# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1KafkaTrigger
KafkaTrigger refers to the specification of the Kafka trigger.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Compress** | **bool** |  | [optional]
**FlushFrequency** | **int** |  | [optional]
**Parameters** | [**List&lt;IoArgoprojEventsV1alpha1TriggerParameter&gt;**](IoArgoprojEventsV1alpha1TriggerParameter.md) | Parameters is the list of parameters that is applied to resolved Kafka trigger object. | [optional]
**Partition** | **int** |  | [optional]
**PartitioningKey** | **string** | The partitioning key for the messages put on the Kafka topic. +optional. | [optional]
**Payload** | [**List&lt;IoArgoprojEventsV1alpha1TriggerParameter&gt;**](IoArgoprojEventsV1alpha1TriggerParameter.md) | Payload is the list of key-value extracted from an event payload to construct the request payload. | [optional]
**RequiredAcks** | **int** | RequiredAcks used in producer to tell the broker how many replica acknowledgements Defaults to 1 (Only wait for the leader to ack). +optional. | [optional]
**Sasl** | [**IoArgoprojEventsV1alpha1SASLConfig**](IoArgoprojEventsV1alpha1SASLConfig.md) |  | [optional]
**SchemaRegistry** | [**IoArgoprojEventsV1alpha1SchemaRegistryConfig**](IoArgoprojEventsV1alpha1SchemaRegistryConfig.md) |  | [optional]
**Tls** | [**IoArgoprojEventsV1alpha1TLSConfig**](IoArgoprojEventsV1alpha1TLSConfig.md) |  | [optional]
**Topic** | **string** |  | [optional]
**Url** | **string** | URL of the Kafka broker, multiple URLs separated by comma. | [optional]
**VarVersion** | **string** |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
