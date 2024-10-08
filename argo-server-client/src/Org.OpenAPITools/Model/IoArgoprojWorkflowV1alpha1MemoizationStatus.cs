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
    /// MemoizationStatus is the status of this memoized node
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.MemoizationStatus")]
    public partial class IoArgoprojWorkflowV1alpha1MemoizationStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1MemoizationStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoArgoprojWorkflowV1alpha1MemoizationStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1MemoizationStatus" /> class.
        /// </summary>
        /// <param name="cacheName">Cache is the name of the cache that was used (required).</param>
        /// <param name="hit">Hit indicates whether this node was created from a cache entry (required).</param>
        /// <param name="key">Key is the name of the key used for this node&#39;s cache (required).</param>
        public IoArgoprojWorkflowV1alpha1MemoizationStatus(string cacheName = default(string), bool hit = default(bool), string key = default(string))
        {
            // to ensure "cacheName" is required (not null)
            if (cacheName == null)
            {
                throw new ArgumentNullException("cacheName is a required property for IoArgoprojWorkflowV1alpha1MemoizationStatus and cannot be null");
            }
            this.CacheName = cacheName;
            this.Hit = hit;
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for IoArgoprojWorkflowV1alpha1MemoizationStatus and cannot be null");
            }
            this.Key = key;
        }

        /// <summary>
        /// Cache is the name of the cache that was used
        /// </summary>
        /// <value>Cache is the name of the cache that was used</value>
        [DataMember(Name = "cacheName", IsRequired = true, EmitDefaultValue = true)]
        public string CacheName { get; set; }

        /// <summary>
        /// Hit indicates whether this node was created from a cache entry
        /// </summary>
        /// <value>Hit indicates whether this node was created from a cache entry</value>
        [DataMember(Name = "hit", IsRequired = true, EmitDefaultValue = true)]
        public bool Hit { get; set; }

        /// <summary>
        /// Key is the name of the key used for this node&#39;s cache
        /// </summary>
        /// <value>Key is the name of the key used for this node&#39;s cache</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1MemoizationStatus {\n");
            sb.Append("  CacheName: ").Append(CacheName).Append("\n");
            sb.Append("  Hit: ").Append(Hit).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
