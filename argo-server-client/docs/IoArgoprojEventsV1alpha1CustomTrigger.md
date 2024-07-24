# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1CustomTrigger
CustomTrigger refers to the specification of the custom trigger.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**Parameters** | [**List&lt;IoArgoprojEventsV1alpha1TriggerParameter&gt;**](IoArgoprojEventsV1alpha1TriggerParameter.md) | Parameters is the list of parameters that is applied to resolved custom trigger trigger object. | [optional]
**Payload** | [**List&lt;IoArgoprojEventsV1alpha1TriggerParameter&gt;**](IoArgoprojEventsV1alpha1TriggerParameter.md) | Payload is the list of key-value extracted from an event payload to construct the request payload. | [optional]
**Secure** | **bool** |  | [optional]
**ServerNameOverride** | **string** | ServerNameOverride for the secure connection between sensor and custom trigger gRPC server. | [optional]
**ServerURL** | **string** |  | [optional]
**Spec** | **Dictionary&lt;string, string&gt;** | Spec is the custom trigger resource specification that custom trigger gRPC server knows how to interpret. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
