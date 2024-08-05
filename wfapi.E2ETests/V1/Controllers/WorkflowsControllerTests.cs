using System.Diagnostics;
using System.Net;
using System.Net.Mime;
using Newtonsoft.Json;
using RestAssured.Request.Logging;
using RestAssured.Response.Logging;
using wfapi.V1.Models;
using Xunit.Abstractions;
using static RestAssured.Dsl;

namespace wfapi.E2ETests.V1.Controllers;

public class WorkflowsControllerTests(ITestOutputHelper output)
{
    private static readonly string RootUrl = "https://wfapi.uds.dev";
    private static readonly string TemplateName = "hello-world-template";
    private static readonly string GenerateName = "hello-world-";

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

        // Get the logstream. Make sure it isn't waiting for the workflow to finish
        // We have to do our own request here because rest-assured-net doesn't support SSE
        var httpClientHandler = new HttpClientHandler();
        using var httpClient = new HttpClient(httpClientHandler, true);
        var request = new HttpRequestMessage(HttpMethod.Get, $"{RootUrl}/api/v1/workflows/{workflow.Name}/logstream");
        request.Headers.Add("Accept", "application/x-ndjson");
        sw = Stopwatch.StartNew();
        var response = httpClient.Send(request, HttpCompletionOption.ResponseHeadersRead);
        sw.Stop();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(response.Content.Headers.ContentType?.MediaType);
        Assert.Equal("application/x-ndjson", response.Content.Headers.ContentType.MediaType);
        Assert.NotNull(response.Headers.CacheControl);
        Assert.Equal("no-cache", response.Headers.CacheControl.ToString());
        // Istio strips this header. Not sure why yet. See https://defense-unicorns.slack.com/archives/C06QJAUHWFN/p1722893232750909
        // Assert.NotNull(response.Headers.Connection);
        // Assert.Equal("keep-alive", response.Headers.Connection.ToString());
        Assert.True(sw.ElapsedMilliseconds < 7000);
    }
}
