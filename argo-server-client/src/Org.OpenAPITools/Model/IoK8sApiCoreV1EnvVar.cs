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
    /// EnvVar represents an environment variable present in a Container.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.EnvVar")]
    public partial class IoK8sApiCoreV1EnvVar : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1EnvVar" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1EnvVar() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1EnvVar" /> class.
        /// </summary>
        /// <param name="name">Name of the environment variable. Must be a C_IDENTIFIER. (required).</param>
        /// <param name="value">Variable references $(VAR_NAME) are expanded using the previously defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. \&quot;$$(VAR_NAME)\&quot; will produce the string literal \&quot;$(VAR_NAME)\&quot;. Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to \&quot;\&quot;..</param>
        /// <param name="valueFrom">valueFrom.</param>
        public IoK8sApiCoreV1EnvVar(string name = default(string), string value = default(string), IoK8sApiCoreV1EnvVarSource valueFrom = default(IoK8sApiCoreV1EnvVarSource))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for IoK8sApiCoreV1EnvVar and cannot be null");
            }
            this.Name = name;
            this.Value = value;
            this.ValueFrom = valueFrom;
        }

        /// <summary>
        /// Name of the environment variable. Must be a C_IDENTIFIER.
        /// </summary>
        /// <value>Name of the environment variable. Must be a C_IDENTIFIER.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Variable references $(VAR_NAME) are expanded using the previously defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. \&quot;$$(VAR_NAME)\&quot; will produce the string literal \&quot;$(VAR_NAME)\&quot;. Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to \&quot;\&quot;.
        /// </summary>
        /// <value>Variable references $(VAR_NAME) are expanded using the previously defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. \&quot;$$(VAR_NAME)\&quot; will produce the string literal \&quot;$(VAR_NAME)\&quot;. Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to \&quot;\&quot;.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets ValueFrom
        /// </summary>
        [DataMember(Name = "valueFrom", EmitDefaultValue = false)]
        public IoK8sApiCoreV1EnvVarSource ValueFrom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1EnvVar {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueFrom: ").Append(ValueFrom).Append("\n");
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
