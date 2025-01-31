using System.Text.RegularExpressions;

namespace wfapi;

/// <summary>
/// Slugify parameter transformer for ASP.NET Core routing.
/// </summary>
public class SlugifyParameterTransformer : IOutboundParameterTransformer
{
    /// <inheritdoc />
    public string? TransformOutbound(object? value)
    {
        // Slugify value
        return value == null ? null : Regex.Replace(value.ToString()!, "([a-z])([A-Z])", "$1-$2").ToLower();
    }
}
