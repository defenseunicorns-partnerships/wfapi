# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1SQSEventSource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessKey** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**Dlq** | **bool** |  | [optional]
**Endpoint** | **string** |  | [optional]
**Filter** | [**IoArgoprojEventsV1alpha1EventSourceFilter**](IoArgoprojEventsV1alpha1EventSourceFilter.md) |  | [optional]
**JsonBody** | **bool** |  | [optional]
**Metadata** | **Dictionary&lt;string, string&gt;** |  | [optional]
**Queue** | **string** |  | [optional]
**QueueAccountId** | **string** |  | [optional]
**Region** | **string** |  | [optional]
**RoleARN** | **string** |  | [optional]
**SecretKey** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**SessionToken** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**WaitTimeSeconds** | **string** | WaitTimeSeconds is The duration (in seconds) for which the call waits for a message to arrive in the queue before returning. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
