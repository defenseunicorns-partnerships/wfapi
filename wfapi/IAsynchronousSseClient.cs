using Org.OpenAPITools.Client;

namespace wfapi;

/// <summary>
/// Contract for Asynchronous SSE API interactions.
/// </summary>
public interface IAsynchronousSseClient
{
    /// <summary>
    /// Executes a non-blocking call to some <paramref name="path"/> using the GET http verb.
    /// </summary>
    /// <param name="path">The relative path to invoke.</param>
    /// <param name="options">The request parameters to pass along to the client.</param>
    /// <param name="configuration">Per-request configurable settings.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <typeparam name="T">The return type.</typeparam>
    /// <returns>A task eventually representing the response data, decorated with <see cref="ApiResponse{T}"/></returns>
    IAsyncEnumerable<ApiResponse<T>> GetAsync<T>(string path,
        RequestOptions options,
        IReadableConfiguration? configuration = null,
        CancellationToken cancellationToken = default(System.Threading.CancellationToken));
}
