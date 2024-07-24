# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1CronWorkflowStatus
CronWorkflowStatus is the status of a CronWorkflow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | [**List&lt;IoK8sApiCoreV1ObjectReference&gt;**](IoK8sApiCoreV1ObjectReference.md) | Active is a list of active workflows stemming from this CronWorkflow |
**Conditions** | [**List&lt;IoArgoprojWorkflowV1alpha1Condition&gt;**](IoArgoprojWorkflowV1alpha1Condition.md) | Conditions is a list of conditions the CronWorkflow may have |
**Failed** | **int** | v3.6 and after: Failed counts how many times child workflows failed |
**LastScheduledTime** | **DateTime?** | Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers. |
**Phase** | **string** | v3.6 and after: Phase is an enum of Active or Stopped. It changes to Stopped when stopStrategy.condition is true |
**Succeeded** | **int** | v3.6 and after: Succeeded counts how many times child workflows succeeded |

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
