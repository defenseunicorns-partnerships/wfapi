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
    /// IoArgoprojEventsV1alpha1RedisStreamEventSource
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.RedisStreamEventSource")]
    public partial class IoArgoprojEventsV1alpha1RedisStreamEventSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1RedisStreamEventSource" /> class.
        /// </summary>
        /// <param name="consumerGroup">consumerGroup.</param>
        /// <param name="db">db.</param>
        /// <param name="filter">filter.</param>
        /// <param name="hostAddress">hostAddress.</param>
        /// <param name="maxMsgCountPerRead">maxMsgCountPerRead.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="password">password.</param>
        /// <param name="streams">Streams to look for entries. XREADGROUP is used on all streams using a single consumer group..</param>
        /// <param name="tls">tls.</param>
        /// <param name="username">username.</param>
        public IoArgoprojEventsV1alpha1RedisStreamEventSource(string consumerGroup = default(string), int db = default(int), IoArgoprojEventsV1alpha1EventSourceFilter filter = default(IoArgoprojEventsV1alpha1EventSourceFilter), string hostAddress = default(string), int maxMsgCountPerRead = default(int), Dictionary<string, string> metadata = default(Dictionary<string, string>), IoK8sApiCoreV1SecretKeySelector password = default(IoK8sApiCoreV1SecretKeySelector), List<string> streams = default(List<string>), IoArgoprojEventsV1alpha1TLSConfig tls = default(IoArgoprojEventsV1alpha1TLSConfig), string username = default(string))
        {
            this.ConsumerGroup = consumerGroup;
            this.Db = db;
            this.Filter = filter;
            this.HostAddress = hostAddress;
            this.MaxMsgCountPerRead = maxMsgCountPerRead;
            this.Metadata = metadata;
            this.Password = password;
            this.Streams = streams;
            this.Tls = tls;
            this.Username = username;
        }

        /// <summary>
        /// Gets or Sets ConsumerGroup
        /// </summary>
        [DataMember(Name = "consumerGroup", EmitDefaultValue = false)]
        public string ConsumerGroup { get; set; }

        /// <summary>
        /// Gets or Sets Db
        /// </summary>
        [DataMember(Name = "db", EmitDefaultValue = false)]
        public int Db { get; set; }

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
        /// Gets or Sets MaxMsgCountPerRead
        /// </summary>
        [DataMember(Name = "maxMsgCountPerRead", EmitDefaultValue = false)]
        public int MaxMsgCountPerRead { get; set; }

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
        /// Streams to look for entries. XREADGROUP is used on all streams using a single consumer group.
        /// </summary>
        /// <value>Streams to look for entries. XREADGROUP is used on all streams using a single consumer group.</value>
        [DataMember(Name = "streams", EmitDefaultValue = false)]
        public List<string> Streams { get; set; }

        /// <summary>
        /// Gets or Sets Tls
        /// </summary>
        [DataMember(Name = "tls", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1TLSConfig Tls { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1RedisStreamEventSource {\n");
            sb.Append("  ConsumerGroup: ").Append(ConsumerGroup).Append("\n");
            sb.Append("  Db: ").Append(Db).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  HostAddress: ").Append(HostAddress).Append("\n");
            sb.Append("  MaxMsgCountPerRead: ").Append(MaxMsgCountPerRead).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Streams: ").Append(Streams).Append("\n");
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
