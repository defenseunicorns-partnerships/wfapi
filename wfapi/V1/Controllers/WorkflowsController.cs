using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using wfapi.V1.Models;

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
