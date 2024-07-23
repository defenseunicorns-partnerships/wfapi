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
    /// Event is a report of an event somewhere in the cluster.  Events have a limited retention time and triggers and messages may evolve with time.  Event consumers should not rely on the timing of an event with a given Reason reflecting a consistent underlying trigger, or the continued existence of events with that Reason.  Events should be treated as informative, best-effort, supplemental data.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.Event")]
    public partial class IoK8sApiCoreV1Event : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1Event" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1Event() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1Event" /> class.
        /// </summary>
        /// <param name="action">What action was taken/failed regarding to the Regarding object..</param>
        /// <param name="apiVersion">APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources.</param>
        /// <param name="count">The number of times this event has occurred..</param>
        /// <param name="eventTime">MicroTime is version of Time with microsecond level precision..</param>
        /// <param name="firstTimestamp">Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers..</param>
        /// <param name="involvedObject">involvedObject (required).</param>
        /// <param name="kind">Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds.</param>
        /// <param name="lastTimestamp">Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers..</param>
        /// <param name="message">A human-readable description of the status of this operation..</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="reason">This should be a short, machine understandable string that gives the reason for the transition into the object&#39;s current status..</param>
        /// <param name="related">related.</param>
        /// <param name="reportingComponent">Name of the controller that emitted this Event, e.g. &#x60;kubernetes.io/kubelet&#x60;..</param>
        /// <param name="reportingInstance">ID of the controller instance, e.g. &#x60;kubelet-xyzf&#x60;..</param>
        /// <param name="series">series.</param>
        /// <param name="source">source.</param>
        /// <param name="type">Type of this event (Normal, Warning), new types could be added in the future.</param>
        public IoK8sApiCoreV1Event(string action = default(string), string apiVersion = default(string), int count = default(int), DateTime eventTime = default(DateTime), DateTime firstTimestamp = default(DateTime), IoK8sApiCoreV1ObjectReference involvedObject = default(IoK8sApiCoreV1ObjectReference), string kind = default(string), DateTime lastTimestamp = default(DateTime), string message = default(string), IoK8sApimachineryPkgApisMetaV1ObjectMeta metadata = default(IoK8sApimachineryPkgApisMetaV1ObjectMeta), string reason = default(string), IoK8sApiCoreV1ObjectReference related = default(IoK8sApiCoreV1ObjectReference), string reportingComponent = default(string), string reportingInstance = default(string), IoK8sApiCoreV1EventSeries series = default(IoK8sApiCoreV1EventSeries), IoK8sApiCoreV1EventSource source = default(IoK8sApiCoreV1EventSource), string type = default(string))
        {
            // to ensure "involvedObject" is required (not null)
            if (involvedObject == null)
            {
                throw new ArgumentNullException("involvedObject is a required property for IoK8sApiCoreV1Event and cannot be null");
            }
            this.InvolvedObject = involvedObject;
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata is a required property for IoK8sApiCoreV1Event and cannot be null");
            }
            this.Metadata = metadata;
            this.Action = action;
            this.ApiVersion = apiVersion;
            this.Count = count;
            this.EventTime = eventTime;
            this.FirstTimestamp = firstTimestamp;
            this.Kind = kind;
            this.LastTimestamp = lastTimestamp;
            this.Message = message;
            this.Reason = reason;
            this.Related = related;
            this.ReportingComponent = reportingComponent;
            this.ReportingInstance = reportingInstance;
            this.Series = series;
            this.Source = source;
            this.Type = type;
        }

        /// <summary>
        /// What action was taken/failed regarding to the Regarding object.
        /// </summary>
        /// <value>What action was taken/failed regarding to the Regarding object.</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</value>
        [DataMember(Name = "apiVersion", EmitDefaultValue = false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// The number of times this event has occurred.
        /// </summary>
        /// <value>The number of times this event has occurred.</value>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// MicroTime is version of Time with microsecond level precision.
        /// </summary>
        /// <value>MicroTime is version of Time with microsecond level precision.</value>
        [DataMember(Name = "eventTime", EmitDefaultValue = false)]
        public DateTime EventTime { get; set; }

        /// <summary>
        /// Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.
        /// </summary>
        /// <value>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</value>
        [DataMember(Name = "firstTimestamp", EmitDefaultValue = false)]
        public DateTime FirstTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets InvolvedObject
        /// </summary>
        [DataMember(Name = "involvedObject", IsRequired = true, EmitDefaultValue = true)]
        public IoK8sApiCoreV1ObjectReference InvolvedObject { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</value>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public string Kind { get; set; }

        /// <summary>
        /// Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.
        /// </summary>
        /// <value>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</value>
        [DataMember(Name = "lastTimestamp", EmitDefaultValue = false)]
        public DateTime LastTimestamp { get; set; }

        /// <summary>
        /// A human-readable description of the status of this operation.
        /// </summary>
        /// <value>A human-readable description of the status of this operation.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = true)]
        public IoK8sApimachineryPkgApisMetaV1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// This should be a short, machine understandable string that gives the reason for the transition into the object&#39;s current status.
        /// </summary>
        /// <value>This should be a short, machine understandable string that gives the reason for the transition into the object&#39;s current status.</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Related
        /// </summary>
        [DataMember(Name = "related", EmitDefaultValue = false)]
        public IoK8sApiCoreV1ObjectReference Related { get; set; }

        /// <summary>
        /// Name of the controller that emitted this Event, e.g. &#x60;kubernetes.io/kubelet&#x60;.
        /// </summary>
        /// <value>Name of the controller that emitted this Event, e.g. &#x60;kubernetes.io/kubelet&#x60;.</value>
        [DataMember(Name = "reportingComponent", EmitDefaultValue = false)]
        public string ReportingComponent { get; set; }

        /// <summary>
        /// ID of the controller instance, e.g. &#x60;kubelet-xyzf&#x60;.
        /// </summary>
        /// <value>ID of the controller instance, e.g. &#x60;kubelet-xyzf&#x60;.</value>
        [DataMember(Name = "reportingInstance", EmitDefaultValue = false)]
        public string ReportingInstance { get; set; }

        /// <summary>
        /// Gets or Sets Series
        /// </summary>
        [DataMember(Name = "series", EmitDefaultValue = false)]
        public IoK8sApiCoreV1EventSeries Series { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public IoK8sApiCoreV1EventSource Source { get; set; }

        /// <summary>
        /// Type of this event (Normal, Warning), new types could be added in the future
        /// </summary>
        /// <value>Type of this event (Normal, Warning), new types could be added in the future</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1Event {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  FirstTimestamp: ").Append(FirstTimestamp).Append("\n");
            sb.Append("  InvolvedObject: ").Append(InvolvedObject).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  LastTimestamp: ").Append(LastTimestamp).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Related: ").Append(Related).Append("\n");
            sb.Append("  ReportingComponent: ").Append(ReportingComponent).Append("\n");
            sb.Append("  ReportingInstance: ").Append(ReportingInstance).Append("\n");
            sb.Append("  Series: ").Append(Series).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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