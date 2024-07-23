# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1ArtifactRepositoryRefStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArtifactRepository** | [**IoArgoprojWorkflowV1alpha1ArtifactRepository**](IoArgoprojWorkflowV1alpha1ArtifactRepository.md) |  | [optional]
**ConfigMap** | **string** | The name of the config map. Defaults to \&quot;artifact-repositories\&quot;. | [optional]
**Default** | **bool** | If this ref represents the default artifact repository, rather than a config map. | [optional]
**Key** | **string** | The config map key. Defaults to the value of the \&quot;workflows.argoproj.io/default-artifact-repository\&quot; annotation. | [optional]
**Namespace** | **string** | The namespace of the config map. Defaults to the workflow&#39;s namespace, or the controller&#39;s namespace (if found). | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
