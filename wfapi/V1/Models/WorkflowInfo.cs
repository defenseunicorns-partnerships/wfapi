using System.ComponentModel.DataAnnotations;
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
    public required string Name { get; set; }

    /// <summary>
    /// Status of the workflow
    /// </summary>
    [Required]
    public required WorkflowStatus Status { get; set; }

    /// <summary>
    /// Status message
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// DateTime the workflow was created
    /// </summary>
    [Required]
    public required DateTime Created { get; set; }

    /// <summary>
    /// DateTime the workflow was started
    /// </summary>
    public DateTime? Started { get; set; }

    /// <summary>
    /// Datetime the workflow was finished
    /// </summary>
    public DateTime? Finished { get; set; }

    /// <summary>
    /// Time it took to finish the workflow in seconds
    /// </summary>
    public int? Duration { get; set; }

    /// <summary>
    /// Number of tasks in the workflow that have been completed
    /// </summary>
    public int? CompletedTasks { get; set; }

    /// <summary>
    /// Total number of tasks in the workflow
    /// </summary>
    public int? TotalTasks { get; set; }
}
