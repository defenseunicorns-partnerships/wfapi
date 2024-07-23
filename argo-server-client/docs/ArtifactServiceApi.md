# Org.OpenAPITools.Api.ArtifactServiceApi

All URIs are relative to *http://localhost:2746*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ArtifactServiceGetArtifactFile**](ArtifactServiceApi.md#artifactservicegetartifactfile) | **GET** /artifact-files/{namespace}/{idDiscriminator}/{id}/{nodeId}/{artifactDiscriminator}/{artifactName} | Get an artifact. |
| [**ArtifactServiceGetInputArtifact**](ArtifactServiceApi.md#artifactservicegetinputartifact) | **GET** /input-artifacts/{namespace}/{name}/{nodeId}/{artifactName} | Get an input artifact. |
| [**ArtifactServiceGetInputArtifactByUID**](ArtifactServiceApi.md#artifactservicegetinputartifactbyuid) | **GET** /input-artifacts-by-uid/{uid}/{nodeId}/{artifactName} | Get an input artifact by UID. |
| [**ArtifactServiceGetOutputArtifact**](ArtifactServiceApi.md#artifactservicegetoutputartifact) | **GET** /artifacts/{namespace}/{name}/{nodeId}/{artifactName} | Get an output artifact. |
| [**ArtifactServiceGetOutputArtifactByUID**](ArtifactServiceApi.md#artifactservicegetoutputartifactbyuid) | **GET** /artifacts-by-uid/{uid}/{nodeId}/{artifactName} | Get an output artifact by UID. |

<a id="artifactservicegetartifactfile"></a>
# **ArtifactServiceGetArtifactFile**
> System.IO.Stream ArtifactServiceGetArtifactFile (string varNamespace, string idDiscriminator, string id, string nodeId, string artifactName, string artifactDiscriminator)

Get an artifact.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArtifactServiceGetArtifactFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArtifactServiceApi(config);
            var varNamespace = "varNamespace_example";  // string |
            var idDiscriminator = "workflow";  // string |
            var id = "id_example";  // string |
            var nodeId = "nodeId_example";  // string |
            var artifactName = "artifactName_example";  // string |
            var artifactDiscriminator = "outputs";  // string |

            try
            {
                // Get an artifact.
                System.IO.Stream result = apiInstance.ArtifactServiceGetArtifactFile(varNamespace, idDiscriminator, id, nodeId, artifactName, artifactDiscriminator);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArtifactServiceApi.ArtifactServiceGetArtifactFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArtifactServiceGetArtifactFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an artifact.
    ApiResponse<System.IO.Stream> response = apiInstance.ArtifactServiceGetArtifactFileWithHttpInfo(varNamespace, idDiscriminator, id, nodeId, artifactName, artifactDiscriminator);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArtifactServiceApi.ArtifactServiceGetArtifactFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **idDiscriminator** | **string** |  |  |
| **id** | **string** |  |  |
| **nodeId** | **string** |  |  |
| **artifactName** | **string** |  |  |
| **artifactDiscriminator** | **string** |  |  |

### Return type

**System.IO.Stream**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An artifact file. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="artifactservicegetinputartifact"></a>
# **ArtifactServiceGetInputArtifact**
> System.IO.Stream ArtifactServiceGetInputArtifact (string varNamespace, string name, string nodeId, string artifactName)

Get an input artifact.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArtifactServiceGetInputArtifactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArtifactServiceApi(config);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var nodeId = "nodeId_example";  // string |
            var artifactName = "artifactName_example";  // string |

            try
            {
                // Get an input artifact.
                System.IO.Stream result = apiInstance.ArtifactServiceGetInputArtifact(varNamespace, name, nodeId, artifactName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArtifactServiceApi.ArtifactServiceGetInputArtifact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArtifactServiceGetInputArtifactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an input artifact.
    ApiResponse<System.IO.Stream> response = apiInstance.ArtifactServiceGetInputArtifactWithHttpInfo(varNamespace, name, nodeId, artifactName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArtifactServiceApi.ArtifactServiceGetInputArtifactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **name** | **string** |  |  |
| **nodeId** | **string** |  |  |
| **artifactName** | **string** |  |  |

### Return type

**System.IO.Stream**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An artifact file. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="artifactservicegetinputartifactbyuid"></a>
# **ArtifactServiceGetInputArtifactByUID**
> System.IO.Stream ArtifactServiceGetInputArtifactByUID (string uid, string nodeId, string artifactName)

Get an input artifact by UID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArtifactServiceGetInputArtifactByUIDExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArtifactServiceApi(config);
            var uid = "uid_example";  // string |
            var nodeId = "nodeId_example";  // string |
            var artifactName = "artifactName_example";  // string |

            try
            {
                // Get an input artifact by UID.
                System.IO.Stream result = apiInstance.ArtifactServiceGetInputArtifactByUID(uid, nodeId, artifactName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArtifactServiceApi.ArtifactServiceGetInputArtifactByUID: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArtifactServiceGetInputArtifactByUIDWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an input artifact by UID.
    ApiResponse<System.IO.Stream> response = apiInstance.ArtifactServiceGetInputArtifactByUIDWithHttpInfo(uid, nodeId, artifactName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArtifactServiceApi.ArtifactServiceGetInputArtifactByUIDWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uid** | **string** |  |  |
| **nodeId** | **string** |  |  |
| **artifactName** | **string** |  |  |

### Return type

**System.IO.Stream**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An artifact file. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="artifactservicegetoutputartifact"></a>
# **ArtifactServiceGetOutputArtifact**
> System.IO.Stream ArtifactServiceGetOutputArtifact (string varNamespace, string name, string nodeId, string artifactName)

Get an output artifact.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArtifactServiceGetOutputArtifactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArtifactServiceApi(config);
            var varNamespace = "varNamespace_example";  // string |
            var name = "name_example";  // string |
            var nodeId = "nodeId_example";  // string |
            var artifactName = "artifactName_example";  // string |

            try
            {
                // Get an output artifact.
                System.IO.Stream result = apiInstance.ArtifactServiceGetOutputArtifact(varNamespace, name, nodeId, artifactName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArtifactServiceApi.ArtifactServiceGetOutputArtifact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArtifactServiceGetOutputArtifactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an output artifact.
    ApiResponse<System.IO.Stream> response = apiInstance.ArtifactServiceGetOutputArtifactWithHttpInfo(varNamespace, name, nodeId, artifactName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArtifactServiceApi.ArtifactServiceGetOutputArtifactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varNamespace** | **string** |  |  |
| **name** | **string** |  |  |
| **nodeId** | **string** |  |  |
| **artifactName** | **string** |  |  |

### Return type

**System.IO.Stream**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An artifact file. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="artifactservicegetoutputartifactbyuid"></a>
# **ArtifactServiceGetOutputArtifactByUID**
> System.IO.Stream ArtifactServiceGetOutputArtifactByUID (string uid, string nodeId, string artifactName)

Get an output artifact by UID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArtifactServiceGetOutputArtifactByUIDExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:2746";
            // Configure API key authorization: BearerToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArtifactServiceApi(config);
            var uid = "uid_example";  // string |
            var nodeId = "nodeId_example";  // string |
            var artifactName = "artifactName_example";  // string |

            try
            {
                // Get an output artifact by UID.
                System.IO.Stream result = apiInstance.ArtifactServiceGetOutputArtifactByUID(uid, nodeId, artifactName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArtifactServiceApi.ArtifactServiceGetOutputArtifactByUID: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArtifactServiceGetOutputArtifactByUIDWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an output artifact by UID.
    ApiResponse<System.IO.Stream> response = apiInstance.ArtifactServiceGetOutputArtifactByUIDWithHttpInfo(uid, nodeId, artifactName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArtifactServiceApi.ArtifactServiceGetOutputArtifactByUIDWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uid** | **string** |  |  |
| **nodeId** | **string** |  |  |
| **artifactName** | **string** |  |  |

### Return type

**System.IO.Stream**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An artifact file. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
