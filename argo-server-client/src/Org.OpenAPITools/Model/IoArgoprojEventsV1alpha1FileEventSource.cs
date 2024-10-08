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
    /// FileEventSource describes an event-source for file related events.
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.FileEventSource")]
    public partial class IoArgoprojEventsV1alpha1FileEventSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1FileEventSource" /> class.
        /// </summary>
        /// <param name="eventType">eventType.</param>
        /// <param name="filter">filter.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="polling">polling.</param>
        /// <param name="watchPathConfig">watchPathConfig.</param>
        public IoArgoprojEventsV1alpha1FileEventSource(string eventType = default(string), IoArgoprojEventsV1alpha1EventSourceFilter filter = default(IoArgoprojEventsV1alpha1EventSourceFilter), Dictionary<string, string> metadata = default(Dictionary<string, string>), bool polling = default(bool), IoArgoprojEventsV1alpha1WatchPathConfig watchPathConfig = default(IoArgoprojEventsV1alpha1WatchPathConfig))
        {
            this.EventType = eventType;
            this.Filter = filter;
            this.Metadata = metadata;
            this.Polling = polling;
            this.WatchPathConfig = watchPathConfig;
        }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1EventSourceFilter Filter { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Polling
        /// </summary>
        [DataMember(Name = "polling", EmitDefaultValue = true)]
        public bool Polling { get; set; }

        /// <summary>
        /// Gets or Sets WatchPathConfig
        /// </summary>
        [DataMember(Name = "watchPathConfig", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1WatchPathConfig WatchPathConfig { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1FileEventSource {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Polling: ").Append(Polling).Append("\n");
            sb.Append("  WatchPathConfig: ").Append(WatchPathConfig).Append("\n");
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
