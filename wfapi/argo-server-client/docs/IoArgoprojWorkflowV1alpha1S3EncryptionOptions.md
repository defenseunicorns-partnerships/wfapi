# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1S3EncryptionOptions
S3EncryptionOptions used to determine encryption options during s3 operations

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableEncryption** | **bool** | EnableEncryption tells the driver to encrypt objects if set to true. If kmsKeyId and serverSideCustomerKeySecret are not set, SSE-S3 will be used | [optional]
**KmsEncryptionContext** | **string** | KmsEncryptionContext is a json blob that contains an encryption context. See https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context for more information | [optional]
**KmsKeyId** | **string** | KMSKeyId tells the driver to encrypt the object using the specified KMS Key. | [optional]
**ServerSideCustomerKeySecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
