# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1Artifact
Artifact indicates an artifact to place at a specified path

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Archive** | [**IoArgoprojWorkflowV1alpha1ArchiveStrategy**](IoArgoprojWorkflowV1alpha1ArchiveStrategy.md) |  | [optional]
**ArchiveLogs** | **bool** | ArchiveLogs indicates if the container logs should be archived | [optional]
**ArtifactGC** | [**IoArgoprojWorkflowV1alpha1ArtifactGC**](IoArgoprojWorkflowV1alpha1ArtifactGC.md) |  | [optional]
**Artifactory** | [**IoArgoprojWorkflowV1alpha1ArtifactoryArtifact**](IoArgoprojWorkflowV1alpha1ArtifactoryArtifact.md) |  | [optional]
**Azure** | [**IoArgoprojWorkflowV1alpha1AzureArtifact**](IoArgoprojWorkflowV1alpha1AzureArtifact.md) |  | [optional]
**Deleted** | **bool** | Has this been deleted? | [optional]
**From** | **string** | From allows an artifact to reference an artifact from a previous step | [optional]
**FromExpression** | **string** | FromExpression, if defined, is evaluated to specify the value for the artifact | [optional]
**Gcs** | [**IoArgoprojWorkflowV1alpha1GCSArtifact**](IoArgoprojWorkflowV1alpha1GCSArtifact.md) |  | [optional]
**Git** | [**IoArgoprojWorkflowV1alpha1GitArtifact**](IoArgoprojWorkflowV1alpha1GitArtifact.md) |  | [optional]
**GlobalName** | **string** | GlobalName exports an output artifact to the global scope, making it available as &#39;{{io.argoproj.workflow.v1alpha1.outputs.artifacts.XXXX}} and in workflow.status.outputs.artifacts | [optional]
**Hdfs** | [**IoArgoprojWorkflowV1alpha1HDFSArtifact**](IoArgoprojWorkflowV1alpha1HDFSArtifact.md) |  | [optional]
**Http** | [**IoArgoprojWorkflowV1alpha1HTTPArtifact**](IoArgoprojWorkflowV1alpha1HTTPArtifact.md) |  | [optional]
**Mode** | **int** | mode bits to use on this file, must be a value between 0 and 0777 set when loading input artifacts. | [optional]
**Name** | **string** | name of the artifact. must be unique within a template&#39;s inputs/outputs. |
**Optional** | **bool** | Make Artifacts optional, if Artifacts doesn&#39;t generate or exist | [optional]
**Oss** | [**IoArgoprojWorkflowV1alpha1OSSArtifact**](IoArgoprojWorkflowV1alpha1OSSArtifact.md) |  | [optional]
**Path** | **string** | Path is the container path to the artifact | [optional]
**Raw** | [**IoArgoprojWorkflowV1alpha1RawArtifact**](IoArgoprojWorkflowV1alpha1RawArtifact.md) |  | [optional]
**RecurseMode** | **bool** | If mode is set, apply the permission recursively into the artifact if it is a folder | [optional]
**S3** | [**IoArgoprojWorkflowV1alpha1S3Artifact**](IoArgoprojWorkflowV1alpha1S3Artifact.md) |  | [optional]
**SubPath** | **string** | SubPath allows an artifact to be sourced from a subpath within the specified source | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
