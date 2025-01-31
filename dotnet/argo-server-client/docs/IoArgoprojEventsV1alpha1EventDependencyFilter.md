# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1EventDependencyFilter
EventDependencyFilter defines filters and constraints for a io.argoproj.workflow.v1alpha1.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Context** | [**IoArgoprojEventsV1alpha1EventContext**](IoArgoprojEventsV1alpha1EventContext.md) |  | [optional]
**Data** | [**List&lt;IoArgoprojEventsV1alpha1DataFilter&gt;**](IoArgoprojEventsV1alpha1DataFilter.md) |  | [optional]
**DataLogicalOperator** | **string** | DataLogicalOperator defines how multiple Data filters (if defined) are evaluated together. Available values: and (&amp;&amp;), or (||) Is optional and if left blank treated as and (&amp;&amp;). | [optional]
**ExprLogicalOperator** | **string** | ExprLogicalOperator defines how multiple Exprs filters (if defined) are evaluated together. Available values: and (&amp;&amp;), or (||) Is optional and if left blank treated as and (&amp;&amp;). | [optional]
**Exprs** | [**List&lt;IoArgoprojEventsV1alpha1ExprFilter&gt;**](IoArgoprojEventsV1alpha1ExprFilter.md) | Exprs contains the list of expressions evaluated against the event payload. | [optional]
**Script** | **string** | Script refers to a Lua script evaluated to determine the validity of an io.argoproj.workflow.v1alpha1. | [optional]
**Time** | [**IoArgoprojEventsV1alpha1TimeFilter**](IoArgoprojEventsV1alpha1TimeFilter.md) |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
