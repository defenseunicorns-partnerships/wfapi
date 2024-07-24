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
    /// IoArgoprojWorkflowV1alpha1CreateCronWorkflowRequest
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.CreateCronWorkflowRequest")]
    public partial class IoArgoprojWorkflowV1alpha1CreateCronWorkflowRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1CreateCronWorkflowRequest" /> class.
        /// </summary>
        /// <param name="createOptions">createOptions.</param>
        /// <param name="cronWorkflow">cronWorkflow.</param>
        /// <param name="varNamespace">varNamespace.</param>
        public IoArgoprojWorkflowV1alpha1CreateCronWorkflowRequest(IoK8sApimachineryPkgApisMetaV1CreateOptions createOptions = default(IoK8sApimachineryPkgApisMetaV1CreateOptions), IoArgoprojWorkflowV1alpha1CronWorkflow cronWorkflow = default(IoArgoprojWorkflowV1alpha1CronWorkflow), string varNamespace = default(string))
        {
            this.CreateOptions = createOptions;
            this.CronWorkflow = cronWorkflow;
            this.Namespace = varNamespace;
        }

        /// <summary>
        /// Gets or Sets CreateOptions
        /// </summary>
        [DataMember(Name = "createOptions", EmitDefaultValue = false)]
        public IoK8sApimachineryPkgApisMetaV1CreateOptions CreateOptions { get; set; }

        /// <summary>
        /// Gets or Sets CronWorkflow
        /// </summary>
        [DataMember(Name = "cronWorkflow", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1CronWorkflow CronWorkflow { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1CreateCronWorkflowRequest {\n");
            sb.Append("  CreateOptions: ").Append(CreateOptions).Append("\n");
            sb.Append("  CronWorkflow: ").Append(CronWorkflow).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
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
