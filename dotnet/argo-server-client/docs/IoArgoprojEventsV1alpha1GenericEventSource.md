# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1GenericEventSource
GenericEventSource refers to a generic event source. It can be used to implement a custom event source.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**Config** | **string** |  | [optional]
**Filter** | [**IoArgoprojEventsV1alpha1EventSourceFilter**](IoArgoprojEventsV1alpha1EventSourceFilter.md) |  | [optional]
**Insecure** | **bool** | Insecure determines the type of connection. | [optional]
**JsonBody** | **bool** |  | [optional]
**Metadata** | **Dictionary&lt;string, string&gt;** |  | [optional]
**Url** | **string** | URL of the gRPC server that implements the event source. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
