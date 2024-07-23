using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Serilog;
using Serilog.Templates;
using Serilog.Templates.Themes;
using Swashbuckle.AspNetCore.SwaggerGen;
using wfapi;

// Logging
// The initial "bootstrap" logger is able to log errors during start-up. It's completely replaced by the
// logger configured in `AddSerilog()` below, once configuration and dependency-injection have both been
// set up successfully.
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();
Log.Information("Starting web application");

try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddSerilog((services, lc) => lc
        .ReadFrom.Configuration(builder.Configuration)
        .ReadFrom.Services(services)
        .Enrich.FromLogContext()
        .Filter.ByExcluding("RequestPath = '/healthz'")
        .WriteTo.Console(new ExpressionTemplate(
            // Include trace and span ids when present.
            "[{@t:HH:mm:ss} {@l:u3}{#if @tr is not null} ({substring(@tr,0,4)}:{substring(@sp,0,4)}){#end}] {@m}\n{@x}",
            theme: TemplateTheme.Code)));

    // Add services to the container.
    builder.Services.AddControllers(options =>
    {
        options.Conventions.Add(new RouteTokenTransformerConvention(new SlugifyParameterTransformer()));
    }).AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.Converters.Add(new StringEnumConverter());
    });
    builder.Services.AddSwaggerGenNewtonsoftSupport();
    builder.Services.AddProblemDetails();
    builder.Services.AddApiVersioning(options =>
        {
            options.ReportApiVersions = true;
        })
        .AddMvc()
        .AddApiExplorer(options =>
        {
            options.GroupNameFormat = "'v'VVV";
            options.SubstituteApiVersionInUrl = true;
        });
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
    builder.Services.AddSwaggerGen(options =>
    {
        var fileName = typeof( Program ).Assembly.GetName().Name + ".xml";
        var filePath = Path.Combine( AppContext.BaseDirectory, fileName );

        options.IncludeXmlComments( filePath );
        options.EnableAnnotations();
    });

    // SSO
    builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = builder.Configuration.GetValue<bool>("Auth:Jwt:ValidateIssuer"),
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = builder.Configuration.GetValue<string>("Auth:Jwt:Authority"),
                ValidAudience = builder.Configuration.GetValue<string>("Auth:Jwt:Audience"),
                IssuerSigningKeyResolver = (_, _, _, _) =>
                {
                    var configurationManager = new ConfigurationManager<OpenIdConnectConfiguration>(
                        builder.Configuration.GetValue<string>("Auth:Jwt:WellKnownConfig"),
                        new OpenIdConnectConfigurationRetriever(),
                        new HttpDocumentRetriever{RequireHttps = false});
                    var discoveryDocument = configurationManager.GetConfigurationAsync().Result;
                    var signingKeys = discoveryDocument.SigningKeys;
                    return signingKeys;
                },
                RoleClaimType = "roles"

            };
            options.Authority = builder.Configuration.GetValue<string>("Auth:Jwt:Authority");
            options.Audience = builder.Configuration.GetValue<string>("Auth:Jwt:Audience");
            options.RequireHttpsMetadata = builder.Configuration.GetValue<bool>("Auth:Jwt:RequireHttpsMetadata");
            options.Events = new JwtBearerEvents
            {
                OnTokenValidated = context =>
                {
                    if (context.Principal?.Identity is not ClaimsIdentity claimsIdentity) return Task.CompletedTask;

                    // THIS IS THE PART TO CHANGE
                    // We've seen Keycloak put roles in the `resource_access` claim. It scopes them to the ClientID.
                    // We've also seen JWTs without roles, but with a `groups` block. We can use that instead, we'll just need to update this code block.
                    var resourceAccess = JObject.Parse(claimsIdentity.FindFirst("resource_access")?.Value ?? "{}");
                    var roles = resourceAccess[builder.Configuration.GetValue<string>("Auth:Jwt:Audience")!]?["roles"]?.ToObject<List<string>>();
                    // ^^^^^^^^^ CHANGE THIS STUFF ^^^^^^^^^

                    if (roles == null) return Task.CompletedTask;
                    foreach (var role in roles)
                    {
                        claimsIdentity.AddClaim(new Claim(claimsIdentity.RoleClaimType, role));
                    }
                    return Task.CompletedTask;
                }
            };
        });
    // Skip authn/authz if we are in Development mode
    if (builder.Environment.IsDevelopment())
    {
        builder.Services.AddSingleton<IAuthorizationHandler, AllowAnonymousAuthorizationHandler>();
    }

    builder.Services.AddHealthChecks();

    // Add the Argo API client
    var argoConfig = new Configuration
    {
        BasePath = builder.Configuration.GetValue<string>("Argo:ApiUrl") ?? throw new InvalidOperationException()
    };
    var token = builder.Configuration.GetValue<string>("Argo:Token");
    if (token == null)
    {
        token = File.ReadAllText("/var/run/secrets/kubernetes.io/serviceaccount/token");
        Log.Information("Using service account token from file");
    }
    else
    {
        Log.Information("Using token from configuration");
    }
    argoConfig.AddApiKey("Authorization", token);
    argoConfig.AddApiKeyPrefix("Authorization", "Bearer");
    var varNamespace = builder.Configuration.GetValue<string>("Argo:Namespace") ?? throw new InvalidOperationException();
    builder.Services.AddSingleton(new ArgoClient(varNamespace, argoConfig));

    var app = builder.Build();

    app.UseSwagger();
    if (builder.Configuration.GetValue<bool>("Swagger:Enable"))
    {
        app.UseSwaggerUI(options =>
        {
            var descriptions = app.DescribeApiVersions();
            foreach (var description in descriptions)
            {
                var url = $"/swagger/{description.GroupName}/swagger.json";
                var name = description.GroupName.ToUpperInvariant();
                options.SwaggerEndpoint(url, name);
            }
        });
    }

    app.UseSerilogRequestLogging();

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();
    app.MapHealthChecks("/healthz");

    app.UseStaticFiles();

    await app.RunAsync();

    Log.Information("Stopped cleanly");
    return 0;
}
catch (Exception e)
{
    Log.Fatal(e, "Application terminated unexpectedly");
    return 1;
}
finally
{
    Log.CloseAndFlush();
}
