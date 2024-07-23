# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1SensorSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dependencies** | [**List&lt;IoArgoprojEventsV1alpha1EventDependency&gt;**](IoArgoprojEventsV1alpha1EventDependency.md) | Dependencies is a list of the events that this sensor is dependent on. | [optional]
**ErrorOnFailedRound** | **bool** | ErrorOnFailedRound if set to true, marks sensor state as &#x60;error&#x60; if the previous trigger round fails. Once sensor state is set to &#x60;error&#x60;, no further triggers will be processed. | [optional]
**EventBusName** | **string** |  | [optional]
**LoggingFields** | **Dictionary&lt;string, string&gt;** |  | [optional]
**Replicas** | **int** |  | [optional]
**RevisionHistoryLimit** | **int** |  | [optional]
**Template** | [**IoArgoprojEventsV1alpha1Template**](IoArgoprojEventsV1alpha1Template.md) |  | [optional]
**Triggers** | [**List&lt;IoArgoprojEventsV1alpha1Trigger&gt;**](IoArgoprojEventsV1alpha1Trigger.md) | Triggers is a list of the things that this sensor evokes. These are the outputs from this sensor. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
