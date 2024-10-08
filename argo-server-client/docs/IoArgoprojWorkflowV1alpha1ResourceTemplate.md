# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1ResourceTemplate
ResourceTemplate is a template subtype to manipulate kubernetes resources

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | Action is the action to perform to the resource. Must be one of: get, create, apply, delete, replace, patch |
**FailureCondition** | **string** | FailureCondition is a label selector expression which describes the conditions of the k8s resource in which the step was considered failed | [optional]
**Flags** | **List&lt;string&gt;** | Flags is a set of additional options passed to kubectl before submitting a resource I.e. to disable resource validation: flags: [  \&quot;- -validate&#x3D;false\&quot;  # disable resource validation ] | [optional]
**Manifest** | **string** | Manifest contains the kubernetes manifest | [optional]
**ManifestFrom** | [**IoArgoprojWorkflowV1alpha1ManifestFrom**](IoArgoprojWorkflowV1alpha1ManifestFrom.md) |  | [optional]
**MergeStrategy** | **string** | MergeStrategy is the strategy used to merge a patch. It defaults to \&quot;strategic\&quot; Must be one of: strategic, merge, json | [optional]
**SetOwnerReference** | **bool** | SetOwnerReference sets the reference to the workflow on the OwnerReference of generated resource. | [optional]
**SuccessCondition** | **string** | SuccessCondition is a label selector expression which describes the conditions of the k8s resource in which it is acceptable to proceed to the following step | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
