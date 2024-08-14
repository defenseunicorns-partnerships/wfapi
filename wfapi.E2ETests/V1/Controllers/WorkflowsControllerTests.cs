using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Mime;
using Newtonsoft.Json;
using NHamcrest;
using Org.OpenAPITools.Model;
using RestAssured.Request.Logging;
using wfapi.V1.Models;
using Xunit.Abstractions;
using static RestAssured.Dsl;
using FileInfo = System.IO.FileInfo;

namespace wfapi.E2ETests.V1.Controllers;

public class WorkflowsControllerTests(ITestOutputHelper output)
{
    private const string RootUrl = "https://wfapi.uds.dev";
    private const string TemplateName = "hello-world-template";
    private const string GenerateName = "hello-world-";

    [Fact]
    public void FileManagementEndpoints_WhenCalled_BehavesAsExpected()
    {
        // Create a text file in the temp directory and add "Hello, World!" to it
        var tempFile = Path.GetTempFileName();
        File.WriteAllText(tempFile, "Hello, World!");

        // Upload the file
        try
        {
            Given()
                .Accept(MediaTypeNames.Application.Json)
                .ContentType(MediaTypeNames.Multipart.FormData)
                .MultiPart("fileName", new StringContent("hello.txt"))
                .MultiPart(new FileInfo(tempFile), "file", new MediaTypeHeaderValue(MediaTypeNames.Text.Plain))
                .When()
                .Post($"{RootUrl}/api/v1/workflows/files")
                .Then()
                .StatusCode(HttpStatusCode.OK);
        }
        catch (Exception e)
        {
            output.WriteLine(JsonConvert.SerializeObject(e));
            throw;
        }


        // Upload the file again. Expect a 409 this time
        Given()
            .Accept(MediaTypeNames.Application.Json)
            .ContentType(MediaTypeNames.Multipart.FormData)
            .MultiPart("fileName", new StringContent("hello.txt"))
            .MultiPart(new FileInfo(tempFile), "file", new MediaTypeHeaderValue(MediaTypeNames.Text.Plain))
            .When()
            .Post($"{RootUrl}/api/v1/workflows/files")
            .Then()
            .StatusCode(HttpStatusCode.Conflict);

        // Get files. Expect the file
        var responseBody = Given()
            .Accept(MediaTypeNames.Application.Json)
            .When()
            .Get($"{RootUrl}/api/v1/workflows/files")
            .Then()
            .StatusCode(HttpStatusCode.OK)
            .And()
            .Extract().Body();
        var files = JsonConvert.DeserializeObject<List<WfapiFileInfo>>(responseBody);
        Assert.NotNull(files);
        Assert.Contains(files, file => file.FileName == "files/hello.txt");

        // Delete the file
        Given()
            .Accept(MediaTypeNames.Application.Json)
            .When()
            .Delete($"{RootUrl}/api/v1/workflows/files/files/hello.txt")
            .Then()
            .StatusCode(HttpStatusCode.OK);

        // Get files again. Expect the file to not exist
        responseBody = Given()
            .Accept(MediaTypeNames.Application.Json)
            .When()
            .Get($"{RootUrl}/api/v1/workflows/files")
            .Then()
            .StatusCode(HttpStatusCode.OK)
            .And()
            .Extract().Body();
        files = JsonConvert.DeserializeObject<List<WfapiFileInfo>>(responseBody);
        Assert.NotNull(files);
        Assert.DoesNotContain(files, file => file.FileName == "files/hello.txt");
    }

    [Fact]
    public void SubmitWorkflow_WhenCalled_WithEmptyParameters_ReturnsOk()
    {
        Given()
            .Accept(MediaTypeNames.Application.Json)
            .ContentType(MediaTypeNames.Application.Json)
            .Body(new WorkflowSubmission()
            {
                TemplateName = TemplateName,
                GenerateName = GenerateName,
                Parameters = []
            })
        .When()
            .Post($"{RootUrl}/api/v1/workflows")
        .Then()
            .StatusCode(HttpStatusCode.OK);
    }

    [Fact]
    public void SubmitWorkflow_WhenCalled_WithoutParameters_ReturnsOk()
    {
        Given()
            .Accept(MediaTypeNames.Application.Json)
            .ContentType(MediaTypeNames.Application.Json)
            .Body(new WorkflowSubmission()
            {
                TemplateName = TemplateName,
                GenerateName = GenerateName
            })
            .When()
            .Post($"{RootUrl}/api/v1/workflows")
            .Then()
            .StatusCode(HttpStatusCode.OK);
    }

    [Fact]
    public void GetWorkflow_WhenCalled_ReturnsOk()
    {
        // Submit the workflow
        var workflow = (WorkflowInfo)Given()
            .Accept(MediaTypeNames.Application.Json)
            .ContentType(MediaTypeNames.Application.Json)
            .Body(new WorkflowSubmission()
            {
                TemplateName = TemplateName,
                GenerateName = GenerateName
            })
            .When()
            .Post("https://wfapi.uds.dev/api/v1/workflows/")
            .Then()
            .StatusCode(HttpStatusCode.OK)
            .And()
            .DeserializeTo(typeof(WorkflowInfo));

        // Get the workflow
        Given()
            .Log(RequestLogLevel.All)
            .Accept(MediaTypeNames.Application.Json)
            .ContentType(MediaTypeNames.Application.Json)
            .When()
            .Get($"https://wfapi.uds.dev/api/v1/workflows/{workflow.Name}")
            .Then()
            .StatusCode(HttpStatusCode.OK);
    }

    [Fact]
    public async Task GetWorkflowLogstream_WhenCalledOnRunningPod_ReturnsOkImmediately()
    {
        // Submit the workflow
        var workflow = (WorkflowInfo)Given()
            .Accept(MediaTypeNames.Application.Json)
            .ContentType(MediaTypeNames.Application.Json)
            .Body(new WorkflowSubmission()
            {
                TemplateName = TemplateName,
                GenerateName = GenerateName,
                Parameters = [new WorkflowParameter("waitSeconds", "30")]
            })
            .When()
            .Post($"{RootUrl}/api/v1/workflows/")
            .Then()
            .StatusCode(HttpStatusCode.OK)
            .And()
            .DeserializeTo(typeof(WorkflowInfo));
        output.WriteLine($"Workflow {workflow.Name} submitted");
        await Task.Delay(500);

        // loop until the workflow is running
        Stopwatch sw = Stopwatch.StartNew();
        var isRunning = false;
        while (!isRunning && sw.ElapsedMilliseconds < 60000)
        {
            workflow = (WorkflowInfo)Given()
                .Accept(MediaTypeNames.Application.Json)
                .When()
                .Get($"{RootUrl}/api/v1/workflows/{workflow.Name}")
                .Then()
                .StatusCode(HttpStatusCode.OK)
                .And()
                .DeserializeTo(typeof(WorkflowInfo));
            isRunning = workflow.Status == WorkflowStatus.Running;
            if (isRunning) break;
            await Task.Delay(500);
        }
        sw.Stop();
        output.WriteLine($"Workflow {workflow.Name} is {workflow.Status} after " + sw.ElapsedMilliseconds + "ms");
        Assert.True(isRunning);

        // Get the logstream. Make sure it isn't waiting for the workflow to finish
        Given()
            .UseHttpCompletionOption(HttpCompletionOption.ResponseHeadersRead)
            .Accept("application/x-ndjson")
            .When()
            .Get($"{RootUrl}/api/v1/workflows/{workflow.Name}/pods/{workflow.Name}/logstream")
            .Then()
            .StatusCode(HttpStatusCode.OK)
            .And()
            .ContentType("application/x-ndjson")
            .And()
            .Header("Cache-Control", "no-cache")
            // Istio strips this header. Not sure why yet. See https://defense-unicorns.slack.com/archives/C06QJAUHWFN/p1722893232750909
            // .And()
            // .Header("Connection", "keep-alive")
            .And()
            .ResponseTime(Is.LessThan(TimeSpan.FromSeconds(10)));

        // Do it one more time. This time it should happen extremely quickly since we know the pod is done initializing.
        HttpResponseMessage response = Given()
            .UseHttpCompletionOption(HttpCompletionOption.ResponseHeadersRead)
            .Accept("application/x-ndjson")
            .When()
            .Get($"{RootUrl}/api/v1/workflows/{workflow.Name}/pods/{workflow.Name}/logstream")
            .Then()
            .StatusCode(HttpStatusCode.OK)
            .And()
            .ContentType("application/x-ndjson")
            .And()
            .Header("Cache-Control", "no-cache")
            // Istio strips this header. Not sure why yet. See https://defense-unicorns.slack.com/archives/C06QJAUHWFN/p1722893232750909
            // .And()
            // .Header("Connection", "keep-alive")
            .And()
            .ResponseTime(Is.LessThan(TimeSpan.FromSeconds(2)))
            .And()
            .Extract().Response();

        // Deserialize the first line of the logstream to make sure it is valid. We'll assume for the sake of time that the rest of the stream is formatted the same way.
        await using var responseStream = await response.Content.ReadAsStreamAsync();
        using var reader = new StreamReader(responseStream);
        var line = await reader.ReadLineAsync();
        Assert.NotNull(line);
        var logEntry = JsonConvert.DeserializeObject<StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry>(line);
        Assert.NotNull(logEntry);
        Assert.Contains("capturing logs", logEntry.Result.Content);

        // Make sure the workflow is still running
        workflow = (WorkflowInfo)Given()
            .Accept(MediaTypeNames.Application.Json)
            .ContentType(MediaTypeNames.Application.Json)
            .When()
            .Get($"{RootUrl}/api/v1/workflows/{workflow.Name}")
            .Then()
            .StatusCode(HttpStatusCode.OK)
            .And()
            .DeserializeTo(typeof(WorkflowInfo));
        Assert.Equal(WorkflowStatus.Running, workflow.Status);
    }

    [Fact]
    public async Task GetWorkflowLogstream_WhenCalledOnArchivedPod_ReturnsOk()
    {
        // Submit the workflow
        var workflow = (WorkflowInfo)Given()
            .Accept(MediaTypeNames.Application.Json)
            .ContentType(MediaTypeNames.Application.Json)
            .Body(new WorkflowSubmission()
            {
                TemplateName = TemplateName,
                GenerateName = GenerateName,
                Parameters = [new WorkflowParameter("waitSeconds", "1")]
            })
            .When()
            .Post($"{RootUrl}/api/v1/workflows/")
            .Then()
            .StatusCode(HttpStatusCode.OK)
            .And()
            .DeserializeTo(typeof(WorkflowInfo));
        output.WriteLine($"Workflow {workflow.Name} submitted");
        await Task.Delay(500);

        // loop until the workflow is archived
        Stopwatch sw = Stopwatch.StartNew();
        var isSucceeded = false;
        while (!isSucceeded && sw.ElapsedMilliseconds < 60000)
        {
            workflow = (WorkflowInfo)Given()
                .Accept(MediaTypeNames.Application.Json)
                .When()
                .Get($"{RootUrl}/api/v1/workflows/{workflow.Name}")
                .Then()
                .StatusCode(HttpStatusCode.OK)
                .And()
                .DeserializeTo(typeof(WorkflowInfo));
            isSucceeded = workflow.Status == WorkflowStatus.Succeeded;
            if (isSucceeded) break;
            await Task.Delay(500);
        }
        sw.Stop();
        output.WriteLine($"Workflow {workflow.Name} is {workflow.Status} after " + sw.ElapsedMilliseconds + "ms");
        Assert.True(isSucceeded);

        // Wait 3 more seconds to try to make sure the pod is archived.
        // Ideally we would check the pod status but as far as I can tell
        // the Argo Server API's GetWorkflow endpoint does not report whether
        // a workflow is archived.
        await Task.Delay(3000);

        // Get the logstream. This should happen very quickly since grabbing logs from the archive is quite a bit faster than establishing a live SSE connection.
        Given()
            .UseHttpCompletionOption(HttpCompletionOption.ResponseHeadersRead)
            .Accept("application/x-ndjson")
            .When()
            .Get($"{RootUrl}/api/v1/workflows/{workflow.Name}/pods/{workflow.Name}/logstream")
            .Then()
            .StatusCode(HttpStatusCode.OK)
            .And()
            .ContentType("application/x-ndjson")
            .And()
            .Header("Cache-Control", "no-cache")
            // Istio strips this header. Not sure why yet. See https://defense-unicorns.slack.com/archives/C06QJAUHWFN/p1722893232750909
            // .And()
            // .Header("Connection", "keep-alive")
            .And()
            .ResponseTime(Is.LessThan(TimeSpan.FromMilliseconds(500)));
    }
}
