# Org.OpenAPITools.Model.IoArgoprojEventsV1alpha1GithubEventSource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** |  | [optional]
**ApiToken** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**ContentType** | **string** |  | [optional]
**DeleteHookOnFinish** | **bool** |  | [optional]
**Events** | **List&lt;string&gt;** |  | [optional]
**Filter** | [**IoArgoprojEventsV1alpha1EventSourceFilter**](IoArgoprojEventsV1alpha1EventSourceFilter.md) |  | [optional]
**GithubApp** | [**IoArgoprojEventsV1alpha1GithubAppCreds**](IoArgoprojEventsV1alpha1GithubAppCreds.md) |  | [optional]
**GithubBaseURL** | **string** |  | [optional]
**GithubUploadURL** | **string** |  | [optional]
**Id** | **string** |  | [optional]
**Insecure** | **bool** |  | [optional]
**Metadata** | **Dictionary&lt;string, string&gt;** |  | [optional]
**Organizations** | **List&lt;string&gt;** | Organizations holds the names of organizations (used for organization level webhooks). Not required if Repositories is set. | [optional]
**Owner** | **string** |  | [optional]
**Repositories** | [**List&lt;IoArgoprojEventsV1alpha1OwnedRepositories&gt;**](IoArgoprojEventsV1alpha1OwnedRepositories.md) | Repositories holds the information of repositories, which uses repo owner as the key, and list of repo names as the value. Not required if Organizations is set. | [optional]
**Repository** | **string** |  | [optional]
**Webhook** | [**IoArgoprojEventsV1alpha1WebhookContext**](IoArgoprojEventsV1alpha1WebhookContext.md) |  | [optional]
**WebhookSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
