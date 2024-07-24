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
    /// A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.NodeSelectorTerm")]
    public partial class IoK8sApiCoreV1NodeSelectorTerm : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1NodeSelectorTerm" /> class.
        /// </summary>
        /// <param name="matchExpressions">A list of node selector requirements by node&#39;s labels..</param>
        /// <param name="matchFields">A list of node selector requirements by node&#39;s fields..</param>
        public IoK8sApiCoreV1NodeSelectorTerm(List<IoK8sApiCoreV1NodeSelectorRequirement> matchExpressions = default(List<IoK8sApiCoreV1NodeSelectorRequirement>), List<IoK8sApiCoreV1NodeSelectorRequirement> matchFields = default(List<IoK8sApiCoreV1NodeSelectorRequirement>))
        {
            this.MatchExpressions = matchExpressions;
            this.MatchFields = matchFields;
        }

        /// <summary>
        /// A list of node selector requirements by node&#39;s labels.
        /// </summary>
        /// <value>A list of node selector requirements by node&#39;s labels.</value>
        [DataMember(Name = "matchExpressions", EmitDefaultValue = false)]
        public List<IoK8sApiCoreV1NodeSelectorRequirement> MatchExpressions { get; set; }

        /// <summary>
        /// A list of node selector requirements by node&#39;s fields.
        /// </summary>
        /// <value>A list of node selector requirements by node&#39;s fields.</value>
        [DataMember(Name = "matchFields", EmitDefaultValue = false)]
        public List<IoK8sApiCoreV1NodeSelectorRequirement> MatchFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1NodeSelectorTerm {\n");
            sb.Append("  MatchExpressions: ").Append(MatchExpressions).Append("\n");
            sb.Append("  MatchFields: ").Append(MatchFields).Append("\n");
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
