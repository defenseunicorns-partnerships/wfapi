using System.Net;
using static RestAssured.Dsl;

namespace wfapi.Tests.V1.Controllers;

public class WorkflowsControllerTests
{
    [Fact]
    public void SubmitWorkflow_WhenCalled_ReturnsOk()
    {
        Given()
            .Accept("application/json")
            .ContentType("application/json-patch+json")
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
}
