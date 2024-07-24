# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1BitbucketServerEventSource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessToken** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**BitbucketserverBaseURL** | **string** |  | [optional]
**DeleteHookOnFinish** | **bool** |  | [optional]
**Events** | **List&lt;string&gt;** |  | [optional]
**Filter** | [**IoArgoprojEventsV1alpha1EventSourceFilter**](IoArgoprojEventsV1alpha1EventSourceFilter.md) |  | [optional]
**Metadata** | **Dictionary&lt;string, string&gt;** |  | [optional]
**ProjectKey** | **string** |  | [optional]
**Repositories** | [**List&lt;IoArgoprojEventsV1alpha1BitbucketServerRepository&gt;**](IoArgoprojEventsV1alpha1BitbucketServerRepository.md) |  | [optional]
**RepositorySlug** | **string** |  | [optional]
**Tls** | [**IoArgoprojEventsV1alpha1TLSConfig**](IoArgoprojEventsV1alpha1TLSConfig.md) |  | [optional]
**Webhook** | [**IoArgoprojEventsV1alpha1WebhookContext**](IoArgoprojEventsV1alpha1WebhookContext.md) |  | [optional]
**WebhookSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
