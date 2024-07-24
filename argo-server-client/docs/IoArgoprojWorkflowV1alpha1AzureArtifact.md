# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1AzureArtifact
AzureArtifact is the location of a an Azure Storage artifact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountKeySecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**Blob** | **string** | Blob is the blob name (i.e., path) in the container where the artifact resides |
**Container** | **string** | Container is the container where resources will be stored |
**Endpoint** | **string** | Endpoint is the service url associated with an account. It is most likely \&quot;https://&lt;ACCOUNT_NAME&gt;.blob.core.windows.net\&quot; |
**UseSDKCreds** | **bool** | UseSDKCreds tells the driver to figure out credentials based on sdk defaults. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
