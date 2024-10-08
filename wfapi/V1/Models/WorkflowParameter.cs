using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

// ReSharper disable ClassNeverInstantiated.Global

namespace wfapi.V1.Models;

/// <summary>
/// WorkflowParameter model
/// </summary>
public class WorkflowParameter
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="value"></param>
    [SetsRequiredMembers]
    public WorkflowParameter(string name, string value)
    {
        Name = name;
        Value = value;
    }

    /// <summary>
    /// Parameter name
    /// </summary>
    [Required]
    [JsonProperty("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Parameter value
    /// </summary>
    [Required]
    [JsonProperty("value")]
    public required string Value { get; set; }
}
