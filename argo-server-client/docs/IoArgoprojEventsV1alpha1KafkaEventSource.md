# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1KafkaEventSource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Config** | **string** | Yaml format Sarama config for Kafka connection. It follows the struct of sarama.Config. See https://github.com/IBM/sarama/blob/main/config.go e.g.  consumer:   fetch:     min: 1 net:   MaxOpenRequests: 5  +optional | [optional]
**ConnectionBackoff** | [**IoArgoprojEventsV1alpha1Backoff**](IoArgoprojEventsV1alpha1Backoff.md) |  | [optional]
**ConsumerGroup** | [**IoArgoprojEventsV1alpha1KafkaConsumerGroup**](IoArgoprojEventsV1alpha1KafkaConsumerGroup.md) |  | [optional]
**Filter** | [**IoArgoprojEventsV1alpha1EventSourceFilter**](IoArgoprojEventsV1alpha1EventSourceFilter.md) |  | [optional]
**JsonBody** | **bool** |  | [optional]
**LimitEventsPerSecond** | **string** |  | [optional]
**Metadata** | **Dictionary&lt;string, string&gt;** |  | [optional]
**Partition** | **string** |  | [optional]
**Sasl** | [**IoArgoprojEventsV1alpha1SASLConfig**](IoArgoprojEventsV1alpha1SASLConfig.md) |  | [optional]
**Tls** | [**IoArgoprojEventsV1alpha1TLSConfig**](IoArgoprojEventsV1alpha1TLSConfig.md) |  | [optional]
**Topic** | **string** |  | [optional]
**Url** | **string** |  | [optional]
**VarVersion** | **string** |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
