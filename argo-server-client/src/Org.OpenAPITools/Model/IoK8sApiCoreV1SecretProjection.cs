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
    /// Adapts a secret into a projected volume.  The contents of the target Secret&#39;s Data field will be presented in a projected volume as files using the keys in the Data field as the file names. Note that this is identical to a secret volume source without the default mode.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.SecretProjection")]
    public partial class IoK8sApiCoreV1SecretProjection : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1SecretProjection" /> class.
        /// </summary>
        /// <param name="items">If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the &#39;..&#39; path or start with &#39;..&#39;..</param>
        /// <param name="name">Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names.</param>
        /// <param name="optional">Specify whether the Secret or its key must be defined.</param>
        public IoK8sApiCoreV1SecretProjection(List<IoK8sApiCoreV1KeyToPath> items = default(List<IoK8sApiCoreV1KeyToPath>), string name = default(string), bool optional = default(bool))
        {
            this.Items = items;
            this.Name = name;
            this.Optional = optional;
        }

        /// <summary>
        /// If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the &#39;..&#39; path or start with &#39;..&#39;.
        /// </summary>
        /// <value>If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the &#39;..&#39; path or start with &#39;..&#39;.</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<IoK8sApiCoreV1KeyToPath> Items { get; set; }

        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        /// <value>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Specify whether the Secret or its key must be defined
        /// </summary>
        /// <value>Specify whether the Secret or its key must be defined</value>
        [DataMember(Name = "optional", EmitDefaultValue = true)]
        public bool Optional { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1SecretProjection {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
