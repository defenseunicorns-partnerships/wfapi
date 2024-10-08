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
    /// IoArgoprojEventsV1alpha1AWSLambdaTrigger
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.AWSLambdaTrigger")]
    public partial class IoArgoprojEventsV1alpha1AWSLambdaTrigger : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1AWSLambdaTrigger" /> class.
        /// </summary>
        /// <param name="accessKey">accessKey.</param>
        /// <param name="functionName">FunctionName refers to the name of the function to invoke..</param>
        /// <param name="invocationType">Choose from the following options.     * RequestResponse (default) - Invoke the function synchronously. Keep    the connection open until the function returns a response or times out.    The API response includes the function response and additional data.     * Event - Invoke the function asynchronously. Send events that fail multiple    times to the function&#39;s dead-letter queue (if it&#39;s configured). The API    response only includes a status code.     * DryRun - Validate parameter values and verify that the user or role    has permission to invoke the function. +optional.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="payload">Payload is the list of key-value extracted from an event payload to construct the request payload..</param>
        /// <param name="region">region.</param>
        /// <param name="roleARN">roleARN.</param>
        /// <param name="secretKey">secretKey.</param>
        public IoArgoprojEventsV1alpha1AWSLambdaTrigger(IoK8sApiCoreV1SecretKeySelector accessKey = default(IoK8sApiCoreV1SecretKeySelector), string functionName = default(string), string invocationType = default(string), List<IoArgoprojEventsV1alpha1TriggerParameter> parameters = default(List<IoArgoprojEventsV1alpha1TriggerParameter>), List<IoArgoprojEventsV1alpha1TriggerParameter> payload = default(List<IoArgoprojEventsV1alpha1TriggerParameter>), string region = default(string), string roleARN = default(string), IoK8sApiCoreV1SecretKeySelector secretKey = default(IoK8sApiCoreV1SecretKeySelector))
        {
            this.AccessKey = accessKey;
            this.FunctionName = functionName;
            this.InvocationType = invocationType;
            this.Parameters = parameters;
            this.Payload = payload;
            this.Region = region;
            this.RoleARN = roleARN;
            this.SecretKey = secretKey;
        }

        /// <summary>
        /// Gets or Sets AccessKey
        /// </summary>
        [DataMember(Name = "accessKey", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector AccessKey { get; set; }

        /// <summary>
        /// FunctionName refers to the name of the function to invoke.
        /// </summary>
        /// <value>FunctionName refers to the name of the function to invoke.</value>
        [DataMember(Name = "functionName", EmitDefaultValue = false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Choose from the following options.     * RequestResponse (default) - Invoke the function synchronously. Keep    the connection open until the function returns a response or times out.    The API response includes the function response and additional data.     * Event - Invoke the function asynchronously. Send events that fail multiple    times to the function&#39;s dead-letter queue (if it&#39;s configured). The API    response only includes a status code.     * DryRun - Validate parameter values and verify that the user or role    has permission to invoke the function. +optional
        /// </summary>
        /// <value>Choose from the following options.     * RequestResponse (default) - Invoke the function synchronously. Keep    the connection open until the function returns a response or times out.    The API response includes the function response and additional data.     * Event - Invoke the function asynchronously. Send events that fail multiple    times to the function&#39;s dead-letter queue (if it&#39;s configured). The API    response only includes a status code.     * DryRun - Validate parameter values and verify that the user or role    has permission to invoke the function. +optional</value>
        [DataMember(Name = "invocationType", EmitDefaultValue = false)]
        public string InvocationType { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<IoArgoprojEventsV1alpha1TriggerParameter> Parameters { get; set; }

        /// <summary>
        /// Payload is the list of key-value extracted from an event payload to construct the request payload.
        /// </summary>
        /// <value>Payload is the list of key-value extracted from an event payload to construct the request payload.</value>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public List<IoArgoprojEventsV1alpha1TriggerParameter> Payload { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets RoleARN
        /// </summary>
        [DataMember(Name = "roleARN", EmitDefaultValue = false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Gets or Sets SecretKey
        /// </summary>
        [DataMember(Name = "secretKey", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector SecretKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1AWSLambdaTrigger {\n");
            sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  FunctionName: ").Append(FunctionName).Append("\n");
            sb.Append("  InvocationType: ").Append(InvocationType).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  RoleARN: ").Append(RoleARN).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
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
