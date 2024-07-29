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
    /// IoArgoprojEventsV1alpha1EmitterEventSource
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.EmitterEventSource")]
    public partial class IoArgoprojEventsV1alpha1EmitterEventSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1EmitterEventSource" /> class.
        /// </summary>
        /// <param name="broker">Broker URI to connect to..</param>
        /// <param name="channelKey">channelKey.</param>
        /// <param name="channelName">channelName.</param>
        /// <param name="connectionBackoff">connectionBackoff.</param>
        /// <param name="filter">filter.</param>
        /// <param name="jsonBody">jsonBody.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="password">password.</param>
        /// <param name="tls">tls.</param>
        /// <param name="username">username.</param>
        public IoArgoprojEventsV1alpha1EmitterEventSource(string broker = default(string), string channelKey = default(string), string channelName = default(string), IoArgoprojEventsV1alpha1Backoff connectionBackoff = default(IoArgoprojEventsV1alpha1Backoff), IoArgoprojEventsV1alpha1EventSourceFilter filter = default(IoArgoprojEventsV1alpha1EventSourceFilter), bool jsonBody = default(bool), Dictionary<string, string> metadata = default(Dictionary<string, string>), IoK8sApiCoreV1SecretKeySelector password = default(IoK8sApiCoreV1SecretKeySelector), IoArgoprojEventsV1alpha1TLSConfig tls = default(IoArgoprojEventsV1alpha1TLSConfig), IoK8sApiCoreV1SecretKeySelector username = default(IoK8sApiCoreV1SecretKeySelector))
        {
            this.Broker = broker;
            this.ChannelKey = channelKey;
            this.ChannelName = channelName;
            this.ConnectionBackoff = connectionBackoff;
            this.Filter = filter;
            this.JsonBody = jsonBody;
            this.Metadata = metadata;
            this.Password = password;
            this.Tls = tls;
            this.Username = username;
        }

        /// <summary>
        /// Broker URI to connect to.
        /// </summary>
        /// <value>Broker URI to connect to.</value>
        [DataMember(Name = "broker", EmitDefaultValue = false)]
        public string Broker { get; set; }

        /// <summary>
        /// Gets or Sets ChannelKey
        /// </summary>
        [DataMember(Name = "channelKey", EmitDefaultValue = false)]
        public string ChannelKey { get; set; }

        /// <summary>
        /// Gets or Sets ChannelName
        /// </summary>
        [DataMember(Name = "channelName", EmitDefaultValue = false)]
        public string ChannelName { get; set; }

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
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector Password { get; set; }

        /// <summary>
        /// Gets or Sets Tls
        /// </summary>
        [DataMember(Name = "tls", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1TLSConfig Tls { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1EmitterEventSource {\n");
            sb.Append("  Broker: ").Append(Broker).Append("\n");
            sb.Append("  ChannelKey: ").Append(ChannelKey).Append("\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
            sb.Append("  ConnectionBackoff: ").Append(ConnectionBackoff).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  JsonBody: ").Append(JsonBody).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Tls: ").Append(Tls).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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