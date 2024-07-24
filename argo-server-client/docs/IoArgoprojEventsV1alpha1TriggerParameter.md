# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1TriggerParameter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dest** | **string** | Dest is the JSONPath of a resource key. A path is a series of keys separated by a dot. The colon character can be escaped with &#39;.&#39; The -1 key can be used to append a value to an existing array. See https://github.com/tidwall/sjson#path-syntax for more information about how this is used. | [optional]
**Operation** | **string** | Operation is what to do with the existing value at Dest, whether to &#39;prepend&#39;, &#39;overwrite&#39;, or &#39;append&#39; it. | [optional]
**Src** | [**IoArgoprojEventsV1alpha1TriggerParameterSource**](IoArgoprojEventsV1alpha1TriggerParameterSource.md) |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
