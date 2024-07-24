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
    /// IoArgoprojEventsV1alpha1EventDependencyTransformer
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.EventDependencyTransformer")]
    public partial class IoArgoprojEventsV1alpha1EventDependencyTransformer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1EventDependencyTransformer" /> class.
        /// </summary>
        /// <param name="jq">jq.</param>
        /// <param name="script">script.</param>
        public IoArgoprojEventsV1alpha1EventDependencyTransformer(string jq = default(string), string script = default(string))
        {
            this.Jq = jq;
            this.Script = script;
        }

        /// <summary>
        /// Gets or Sets Jq
        /// </summary>
        [DataMember(Name = "jq", EmitDefaultValue = false)]
        public string Jq { get; set; }

        /// <summary>
        /// Gets or Sets Script
        /// </summary>
        [DataMember(Name = "script", EmitDefaultValue = false)]
        public string Script { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1EventDependencyTransformer {\n");
            sb.Append("  Jq: ").Append(Jq).Append("\n");
            sb.Append("  Script: ").Append(Script).Append("\n");
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
