using System.ComponentModel.DataAnnotations;
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
    public required string PodName { get; set; }

    /// <summary>
    /// Log content
    /// </summary>
    [Required]
    public required string Content { get; set; }
}
