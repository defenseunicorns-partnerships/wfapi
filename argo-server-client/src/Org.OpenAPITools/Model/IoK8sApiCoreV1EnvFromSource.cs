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
    /// EnvFromSource represents the source of a set of ConfigMaps
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.EnvFromSource")]
    public partial class IoK8sApiCoreV1EnvFromSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1EnvFromSource" /> class.
        /// </summary>
        /// <param name="configMapRef">configMapRef.</param>
        /// <param name="prefix">An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER..</param>
        /// <param name="secretRef">secretRef.</param>
        public IoK8sApiCoreV1EnvFromSource(IoK8sApiCoreV1ConfigMapEnvSource configMapRef = default(IoK8sApiCoreV1ConfigMapEnvSource), string prefix = default(string), IoK8sApiCoreV1SecretEnvSource secretRef = default(IoK8sApiCoreV1SecretEnvSource))
        {
            this.ConfigMapRef = configMapRef;
            this.Prefix = prefix;
            this.SecretRef = secretRef;
        }

        /// <summary>
        /// Gets or Sets ConfigMapRef
        /// </summary>
        [DataMember(Name = "configMapRef", EmitDefaultValue = false)]
        public IoK8sApiCoreV1ConfigMapEnvSource ConfigMapRef { get; set; }

        /// <summary>
        /// An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.
        /// </summary>
        /// <value>An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.</value>
        [DataMember(Name = "prefix", EmitDefaultValue = false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or Sets SecretRef
        /// </summary>
        [DataMember(Name = "secretRef", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretEnvSource SecretRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1EnvFromSource {\n");
            sb.Append("  ConfigMapRef: ").Append(ConfigMapRef).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  SecretRef: ").Append(SecretRef).Append("\n");
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