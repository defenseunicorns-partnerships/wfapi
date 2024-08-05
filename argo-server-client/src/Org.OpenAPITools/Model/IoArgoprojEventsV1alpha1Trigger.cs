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
    /// IoArgoprojEventsV1alpha1Trigger
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.Trigger")]
    public partial class IoArgoprojEventsV1alpha1Trigger : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1Trigger" /> class.
        /// </summary>
        /// <param name="atLeastOnce">atLeastOnce.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="policy">policy.</param>
        /// <param name="rateLimit">rateLimit.</param>
        /// <param name="retryStrategy">retryStrategy.</param>
        /// <param name="template">template.</param>
        public IoArgoprojEventsV1alpha1Trigger(bool atLeastOnce = default(bool), List<IoArgoprojEventsV1alpha1TriggerParameter> parameters = default(List<IoArgoprojEventsV1alpha1TriggerParameter>), IoArgoprojEventsV1alpha1TriggerPolicy policy = default(IoArgoprojEventsV1alpha1TriggerPolicy), IoArgoprojEventsV1alpha1RateLimit rateLimit = default(IoArgoprojEventsV1alpha1RateLimit), IoArgoprojEventsV1alpha1Backoff retryStrategy = default(IoArgoprojEventsV1alpha1Backoff), IoArgoprojEventsV1alpha1TriggerTemplate template = default(IoArgoprojEventsV1alpha1TriggerTemplate))
        {
            this.AtLeastOnce = atLeastOnce;
            this.Parameters = parameters;
            this.Policy = policy;
            this.RateLimit = rateLimit;
            this.RetryStrategy = retryStrategy;
            this.Template = template;
        }

        /// <summary>
        /// Gets or Sets AtLeastOnce
        /// </summary>
        [DataMember(Name = "atLeastOnce", EmitDefaultValue = true)]
        public bool AtLeastOnce { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<IoArgoprojEventsV1alpha1TriggerParameter> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1TriggerPolicy Policy { get; set; }

        /// <summary>
        /// Gets or Sets RateLimit
        /// </summary>
        [DataMember(Name = "rateLimit", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1RateLimit RateLimit { get; set; }

        /// <summary>
        /// Gets or Sets RetryStrategy
        /// </summary>
        [DataMember(Name = "retryStrategy", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1Backoff RetryStrategy { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1TriggerTemplate Template { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1Trigger {\n");
            sb.Append("  AtLeastOnce: ").Append(AtLeastOnce).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  RateLimit: ").Append(RateLimit).Append("\n");
            sb.Append("  RetryStrategy: ").Append(RetryStrategy).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
