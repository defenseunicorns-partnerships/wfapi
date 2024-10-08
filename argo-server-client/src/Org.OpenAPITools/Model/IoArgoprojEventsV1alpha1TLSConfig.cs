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
    /// TLSConfig refers to TLS configuration for a client.
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.TLSConfig")]
    public partial class IoArgoprojEventsV1alpha1TLSConfig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1TLSConfig" /> class.
        /// </summary>
        /// <param name="caCertSecret">caCertSecret.</param>
        /// <param name="clientCertSecret">clientCertSecret.</param>
        /// <param name="clientKeySecret">clientKeySecret.</param>
        /// <param name="insecureSkipVerify">insecureSkipVerify.</param>
        public IoArgoprojEventsV1alpha1TLSConfig(IoK8sApiCoreV1SecretKeySelector caCertSecret = default(IoK8sApiCoreV1SecretKeySelector), IoK8sApiCoreV1SecretKeySelector clientCertSecret = default(IoK8sApiCoreV1SecretKeySelector), IoK8sApiCoreV1SecretKeySelector clientKeySecret = default(IoK8sApiCoreV1SecretKeySelector), bool insecureSkipVerify = default(bool))
        {
            this.CaCertSecret = caCertSecret;
            this.ClientCertSecret = clientCertSecret;
            this.ClientKeySecret = clientKeySecret;
            this.InsecureSkipVerify = insecureSkipVerify;
        }

        /// <summary>
        /// Gets or Sets CaCertSecret
        /// </summary>
        [DataMember(Name = "caCertSecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector CaCertSecret { get; set; }

        /// <summary>
        /// Gets or Sets ClientCertSecret
        /// </summary>
        [DataMember(Name = "clientCertSecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector ClientCertSecret { get; set; }

        /// <summary>
        /// Gets or Sets ClientKeySecret
        /// </summary>
        [DataMember(Name = "clientKeySecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector ClientKeySecret { get; set; }

        /// <summary>
        /// Gets or Sets InsecureSkipVerify
        /// </summary>
        [DataMember(Name = "insecureSkipVerify", EmitDefaultValue = true)]
        public bool InsecureSkipVerify { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1TLSConfig {\n");
            sb.Append("  CaCertSecret: ").Append(CaCertSecret).Append("\n");
            sb.Append("  ClientCertSecret: ").Append(ClientCertSecret).Append("\n");
            sb.Append("  ClientKeySecret: ").Append(ClientKeySecret).Append("\n");
            sb.Append("  InsecureSkipVerify: ").Append(InsecureSkipVerify).Append("\n");
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
