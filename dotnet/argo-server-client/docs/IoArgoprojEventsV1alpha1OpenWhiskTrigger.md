# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1OpenWhiskTrigger
OpenWhiskTrigger refers to the specification of the OpenWhisk trigger.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActionName** | **string** | Name of the action/function. | [optional]
**AuthToken** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**Host** | **string** | Host URL of the OpenWhisk. | [optional]
**Namespace** | **string** | Namespace for the action. Defaults to \&quot;_\&quot;. +optional. | [optional]
**Parameters** | [**List&lt;IoArgoprojEventsV1alpha1TriggerParameter&gt;**](IoArgoprojEventsV1alpha1TriggerParameter.md) |  | [optional]
**Payload** | [**List&lt;IoArgoprojEventsV1alpha1TriggerParameter&gt;**](IoArgoprojEventsV1alpha1TriggerParameter.md) | Payload is the list of key-value extracted from an event payload to construct the request payload. | [optional]
**VarVersion** | **string** |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
