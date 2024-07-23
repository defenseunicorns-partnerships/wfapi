using System.Diagnostics;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using wfapi.V1.Models;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
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
public class WorkflowsController(ILogger<WorkflowsController> log) : ControllerBase
{
    /// <summary>
    /// Submit a workflow by providing the template to use and the parameters to use with it.
    /// </summary>
    /// <param name="submission">The input information</param>
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
        var token = System.IO.File.ReadAllText("/var/run/secrets/kubernetes.io/serviceaccount/token");
        Configuration config = new Configuration();
        config.BasePath = "http://argo-workflows-server:2746";
        config.AddApiKey("Authorization", token);
        config.AddApiKeyPrefix("Authorization", "Bearer");

        var apiInstance = new WorkflowServiceApi(config);
        var varNamespace = "argo";
        var body = new IoArgoprojWorkflowV1alpha1WorkflowCreateRequest();
        body.Workflow = new IoArgoprojWorkflowV1alpha1Workflow(
            apiVersion: "argoproj.io/v1alpha1",
            kind: "Workflow",
            metadata: new IoK8sApimachineryPkgApisMetaV1ObjectMeta(
                generateName: submission.GenerateName
            ),
            spec: new IoArgoprojWorkflowV1alpha1WorkflowSpec(
                archiveLogs: true,
                workflowTemplateRef: new IoArgoprojWorkflowV1alpha1WorkflowTemplateRef(
                    name: submission.TemplateName
                ),
                podMetadata: new IoArgoprojWorkflowV1alpha1Metadata(
                    annotations: new Dictionary<string, string>()
                    {
                        {
                            "workflows.argoproj.io/kill-cmd-istio-proxy",
                            """["pilot-agent", "request", "POST", "quitquitquit"]"""
                        }
                    }
                ),
                automountServiceAccountToken: true,
                executor: new IoArgoprojWorkflowV1alpha1ExecutorConfig(
                    serviceAccountName: "argo-workflow"
                )
            )
        );
        IoArgoprojWorkflowV1alpha1Workflow result = apiInstance.WorkflowServiceCreateWorkflow(varNamespace, body);
        log.LogDebug(result.ToString());
        var retval = new WorkflowInfo
        {
            Created = result.Metadata.CreationTimestamp,
            Name = result.Metadata.Name,
            Status = (WorkflowStatus)Enum.Parse(typeof(WorkflowStatus), result.Status.Phase),
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
