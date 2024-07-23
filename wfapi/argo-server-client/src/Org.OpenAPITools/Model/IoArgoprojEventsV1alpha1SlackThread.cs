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
    /// IoArgoprojEventsV1alpha1SlackThread
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.SlackThread")]
    public partial class IoArgoprojEventsV1alpha1SlackThread : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1SlackThread" /> class.
        /// </summary>
        /// <param name="broadcastMessageToChannel">broadcastMessageToChannel.</param>
        /// <param name="messageAggregationKey">messageAggregationKey.</param>
        public IoArgoprojEventsV1alpha1SlackThread(bool broadcastMessageToChannel = default(bool), string messageAggregationKey = default(string))
        {
            this.BroadcastMessageToChannel = broadcastMessageToChannel;
            this.MessageAggregationKey = messageAggregationKey;
        }

        /// <summary>
        /// Gets or Sets BroadcastMessageToChannel
        /// </summary>
        [DataMember(Name = "broadcastMessageToChannel", EmitDefaultValue = true)]
        public bool BroadcastMessageToChannel { get; set; }

        /// <summary>
        /// Gets or Sets MessageAggregationKey
        /// </summary>
        [DataMember(Name = "messageAggregationKey", EmitDefaultValue = false)]
        public string MessageAggregationKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1SlackThread {\n");
            sb.Append("  BroadcastMessageToChannel: ").Append(BroadcastMessageToChannel).Append("\n");
            sb.Append("  MessageAggregationKey: ").Append(MessageAggregationKey).Append("\n");
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