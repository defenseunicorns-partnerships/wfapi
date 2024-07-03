using System.ComponentModel.DataAnnotations;
// ReSharper disable ClassNeverInstantiated.Global

namespace wfapi.V1.Models;

/// <summary>
/// WorkflowParameter model
/// </summary>
public class WorkflowParameter
{
    /// <summary>
    /// Parameter name
    /// </summary>
    [Required]
    public required string Name { get; set; }

    /// <summary>
    /// Parameter value
    /// </summary>
    [Required]
    public required string Value { get; set; }
}
