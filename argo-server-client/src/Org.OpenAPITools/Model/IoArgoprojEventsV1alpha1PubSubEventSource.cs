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
    /// PubSubEventSource refers to event-source for GCP PubSub related events.
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.PubSubEventSource")]
    public partial class IoArgoprojEventsV1alpha1PubSubEventSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1PubSubEventSource" /> class.
        /// </summary>
        /// <param name="credentialSecret">credentialSecret.</param>
        /// <param name="deleteSubscriptionOnFinish">deleteSubscriptionOnFinish.</param>
        /// <param name="filter">filter.</param>
        /// <param name="jsonBody">jsonBody.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="projectID">projectID.</param>
        /// <param name="subscriptionID">subscriptionID.</param>
        /// <param name="topic">topic.</param>
        /// <param name="topicProjectID">topicProjectID.</param>
        public IoArgoprojEventsV1alpha1PubSubEventSource(IoK8sApiCoreV1SecretKeySelector credentialSecret = default(IoK8sApiCoreV1SecretKeySelector), bool deleteSubscriptionOnFinish = default(bool), IoArgoprojEventsV1alpha1EventSourceFilter filter = default(IoArgoprojEventsV1alpha1EventSourceFilter), bool jsonBody = default(bool), Dictionary<string, string> metadata = default(Dictionary<string, string>), string projectID = default(string), string subscriptionID = default(string), string topic = default(string), string topicProjectID = default(string))
        {
            this.CredentialSecret = credentialSecret;
            this.DeleteSubscriptionOnFinish = deleteSubscriptionOnFinish;
            this.Filter = filter;
            this.JsonBody = jsonBody;
            this.Metadata = metadata;
            this.ProjectID = projectID;
            this.SubscriptionID = subscriptionID;
            this.Topic = topic;
            this.TopicProjectID = topicProjectID;
        }

        /// <summary>
        /// Gets or Sets CredentialSecret
        /// </summary>
        [DataMember(Name = "credentialSecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector CredentialSecret { get; set; }

        /// <summary>
        /// Gets or Sets DeleteSubscriptionOnFinish
        /// </summary>
        [DataMember(Name = "deleteSubscriptionOnFinish", EmitDefaultValue = true)]
        public bool DeleteSubscriptionOnFinish { get; set; }

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
        /// Gets or Sets ProjectID
        /// </summary>
        [DataMember(Name = "projectID", EmitDefaultValue = false)]
        public string ProjectID { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionID
        /// </summary>
        [DataMember(Name = "subscriptionID", EmitDefaultValue = false)]
        public string SubscriptionID { get; set; }

        /// <summary>
        /// Gets or Sets Topic
        /// </summary>
        [DataMember(Name = "topic", EmitDefaultValue = false)]
        public string Topic { get; set; }

        /// <summary>
        /// Gets or Sets TopicProjectID
        /// </summary>
        [DataMember(Name = "topicProjectID", EmitDefaultValue = false)]
        public string TopicProjectID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1PubSubEventSource {\n");
            sb.Append("  CredentialSecret: ").Append(CredentialSecret).Append("\n");
            sb.Append("  DeleteSubscriptionOnFinish: ").Append(DeleteSubscriptionOnFinish).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  JsonBody: ").Append(JsonBody).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  ProjectID: ").Append(ProjectID).Append("\n");
            sb.Append("  SubscriptionID: ").Append(SubscriptionID).Append("\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  TopicProjectID: ").Append(TopicProjectID).Append("\n");
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
