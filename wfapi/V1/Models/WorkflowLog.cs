using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global

namespace wfapi.V1.Models;

/// <summary>
/// WorkflowLog model
/// </summary>
public class WorkflowLog
{
    /// <summary>
    /// Pod name
    /// </summary>
    [Required]
    [JsonProperty("podName")]
    public required string PodName { get; set; }

    /// <summary>
    /// Log content
    /// </summary>
    [Required]
    [JsonProperty("content")]
    public required string Content { get; set; }
}
