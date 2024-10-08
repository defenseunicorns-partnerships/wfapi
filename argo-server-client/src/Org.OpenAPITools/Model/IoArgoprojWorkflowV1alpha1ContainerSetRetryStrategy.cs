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
    /// ContainerSetRetryStrategy provides controls on how to retry a container set
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.ContainerSetRetryStrategy")]
    public partial class IoArgoprojWorkflowV1alpha1ContainerSetRetryStrategy : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1ContainerSetRetryStrategy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoArgoprojWorkflowV1alpha1ContainerSetRetryStrategy() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1ContainerSetRetryStrategy" /> class.
        /// </summary>
        /// <param name="duration">Duration is the time between each retry, examples values are \&quot;300ms\&quot;, \&quot;1s\&quot; or \&quot;5m\&quot;. Valid time units are \&quot;ns\&quot;, \&quot;us\&quot; (or \&quot;µs\&quot;), \&quot;ms\&quot;, \&quot;s\&quot;, \&quot;m\&quot;, \&quot;h\&quot;..</param>
        /// <param name="retries">retries (required).</param>
        public IoArgoprojWorkflowV1alpha1ContainerSetRetryStrategy(string duration = default(string), string retries = default(string))
        {
            // to ensure "retries" is required (not null)
            if (retries == null)
            {
                throw new ArgumentNullException("retries is a required property for IoArgoprojWorkflowV1alpha1ContainerSetRetryStrategy and cannot be null");
            }
            this.Retries = retries;
            this.Duration = duration;
        }

        /// <summary>
        /// Duration is the time between each retry, examples values are \&quot;300ms\&quot;, \&quot;1s\&quot; or \&quot;5m\&quot;. Valid time units are \&quot;ns\&quot;, \&quot;us\&quot; (or \&quot;µs\&quot;), \&quot;ms\&quot;, \&quot;s\&quot;, \&quot;m\&quot;, \&quot;h\&quot;.
        /// </summary>
        /// <value>Duration is the time between each retry, examples values are \&quot;300ms\&quot;, \&quot;1s\&quot; or \&quot;5m\&quot;. Valid time units are \&quot;ns\&quot;, \&quot;us\&quot; (or \&quot;µs\&quot;), \&quot;ms\&quot;, \&quot;s\&quot;, \&quot;m\&quot;, \&quot;h\&quot;.</value>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or Sets Retries
        /// </summary>
        [DataMember(Name = "retries", IsRequired = true, EmitDefaultValue = true)]
        public string Retries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1ContainerSetRetryStrategy {\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
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
