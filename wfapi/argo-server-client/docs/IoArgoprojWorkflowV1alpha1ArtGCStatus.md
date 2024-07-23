# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1ArtGCStatus
ArtGCStatus maintains state related to ArtifactGC

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NotSpecified** | **bool** | if this is true, we already checked to see if we need to do it and we don&#39;t | [optional]
**PodsRecouped** | **Dictionary&lt;string, bool&gt;** | have completed Pods been processed? (mapped by Pod name) used to prevent re-processing the Status of a Pod more than once | [optional]
**StrategiesProcessed** | **Dictionary&lt;string, bool&gt;** | have Pods been started to perform this strategy? (enables us not to re-process what we&#39;ve already done) | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
