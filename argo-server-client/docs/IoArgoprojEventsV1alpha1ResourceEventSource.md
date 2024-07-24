# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1ResourceEventSource
ResourceEventSource refers to a event-source for K8s resource related events.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventTypes** | **List&lt;string&gt;** | EventTypes is the list of event type to watch. Possible values are - ADD, UPDATE and DELETE. | [optional]
**Filter** | [**IoArgoprojEventsV1alpha1ResourceFilter**](IoArgoprojEventsV1alpha1ResourceFilter.md) |  | [optional]
**GroupVersionResource** | [**IoK8sApimachineryPkgApisMetaV1GroupVersionResource**](IoK8sApimachineryPkgApisMetaV1GroupVersionResource.md) |  | [optional]
**Metadata** | **Dictionary&lt;string, string&gt;** |  | [optional]
**Namespace** | **string** |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
