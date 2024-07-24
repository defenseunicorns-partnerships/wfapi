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
    /// OpenWhiskTrigger refers to the specification of the OpenWhisk trigger.
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.OpenWhiskTrigger")]
    public partial class IoArgoprojEventsV1alpha1OpenWhiskTrigger : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1OpenWhiskTrigger" /> class.
        /// </summary>
        /// <param name="actionName">Name of the action/function..</param>
        /// <param name="authToken">authToken.</param>
        /// <param name="host">Host URL of the OpenWhisk..</param>
        /// <param name="varNamespace">Namespace for the action. Defaults to \&quot;_\&quot;. +optional..</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="payload">Payload is the list of key-value extracted from an event payload to construct the request payload..</param>
        /// <param name="varVersion">varVersion.</param>
        public IoArgoprojEventsV1alpha1OpenWhiskTrigger(string actionName = default(string), IoK8sApiCoreV1SecretKeySelector authToken = default(IoK8sApiCoreV1SecretKeySelector), string host = default(string), string varNamespace = default(string), List<IoArgoprojEventsV1alpha1TriggerParameter> parameters = default(List<IoArgoprojEventsV1alpha1TriggerParameter>), List<IoArgoprojEventsV1alpha1TriggerParameter> payload = default(List<IoArgoprojEventsV1alpha1TriggerParameter>), string varVersion = default(string))
        {
            this.ActionName = actionName;
            this.AuthToken = authToken;
            this.Host = host;
            this.Namespace = varNamespace;
            this.Parameters = parameters;
            this.Payload = payload;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// Name of the action/function.
        /// </summary>
        /// <value>Name of the action/function.</value>
        [DataMember(Name = "actionName", EmitDefaultValue = false)]
        public string ActionName { get; set; }

        /// <summary>
        /// Gets or Sets AuthToken
        /// </summary>
        [DataMember(Name = "authToken", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector AuthToken { get; set; }

        /// <summary>
        /// Host URL of the OpenWhisk.
        /// </summary>
        /// <value>Host URL of the OpenWhisk.</value>
        [DataMember(Name = "host", EmitDefaultValue = false)]
        public string Host { get; set; }

        /// <summary>
        /// Namespace for the action. Defaults to \&quot;_\&quot;. +optional.
        /// </summary>
        /// <value>Namespace for the action. Defaults to \&quot;_\&quot;. +optional.</value>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<IoArgoprojEventsV1alpha1TriggerParameter> Parameters { get; set; }

        /// <summary>
        /// Payload is the list of key-value extracted from an event payload to construct the request payload.
        /// </summary>
        /// <value>Payload is the list of key-value extracted from an event payload to construct the request payload.</value>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public List<IoArgoprojEventsV1alpha1TriggerParameter> Payload { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1OpenWhiskTrigger {\n");
            sb.Append("  ActionName: ").Append(ActionName).Append("\n");
            sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
