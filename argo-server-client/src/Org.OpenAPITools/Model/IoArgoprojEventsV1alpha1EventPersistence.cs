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
    /// IoArgoprojEventsV1alpha1EventPersistence
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.EventPersistence")]
    public partial class IoArgoprojEventsV1alpha1EventPersistence : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1EventPersistence" /> class.
        /// </summary>
        /// <param name="catchup">catchup.</param>
        /// <param name="configMap">configMap.</param>
        public IoArgoprojEventsV1alpha1EventPersistence(IoArgoprojEventsV1alpha1CatchupConfiguration catchup = default(IoArgoprojEventsV1alpha1CatchupConfiguration), IoArgoprojEventsV1alpha1ConfigMapPersistence configMap = default(IoArgoprojEventsV1alpha1ConfigMapPersistence))
        {
            this.Catchup = catchup;
            this.ConfigMap = configMap;
        }

        /// <summary>
        /// Gets or Sets Catchup
        /// </summary>
        [DataMember(Name = "catchup", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1CatchupConfiguration Catchup { get; set; }

        /// <summary>
        /// Gets or Sets ConfigMap
        /// </summary>
        [DataMember(Name = "configMap", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1ConfigMapPersistence ConfigMap { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1EventPersistence {\n");
            sb.Append("  Catchup: ").Append(Catchup).Append("\n");
            sb.Append("  ConfigMap: ").Append(ConfigMap).Append("\n");
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
