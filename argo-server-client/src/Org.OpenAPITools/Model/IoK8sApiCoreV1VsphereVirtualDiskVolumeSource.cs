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
    /// Represents a vSphere volume resource.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.VsphereVirtualDiskVolumeSource")]
    public partial class IoK8sApiCoreV1VsphereVirtualDiskVolumeSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1VsphereVirtualDiskVolumeSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1VsphereVirtualDiskVolumeSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1VsphereVirtualDiskVolumeSource" /> class.
        /// </summary>
        /// <param name="fsType">Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified..</param>
        /// <param name="storagePolicyID">Storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName..</param>
        /// <param name="storagePolicyName">Storage Policy Based Management (SPBM) profile name..</param>
        /// <param name="volumePath">Path that identifies vSphere volume vmdk (required).</param>
        public IoK8sApiCoreV1VsphereVirtualDiskVolumeSource(string fsType = default(string), string storagePolicyID = default(string), string storagePolicyName = default(string), string volumePath = default(string))
        {
            // to ensure "volumePath" is required (not null)
            if (volumePath == null)
            {
                throw new ArgumentNullException("volumePath is a required property for IoK8sApiCoreV1VsphereVirtualDiskVolumeSource and cannot be null");
            }
            this.VolumePath = volumePath;
            this.FsType = fsType;
            this.StoragePolicyID = storagePolicyID;
            this.StoragePolicyName = storagePolicyName;
        }

        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified.
        /// </summary>
        /// <value>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified.</value>
        [DataMember(Name = "fsType", EmitDefaultValue = false)]
        public string FsType { get; set; }

        /// <summary>
        /// Storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.
        /// </summary>
        /// <value>Storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.</value>
        [DataMember(Name = "storagePolicyID", EmitDefaultValue = false)]
        public string StoragePolicyID { get; set; }

        /// <summary>
        /// Storage Policy Based Management (SPBM) profile name.
        /// </summary>
        /// <value>Storage Policy Based Management (SPBM) profile name.</value>
        [DataMember(Name = "storagePolicyName", EmitDefaultValue = false)]
        public string StoragePolicyName { get; set; }

        /// <summary>
        /// Path that identifies vSphere volume vmdk
        /// </summary>
        /// <value>Path that identifies vSphere volume vmdk</value>
        [DataMember(Name = "volumePath", IsRequired = true, EmitDefaultValue = true)]
        public string VolumePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1VsphereVirtualDiskVolumeSource {\n");
            sb.Append("  FsType: ").Append(FsType).Append("\n");
            sb.Append("  StoragePolicyID: ").Append(StoragePolicyID).Append("\n");
            sb.Append("  StoragePolicyName: ").Append(StoragePolicyName).Append("\n");
            sb.Append("  VolumePath: ").Append(VolumePath).Append("\n");
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
