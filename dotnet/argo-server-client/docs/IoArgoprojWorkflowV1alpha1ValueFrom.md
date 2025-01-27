# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1ValueFrom
ValueFrom describes a location in which to obtain the value to a parameter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigMapKeyRef** | [**IoK8sApiCoreV1ConfigMapKeySelector**](IoK8sApiCoreV1ConfigMapKeySelector.md) |  | [optional]
**Default** | **string** | Default specifies a value to be used if retrieving the value from the specified source fails | [optional]
**Event** | **string** | Selector (https://github.com/expr-lang/expr) that is evaluated against the event to get the value of the parameter. E.g. &#x60;payload.message&#x60; | [optional]
**Expression** | **string** | Expression, if defined, is evaluated to specify the value for the parameter | [optional]
**JqFilter** | **string** | JQFilter expression against the resource object in resource templates | [optional]
**JsonPath** | **string** | JSONPath of a resource to retrieve an output parameter value from in resource templates | [optional]
**Parameter** | **string** | Parameter reference to a step or dag task in which to retrieve an output parameter value from (e.g. &#39;{{steps.mystep.outputs.myparam}}&#39;) | [optional]
**Path** | **string** | Path in the container to retrieve an output parameter value from in container templates | [optional]
**Supplied** | **Object** | SuppliedValueFrom is a placeholder for a value to be filled in directly, either through the CLI, API, etc. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
