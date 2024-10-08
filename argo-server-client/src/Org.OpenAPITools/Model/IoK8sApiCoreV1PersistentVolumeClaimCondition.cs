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
using FileParameter = Org.OpenAPITools.Client.FileParameter;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// PersistentVolumeClaimCondition contails details about state of pvc
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.PersistentVolumeClaimCondition")]
    public partial class IoK8sApiCoreV1PersistentVolumeClaimCondition : IValidatableObject
    {
        /// <summary>
        ///    Possible enum values:  - &#x60;\&quot;FileSystemResizePending\&quot;&#x60; - controller resize is finished and a file system resize is pending on node  - &#x60;\&quot;Resizing\&quot;&#x60; - a user trigger resize of pvc has been started
        /// </summary>
        /// <value>   Possible enum values:  - &#x60;\&quot;FileSystemResizePending\&quot;&#x60; - controller resize is finished and a file system resize is pending on node  - &#x60;\&quot;Resizing\&quot;&#x60; - a user trigger resize of pvc has been started</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum FileSystemResizePending for value: FileSystemResizePending
            /// </summary>
            [EnumMember(Value = "FileSystemResizePending")]
            FileSystemResizePending = 1,

            /// <summary>
            /// Enum Resizing for value: Resizing
            /// </summary>
            [EnumMember(Value = "Resizing")]
            Resizing = 2
        }


        /// <summary>
        ///    Possible enum values:  - &#x60;\&quot;FileSystemResizePending\&quot;&#x60; - controller resize is finished and a file system resize is pending on node  - &#x60;\&quot;Resizing\&quot;&#x60; - a user trigger resize of pvc has been started
        /// </summary>
        /// <value>   Possible enum values:  - &#x60;\&quot;FileSystemResizePending\&quot;&#x60; - controller resize is finished and a file system resize is pending on node  - &#x60;\&quot;Resizing\&quot;&#x60; - a user trigger resize of pvc has been started</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1PersistentVolumeClaimCondition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1PersistentVolumeClaimCondition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1PersistentVolumeClaimCondition" /> class.
        /// </summary>
        /// <param name="lastProbeTime">Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers..</param>
        /// <param name="lastTransitionTime">Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers..</param>
        /// <param name="message">Human-readable message indicating details about last transition..</param>
        /// <param name="reason">Unique, this should be a short, machine understandable string that gives the reason for condition&#39;s last transition. If it reports \&quot;ResizeStarted\&quot; that means the underlying persistent volume is being resized..</param>
        /// <param name="status">status (required).</param>
        /// <param name="type">   Possible enum values:  - &#x60;\&quot;FileSystemResizePending\&quot;&#x60; - controller resize is finished and a file system resize is pending on node  - &#x60;\&quot;Resizing\&quot;&#x60; - a user trigger resize of pvc has been started (required).</param>
        public IoK8sApiCoreV1PersistentVolumeClaimCondition(DateTime? lastProbeTime = default(DateTime?), DateTime? lastTransitionTime = default(DateTime?), string message = default(string), string reason = default(string), string status = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for IoK8sApiCoreV1PersistentVolumeClaimCondition and cannot be null");
            }
            this.Status = status;
            this.Type = type;
            this.LastProbeTime = lastProbeTime;
            this.LastTransitionTime = lastTransitionTime;
            this.Message = message;
            this.Reason = reason;
        }

        /// <summary>
        /// Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.
        /// </summary>
        /// <value>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</value>
        [DataMember(Name = "lastProbeTime", EmitDefaultValue = false)]
        public DateTime? LastProbeTime { get; set; }

        /// <summary>
        /// Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.
        /// </summary>
        /// <value>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</value>
        [DataMember(Name = "lastTransitionTime", EmitDefaultValue = false)]
        public DateTime? LastTransitionTime { get; set; }

        /// <summary>
        /// Human-readable message indicating details about last transition.
        /// </summary>
        /// <value>Human-readable message indicating details about last transition.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Unique, this should be a short, machine understandable string that gives the reason for condition&#39;s last transition. If it reports \&quot;ResizeStarted\&quot; that means the underlying persistent volume is being resized.
        /// </summary>
        /// <value>Unique, this should be a short, machine understandable string that gives the reason for condition&#39;s last transition. If it reports \&quot;ResizeStarted\&quot; that means the underlying persistent volume is being resized.</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1PersistentVolumeClaimCondition {\n");
            sb.Append("  LastProbeTime: ").Append(LastProbeTime).Append("\n");
            sb.Append("  LastTransitionTime: ").Append(LastTransitionTime).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
