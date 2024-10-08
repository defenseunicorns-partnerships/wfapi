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
    /// IoArgoprojWorkflowV1alpha1SemaphoreHolding
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.SemaphoreHolding")]
    public partial class IoArgoprojWorkflowV1alpha1SemaphoreHolding : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1SemaphoreHolding" /> class.
        /// </summary>
        /// <param name="holders">Holders stores the list of current holder names in the io.argoproj.workflow.v1alpha1..</param>
        /// <param name="semaphore">Semaphore stores the semaphore name..</param>
        public IoArgoprojWorkflowV1alpha1SemaphoreHolding(List<string> holders = default(List<string>), string semaphore = default(string))
        {
            this.Holders = holders;
            this.Semaphore = semaphore;
        }

        /// <summary>
        /// Holders stores the list of current holder names in the io.argoproj.workflow.v1alpha1.
        /// </summary>
        /// <value>Holders stores the list of current holder names in the io.argoproj.workflow.v1alpha1.</value>
        [DataMember(Name = "holders", EmitDefaultValue = false)]
        public List<string> Holders { get; set; }

        /// <summary>
        /// Semaphore stores the semaphore name.
        /// </summary>
        /// <value>Semaphore stores the semaphore name.</value>
        [DataMember(Name = "semaphore", EmitDefaultValue = false)]
        public string Semaphore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1SemaphoreHolding {\n");
            sb.Append("  Holders: ").Append(Holders).Append("\n");
            sb.Append("  Semaphore: ").Append(Semaphore).Append("\n");
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
