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
    /// ObjectFieldSelector selects an APIVersioned field of an object.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.ObjectFieldSelector")]
    public partial class IoK8sApiCoreV1ObjectFieldSelector : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1ObjectFieldSelector" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1ObjectFieldSelector() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1ObjectFieldSelector" /> class.
        /// </summary>
        /// <param name="apiVersion">Version of the schema the FieldPath is written in terms of, defaults to \&quot;v1\&quot;..</param>
        /// <param name="fieldPath">Path of the field to select in the specified API version. (required).</param>
        public IoK8sApiCoreV1ObjectFieldSelector(string apiVersion = default(string), string fieldPath = default(string))
        {
            // to ensure "fieldPath" is required (not null)
            if (fieldPath == null)
            {
                throw new ArgumentNullException("fieldPath is a required property for IoK8sApiCoreV1ObjectFieldSelector and cannot be null");
            }
            this.FieldPath = fieldPath;
            this.ApiVersion = apiVersion;
        }

        /// <summary>
        /// Version of the schema the FieldPath is written in terms of, defaults to \&quot;v1\&quot;.
        /// </summary>
        /// <value>Version of the schema the FieldPath is written in terms of, defaults to \&quot;v1\&quot;.</value>
        [DataMember(Name = "apiVersion", EmitDefaultValue = false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Path of the field to select in the specified API version.
        /// </summary>
        /// <value>Path of the field to select in the specified API version.</value>
        [DataMember(Name = "fieldPath", IsRequired = true, EmitDefaultValue = true)]
        public string FieldPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1ObjectFieldSelector {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  FieldPath: ").Append(FieldPath).Append("\n");
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
