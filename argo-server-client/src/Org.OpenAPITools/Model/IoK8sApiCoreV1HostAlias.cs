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
    /// HostAlias holds the mapping between IP and hostnames that will be injected as an entry in the pod&#39;s hosts file.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.HostAlias")]
    public partial class IoK8sApiCoreV1HostAlias : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1HostAlias" /> class.
        /// </summary>
        /// <param name="hostnames">Hostnames for the above IP address..</param>
        /// <param name="ip">IP address of the host file entry..</param>
        public IoK8sApiCoreV1HostAlias(List<string> hostnames = default(List<string>), string ip = default(string))
        {
            this.Hostnames = hostnames;
            this.Ip = ip;
        }

        /// <summary>
        /// Hostnames for the above IP address.
        /// </summary>
        /// <value>Hostnames for the above IP address.</value>
        [DataMember(Name = "hostnames", EmitDefaultValue = false)]
        public List<string> Hostnames { get; set; }

        /// <summary>
        /// IP address of the host file entry.
        /// </summary>
        /// <value>IP address of the host file entry.</value>
        [DataMember(Name = "ip", EmitDefaultValue = false)]
        public string Ip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1HostAlias {\n");
            sb.Append("  Hostnames: ").Append(Hostnames).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
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