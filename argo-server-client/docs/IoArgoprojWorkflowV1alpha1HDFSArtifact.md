# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1HDFSArtifact
HDFSArtifact is the location of an HDFS artifact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Addresses** | **List&lt;string&gt;** | Addresses is accessible addresses of HDFS name nodes | [optional]
**Force** | **bool** | Force copies a file forcibly even if it exists | [optional]
**HdfsUser** | **string** | HDFSUser is the user to access HDFS file system. It is ignored if either ccache or keytab is used. | [optional]
**KrbCCacheSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**KrbConfigConfigMap** | [**IoK8sApiCoreV1ConfigMapKeySelector**](IoK8sApiCoreV1ConfigMapKeySelector.md) |  | [optional]
**KrbKeytabSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional]
**KrbRealm** | **string** | KrbRealm is the Kerberos realm used with Kerberos keytab It must be set if keytab is used. | [optional]
**KrbServicePrincipalName** | **string** | KrbServicePrincipalName is the principal name of Kerberos service It must be set if either ccache or keytab is used. | [optional]
**KrbUsername** | **string** | KrbUsername is the Kerberos username used with Kerberos keytab It must be set if keytab is used. | [optional]
**Path** | **string** | Path is a file path in HDFS |

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
