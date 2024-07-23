# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1RedisStreamEventSource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConsumerGroup** | **string** |  | [optional]
**Db** | **int** |  | [optional]
**Filter** | [**IoArgoprojEventsV1alpha1EventSourceFilter**](IoArgoprojEventsV1alpha1EventSourceFilter.md) |  | [optional]
**HostAddress** | **string** |  | [optional]
**MaxMsgCountPerRead** | **int** |  | [optional]
**Metadata** | **Dictionary&lt;string, string&gt;** |  | [optional]
**Password** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**Streams** | **List&lt;string&gt;** | Streams to look for entries. XREADGROUP is used on all streams using a single consumer group. | [optional]
**Tls** | [**IoArgoprojEventsV1alpha1TLSConfig**](IoArgoprojEventsV1alpha1TLSConfig.md) |  | [optional]
**Username** | **string** |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
