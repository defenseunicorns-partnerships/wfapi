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
    /// IoArgoprojEventsV1alpha1SchemaRegistryConfig
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.SchemaRegistryConfig")]
    public partial class IoArgoprojEventsV1alpha1SchemaRegistryConfig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1SchemaRegistryConfig" /> class.
        /// </summary>
        /// <param name="auth">auth.</param>
        /// <param name="schemaId">schemaId.</param>
        /// <param name="url">Schema Registry URL..</param>
        public IoArgoprojEventsV1alpha1SchemaRegistryConfig(IoArgoprojEventsV1alpha1BasicAuth auth = default(IoArgoprojEventsV1alpha1BasicAuth), int schemaId = default(int), string url = default(string))
        {
            this.Auth = auth;
            this.SchemaId = schemaId;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets Auth
        /// </summary>
        [DataMember(Name = "auth", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1BasicAuth Auth { get; set; }

        /// <summary>
        /// Gets or Sets SchemaId
        /// </summary>
        [DataMember(Name = "schemaId", EmitDefaultValue = false)]
        public int SchemaId { get; set; }

        /// <summary>
        /// Schema Registry URL.
        /// </summary>
        /// <value>Schema Registry URL.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1SchemaRegistryConfig {\n");
            sb.Append("  Auth: ").Append(Auth).Append("\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
