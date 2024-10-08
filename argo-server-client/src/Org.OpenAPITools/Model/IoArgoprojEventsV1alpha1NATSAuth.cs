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
    /// IoArgoprojEventsV1alpha1NATSAuth
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.NATSAuth")]
    public partial class IoArgoprojEventsV1alpha1NATSAuth : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1NATSAuth" /> class.
        /// </summary>
        /// <param name="basic">basic.</param>
        /// <param name="credential">credential.</param>
        /// <param name="nkey">nkey.</param>
        /// <param name="token">token.</param>
        public IoArgoprojEventsV1alpha1NATSAuth(IoArgoprojEventsV1alpha1BasicAuth basic = default(IoArgoprojEventsV1alpha1BasicAuth), IoK8sApiCoreV1SecretKeySelector credential = default(IoK8sApiCoreV1SecretKeySelector), IoK8sApiCoreV1SecretKeySelector nkey = default(IoK8sApiCoreV1SecretKeySelector), IoK8sApiCoreV1SecretKeySelector token = default(IoK8sApiCoreV1SecretKeySelector))
        {
            this.Basic = basic;
            this.Credential = credential;
            this.Nkey = nkey;
            this.Token = token;
        }

        /// <summary>
        /// Gets or Sets Basic
        /// </summary>
        [DataMember(Name = "basic", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1BasicAuth Basic { get; set; }

        /// <summary>
        /// Gets or Sets Credential
        /// </summary>
        [DataMember(Name = "credential", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector Credential { get; set; }

        /// <summary>
        /// Gets or Sets Nkey
        /// </summary>
        [DataMember(Name = "nkey", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector Nkey { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1NATSAuth {\n");
            sb.Append("  Basic: ").Append(Basic).Append("\n");
            sb.Append("  Credential: ").Append(Credential).Append("\n");
            sb.Append("  Nkey: ").Append(Nkey).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
