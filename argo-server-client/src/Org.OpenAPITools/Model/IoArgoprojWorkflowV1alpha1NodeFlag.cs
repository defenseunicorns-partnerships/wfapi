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
    /// IoArgoprojWorkflowV1alpha1NodeFlag
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.NodeFlag")]
    public partial class IoArgoprojWorkflowV1alpha1NodeFlag : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1NodeFlag" /> class.
        /// </summary>
        /// <param name="hooked">Hooked tracks whether or not this node was triggered by hook or onExit.</param>
        /// <param name="retried">Retried tracks whether or not this node was retried by retryStrategy.</param>
        public IoArgoprojWorkflowV1alpha1NodeFlag(bool hooked = default(bool), bool retried = default(bool))
        {
            this.Hooked = hooked;
            this.Retried = retried;
        }

        /// <summary>
        /// Hooked tracks whether or not this node was triggered by hook or onExit
        /// </summary>
        /// <value>Hooked tracks whether or not this node was triggered by hook or onExit</value>
        [DataMember(Name = "hooked", EmitDefaultValue = true)]
        public bool Hooked { get; set; }

        /// <summary>
        /// Retried tracks whether or not this node was retried by retryStrategy
        /// </summary>
        /// <value>Retried tracks whether or not this node was retried by retryStrategy</value>
        [DataMember(Name = "retried", EmitDefaultValue = true)]
        public bool Retried { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1NodeFlag {\n");
            sb.Append("  Hooked: ").Append(Hooked).Append("\n");
            sb.Append("  Retried: ").Append(Retried).Append("\n");
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
