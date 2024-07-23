using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using wfapi.V1.Models;
using FileInfo = wfapi.V1.Models.FileInfo;

namespace wfapi.V1.Controllers;

/// <summary>
/// Workflows controller for the Workflow API
/// </summary>
[ApiController]
[Authorize]
[ApiVersion(1.0)]
[Route("api/v{version:apiVersion}/workflows")]
[Tags("Workflows")]
public class WorkflowsController : ControllerBase
{
    /// <summary>
    /// Get a list of all files present and ready to be consumed by a workflow.
    /// </summary>
    [HttpGet("files")]
    [SwaggerResponse(
        StatusCodes.Status200OK,
        "Success. The list of files is returned.",
        typeof(List<FileInfo>),
        "application/json"
    )]
    public IActionResult GetFiles()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Upload a file to be used in a workflow. The response contains the fully qualified filename that you can use in the workflow.
    /// </summary>
    /// <param name="fileName">The file name</param>
    /// <param name="file">The file</param>
    [HttpPost("files")]
    [SwaggerResponse(
        StatusCodes.Status200OK,
        "Success. The file has been uploaded.",
        typeof(FileInfo),
        "application/json"
    )]
    public IActionResult UploadFile([FromForm] string fileName, IFormFile file)
    {
        throw new NotImplementedException();
    }


    /// <summary>
    /// Delete a file that was previously uploaded
    /// </summary>
    /// <param name="fileName">The fully qualified filename to be deleted. Example: "theuser/myfile.txt"</param>
    [HttpDelete("files/{fileName}")]
    [SwaggerResponse(
        StatusCodes.Status200OK,
        "Success. The file has been deleted."
    ),
     SwaggerResponse(
         StatusCodes.Status404NotFound,
         "The requested file was not found."
     ),
     SwaggerResponse(
         StatusCodes.Status403Forbidden,
         "You don't have permission to delete that file."
     )]
    public IActionResult DeleteFile([FromRoute] string fileName)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Submit a workflow by providing the template to use and the parameters to use with it.
    /// </summary>
    /// <param name="submission">The input information</param>
    [HttpPost("submit")]
    [SwaggerResponse(
        StatusCodes.Status200OK,
        "Success. The workflow has been submitted. The output is the WorkflowInfo object that you can also query for at any time.",
        typeof(WorkflowInfo),
        "application/json"
    )]
    public IActionResult SubmitWorkflow([FromBody] WorkflowSubmission submission)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get the Info object of a workflow that contains the status and other information.
    /// </summary>
    /// <param name="workflowName">The name of the workflow to get</param>
    [HttpGet("{workflowName}")]
    [SwaggerResponse(
        StatusCodes.Status200OK,
        "Success. The workflow status is returned.",
        typeof(WorkflowInfo),
        "application/json"
    )]
    [SwaggerResponse(
         StatusCodes.Status404NotFound,
         "The requested workflow was not found."
     )]
    public IActionResult GetWorkflowInfo(string workflowName)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get the log of a workflow.
    /// </summary>
    /// <param name="workflowName">The name of the workflow that you want the log(s) for</param>
    [HttpGet("{workflowName}/log")]
    [SwaggerResponse(
        StatusCodes.Status200OK,
        "Success. The workflow log is returned.",
        typeof(List<WorkflowLog>),
        "application/json"
    )]
    [SwaggerResponse(
        StatusCodes.Status404NotFound,
        "The requested workflow was not found."
    )]
    public IActionResult GetWorkflowLog(string workflowName)
    {
        throw new NotImplementedException();
    }
}
