# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1EmailTrigger
EmailTrigger refers to the specification of the email notification trigger.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Body** | **string** |  | [optional]
**From** | **string** |  | [optional]
**Host** | **string** | Host refers to the smtp host url to which email is send. | [optional]
**Parameters** | [**List&lt;IoArgoprojEventsV1alpha1TriggerParameter&gt;**](IoArgoprojEventsV1alpha1TriggerParameter.md) |  | [optional]
**Port** | **int** |  | [optional]
**SmtpPassword** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**Subject** | **string** |  | [optional]
**To** | **List&lt;string&gt;** |  | [optional]
**Username** | **string** |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
