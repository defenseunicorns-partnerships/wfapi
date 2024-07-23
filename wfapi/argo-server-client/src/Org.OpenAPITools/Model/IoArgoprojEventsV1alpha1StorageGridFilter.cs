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
    /// IoArgoprojEventsV1alpha1StorageGridFilter
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.StorageGridFilter")]
    public partial class IoArgoprojEventsV1alpha1StorageGridFilter : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1StorageGridFilter" /> class.
        /// </summary>
        /// <param name="prefix">prefix.</param>
        /// <param name="suffix">suffix.</param>
        public IoArgoprojEventsV1alpha1StorageGridFilter(string prefix = default(string), string suffix = default(string))
        {
            this.Prefix = prefix;
            this.Suffix = suffix;
        }

        /// <summary>
        /// Gets or Sets Prefix
        /// </summary>
        [DataMember(Name = "prefix", EmitDefaultValue = false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or Sets Suffix
        /// </summary>
        [DataMember(Name = "suffix", EmitDefaultValue = false)]
        public string Suffix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1StorageGridFilter {\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
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
