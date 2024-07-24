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
    /// AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.AzureFileVolumeSource")]
    public partial class IoK8sApiCoreV1AzureFileVolumeSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1AzureFileVolumeSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1AzureFileVolumeSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1AzureFileVolumeSource" /> class.
        /// </summary>
        /// <param name="readOnly">Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts..</param>
        /// <param name="secretName">the name of secret that contains Azure Storage Account Name and Key (required).</param>
        /// <param name="shareName">Share Name (required).</param>
        public IoK8sApiCoreV1AzureFileVolumeSource(bool readOnly = default(bool), string secretName = default(string), string shareName = default(string))
        {
            // to ensure "secretName" is required (not null)
            if (secretName == null)
            {
                throw new ArgumentNullException("secretName is a required property for IoK8sApiCoreV1AzureFileVolumeSource and cannot be null");
            }
            this.SecretName = secretName;
            // to ensure "shareName" is required (not null)
            if (shareName == null)
            {
                throw new ArgumentNullException("shareName is a required property for IoK8sApiCoreV1AzureFileVolumeSource and cannot be null");
            }
            this.ShareName = shareName;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        /// <value>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</value>
        [DataMember(Name = "readOnly", EmitDefaultValue = true)]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// the name of secret that contains Azure Storage Account Name and Key
        /// </summary>
        /// <value>the name of secret that contains Azure Storage Account Name and Key</value>
        [DataMember(Name = "secretName", IsRequired = true, EmitDefaultValue = true)]
        public string SecretName { get; set; }

        /// <summary>
        /// Share Name
        /// </summary>
        /// <value>Share Name</value>
        [DataMember(Name = "shareName", IsRequired = true, EmitDefaultValue = true)]
        public string ShareName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1AzureFileVolumeSource {\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  SecretName: ").Append(SecretName).Append("\n");
            sb.Append("  ShareName: ").Append(ShareName).Append("\n");
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
