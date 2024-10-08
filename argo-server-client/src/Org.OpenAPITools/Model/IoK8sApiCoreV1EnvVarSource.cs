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
    /// EnvVarSource represents a source for the value of an EnvVar.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.EnvVarSource")]
    public partial class IoK8sApiCoreV1EnvVarSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1EnvVarSource" /> class.
        /// </summary>
        /// <param name="configMapKeyRef">configMapKeyRef.</param>
        /// <param name="fieldRef">fieldRef.</param>
        /// <param name="resourceFieldRef">resourceFieldRef.</param>
        /// <param name="secretKeyRef">secretKeyRef.</param>
        public IoK8sApiCoreV1EnvVarSource(IoK8sApiCoreV1ConfigMapKeySelector configMapKeyRef = default(IoK8sApiCoreV1ConfigMapKeySelector), IoK8sApiCoreV1ObjectFieldSelector fieldRef = default(IoK8sApiCoreV1ObjectFieldSelector), IoK8sApiCoreV1ResourceFieldSelector resourceFieldRef = default(IoK8sApiCoreV1ResourceFieldSelector), IoK8sApiCoreV1SecretKeySelector secretKeyRef = default(IoK8sApiCoreV1SecretKeySelector))
        {
            this.ConfigMapKeyRef = configMapKeyRef;
            this.FieldRef = fieldRef;
            this.ResourceFieldRef = resourceFieldRef;
            this.SecretKeyRef = secretKeyRef;
        }

        /// <summary>
        /// Gets or Sets ConfigMapKeyRef
        /// </summary>
        [DataMember(Name = "configMapKeyRef", EmitDefaultValue = false)]
        public IoK8sApiCoreV1ConfigMapKeySelector ConfigMapKeyRef { get; set; }

        /// <summary>
        /// Gets or Sets FieldRef
        /// </summary>
        [DataMember(Name = "fieldRef", EmitDefaultValue = false)]
        public IoK8sApiCoreV1ObjectFieldSelector FieldRef { get; set; }

        /// <summary>
        /// Gets or Sets ResourceFieldRef
        /// </summary>
        [DataMember(Name = "resourceFieldRef", EmitDefaultValue = false)]
        public IoK8sApiCoreV1ResourceFieldSelector ResourceFieldRef { get; set; }

        /// <summary>
        /// Gets or Sets SecretKeyRef
        /// </summary>
        [DataMember(Name = "secretKeyRef", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector SecretKeyRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1EnvVarSource {\n");
            sb.Append("  ConfigMapKeyRef: ").Append(ConfigMapKeyRef).Append("\n");
            sb.Append("  FieldRef: ").Append(FieldRef).Append("\n");
            sb.Append("  ResourceFieldRef: ").Append(ResourceFieldRef).Append("\n");
            sb.Append("  SecretKeyRef: ").Append(SecretKeyRef).Append("\n");
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
