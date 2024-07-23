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
    /// Column is a custom column that will be exposed in the Workflow List View.
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.Column")]
    public partial class IoArgoprojWorkflowV1alpha1Column : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1Column" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoArgoprojWorkflowV1alpha1Column() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1Column" /> class.
        /// </summary>
        /// <param name="key">The key of the label or annotation, e.g., \&quot;workflows.argoproj.io/completed\&quot;. (required).</param>
        /// <param name="name">The name of this column, e.g., \&quot;Workflow Completed\&quot;. (required).</param>
        /// <param name="type">The type of this column, \&quot;label\&quot; or \&quot;annotation\&quot;. (required).</param>
        public IoArgoprojWorkflowV1alpha1Column(string key = default(string), string name = default(string), string type = default(string))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for IoArgoprojWorkflowV1alpha1Column and cannot be null");
            }
            this.Key = key;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for IoArgoprojWorkflowV1alpha1Column and cannot be null");
            }
            this.Name = name;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for IoArgoprojWorkflowV1alpha1Column and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// The key of the label or annotation, e.g., \&quot;workflows.argoproj.io/completed\&quot;.
        /// </summary>
        /// <value>The key of the label or annotation, e.g., \&quot;workflows.argoproj.io/completed\&quot;.</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The name of this column, e.g., \&quot;Workflow Completed\&quot;.
        /// </summary>
        /// <value>The name of this column, e.g., \&quot;Workflow Completed\&quot;.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The type of this column, \&quot;label\&quot; or \&quot;annotation\&quot;.
        /// </summary>
        /// <value>The type of this column, \&quot;label\&quot; or \&quot;annotation\&quot;.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1Column {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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