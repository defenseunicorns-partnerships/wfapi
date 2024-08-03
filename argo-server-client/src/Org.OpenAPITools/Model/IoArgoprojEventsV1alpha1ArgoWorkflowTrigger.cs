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
    /// IoArgoprojEventsV1alpha1ArgoWorkflowTrigger
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.ArgoWorkflowTrigger")]
    public partial class IoArgoprojEventsV1alpha1ArgoWorkflowTrigger : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1ArgoWorkflowTrigger" /> class.
        /// </summary>
        /// <param name="args">args.</param>
        /// <param name="operation">operation.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="source">source.</param>
        public IoArgoprojEventsV1alpha1ArgoWorkflowTrigger(List<string> args = default(List<string>), string operation = default(string), List<IoArgoprojEventsV1alpha1TriggerParameter> parameters = default(List<IoArgoprojEventsV1alpha1TriggerParameter>), IoArgoprojEventsV1alpha1ArtifactLocation source = default(IoArgoprojEventsV1alpha1ArtifactLocation))
        {
            this.Args = args;
            this.Operation = operation;
            this.Parameters = parameters;
            this.Source = source;
        }

        /// <summary>
        /// Gets or Sets Args
        /// </summary>
        [DataMember(Name = "args", EmitDefaultValue = false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name = "operation", EmitDefaultValue = false)]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<IoArgoprojEventsV1alpha1TriggerParameter> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1ArtifactLocation Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1ArgoWorkflowTrigger {\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
