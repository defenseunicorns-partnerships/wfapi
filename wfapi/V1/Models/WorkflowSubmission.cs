using System.ComponentModel.DataAnnotations;

namespace wfapi.V1.Models;

/// <summary>
/// WorkflowSubmission model
/// </summary>
public class WorkflowSubmission
{
    /// <summary>
    /// Name of the WorkflowTemplate to use
    /// </summary>
    [Required]
    public required string TemplateName { get; set; }

    /// <summary>
    /// Name prefix for the generated workflow. The actual name will be the prefix followed by a random string
    /// </summary>
    [Required]
    public required string GenerateName { get; set; }

    /// <summary>
    /// Parameters for the WorkflowTemplate
    /// </summary>
    public List<WorkflowParameter>? Parameters { get; set; }
}
