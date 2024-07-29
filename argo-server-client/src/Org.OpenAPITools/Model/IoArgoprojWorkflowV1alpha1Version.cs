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
    /// IoArgoprojWorkflowV1alpha1Version
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.Version")]
    public partial class IoArgoprojWorkflowV1alpha1Version : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1Version" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoArgoprojWorkflowV1alpha1Version() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1Version" /> class.
        /// </summary>
        /// <param name="buildDate">buildDate (required).</param>
        /// <param name="compiler">compiler (required).</param>
        /// <param name="gitCommit">gitCommit (required).</param>
        /// <param name="gitTag">gitTag (required).</param>
        /// <param name="gitTreeState">gitTreeState (required).</param>
        /// <param name="goVersion">goVersion (required).</param>
        /// <param name="platform">platform (required).</param>
        /// <param name="varVersion">varVersion (required).</param>
        public IoArgoprojWorkflowV1alpha1Version(string buildDate = default(string), string compiler = default(string), string gitCommit = default(string), string gitTag = default(string), string gitTreeState = default(string), string goVersion = default(string), string platform = default(string), string varVersion = default(string))
        {
            // to ensure "buildDate" is required (not null)
            if (buildDate == null)
            {
                throw new ArgumentNullException("buildDate is a required property for IoArgoprojWorkflowV1alpha1Version and cannot be null");
            }
            this.BuildDate = buildDate;
            // to ensure "compiler" is required (not null)
            if (compiler == null)
            {
                throw new ArgumentNullException("compiler is a required property for IoArgoprojWorkflowV1alpha1Version and cannot be null");
            }
            this.Compiler = compiler;
            // to ensure "gitCommit" is required (not null)
            if (gitCommit == null)
            {
                throw new ArgumentNullException("gitCommit is a required property for IoArgoprojWorkflowV1alpha1Version and cannot be null");
            }
            this.GitCommit = gitCommit;
            // to ensure "gitTag" is required (not null)
            if (gitTag == null)
            {
                throw new ArgumentNullException("gitTag is a required property for IoArgoprojWorkflowV1alpha1Version and cannot be null");
            }
            this.GitTag = gitTag;
            // to ensure "gitTreeState" is required (not null)
            if (gitTreeState == null)
            {
                throw new ArgumentNullException("gitTreeState is a required property for IoArgoprojWorkflowV1alpha1Version and cannot be null");
            }
            this.GitTreeState = gitTreeState;
            // to ensure "goVersion" is required (not null)
            if (goVersion == null)
            {
                throw new ArgumentNullException("goVersion is a required property for IoArgoprojWorkflowV1alpha1Version and cannot be null");
            }
            this.GoVersion = goVersion;
            // to ensure "platform" is required (not null)
            if (platform == null)
            {
                throw new ArgumentNullException("platform is a required property for IoArgoprojWorkflowV1alpha1Version and cannot be null");
            }
            this.Platform = platform;
            // to ensure "varVersion" is required (not null)
            if (varVersion == null)
            {
                throw new ArgumentNullException("varVersion is a required property for IoArgoprojWorkflowV1alpha1Version and cannot be null");
            }
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// Gets or Sets BuildDate
        /// </summary>
        [DataMember(Name = "buildDate", IsRequired = true, EmitDefaultValue = true)]
        public string BuildDate { get; set; }

        /// <summary>
        /// Gets or Sets Compiler
        /// </summary>
        [DataMember(Name = "compiler", IsRequired = true, EmitDefaultValue = true)]
        public string Compiler { get; set; }

        /// <summary>
        /// Gets or Sets GitCommit
        /// </summary>
        [DataMember(Name = "gitCommit", IsRequired = true, EmitDefaultValue = true)]
        public string GitCommit { get; set; }

        /// <summary>
        /// Gets or Sets GitTag
        /// </summary>
        [DataMember(Name = "gitTag", IsRequired = true, EmitDefaultValue = true)]
        public string GitTag { get; set; }

        /// <summary>
        /// Gets or Sets GitTreeState
        /// </summary>
        [DataMember(Name = "gitTreeState", IsRequired = true, EmitDefaultValue = true)]
        public string GitTreeState { get; set; }

        /// <summary>
        /// Gets or Sets GoVersion
        /// </summary>
        [DataMember(Name = "goVersion", IsRequired = true, EmitDefaultValue = true)]
        public string GoVersion { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1Version {\n");
            sb.Append("  BuildDate: ").Append(BuildDate).Append("\n");
            sb.Append("  Compiler: ").Append(Compiler).Append("\n");
            sb.Append("  GitCommit: ").Append(GitCommit).Append("\n");
            sb.Append("  GitTag: ").Append(GitTag).Append("\n");
            sb.Append("  GitTreeState: ").Append(GitTreeState).Append("\n");
            sb.Append("  GoVersion: ").Append(GoVersion).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
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