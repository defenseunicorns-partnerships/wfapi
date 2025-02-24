using System.Net.Mime;
using System.Web;
using System.Security.Claims;
using Amazon.S3;
using Amazon.S3.Model;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Org.OpenAPITools.Client;
using Swashbuckle.AspNetCore.Annotations;
using wfapi.V1.Models;
using Org.OpenAPITools.Model;
using System.Threading.Tasks;

namespace wfapi.V1.Controllers;

/// <summary>
/// Workflows controller for the Workflow API.
/// </summary>
[ApiController]
[Authorize]
[ApiVersion(1.0)]
[Route("api/v{version:apiVersion}/workflows")]
[Tags("Workflows")]
public class WorkflowsController(ArgoClient argoClient, S3Client s3Client, ClientCredentials OidcClient, ILogger<WorkflowsController> log) : ControllerBase
{

    private const string FilesPrefix = "files/";

    /// <summary>
    /// Get a list of all files present and ready to be consumed by a workflow.
    /// </summary>
    /// <param name="cancellationToken"></param>
    [HttpGet("files")]
    [SwaggerResponse(
        StatusCodes.Status200OK,
        "Success. The list of files is returned.",
        typeof(List<WfapiFileInfo>),
        MediaTypeNames.Application.Json
    )]
    [SwaggerOperation(OperationId = "GetFiles")]
    public async Task<IActionResult> GetFiles(CancellationToken cancellationToken)
    {
        string ClientPrefix = PrefixBuilder.New(User.Claims, FilesPrefix);
        log.LogInformation($"Attempting to list files with Client prefix: {ClientPrefix}");

        var objects = await s3Client.Client.ListObjectsV2Async(new ListObjectsV2Request
        {
            BucketName = s3Client.BucketName,
            Prefix = ClientPrefix
        }, cancellationToken: cancellationToken);
        var files = objects.S3Objects.Select(o => new WfapiFileInfo { FileName = o.Key }).ToList();
        return Ok(files);
    }

    /// <summary>
    /// Download a file that was previously uploaded
    /// </summary>
    /// <param name="fullFileName"></param>
    /// <param name="cancellationToken"></param>
    [HttpGet("files/{fullFileName}")]
    [SwaggerResponse(
        StatusCodes.Status200OK,
        "Success. The file is returned.",
        typeof(FileStreamResult),
        MediaTypeNames.Application.Octet
    )]
    [SwaggerResponse(
        StatusCodes.Status404NotFound,
        "The requested file was not found."
    )]
    [SwaggerResponse(
        StatusCodes.Status403Forbidden,
        "You don't have permission to download that file."
    )]
    [SwaggerOperation(OperationId = "DownloadFile")]
    public async Task<IActionResult> DownloadFile(string fullFileName, CancellationToken cancellationToken)
    {
        fullFileName = HttpUtility.UrlDecode(fullFileName);
        string ClientPrefix = PrefixBuilder.New(User.Claims, FilesPrefix);
        log.LogInformation($"Attempting to download key {fullFileName} with Client prefix: {ClientPrefix}");
        if (fullFileName.StartsWith("/")) fullFileName = fullFileName.Substring(1);
        if (! fullFileName.StartsWith(ClientPrefix)) {
            log.LogWarning($"Client tried to download S3 Key {fullFileName} with ClientPrefix={ClientPrefix}");
            return Forbid();
        }
        var objects = await s3Client.Client.ListObjectsV2Async(new ListObjectsV2Request()
        {
            BucketName = s3Client.BucketName,
            Prefix = fullFileName
        }, cancellationToken: cancellationToken);
        if (objects.S3Objects.Count == 0)
        {
            return NotFound();
        }
        var response = await s3Client.Client.GetObjectStreamAsync(s3Client.BucketName, fullFileName, null, cancellationToken);
        return new FileStreamResult(response, MediaTypeNames.Application.Octet)
        {
            FileDownloadName = Path.GetFileName(fullFileName)
        };
    }

    /// <summary>
    /// Upload a file to be used in a workflow. The response contains the fully qualified filename that you can use in the workflow.
    /// </summary>
    /// <param name="fileName">The file name</param>
    /// <param name="file">The file</param>
    /// <param name="cancellationToken"></param>
    [HttpPost("files")]
    [SwaggerResponse(
        StatusCodes.Status200OK,
        "Success. The file has been uploaded.",
        typeof(WfapiFileInfo),
        "application/json"
    )]
    [SwaggerResponse(
        StatusCodes.Status409Conflict,
        "A file with the same name already exists."
    )]
    [SwaggerOperation(OperationId = "UploadFile")]
    [Consumes(MediaTypeNames.Multipart.FormData)]
    public async Task<IActionResult> UploadFile([FromForm] string fileName, IFormFile file, CancellationToken cancellationToken)
    {
        string ClientPrefix = PrefixBuilder.New(User.Claims, FilesPrefix);
        var key = $"{ClientPrefix}{fileName}";
        log.LogInformation($"Attempting to upload file key {key} with Client Prefix {ClientPrefix}");

        // Upload the file
        await using var stream = file.OpenReadStream();
        await s3Client.Client.UploadObjectFromStreamAsync(s3Client.BucketName, key, stream, null, cancellationToken: cancellationToken);

        return Ok(new WfapiFileInfo { FileName = key });
    }


    /// <summary>
    /// Delete a file that was previously uploaded
    /// </summary>
    /// <param name="fullFileName">The fully qualified filename to be deleted. Example: "files/myfile.txt". Must be URLEncoded though, so that would actually be "files%2Fmyfile.txt"</param>
    /// <param name="cancellationToken"></param>
    [HttpDelete("files/{fullFileName}")]
    [SwaggerResponse(
        StatusCodes.Status204NoContent,
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
    [SwaggerOperation(OperationId = "DeleteFile")]
    public async Task<IActionResult> DeleteFile([FromRoute] string fullFileName, CancellationToken cancellationToken)
    {
        fullFileName = HttpUtility.UrlDecode(fullFileName);
        string ClientPrefix = PrefixBuilder.New(User.Claims, FilesPrefix);
        log.LogInformation($"Attempting to delete key {fullFileName} with Client prefix: {ClientPrefix}");
        if (fullFileName.StartsWith("/")) fullFileName = fullFileName.Substring(1);
        if (! fullFileName.StartsWith(ClientPrefix)) {
            log.LogWarning($"Client tried to download S3 Key {fullFileName} with ClientPrefix={ClientPrefix}");
            return Forbid();
        }
        try
        {
            var objects = await s3Client.Client.ListObjectsV2Async(new ListObjectsV2Request()
            {
                BucketName = s3Client.BucketName,
                Prefix = fullFileName
            }, cancellationToken: cancellationToken);
            if (objects.S3Objects.Count == 0)
            {
                return NotFound();
            }
            var response = await s3Client.Client.DeleteObjectAsync(s3Client.BucketName, fullFileName, cancellationToken);
            return NoContent();
        }
        catch (AmazonS3Exception e)
        {
            if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return NotFound();
            }
            if (e.StatusCode == System.Net.HttpStatusCode.Forbidden)
            {
                return Forbid();
            }
            throw;
        }
    }

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
    ),
    SwaggerResponse(
         StatusCodes.Status403Forbidden,
         "You don't have permission to reference that workflowTemplate."
     )]
    [SwaggerOperation(OperationId = "SubmitWorkflow")]
    [Consumes(MediaTypeNames.Application.Json)]
    public async Task<IActionResult> SubmitWorkflow([FromBody] WorkflowSubmission submission)
    {
        string template = submission.TemplateName;
        string ClientWorkflowPrefix = PrefixBuilder.New(User.Claims, null);
        log.LogInformation($"Attempting to create workflow with template {template} and client {ClientWorkflowPrefix}");
        if ( ClientWorkflowPrefix != "" && !template.StartsWith(ClientWorkflowPrefix)) {
            log.LogWarning($"WorkflowTemplate and Client mismatch: {template} != {ClientWorkflowPrefix}");
            return Forbid();
        }
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
        foreach (var parameter in submission.Parameters ?? [])
        {
            body.SubmitOptions.Parameters.Add(parameter.Name + "=" + parameter.Value);
        }

        var authHeader = await OidcClient.GetClientCredentialToken();
        var submitResult = argoClient.WorkflowServiceApi.WorkflowServiceSubmitWorkflow(argoClient.Namespace, body, authHeader);
        var getResult = argoClient.WorkflowServiceApi.WorkflowServiceGetWorkflow(argoClient.Namespace, submitResult.Metadata.Name, authHeader);
        // Initialize the start time for timeout
        var startTime = DateTime.Now;
        var timeout = TimeSpan.FromSeconds(2);
        // Loop until the status phase is not null or timeout is reached
        while (string.IsNullOrWhiteSpace(getResult.Status.Phase) && (DateTime.Now - startTime) < timeout)
        {
            // Wait for 50 milliseconds
            Thread.Sleep(50);

            // Fetch the workflow status again
            getResult = argoClient.WorkflowServiceApi.WorkflowServiceGetWorkflow(argoClient.Namespace, submitResult.Metadata.Name, authHeader);
        }
        if (string.IsNullOrWhiteSpace(getResult.Status.Phase))
        {
            // Handle the timeout scenario
            throw new TimeoutException("Timeout occurred while waiting for the workflow status phase to be populated.");
        }
        var retval = new WorkflowInfo
        {
            Created = getResult.Metadata.CreationTimestamp ?? throw new ArgumentNullException(nameof(getResult.Metadata.CreationTimestamp), "Mandatory parameter"),
            Name = getResult.Metadata.Name,
            Uid = getResult.Metadata.Uid,
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
    public async Task<IActionResult> GetWorkflowInfo(string workflowName)
    {

        string authHeader = await OidcClient.GetClientCredentialToken();
        IoArgoprojWorkflowV1alpha1Workflow getResult;
        try
        {
            getResult = argoClient.WorkflowServiceApi.WorkflowServiceGetWorkflow(argoClient.Namespace, workflowName, authHeader);
        }
        catch (ApiException e)
        {
            if (e.ErrorCode == 404)
            {
                return NotFound();
            }
            throw;
        }
        var retval = new WorkflowInfo
        {
            Created = getResult.Metadata.CreationTimestamp ?? throw new ArgumentNullException(nameof(getResult.Metadata.CreationTimestamp), "Mandatory parameter"),
            Name = getResult.Metadata.Name,
            Uid = getResult.Metadata.Uid,
            Status = (WorkflowStatus)Enum.Parse(typeof(WorkflowStatus), getResult.Status.Phase),
            Message = getResult.Status.Message,
            Started = getResult.Status.StartedAt,
            Finished = getResult.Status.FinishedAt,
            Progress = getResult.Status.Progress
        };
        return Ok(retval);
    }

    /// <summary>
    /// Get the log stream of a workflow as an NDJSON stream using SSE. If the workflow is active in the cluster it will stream the logs from there. If it isn't, it will look for the logs in the archive.
    /// </summary>
    /// <param name="workflowName">The name of the workflow that you want the log(s) for</param>
    /// <param name="podName">The name of the pod that you want the log(s) for. If the workflow only had one template than the podname will be the same as the workflow name</param>
    /// <param name="cancellationToken"></param>
    [HttpGet("{workflowName}/pods/{podName}/logstream")]
    [SwaggerResponse(
        StatusCodes.Status200OK,
        "Success. The workflow log is returned as an NDJSON stream using SSE.",
        typeof(StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry),
        "application/x-ndjson"
    )]
    [SwaggerResponse(
        StatusCodes.Status404NotFound,
        "The requested workflow was not found."
    )]
    [SwaggerOperation(OperationId = "GetWorkflowLogStream")]
    public async Task GetWorkflowLogStream(string workflowName, string podName, CancellationToken cancellationToken)
    {
        Response.Headers.ContentType = "application/x-ndjson";
        Response.Headers.CacheControl = "no-cache";
        // Istio strips the connection header, so adding this doesn't do anything useful.
        // Response.Headers.Connection = "keep-alive";

        // If the workflow is still active, we'll get the log stream from the active pod
        try
        {
            await foreach (var logEntry in argoClient.WorkflowServiceSseApiAsync.WorkflowServiceWorkflowLogsAsync(
                               varNamespace: argoClient.Namespace,
                               name: workflowName,
                               podName: podName,
                               logOptionsContainer: "main",
                               logOptionsFollow: true,
                               cancellationToken: cancellationToken
                           ))
            {
                // log.LogInformation(JsonConvert.SerializeObject(logEntry));
                await Response.WriteAsync(JsonConvert.SerializeObject(logEntry), cancellationToken: cancellationToken);
                await Response.WriteAsync("\n", cancellationToken: cancellationToken);
                await Response.Body.FlushAsync(cancellationToken);
            }
        }
        catch (ApiException e)
        {
            if (e.ErrorCode == 404)
            {
                // If the workflow is not found, it might be in the archive. We'll try to get the logs from there.
                try
                {
                    var workflow = await argoClient.WorkflowServiceApi.WorkflowServiceGetWorkflowAsync(
                        argoClient.Namespace, workflowName,
                        cancellationToken: cancellationToken);
                    var logFile = await argoClient.ArtifactServiceApi.ArtifactServiceGetArtifactFileAsync(argoClient.Namespace,
                        "archived-workflows", workflow.Metadata.Uid, podName, "main-logs", "outputs",
                        cancellationToken: cancellationToken);
                    using var reader = new StreamReader(logFile.Content);
                    while (!reader.EndOfStream && !cancellationToken.IsCancellationRequested)
                    {
                        var line = await reader.ReadLineAsync(cancellationToken).ConfigureAwait(false);
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        var streamResultLogEntry =
                            new StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry(
                                result: new IoArgoprojWorkflowV1alpha1LogEntry(line, podName));
                        await Response.WriteAsync(JsonConvert.SerializeObject(streamResultLogEntry), cancellationToken);
                        await Response.WriteAsync("\n", cancellationToken);
                        await Response.Body.FlushAsync(cancellationToken);
                    }
                }
                catch (ApiException e2)
                {
                    if (e2.ErrorCode != 404) throw;
                    // If the workflow is still not found, we'll return a 404
                    Response.StatusCode = 404;
                }
            }
            else
            {
                throw;
            }
        }
    }
}
