using System.Security.Claims;
using Amazon;
using Amazon.Extensions.NETCore.Setup;
using Amazon.Internal;
using Amazon.Runtime;
using Amazon.S3;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;
using Microsoft.IdentityModel.Client;
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
    string jwt_auds = builder.Configuration.GetValue<string>("Auth:Jwt:Audience");
    Log.Information($"Audiences: {jwt_auds}");
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
                ValidAudiences = jwt_auds.Split(";"),
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
            options.RequireHttpsMetadata = builder.Configuration.GetValue<bool>("Auth:Jwt:RequireHttpsMetadata");
            options.Events = new JwtBearerEvents
            {
                OnTokenValidated = context =>
                {
                    if (context.Principal?.Identity is not ClaimsIdentity claimsIdentity) return Task.CompletedTask;

                    // THIS IS THE PART TO CHANGE
                    // We've seen Keycloak put roles in the `resource_access` claim. It scopes them to the ClientID.
                    // We've also seen JWTs without roles, but with a `groups` block. We can use that instead, we'll just need to update this code block.
                    var client_id = claimsIdentity.FindFirst("client_id")?.Value ?? null;
                    // ^^^^^^^^^ CHANGE THIS STUFF ^^^^^^^^^

                    if (client_id == null) return Task.CompletedTask;
                    else
                    {
                        claimsIdentity.AddClaim(new Claim(claimsIdentity.RoleClaimType, client_id));
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
        IdentityPath = builder.Configuration.GetValue<string>("Auth:Jwt:Token");
        ClientId = builder.Configuration.GetValue<string>("clientId");
        ClientSecret = builder.configuration.GetValue<string>("secret");
    };
    var token = builder.Configuration.GetValue<string>("Argo:Token");
    if (String.IsNullOrWhiteSpace(token))
    {
        token = File.ReadAllText("/var/run/secrets/kubernetes.io/serviceaccount/token");
        Log.Information("Using service account token from file");
    }
    else
    {
        Log.Information("Using token from configuration");
    }
    //argoConfig.AddApiKey("Authorization", token);
    //argoConfig.AddApiKeyPrefix("Authorization", "Bearer");
    var varNamespace = builder.Configuration.GetValue<string>("Argo:Namespace") ?? throw new InvalidOperationException();
    builder.Services.AddSingleton(new ArgoClient(varNamespace, argoConfig));

    // Object Storage setup. Officially supported object storage providers are AWS S3 and MinIO.
    var bucketRegion = builder.Configuration.GetValue<string>("Bucket:Region") ?? throw new InvalidOperationException();
    var bucketServiceUrl = builder.Configuration.GetValue<string>("Bucket:ServiceUrl") ?? throw new InvalidOperationException();
    var bucketName = builder.Configuration.GetValue<string>("Bucket:Name") ?? throw new InvalidOperationException();
    builder.Services.AddSingleton(
        new S3Client(
            bucketName,
            new AmazonS3Client(
                FallbackCredentialsFactory.GetCredentials(),
                new AmazonS3Config
                {
                    ServiceURL = bucketServiceUrl,
                    AuthenticationRegion = bucketRegion,
                    ForcePathStyle = true
                }
            )
        )
    );

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
