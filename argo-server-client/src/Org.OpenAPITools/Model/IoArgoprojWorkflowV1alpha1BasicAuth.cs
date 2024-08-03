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
    /// BasicAuth describes the secret selectors required for basic authentication
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.BasicAuth")]
    public partial class IoArgoprojWorkflowV1alpha1BasicAuth : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1BasicAuth" /> class.
        /// </summary>
        /// <param name="passwordSecret">passwordSecret.</param>
        /// <param name="usernameSecret">usernameSecret.</param>
        public IoArgoprojWorkflowV1alpha1BasicAuth(IoK8sApiCoreV1SecretKeySelector passwordSecret = default(IoK8sApiCoreV1SecretKeySelector), IoK8sApiCoreV1SecretKeySelector usernameSecret = default(IoK8sApiCoreV1SecretKeySelector))
        {
            this.PasswordSecret = passwordSecret;
            this.UsernameSecret = usernameSecret;
        }

        /// <summary>
        /// Gets or Sets PasswordSecret
        /// </summary>
        [DataMember(Name = "passwordSecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector PasswordSecret { get; set; }

        /// <summary>
        /// Gets or Sets UsernameSecret
        /// </summary>
        [DataMember(Name = "usernameSecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector UsernameSecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1BasicAuth {\n");
            sb.Append("  PasswordSecret: ").Append(PasswordSecret).Append("\n");
            sb.Append("  UsernameSecret: ").Append(UsernameSecret).Append("\n");
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
