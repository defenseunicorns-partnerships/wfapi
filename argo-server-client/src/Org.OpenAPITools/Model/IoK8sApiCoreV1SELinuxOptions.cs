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
    /// SELinuxOptions are the labels to be applied to the container
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.SELinuxOptions")]
    public partial class IoK8sApiCoreV1SELinuxOptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1SELinuxOptions" /> class.
        /// </summary>
        /// <param name="level">Level is SELinux level label that applies to the container..</param>
        /// <param name="role">Role is a SELinux role label that applies to the container..</param>
        /// <param name="type">Type is a SELinux type label that applies to the container..</param>
        /// <param name="user">User is a SELinux user label that applies to the container..</param>
        public IoK8sApiCoreV1SELinuxOptions(string level = default(string), string role = default(string), string type = default(string), string user = default(string))
        {
            this.Level = level;
            this.Role = role;
            this.Type = type;
            this.User = user;
        }

        /// <summary>
        /// Level is SELinux level label that applies to the container.
        /// </summary>
        /// <value>Level is SELinux level label that applies to the container.</value>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public string Level { get; set; }

        /// <summary>
        /// Role is a SELinux role label that applies to the container.
        /// </summary>
        /// <value>Role is a SELinux role label that applies to the container.</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public string Role { get; set; }

        /// <summary>
        /// Type is a SELinux type label that applies to the container.
        /// </summary>
        /// <value>Type is a SELinux type label that applies to the container.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// User is a SELinux user label that applies to the container.
        /// </summary>
        /// <value>User is a SELinux user label that applies to the container.</value>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public string User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1SELinuxOptions {\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
