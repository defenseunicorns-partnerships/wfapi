# Org.OpenAPITools.Model.IoK8sApimachineryPkgApisMetaV1LabelSelector
A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MatchExpressions** | [**List&lt;IoK8sApimachineryPkgApisMetaV1LabelSelectorRequirement&gt;**](IoK8sApimachineryPkgApisMetaV1LabelSelectorRequirement.md) | matchExpressions is a list of label selector requirements. The requirements are ANDed. | [optional]
**MatchLabels** | **Dictionary&lt;string, string&gt;** | matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is \&quot;key\&quot;, the operator is \&quot;In\&quot;, and the values array contains only \&quot;value\&quot;. The requirements are ANDed. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
