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
    /// Adapts a Secret into a volume.  The contents of the target Secret&#39;s Data field will be presented in a volume as files using the keys in the Data field as the file names. Secret volumes support ownership management and SELinux relabeling.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.SecretVolumeSource")]
    public partial class IoK8sApiCoreV1SecretVolumeSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1SecretVolumeSource" /> class.
        /// </summary>
        /// <param name="defaultMode">Optional: mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set..</param>
        /// <param name="items">If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the &#39;..&#39; path or start with &#39;..&#39;..</param>
        /// <param name="optional">Specify whether the Secret or its keys must be defined.</param>
        /// <param name="secretName">Name of the secret in the pod&#39;s namespace to use. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret.</param>
        public IoK8sApiCoreV1SecretVolumeSource(int defaultMode = default(int), List<IoK8sApiCoreV1KeyToPath> items = default(List<IoK8sApiCoreV1KeyToPath>), bool optional = default(bool), string secretName = default(string))
        {
            this.DefaultMode = defaultMode;
            this.Items = items;
            this.Optional = optional;
            this.SecretName = secretName;
        }

        /// <summary>
        /// Optional: mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        /// </summary>
        /// <value>Optional: mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</value>
        [DataMember(Name = "defaultMode", EmitDefaultValue = false)]
        public int DefaultMode { get; set; }

        /// <summary>
        /// If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the &#39;..&#39; path or start with &#39;..&#39;.
        /// </summary>
        /// <value>If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the &#39;..&#39; path or start with &#39;..&#39;.</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<IoK8sApiCoreV1KeyToPath> Items { get; set; }

        /// <summary>
        /// Specify whether the Secret or its keys must be defined
        /// </summary>
        /// <value>Specify whether the Secret or its keys must be defined</value>
        [DataMember(Name = "optional", EmitDefaultValue = true)]
        public bool Optional { get; set; }

        /// <summary>
        /// Name of the secret in the pod&#39;s namespace to use. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret
        /// </summary>
        /// <value>Name of the secret in the pod&#39;s namespace to use. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret</value>
        [DataMember(Name = "secretName", EmitDefaultValue = false)]
        public string SecretName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1SecretVolumeSource {\n");
            sb.Append("  DefaultMode: ").Append(DefaultMode).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  SecretName: ").Append(SecretName).Append("\n");
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