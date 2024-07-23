# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1NodeStatus
NodeStatus contains status information about an individual node in the workflow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BoundaryID** | **string** | BoundaryID indicates the node ID of the associated template root node in which this node belongs to | [optional]
**Children** | **List&lt;string&gt;** | Children is a list of child node IDs | [optional]
**Daemoned** | **bool** | Daemoned tracks whether or not this node was daemoned and need to be terminated | [optional]
**DisplayName** | **string** | DisplayName is a human readable representation of the node. Unique within a template boundary | [optional]
**EstimatedDuration** | **int** | EstimatedDuration in seconds. | [optional]
**FinishedAt** | **DateTime** | Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers. | [optional]
**HostNodeName** | **string** | HostNodeName name of the Kubernetes node on which the Pod is running, if applicable | [optional]
**Id** | **string** | ID is a unique identifier of a node within the worklow It is implemented as a hash of the node name, which makes the ID deterministic |
**Inputs** | [**IoArgoprojWorkflowV1alpha1Inputs**](IoArgoprojWorkflowV1alpha1Inputs.md) |  | [optional]
**MemoizationStatus** | [**IoArgoprojWorkflowV1alpha1MemoizationStatus**](IoArgoprojWorkflowV1alpha1MemoizationStatus.md) |  | [optional]
**Message** | **string** | A human readable message indicating details about why the node is in this condition. | [optional]
**Name** | **string** | Name is unique name in the node tree used to generate the node ID |
**NodeFlag** | [**IoArgoprojWorkflowV1alpha1NodeFlag**](IoArgoprojWorkflowV1alpha1NodeFlag.md) |  | [optional]
**OutboundNodes** | **List&lt;string&gt;** | OutboundNodes tracks the node IDs which are considered \&quot;outbound\&quot; nodes to a template invocation. For every invocation of a template, there are nodes which we considered as \&quot;outbound\&quot;. Essentially, these are last nodes in the execution sequence to run, before the template is considered completed. These nodes are then connected as parents to a following step.  In the case of single pod steps (i.e. container, script, resource templates), this list will be nil since the pod itself is already considered the \&quot;outbound\&quot; node. In the case of DAGs, outbound nodes are the \&quot;target\&quot; tasks (tasks with no children). In the case of steps, outbound nodes are all the containers involved in the last step group. NOTE: since templates are composable, the list of outbound nodes are carried upwards when a DAG/steps template invokes another DAG/steps template. In other words, the outbound nodes of a template, will be a superset of the outbound nodes of its last children. | [optional]
**Outputs** | [**IoArgoprojWorkflowV1alpha1Outputs**](IoArgoprojWorkflowV1alpha1Outputs.md) |  | [optional]
**Phase** | **string** | Phase a simple, high-level summary of where the node is in its lifecycle. Can be used as a state machine. Will be one of these values \&quot;Pending\&quot;, \&quot;Running\&quot; before the node is completed, or \&quot;Succeeded\&quot;, \&quot;Skipped\&quot;, \&quot;Failed\&quot;, \&quot;Error\&quot;, or \&quot;Omitted\&quot; as a final state. | [optional]
**PodIP** | **string** | PodIP captures the IP of the pod for daemoned steps | [optional]
**Progress** | **string** | Progress to completion | [optional]
**ResourcesDuration** | **Dictionary&lt;string, long&gt;** | ResourcesDuration is indicative, but not accurate, resource duration. This is populated when the nodes completes. | [optional]
**StartedAt** | **DateTime** | Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers. | [optional]
**SynchronizationStatus** | [**IoArgoprojWorkflowV1alpha1NodeSynchronizationStatus**](IoArgoprojWorkflowV1alpha1NodeSynchronizationStatus.md) |  | [optional]
**TemplateName** | **string** | TemplateName is the template name which this node corresponds to. Not applicable to virtual nodes (e.g. Retry, StepGroup) | [optional]
**TemplateRef** | [**IoArgoprojWorkflowV1alpha1TemplateRef**](IoArgoprojWorkflowV1alpha1TemplateRef.md) |  | [optional]
**TemplateScope** | **string** | TemplateScope is the template scope in which the template of this node was retrieved. | [optional]
**Type** | **string** | Type indicates type of node |

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
