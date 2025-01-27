# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1WorkflowStatus
WorkflowStatus contains overall status information about a workflow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArtifactGCStatus** | [**IoArgoprojWorkflowV1alpha1ArtGCStatus**](IoArgoprojWorkflowV1alpha1ArtGCStatus.md) |  | [optional]
**ArtifactRepositoryRef** | [**IoArgoprojWorkflowV1alpha1ArtifactRepositoryRefStatus**](IoArgoprojWorkflowV1alpha1ArtifactRepositoryRefStatus.md) |  | [optional]
**CompressedNodes** | **string** | Compressed and base64 decoded Nodes map | [optional]
**Conditions** | [**List&lt;IoArgoprojWorkflowV1alpha1Condition&gt;**](IoArgoprojWorkflowV1alpha1Condition.md) | Conditions is a list of conditions the Workflow may have | [optional]
**EstimatedDuration** | **int** | EstimatedDuration in seconds. | [optional]
**FinishedAt** | **DateTime?** | Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers. | [optional]
**Message** | **string** | A human readable message indicating details about why the workflow is in this condition. | [optional]
**Nodes** | [**Dictionary&lt;string, IoArgoprojWorkflowV1alpha1NodeStatus&gt;**](IoArgoprojWorkflowV1alpha1NodeStatus.md) | Nodes is a mapping between a node ID and the node&#39;s status. | [optional]
**OffloadNodeStatusVersion** | **string** | Whether on not node status has been offloaded to a database. If exists, then Nodes and CompressedNodes will be empty. This will actually be populated with a hash of the offloaded data. | [optional]
**Outputs** | [**IoArgoprojWorkflowV1alpha1Outputs**](IoArgoprojWorkflowV1alpha1Outputs.md) |  | [optional]
**PersistentVolumeClaims** | [**List&lt;IoK8sApiCoreV1Volume&gt;**](IoK8sApiCoreV1Volume.md) | PersistentVolumeClaims tracks all PVCs that were created as part of the io.argoproj.workflow.v1alpha1. The contents of this list are drained at the end of the workflow. | [optional]
**Phase** | **string** | Phase a simple, high-level summary of where the workflow is in its lifecycle. Will be \&quot;\&quot; (Unknown), \&quot;Pending\&quot;, or \&quot;Running\&quot; before the workflow is completed, and \&quot;Succeeded\&quot;, \&quot;Failed\&quot; or \&quot;Error\&quot; once the workflow has completed. | [optional]
**Progress** | **string** | Progress to completion | [optional]
**ResourcesDuration** | **Dictionary&lt;string, long&gt;** | ResourcesDuration is the total for the workflow | [optional]
**StartedAt** | **DateTime?** | Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers. | [optional]
**StoredTemplates** | [**Dictionary&lt;string, IoArgoprojWorkflowV1alpha1Template&gt;**](IoArgoprojWorkflowV1alpha1Template.md) | StoredTemplates is a mapping between a template ref and the node&#39;s status. | [optional]
**StoredWorkflowTemplateSpec** | [**IoArgoprojWorkflowV1alpha1WorkflowSpec**](IoArgoprojWorkflowV1alpha1WorkflowSpec.md) |  | [optional]
**Synchronization** | [**IoArgoprojWorkflowV1alpha1SynchronizationStatus**](IoArgoprojWorkflowV1alpha1SynchronizationStatus.md) |  | [optional]
**TaskResultsCompletionStatus** | **Dictionary&lt;string, bool&gt;** | TaskResultsCompletionStatus tracks task result completion status (mapped by node ID). Used to prevent premature archiving and garbage collection. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
