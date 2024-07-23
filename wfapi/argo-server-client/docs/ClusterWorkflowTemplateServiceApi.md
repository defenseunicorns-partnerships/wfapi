# Org.OpenAPITools.Api.ClusterWorkflowTemplateServiceApi

All URIs are relative to *http://localhost:2746*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ClusterWorkflowTemplateServiceCreateClusterWorkflowTemplate**](ClusterWorkflowTemplateServiceApi.md#clusterworkflowtemplateservicecreateclusterworkflowtemplate) | **POST** /api/v1/cluster-workflow-templates |  |
| [**ClusterWorkflowTemplateServiceDeleteClusterWorkflowTemplate**](ClusterWorkflowTemplateServiceApi.md#clusterworkflowtemplateservicedeleteclusterworkflowtemplate) | **DELETE** /api/v1/cluster-workflow-templates/{name} |  |
| [**ClusterWorkflowTemplateServiceGetClusterWorkflowTemplate**](ClusterWorkflowTemplateServiceApi.md#clusterworkflowtemplateservicegetclusterworkflowtemplate) | **GET** /api/v1/cluster-workflow-templates/{name} |  |
| [**ClusterWorkflowTemplateServiceLintClusterWorkflowTemplate**](ClusterWorkflowTemplateServiceApi.md#clusterworkflowtemplateservicelintclusterworkflowtemplate) | **POST** /api/v1/cluster-workflow-templates/lint |  |
| [**ClusterWorkflowTemplateServiceListClusterWorkflowTemplates**](ClusterWorkflowTemplateServiceApi.md#clusterworkflowtemplateservicelistclusterworkflowtemplates) | **GET** /api/v1/cluster-workflow-templates |  |
| [**ClusterWorkflowTemplateServiceUpdateClusterWorkflowTemplate**](ClusterWorkflowTemplateServiceApi.md#clusterworkflowtemplateserviceupdateclusterworkflowtemplate) | **PUT** /api/v1/cluster-workflow-templates/{name} |  |

<a id="clusterworkflowtemplateservicecreateclusterworkflowtemplate"></a>
# **ClusterWorkflowTemplateServiceCreateClusterWorkflowTemplate**
> IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate ClusterWorkflowTemplateServiceCreateClusterWorkflowTemplate (IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateCreateRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClusterWorkflowTemplateServiceCreateClusterWorkflowTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClusterWorkflowTemplateServiceApi(config);
            var body = new IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateCreateRequest(); // IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateCreateRequest |

            try
            {
                IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate result = apiInstance.ClusterWorkflowTemplateServiceCreateClusterWorkflowTemplate(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterWorkflowTemplateServiceApi.ClusterWorkflowTemplateServiceCreateClusterWorkflowTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterWorkflowTemplateServiceCreateClusterWorkflowTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate> response = apiInstance.ClusterWorkflowTemplateServiceCreateClusterWorkflowTemplateWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterWorkflowTemplateServiceApi.ClusterWorkflowTemplateServiceCreateClusterWorkflowTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateCreateRequest**](IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateCreateRequest.md) |  |  |

### Return type

[**IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate**](IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate.md)

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

<a id="clusterworkflowtemplateservicedeleteclusterworkflowtemplate"></a>
# **ClusterWorkflowTemplateServiceDeleteClusterWorkflowTemplate**
> Object ClusterWorkflowTemplateServiceDeleteClusterWorkflowTemplate (string name, string? deleteOptionsGracePeriodSeconds = null, string? deleteOptionsPreconditionsUid = null, string? deleteOptionsPreconditionsResourceVersion = null, bool? deleteOptionsOrphanDependents = null, string? deleteOptionsPropagationPolicy = null, List<string>? deleteOptionsDryRun = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClusterWorkflowTemplateServiceDeleteClusterWorkflowTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClusterWorkflowTemplateServiceApi(config);
            var name = "name_example";  // string |
            var deleteOptionsGracePeriodSeconds = "deleteOptionsGracePeriodSeconds_example";  // string? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. +optional. (optional)
            var deleteOptionsPreconditionsUid = "deleteOptionsPreconditionsUid_example";  // string? | Specifies the target UID. +optional. (optional)
            var deleteOptionsPreconditionsResourceVersion = "deleteOptionsPreconditionsResourceVersion_example";  // string? | Specifies the target ResourceVersion +optional. (optional)
            var deleteOptionsOrphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. +optional. (optional)
            var deleteOptionsPropagationPolicy = "deleteOptionsPropagationPolicy_example";  // string? | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. Acceptable values are: 'Orphan' - orphan the dependents; 'Background' - allow the garbage collector to delete the dependents in the background; 'Foreground' - a cascading policy that deletes all dependents in the foreground. +optional. (optional)
            var deleteOptionsDryRun = new List<string>?(); // List<string>? | When present, indicates that modifications should not be persisted. An invalid or unrecognized dryRun directive will result in an error response and no further processing of the request. Valid values are: - All: all dry run stages will be processed +optional. (optional)

            try
            {
                Object result = apiInstance.ClusterWorkflowTemplateServiceDeleteClusterWorkflowTemplate(name, deleteOptionsGracePeriodSeconds, deleteOptionsPreconditionsUid, deleteOptionsPreconditionsResourceVersion, deleteOptionsOrphanDependents, deleteOptionsPropagationPolicy, deleteOptionsDryRun);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterWorkflowTemplateServiceApi.ClusterWorkflowTemplateServiceDeleteClusterWorkflowTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterWorkflowTemplateServiceDeleteClusterWorkflowTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ClusterWorkflowTemplateServiceDeleteClusterWorkflowTemplateWithHttpInfo(name, deleteOptionsGracePeriodSeconds, deleteOptionsPreconditionsUid, deleteOptionsPreconditionsResourceVersion, deleteOptionsOrphanDependents, deleteOptionsPropagationPolicy, deleteOptionsDryRun);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterWorkflowTemplateServiceApi.ClusterWorkflowTemplateServiceDeleteClusterWorkflowTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |
| **deleteOptionsGracePeriodSeconds** | **string?** | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. +optional. | [optional]  |
| **deleteOptionsPreconditionsUid** | **string?** | Specifies the target UID. +optional. | [optional]  |
| **deleteOptionsPreconditionsResourceVersion** | **string?** | Specifies the target ResourceVersion +optional. | [optional]  |
| **deleteOptionsOrphanDependents** | **bool?** | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both. +optional. | [optional]  |
| **deleteOptionsPropagationPolicy** | **string?** | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. Acceptable values are: &#39;Orphan&#39; - orphan the dependents; &#39;Background&#39; - allow the garbage collector to delete the dependents in the background; &#39;Foreground&#39; - a cascading policy that deletes all dependents in the foreground. +optional. | [optional]  |
| **deleteOptionsDryRun** | [**List&lt;string&gt;?**](string.md) | When present, indicates that modifications should not be persisted. An invalid or unrecognized dryRun directive will result in an error response and no further processing of the request. Valid values are: - All: all dry run stages will be processed +optional. | [optional]  |

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

<a id="clusterworkflowtemplateservicegetclusterworkflowtemplate"></a>
# **ClusterWorkflowTemplateServiceGetClusterWorkflowTemplate**
> IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate ClusterWorkflowTemplateServiceGetClusterWorkflowTemplate (string name, string? getOptionsResourceVersion = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClusterWorkflowTemplateServiceGetClusterWorkflowTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClusterWorkflowTemplateServiceApi(config);
            var name = "name_example";  // string |
            var getOptionsResourceVersion = "getOptionsResourceVersion_example";  // string? | resourceVersion sets a constraint on what resource versions a request may be served from. See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional (optional)

            try
            {
                IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate result = apiInstance.ClusterWorkflowTemplateServiceGetClusterWorkflowTemplate(name, getOptionsResourceVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterWorkflowTemplateServiceApi.ClusterWorkflowTemplateServiceGetClusterWorkflowTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterWorkflowTemplateServiceGetClusterWorkflowTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate> response = apiInstance.ClusterWorkflowTemplateServiceGetClusterWorkflowTemplateWithHttpInfo(name, getOptionsResourceVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterWorkflowTemplateServiceApi.ClusterWorkflowTemplateServiceGetClusterWorkflowTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |
| **getOptionsResourceVersion** | **string?** | resourceVersion sets a constraint on what resource versions a request may be served from. See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional | [optional]  |

### Return type

[**IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate**](IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate.md)

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

<a id="clusterworkflowtemplateservicelintclusterworkflowtemplate"></a>
# **ClusterWorkflowTemplateServiceLintClusterWorkflowTemplate**
> IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate ClusterWorkflowTemplateServiceLintClusterWorkflowTemplate (IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateLintRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClusterWorkflowTemplateServiceLintClusterWorkflowTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClusterWorkflowTemplateServiceApi(config);
            var body = new IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateLintRequest(); // IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateLintRequest |

            try
            {
                IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate result = apiInstance.ClusterWorkflowTemplateServiceLintClusterWorkflowTemplate(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterWorkflowTemplateServiceApi.ClusterWorkflowTemplateServiceLintClusterWorkflowTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterWorkflowTemplateServiceLintClusterWorkflowTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate> response = apiInstance.ClusterWorkflowTemplateServiceLintClusterWorkflowTemplateWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterWorkflowTemplateServiceApi.ClusterWorkflowTemplateServiceLintClusterWorkflowTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateLintRequest**](IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateLintRequest.md) |  |  |

### Return type

[**IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate**](IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate.md)

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

<a id="clusterworkflowtemplateservicelistclusterworkflowtemplates"></a>
# **ClusterWorkflowTemplateServiceListClusterWorkflowTemplates**
> IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateList ClusterWorkflowTemplateServiceListClusterWorkflowTemplates (string? listOptionsLabelSelector = null, string? listOptionsFieldSelector = null, bool? listOptionsWatch = null, bool? listOptionsAllowWatchBookmarks = null, string? listOptionsResourceVersion = null, string? listOptionsResourceVersionMatch = null, string? listOptionsTimeoutSeconds = null, string? listOptionsLimit = null, string? listOptionsContinue = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClusterWorkflowTemplateServiceListClusterWorkflowTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClusterWorkflowTemplateServiceApi(config);
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
                IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateList result = apiInstance.ClusterWorkflowTemplateServiceListClusterWorkflowTemplates(listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterWorkflowTemplateServiceApi.ClusterWorkflowTemplateServiceListClusterWorkflowTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterWorkflowTemplateServiceListClusterWorkflowTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateList> response = apiInstance.ClusterWorkflowTemplateServiceListClusterWorkflowTemplatesWithHttpInfo(listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterWorkflowTemplateServiceApi.ClusterWorkflowTemplateServiceListClusterWorkflowTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

[**IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateList**](IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateList.md)

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

<a id="clusterworkflowtemplateserviceupdateclusterworkflowtemplate"></a>
# **ClusterWorkflowTemplateServiceUpdateClusterWorkflowTemplate**
> IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate ClusterWorkflowTemplateServiceUpdateClusterWorkflowTemplate (string name, IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateUpdateRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClusterWorkflowTemplateServiceUpdateClusterWorkflowTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClusterWorkflowTemplateServiceApi(config);
            var name = "name_example";  // string | DEPRECATED: This field is ignored.
            var body = new IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateUpdateRequest(); // IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateUpdateRequest |

            try
            {
                IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate result = apiInstance.ClusterWorkflowTemplateServiceUpdateClusterWorkflowTemplate(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterWorkflowTemplateServiceApi.ClusterWorkflowTemplateServiceUpdateClusterWorkflowTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClusterWorkflowTemplateServiceUpdateClusterWorkflowTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate> response = apiInstance.ClusterWorkflowTemplateServiceUpdateClusterWorkflowTemplateWithHttpInfo(name, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterWorkflowTemplateServiceApi.ClusterWorkflowTemplateServiceUpdateClusterWorkflowTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | DEPRECATED: This field is ignored. |  |
| **body** | [**IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateUpdateRequest**](IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateUpdateRequest.md) |  |  |

### Return type

[**IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate**](IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate.md)

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
