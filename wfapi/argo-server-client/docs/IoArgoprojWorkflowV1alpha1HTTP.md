# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1HTTP

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Body** | **string** | Body is content of the HTTP Request | [optional]
**BodyFrom** | [**IoArgoprojWorkflowV1alpha1HTTPBodySource**](IoArgoprojWorkflowV1alpha1HTTPBodySource.md) |  | [optional]
**Headers** | [**List&lt;IoArgoprojWorkflowV1alpha1HTTPHeader&gt;**](IoArgoprojWorkflowV1alpha1HTTPHeader.md) | Headers are an optional list of headers to send with HTTP requests | [optional]
**InsecureSkipVerify** | **bool** | InsecureSkipVerify is a bool when if set to true will skip TLS verification for the HTTP client | [optional]
**Method** | **string** | Method is HTTP methods for HTTP Request | [optional]
**SuccessCondition** | **string** | SuccessCondition is an expression if evaluated to true is considered successful | [optional]
**TimeoutSeconds** | **int** | TimeoutSeconds is request timeout for HTTP Request. Default is 30 seconds | [optional]
**Url** | **string** | URL of the HTTP Request |

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
