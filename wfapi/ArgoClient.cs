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
    public ArgoClient(string varNamespace, Configuration configuration)
    {
        this.Namespace = varNamespace;
        this.WorkflowServiceApi = new WorkflowServiceApi(configuration);
        this.ArchivedWorkflowServiceApi = new ArchivedWorkflowServiceApi(configuration);
    }

    /// <summary>
    /// The namespace to use for the Argo client
    /// </summary>
    public string Namespace { get; }

    /// <summary>
    /// WorkflowService client
    /// </summary>
    public IWorkflowServiceApi WorkflowServiceApi { get; }

    public IArchivedWorkflowServiceApi ArchivedWorkflowServiceApi { get; }
}
