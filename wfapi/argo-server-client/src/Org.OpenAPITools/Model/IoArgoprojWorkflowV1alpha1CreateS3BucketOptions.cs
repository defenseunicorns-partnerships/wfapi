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
    /// CreateS3BucketOptions options used to determine automatic automatic bucket-creation process
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.CreateS3BucketOptions")]
    public partial class IoArgoprojWorkflowV1alpha1CreateS3BucketOptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1CreateS3BucketOptions" /> class.
        /// </summary>
        /// <param name="objectLocking">ObjectLocking Enable object locking.</param>
        public IoArgoprojWorkflowV1alpha1CreateS3BucketOptions(bool objectLocking = default(bool))
        {
            this.ObjectLocking = objectLocking;
        }

        /// <summary>
        /// ObjectLocking Enable object locking
        /// </summary>
        /// <value>ObjectLocking Enable object locking</value>
        [DataMember(Name = "objectLocking", EmitDefaultValue = true)]
        public bool ObjectLocking { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1CreateS3BucketOptions {\n");
            sb.Append("  ObjectLocking: ").Append(ObjectLocking).Append("\n");
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
