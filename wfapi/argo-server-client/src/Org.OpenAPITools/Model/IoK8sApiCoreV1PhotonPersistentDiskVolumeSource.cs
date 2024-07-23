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
    /// Represents a Photon Controller persistent disk resource.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.PhotonPersistentDiskVolumeSource")]
    public partial class IoK8sApiCoreV1PhotonPersistentDiskVolumeSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1PhotonPersistentDiskVolumeSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1PhotonPersistentDiskVolumeSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1PhotonPersistentDiskVolumeSource" /> class.
        /// </summary>
        /// <param name="fsType">Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified..</param>
        /// <param name="pdID">ID that identifies Photon Controller persistent disk (required).</param>
        public IoK8sApiCoreV1PhotonPersistentDiskVolumeSource(string fsType = default(string), string pdID = default(string))
        {
            // to ensure "pdID" is required (not null)
            if (pdID == null)
            {
                throw new ArgumentNullException("pdID is a required property for IoK8sApiCoreV1PhotonPersistentDiskVolumeSource and cannot be null");
            }
            this.PdID = pdID;
            this.FsType = fsType;
        }

        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified.
        /// </summary>
        /// <value>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified.</value>
        [DataMember(Name = "fsType", EmitDefaultValue = false)]
        public string FsType { get; set; }

        /// <summary>
        /// ID that identifies Photon Controller persistent disk
        /// </summary>
        /// <value>ID that identifies Photon Controller persistent disk</value>
        [DataMember(Name = "pdID", IsRequired = true, EmitDefaultValue = true)]
        public string PdID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1PhotonPersistentDiskVolumeSource {\n");
            sb.Append("  FsType: ").Append(FsType).Append("\n");
            sb.Append("  PdID: ").Append(PdID).Append("\n");
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