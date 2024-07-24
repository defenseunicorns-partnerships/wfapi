# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1OSSArtifact
OSSArtifact is the location of an Alibaba Cloud OSS artifact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessKeySecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**Bucket** | **string** | Bucket is the name of the bucket | [optional]
**CreateBucketIfNotPresent** | **bool** | CreateBucketIfNotPresent tells the driver to attempt to create the OSS bucket for output artifacts, if it doesn&#39;t exist | [optional]
**Endpoint** | **string** | Endpoint is the hostname of the bucket endpoint | [optional]
**Key** | **string** | Key is the path in the bucket where the artifact resides |
**LifecycleRule** | [**IoArgoprojWorkflowV1alpha1OSSLifecycleRule**](IoArgoprojWorkflowV1alpha1OSSLifecycleRule.md) |  | [optional]
**SecretKeySecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**SecurityToken** | **string** | SecurityToken is the user&#39;s temporary security token. For more details, check out: https://www.alibabacloud.com/help/doc-detail/100624.htm | [optional]
**UseSDKCreds** | **bool** | UseSDKCreds tells the driver to figure out credentials based on sdk defaults. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
