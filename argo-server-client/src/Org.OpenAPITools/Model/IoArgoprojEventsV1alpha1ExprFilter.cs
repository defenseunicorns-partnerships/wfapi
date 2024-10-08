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
    /// IoArgoprojEventsV1alpha1ExprFilter
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.ExprFilter")]
    public partial class IoArgoprojEventsV1alpha1ExprFilter : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1ExprFilter" /> class.
        /// </summary>
        /// <param name="expr">Expr refers to the expression that determines the outcome of the filter..</param>
        /// <param name="fields">Fields refers to set of keys that refer to the paths within event payload..</param>
        public IoArgoprojEventsV1alpha1ExprFilter(string expr = default(string), List<IoArgoprojEventsV1alpha1PayloadField> fields = default(List<IoArgoprojEventsV1alpha1PayloadField>))
        {
            this.Expr = expr;
            this.Fields = fields;
        }

        /// <summary>
        /// Expr refers to the expression that determines the outcome of the filter.
        /// </summary>
        /// <value>Expr refers to the expression that determines the outcome of the filter.</value>
        [DataMember(Name = "expr", EmitDefaultValue = false)]
        public string Expr { get; set; }

        /// <summary>
        /// Fields refers to set of keys that refer to the paths within event payload.
        /// </summary>
        /// <value>Fields refers to set of keys that refer to the paths within event payload.</value>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<IoArgoprojEventsV1alpha1PayloadField> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1ExprFilter {\n");
            sb.Append("  Expr: ").Append(Expr).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
