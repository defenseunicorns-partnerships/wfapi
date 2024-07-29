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
    /// TCPSocketAction describes an action based on opening a socket
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.TCPSocketAction")]
    public partial class IoK8sApiCoreV1TCPSocketAction : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1TCPSocketAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1TCPSocketAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1TCPSocketAction" /> class.
        /// </summary>
        /// <param name="host">Optional: Host name to connect to, defaults to the pod IP..</param>
        /// <param name="port">port (required).</param>
        public IoK8sApiCoreV1TCPSocketAction(string host = default(string), string port = default(string))
        {
            // to ensure "port" is required (not null)
            if (port == null)
            {
                throw new ArgumentNullException("port is a required property for IoK8sApiCoreV1TCPSocketAction and cannot be null");
            }
            this.Port = port;
            this.Host = host;
        }

        /// <summary>
        /// Optional: Host name to connect to, defaults to the pod IP.
        /// </summary>
        /// <value>Optional: Host name to connect to, defaults to the pod IP.</value>
        [DataMember(Name = "host", EmitDefaultValue = false)]
        public string Host { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name = "port", IsRequired = true, EmitDefaultValue = true)]
        public string Port { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1TCPSocketAction {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
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