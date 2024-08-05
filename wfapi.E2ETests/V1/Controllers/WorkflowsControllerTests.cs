using System.Diagnostics;
using System.Net;
using System.Net.Mime;
using Newtonsoft.Json;
using RestAssured.Request.Logging;
using wfapi.V1.Models;
using static RestAssured.Dsl;

namespace wfapi.E2ETests.V1.Controllers;

public class WorkflowsControllerTests
{
    private static readonly string RootUrl = "https://wfapi.uds.dev";
    private static readonly string TemplateName = "hello-world-template";
    private static readonly string GenerateName = "hello-world-";

    [Fact]
    public void SubmitWorkflow_WhenCalled_WithEmptyParameters_ReturnsOk()
    {
        Given()
            .Log(RequestLogLevel.All)
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
            .Accept(MediaTypeNames.Application.Json)
            .ContentType(MediaTypeNames.Application.Json)
            .When()
            .Get($"https://wfapi.uds.dev/api/v1/workflows/{workflow.Name}")
            .Then()
            .StatusCode(HttpStatusCode.OK);
    }

    [Fact]
    public void GetWorkflowLogstream_WhenCalledOnRunningPod_ReturnsOkImmediately()
    {
        // Submit the workflow
        var workflow = (WorkflowInfo)Given()
            .Accept(MediaTypeNames.Application.Json)
            .ContentType(MediaTypeNames.Application.Json)
            .Body(new WorkflowSubmission()
            {
                TemplateName = TemplateName,
                GenerateName = GenerateName,
                Parameters = [new WorkflowParameter("waitSeconds", "10")]
            })
            .When()
            .Post($"{RootUrl}/api/v1/workflows/")
            .Then()
            .StatusCode(HttpStatusCode.OK)
            .And()
            .DeserializeTo(typeof(WorkflowInfo));
        Thread.Sleep(500);

        // loop until the workflow is running
        Stopwatch sw = Stopwatch.StartNew();
        while (workflow.Status != WorkflowStatus.Running && sw.ElapsedMilliseconds < 3000)
        {
            workflow = (WorkflowInfo)Given()
                .Accept(MediaTypeNames.Application.Json)
                .ContentType(MediaTypeNames.Application.Json)
                .When()
                .Get($"{RootUrl}/api/v1/workflows/{workflow.Name}")
                .Then()
                .StatusCode(HttpStatusCode.OK)
                .And()
                .DeserializeTo(typeof(WorkflowInfo));
            Thread.Sleep(500);
        }
        sw.Stop();

        // Get the logstream
        sw = Stopwatch.StartNew();
        Given()
            .Accept("application/x-ndjson")
            .When()
            .Get($"{RootUrl}/api/v1/workflows/{workflow.Name}/logstream")
            .Then()
            .StatusCode(HttpStatusCode.OK)
            .And()
            .ContentType("application/x-ndjson")
            .And()
            .Header("Cache-Control", "no-cache")
            .And()
            .Header("Connection", "keep-alive");

        // assert that the logstream is not waiting for the workflow to finish
        sw.Stop();
        Assert.True(sw.ElapsedMilliseconds < 1000);
    }
}
