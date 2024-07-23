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
    /// StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry
    /// </summary>
    [DataContract(Name = "Stream_result_of_io_argoproj_workflow_v1alpha1_LogEntry")]
    public partial class StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="result">result.</param>
        public StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry(GrpcGatewayRuntimeStreamError error = default(GrpcGatewayRuntimeStreamError), IoArgoprojWorkflowV1alpha1LogEntry result = default(IoArgoprojWorkflowV1alpha1LogEntry))
        {
            this.Error = error;
            this.Result = result;
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public GrpcGatewayRuntimeStreamError Error { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1LogEntry Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
