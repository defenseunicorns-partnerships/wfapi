# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1StorageGridEventSource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiURL** | **string** | APIURL is the url of the storagegrid api. | [optional]
**AuthToken** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**Bucket** | **string** | Name of the bucket to register notifications for. | [optional]
**Events** | **List&lt;string&gt;** |  | [optional]
**Filter** | [**IoArgoprojEventsV1alpha1StorageGridFilter**](IoArgoprojEventsV1alpha1StorageGridFilter.md) |  | [optional]
**Metadata** | **Dictionary&lt;string, string&gt;** |  | [optional]
**Region** | **string** |  | [optional]
**TopicArn** | **string** |  | [optional]
**Webhook** | [**IoArgoprojEventsV1alpha1WebhookContext**](IoArgoprojEventsV1alpha1WebhookContext.md) |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
