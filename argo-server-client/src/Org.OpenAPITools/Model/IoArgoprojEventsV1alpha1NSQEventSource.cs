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
    /// IoArgoprojEventsV1alpha1NSQEventSource
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.NSQEventSource")]
    public partial class IoArgoprojEventsV1alpha1NSQEventSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1NSQEventSource" /> class.
        /// </summary>
        /// <param name="channel">channel.</param>
        /// <param name="connectionBackoff">connectionBackoff.</param>
        /// <param name="filter">filter.</param>
        /// <param name="hostAddress">hostAddress.</param>
        /// <param name="jsonBody">jsonBody.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="tls">tls.</param>
        /// <param name="topic">Topic to subscribe to..</param>
        public IoArgoprojEventsV1alpha1NSQEventSource(string channel = default(string), IoArgoprojEventsV1alpha1Backoff connectionBackoff = default(IoArgoprojEventsV1alpha1Backoff), IoArgoprojEventsV1alpha1EventSourceFilter filter = default(IoArgoprojEventsV1alpha1EventSourceFilter), string hostAddress = default(string), bool jsonBody = default(bool), Dictionary<string, string> metadata = default(Dictionary<string, string>), IoArgoprojEventsV1alpha1TLSConfig tls = default(IoArgoprojEventsV1alpha1TLSConfig), string topic = default(string))
        {
            this.Channel = channel;
            this.ConnectionBackoff = connectionBackoff;
            this.Filter = filter;
            this.HostAddress = hostAddress;
            this.JsonBody = jsonBody;
            this.Metadata = metadata;
            this.Tls = tls;
            this.Topic = topic;
        }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string Channel { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionBackoff
        /// </summary>
        [DataMember(Name = "connectionBackoff", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1Backoff ConnectionBackoff { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1EventSourceFilter Filter { get; set; }

        /// <summary>
        /// Gets or Sets HostAddress
        /// </summary>
        [DataMember(Name = "hostAddress", EmitDefaultValue = false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// Gets or Sets JsonBody
        /// </summary>
        [DataMember(Name = "jsonBody", EmitDefaultValue = true)]
        public bool JsonBody { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Tls
        /// </summary>
        [DataMember(Name = "tls", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1TLSConfig Tls { get; set; }

        /// <summary>
        /// Topic to subscribe to.
        /// </summary>
        /// <value>Topic to subscribe to.</value>
        [DataMember(Name = "topic", EmitDefaultValue = false)]
        public string Topic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1NSQEventSource {\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  ConnectionBackoff: ").Append(ConnectionBackoff).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  HostAddress: ").Append(HostAddress).Append("\n");
            sb.Append("  JsonBody: ").Append(JsonBody).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Tls: ").Append(Tls).Append("\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
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
