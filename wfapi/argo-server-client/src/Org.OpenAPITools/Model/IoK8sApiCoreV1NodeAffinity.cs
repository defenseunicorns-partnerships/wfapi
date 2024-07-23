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
    /// Node affinity is a group of node affinity scheduling rules.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.NodeAffinity")]
    public partial class IoK8sApiCoreV1NodeAffinity : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1NodeAffinity" /> class.
        /// </summary>
        /// <param name="preferredDuringSchedulingIgnoredDuringExecution">The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding \&quot;weight\&quot; to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred..</param>
        /// <param name="requiredDuringSchedulingIgnoredDuringExecution">requiredDuringSchedulingIgnoredDuringExecution.</param>
        public IoK8sApiCoreV1NodeAffinity(List<IoK8sApiCoreV1PreferredSchedulingTerm> preferredDuringSchedulingIgnoredDuringExecution = default(List<IoK8sApiCoreV1PreferredSchedulingTerm>), IoK8sApiCoreV1NodeSelector requiredDuringSchedulingIgnoredDuringExecution = default(IoK8sApiCoreV1NodeSelector))
        {
            this.PreferredDuringSchedulingIgnoredDuringExecution = preferredDuringSchedulingIgnoredDuringExecution;
            this.RequiredDuringSchedulingIgnoredDuringExecution = requiredDuringSchedulingIgnoredDuringExecution;
        }

        /// <summary>
        /// The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding \&quot;weight\&quot; to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.
        /// </summary>
        /// <value>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding \&quot;weight\&quot; to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.</value>
        [DataMember(Name = "preferredDuringSchedulingIgnoredDuringExecution", EmitDefaultValue = false)]
        public List<IoK8sApiCoreV1PreferredSchedulingTerm> PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

        /// <summary>
        /// Gets or Sets RequiredDuringSchedulingIgnoredDuringExecution
        /// </summary>
        [DataMember(Name = "requiredDuringSchedulingIgnoredDuringExecution", EmitDefaultValue = false)]
        public IoK8sApiCoreV1NodeSelector RequiredDuringSchedulingIgnoredDuringExecution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1NodeAffinity {\n");
            sb.Append("  PreferredDuringSchedulingIgnoredDuringExecution: ").Append(PreferredDuringSchedulingIgnoredDuringExecution).Append("\n");
            sb.Append("  RequiredDuringSchedulingIgnoredDuringExecution: ").Append(RequiredDuringSchedulingIgnoredDuringExecution).Append("\n");
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
