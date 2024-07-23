using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using wfapi.V1.Models;
using Org.OpenAPITools.Model;

namespace wfapi.V1.Controllers;

/// <summary>
/// Workflows controller for the Workflow API
/// </summary>
[ApiController]
[Authorize]
[ApiVersion(1.0)]
[Route("api/v{version:apiVersion}/workflows")]
[Tags("Workflows")]
public class WorkflowsController(ArgoClient argoClient, ILogger<WorkflowsController> log) : ControllerBase
{
    /// <summary>
    /// Submit a workflow by providing the template to use and the parameters to use with it.
    /// </summary>
    /// <param name="submission">The input information</param>
    /// <exception cref="ArgumentNullException"></exception>
    [HttpPost("")]
    [SwaggerResponse(
        StatusCodes.Status200OK,
        "Success. The workflow has been submitted. The output is the WorkflowInfo object that you can also query for at any time.",
        typeof(WorkflowInfo),
        "application/json"
    )]
    [SwaggerOperation(OperationId = "SubmitWorkflow")]
    public IActionResult SubmitWorkflow([FromBody] WorkflowSubmission submission)
    {
        var body = new IoArgoprojWorkflowV1alpha1WorkflowSubmitRequest
        {
            ResourceKind = "WorkflowTemplate",
            ResourceName = submission.TemplateName,
            SubmitOptions = new IoArgoprojWorkflowV1alpha1SubmitOpts
            {
                GenerateName = submission.GenerateName,
                Parameters = []
            }
        };
        foreach (var parameter in submission.Parameters)
        {
            body.SubmitOptions.Parameters.Add(parameter.Name + "=" + parameter.Value);
        }
        var submitResult = argoClient.WorkflowServiceApi.WorkflowServiceSubmitWorkflow(argoClient.Namespace, body);
        Thread.Sleep(1000);
        var getResult = argoClient.WorkflowServiceApi.WorkflowServiceGetWorkflow(argoClient.Namespace, submitResult.Metadata.Name);
        log.LogInformation(JsonConvert.SerializeObject(getResult));
        var retval = new WorkflowInfo
        {
            Created = getResult.Metadata.CreationTimestamp ?? throw new ArgumentNullException(nameof(getResult.Metadata.CreationTimestamp), "Mandatory parameter"),
            Name = getResult.Metadata.Name,
            Status = (WorkflowStatus)Enum.Parse(typeof(WorkflowStatus), getResult.Status.Phase),
            Message = getResult.Status.Message,
            Started = getResult.Status.StartedAt,
            Finished = getResult.Status.FinishedAt,
            Progress = getResult.Status.Progress
        };
        return Ok(retval);
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
    [SwaggerOperation(OperationId = "GetWorkflowInfo")]
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
    [SwaggerOperation(OperationId = "GetWorkflowLog")]
    public IActionResult GetWorkflowLog(string workflowName)
    {
        throw new NotImplementedException();
    }
}
