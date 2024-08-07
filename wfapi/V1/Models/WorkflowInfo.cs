using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

// ReSharper disable UnusedMember.Global

namespace wfapi.V1.Models;

/// <summary>
/// WorkflowInfo model
/// </summary>
public class WorkflowInfo
{
    /// <summary>
    /// Unique workflow name
    /// </summary>
    [Required]
    [JsonProperty("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Unique workflow ID
    /// </summary>
    [Required]
    [JsonProperty("uid")]
    public required string Uid { get; set; }

    /// <summary>
    /// Status of the workflow
    /// </summary>
    [Required]
    [JsonProperty("status")]
    public required WorkflowStatus Status { get; set; }

    /// <summary>
    /// Status message
    /// </summary>
    [JsonProperty("message")]
    public string? Message { get; set; }

    /// <summary>
    /// DateTime the workflow was created
    /// </summary>
    [Required]
    [JsonProperty("created")]
    public required DateTime Created { get; set; }

    /// <summary>
    /// DateTime the workflow was started
    /// </summary>
    [JsonProperty("started")]
    public DateTime? Started { get; set; }

    /// <summary>
    /// Datetime the workflow was finished
    /// </summary>
    [JsonProperty("finished")]
    public DateTime? Finished { get; set; }

    /// <summary>
    /// Time it took to finish the workflow in seconds
    /// </summary>
    [JsonProperty("duration")]
    public int? Duration
    {
        get
        {
            if (Started.HasValue && Finished.HasValue)
            {
                return (int)(Finished.Value - Started.Value).TotalSeconds;
            }
            return null;
        }
    }

    /// <summary>
    /// Progress of the workflow in the format of "X/Y" where X is the number of tasks completed and Y is the total number of tasks
    /// </summary>
    [JsonProperty("progress")]
    public string? Progress { get; set; }
}
