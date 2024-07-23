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
    /// CustomTrigger refers to the specification of the custom trigger.
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.CustomTrigger")]
    public partial class IoArgoprojEventsV1alpha1CustomTrigger : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1CustomTrigger" /> class.
        /// </summary>
        /// <param name="certSecret">certSecret.</param>
        /// <param name="parameters">Parameters is the list of parameters that is applied to resolved custom trigger trigger object..</param>
        /// <param name="payload">Payload is the list of key-value extracted from an event payload to construct the request payload..</param>
        /// <param name="secure">secure.</param>
        /// <param name="serverNameOverride">ServerNameOverride for the secure connection between sensor and custom trigger gRPC server..</param>
        /// <param name="serverURL">serverURL.</param>
        /// <param name="spec">Spec is the custom trigger resource specification that custom trigger gRPC server knows how to interpret..</param>
        public IoArgoprojEventsV1alpha1CustomTrigger(IoK8sApiCoreV1SecretKeySelector certSecret = default(IoK8sApiCoreV1SecretKeySelector), List<IoArgoprojEventsV1alpha1TriggerParameter> parameters = default(List<IoArgoprojEventsV1alpha1TriggerParameter>), List<IoArgoprojEventsV1alpha1TriggerParameter> payload = default(List<IoArgoprojEventsV1alpha1TriggerParameter>), bool secure = default(bool), string serverNameOverride = default(string), string serverURL = default(string), Dictionary<string, string> spec = default(Dictionary<string, string>))
        {
            this.CertSecret = certSecret;
            this.Parameters = parameters;
            this.Payload = payload;
            this.Secure = secure;
            this.ServerNameOverride = serverNameOverride;
            this.ServerURL = serverURL;
            this.Spec = spec;
        }

        /// <summary>
        /// Gets or Sets CertSecret
        /// </summary>
        [DataMember(Name = "certSecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector CertSecret { get; set; }

        /// <summary>
        /// Parameters is the list of parameters that is applied to resolved custom trigger trigger object.
        /// </summary>
        /// <value>Parameters is the list of parameters that is applied to resolved custom trigger trigger object.</value>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<IoArgoprojEventsV1alpha1TriggerParameter> Parameters { get; set; }

        /// <summary>
        /// Payload is the list of key-value extracted from an event payload to construct the request payload.
        /// </summary>
        /// <value>Payload is the list of key-value extracted from an event payload to construct the request payload.</value>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public List<IoArgoprojEventsV1alpha1TriggerParameter> Payload { get; set; }

        /// <summary>
        /// Gets or Sets Secure
        /// </summary>
        [DataMember(Name = "secure", EmitDefaultValue = true)]
        public bool Secure { get; set; }

        /// <summary>
        /// ServerNameOverride for the secure connection between sensor and custom trigger gRPC server.
        /// </summary>
        /// <value>ServerNameOverride for the secure connection between sensor and custom trigger gRPC server.</value>
        [DataMember(Name = "serverNameOverride", EmitDefaultValue = false)]
        public string ServerNameOverride { get; set; }

        /// <summary>
        /// Gets or Sets ServerURL
        /// </summary>
        [DataMember(Name = "serverURL", EmitDefaultValue = false)]
        public string ServerURL { get; set; }

        /// <summary>
        /// Spec is the custom trigger resource specification that custom trigger gRPC server knows how to interpret.
        /// </summary>
        /// <value>Spec is the custom trigger resource specification that custom trigger gRPC server knows how to interpret.</value>
        [DataMember(Name = "spec", EmitDefaultValue = false)]
        public Dictionary<string, string> Spec { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1CustomTrigger {\n");
            sb.Append("  CertSecret: ").Append(CertSecret).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Secure: ").Append(Secure).Append("\n");
            sb.Append("  ServerNameOverride: ").Append(ServerNameOverride).Append("\n");
            sb.Append("  ServerURL: ").Append(ServerURL).Append("\n");
            sb.Append("  Spec: ").Append(Spec).Append("\n");
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