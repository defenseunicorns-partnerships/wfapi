# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1GitArtifact
GitArtifact is the location of an git artifact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Branch** | **string** | Branch is the branch to fetch when &#x60;SingleBranch&#x60; is enabled | [optional]
**Depth** | **int** | Depth specifies clones/fetches should be shallow and include the given number of commits from the branch tip | [optional]
**DisableSubmodules** | **bool** | DisableSubmodules disables submodules during git clone | [optional]
**Fetch** | **List&lt;string&gt;** | Fetch specifies a number of refs that should be fetched before checkout | [optional]
**InsecureIgnoreHostKey** | **bool** | InsecureIgnoreHostKey disables SSH strict host key checking during git clone | [optional]
**PasswordSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**Repo** | **string** | Repo is the git repository |
**Revision** | **string** | Revision is the git commit, tag, branch to checkout | [optional]
**SingleBranch** | **bool** | SingleBranch enables single branch clone, using the &#x60;branch&#x60; parameter | [optional]
**SshPrivateKeySecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**UsernameSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
