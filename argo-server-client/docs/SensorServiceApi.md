# Org.OpenAPITools.Api.SensorServiceApi

All URIs are relative to *http://localhost:2746*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SensorServiceCreateSensor**](SensorServiceApi.md#sensorservicecreatesensor) | **POST** /api/v1/sensors/{namespace} |  |
| [**SensorServiceDeleteSensor**](SensorServiceApi.md#sensorservicedeletesensor) | **DELETE** /api/v1/sensors/{namespace}/{name} |  |
| [**SensorServiceGetSensor**](SensorServiceApi.md#sensorservicegetsensor) | **GET** /api/v1/sensors/{namespace}/{name} |  |
| [**SensorServiceListSensors**](SensorServiceApi.md#sensorservicelistsensors) | **GET** /api/v1/sensors/{namespace} |  |
| [**SensorServiceSensorsLogs**](SensorServiceApi.md#sensorservicesensorslogs) | **GET** /api/v1/stream/sensors/{namespace}/logs |  |
| [**SensorServiceUpdateSensor**](SensorServiceApi.md#sensorserviceupdatesensor) | **PUT** /api/v1/sensors/{namespace}/{name} |  |
| [**SensorServiceWatchSensors**](SensorServiceApi.md#sensorservicewatchsensors) | **GET** /api/v1/stream/sensors/{namespace} |  |

<a id="sensorservicecreatesensor"></a>
# **SensorServiceCreateSensor**
> IoArgoprojEventsV1alpha1Sensor SensorServiceCreateSensor (string varNamespace, SensorCreateSensorRequest body)



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
    public class SensorServiceCreateSensorExample
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
            var apiInstance = new SensorServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var body = new SensorCreateSensorRequest(); // SensorCreateSensorRequest |

            try
            {
                IoArgoprojEventsV1alpha1Sensor result = apiInstance.SensorServiceCreateSensor(varNamespace, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SensorServiceApi.SensorServiceCreateSensor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SensorServiceCreateSensorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojEventsV1alpha1Sensor> response = apiInstance.SensorServiceCreateSensorWithHttpInfo(varNamespace, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SensorServiceApi.SensorServiceCreateSensorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **body** | [**SensorCreateSensorRequest**](SensorCreateSensorRequest.md) |  |  |

### Return type

[**IoArgoprojEventsV1alpha1Sensor**](IoArgoprojEventsV1alpha1Sensor.md)

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

<a id="sensorservicedeletesensor"></a>
# **SensorServiceDeleteSensor**
> Object SensorServiceDeleteSensor (string varNamespace, string name, string? deleteOptionsGracePeriodSeconds = null, string? deleteOptionsPreconditionsUid = null, string? deleteOptionsPreconditionsResourceVersion = null, bool? deleteOptionsOrphanDependents = null, string? deleteOptionsPropagationPolicy = null, List<string>? deleteOptionsDryRun = null)



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
    public class SensorServiceDeleteSensorExample
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
            var apiInstance = new SensorServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var deleteOptionsGracePeriodSeconds = "deleteOptionsGracePeriodSeconds_example";  // string? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. +optional. (optional)
            var deleteOptionsPreconditionsUid = "deleteOptionsPreconditionsUid_example";  // string? | Specifies the target UID. +optional. (optional)
            var deleteOptionsPreconditionsResourceVersion = "deleteOptionsPreconditionsResourceVersion_example";  // string? | Specifies the target ResourceVersion +optional. (optional)
            var deleteOptionsOrphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. +optional. (optional)
            var deleteOptionsPropagationPolicy = "deleteOptionsPropagationPolicy_example";  // string? | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. Acceptable values are: 'Orphan' - orphan the dependents; 'Background' - allow the garbage collector to delete the dependents in the background; 'Foreground' - a cascading policy that deletes all dependents in the foreground. +optional. (optional)
            var deleteOptionsDryRun = new List<string>?(); // List<string>? | When present, indicates that modifications should not be persisted. An invalid or unrecognized dryRun directive will result in an error response and no further processing of the request. Valid values are: - All: all dry run stages will be processed +optional. (optional)

            try
            {
                Object result = apiInstance.SensorServiceDeleteSensor(varNamespace, name, deleteOptionsGracePeriodSeconds, deleteOptionsPreconditionsUid, deleteOptionsPreconditionsResourceVersion, deleteOptionsOrphanDependents, deleteOptionsPropagationPolicy, deleteOptionsDryRun);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SensorServiceApi.SensorServiceDeleteSensor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SensorServiceDeleteSensorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.SensorServiceDeleteSensorWithHttpInfo(varNamespace, name, deleteOptionsGracePeriodSeconds, deleteOptionsPreconditionsUid, deleteOptionsPreconditionsResourceVersion, deleteOptionsOrphanDependents, deleteOptionsPropagationPolicy, deleteOptionsDryRun);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SensorServiceApi.SensorServiceDeleteSensorWithHttpInfo: " + e.Message);
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

<a id="sensorservicegetsensor"></a>
# **SensorServiceGetSensor**
> IoArgoprojEventsV1alpha1Sensor SensorServiceGetSensor (string varNamespace, string name, string? getOptionsResourceVersion = null)



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
    public class SensorServiceGetSensorExample
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
            var apiInstance = new SensorServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var getOptionsResourceVersion = "getOptionsResourceVersion_example";  // string? | resourceVersion sets a constraint on what resource versions a request may be served from. See https://kubernetes.io/docs/reference/using-api/api-concepts/#resource-versions for details.  Defaults to unset +optional (optional)

            try
            {
                IoArgoprojEventsV1alpha1Sensor result = apiInstance.SensorServiceGetSensor(varNamespace, name, getOptionsResourceVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SensorServiceApi.SensorServiceGetSensor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SensorServiceGetSensorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojEventsV1alpha1Sensor> response = apiInstance.SensorServiceGetSensorWithHttpInfo(varNamespace, name, getOptionsResourceVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SensorServiceApi.SensorServiceGetSensorWithHttpInfo: " + e.Message);
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

### Return type

[**IoArgoprojEventsV1alpha1Sensor**](IoArgoprojEventsV1alpha1Sensor.md)

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

<a id="sensorservicelistsensors"></a>
# **SensorServiceListSensors**
> IoArgoprojEventsV1alpha1SensorList SensorServiceListSensors (string varNamespace, string? listOptionsLabelSelector = null, string? listOptionsFieldSelector = null, bool? listOptionsWatch = null, bool? listOptionsAllowWatchBookmarks = null, string? listOptionsResourceVersion = null, string? listOptionsResourceVersionMatch = null, string? listOptionsTimeoutSeconds = null, string? listOptionsLimit = null, string? listOptionsContinue = null)



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
    public class SensorServiceListSensorsExample
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
            var apiInstance = new SensorServiceApi(httpClient, config, httpClientHandler);
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
                IoArgoprojEventsV1alpha1SensorList result = apiInstance.SensorServiceListSensors(varNamespace, listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SensorServiceApi.SensorServiceListSensors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SensorServiceListSensorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojEventsV1alpha1SensorList> response = apiInstance.SensorServiceListSensorsWithHttpInfo(varNamespace, listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SensorServiceApi.SensorServiceListSensorsWithHttpInfo: " + e.Message);
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

[**IoArgoprojEventsV1alpha1SensorList**](IoArgoprojEventsV1alpha1SensorList.md)

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

<a id="sensorservicesensorslogs"></a>
# **SensorServiceSensorsLogs**
> StreamResultOfSensorLogEntry SensorServiceSensorsLogs (string varNamespace, string? name = null, string? triggerName = null, string? grep = null, string? podLogOptionsContainer = null, bool? podLogOptionsFollow = null, bool? podLogOptionsPrevious = null, string? podLogOptionsSinceSeconds = null, string? podLogOptionsSinceTimeSeconds = null, int? podLogOptionsSinceTimeNanos = null, bool? podLogOptionsTimestamps = null, string? podLogOptionsTailLines = null, string? podLogOptionsLimitBytes = null, bool? podLogOptionsInsecureSkipTLSVerifyBackend = null)



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
    public class SensorServiceSensorsLogsExample
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
            var apiInstance = new SensorServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string? | optional - only return entries for this sensor name. (optional)
            var triggerName = "triggerName_example";  // string? | optional - only return entries for this trigger. (optional)
            var grep = "grep_example";  // string? | option - only return entries where `msg` contains this regular expressions. (optional)
            var podLogOptionsContainer = "podLogOptionsContainer_example";  // string? | The container for which to stream logs. Defaults to only container if there is one container in the pod. +optional. (optional)
            var podLogOptionsFollow = true;  // bool? | Follow the log stream of the pod. Defaults to false. +optional. (optional)
            var podLogOptionsPrevious = true;  // bool? | Return previous terminated container logs. Defaults to false. +optional. (optional)
            var podLogOptionsSinceSeconds = "podLogOptionsSinceSeconds_example";  // string? | A relative time in seconds before the current time from which to show logs. If this value precedes the time a pod was started, only logs since the pod start will be returned. If this value is in the future, no logs will be returned. Only one of sinceSeconds or sinceTime may be specified. +optional. (optional)
            var podLogOptionsSinceTimeSeconds = "podLogOptionsSinceTimeSeconds_example";  // string? | Represents seconds of UTC time since Unix epoch 1970-01-01T00:00:00Z. Must be from 0001-01-01T00:00:00Z to 9999-12-31T23:59:59Z inclusive. (optional)
            var podLogOptionsSinceTimeNanos = 56;  // int? | Non-negative fractions of a second at nanosecond resolution. Negative second values with fractions must still have non-negative nanos values that count forward in time. Must be from 0 to 999,999,999 inclusive. This field may be limited in precision depending on context. (optional)
            var podLogOptionsTimestamps = true;  // bool? | If true, add an RFC3339 or RFC3339Nano timestamp at the beginning of every line of log output. Defaults to false. +optional. (optional)
            var podLogOptionsTailLines = "podLogOptionsTailLines_example";  // string? | If set, the number of lines from the end of the logs to show. If not specified, logs are shown from the creation of the container or sinceSeconds or sinceTime +optional. (optional)
            var podLogOptionsLimitBytes = "podLogOptionsLimitBytes_example";  // string? | If set, the number of bytes to read from the server before terminating the log output. This may not display a complete final line of logging, and may return slightly more or slightly less than the specified limit. +optional. (optional)
            var podLogOptionsInsecureSkipTLSVerifyBackend = true;  // bool? | insecureSkipTLSVerifyBackend indicates that the apiserver should not confirm the validity of the serving certificate of the backend it is connecting to.  This will make the HTTPS connection between the apiserver and the backend insecure. This means the apiserver cannot verify the log data it is receiving came from the real kubelet.  If the kubelet is configured to verify the apiserver's TLS credentials, it does not mean the connection to the real kubelet is vulnerable to a man in the middle attack (e.g. an attacker could not intercept the actual log data coming from the real kubelet). +optional. (optional)

            try
            {
                StreamResultOfSensorLogEntry result = apiInstance.SensorServiceSensorsLogs(varNamespace, name, triggerName, grep, podLogOptionsContainer, podLogOptionsFollow, podLogOptionsPrevious, podLogOptionsSinceSeconds, podLogOptionsSinceTimeSeconds, podLogOptionsSinceTimeNanos, podLogOptionsTimestamps, podLogOptionsTailLines, podLogOptionsLimitBytes, podLogOptionsInsecureSkipTLSVerifyBackend);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SensorServiceApi.SensorServiceSensorsLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SensorServiceSensorsLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StreamResultOfSensorLogEntry> response = apiInstance.SensorServiceSensorsLogsWithHttpInfo(varNamespace, name, triggerName, grep, podLogOptionsContainer, podLogOptionsFollow, podLogOptionsPrevious, podLogOptionsSinceSeconds, podLogOptionsSinceTimeSeconds, podLogOptionsSinceTimeNanos, podLogOptionsTimestamps, podLogOptionsTailLines, podLogOptionsLimitBytes, podLogOptionsInsecureSkipTLSVerifyBackend);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SensorServiceApi.SensorServiceSensorsLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **name** | **string?** | optional - only return entries for this sensor name. | [optional]  |
| **triggerName** | **string?** | optional - only return entries for this trigger. | [optional]  |
| **grep** | **string?** | option - only return entries where &#x60;msg&#x60; contains this regular expressions. | [optional]  |
| **podLogOptionsContainer** | **string?** | The container for which to stream logs. Defaults to only container if there is one container in the pod. +optional. | [optional]  |
| **podLogOptionsFollow** | **bool?** | Follow the log stream of the pod. Defaults to false. +optional. | [optional]  |
| **podLogOptionsPrevious** | **bool?** | Return previous terminated container logs. Defaults to false. +optional. | [optional]  |
| **podLogOptionsSinceSeconds** | **string?** | A relative time in seconds before the current time from which to show logs. If this value precedes the time a pod was started, only logs since the pod start will be returned. If this value is in the future, no logs will be returned. Only one of sinceSeconds or sinceTime may be specified. +optional. | [optional]  |
| **podLogOptionsSinceTimeSeconds** | **string?** | Represents seconds of UTC time since Unix epoch 1970-01-01T00:00:00Z. Must be from 0001-01-01T00:00:00Z to 9999-12-31T23:59:59Z inclusive. | [optional]  |
| **podLogOptionsSinceTimeNanos** | **int?** | Non-negative fractions of a second at nanosecond resolution. Negative second values with fractions must still have non-negative nanos values that count forward in time. Must be from 0 to 999,999,999 inclusive. This field may be limited in precision depending on context. | [optional]  |
| **podLogOptionsTimestamps** | **bool?** | If true, add an RFC3339 or RFC3339Nano timestamp at the beginning of every line of log output. Defaults to false. +optional. | [optional]  |
| **podLogOptionsTailLines** | **string?** | If set, the number of lines from the end of the logs to show. If not specified, logs are shown from the creation of the container or sinceSeconds or sinceTime +optional. | [optional]  |
| **podLogOptionsLimitBytes** | **string?** | If set, the number of bytes to read from the server before terminating the log output. This may not display a complete final line of logging, and may return slightly more or slightly less than the specified limit. +optional. | [optional]  |
| **podLogOptionsInsecureSkipTLSVerifyBackend** | **bool?** | insecureSkipTLSVerifyBackend indicates that the apiserver should not confirm the validity of the serving certificate of the backend it is connecting to.  This will make the HTTPS connection between the apiserver and the backend insecure. This means the apiserver cannot verify the log data it is receiving came from the real kubelet.  If the kubelet is configured to verify the apiserver&#39;s TLS credentials, it does not mean the connection to the real kubelet is vulnerable to a man in the middle attack (e.g. an attacker could not intercept the actual log data coming from the real kubelet). +optional. | [optional]  |

### Return type

[**StreamResultOfSensorLogEntry**](StreamResultOfSensorLogEntry.md)

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

<a id="sensorserviceupdatesensor"></a>
# **SensorServiceUpdateSensor**
> IoArgoprojEventsV1alpha1Sensor SensorServiceUpdateSensor (string varNamespace, string name, SensorUpdateSensorRequest body)



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
    public class SensorServiceUpdateSensorExample
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
            var apiInstance = new SensorServiceApi(httpClient, config, httpClientHandler);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var body = new SensorUpdateSensorRequest(); // SensorUpdateSensorRequest |

            try
            {
                IoArgoprojEventsV1alpha1Sensor result = apiInstance.SensorServiceUpdateSensor(varNamespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SensorServiceApi.SensorServiceUpdateSensor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SensorServiceUpdateSensorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IoArgoprojEventsV1alpha1Sensor> response = apiInstance.SensorServiceUpdateSensorWithHttpInfo(varNamespace, name, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SensorServiceApi.SensorServiceUpdateSensorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **name** | **string** |  |  |
| **body** | [**SensorUpdateSensorRequest**](SensorUpdateSensorRequest.md) |  |  |

### Return type

[**IoArgoprojEventsV1alpha1Sensor**](IoArgoprojEventsV1alpha1Sensor.md)

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

<a id="sensorservicewatchsensors"></a>
# **SensorServiceWatchSensors**
> StreamResultOfSensorSensorWatchEvent SensorServiceWatchSensors (string varNamespace, string? listOptionsLabelSelector = null, string? listOptionsFieldSelector = null, bool? listOptionsWatch = null, bool? listOptionsAllowWatchBookmarks = null, string? listOptionsResourceVersion = null, string? listOptionsResourceVersionMatch = null, string? listOptionsTimeoutSeconds = null, string? listOptionsLimit = null, string? listOptionsContinue = null)



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
    public class SensorServiceWatchSensorsExample
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
            var apiInstance = new SensorServiceApi(httpClient, config, httpClientHandler);
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
                StreamResultOfSensorSensorWatchEvent result = apiInstance.SensorServiceWatchSensors(varNamespace, listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SensorServiceApi.SensorServiceWatchSensors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SensorServiceWatchSensorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StreamResultOfSensorSensorWatchEvent> response = apiInstance.SensorServiceWatchSensorsWithHttpInfo(varNamespace, listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SensorServiceApi.SensorServiceWatchSensorsWithHttpInfo: " + e.Message);
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

[**StreamResultOfSensorSensorWatchEvent**](StreamResultOfSensorSensorWatchEvent.md)

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
