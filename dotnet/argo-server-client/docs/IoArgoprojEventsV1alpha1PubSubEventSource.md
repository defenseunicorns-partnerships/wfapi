# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1PubSubEventSource
PubSubEventSource refers to event-source for GCP PubSub related events.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CredentialSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**DeleteSubscriptionOnFinish** | **bool** |  | [optional]
**Filter** | [**IoArgoprojEventsV1alpha1EventSourceFilter**](IoArgoprojEventsV1alpha1EventSourceFilter.md) |  | [optional]
**JsonBody** | **bool** |  | [optional]
**Metadata** | **Dictionary&lt;string, string&gt;** |  | [optional]
**ProjectID** | **string** |  | [optional]
**SubscriptionID** | **string** |  | [optional]
**Topic** | **string** |  | [optional]
**TopicProjectID** | **string** |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
