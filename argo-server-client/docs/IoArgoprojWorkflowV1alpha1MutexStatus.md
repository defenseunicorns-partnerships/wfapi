# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1MutexStatus
MutexStatus contains which objects hold  mutex locks, and which objects this workflow is waiting on to release locks.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Holding** | [**List&lt;IoArgoprojWorkflowV1alpha1MutexHolding&gt;**](IoArgoprojWorkflowV1alpha1MutexHolding.md) | Holding is a list of mutexes and their respective objects that are held by mutex lock for this io.argoproj.workflow.v1alpha1. | [optional]
**Waiting** | [**List&lt;IoArgoprojWorkflowV1alpha1MutexHolding&gt;**](IoArgoprojWorkflowV1alpha1MutexHolding.md) | Waiting is a list of mutexes and their respective objects this workflow is waiting for. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
