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
    /// IoArgoprojEventsV1alpha1GitArtifact
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.GitArtifact")]
    public partial class IoArgoprojEventsV1alpha1GitArtifact : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1GitArtifact" /> class.
        /// </summary>
        /// <param name="branch">branch.</param>
        /// <param name="cloneDirectory">Directory to clone the repository. We clone complete directory because GitArtifact is not limited to any specific Git service providers. Hence we don&#39;t use any specific git provider client..</param>
        /// <param name="creds">creds.</param>
        /// <param name="filePath">filePath.</param>
        /// <param name="insecureIgnoreHostKey">insecureIgnoreHostKey.</param>
        /// <param name="varRef">varRef.</param>
        /// <param name="remote">remote.</param>
        /// <param name="sshKeySecret">sshKeySecret.</param>
        /// <param name="tag">tag.</param>
        /// <param name="url">url.</param>
        public IoArgoprojEventsV1alpha1GitArtifact(string branch = default(string), string cloneDirectory = default(string), IoArgoprojEventsV1alpha1GitCreds creds = default(IoArgoprojEventsV1alpha1GitCreds), string filePath = default(string), bool insecureIgnoreHostKey = default(bool), string varRef = default(string), IoArgoprojEventsV1alpha1GitRemoteConfig remote = default(IoArgoprojEventsV1alpha1GitRemoteConfig), IoK8sApiCoreV1SecretKeySelector sshKeySecret = default(IoK8sApiCoreV1SecretKeySelector), string tag = default(string), string url = default(string))
        {
            this.Branch = branch;
            this.CloneDirectory = cloneDirectory;
            this.Creds = creds;
            this.FilePath = filePath;
            this.InsecureIgnoreHostKey = insecureIgnoreHostKey;
            this.Ref = varRef;
            this.Remote = remote;
            this.SshKeySecret = sshKeySecret;
            this.Tag = tag;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name = "branch", EmitDefaultValue = false)]
        public string Branch { get; set; }

        /// <summary>
        /// Directory to clone the repository. We clone complete directory because GitArtifact is not limited to any specific Git service providers. Hence we don&#39;t use any specific git provider client.
        /// </summary>
        /// <value>Directory to clone the repository. We clone complete directory because GitArtifact is not limited to any specific Git service providers. Hence we don&#39;t use any specific git provider client.</value>
        [DataMember(Name = "cloneDirectory", EmitDefaultValue = false)]
        public string CloneDirectory { get; set; }

        /// <summary>
        /// Gets or Sets Creds
        /// </summary>
        [DataMember(Name = "creds", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1GitCreds Creds { get; set; }

        /// <summary>
        /// Gets or Sets FilePath
        /// </summary>
        [DataMember(Name = "filePath", EmitDefaultValue = false)]
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or Sets InsecureIgnoreHostKey
        /// </summary>
        [DataMember(Name = "insecureIgnoreHostKey", EmitDefaultValue = true)]
        public bool InsecureIgnoreHostKey { get; set; }

        /// <summary>
        /// Gets or Sets Ref
        /// </summary>
        [DataMember(Name = "ref", EmitDefaultValue = false)]
        public string Ref { get; set; }

        /// <summary>
        /// Gets or Sets Remote
        /// </summary>
        [DataMember(Name = "remote", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1GitRemoteConfig Remote { get; set; }

        /// <summary>
        /// Gets or Sets SshKeySecret
        /// </summary>
        [DataMember(Name = "sshKeySecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector SshKeySecret { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public string Tag { get; set; }

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
            sb.Append("class IoArgoprojEventsV1alpha1GitArtifact {\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  CloneDirectory: ").Append(CloneDirectory).Append("\n");
            sb.Append("  Creds: ").Append(Creds).Append("\n");
            sb.Append("  FilePath: ").Append(FilePath).Append("\n");
            sb.Append("  InsecureIgnoreHostKey: ").Append(InsecureIgnoreHostKey).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  Remote: ").Append(Remote).Append("\n");
            sb.Append("  SshKeySecret: ").Append(SshKeySecret).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
