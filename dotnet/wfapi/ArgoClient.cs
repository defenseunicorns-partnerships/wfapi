using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;

namespace wfapi;

/// <summary>
/// Static Argo configuration
/// </summary>
public class ArgoClient
{
    /// <summary>
    /// Create a new Argo client
    /// </summary>
    /// <param name="varNamespace"></param>
    /// <param name="configuration"></param>
    /// <param name="OidcClient"></param>
    public ArgoClient(string varNamespace, Configuration configuration, ClientCredentials OidcClient)
    {
        this.Namespace = varNamespace;
        this.WorkflowServiceApi = new WorkflowServiceApi(configuration);
        this.WorkflowServiceSseApiAsync = new WorkflowServiceSseApiAsync(configuration);
        this.ArtifactServiceApi = new ArtifactServiceApi(configuration);
    }

    /// <summary>
    /// The namespace to use for the Argo client
    /// </summary>
    public string Namespace { get; }

    /// <summary>
    /// WorkflowService client
    /// </summary>
    public IWorkflowServiceApi WorkflowServiceApi { get; }

    /// <summary>
    /// WorkflowService SSE client
    /// </summary>
    public IWorkflowServiceSseApiAsync WorkflowServiceSseApiAsync { get; }

    public IArtifactServiceApi ArtifactServiceApi { get; }
}
