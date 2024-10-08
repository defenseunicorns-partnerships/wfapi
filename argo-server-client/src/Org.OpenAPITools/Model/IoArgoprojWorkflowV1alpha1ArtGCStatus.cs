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
    /// ArtGCStatus maintains state related to ArtifactGC
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.ArtGCStatus")]
    public partial class IoArgoprojWorkflowV1alpha1ArtGCStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1ArtGCStatus" /> class.
        /// </summary>
        /// <param name="notSpecified">if this is true, we already checked to see if we need to do it and we don&#39;t.</param>
        /// <param name="podsRecouped">have completed Pods been processed? (mapped by Pod name) used to prevent re-processing the Status of a Pod more than once.</param>
        /// <param name="strategiesProcessed">have Pods been started to perform this strategy? (enables us not to re-process what we&#39;ve already done).</param>
        public IoArgoprojWorkflowV1alpha1ArtGCStatus(bool notSpecified = default(bool), Dictionary<string, bool> podsRecouped = default(Dictionary<string, bool>), Dictionary<string, bool> strategiesProcessed = default(Dictionary<string, bool>))
        {
            this.NotSpecified = notSpecified;
            this.PodsRecouped = podsRecouped;
            this.StrategiesProcessed = strategiesProcessed;
        }

        /// <summary>
        /// if this is true, we already checked to see if we need to do it and we don&#39;t
        /// </summary>
        /// <value>if this is true, we already checked to see if we need to do it and we don&#39;t</value>
        [DataMember(Name = "notSpecified", EmitDefaultValue = true)]
        public bool NotSpecified { get; set; }

        /// <summary>
        /// have completed Pods been processed? (mapped by Pod name) used to prevent re-processing the Status of a Pod more than once
        /// </summary>
        /// <value>have completed Pods been processed? (mapped by Pod name) used to prevent re-processing the Status of a Pod more than once</value>
        [DataMember(Name = "podsRecouped", EmitDefaultValue = false)]
        public Dictionary<string, bool> PodsRecouped { get; set; }

        /// <summary>
        /// have Pods been started to perform this strategy? (enables us not to re-process what we&#39;ve already done)
        /// </summary>
        /// <value>have Pods been started to perform this strategy? (enables us not to re-process what we&#39;ve already done)</value>
        [DataMember(Name = "strategiesProcessed", EmitDefaultValue = false)]
        public Dictionary<string, bool> StrategiesProcessed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1ArtGCStatus {\n");
            sb.Append("  NotSpecified: ").Append(NotSpecified).Append("\n");
            sb.Append("  PodsRecouped: ").Append(PodsRecouped).Append("\n");
            sb.Append("  StrategiesProcessed: ").Append(StrategiesProcessed).Append("\n");
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
