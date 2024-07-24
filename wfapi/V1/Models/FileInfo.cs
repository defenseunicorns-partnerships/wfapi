// ReSharper disable UnusedMember.Global

using System.ComponentModel.DataAnnotations;

namespace wfapi.V1.Models;

/// <summary>
/// The response object for the UploadFile method in the WorkflowsController
/// </summary>
public class FileInfo
{
    /// <summary>
    /// The fully qualified filename that you can use in the workflow
    /// </summary>
    [Required]
    public required string FileName { get; set; }
}
