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
    /// EventSeries contain information on series of events, i.e. thing that was/is happening continuously for some time.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.EventSeries")]
    public partial class IoK8sApiCoreV1EventSeries : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1EventSeries" /> class.
        /// </summary>
        /// <param name="count">Number of occurrences in this series up to the last heartbeat time.</param>
        /// <param name="lastObservedTime">MicroTime is version of Time with microsecond level precision..</param>
        public IoK8sApiCoreV1EventSeries(int count = default(int), DateTime? lastObservedTime = default(DateTime?))
        {
            this.Count = count;
            this.LastObservedTime = lastObservedTime;
        }

        /// <summary>
        /// Number of occurrences in this series up to the last heartbeat time
        /// </summary>
        /// <value>Number of occurrences in this series up to the last heartbeat time</value>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// MicroTime is version of Time with microsecond level precision.
        /// </summary>
        /// <value>MicroTime is version of Time with microsecond level precision.</value>
        [DataMember(Name = "lastObservedTime", EmitDefaultValue = false)]
        public DateTime? LastObservedTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1EventSeries {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  LastObservedTime: ").Append(LastObservedTime).Append("\n");
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
