using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace wfapi;

/// <summary>
/// Reimplementation of some endpoints in the WorkflowServiceApi that use Server-Sent Events (SSE).
/// Endpoints that use SSE are not supported by the OpenAPI generator so those endpoints are not functional.
/// </summary>
public interface IWorkflowServiceSseApiAsync
{
    /// <summary>
    /// Get the logs of a workflow as NDJSON using SSE
    /// </summary>
    /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="varNamespace"></param>
    /// <param name="name"></param>
    /// <param name="podName"> (optional)</param>
    /// <param name="logOptionsContainer">The container for which to stream logs. Defaults to only container if there is one container in the pod. +optional. (optional)</param>
    /// <param name="logOptionsFollow">Follow the log stream of the pod. Defaults to false. +optional. (optional)</param>
    /// <param name="logOptionsPrevious">Return previous terminated container logs. Defaults to false. +optional. (optional)</param>
    /// <param name="logOptionsSinceSeconds">A relative time in seconds before the current time from which to show logs. If this value precedes the time a pod was started, only logs since the pod start will be returned. If this value is in the future, no logs will be returned. Only one of sinceSeconds or sinceTime may be specified. +optional. (optional)</param>
    /// <param name="logOptionsSinceTimeSeconds">Represents seconds of UTC time since Unix epoch 1970-01-01T00:00:00Z. Must be from 0001-01-01T00:00:00Z to 9999-12-31T23:59:59Z inclusive. (optional)</param>
    /// <param name="logOptionsSinceTimeNanos">Non-negative fractions of a second at nanosecond resolution. Negative second values with fractions must still have non-negative nanos values that count forward in time. Must be from 0 to 999,999,999 inclusive. This field may be limited in precision depending on context. (optional)</param>
    /// <param name="logOptionsTimestamps">If true, add an RFC3339 or RFC3339Nano timestamp at the beginning of every line of log output. Defaults to false. +optional. (optional)</param>
    /// <param name="logOptionsTailLines">If set, the number of lines from the end of the logs to show. If not specified, logs are shown from the creation of the container or sinceSeconds or sinceTime +optional. (optional)</param>
    /// <param name="logOptionsLimitBytes">If set, the number of bytes to read from the server before terminating the log output. This may not display a complete final line of logging, and may return slightly more or slightly less than the specified limit. +optional. (optional)</param>
    /// <param name="logOptionsInsecureSkipTLSVerifyBackend">insecureSkipTLSVerifyBackend indicates that the apiserver should not confirm the validity of the serving certificate of the backend it is connecting to.  This will make the HTTPS connection between the apiserver and the backend insecure. This means the apiserver cannot verify the log data it is receiving came from the real kubelet.  If the kubelet is configured to verify the apiserver&#39;s TLS credentials, it does not mean the connection to the real kubelet is vulnerable to a man in the middle attack (e.g. an attacker could not intercept the actual log data coming from the real kubelet). +optional. (optional)</param>
    /// <param name="grep"> (optional)</param>
    /// <param name="selector"> (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>IAsyncEnumerable of StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry</returns>
    IAsyncEnumerable<StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry> WorkflowServiceWorkflowLogsAsync(
        string varNamespace,
        string name,
        string? podName = default(string?),
        string? logOptionsContainer = default(string?),
        bool? logOptionsFollow = default(bool?),
        bool? logOptionsPrevious = default(bool?),
        string? logOptionsSinceSeconds = default(string?),
        string? logOptionsSinceTimeSeconds = default(string?),
        int? logOptionsSinceTimeNanos = default(int?),
        bool? logOptionsTimestamps = default(bool?),
        string? logOptionsTailLines = default(string?),
        string? logOptionsLimitBytes = default(string?),
        // ReSharper disable once InconsistentNaming
        bool? logOptionsInsecureSkipTLSVerifyBackend = default(bool?),
        string? grep = default(string?),
        string? selector = default(string?),
        int operationIndex = 0,
        CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    /// <summary>
    /// Get the logs of a workflow as NDJSON using SSE (lower level method)
    /// </summary>
    /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="varNamespace"></param>
    /// <param name="name"></param>
    /// <param name="podName"> (optional)</param>
    /// <param name="logOptionsContainer">The container for which to stream logs. Defaults to only container if there is one container in the pod. +optional. (optional)</param>
    /// <param name="logOptionsFollow">Follow the log stream of the pod. Defaults to false. +optional. (optional)</param>
    /// <param name="logOptionsPrevious">Return previous terminated container logs. Defaults to false. +optional. (optional)</param>
    /// <param name="logOptionsSinceSeconds">A relative time in seconds before the current time from which to show logs. If this value precedes the time a pod was started, only logs since the pod start will be returned. If this value is in the future, no logs will be returned. Only one of sinceSeconds or sinceTime may be specified. +optional. (optional)</param>
    /// <param name="logOptionsSinceTimeSeconds">Represents seconds of UTC time since Unix epoch 1970-01-01T00:00:00Z. Must be from 0001-01-01T00:00:00Z to 9999-12-31T23:59:59Z inclusive. (optional)</param>
    /// <param name="logOptionsSinceTimeNanos">Non-negative fractions of a second at nanosecond resolution. Negative second values with fractions must still have non-negative nanos values that count forward in time. Must be from 0 to 999,999,999 inclusive. This field may be limited in precision depending on context. (optional)</param>
    /// <param name="logOptionsTimestamps">If true, add an RFC3339 or RFC3339Nano timestamp at the beginning of every line of log output. Defaults to false. +optional. (optional)</param>
    /// <param name="logOptionsTailLines">If set, the number of lines from the end of the logs to show. If not specified, logs are shown from the creation of the container or sinceSeconds or sinceTime +optional. (optional)</param>
    /// <param name="logOptionsLimitBytes">If set, the number of bytes to read from the server before terminating the log output. This may not display a complete final line of logging, and may return slightly more or slightly less than the specified limit. +optional. (optional)</param>
    /// <param name="logOptionsInsecureSkipTLSVerifyBackend">insecureSkipTLSVerifyBackend indicates that the apiserver should not confirm the validity of the serving certificate of the backend it is connecting to.  This will make the HTTPS connection between the apiserver and the backend insecure. This means the apiserver cannot verify the log data it is receiving came from the real kubelet.  If the kubelet is configured to verify the apiserver&#39;s TLS credentials, it does not mean the connection to the real kubelet is vulnerable to a man in the middle attack (e.g. an attacker could not intercept the actual log data coming from the real kubelet). +optional. (optional)</param>
    /// <param name="grep"> (optional)</param>
    /// <param name="selector"> (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry)</returns>
    IAsyncEnumerable<ApiResponse<StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry>>
        WorkflowServiceWorkflowLogsWithHttpInfoAsync(string varNamespace,
            string name,
            string? podName = default(string?),
            string? logOptionsContainer = default(string?),
            bool? logOptionsFollow = default(bool?),
            bool? logOptionsPrevious = default(bool?),
            string? logOptionsSinceSeconds = default(string?),
            string? logOptionsSinceTimeSeconds = default(string?),
            int? logOptionsSinceTimeNanos = default(int?),
            bool? logOptionsTimestamps = default(bool?),
            string? logOptionsTailLines = default(string?),
            string? logOptionsLimitBytes = default(string?),
            // ReSharper disable once InconsistentNaming
            bool? logOptionsInsecureSkipTLSVerifyBackend = default(bool?),
            string? grep = default(string?),
            string? selector = default(string?),
            CancellationToken cancellationToken = default(System.Threading.CancellationToken));
}
