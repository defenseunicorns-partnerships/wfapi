# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1GitlabEventSource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessToken** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**DeleteHookOnFinish** | **bool** |  | [optional]
**EnableSSLVerification** | **bool** |  | [optional]
**Events** | **List&lt;string&gt;** | Events are gitlab event to listen to. Refer https://github.com/xanzy/go-gitlab/blob/bf34eca5d13a9f4c3f501d8a97b8ac226d55e4d9/projects.go#L794. | [optional]
**Filter** | [**IoArgoprojEventsV1alpha1EventSourceFilter**](IoArgoprojEventsV1alpha1EventSourceFilter.md) |  | [optional]
**GitlabBaseURL** | **string** |  | [optional]
**Groups** | **List&lt;string&gt;** |  | [optional]
**Metadata** | **Dictionary&lt;string, string&gt;** |  | [optional]
**ProjectID** | **string** |  | [optional]
**Projects** | **List&lt;string&gt;** |  | [optional]
**SecretToken** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**Webhook** | [**IoArgoprojEventsV1alpha1WebhookContext**](IoArgoprojEventsV1alpha1WebhookContext.md) |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
