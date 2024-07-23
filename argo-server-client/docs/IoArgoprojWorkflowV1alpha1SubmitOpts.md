# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1SubmitOpts
SubmitOpts are workflow submission options

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Annotations** | **string** | Annotations adds to metadata.labels | [optional]
**DryRun** | **bool** | DryRun validates the workflow on the client-side without creating it. This option is not supported in API | [optional]
**EntryPoint** | **string** | Entrypoint overrides spec.entrypoint | [optional]
**GenerateName** | **string** | GenerateName overrides metadata.generateName | [optional]
**Labels** | **string** | Labels adds to metadata.labels | [optional]
**Name** | **string** | Name overrides metadata.name | [optional]
**OwnerReference** | [**IoK8sApimachineryPkgApisMetaV1OwnerReference**](IoK8sApimachineryPkgApisMetaV1OwnerReference.md) |  | [optional]
**Parameters** | **List&lt;string&gt;** | Parameters passes input parameters to workflow | [optional]
**PodPriorityClassName** | **string** | Set the podPriorityClassName of the workflow | [optional]
**Priority** | **int** | Priority is used if controller is configured to process limited number of workflows in parallel, higher priority workflows are processed first. | [optional]
**ServerDryRun** | **bool** | ServerDryRun validates the workflow on the server-side without creating it | [optional]
**ServiceAccount** | **string** | ServiceAccount runs all pods in the workflow using specified ServiceAccount. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
