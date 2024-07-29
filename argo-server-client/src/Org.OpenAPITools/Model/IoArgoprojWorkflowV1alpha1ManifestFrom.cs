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
    /// IoArgoprojWorkflowV1alpha1ManifestFrom
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.ManifestFrom")]
    public partial class IoArgoprojWorkflowV1alpha1ManifestFrom : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1ManifestFrom" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoArgoprojWorkflowV1alpha1ManifestFrom() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1ManifestFrom" /> class.
        /// </summary>
        /// <param name="artifact">artifact (required).</param>
        public IoArgoprojWorkflowV1alpha1ManifestFrom(IoArgoprojWorkflowV1alpha1Artifact artifact = default(IoArgoprojWorkflowV1alpha1Artifact))
        {
            // to ensure "artifact" is required (not null)
            if (artifact == null)
            {
                throw new ArgumentNullException("artifact is a required property for IoArgoprojWorkflowV1alpha1ManifestFrom and cannot be null");
            }
            this.Artifact = artifact;
        }

        /// <summary>
        /// Gets or Sets Artifact
        /// </summary>
        [DataMember(Name = "artifact", IsRequired = true, EmitDefaultValue = true)]
        public IoArgoprojWorkflowV1alpha1Artifact Artifact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1ManifestFrom {\n");
            sb.Append("  Artifact: ").Append(Artifact).Append("\n");
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