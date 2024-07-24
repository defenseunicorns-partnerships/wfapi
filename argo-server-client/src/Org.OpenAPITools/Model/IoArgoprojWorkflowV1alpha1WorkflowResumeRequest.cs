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
    /// IoArgoprojWorkflowV1alpha1WorkflowResumeRequest
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.WorkflowResumeRequest")]
    public partial class IoArgoprojWorkflowV1alpha1WorkflowResumeRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1WorkflowResumeRequest" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="varNamespace">varNamespace.</param>
        /// <param name="nodeFieldSelector">nodeFieldSelector.</param>
        public IoArgoprojWorkflowV1alpha1WorkflowResumeRequest(string name = default(string), string varNamespace = default(string), string nodeFieldSelector = default(string))
        {
            this.Name = name;
            this.Namespace = varNamespace;
            this.NodeFieldSelector = nodeFieldSelector;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets NodeFieldSelector
        /// </summary>
        [DataMember(Name = "nodeFieldSelector", EmitDefaultValue = false)]
        public string NodeFieldSelector { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1WorkflowResumeRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  NodeFieldSelector: ").Append(NodeFieldSelector).Append("\n");
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
