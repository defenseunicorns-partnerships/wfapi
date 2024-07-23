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
    /// TarStrategy will tar and gzip the file or directory when saving
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.TarStrategy")]
    public partial class IoArgoprojWorkflowV1alpha1TarStrategy : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1TarStrategy" /> class.
        /// </summary>
        /// <param name="compressionLevel">CompressionLevel specifies the gzip compression level to use for the artifact. Defaults to gzip.DefaultCompression..</param>
        public IoArgoprojWorkflowV1alpha1TarStrategy(int compressionLevel = default(int))
        {
            this.CompressionLevel = compressionLevel;
        }

        /// <summary>
        /// CompressionLevel specifies the gzip compression level to use for the artifact. Defaults to gzip.DefaultCompression.
        /// </summary>
        /// <value>CompressionLevel specifies the gzip compression level to use for the artifact. Defaults to gzip.DefaultCompression.</value>
        [DataMember(Name = "compressionLevel", EmitDefaultValue = false)]
        public int CompressionLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1TarStrategy {\n");
            sb.Append("  CompressionLevel: ").Append(CompressionLevel).Append("\n");
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