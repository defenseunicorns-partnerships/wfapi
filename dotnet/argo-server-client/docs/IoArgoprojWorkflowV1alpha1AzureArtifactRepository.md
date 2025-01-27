# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1AzureArtifactRepository
AzureArtifactRepository defines the controller configuration for an Azure Blob Storage artifact repository

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountKeySecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**BlobNameFormat** | **string** | BlobNameFormat is defines the format of how to store blob names. Can reference workflow variables | [optional]
**Container** | **string** | Container is the container where resources will be stored |
**Endpoint** | **string** | Endpoint is the service url associated with an account. It is most likely \&quot;https://&lt;ACCOUNT_NAME&gt;.blob.core.windows.net\&quot; |
**UseSDKCreds** | **bool** | UseSDKCreds tells the driver to figure out credentials based on sdk defaults. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
