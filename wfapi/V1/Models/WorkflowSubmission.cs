using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

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
    [JsonProperty("templateName")]
    public required string TemplateName { get; set; }

    /// <summary>
    /// Name prefix for the generated workflow. The actual name will be the prefix followed by a random string
    /// </summary>
    [Required]
    [JsonProperty("generateName")]
    public required string GenerateName { get; set; }

    /// <summary>
    /// Parameters for the WorkflowTemplate
    /// </summary>
    [JsonProperty("parameters")]
    public List<WorkflowParameter>? Parameters { get; set; }
}
