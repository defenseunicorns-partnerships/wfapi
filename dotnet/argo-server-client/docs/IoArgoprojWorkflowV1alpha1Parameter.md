# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1Parameter
Parameter indicate a passed string parameter to a service template with an optional default value

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Default** | **string** | Default is the default value to use for an input parameter if a value was not supplied | [optional]
**Description** | **string** | Description is the parameter description | [optional]
**Enum** | **List&lt;string&gt;** | Enum holds a list of string values to choose from, for the actual value of the parameter | [optional]
**GlobalName** | **string** | GlobalName exports an output parameter to the global scope, making it available as &#39;{{io.argoproj.workflow.v1alpha1.outputs.parameters.XXXX}} and in workflow.status.outputs.parameters | [optional]
**Name** | **string** | Name is the parameter name |
**Value** | **string** | Value is the literal value to use for the parameter. If specified in the context of an input parameter, the value takes precedence over any passed values | [optional]
**ValueFrom** | [**IoArgoprojWorkflowV1alpha1ValueFrom**](IoArgoprojWorkflowV1alpha1ValueFrom.md) |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
