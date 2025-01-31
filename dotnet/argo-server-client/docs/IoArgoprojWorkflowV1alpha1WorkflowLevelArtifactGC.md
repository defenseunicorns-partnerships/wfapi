# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1WorkflowLevelArtifactGC
WorkflowLevelArtifactGC describes how to delete artifacts from completed Workflows - this spec is used on the Workflow level

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ForceFinalizerRemoval** | **bool** | ForceFinalizerRemoval: if set to true, the finalizer will be removed in the case that Artifact GC fails | [optional]
**PodMetadata** | [**IoArgoprojWorkflowV1alpha1Metadata**](IoArgoprojWorkflowV1alpha1Metadata.md) |  | [optional]
**PodSpecPatch** | **string** | PodSpecPatch holds strategic merge patch to apply against the artgc pod spec. | [optional]
**ServiceAccountName** | **string** | ServiceAccountName is an optional field for specifying the Service Account that should be assigned to the Pod doing the deletion | [optional]
**Strategy** | **string** | Strategy is the strategy to use. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
