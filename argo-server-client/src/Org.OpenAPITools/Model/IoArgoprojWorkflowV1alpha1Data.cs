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
    /// Data is a data template
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.Data")]
    public partial class IoArgoprojWorkflowV1alpha1Data : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1Data" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoArgoprojWorkflowV1alpha1Data() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1Data" /> class.
        /// </summary>
        /// <param name="source">source (required).</param>
        /// <param name="transformation">Transformation applies a set of transformations (required).</param>
        public IoArgoprojWorkflowV1alpha1Data(IoArgoprojWorkflowV1alpha1DataSource source = default(IoArgoprojWorkflowV1alpha1DataSource), List<IoArgoprojWorkflowV1alpha1TransformationStep> transformation = default(List<IoArgoprojWorkflowV1alpha1TransformationStep>))
        {
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new ArgumentNullException("source is a required property for IoArgoprojWorkflowV1alpha1Data and cannot be null");
            }
            this.Source = source;
            // to ensure "transformation" is required (not null)
            if (transformation == null)
            {
                throw new ArgumentNullException("transformation is a required property for IoArgoprojWorkflowV1alpha1Data and cannot be null");
            }
            this.Transformation = transformation;
        }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = true)]
        public IoArgoprojWorkflowV1alpha1DataSource Source { get; set; }

        /// <summary>
        /// Transformation applies a set of transformations
        /// </summary>
        /// <value>Transformation applies a set of transformations</value>
        [DataMember(Name = "transformation", IsRequired = true, EmitDefaultValue = true)]
        public List<IoArgoprojWorkflowV1alpha1TransformationStep> Transformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1Data {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Transformation: ").Append(Transformation).Append("\n");
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
