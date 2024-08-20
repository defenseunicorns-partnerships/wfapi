// ReSharper disable UnusedMember.Global

using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace wfapi.V1.Models;

/// <summary>
/// The response object for the UploadFile method in the WorkflowsController
/// </summary>
public class WfapiFileInfo
{
    /// <summary>
    /// The fully qualified filename that you can use in the workflow
    /// </summary>
    [Required]
    [JsonProperty("fileName")]
    public required string FileName { get; set; }
}
