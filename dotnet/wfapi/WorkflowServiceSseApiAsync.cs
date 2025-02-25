using System.Runtime.CompilerServices;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace wfapi;

/// <inheritdoc />
public class WorkflowServiceSseApiAsync : IWorkflowServiceSseApiAsync
{
    private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

    /// <summary>
    /// Gets or sets the configuration object
    /// </summary>
    /// <value>An instance of the Configuration</value>
    public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

    /// <summary>
    /// The client for accessing this underlying API's SSE endpoints asynchronously.
    /// </summary>
    public IAsynchronousSseClient AsynchronousSseClient { get; set; }

    /// <summary>
    /// Provides a factory method hook for the creation of exceptions.
    /// </summary>
    public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
    {
        get
        {
            if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
            {
                throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
            }
            return _exceptionFactory;
        }
        set { _exceptionFactory = value; }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkflowServiceApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public WorkflowServiceSseApiAsync(Org.OpenAPITools.Client.Configuration configuration)
    {
        ArgumentNullException.ThrowIfNull(configuration);

        Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
            Org.OpenAPITools.Client.GlobalConfiguration.Instance,
            configuration
        );
        this.AsynchronousSseClient = new AsynchronousSseClient(Configuration.BasePath);
        ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
    }

    /// <inheritdoc />
    public async IAsyncEnumerable<StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry> WorkflowServiceWorkflowLogsAsync(string varNamespace, string name, string authHeader,
        string? podName = default(string?),
        string? logOptionsContainer = default(string?), bool? logOptionsFollow = default(bool?),
        bool? logOptionsPrevious = default(bool?), string? logOptionsSinceSeconds = default(string?),
        string? logOptionsSinceTimeSeconds = default(string?), int? logOptionsSinceTimeNanos = default(int?),
        bool? logOptionsTimestamps = default(bool?), string? logOptionsTailLines = default(string?),
        // ReSharper disable once InconsistentNaming
        string? logOptionsLimitBytes = default(string?), bool? logOptionsInsecureSkipTLSVerifyBackend = default(bool?),
        string? grep = default(string?), string? selector = default(string?), int operationIndex = 0,
        [EnumeratorCancellation] CancellationToken cancellationToken = default(CancellationToken))
    {
        await foreach (var apiResponse in WorkflowServiceWorkflowLogsWithHttpInfoAsync(varNamespace,
                        name,
                        authHeader,
                        podName,
                        logOptionsContainer,
                        logOptionsFollow,
                        logOptionsPrevious,
                        logOptionsSinceSeconds,
                        logOptionsSinceTimeSeconds,
                        logOptionsSinceTimeNanos,
                        logOptionsTimestamps,
                        logOptionsTailLines,
                        logOptionsLimitBytes,
                        logOptionsInsecureSkipTLSVerifyBackend,
                        grep,
                        selector,
                        cancellationToken).ConfigureAwait(false))
        {
            yield return apiResponse.Data;
        }
    }

    /// <inheritdoc />
    public async IAsyncEnumerable<ApiResponse<StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry>> WorkflowServiceWorkflowLogsWithHttpInfoAsync(string varNamespace, string name, string authHeader,
        string? podName = default(string?), string? logOptionsContainer = default(string?),
        bool? logOptionsFollow = default(bool?), bool? logOptionsPrevious = default(bool?),
        string? logOptionsSinceSeconds = default(string?), string? logOptionsSinceTimeSeconds = default(string?),
        int? logOptionsSinceTimeNanos = default(int?), bool? logOptionsTimestamps = default(bool?),
        string? logOptionsTailLines = default(string?), string? logOptionsLimitBytes = default(string?),
        // ReSharper disable once InconsistentNaming
        bool? logOptionsInsecureSkipTLSVerifyBackend = default(bool?), string? grep = default(string?),
        string? selector = default(string?), CancellationToken cancellationToken = default(CancellationToken))
    {
        // verify the required parameter 'varNamespace' is set
        if (varNamespace == null)
            throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'varNamespace' when calling WorkflowServiceApi->WorkflowServiceWorkflowLogs");

        // verify the required parameter 'name' is set
        if (name == null)
            throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'name' when calling WorkflowServiceApi->WorkflowServiceWorkflowLogs");


        Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

        string[] _contentTypes = new string[] {
        };

        // to determine the Accept header
        string[] _accepts = new string[] {
            "application/x-ndjson"
        };


        var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
        if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

        var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

        localVarRequestOptions.PathParameters.Add("namespace", Org.OpenAPITools.Client.ClientUtils.ParameterToString(varNamespace)); // path parameter
        localVarRequestOptions.PathParameters.Add("name", Org.OpenAPITools.Client.ClientUtils.ParameterToString(name)); // path parameter
        if (podName != null)
        {
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "podName", podName));
        }
        if (logOptionsContainer != null)
        {
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "logOptions.container", logOptionsContainer));
        }
        if (logOptionsFollow != null)
        {
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "logOptions.follow", logOptionsFollow));
        }
        if (logOptionsPrevious != null)
        {
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "logOptions.previous", logOptionsPrevious));
        }
        if (logOptionsSinceSeconds != null)
        {
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "logOptions.sinceSeconds", logOptionsSinceSeconds));
        }
        if (logOptionsSinceTimeSeconds != null)
        {
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "logOptions.sinceTime.seconds", logOptionsSinceTimeSeconds));
        }
        if (logOptionsSinceTimeNanos != null)
        {
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "logOptions.sinceTime.nanos", logOptionsSinceTimeNanos));
        }
        if (logOptionsTimestamps != null)
        {
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "logOptions.timestamps", logOptionsTimestamps));
        }
        if (logOptionsTailLines != null)
        {
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "logOptions.tailLines", logOptionsTailLines));
        }
        if (logOptionsLimitBytes != null)
        {
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "logOptions.limitBytes", logOptionsLimitBytes));
        }
        if (logOptionsInsecureSkipTLSVerifyBackend != null)
        {
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "logOptions.insecureSkipTLSVerifyBackend", logOptionsInsecureSkipTLSVerifyBackend));
        }
        if (grep != null)
        {
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "grep", grep));
        }
        if (selector != null)
        {
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "selector", selector));
        }

        // authentication (BearerToken) required
        localVarRequestOptions.HeaderParameters.Add("Authorization", authHeader);


        // make the HTTP request

        await foreach (var localVarResponse in AsynchronousSseClient.GetAsync<StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry>("/api/v1/workflows/{namespace}/{name}/log", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false))
        {
            if (ExceptionFactory != null)
            {
                // ReSharper disable once InconsistentNaming
                var _exception = this.ExceptionFactory("WorkflowServiceWorkflowLogs", localVarResponse);
                if (_exception != null) throw _exception;
            }

            yield return localVarResponse;
        }
    }
}
