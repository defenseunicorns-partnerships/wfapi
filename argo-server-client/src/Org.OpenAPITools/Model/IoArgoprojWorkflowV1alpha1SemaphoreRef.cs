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
    /// SemaphoreRef is a reference of Semaphore
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.SemaphoreRef")]
    public partial class IoArgoprojWorkflowV1alpha1SemaphoreRef : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1SemaphoreRef" /> class.
        /// </summary>
        /// <param name="configMapKeyRef">configMapKeyRef.</param>
        /// <param name="varNamespace">Namespace is the namespace of the configmap, default: [namespace of workflow].</param>
        public IoArgoprojWorkflowV1alpha1SemaphoreRef(IoK8sApiCoreV1ConfigMapKeySelector configMapKeyRef = default(IoK8sApiCoreV1ConfigMapKeySelector), string varNamespace = default(string))
        {
            this.ConfigMapKeyRef = configMapKeyRef;
            this.Namespace = varNamespace;
        }

        /// <summary>
        /// Gets or Sets ConfigMapKeyRef
        /// </summary>
        [DataMember(Name = "configMapKeyRef", EmitDefaultValue = false)]
        public IoK8sApiCoreV1ConfigMapKeySelector ConfigMapKeyRef { get; set; }

        /// <summary>
        /// Namespace is the namespace of the configmap, default: [namespace of workflow]
        /// </summary>
        /// <value>Namespace is the namespace of the configmap, default: [namespace of workflow]</value>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1SemaphoreRef {\n");
            sb.Append("  ConfigMapKeyRef: ").Append(ConfigMapKeyRef).Append("\n");
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