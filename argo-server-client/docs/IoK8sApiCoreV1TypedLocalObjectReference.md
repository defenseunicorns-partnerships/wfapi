# Org.OpenAPITools.Model.IoK8sApiCoreV1TypedLocalObjectReference
TypedLocalObjectReference contains enough information to let you locate the typed referenced object inside the same namespace.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiGroup** | **string** | APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required. | [optional]
**Kind** | **string** | Kind is the type of resource being referenced |
**Name** | **string** | Name is the name of resource being referenced |

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
