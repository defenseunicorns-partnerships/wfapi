/*
 * Argo Workflows API
 *
 * Argo Workflows is an open source container-native workflow engine for orchestrating parallel jobs on Kubernetes. For more information, please see https://argo-workflows.readthedocs.io/en/latest/
 *
 * The version of the OpenAPI document: VERSION
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// NodeStatus contains status information about an individual node in the workflow
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.NodeStatus")]
    public partial class IoArgoprojWorkflowV1alpha1NodeStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1NodeStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoArgoprojWorkflowV1alpha1NodeStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1NodeStatus" /> class.
        /// </summary>
        /// <param name="boundaryID">BoundaryID indicates the node ID of the associated template root node in which this node belongs to.</param>
        /// <param name="children">Children is a list of child node IDs.</param>
        /// <param name="daemoned">Daemoned tracks whether or not this node was daemoned and need to be terminated.</param>
        /// <param name="displayName">DisplayName is a human readable representation of the node. Unique within a template boundary.</param>
        /// <param name="estimatedDuration">EstimatedDuration in seconds..</param>
        /// <param name="finishedAt">Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers..</param>
        /// <param name="hostNodeName">HostNodeName name of the Kubernetes node on which the Pod is running, if applicable.</param>
        /// <param name="id">ID is a unique identifier of a node within the worklow It is implemented as a hash of the node name, which makes the ID deterministic (required).</param>
        /// <param name="inputs">inputs.</param>
        /// <param name="memoizationStatus">memoizationStatus.</param>
        /// <param name="message">A human readable message indicating details about why the node is in this condition..</param>
        /// <param name="name">Name is unique name in the node tree used to generate the node ID (required).</param>
        /// <param name="nodeFlag">nodeFlag.</param>
        /// <param name="outboundNodes">OutboundNodes tracks the node IDs which are considered \&quot;outbound\&quot; nodes to a template invocation. For every invocation of a template, there are nodes which we considered as \&quot;outbound\&quot;. Essentially, these are last nodes in the execution sequence to run, before the template is considered completed. These nodes are then connected as parents to a following step.  In the case of single pod steps (i.e. container, script, resource templates), this list will be nil since the pod itself is already considered the \&quot;outbound\&quot; node. In the case of DAGs, outbound nodes are the \&quot;target\&quot; tasks (tasks with no children). In the case of steps, outbound nodes are all the containers involved in the last step group. NOTE: since templates are composable, the list of outbound nodes are carried upwards when a DAG/steps template invokes another DAG/steps template. In other words, the outbound nodes of a template, will be a superset of the outbound nodes of its last children..</param>
        /// <param name="outputs">outputs.</param>
        /// <param name="phase">Phase a simple, high-level summary of where the node is in its lifecycle. Can be used as a state machine. Will be one of these values \&quot;Pending\&quot;, \&quot;Running\&quot; before the node is completed, or \&quot;Succeeded\&quot;, \&quot;Skipped\&quot;, \&quot;Failed\&quot;, \&quot;Error\&quot;, or \&quot;Omitted\&quot; as a final state..</param>
        /// <param name="podIP">PodIP captures the IP of the pod for daemoned steps.</param>
        /// <param name="progress">Progress to completion.</param>
        /// <param name="resourcesDuration">ResourcesDuration is indicative, but not accurate, resource duration. This is populated when the nodes completes..</param>
        /// <param name="startedAt">Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers..</param>
        /// <param name="synchronizationStatus">synchronizationStatus.</param>
        /// <param name="templateName">TemplateName is the template name which this node corresponds to. Not applicable to virtual nodes (e.g. Retry, StepGroup).</param>
        /// <param name="templateRef">templateRef.</param>
        /// <param name="templateScope">TemplateScope is the template scope in which the template of this node was retrieved..</param>
        /// <param name="type">Type indicates type of node (required).</param>
        public IoArgoprojWorkflowV1alpha1NodeStatus(string boundaryID = default(string), List<string> children = default(List<string>), bool daemoned = default(bool), string displayName = default(string), int estimatedDuration = default(int), DateTime? finishedAt = default(DateTime?), string hostNodeName = default(string), string id = default(string), IoArgoprojWorkflowV1alpha1Inputs inputs = default(IoArgoprojWorkflowV1alpha1Inputs), IoArgoprojWorkflowV1alpha1MemoizationStatus memoizationStatus = default(IoArgoprojWorkflowV1alpha1MemoizationStatus), string message = default(string), string name = default(string), IoArgoprojWorkflowV1alpha1NodeFlag nodeFlag = default(IoArgoprojWorkflowV1alpha1NodeFlag), List<string> outboundNodes = default(List<string>), IoArgoprojWorkflowV1alpha1Outputs outputs = default(IoArgoprojWorkflowV1alpha1Outputs), string phase = default(string), string podIP = default(string), string progress = default(string), Dictionary<string, long> resourcesDuration = default(Dictionary<string, long>), DateTime? startedAt = default(DateTime?), IoArgoprojWorkflowV1alpha1NodeSynchronizationStatus synchronizationStatus = default(IoArgoprojWorkflowV1alpha1NodeSynchronizationStatus), string templateName = default(string), IoArgoprojWorkflowV1alpha1TemplateRef templateRef = default(IoArgoprojWorkflowV1alpha1TemplateRef), string templateScope = default(string), string type = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for IoArgoprojWorkflowV1alpha1NodeStatus and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for IoArgoprojWorkflowV1alpha1NodeStatus and cannot be null");
            }
            this.Name = name;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for IoArgoprojWorkflowV1alpha1NodeStatus and cannot be null");
            }
            this.Type = type;
            this.BoundaryID = boundaryID;
            this.Children = children;
            this.Daemoned = daemoned;
            this.DisplayName = displayName;
            this.EstimatedDuration = estimatedDuration;
            this.FinishedAt = finishedAt;
            this.HostNodeName = hostNodeName;
            this.Inputs = inputs;
            this.MemoizationStatus = memoizationStatus;
            this.Message = message;
            this.NodeFlag = nodeFlag;
            this.OutboundNodes = outboundNodes;
            this.Outputs = outputs;
            this.Phase = phase;
            this.PodIP = podIP;
            this.Progress = progress;
            this.ResourcesDuration = resourcesDuration;
            this.StartedAt = startedAt;
            this.SynchronizationStatus = synchronizationStatus;
            this.TemplateName = templateName;
            this.TemplateRef = templateRef;
            this.TemplateScope = templateScope;
        }

        /// <summary>
        /// BoundaryID indicates the node ID of the associated template root node in which this node belongs to
        /// </summary>
        /// <value>BoundaryID indicates the node ID of the associated template root node in which this node belongs to</value>
        [DataMember(Name = "boundaryID", EmitDefaultValue = false)]
        public string BoundaryID { get; set; }

        /// <summary>
        /// Children is a list of child node IDs
        /// </summary>
        /// <value>Children is a list of child node IDs</value>
        [DataMember(Name = "children", EmitDefaultValue = false)]
        public List<string> Children { get; set; }

        /// <summary>
        /// Daemoned tracks whether or not this node was daemoned and need to be terminated
        /// </summary>
        /// <value>Daemoned tracks whether or not this node was daemoned and need to be terminated</value>
        [DataMember(Name = "daemoned", EmitDefaultValue = true)]
        public bool Daemoned { get; set; }

        /// <summary>
        /// DisplayName is a human readable representation of the node. Unique within a template boundary
        /// </summary>
        /// <value>DisplayName is a human readable representation of the node. Unique within a template boundary</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// EstimatedDuration in seconds.
        /// </summary>
        /// <value>EstimatedDuration in seconds.</value>
        [DataMember(Name = "estimatedDuration", EmitDefaultValue = false)]
        public int EstimatedDuration { get; set; }

        /// <summary>
        /// Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.
        /// </summary>
        /// <value>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</value>
        [DataMember(Name = "finishedAt", EmitDefaultValue = false)]
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// HostNodeName name of the Kubernetes node on which the Pod is running, if applicable
        /// </summary>
        /// <value>HostNodeName name of the Kubernetes node on which the Pod is running, if applicable</value>
        [DataMember(Name = "hostNodeName", EmitDefaultValue = false)]
        public string HostNodeName { get; set; }

        /// <summary>
        /// ID is a unique identifier of a node within the worklow It is implemented as a hash of the node name, which makes the ID deterministic
        /// </summary>
        /// <value>ID is a unique identifier of a node within the worklow It is implemented as a hash of the node name, which makes the ID deterministic</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name = "inputs", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1Inputs Inputs { get; set; }

        /// <summary>
        /// Gets or Sets MemoizationStatus
        /// </summary>
        [DataMember(Name = "memoizationStatus", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1MemoizationStatus MemoizationStatus { get; set; }

        /// <summary>
        /// A human readable message indicating details about why the node is in this condition.
        /// </summary>
        /// <value>A human readable message indicating details about why the node is in this condition.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Name is unique name in the node tree used to generate the node ID
        /// </summary>
        /// <value>Name is unique name in the node tree used to generate the node ID</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NodeFlag
        /// </summary>
        [DataMember(Name = "nodeFlag", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1NodeFlag NodeFlag { get; set; }

        /// <summary>
        /// OutboundNodes tracks the node IDs which are considered \&quot;outbound\&quot; nodes to a template invocation. For every invocation of a template, there are nodes which we considered as \&quot;outbound\&quot;. Essentially, these are last nodes in the execution sequence to run, before the template is considered completed. These nodes are then connected as parents to a following step.  In the case of single pod steps (i.e. container, script, resource templates), this list will be nil since the pod itself is already considered the \&quot;outbound\&quot; node. In the case of DAGs, outbound nodes are the \&quot;target\&quot; tasks (tasks with no children). In the case of steps, outbound nodes are all the containers involved in the last step group. NOTE: since templates are composable, the list of outbound nodes are carried upwards when a DAG/steps template invokes another DAG/steps template. In other words, the outbound nodes of a template, will be a superset of the outbound nodes of its last children.
        /// </summary>
        /// <value>OutboundNodes tracks the node IDs which are considered \&quot;outbound\&quot; nodes to a template invocation. For every invocation of a template, there are nodes which we considered as \&quot;outbound\&quot;. Essentially, these are last nodes in the execution sequence to run, before the template is considered completed. These nodes are then connected as parents to a following step.  In the case of single pod steps (i.e. container, script, resource templates), this list will be nil since the pod itself is already considered the \&quot;outbound\&quot; node. In the case of DAGs, outbound nodes are the \&quot;target\&quot; tasks (tasks with no children). In the case of steps, outbound nodes are all the containers involved in the last step group. NOTE: since templates are composable, the list of outbound nodes are carried upwards when a DAG/steps template invokes another DAG/steps template. In other words, the outbound nodes of a template, will be a superset of the outbound nodes of its last children.</value>
        [DataMember(Name = "outboundNodes", EmitDefaultValue = false)]
        public List<string> OutboundNodes { get; set; }

        /// <summary>
        /// Gets or Sets Outputs
        /// </summary>
        [DataMember(Name = "outputs", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1Outputs Outputs { get; set; }

        /// <summary>
        /// Phase a simple, high-level summary of where the node is in its lifecycle. Can be used as a state machine. Will be one of these values \&quot;Pending\&quot;, \&quot;Running\&quot; before the node is completed, or \&quot;Succeeded\&quot;, \&quot;Skipped\&quot;, \&quot;Failed\&quot;, \&quot;Error\&quot;, or \&quot;Omitted\&quot; as a final state.
        /// </summary>
        /// <value>Phase a simple, high-level summary of where the node is in its lifecycle. Can be used as a state machine. Will be one of these values \&quot;Pending\&quot;, \&quot;Running\&quot; before the node is completed, or \&quot;Succeeded\&quot;, \&quot;Skipped\&quot;, \&quot;Failed\&quot;, \&quot;Error\&quot;, or \&quot;Omitted\&quot; as a final state.</value>
        [DataMember(Name = "phase", EmitDefaultValue = false)]
        public string Phase { get; set; }

        /// <summary>
        /// PodIP captures the IP of the pod for daemoned steps
        /// </summary>
        /// <value>PodIP captures the IP of the pod for daemoned steps</value>
        [DataMember(Name = "podIP", EmitDefaultValue = false)]
        public string PodIP { get; set; }

        /// <summary>
        /// Progress to completion
        /// </summary>
        /// <value>Progress to completion</value>
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public string Progress { get; set; }

        /// <summary>
        /// ResourcesDuration is indicative, but not accurate, resource duration. This is populated when the nodes completes.
        /// </summary>
        /// <value>ResourcesDuration is indicative, but not accurate, resource duration. This is populated when the nodes completes.</value>
        [DataMember(Name = "resourcesDuration", EmitDefaultValue = false)]
        public Dictionary<string, long> ResourcesDuration { get; set; }

        /// <summary>
        /// Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.
        /// </summary>
        /// <value>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</value>
        [DataMember(Name = "startedAt", EmitDefaultValue = false)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Gets or Sets SynchronizationStatus
        /// </summary>
        [DataMember(Name = "synchronizationStatus", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1NodeSynchronizationStatus SynchronizationStatus { get; set; }

        /// <summary>
        /// TemplateName is the template name which this node corresponds to. Not applicable to virtual nodes (e.g. Retry, StepGroup)
        /// </summary>
        /// <value>TemplateName is the template name which this node corresponds to. Not applicable to virtual nodes (e.g. Retry, StepGroup)</value>
        [DataMember(Name = "templateName", EmitDefaultValue = false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Gets or Sets TemplateRef
        /// </summary>
        [DataMember(Name = "templateRef", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1TemplateRef TemplateRef { get; set; }

        /// <summary>
        /// TemplateScope is the template scope in which the template of this node was retrieved.
        /// </summary>
        /// <value>TemplateScope is the template scope in which the template of this node was retrieved.</value>
        [DataMember(Name = "templateScope", EmitDefaultValue = false)]
        public string TemplateScope { get; set; }

        /// <summary>
        /// Type indicates type of node
        /// </summary>
        /// <value>Type indicates type of node</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1NodeStatus {\n");
            sb.Append("  BoundaryID: ").Append(BoundaryID).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Daemoned: ").Append(Daemoned).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  EstimatedDuration: ").Append(EstimatedDuration).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  HostNodeName: ").Append(HostNodeName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  MemoizationStatus: ").Append(MemoizationStatus).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NodeFlag: ").Append(NodeFlag).Append("\n");
            sb.Append("  OutboundNodes: ").Append(OutboundNodes).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  PodIP: ").Append(PodIP).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  ResourcesDuration: ").Append(ResourcesDuration).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  SynchronizationStatus: ").Append(SynchronizationStatus).Append("\n");
            sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
            sb.Append("  TemplateRef: ").Append(TemplateRef).Append("\n");
            sb.Append("  TemplateScope: ").Append(TemplateScope).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}