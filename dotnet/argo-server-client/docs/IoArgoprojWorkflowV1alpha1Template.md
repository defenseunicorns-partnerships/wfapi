# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1Template
Template is a reusable and composable unit of execution in a workflow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveDeadlineSeconds** | **string** |  | [optional]
**Affinity** | [**IoK8sApiCoreV1Affinity**](IoK8sApiCoreV1Affinity.md) |  | [optional]
**ArchiveLocation** | [**IoArgoprojWorkflowV1alpha1ArtifactLocation**](IoArgoprojWorkflowV1alpha1ArtifactLocation.md) |  | [optional]
**AutomountServiceAccountToken** | **bool** | AutomountServiceAccountToken indicates whether a service account token should be automatically mounted in pods. ServiceAccountName of ExecutorConfig must be specified if this value is false. | [optional]
**Container** | [**IoK8sApiCoreV1Container**](IoK8sApiCoreV1Container.md) |  | [optional]
**ContainerSet** | [**IoArgoprojWorkflowV1alpha1ContainerSetTemplate**](IoArgoprojWorkflowV1alpha1ContainerSetTemplate.md) |  | [optional]
**Daemon** | **bool** | Daemon will allow a workflow to proceed to the next step so long as the container reaches readiness | [optional]
**Dag** | [**IoArgoprojWorkflowV1alpha1DAGTemplate**](IoArgoprojWorkflowV1alpha1DAGTemplate.md) |  | [optional]
**Data** | [**IoArgoprojWorkflowV1alpha1Data**](IoArgoprojWorkflowV1alpha1Data.md) |  | [optional]
**Executor** | [**IoArgoprojWorkflowV1alpha1ExecutorConfig**](IoArgoprojWorkflowV1alpha1ExecutorConfig.md) |  | [optional]
**FailFast** | **bool** | FailFast, if specified, will fail this template if any of its child pods has failed. This is useful for when this template is expanded with &#x60;withItems&#x60;, etc. | [optional]
**HostAliases** | [**List&lt;IoK8sApiCoreV1HostAlias&gt;**](IoK8sApiCoreV1HostAlias.md) | HostAliases is an optional list of hosts and IPs that will be injected into the pod spec | [optional]
**Http** | [**IoArgoprojWorkflowV1alpha1HTTP**](IoArgoprojWorkflowV1alpha1HTTP.md) |  | [optional]
**InitContainers** | [**List&lt;IoArgoprojWorkflowV1alpha1UserContainer&gt;**](IoArgoprojWorkflowV1alpha1UserContainer.md) | InitContainers is a list of containers which run before the main container. | [optional]
**Inputs** | [**IoArgoprojWorkflowV1alpha1Inputs**](IoArgoprojWorkflowV1alpha1Inputs.md) |  | [optional]
**Memoize** | [**IoArgoprojWorkflowV1alpha1Memoize**](IoArgoprojWorkflowV1alpha1Memoize.md) |  | [optional]
**Metadata** | [**IoArgoprojWorkflowV1alpha1Metadata**](IoArgoprojWorkflowV1alpha1Metadata.md) |  | [optional]
**Metrics** | [**IoArgoprojWorkflowV1alpha1Metrics**](IoArgoprojWorkflowV1alpha1Metrics.md) |  | [optional]
**Name** | **string** | Name is the name of the template | [optional]
**NodeSelector** | **Dictionary&lt;string, string&gt;** | NodeSelector is a selector to schedule this step of the workflow to be run on the selected node(s). Overrides the selector set at the workflow level. | [optional]
**Outputs** | [**IoArgoprojWorkflowV1alpha1Outputs**](IoArgoprojWorkflowV1alpha1Outputs.md) |  | [optional]
**Parallelism** | **int** | Parallelism limits the max total parallel pods that can execute at the same time within the boundaries of this template invocation. If additional steps/dag templates are invoked, the pods created by those templates will not be counted towards this total. | [optional]
**Plugin** | **Object** | Plugin is an Object with exactly one key | [optional]
**PodSpecPatch** | **string** | PodSpecPatch holds strategic merge patch to apply against the pod spec. Allows parameterization of container fields which are not strings (e.g. resource limits). | [optional]
**Priority** | **int** | Priority to apply to workflow pods. | [optional]
**PriorityClassName** | **string** | PriorityClassName to apply to workflow pods. | [optional]
**Resource** | [**IoArgoprojWorkflowV1alpha1ResourceTemplate**](IoArgoprojWorkflowV1alpha1ResourceTemplate.md) |  | [optional]
**RetryStrategy** | [**IoArgoprojWorkflowV1alpha1RetryStrategy**](IoArgoprojWorkflowV1alpha1RetryStrategy.md) |  | [optional]
**SchedulerName** | **string** | If specified, the pod will be dispatched by specified scheduler. Or it will be dispatched by workflow scope scheduler if specified. If neither specified, the pod will be dispatched by default scheduler. | [optional]
**Script** | [**IoArgoprojWorkflowV1alpha1ScriptTemplate**](IoArgoprojWorkflowV1alpha1ScriptTemplate.md) |  | [optional]
**SecurityContext** | [**IoK8sApiCoreV1PodSecurityContext**](IoK8sApiCoreV1PodSecurityContext.md) |  | [optional]
**ServiceAccountName** | **string** | ServiceAccountName to apply to workflow pods | [optional]
**Sidecars** | [**List&lt;IoArgoprojWorkflowV1alpha1UserContainer&gt;**](IoArgoprojWorkflowV1alpha1UserContainer.md) | Sidecars is a list of containers which run alongside the main container Sidecars are automatically killed when the main container completes | [optional]
**Steps** | **List&lt;List&lt;IoArgoprojWorkflowV1alpha1WorkflowStep&gt;&gt;** | Steps define a series of sequential/parallel workflow steps | [optional]
**Suspend** | [**IoArgoprojWorkflowV1alpha1SuspendTemplate**](IoArgoprojWorkflowV1alpha1SuspendTemplate.md) |  | [optional]
**Synchronization** | [**IoArgoprojWorkflowV1alpha1Synchronization**](IoArgoprojWorkflowV1alpha1Synchronization.md) |  | [optional]
**Timeout** | **string** | Timeout allows to set the total node execution timeout duration counting from the node&#39;s start time. This duration also includes time in which the node spends in Pending state. This duration may not be applied to Step or DAG templates. | [optional]
**Tolerations** | [**List&lt;IoK8sApiCoreV1Toleration&gt;**](IoK8sApiCoreV1Toleration.md) | Tolerations to apply to workflow pods. | [optional]
**Volumes** | [**List&lt;IoK8sApiCoreV1Volume&gt;**](IoK8sApiCoreV1Volume.md) | Volumes is a list of volumes that can be mounted by containers in a template. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
