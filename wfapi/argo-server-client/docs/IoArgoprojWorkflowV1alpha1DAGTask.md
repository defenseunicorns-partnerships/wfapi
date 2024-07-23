# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1DAGTask
DAGTask represents a node in the graph during DAG execution

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Arguments** | [**IoArgoprojWorkflowV1alpha1Arguments**](IoArgoprojWorkflowV1alpha1Arguments.md) |  | [optional]
**ContinueOn** | [**IoArgoprojWorkflowV1alpha1ContinueOn**](IoArgoprojWorkflowV1alpha1ContinueOn.md) |  | [optional]
**Dependencies** | **List&lt;string&gt;** | Dependencies are name of other targets which this depends on | [optional]
**Depends** | **string** | Depends are name of other targets which this depends on | [optional]
**Hooks** | [**Dictionary&lt;string, IoArgoprojWorkflowV1alpha1LifecycleHook&gt;**](IoArgoprojWorkflowV1alpha1LifecycleHook.md) | Hooks hold the lifecycle hook which is invoked at lifecycle of task, irrespective of the success, failure, or error status of the primary task | [optional]
**Inline** | [**IoArgoprojWorkflowV1alpha1Template**](IoArgoprojWorkflowV1alpha1Template.md) |  | [optional]
**Name** | **string** | Name is the name of the target |
**OnExit** | **string** | OnExit is a template reference which is invoked at the end of the template, irrespective of the success, failure, or error of the primary template. DEPRECATED: Use Hooks[exit].Template instead. | [optional]
**Template** | **string** | Name of template to execute | [optional]
**TemplateRef** | [**IoArgoprojWorkflowV1alpha1TemplateRef**](IoArgoprojWorkflowV1alpha1TemplateRef.md) |  | [optional]
**When** | **string** | When is an expression in which the task should conditionally execute | [optional]
**WithItems** | **List&lt;Object&gt;** | WithItems expands a task into multiple parallel tasks from the items in the list | [optional]
**WithParam** | **string** | WithParam expands a task into multiple parallel tasks from the value in the parameter, which is expected to be a JSON list. | [optional]
**WithSequence** | [**IoArgoprojWorkflowV1alpha1Sequence**](IoArgoprojWorkflowV1alpha1Sequence.md) |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
