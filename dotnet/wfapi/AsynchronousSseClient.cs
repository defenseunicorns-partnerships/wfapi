using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Org.OpenAPITools.Client;
using Polly;

namespace wfapi;

/// <summary>
/// Implementation for Asynchronous SSE API interactions.
/// </summary>
public class AsynchronousSseClient : IDisposable, IAsynchronousSseClient
{
    private readonly string _baseUrl;

    private readonly HttpClientHandler _httpClientHandler;
    private readonly HttpClient _httpClient;
    private readonly bool _disposeClient;

    /// <summary>
    /// Specifies the settings on a <see cref="JsonSerializer" /> object.
    /// These settings can be adjusted to accommodate custom serialization rules.
    /// </summary>
    private JsonSerializerSettings SerializerSettings { get; } = new()
    {
        // OpenAPI generated types generally hide default constructors.
        ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy
            {
                OverrideSpecifiedNames = false
            }
        }
    };

    /// <summary>
    /// Initializes a new instance of the <see cref="AsynchronousSseClient" />.
    /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
    /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
    /// </summary>
    /// <param name="basePath">The target service's base path in URL format.</param>
    /// <exception cref="ArgumentException"></exception>
    public AsynchronousSseClient(string basePath)
    {
        if (string.IsNullOrEmpty(basePath)) throw new ArgumentException("basePath cannot be empty");

        _httpClientHandler = new HttpClientHandler();
        _httpClient = new HttpClient(_httpClientHandler, true);
        _disposeClient = true;
        _baseUrl = basePath;
    }

    /// <summary>
    /// Disposes resources if they were created by us
    /// </summary>
    public void Dispose()
    {
        if(_disposeClient) {
            _httpClient.Dispose();
        }
    }

    /// <summary>
    /// Prepares multipart/form-data content
    /// </summary>
    /// <param name="options"></param>
    /// <returns></returns>
    HttpContent PrepareMultipartFormDataContent(RequestOptions options)
    {
        var boundary = "---------" + Guid.NewGuid().ToString().ToUpperInvariant();
        var multipartContent = new MultipartFormDataContent(boundary);
        foreach (var formParameter in options.FormParameters)
        {
            multipartContent.Add(new StringContent(formParameter.Value), formParameter.Key);
        }

        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (options.FileParameters is { Count: > 0 })
        {
            foreach (var fileParam in options.FileParameters)
            {
                foreach (var file in fileParam.Value)
                {
                    var content = new StreamContent(file.Content);
                    content.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
                    multipartContent.Add(content, fileParam.Key, file.Name);
                }
            }
        }
        return multipartContent;
    }

    /// <inheritdoc />
    public async IAsyncEnumerable<ApiResponse<T>> GetAsync<T>(string path,
        RequestOptions options,
        IReadableConfiguration? configuration = null,
        [EnumeratorCancellation] CancellationToken cancellationToken = default(CancellationToken))
    {
        var config = configuration ?? GlobalConfiguration.Instance;
        await foreach (var apiResponse in ExecAsync<T>(NewRequest(HttpMethod.Get, path, options, config), config,
                           cancellationToken))
        {
            yield return apiResponse;
        }
    }

    private async IAsyncEnumerable<ApiResponse<T>> ExecAsync<T>(HttpRequestMessage req,
        IReadableConfiguration configuration,
        [EnumeratorCancellation] CancellationToken cancellationToken = default(System.Threading.CancellationToken))
    {
        var finalToken = cancellationToken;

        if (configuration.Timeout > 0)
        {
            var timeoutTokenSource = new CancellationTokenSource(configuration.Timeout);
            var finalTokenSource = CancellationTokenSource.CreateLinkedTokenSource(finalToken, timeoutTokenSource.Token);
            finalToken = finalTokenSource.Token;
        }

        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (configuration.Proxy != null)
        {
            if(_httpClientHandler == null) throw new InvalidOperationException("Configuration `Proxy` not supported when the client is explicitly created without an HttpClientHandler, use the proper constructor.");
            _httpClientHandler.Proxy = configuration.Proxy;
        }

        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (configuration.ClientCertificates != null)
        {
            if(_httpClientHandler == null) throw new InvalidOperationException("Configuration `ClientCertificates` not supported when the client is explicitly created without an HttpClientHandler, use the proper constructor.");
            _httpClientHandler.ClientCertificates.AddRange(configuration.ClientCertificates);
        }

        req.Options.TryGetValue(new HttpRequestOptionsKey<List<Cookie>>("CookieContainer"),
            out var cookieContainer);
        // var cookieContainer = req.Properties.ContainsKey("CookieContainer") ? req.Properties["CookieContainer"] as List<Cookie> : null;

        if (cookieContainer != null)
        {
            if(_httpClientHandler == null) throw new InvalidOperationException("Request property `CookieContainer` not supported when the client is explicitly created without an HttpClientHandler, use the proper constructor.");
            foreach (var cookie in cookieContainer)
            {
                _httpClientHandler.CookieContainer.Add(cookie);
            }
        }

        HttpResponseMessage response;
        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (RetryConfiguration.AsyncRetryPolicy != null)
        {
            var policy = RetryConfiguration.AsyncRetryPolicy;
            var policyResult = await policy
                .ExecuteAndCaptureAsync(() => _httpClient.SendAsync(req, HttpCompletionOption.ResponseHeadersRead, finalToken))
                .ConfigureAwait(false);
            response = (policyResult.Outcome == OutcomeType.Successful) ?
                policyResult.Result : new HttpResponseMessage()
                {
                    ReasonPhrase = policyResult.FinalException.ToString(),
                    RequestMessage = req
                };
        }
        else
        {
            response = await _httpClient.SendAsync(req, HttpCompletionOption.ResponseHeadersRead, finalToken).ConfigureAwait(false);
        }

        if (!response.IsSuccessStatusCode)
        {
            yield return ToApiResponse<T>(response, null, default(T), req.RequestUri ?? throw new InvalidOperationException());
        }

        await using var responseStream = await response.Content.ReadAsStreamAsync(finalToken).ConfigureAwait(false);
        using var reader = new StreamReader(responseStream);
        while (!reader.EndOfStream && !cancellationToken.IsCancellationRequested)
        {
            var line = await reader.ReadLineAsync(finalToken).ConfigureAwait(false);
            if (string.IsNullOrWhiteSpace(line)) continue;
            object responseData = JsonConvert.DeserializeObject<T>(line, SerializerSettings) ?? throw new InvalidOperationException();
            yield return ToApiResponse<T>(response, line, responseData, req.RequestUri ?? throw new InvalidOperationException());
        }
    }

    private ApiResponse<T> ToApiResponse<T>(HttpResponseMessage response, string? rawContent, object? responseData, Uri uri)
    {
        var result = (T?) responseData;

        var transformed = new ApiResponse<T>(response.StatusCode, new Multimap<string, string>(), result!, rawContent!)
        {
            ErrorText = response.ReasonPhrase!,
            Cookies = []
        };

        // process response headers, e.g. Access-Control-Allow-Methods
        foreach (var responseHeader in response.Headers)
        {
            transformed.Headers.Add(responseHeader.Key, ClientUtils.ParameterToString(responseHeader.Value));
        }

        // process response content headers, e.g. Content-Type
        foreach (var responseHeader in response.Content.Headers)
        {
            transformed.Headers.Add(responseHeader.Key, ClientUtils.ParameterToString(responseHeader.Value));
        }

        try {
            foreach (Cookie cookie in _httpClientHandler.CookieContainer.GetCookies(uri))
            {
                transformed.Cookies.Add(cookie);
            }
        }
        catch (PlatformNotSupportedException) {}

        return transformed;
    }

    /// <summary>
    /// Provides all logic for constructing a new HttpRequestMessage.
    /// At this point, all information for querying the service is known. Here, it is simply
    /// mapped into a HttpRequestMessage.
    /// </summary>
    /// <param name="method">The http verb.</param>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>[private] A new HttpRequestMessage instance.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    private HttpRequestMessage NewRequest(
        HttpMethod method,
        string path,
        RequestOptions options,
        IReadableConfiguration configuration)
    {
        ArgumentNullException.ThrowIfNull(path);
        ArgumentNullException.ThrowIfNull(options);
        ArgumentNullException.ThrowIfNull(configuration);

        var builder = new WebRequestPathBuilder(_baseUrl, path);

        builder.AddPathParameters(options.PathParameters);

        builder.AddQueryParameters(options.QueryParameters);

        var request = new HttpRequestMessage(method, builder.GetFullUri());

        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (configuration.UserAgent != null)
        {
            request.Headers.TryAddWithoutValidation("User-Agent", configuration.UserAgent);
        }

        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (configuration.DefaultHeaders != null)
        {
            foreach (var headerParam in configuration.DefaultHeaders)
            {
                request.Headers.Add(headerParam.Key, headerParam.Value);
            }
        }

        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (options.HeaderParameters != null)
        {
            foreach (var headerParam in options.HeaderParameters)
            {
                foreach (var value in headerParam.Value)
                {
                    // Todo make content headers actually content headers
                    request.Headers.TryAddWithoutValidation(headerParam.Key, value);
                }
            }
        }

        string? contentType = null;
        if (options.HeaderParameters != null && options.HeaderParameters.TryGetValue("Content-Type", out var contentTypes))
        {
            contentType = contentTypes.FirstOrDefault();
        }

        if (contentType == "multipart/form-data")
        {
            request.Content = PrepareMultipartFormDataContent(options);
        }
        else if (contentType == "application/x-www-form-urlencoded")
        {
            request.Content = new FormUrlEncodedContent(options.FormParameters);
        }
        else
        {
            // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
            if (options.Data != null)
            {
                if (options.Data is FileParameter fp)
                {
                    contentType = contentType ?? "application/octet-stream";

                    var streamContent = new StreamContent(fp.Content);
                    streamContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
                    request.Content = streamContent;
                }
                else
                {
                    var serializer = new CustomJsonCodec(SerializerSettings, configuration);
                    request.Content = new StringContent(serializer.Serialize(options.Data), new UTF8Encoding(),
                        "application/json");
                }
            }
        }



        // TODO provide an alternative that allows cookies per request instead of per API client
        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (options.Cookies is { Count: > 0 })
        {
            request.Options.Set(new HttpRequestOptionsKey<List<Cookie>>("CookieContainer"), options.Cookies);
            // request.Properties["CookieContainer"] = options.Cookies;
        }

        return request;
    }
}
