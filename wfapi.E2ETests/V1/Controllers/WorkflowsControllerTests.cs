using System.Net;
using System.Net.Mime;
using wfapi.V1.Models;
using static RestAssured.Dsl;

namespace wfapi.E2ETests.V1.Controllers;

public class WorkflowsControllerTests
{
    [Fact]
    public void SubmitWorkflow_WhenCalled_ReturnsOk()
    {
        Given()
            .Accept(MediaTypeNames.Application.Json)
            .ContentType(MediaTypeNames.Application.Json)
            .Body("""
                  {
                    "templateName": "hello-world-template",
                    "generateName": "hello-world-",
                    "parameters": []
                  }
                  """)
        .When()
            .Post("https://wfapi.uds.dev/api/v1/workflows")
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
            .Body("""
                  {
                    "templateName": "hello-world-template",
                    "generateName": "hello-world-",
                    "parameters": []
                  }
                  """)
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
}
