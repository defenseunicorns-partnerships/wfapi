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
    /// Outputs hold parameters, artifacts, and results from a step
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.Outputs")]
    public partial class IoArgoprojWorkflowV1alpha1Outputs : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1Outputs" /> class.
        /// </summary>
        /// <param name="artifacts">Artifacts holds the list of output artifacts produced by a step.</param>
        /// <param name="exitCode">ExitCode holds the exit code of a script template.</param>
        /// <param name="parameters">Parameters holds the list of output parameters produced by a step.</param>
        /// <param name="result">Result holds the result (stdout) of a script template.</param>
        public IoArgoprojWorkflowV1alpha1Outputs(List<IoArgoprojWorkflowV1alpha1Artifact> artifacts = default(List<IoArgoprojWorkflowV1alpha1Artifact>), string exitCode = default(string), List<IoArgoprojWorkflowV1alpha1Parameter> parameters = default(List<IoArgoprojWorkflowV1alpha1Parameter>), string result = default(string))
        {
            this.Artifacts = artifacts;
            this.ExitCode = exitCode;
            this.Parameters = parameters;
            this.Result = result;
        }

        /// <summary>
        /// Artifacts holds the list of output artifacts produced by a step
        /// </summary>
        /// <value>Artifacts holds the list of output artifacts produced by a step</value>
        [DataMember(Name = "artifacts", EmitDefaultValue = false)]
        public List<IoArgoprojWorkflowV1alpha1Artifact> Artifacts { get; set; }

        /// <summary>
        /// ExitCode holds the exit code of a script template
        /// </summary>
        /// <value>ExitCode holds the exit code of a script template</value>
        [DataMember(Name = "exitCode", EmitDefaultValue = false)]
        public string ExitCode { get; set; }

        /// <summary>
        /// Parameters holds the list of output parameters produced by a step
        /// </summary>
        /// <value>Parameters holds the list of output parameters produced by a step</value>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<IoArgoprojWorkflowV1alpha1Parameter> Parameters { get; set; }

        /// <summary>
        /// Result holds the result (stdout) of a script template
        /// </summary>
        /// <value>Result holds the result (stdout) of a script template</value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public string Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1Outputs {\n");
            sb.Append("  Artifacts: ").Append(Artifacts).Append("\n");
            sb.Append("  ExitCode: ").Append(ExitCode).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
