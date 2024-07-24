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
    /// ResourceTemplate is a template subtype to manipulate kubernetes resources
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.ResourceTemplate")]
    public partial class IoArgoprojWorkflowV1alpha1ResourceTemplate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1ResourceTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoArgoprojWorkflowV1alpha1ResourceTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1ResourceTemplate" /> class.
        /// </summary>
        /// <param name="action">Action is the action to perform to the resource. Must be one of: get, create, apply, delete, replace, patch (required).</param>
        /// <param name="failureCondition">FailureCondition is a label selector expression which describes the conditions of the k8s resource in which the step was considered failed.</param>
        /// <param name="flags">Flags is a set of additional options passed to kubectl before submitting a resource I.e. to disable resource validation: flags: [  \&quot;- -validate&#x3D;false\&quot;  # disable resource validation ].</param>
        /// <param name="manifest">Manifest contains the kubernetes manifest.</param>
        /// <param name="manifestFrom">manifestFrom.</param>
        /// <param name="mergeStrategy">MergeStrategy is the strategy used to merge a patch. It defaults to \&quot;strategic\&quot; Must be one of: strategic, merge, json.</param>
        /// <param name="setOwnerReference">SetOwnerReference sets the reference to the workflow on the OwnerReference of generated resource..</param>
        /// <param name="successCondition">SuccessCondition is a label selector expression which describes the conditions of the k8s resource in which it is acceptable to proceed to the following step.</param>
        public IoArgoprojWorkflowV1alpha1ResourceTemplate(string action = default(string), string failureCondition = default(string), List<string> flags = default(List<string>), string manifest = default(string), IoArgoprojWorkflowV1alpha1ManifestFrom manifestFrom = default(IoArgoprojWorkflowV1alpha1ManifestFrom), string mergeStrategy = default(string), bool setOwnerReference = default(bool), string successCondition = default(string))
        {
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new ArgumentNullException("action is a required property for IoArgoprojWorkflowV1alpha1ResourceTemplate and cannot be null");
            }
            this.Action = action;
            this.FailureCondition = failureCondition;
            this.Flags = flags;
            this.Manifest = manifest;
            this.ManifestFrom = manifestFrom;
            this.MergeStrategy = mergeStrategy;
            this.SetOwnerReference = setOwnerReference;
            this.SuccessCondition = successCondition;
        }

        /// <summary>
        /// Action is the action to perform to the resource. Must be one of: get, create, apply, delete, replace, patch
        /// </summary>
        /// <value>Action is the action to perform to the resource. Must be one of: get, create, apply, delete, replace, patch</value>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// FailureCondition is a label selector expression which describes the conditions of the k8s resource in which the step was considered failed
        /// </summary>
        /// <value>FailureCondition is a label selector expression which describes the conditions of the k8s resource in which the step was considered failed</value>
        [DataMember(Name = "failureCondition", EmitDefaultValue = false)]
        public string FailureCondition { get; set; }

        /// <summary>
        /// Flags is a set of additional options passed to kubectl before submitting a resource I.e. to disable resource validation: flags: [  \&quot;- -validate&#x3D;false\&quot;  # disable resource validation ]
        /// </summary>
        /// <value>Flags is a set of additional options passed to kubectl before submitting a resource I.e. to disable resource validation: flags: [  \&quot;- -validate&#x3D;false\&quot;  # disable resource validation ]</value>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        public List<string> Flags { get; set; }

        /// <summary>
        /// Manifest contains the kubernetes manifest
        /// </summary>
        /// <value>Manifest contains the kubernetes manifest</value>
        [DataMember(Name = "manifest", EmitDefaultValue = false)]
        public string Manifest { get; set; }

        /// <summary>
        /// Gets or Sets ManifestFrom
        /// </summary>
        [DataMember(Name = "manifestFrom", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1ManifestFrom ManifestFrom { get; set; }

        /// <summary>
        /// MergeStrategy is the strategy used to merge a patch. It defaults to \&quot;strategic\&quot; Must be one of: strategic, merge, json
        /// </summary>
        /// <value>MergeStrategy is the strategy used to merge a patch. It defaults to \&quot;strategic\&quot; Must be one of: strategic, merge, json</value>
        [DataMember(Name = "mergeStrategy", EmitDefaultValue = false)]
        public string MergeStrategy { get; set; }

        /// <summary>
        /// SetOwnerReference sets the reference to the workflow on the OwnerReference of generated resource.
        /// </summary>
        /// <value>SetOwnerReference sets the reference to the workflow on the OwnerReference of generated resource.</value>
        [DataMember(Name = "setOwnerReference", EmitDefaultValue = true)]
        public bool SetOwnerReference { get; set; }

        /// <summary>
        /// SuccessCondition is a label selector expression which describes the conditions of the k8s resource in which it is acceptable to proceed to the following step
        /// </summary>
        /// <value>SuccessCondition is a label selector expression which describes the conditions of the k8s resource in which it is acceptable to proceed to the following step</value>
        [DataMember(Name = "successCondition", EmitDefaultValue = false)]
        public string SuccessCondition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1ResourceTemplate {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  FailureCondition: ").Append(FailureCondition).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Manifest: ").Append(Manifest).Append("\n");
            sb.Append("  ManifestFrom: ").Append(ManifestFrom).Append("\n");
            sb.Append("  MergeStrategy: ").Append(MergeStrategy).Append("\n");
            sb.Append("  SetOwnerReference: ").Append(SetOwnerReference).Append("\n");
            sb.Append("  SuccessCondition: ").Append(SuccessCondition).Append("\n");
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
