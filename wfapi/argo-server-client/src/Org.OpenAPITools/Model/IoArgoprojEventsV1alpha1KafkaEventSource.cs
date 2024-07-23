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
    /// IoArgoprojEventsV1alpha1KafkaEventSource
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.KafkaEventSource")]
    public partial class IoArgoprojEventsV1alpha1KafkaEventSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1KafkaEventSource" /> class.
        /// </summary>
        /// <param name="config">Yaml format Sarama config for Kafka connection. It follows the struct of sarama.Config. See https://github.com/IBM/sarama/blob/main/config.go e.g.  consumer:   fetch:     min: 1 net:   MaxOpenRequests: 5  +optional.</param>
        /// <param name="connectionBackoff">connectionBackoff.</param>
        /// <param name="consumerGroup">consumerGroup.</param>
        /// <param name="filter">filter.</param>
        /// <param name="jsonBody">jsonBody.</param>
        /// <param name="limitEventsPerSecond">limitEventsPerSecond.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="partition">partition.</param>
        /// <param name="sasl">sasl.</param>
        /// <param name="tls">tls.</param>
        /// <param name="topic">topic.</param>
        /// <param name="url">url.</param>
        /// <param name="varVersion">varVersion.</param>
        public IoArgoprojEventsV1alpha1KafkaEventSource(string config = default(string), IoArgoprojEventsV1alpha1Backoff connectionBackoff = default(IoArgoprojEventsV1alpha1Backoff), IoArgoprojEventsV1alpha1KafkaConsumerGroup consumerGroup = default(IoArgoprojEventsV1alpha1KafkaConsumerGroup), IoArgoprojEventsV1alpha1EventSourceFilter filter = default(IoArgoprojEventsV1alpha1EventSourceFilter), bool jsonBody = default(bool), string limitEventsPerSecond = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), string partition = default(string), IoArgoprojEventsV1alpha1SASLConfig sasl = default(IoArgoprojEventsV1alpha1SASLConfig), IoArgoprojEventsV1alpha1TLSConfig tls = default(IoArgoprojEventsV1alpha1TLSConfig), string topic = default(string), string url = default(string), string varVersion = default(string))
        {
            this.Config = config;
            this.ConnectionBackoff = connectionBackoff;
            this.ConsumerGroup = consumerGroup;
            this.Filter = filter;
            this.JsonBody = jsonBody;
            this.LimitEventsPerSecond = limitEventsPerSecond;
            this.Metadata = metadata;
            this.Partition = partition;
            this.Sasl = sasl;
            this.Tls = tls;
            this.Topic = topic;
            this.Url = url;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// Yaml format Sarama config for Kafka connection. It follows the struct of sarama.Config. See https://github.com/IBM/sarama/blob/main/config.go e.g.  consumer:   fetch:     min: 1 net:   MaxOpenRequests: 5  +optional
        /// </summary>
        /// <value>Yaml format Sarama config for Kafka connection. It follows the struct of sarama.Config. See https://github.com/IBM/sarama/blob/main/config.go e.g.  consumer:   fetch:     min: 1 net:   MaxOpenRequests: 5  +optional</value>
        [DataMember(Name = "config", EmitDefaultValue = false)]
        public string Config { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionBackoff
        /// </summary>
        [DataMember(Name = "connectionBackoff", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1Backoff ConnectionBackoff { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerGroup
        /// </summary>
        [DataMember(Name = "consumerGroup", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1KafkaConsumerGroup ConsumerGroup { get; set; }

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
        /// Gets or Sets LimitEventsPerSecond
        /// </summary>
        [DataMember(Name = "limitEventsPerSecond", EmitDefaultValue = false)]
        public string LimitEventsPerSecond { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Partition
        /// </summary>
        [DataMember(Name = "partition", EmitDefaultValue = false)]
        public string Partition { get; set; }

        /// <summary>
        /// Gets or Sets Sasl
        /// </summary>
        [DataMember(Name = "sasl", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1SASLConfig Sasl { get; set; }

        /// <summary>
        /// Gets or Sets Tls
        /// </summary>
        [DataMember(Name = "tls", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1TLSConfig Tls { get; set; }

        /// <summary>
        /// Gets or Sets Topic
        /// </summary>
        [DataMember(Name = "topic", EmitDefaultValue = false)]
        public string Topic { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1KafkaEventSource {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  ConnectionBackoff: ").Append(ConnectionBackoff).Append("\n");
            sb.Append("  ConsumerGroup: ").Append(ConsumerGroup).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  JsonBody: ").Append(JsonBody).Append("\n");
            sb.Append("  LimitEventsPerSecond: ").Append(LimitEventsPerSecond).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Partition: ").Append(Partition).Append("\n");
            sb.Append("  Sasl: ").Append(Sasl).Append("\n");
            sb.Append("  Tls: ").Append(Tls).Append("\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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