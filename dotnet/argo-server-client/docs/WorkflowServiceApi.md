# Org.OpenAPITools.Api.WorkflowServiceApi

All URIs are relative to *http://localhost:2746*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WorkflowServiceCreateWorkflow**](WorkflowServiceApi.md#workflowservicecreateworkflow) | **POST** /api/v1/workflows/{namespace} |  |
| [**WorkflowServiceDeleteWorkflow**](WorkflowServiceApi.md#workflowservicedeleteworkflow) | **DELETE** /api/v1/workflows/{namespace}/{name} |  |
| [**WorkflowServiceGetWorkflow**](WorkflowServiceApi.md#workflowservicegetworkflow) | **GET** /api/v1/workflows/{namespace}/{name} |  |
| [**WorkflowServiceLintWorkflow**](WorkflowServiceApi.md#workflowservicelintworkflow) | **POST** /api/v1/workflows/{namespace}/lint |  |
| [**WorkflowServiceListWorkflows**](WorkflowServiceApi.md#workflowservicelistworkflows) | **GET** /api/v1/workflows/{namespace} |  |
| [**WorkflowServicePodLogs**](WorkflowServiceApi.md#workflowservicepodlogs) | **GET** /api/v1/workflows/{namespace}/{name}/{podName}/log | DEPRECATED: Cannot work via HTTP if podName is an empty string. Use WorkflowLogs. |
| [**WorkflowServiceResubmitWorkflow**](WorkflowServiceApi.md#workflowserviceresubmitworkflow) | **PUT** /api/v1/workflows/{namespace}/{name}/resubmit |  |
| [**WorkflowServiceResumeWorkflow**](WorkflowServiceApi.md#workflowserviceresumeworkflow) | **PUT** /api/v1/workflows/{namespace}/{name}/resume |  |
| [**WorkflowServiceRetryWorkflow**](WorkflowServiceApi.md#workflowserviceretryworkflow) | **PUT** /api/v1/workflows/{namespace}/{name}/retry |  |
| [**WorkflowServiceSetWorkflow**](WorkflowServiceApi.md#workflowservicesetworkflow) | **PUT** /api/v1/workflows/{namespace}/{name}/set |  |
| [**WorkflowServiceStopWorkflow**](WorkflowServiceApi.md#workflowservicestopworkflow) | **PUT** /api/v1/workflows/{namespace}/{name}/stop |  |
| [**WorkflowServiceSubmitWorkflow**](WorkflowServiceApi.md#workflowservicesubmitworkflow) | **POST** /api/v1/workflows/{namespace}/submit |  |
| [**WorkflowServiceSuspendWorkflow**](WorkflowServiceApi.md#workflowservicesuspendworkflow) | **PUT** /api/v1/workflows/{namespace}/{name}/suspend |  |
| [**WorkflowServiceTerminateWorkflow**](WorkflowServiceApi.md#workflowserviceterminateworkflow) | **PUT** /api/v1/workflows/{namespace}/{name}/terminate |  |
| [**WorkflowServiceWatchEvents**](WorkflowServiceApi.md#workflowservicewatchevents) | **GET** /api/v1/stream/events/{namespace} |  |
| [**WorkflowServiceWatchWorkflows**](WorkflowServiceApi.md#workflowservicewatchworkflows) | **GET** /api/v1/workflow-events/{namespace} |  |
| [**WorkflowServiceWorkflowLogs**](WorkflowServiceApi.md#workflowserviceworkflowlogs) | **GET** /api/v1/workflows/{namespace}/{name}/log |  |

<a id="workflowservicecreateworkflow"></a>
# **WorkflowServiceCreateWorkflow**
> IoArgoprojWorkflowV1alpha1Workflow WorkflowServiceCreateWorkflow (string varNamespace, IoArgoprojWorkflowV1alpha1WorkflowCreateRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceCreateWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var body = new IoArgoprojWorkflowV1alpha1WorkflowCreateRequest(); // IoArgoprojWorkflowV1alpha1WorkflowCreateRequest |

            try
            {
                IoArgoprojWorkflowV1alpha1Workflow result = apiInstance.WorkflowServiceCreateWorkflow(varNamespace, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceCreateWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceCreateWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1Workflow> response = apiInstance.WorkflowServiceCreateWorkflowWithHttpInfo(varNamespace, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceCreateWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **body** | [**IoArgoprojWorkflowV1alpha1WorkflowCreateRequest**](IoArgoprojWorkflowV1alpha1WorkflowCreateRequest.md) |  |  |

### Return type

[**IoArgoprojWorkflowV1alpha1Workflow**](IoArgoprojWorkflowV1alpha1Workflow.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowservicedeleteworkflow"></a>
# **WorkflowServiceDeleteWorkflow**
> Object WorkflowServiceDeleteWorkflow (string varNamespace, string name, string? deleteOptionsGracePeriodSeconds = null, string? deleteOptionsPreconditionsUid = null, string? deleteOptionsPreconditionsResourceVersion = null, bool? deleteOptionsOrphanDependents = null, string? deleteOptionsPropagationPolicy = null, List<string>? deleteOptionsDryRun = null, bool? force = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceDeleteWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var deleteOptionsGracePeriodSeconds = "deleteOptionsGracePeriodSeconds_example";  // string? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. +optional. (optional)
            var deleteOptionsPreconditionsUid = "deleteOptionsPreconditionsUid_example";  // string? | Specifies the target UID. +optional. (optional)
            var deleteOptionsPreconditionsResourceVersion = "deleteOptionsPreconditionsResourceVersion_example";  // string? | Specifies the target ResourceVersion +optional. (optional)
            var deleteOptionsOrphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. +optional. (optional)
            var deleteOptionsPropagationPolicy = "deleteOptionsPropagationPolicy_example";  // string? | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. Acceptable values are: 'Orphan' - orphan the dependents; 'Background' - allow the garbage collector to delete the dependents in the background; 'Foreground' - a cascading policy that deletes all dependents in the foreground. +optional. (optional)
            var deleteOptionsDryRun = new List<string>?(); // List<string>? | When present, indicates that modifications should not be persisted. An invalid or unrecognized dryRun directive will result in an error response and no further processing of the request. Valid values are: - All: all dry run stages will be processed +optional. (optional)
            var force = true;  // bool? |  (optional)

            try
            {
                Object result = apiInstance.WorkflowServiceDeleteWorkflow(varNamespace, name, deleteOptionsGracePeriodSeconds, deleteOptionsPreconditionsUid, deleteOptionsPreconditionsResourceVersion, deleteOptionsOrphanDependents, deleteOptionsPropagationPolicy, deleteOptionsDryRun, force);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceDeleteWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceDeleteWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.WorkflowServiceDeleteWorkflowWithHttpInfo(varNamespace, name, deleteOptionsGracePeriodSeconds, deleteOptionsPreconditionsUid, deleteOptionsPreconditionsResourceVersion, deleteOptionsOrphanDependents, deleteOptionsPropagationPolicy, deleteOptionsDryRun, force);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceDeleteWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **name** | **string** |  |  |
| **deleteOptionsGracePeriodSeconds** | **string?** | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. +optional. | [optional]  |
| **deleteOptionsPreconditionsUid** | **string?** | Specifies the target UID. +optional. | [optional]  |
| **deleteOptionsPreconditionsResourceVersion** | **string?** | Specifies the target ResourceVersion +optional. | [optional]  |
| **deleteOptionsOrphanDependents** | **bool?** | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both. +optional. | [optional]  |
| **deleteOptionsPropagationPolicy** | **string?** | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. Acceptable values are: &#39;Orphan&#39; - orphan the dependents; &#39;Background&#39; - allow the garbage collector to delete the dependents in the background; &#39;Foreground&#39; - a cascading policy that deletes all dependents in the foreground. +optional. | [optional]  |
| **deleteOptionsDryRun** | [**List&lt;string&gt;?**](string.md) | When present, indicates that modifications should not be persisted. An invalid or unrecognized dryRun directive will result in an error response and no further processing of the request. Valid values are: - All: all dry run stages will be processed +optional. | [optional]  |
| **force** | **bool?** |  | [optional]  |

### Return type

**Object**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowservicegetworkflow"></a>
# **WorkflowServiceGetWorkflow**
> IoArgoprojWorkflowV1alpha1Workflow WorkflowServiceGetWorkflow (string varNamespace, string name, string? getOptionsResourceVersion = null, string? fields = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceGetWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var getOptionsResourceVersion = "getOptionsResourceVersion_example";  // string? | resourceVersion sets a constraint on what resource versions a request may be served from. See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional (optional)
            var fields = "fields_example";  // string? | Fields to be included or excluded in the response. e.g. \"spec,status.phase\", \"-status.nodes\". (optional)

            try
            {
                IoArgoprojWorkflowV1alpha1Workflow result = apiInstance.WorkflowServiceGetWorkflow(varNamespace, name, getOptionsResourceVersion, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceGetWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceGetWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1Workflow> response = apiInstance.WorkflowServiceGetWorkflowWithHttpInfo(varNamespace, name, getOptionsResourceVersion, fields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceGetWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **name** | **string** |  |  |
| **getOptionsResourceVersion** | **string?** | resourceVersion sets a constraint on what resource versions a request may be served from. See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional | [optional]  |
| **fields** | **string?** | Fields to be included or excluded in the response. e.g. \&quot;spec,status.phase\&quot;, \&quot;-status.nodes\&quot;. | [optional]  |

### Return type

[**IoArgoprojWorkflowV1alpha1Workflow**](IoArgoprojWorkflowV1alpha1Workflow.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowservicelintworkflow"></a>
# **WorkflowServiceLintWorkflow**
> IoArgoprojWorkflowV1alpha1Workflow WorkflowServiceLintWorkflow (string varNamespace, IoArgoprojWorkflowV1alpha1WorkflowLintRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceLintWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var body = new IoArgoprojWorkflowV1alpha1WorkflowLintRequest(); // IoArgoprojWorkflowV1alpha1WorkflowLintRequest |

            try
            {
                IoArgoprojWorkflowV1alpha1Workflow result = apiInstance.WorkflowServiceLintWorkflow(varNamespace, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceLintWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceLintWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1Workflow> response = apiInstance.WorkflowServiceLintWorkflowWithHttpInfo(varNamespace, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceLintWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **body** | [**IoArgoprojWorkflowV1alpha1WorkflowLintRequest**](IoArgoprojWorkflowV1alpha1WorkflowLintRequest.md) |  |  |

### Return type

[**IoArgoprojWorkflowV1alpha1Workflow**](IoArgoprojWorkflowV1alpha1Workflow.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowservicelistworkflows"></a>
# **WorkflowServiceListWorkflows**
> IoArgoprojWorkflowV1alpha1WorkflowList WorkflowServiceListWorkflows (string varNamespace, string? listOptionsLabelSelector = null, string? listOptionsFieldSelector = null, bool? listOptionsWatch = null, bool? listOptionsAllowWatchBookmarks = null, string? listOptionsResourceVersion = null, string? listOptionsResourceVersionMatch = null, string? listOptionsTimeoutSeconds = null, string? listOptionsLimit = null, string? listOptionsContinue = null, string? fields = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceListWorkflowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var listOptionsLabelSelector = "listOptionsLabelSelector_example";  // string? | A selector to restrict the list of returned objects by their labels. Defaults to everything. +optional. (optional)
            var listOptionsFieldSelector = "listOptionsFieldSelector_example";  // string? | A selector to restrict the list of returned objects by their fields. Defaults to everything. +optional. (optional)
            var listOptionsWatch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. +optional. (optional)
            var listOptionsAllowWatchBookmarks = true;  // bool? | allowWatchBookmarks requests watch events with type \"BOOKMARK\". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. +optional. (optional)
            var listOptionsResourceVersion = "listOptionsResourceVersion_example";  // string? | resourceVersion sets a constraint on what resource versions a request may be served from. See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional (optional)
            var listOptionsResourceVersionMatch = "listOptionsResourceVersionMatch_example";  // string? | resourceVersionMatch determines how resourceVersion is applied to list calls. It is highly recommended that resourceVersionMatch be set for list calls where resourceVersion is set See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional (optional)
            var listOptionsTimeoutSeconds = "listOptionsTimeoutSeconds_example";  // string? | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. +optional. (optional)
            var listOptionsLimit = "listOptionsLimit_example";  // string? | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. (optional)
            var listOptionsContinue = "listOptionsContinue_example";  // string? | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \"next key\".  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. (optional)
            var fields = "fields_example";  // string? | Fields to be included or excluded in the response. e.g. \"items.spec,items.status.phase\", \"-items.status.nodes\". (optional)

            try
            {
                IoArgoprojWorkflowV1alpha1WorkflowList result = apiInstance.WorkflowServiceListWorkflows(varNamespace, listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceListWorkflows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceListWorkflowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1WorkflowList> response = apiInstance.WorkflowServiceListWorkflowsWithHttpInfo(varNamespace, listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue, fields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceListWorkflowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **listOptionsLabelSelector** | **string?** | A selector to restrict the list of returned objects by their labels. Defaults to everything. +optional. | [optional]  |
| **listOptionsFieldSelector** | **string?** | A selector to restrict the list of returned objects by their fields. Defaults to everything. +optional. | [optional]  |
| **listOptionsWatch** | **bool?** | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. +optional. | [optional]  |
| **listOptionsAllowWatchBookmarks** | **bool?** | allowWatchBookmarks requests watch events with type \&quot;BOOKMARK\&quot;. Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server&#39;s discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. +optional. | [optional]  |
| **listOptionsResourceVersion** | **string?** | resourceVersion sets a constraint on what resource versions a request may be served from. See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional | [optional]  |
| **listOptionsResourceVersionMatch** | **string?** | resourceVersionMatch determines how resourceVersion is applied to list calls. It is highly recommended that resourceVersionMatch be set for list calls where resourceVersion is set See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional | [optional]  |
| **listOptionsTimeoutSeconds** | **string?** | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. +optional. | [optional]  |
| **listOptionsLimit** | **string?** | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the &#x60;continue&#x60; field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. | [optional]  |
| **listOptionsContinue** | **string?** | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \&quot;next key\&quot;.  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. | [optional]  |
| **fields** | **string?** | Fields to be included or excluded in the response. e.g. \&quot;items.spec,items.status.phase\&quot;, \&quot;-items.status.nodes\&quot;. | [optional]  |

### Return type

[**IoArgoprojWorkflowV1alpha1WorkflowList**](IoArgoprojWorkflowV1alpha1WorkflowList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowservicepodlogs"></a>
# **WorkflowServicePodLogs**
> StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry WorkflowServicePodLogs (string varNamespace, string name, string podName, string? logOptionsContainer = null, bool? logOptionsFollow = null, bool? logOptionsPrevious = null, string? logOptionsSinceSeconds = null, string? logOptionsSinceTimeSeconds = null, int? logOptionsSinceTimeNanos = null, bool? logOptionsTimestamps = null, string? logOptionsTailLines = null, string? logOptionsLimitBytes = null, bool? logOptionsInsecureSkipTLSVerifyBackend = null, string? grep = null, string? selector = null)

DEPRECATED: Cannot work via HTTP if podName is an empty string. Use WorkflowLogs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServicePodLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var podName = "podName_example";  // string |
            var logOptionsContainer = "logOptionsContainer_example";  // string? | The container for which to stream logs. Defaults to only container if there is one container in the pod. +optional. (optional)
            var logOptionsFollow = true;  // bool? | Follow the log stream of the pod. Defaults to false. +optional. (optional)
            var logOptionsPrevious = true;  // bool? | Return previous terminated container logs. Defaults to false. +optional. (optional)
            var logOptionsSinceSeconds = "logOptionsSinceSeconds_example";  // string? | A relative time in seconds before the current time from which to show logs. If this value precedes the time a pod was started, only logs since the pod start will be returned. If this value is in the future, no logs will be returned. Only one of sinceSeconds or sinceTime may be specified. +optional. (optional)
            var logOptionsSinceTimeSeconds = "logOptionsSinceTimeSeconds_example";  // string? | Represents seconds of UTC time since Unix epoch 1970-01-01T00:00:00Z. Must be from 0001-01-01T00:00:00Z to 9999-12-31T23:59:59Z inclusive. (optional)
            var logOptionsSinceTimeNanos = 56;  // int? | Non-negative fractions of a second at nanosecond resolution. Negative second values with fractions must still have non-negative nanos values that count forward in time. Must be from 0 to 999,999,999 inclusive. This field may be limited in precision depending on context. (optional)
            var logOptionsTimestamps = true;  // bool? | If true, add an RFC3339 or RFC3339Nano timestamp at the beginning of every line of log output. Defaults to false. +optional. (optional)
            var logOptionsTailLines = "logOptionsTailLines_example";  // string? | If set, the number of lines from the end of the logs to show. If not specified, logs are shown from the creation of the container or sinceSeconds or sinceTime +optional. (optional)
            var logOptionsLimitBytes = "logOptionsLimitBytes_example";  // string? | If set, the number of bytes to read from the server before terminating the log output. This may not display a complete final line of logging, and may return slightly more or slightly less than the specified limit. +optional. (optional)
            var logOptionsInsecureSkipTLSVerifyBackend = true;  // bool? | insecureSkipTLSVerifyBackend indicates that the apiserver should not confirm the validity of the serving certificate of the backend it is connecting to.  This will make the HTTPS connection between the apiserver and the backend insecure. This means the apiserver cannot verify the log data it is receiving came from the real kubelet.  If the kubelet is configured to verify the apiserver's TLS credentials, it does not mean the connection to the real kubelet is vulnerable to a man in the middle attack (e.g. an attacker could not intercept the actual log data coming from the real kubelet). +optional. (optional)
            var grep = "grep_example";  // string? |  (optional)
            var selector = "selector_example";  // string? |  (optional)

            try
            {
                // DEPRECATED: Cannot work via HTTP if podName is an empty string. Use WorkflowLogs.
                StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry result = apiInstance.WorkflowServicePodLogs(varNamespace, name, podName, logOptionsContainer, logOptionsFollow, logOptionsPrevious, logOptionsSinceSeconds, logOptionsSinceTimeSeconds, logOptionsSinceTimeNanos, logOptionsTimestamps, logOptionsTailLines, logOptionsLimitBytes, logOptionsInsecureSkipTLSVerifyBackend, grep, selector);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServicePodLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServicePodLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DEPRECATED: Cannot work via HTTP if podName is an empty string. Use WorkflowLogs.
    ApiResponse<StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry> response = apiInstance.WorkflowServicePodLogsWithHttpInfo(varNamespace, name, podName, logOptionsContainer, logOptionsFollow, logOptionsPrevious, logOptionsSinceSeconds, logOptionsSinceTimeSeconds, logOptionsSinceTimeNanos, logOptionsTimestamps, logOptionsTailLines, logOptionsLimitBytes, logOptionsInsecureSkipTLSVerifyBackend, grep, selector);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServicePodLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **name** | **string** |  |  |
| **podName** | **string** |  |  |
| **logOptionsContainer** | **string?** | The container for which to stream logs. Defaults to only container if there is one container in the pod. +optional. | [optional]  |
| **logOptionsFollow** | **bool?** | Follow the log stream of the pod. Defaults to false. +optional. | [optional]  |
| **logOptionsPrevious** | **bool?** | Return previous terminated container logs. Defaults to false. +optional. | [optional]  |
| **logOptionsSinceSeconds** | **string?** | A relative time in seconds before the current time from which to show logs. If this value precedes the time a pod was started, only logs since the pod start will be returned. If this value is in the future, no logs will be returned. Only one of sinceSeconds or sinceTime may be specified. +optional. | [optional]  |
| **logOptionsSinceTimeSeconds** | **string?** | Represents seconds of UTC time since Unix epoch 1970-01-01T00:00:00Z. Must be from 0001-01-01T00:00:00Z to 9999-12-31T23:59:59Z inclusive. | [optional]  |
| **logOptionsSinceTimeNanos** | **int?** | Non-negative fractions of a second at nanosecond resolution. Negative second values with fractions must still have non-negative nanos values that count forward in time. Must be from 0 to 999,999,999 inclusive. This field may be limited in precision depending on context. | [optional]  |
| **logOptionsTimestamps** | **bool?** | If true, add an RFC3339 or RFC3339Nano timestamp at the beginning of every line of log output. Defaults to false. +optional. | [optional]  |
| **logOptionsTailLines** | **string?** | If set, the number of lines from the end of the logs to show. If not specified, logs are shown from the creation of the container or sinceSeconds or sinceTime +optional. | [optional]  |
| **logOptionsLimitBytes** | **string?** | If set, the number of bytes to read from the server before terminating the log output. This may not display a complete final line of logging, and may return slightly more or slightly less than the specified limit. +optional. | [optional]  |
| **logOptionsInsecureSkipTLSVerifyBackend** | **bool?** | insecureSkipTLSVerifyBackend indicates that the apiserver should not confirm the validity of the serving certificate of the backend it is connecting to.  This will make the HTTPS connection between the apiserver and the backend insecure. This means the apiserver cannot verify the log data it is receiving came from the real kubelet.  If the kubelet is configured to verify the apiserver&#39;s TLS credentials, it does not mean the connection to the real kubelet is vulnerable to a man in the middle attack (e.g. an attacker could not intercept the actual log data coming from the real kubelet). +optional. | [optional]  |
| **grep** | **string?** |  | [optional]  |
| **selector** | **string?** |  | [optional]  |

### Return type

[**StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry**](StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response.(streaming responses) |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowserviceresubmitworkflow"></a>
# **WorkflowServiceResubmitWorkflow**
> IoArgoprojWorkflowV1alpha1Workflow WorkflowServiceResubmitWorkflow (string varNamespace, string name, IoArgoprojWorkflowV1alpha1WorkflowResubmitRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceResubmitWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var body = new IoArgoprojWorkflowV1alpha1WorkflowResubmitRequest(); // IoArgoprojWorkflowV1alpha1WorkflowResubmitRequest |

            try
            {
                IoArgoprojWorkflowV1alpha1Workflow result = apiInstance.WorkflowServiceResubmitWorkflow(varNamespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceResubmitWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceResubmitWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1Workflow> response = apiInstance.WorkflowServiceResubmitWorkflowWithHttpInfo(varNamespace, name, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceResubmitWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **name** | **string** |  |  |
| **body** | [**IoArgoprojWorkflowV1alpha1WorkflowResubmitRequest**](IoArgoprojWorkflowV1alpha1WorkflowResubmitRequest.md) |  |  |

### Return type

[**IoArgoprojWorkflowV1alpha1Workflow**](IoArgoprojWorkflowV1alpha1Workflow.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowserviceresumeworkflow"></a>
# **WorkflowServiceResumeWorkflow**
> IoArgoprojWorkflowV1alpha1Workflow WorkflowServiceResumeWorkflow (string varNamespace, string name, IoArgoprojWorkflowV1alpha1WorkflowResumeRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceResumeWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var body = new IoArgoprojWorkflowV1alpha1WorkflowResumeRequest(); // IoArgoprojWorkflowV1alpha1WorkflowResumeRequest |

            try
            {
                IoArgoprojWorkflowV1alpha1Workflow result = apiInstance.WorkflowServiceResumeWorkflow(varNamespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceResumeWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceResumeWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1Workflow> response = apiInstance.WorkflowServiceResumeWorkflowWithHttpInfo(varNamespace, name, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceResumeWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **name** | **string** |  |  |
| **body** | [**IoArgoprojWorkflowV1alpha1WorkflowResumeRequest**](IoArgoprojWorkflowV1alpha1WorkflowResumeRequest.md) |  |  |

### Return type

[**IoArgoprojWorkflowV1alpha1Workflow**](IoArgoprojWorkflowV1alpha1Workflow.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowserviceretryworkflow"></a>
# **WorkflowServiceRetryWorkflow**
> IoArgoprojWorkflowV1alpha1Workflow WorkflowServiceRetryWorkflow (string varNamespace, string name, IoArgoprojWorkflowV1alpha1WorkflowRetryRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceRetryWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var body = new IoArgoprojWorkflowV1alpha1WorkflowRetryRequest(); // IoArgoprojWorkflowV1alpha1WorkflowRetryRequest |

            try
            {
                IoArgoprojWorkflowV1alpha1Workflow result = apiInstance.WorkflowServiceRetryWorkflow(varNamespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceRetryWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceRetryWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1Workflow> response = apiInstance.WorkflowServiceRetryWorkflowWithHttpInfo(varNamespace, name, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceRetryWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **name** | **string** |  |  |
| **body** | [**IoArgoprojWorkflowV1alpha1WorkflowRetryRequest**](IoArgoprojWorkflowV1alpha1WorkflowRetryRequest.md) |  |  |

### Return type

[**IoArgoprojWorkflowV1alpha1Workflow**](IoArgoprojWorkflowV1alpha1Workflow.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowservicesetworkflow"></a>
# **WorkflowServiceSetWorkflow**
> IoArgoprojWorkflowV1alpha1Workflow WorkflowServiceSetWorkflow (string varNamespace, string name, IoArgoprojWorkflowV1alpha1WorkflowSetRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceSetWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var body = new IoArgoprojWorkflowV1alpha1WorkflowSetRequest(); // IoArgoprojWorkflowV1alpha1WorkflowSetRequest |

            try
            {
                IoArgoprojWorkflowV1alpha1Workflow result = apiInstance.WorkflowServiceSetWorkflow(varNamespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceSetWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceSetWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1Workflow> response = apiInstance.WorkflowServiceSetWorkflowWithHttpInfo(varNamespace, name, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceSetWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **name** | **string** |  |  |
| **body** | [**IoArgoprojWorkflowV1alpha1WorkflowSetRequest**](IoArgoprojWorkflowV1alpha1WorkflowSetRequest.md) |  |  |

### Return type

[**IoArgoprojWorkflowV1alpha1Workflow**](IoArgoprojWorkflowV1alpha1Workflow.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowservicestopworkflow"></a>
# **WorkflowServiceStopWorkflow**
> IoArgoprojWorkflowV1alpha1Workflow WorkflowServiceStopWorkflow (string varNamespace, string name, IoArgoprojWorkflowV1alpha1WorkflowStopRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceStopWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var body = new IoArgoprojWorkflowV1alpha1WorkflowStopRequest(); // IoArgoprojWorkflowV1alpha1WorkflowStopRequest |

            try
            {
                IoArgoprojWorkflowV1alpha1Workflow result = apiInstance.WorkflowServiceStopWorkflow(varNamespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceStopWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceStopWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1Workflow> response = apiInstance.WorkflowServiceStopWorkflowWithHttpInfo(varNamespace, name, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceStopWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **name** | **string** |  |  |
| **body** | [**IoArgoprojWorkflowV1alpha1WorkflowStopRequest**](IoArgoprojWorkflowV1alpha1WorkflowStopRequest.md) |  |  |

### Return type

[**IoArgoprojWorkflowV1alpha1Workflow**](IoArgoprojWorkflowV1alpha1Workflow.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowservicesubmitworkflow"></a>
# **WorkflowServiceSubmitWorkflow**
> IoArgoprojWorkflowV1alpha1Workflow WorkflowServiceSubmitWorkflow (string varNamespace, IoArgoprojWorkflowV1alpha1WorkflowSubmitRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceSubmitWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var body = new IoArgoprojWorkflowV1alpha1WorkflowSubmitRequest(); // IoArgoprojWorkflowV1alpha1WorkflowSubmitRequest |

            try
            {
                IoArgoprojWorkflowV1alpha1Workflow result = apiInstance.WorkflowServiceSubmitWorkflow(varNamespace, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceSubmitWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceSubmitWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1Workflow> response = apiInstance.WorkflowServiceSubmitWorkflowWithHttpInfo(varNamespace, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceSubmitWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **body** | [**IoArgoprojWorkflowV1alpha1WorkflowSubmitRequest**](IoArgoprojWorkflowV1alpha1WorkflowSubmitRequest.md) |  |  |

### Return type

[**IoArgoprojWorkflowV1alpha1Workflow**](IoArgoprojWorkflowV1alpha1Workflow.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowservicesuspendworkflow"></a>
# **WorkflowServiceSuspendWorkflow**
> IoArgoprojWorkflowV1alpha1Workflow WorkflowServiceSuspendWorkflow (string varNamespace, string name, IoArgoprojWorkflowV1alpha1WorkflowSuspendRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceSuspendWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var body = new IoArgoprojWorkflowV1alpha1WorkflowSuspendRequest(); // IoArgoprojWorkflowV1alpha1WorkflowSuspendRequest |

            try
            {
                IoArgoprojWorkflowV1alpha1Workflow result = apiInstance.WorkflowServiceSuspendWorkflow(varNamespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceSuspendWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceSuspendWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1Workflow> response = apiInstance.WorkflowServiceSuspendWorkflowWithHttpInfo(varNamespace, name, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceSuspendWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **name** | **string** |  |  |
| **body** | [**IoArgoprojWorkflowV1alpha1WorkflowSuspendRequest**](IoArgoprojWorkflowV1alpha1WorkflowSuspendRequest.md) |  |  |

### Return type

[**IoArgoprojWorkflowV1alpha1Workflow**](IoArgoprojWorkflowV1alpha1Workflow.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowserviceterminateworkflow"></a>
# **WorkflowServiceTerminateWorkflow**
> IoArgoprojWorkflowV1alpha1Workflow WorkflowServiceTerminateWorkflow (string varNamespace, string name, IoArgoprojWorkflowV1alpha1WorkflowTerminateRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceTerminateWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var body = new IoArgoprojWorkflowV1alpha1WorkflowTerminateRequest(); // IoArgoprojWorkflowV1alpha1WorkflowTerminateRequest |

            try
            {
                IoArgoprojWorkflowV1alpha1Workflow result = apiInstance.WorkflowServiceTerminateWorkflow(varNamespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceTerminateWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceTerminateWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1Workflow> response = apiInstance.WorkflowServiceTerminateWorkflowWithHttpInfo(varNamespace, name, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceTerminateWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **name** | **string** |  |  |
| **body** | [**IoArgoprojWorkflowV1alpha1WorkflowTerminateRequest**](IoArgoprojWorkflowV1alpha1WorkflowTerminateRequest.md) |  |  |

### Return type

[**IoArgoprojWorkflowV1alpha1Workflow**](IoArgoprojWorkflowV1alpha1Workflow.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowservicewatchevents"></a>
# **WorkflowServiceWatchEvents**
> StreamResultOfIoK8sApiCoreV1Event WorkflowServiceWatchEvents (string varNamespace, string? listOptionsLabelSelector = null, string? listOptionsFieldSelector = null, bool? listOptionsWatch = null, bool? listOptionsAllowWatchBookmarks = null, string? listOptionsResourceVersion = null, string? listOptionsResourceVersionMatch = null, string? listOptionsTimeoutSeconds = null, string? listOptionsLimit = null, string? listOptionsContinue = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceWatchEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var listOptionsLabelSelector = "listOptionsLabelSelector_example";  // string? | A selector to restrict the list of returned objects by their labels. Defaults to everything. +optional. (optional)
            var listOptionsFieldSelector = "listOptionsFieldSelector_example";  // string? | A selector to restrict the list of returned objects by their fields. Defaults to everything. +optional. (optional)
            var listOptionsWatch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. +optional. (optional)
            var listOptionsAllowWatchBookmarks = true;  // bool? | allowWatchBookmarks requests watch events with type \"BOOKMARK\". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. +optional. (optional)
            var listOptionsResourceVersion = "listOptionsResourceVersion_example";  // string? | resourceVersion sets a constraint on what resource versions a request may be served from. See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional (optional)
            var listOptionsResourceVersionMatch = "listOptionsResourceVersionMatch_example";  // string? | resourceVersionMatch determines how resourceVersion is applied to list calls. It is highly recommended that resourceVersionMatch be set for list calls where resourceVersion is set See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional (optional)
            var listOptionsTimeoutSeconds = "listOptionsTimeoutSeconds_example";  // string? | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. +optional. (optional)
            var listOptionsLimit = "listOptionsLimit_example";  // string? | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. (optional)
            var listOptionsContinue = "listOptionsContinue_example";  // string? | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \"next key\".  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. (optional)

            try
            {
                StreamResultOfIoK8sApiCoreV1Event result = apiInstance.WorkflowServiceWatchEvents(varNamespace, listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceWatchEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceWatchEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StreamResultOfIoK8sApiCoreV1Event> response = apiInstance.WorkflowServiceWatchEventsWithHttpInfo(varNamespace, listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceWatchEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **listOptionsLabelSelector** | **string?** | A selector to restrict the list of returned objects by their labels. Defaults to everything. +optional. | [optional]  |
| **listOptionsFieldSelector** | **string?** | A selector to restrict the list of returned objects by their fields. Defaults to everything. +optional. | [optional]  |
| **listOptionsWatch** | **bool?** | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. +optional. | [optional]  |
| **listOptionsAllowWatchBookmarks** | **bool?** | allowWatchBookmarks requests watch events with type \&quot;BOOKMARK\&quot;. Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server&#39;s discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. +optional. | [optional]  |
| **listOptionsResourceVersion** | **string?** | resourceVersion sets a constraint on what resource versions a request may be served from. See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional | [optional]  |
| **listOptionsResourceVersionMatch** | **string?** | resourceVersionMatch determines how resourceVersion is applied to list calls. It is highly recommended that resourceVersionMatch be set for list calls where resourceVersion is set See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional | [optional]  |
| **listOptionsTimeoutSeconds** | **string?** | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. +optional. | [optional]  |
| **listOptionsLimit** | **string?** | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the &#x60;continue&#x60; field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. | [optional]  |
| **listOptionsContinue** | **string?** | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \&quot;next key\&quot;.  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. | [optional]  |

### Return type

[**StreamResultOfIoK8sApiCoreV1Event**](StreamResultOfIoK8sApiCoreV1Event.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response.(streaming responses) |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowservicewatchworkflows"></a>
# **WorkflowServiceWatchWorkflows**
> StreamResultOfIoArgoprojWorkflowV1alpha1WorkflowWatchEvent WorkflowServiceWatchWorkflows (string varNamespace, string? listOptionsLabelSelector = null, string? listOptionsFieldSelector = null, bool? listOptionsWatch = null, bool? listOptionsAllowWatchBookmarks = null, string? listOptionsResourceVersion = null, string? listOptionsResourceVersionMatch = null, string? listOptionsTimeoutSeconds = null, string? listOptionsLimit = null, string? listOptionsContinue = null, string? fields = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceWatchWorkflowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var listOptionsLabelSelector = "listOptionsLabelSelector_example";  // string? | A selector to restrict the list of returned objects by their labels. Defaults to everything. +optional. (optional)
            var listOptionsFieldSelector = "listOptionsFieldSelector_example";  // string? | A selector to restrict the list of returned objects by their fields. Defaults to everything. +optional. (optional)
            var listOptionsWatch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. +optional. (optional)
            var listOptionsAllowWatchBookmarks = true;  // bool? | allowWatchBookmarks requests watch events with type \"BOOKMARK\". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. +optional. (optional)
            var listOptionsResourceVersion = "listOptionsResourceVersion_example";  // string? | resourceVersion sets a constraint on what resource versions a request may be served from. See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional (optional)
            var listOptionsResourceVersionMatch = "listOptionsResourceVersionMatch_example";  // string? | resourceVersionMatch determines how resourceVersion is applied to list calls. It is highly recommended that resourceVersionMatch be set for list calls where resourceVersion is set See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional (optional)
            var listOptionsTimeoutSeconds = "listOptionsTimeoutSeconds_example";  // string? | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. +optional. (optional)
            var listOptionsLimit = "listOptionsLimit_example";  // string? | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. (optional)
            var listOptionsContinue = "listOptionsContinue_example";  // string? | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \"next key\".  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. (optional)
            var fields = "fields_example";  // string? |  (optional)

            try
            {
                StreamResultOfIoArgoprojWorkflowV1alpha1WorkflowWatchEvent result = apiInstance.WorkflowServiceWatchWorkflows(varNamespace, listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceWatchWorkflows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceWatchWorkflowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StreamResultOfIoArgoprojWorkflowV1alpha1WorkflowWatchEvent> response = apiInstance.WorkflowServiceWatchWorkflowsWithHttpInfo(varNamespace, listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue, fields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceWatchWorkflowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **listOptionsLabelSelector** | **string?** | A selector to restrict the list of returned objects by their labels. Defaults to everything. +optional. | [optional]  |
| **listOptionsFieldSelector** | **string?** | A selector to restrict the list of returned objects by their fields. Defaults to everything. +optional. | [optional]  |
| **listOptionsWatch** | **bool?** | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. +optional. | [optional]  |
| **listOptionsAllowWatchBookmarks** | **bool?** | allowWatchBookmarks requests watch events with type \&quot;BOOKMARK\&quot;. Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server&#39;s discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. +optional. | [optional]  |
| **listOptionsResourceVersion** | **string?** | resourceVersion sets a constraint on what resource versions a request may be served from. See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional | [optional]  |
| **listOptionsResourceVersionMatch** | **string?** | resourceVersionMatch determines how resourceVersion is applied to list calls. It is highly recommended that resourceVersionMatch be set for list calls where resourceVersion is set See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional | [optional]  |
| **listOptionsTimeoutSeconds** | **string?** | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. +optional. | [optional]  |
| **listOptionsLimit** | **string?** | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the &#x60;continue&#x60; field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. | [optional]  |
| **listOptionsContinue** | **string?** | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \&quot;next key\&quot;.  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. | [optional]  |
| **fields** | **string?** |  | [optional]  |

### Return type

[**StreamResultOfIoArgoprojWorkflowV1alpha1WorkflowWatchEvent**](StreamResultOfIoArgoprojWorkflowV1alpha1WorkflowWatchEvent.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response.(streaming responses) |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workflowserviceworkflowlogs"></a>
# **WorkflowServiceWorkflowLogs**
> StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry WorkflowServiceWorkflowLogs (string varNamespace, string name, string? podName = null, string? logOptionsContainer = null, bool? logOptionsFollow = null, bool? logOptionsPrevious = null, string? logOptionsSinceSeconds = null, string? logOptionsSinceTimeSeconds = null, int? logOptionsSinceTimeNanos = null, bool? logOptionsTimestamps = null, string? logOptionsTailLines = null, string? logOptionsLimitBytes = null, bool? logOptionsInsecureSkipTLSVerifyBackend = null, string? grep = null, string? selector = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WorkflowServiceWorkflowLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkflowServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var podName = "podName_example";  // string? |  (optional)
            var logOptionsContainer = "logOptionsContainer_example";  // string? | The container for which to stream logs. Defaults to only container if there is one container in the pod. +optional. (optional)
            var logOptionsFollow = true;  // bool? | Follow the log stream of the pod. Defaults to false. +optional. (optional)
            var logOptionsPrevious = true;  // bool? | Return previous terminated container logs. Defaults to false. +optional. (optional)
            var logOptionsSinceSeconds = "logOptionsSinceSeconds_example";  // string? | A relative time in seconds before the current time from which to show logs. If this value precedes the time a pod was started, only logs since the pod start will be returned. If this value is in the future, no logs will be returned. Only one of sinceSeconds or sinceTime may be specified. +optional. (optional)
            var logOptionsSinceTimeSeconds = "logOptionsSinceTimeSeconds_example";  // string? | Represents seconds of UTC time since Unix epoch 1970-01-01T00:00:00Z. Must be from 0001-01-01T00:00:00Z to 9999-12-31T23:59:59Z inclusive. (optional)
            var logOptionsSinceTimeNanos = 56;  // int? | Non-negative fractions of a second at nanosecond resolution. Negative second values with fractions must still have non-negative nanos values that count forward in time. Must be from 0 to 999,999,999 inclusive. This field may be limited in precision depending on context. (optional)
            var logOptionsTimestamps = true;  // bool? | If true, add an RFC3339 or RFC3339Nano timestamp at the beginning of every line of log output. Defaults to false. +optional. (optional)
            var logOptionsTailLines = "logOptionsTailLines_example";  // string? | If set, the number of lines from the end of the logs to show. If not specified, logs are shown from the creation of the container or sinceSeconds or sinceTime +optional. (optional)
            var logOptionsLimitBytes = "logOptionsLimitBytes_example";  // string? | If set, the number of bytes to read from the server before terminating the log output. This may not display a complete final line of logging, and may return slightly more or slightly less than the specified limit. +optional. (optional)
            var logOptionsInsecureSkipTLSVerifyBackend = true;  // bool? | insecureSkipTLSVerifyBackend indicates that the apiserver should not confirm the validity of the serving certificate of the backend it is connecting to.  This will make the HTTPS connection between the apiserver and the backend insecure. This means the apiserver cannot verify the log data it is receiving came from the real kubelet.  If the kubelet is configured to verify the apiserver's TLS credentials, it does not mean the connection to the real kubelet is vulnerable to a man in the middle attack (e.g. an attacker could not intercept the actual log data coming from the real kubelet). +optional. (optional)
            var grep = "grep_example";  // string? |  (optional)
            var selector = "selector_example";  // string? |  (optional)

            try
            {
                StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry result = apiInstance.WorkflowServiceWorkflowLogs(varNamespace, name, podName, logOptionsContainer, logOptionsFollow, logOptionsPrevious, logOptionsSinceSeconds, logOptionsSinceTimeSeconds, logOptionsSinceTimeNanos, logOptionsTimestamps, logOptionsTailLines, logOptionsLimitBytes, logOptionsInsecureSkipTLSVerifyBackend, grep, selector);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceWorkflowLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowServiceWorkflowLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry> response = apiInstance.WorkflowServiceWorkflowLogsWithHttpInfo(varNamespace, name, podName, logOptionsContainer, logOptionsFollow, logOptionsPrevious, logOptionsSinceSeconds, logOptionsSinceTimeSeconds, logOptionsSinceTimeNanos, logOptionsTimestamps, logOptionsTailLines, logOptionsLimitBytes, logOptionsInsecureSkipTLSVerifyBackend, grep, selector);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowServiceApi.WorkflowServiceWorkflowLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **name** | **string** |  |  |
| **podName** | **string?** |  | [optional]  |
| **logOptionsContainer** | **string?** | The container for which to stream logs. Defaults to only container if there is one container in the pod. +optional. | [optional]  |
| **logOptionsFollow** | **bool?** | Follow the log stream of the pod. Defaults to false. +optional. | [optional]  |
| **logOptionsPrevious** | **bool?** | Return previous terminated container logs. Defaults to false. +optional. | [optional]  |
| **logOptionsSinceSeconds** | **string?** | A relative time in seconds before the current time from which to show logs. If this value precedes the time a pod was started, only logs since the pod start will be returned. If this value is in the future, no logs will be returned. Only one of sinceSeconds or sinceTime may be specified. +optional. | [optional]  |
| **logOptionsSinceTimeSeconds** | **string?** | Represents seconds of UTC time since Unix epoch 1970-01-01T00:00:00Z. Must be from 0001-01-01T00:00:00Z to 9999-12-31T23:59:59Z inclusive. | [optional]  |
| **logOptionsSinceTimeNanos** | **int?** | Non-negative fractions of a second at nanosecond resolution. Negative second values with fractions must still have non-negative nanos values that count forward in time. Must be from 0 to 999,999,999 inclusive. This field may be limited in precision depending on context. | [optional]  |
| **logOptionsTimestamps** | **bool?** | If true, add an RFC3339 or RFC3339Nano timestamp at the beginning of every line of log output. Defaults to false. +optional. | [optional]  |
| **logOptionsTailLines** | **string?** | If set, the number of lines from the end of the logs to show. If not specified, logs are shown from the creation of the container or sinceSeconds or sinceTime +optional. | [optional]  |
| **logOptionsLimitBytes** | **string?** | If set, the number of bytes to read from the server before terminating the log output. This may not display a complete final line of logging, and may return slightly more or slightly less than the specified limit. +optional. | [optional]  |
| **logOptionsInsecureSkipTLSVerifyBackend** | **bool?** | insecureSkipTLSVerifyBackend indicates that the apiserver should not confirm the validity of the serving certificate of the backend it is connecting to.  This will make the HTTPS connection between the apiserver and the backend insecure. This means the apiserver cannot verify the log data it is receiving came from the real kubelet.  If the kubelet is configured to verify the apiserver&#39;s TLS credentials, it does not mean the connection to the real kubelet is vulnerable to a man in the middle attack (e.g. an attacker could not intercept the actual log data coming from the real kubelet). +optional. | [optional]  |
| **grep** | **string?** |  | [optional]  |
| **selector** | **string?** |  | [optional]  |

### Return type

[**StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry**](StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response.(streaming responses) |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
