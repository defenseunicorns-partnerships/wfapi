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
    /// Selects a key from a ConfigMap.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.ConfigMapKeySelector")]
    public partial class IoK8sApiCoreV1ConfigMapKeySelector : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1ConfigMapKeySelector" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1ConfigMapKeySelector() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1ConfigMapKeySelector" /> class.
        /// </summary>
        /// <param name="key">The key to select. (required).</param>
        /// <param name="name">Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names.</param>
        /// <param name="optional">Specify whether the ConfigMap or its key must be defined.</param>
        public IoK8sApiCoreV1ConfigMapKeySelector(string key = default(string), string name = default(string), bool optional = default(bool))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for IoK8sApiCoreV1ConfigMapKeySelector and cannot be null");
            }
            this.Key = key;
            this.Name = name;
            this.Optional = optional;
        }

        /// <summary>
        /// The key to select.
        /// </summary>
        /// <value>The key to select.</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        /// <value>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Specify whether the ConfigMap or its key must be defined
        /// </summary>
        /// <value>Specify whether the ConfigMap or its key must be defined</value>
        [DataMember(Name = "optional", EmitDefaultValue = true)]
        public bool Optional { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1ConfigMapKeySelector {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
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
