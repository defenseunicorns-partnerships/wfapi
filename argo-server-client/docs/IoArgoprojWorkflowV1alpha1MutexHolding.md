# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1MutexHolding
MutexHolding describes the mutex and the object which is holding it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Holder** | **string** | Holder is a reference to the object which holds the Mutex. Holding Scenario:   1. Current workflow&#39;s NodeID which is holding the lock.      e.g: ${NodeID} Waiting Scenario:   1. Current workflow or other workflow NodeID which is holding the lock.      e.g: ${WorkflowName}/${NodeID} | [optional]
**Mutex** | **string** | Reference for the mutex e.g: ${namespace}/mutex/${mutexName} | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
