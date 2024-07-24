# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1ArtifactoryArtifactRepository
ArtifactoryArtifactRepository defines the controller configuration for an artifactory artifact repository

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeyFormat** | **string** | KeyFormat defines the format of how to store keys and can reference workflow variables. | [optional]
**PasswordSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**RepoURL** | **string** | RepoURL is the url for artifactory repo. | [optional]
**UsernameSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
