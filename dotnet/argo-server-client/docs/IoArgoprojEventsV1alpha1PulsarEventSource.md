# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1PulsarEventSource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthAthenzParams** | **Dictionary&lt;string, string&gt;** |  | [optional]
**AuthAthenzSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**AuthTokenSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**ConnectionBackoff** | [**IoArgoprojEventsV1alpha1Backoff**](IoArgoprojEventsV1alpha1Backoff.md) |  | [optional]
**Filter** | [**IoArgoprojEventsV1alpha1EventSourceFilter**](IoArgoprojEventsV1alpha1EventSourceFilter.md) |  | [optional]
**JsonBody** | **bool** |  | [optional]
**Metadata** | **Dictionary&lt;string, string&gt;** |  | [optional]
**Tls** | [**IoArgoprojEventsV1alpha1TLSConfig**](IoArgoprojEventsV1alpha1TLSConfig.md) |  | [optional]
**TlsAllowInsecureConnection** | **bool** |  | [optional]
**TlsTrustCertsSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**TlsValidateHostname** | **bool** |  | [optional]
**Topics** | **List&lt;string&gt;** |  | [optional]
**Type** | **string** |  | [optional]
**Url** | **string** |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
