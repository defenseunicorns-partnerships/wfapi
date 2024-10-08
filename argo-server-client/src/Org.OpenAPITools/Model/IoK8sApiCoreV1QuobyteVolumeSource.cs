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
    /// Represents a Quobyte mount that lasts the lifetime of a pod. Quobyte volumes do not support ownership management or SELinux relabeling.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.QuobyteVolumeSource")]
    public partial class IoK8sApiCoreV1QuobyteVolumeSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1QuobyteVolumeSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1QuobyteVolumeSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1QuobyteVolumeSource" /> class.
        /// </summary>
        /// <param name="group">Group to map volume access to Default is no group.</param>
        /// <param name="readOnly">ReadOnly here will force the Quobyte volume to be mounted with read-only permissions. Defaults to false..</param>
        /// <param name="registry">Registry represents a single or multiple Quobyte Registry services specified as a string as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes (required).</param>
        /// <param name="tenant">Tenant owning the given Quobyte volume in the Backend Used with dynamically provisioned Quobyte volumes, value is set by the plugin.</param>
        /// <param name="user">User to map volume access to Defaults to serivceaccount user.</param>
        /// <param name="volume">Volume is a string that references an already created Quobyte volume by name. (required).</param>
        public IoK8sApiCoreV1QuobyteVolumeSource(string group = default(string), bool readOnly = default(bool), string registry = default(string), string tenant = default(string), string user = default(string), string volume = default(string))
        {
            // to ensure "registry" is required (not null)
            if (registry == null)
            {
                throw new ArgumentNullException("registry is a required property for IoK8sApiCoreV1QuobyteVolumeSource and cannot be null");
            }
            this.Registry = registry;
            // to ensure "volume" is required (not null)
            if (volume == null)
            {
                throw new ArgumentNullException("volume is a required property for IoK8sApiCoreV1QuobyteVolumeSource and cannot be null");
            }
            this.Volume = volume;
            this.Group = group;
            this.ReadOnly = readOnly;
            this.Tenant = tenant;
            this.User = user;
        }

        /// <summary>
        /// Group to map volume access to Default is no group
        /// </summary>
        /// <value>Group to map volume access to Default is no group</value>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public string Group { get; set; }

        /// <summary>
        /// ReadOnly here will force the Quobyte volume to be mounted with read-only permissions. Defaults to false.
        /// </summary>
        /// <value>ReadOnly here will force the Quobyte volume to be mounted with read-only permissions. Defaults to false.</value>
        [DataMember(Name = "readOnly", EmitDefaultValue = true)]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Registry represents a single or multiple Quobyte Registry services specified as a string as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes
        /// </summary>
        /// <value>Registry represents a single or multiple Quobyte Registry services specified as a string as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes</value>
        [DataMember(Name = "registry", IsRequired = true, EmitDefaultValue = true)]
        public string Registry { get; set; }

        /// <summary>
        /// Tenant owning the given Quobyte volume in the Backend Used with dynamically provisioned Quobyte volumes, value is set by the plugin
        /// </summary>
        /// <value>Tenant owning the given Quobyte volume in the Backend Used with dynamically provisioned Quobyte volumes, value is set by the plugin</value>
        [DataMember(Name = "tenant", EmitDefaultValue = false)]
        public string Tenant { get; set; }

        /// <summary>
        /// User to map volume access to Defaults to serivceaccount user
        /// </summary>
        /// <value>User to map volume access to Defaults to serivceaccount user</value>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public string User { get; set; }

        /// <summary>
        /// Volume is a string that references an already created Quobyte volume by name.
        /// </summary>
        /// <value>Volume is a string that references an already created Quobyte volume by name.</value>
        [DataMember(Name = "volume", IsRequired = true, EmitDefaultValue = true)]
        public string Volume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1QuobyteVolumeSource {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  Registry: ").Append(Registry).Append("\n");
            sb.Append("  Tenant: ").Append(Tenant).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
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
