using System.Text;
using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace wfapi;

/// <summary>
/// Represents the Swagger/Swashbuckle configuration options.
/// </summary>
public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
{
    private readonly IApiVersionDescriptionProvider _provider;

    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigureSwaggerOptions"/> class.
    /// </summary>
    /// <param name="provider">The <see cref="IApiVersionDescriptionProvider">provider</see> used to generate Swagger documents.</param>
    public ConfigureSwaggerOptions( IApiVersionDescriptionProvider provider ) => this._provider = provider;

    /// <inheritdoc />
    public void Configure( SwaggerGenOptions options )
    {
        // add a swagger document for each discovered API version
        // note: you might choose to skip or document deprecated API versions differently
        foreach ( var description in _provider.ApiVersionDescriptions )
        {
            options.SwaggerDoc( description.GroupName, CreateInfoForApiVersion( description ) );
        }
    }

    private static OpenApiInfo CreateInfoForApiVersion( ApiVersionDescription description )
    {
        var text = new StringBuilder( "WFAPI." );
        var info = new OpenApiInfo()
        {
            Title = "WFAPI",
            Version = "0.0.8", // x-release-please-version
            Contact = new OpenApiContact() { Name = "Defense Unicorns", Email = "navy@defenseunicorns.com" },
        };

        if ( description.IsDeprecated )
        {
            text.Append( " This API version has been deprecated." );
        }

        if ( description.SunsetPolicy is { } policy )
        {
            if ( policy.Date is { } when )
            {
                text.Append( " The API will be sunset on " )
                    .Append( when.Date.ToShortDateString() )
                    .Append( '.' );
            }

            if ( policy.HasLinks )
            {
                text.AppendLine();

                var rendered = false;

                for ( var i = 0; i < policy.Links.Count; i++ )
                {
                    var link = policy.Links[i];

                    if ( link.Type == "text/html" )
                    {
                        if ( !rendered )
                        {
                            text.Append( "<h4>Links</h4><ul>" );
                            rendered = true;
                        }

                        text.Append( "<li><a href=\"" );
                        text.Append( link.LinkTarget.OriginalString );
                        text.Append( "\">" );
                        text.Append(
                            StringSegment.IsNullOrEmpty( link.Title )
                            ? link.LinkTarget.OriginalString
                            : link.Title.ToString() );
                        text.Append( "</a></li>" );
                    }
                }

                if ( rendered )
                {
                    text.Append( "</ul>" );
                }
            }
        }

        text.Append( "<h4>Additional Information</h4>" );
        info.Description = text.ToString();

        return info;
    }
}
