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
    /// IoArgoprojEventsV1alpha1PulsarEventSource
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.PulsarEventSource")]
    public partial class IoArgoprojEventsV1alpha1PulsarEventSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1PulsarEventSource" /> class.
        /// </summary>
        /// <param name="authAthenzParams">authAthenzParams.</param>
        /// <param name="authAthenzSecret">authAthenzSecret.</param>
        /// <param name="authTokenSecret">authTokenSecret.</param>
        /// <param name="connectionBackoff">connectionBackoff.</param>
        /// <param name="filter">filter.</param>
        /// <param name="jsonBody">jsonBody.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="tls">tls.</param>
        /// <param name="tlsAllowInsecureConnection">tlsAllowInsecureConnection.</param>
        /// <param name="tlsTrustCertsSecret">tlsTrustCertsSecret.</param>
        /// <param name="tlsValidateHostname">tlsValidateHostname.</param>
        /// <param name="topics">topics.</param>
        /// <param name="type">type.</param>
        /// <param name="url">url.</param>
        public IoArgoprojEventsV1alpha1PulsarEventSource(Dictionary<string, string> authAthenzParams = default(Dictionary<string, string>), IoK8sApiCoreV1SecretKeySelector authAthenzSecret = default(IoK8sApiCoreV1SecretKeySelector), IoK8sApiCoreV1SecretKeySelector authTokenSecret = default(IoK8sApiCoreV1SecretKeySelector), IoArgoprojEventsV1alpha1Backoff connectionBackoff = default(IoArgoprojEventsV1alpha1Backoff), IoArgoprojEventsV1alpha1EventSourceFilter filter = default(IoArgoprojEventsV1alpha1EventSourceFilter), bool jsonBody = default(bool), Dictionary<string, string> metadata = default(Dictionary<string, string>), IoArgoprojEventsV1alpha1TLSConfig tls = default(IoArgoprojEventsV1alpha1TLSConfig), bool tlsAllowInsecureConnection = default(bool), IoK8sApiCoreV1SecretKeySelector tlsTrustCertsSecret = default(IoK8sApiCoreV1SecretKeySelector), bool tlsValidateHostname = default(bool), List<string> topics = default(List<string>), string type = default(string), string url = default(string))
        {
            this.AuthAthenzParams = authAthenzParams;
            this.AuthAthenzSecret = authAthenzSecret;
            this.AuthTokenSecret = authTokenSecret;
            this.ConnectionBackoff = connectionBackoff;
            this.Filter = filter;
            this.JsonBody = jsonBody;
            this.Metadata = metadata;
            this.Tls = tls;
            this.TlsAllowInsecureConnection = tlsAllowInsecureConnection;
            this.TlsTrustCertsSecret = tlsTrustCertsSecret;
            this.TlsValidateHostname = tlsValidateHostname;
            this.Topics = topics;
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets AuthAthenzParams
        /// </summary>
        [DataMember(Name = "authAthenzParams", EmitDefaultValue = false)]
        public Dictionary<string, string> AuthAthenzParams { get; set; }

        /// <summary>
        /// Gets or Sets AuthAthenzSecret
        /// </summary>
        [DataMember(Name = "authAthenzSecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector AuthAthenzSecret { get; set; }

        /// <summary>
        /// Gets or Sets AuthTokenSecret
        /// </summary>
        [DataMember(Name = "authTokenSecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector AuthTokenSecret { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionBackoff
        /// </summary>
        [DataMember(Name = "connectionBackoff", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1Backoff ConnectionBackoff { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1EventSourceFilter Filter { get; set; }

        /// <summary>
        /// Gets or Sets JsonBody
        /// </summary>
        [DataMember(Name = "jsonBody", EmitDefaultValue = true)]
        public bool JsonBody { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Tls
        /// </summary>
        [DataMember(Name = "tls", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1TLSConfig Tls { get; set; }

        /// <summary>
        /// Gets or Sets TlsAllowInsecureConnection
        /// </summary>
        [DataMember(Name = "tlsAllowInsecureConnection", EmitDefaultValue = true)]
        public bool TlsAllowInsecureConnection { get; set; }

        /// <summary>
        /// Gets or Sets TlsTrustCertsSecret
        /// </summary>
        [DataMember(Name = "tlsTrustCertsSecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector TlsTrustCertsSecret { get; set; }

        /// <summary>
        /// Gets or Sets TlsValidateHostname
        /// </summary>
        [DataMember(Name = "tlsValidateHostname", EmitDefaultValue = true)]
        public bool TlsValidateHostname { get; set; }

        /// <summary>
        /// Gets or Sets Topics
        /// </summary>
        [DataMember(Name = "topics", EmitDefaultValue = false)]
        public List<string> Topics { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1PulsarEventSource {\n");
            sb.Append("  AuthAthenzParams: ").Append(AuthAthenzParams).Append("\n");
            sb.Append("  AuthAthenzSecret: ").Append(AuthAthenzSecret).Append("\n");
            sb.Append("  AuthTokenSecret: ").Append(AuthTokenSecret).Append("\n");
            sb.Append("  ConnectionBackoff: ").Append(ConnectionBackoff).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  JsonBody: ").Append(JsonBody).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Tls: ").Append(Tls).Append("\n");
            sb.Append("  TlsAllowInsecureConnection: ").Append(TlsAllowInsecureConnection).Append("\n");
            sb.Append("  TlsTrustCertsSecret: ").Append(TlsTrustCertsSecret).Append("\n");
            sb.Append("  TlsValidateHostname: ").Append(TlsValidateHostname).Append("\n");
            sb.Append("  Topics: ").Append(Topics).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
