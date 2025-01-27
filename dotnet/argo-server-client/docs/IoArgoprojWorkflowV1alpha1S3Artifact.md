# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1S3Artifact
S3Artifact is the location of an S3 artifact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessKeySecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**Bucket** | **string** | Bucket is the name of the bucket | [optional]
**CaSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**CreateBucketIfNotPresent** | [**IoArgoprojWorkflowV1alpha1CreateS3BucketOptions**](IoArgoprojWorkflowV1alpha1CreateS3BucketOptions.md) |  | [optional]
**EncryptionOptions** | [**IoArgoprojWorkflowV1alpha1S3EncryptionOptions**](IoArgoprojWorkflowV1alpha1S3EncryptionOptions.md) |  | [optional]
**Endpoint** | **string** | Endpoint is the hostname of the bucket endpoint | [optional]
**Insecure** | **bool** | Insecure will connect to the service with TLS | [optional]
**Key** | **string** | Key is the key in the bucket where the artifact resides | [optional]
**Region** | **string** | Region contains the optional bucket region | [optional]
**RoleARN** | **string** | RoleARN is the Amazon Resource Name (ARN) of the role to assume. | [optional]
**SecretKeySecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**UseSDKCreds** | **bool** | UseSDKCreds tells the driver to figure out credentials based on sdk defaults. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
