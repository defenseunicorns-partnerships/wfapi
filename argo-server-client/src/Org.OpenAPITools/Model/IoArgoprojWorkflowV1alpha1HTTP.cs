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
    /// IoArgoprojWorkflowV1alpha1HTTP
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.HTTP")]
    public partial class IoArgoprojWorkflowV1alpha1HTTP : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1HTTP" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoArgoprojWorkflowV1alpha1HTTP() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1HTTP" /> class.
        /// </summary>
        /// <param name="body">Body is content of the HTTP Request.</param>
        /// <param name="bodyFrom">bodyFrom.</param>
        /// <param name="headers">Headers are an optional list of headers to send with HTTP requests.</param>
        /// <param name="insecureSkipVerify">InsecureSkipVerify is a bool when if set to true will skip TLS verification for the HTTP client.</param>
        /// <param name="method">Method is HTTP methods for HTTP Request.</param>
        /// <param name="successCondition">SuccessCondition is an expression if evaluated to true is considered successful.</param>
        /// <param name="timeoutSeconds">TimeoutSeconds is request timeout for HTTP Request. Default is 30 seconds.</param>
        /// <param name="url">URL of the HTTP Request (required).</param>
        public IoArgoprojWorkflowV1alpha1HTTP(string body = default(string), IoArgoprojWorkflowV1alpha1HTTPBodySource bodyFrom = default(IoArgoprojWorkflowV1alpha1HTTPBodySource), List<IoArgoprojWorkflowV1alpha1HTTPHeader> headers = default(List<IoArgoprojWorkflowV1alpha1HTTPHeader>), bool insecureSkipVerify = default(bool), string method = default(string), string successCondition = default(string), int timeoutSeconds = default(int), string url = default(string))
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for IoArgoprojWorkflowV1alpha1HTTP and cannot be null");
            }
            this.Url = url;
            this.Body = body;
            this.BodyFrom = bodyFrom;
            this.Headers = headers;
            this.InsecureSkipVerify = insecureSkipVerify;
            this.Method = method;
            this.SuccessCondition = successCondition;
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Body is content of the HTTP Request
        /// </summary>
        /// <value>Body is content of the HTTP Request</value>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets BodyFrom
        /// </summary>
        [DataMember(Name = "bodyFrom", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1HTTPBodySource BodyFrom { get; set; }

        /// <summary>
        /// Headers are an optional list of headers to send with HTTP requests
        /// </summary>
        /// <value>Headers are an optional list of headers to send with HTTP requests</value>
        [DataMember(Name = "headers", EmitDefaultValue = false)]
        public List<IoArgoprojWorkflowV1alpha1HTTPHeader> Headers { get; set; }

        /// <summary>
        /// InsecureSkipVerify is a bool when if set to true will skip TLS verification for the HTTP client
        /// </summary>
        /// <value>InsecureSkipVerify is a bool when if set to true will skip TLS verification for the HTTP client</value>
        [DataMember(Name = "insecureSkipVerify", EmitDefaultValue = true)]
        public bool InsecureSkipVerify { get; set; }

        /// <summary>
        /// Method is HTTP methods for HTTP Request
        /// </summary>
        /// <value>Method is HTTP methods for HTTP Request</value>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// SuccessCondition is an expression if evaluated to true is considered successful
        /// </summary>
        /// <value>SuccessCondition is an expression if evaluated to true is considered successful</value>
        [DataMember(Name = "successCondition", EmitDefaultValue = false)]
        public string SuccessCondition { get; set; }

        /// <summary>
        /// TimeoutSeconds is request timeout for HTTP Request. Default is 30 seconds
        /// </summary>
        /// <value>TimeoutSeconds is request timeout for HTTP Request. Default is 30 seconds</value>
        [DataMember(Name = "timeoutSeconds", EmitDefaultValue = false)]
        public int TimeoutSeconds { get; set; }

        /// <summary>
        /// URL of the HTTP Request
        /// </summary>
        /// <value>URL of the HTTP Request</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1HTTP {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  BodyFrom: ").Append(BodyFrom).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  InsecureSkipVerify: ").Append(InsecureSkipVerify).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  SuccessCondition: ").Append(SuccessCondition).Append("\n");
            sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
