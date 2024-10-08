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
    /// S3ArtifactRepository defines the controller configuration for an S3 artifact repository
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.S3ArtifactRepository")]
    public partial class IoArgoprojWorkflowV1alpha1S3ArtifactRepository : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1S3ArtifactRepository" /> class.
        /// </summary>
        /// <param name="accessKeySecret">accessKeySecret.</param>
        /// <param name="bucket">Bucket is the name of the bucket.</param>
        /// <param name="caSecret">caSecret.</param>
        /// <param name="createBucketIfNotPresent">createBucketIfNotPresent.</param>
        /// <param name="encryptionOptions">encryptionOptions.</param>
        /// <param name="endpoint">Endpoint is the hostname of the bucket endpoint.</param>
        /// <param name="insecure">Insecure will connect to the service with TLS.</param>
        /// <param name="keyFormat">KeyFormat defines the format of how to store keys and can reference workflow variables..</param>
        /// <param name="keyPrefix">KeyPrefix is prefix used as part of the bucket key in which the controller will store artifacts. DEPRECATED. Use KeyFormat instead.</param>
        /// <param name="region">Region contains the optional bucket region.</param>
        /// <param name="roleARN">RoleARN is the Amazon Resource Name (ARN) of the role to assume..</param>
        /// <param name="secretKeySecret">secretKeySecret.</param>
        /// <param name="useSDKCreds">UseSDKCreds tells the driver to figure out credentials based on sdk defaults..</param>
        public IoArgoprojWorkflowV1alpha1S3ArtifactRepository(IoK8sApiCoreV1SecretKeySelector accessKeySecret = default(IoK8sApiCoreV1SecretKeySelector), string bucket = default(string), IoK8sApiCoreV1SecretKeySelector caSecret = default(IoK8sApiCoreV1SecretKeySelector), IoArgoprojWorkflowV1alpha1CreateS3BucketOptions createBucketIfNotPresent = default(IoArgoprojWorkflowV1alpha1CreateS3BucketOptions), IoArgoprojWorkflowV1alpha1S3EncryptionOptions encryptionOptions = default(IoArgoprojWorkflowV1alpha1S3EncryptionOptions), string endpoint = default(string), bool insecure = default(bool), string keyFormat = default(string), string keyPrefix = default(string), string region = default(string), string roleARN = default(string), IoK8sApiCoreV1SecretKeySelector secretKeySecret = default(IoK8sApiCoreV1SecretKeySelector), bool useSDKCreds = default(bool))
        {
            this.AccessKeySecret = accessKeySecret;
            this.Bucket = bucket;
            this.CaSecret = caSecret;
            this.CreateBucketIfNotPresent = createBucketIfNotPresent;
            this.EncryptionOptions = encryptionOptions;
            this.Endpoint = endpoint;
            this.Insecure = insecure;
            this.KeyFormat = keyFormat;
            this.KeyPrefix = keyPrefix;
            this.Region = region;
            this.RoleARN = roleARN;
            this.SecretKeySecret = secretKeySecret;
            this.UseSDKCreds = useSDKCreds;
        }

        /// <summary>
        /// Gets or Sets AccessKeySecret
        /// </summary>
        [DataMember(Name = "accessKeySecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector AccessKeySecret { get; set; }

        /// <summary>
        /// Bucket is the name of the bucket
        /// </summary>
        /// <value>Bucket is the name of the bucket</value>
        [DataMember(Name = "bucket", EmitDefaultValue = false)]
        public string Bucket { get; set; }

        /// <summary>
        /// Gets or Sets CaSecret
        /// </summary>
        [DataMember(Name = "caSecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector CaSecret { get; set; }

        /// <summary>
        /// Gets or Sets CreateBucketIfNotPresent
        /// </summary>
        [DataMember(Name = "createBucketIfNotPresent", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1CreateS3BucketOptions CreateBucketIfNotPresent { get; set; }

        /// <summary>
        /// Gets or Sets EncryptionOptions
        /// </summary>
        [DataMember(Name = "encryptionOptions", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1S3EncryptionOptions EncryptionOptions { get; set; }

        /// <summary>
        /// Endpoint is the hostname of the bucket endpoint
        /// </summary>
        /// <value>Endpoint is the hostname of the bucket endpoint</value>
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Insecure will connect to the service with TLS
        /// </summary>
        /// <value>Insecure will connect to the service with TLS</value>
        [DataMember(Name = "insecure", EmitDefaultValue = true)]
        public bool Insecure { get; set; }

        /// <summary>
        /// KeyFormat defines the format of how to store keys and can reference workflow variables.
        /// </summary>
        /// <value>KeyFormat defines the format of how to store keys and can reference workflow variables.</value>
        [DataMember(Name = "keyFormat", EmitDefaultValue = false)]
        public string KeyFormat { get; set; }

        /// <summary>
        /// KeyPrefix is prefix used as part of the bucket key in which the controller will store artifacts. DEPRECATED. Use KeyFormat instead
        /// </summary>
        /// <value>KeyPrefix is prefix used as part of the bucket key in which the controller will store artifacts. DEPRECATED. Use KeyFormat instead</value>
        [DataMember(Name = "keyPrefix", EmitDefaultValue = false)]
        public string KeyPrefix { get; set; }

        /// <summary>
        /// Region contains the optional bucket region
        /// </summary>
        /// <value>Region contains the optional bucket region</value>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// RoleARN is the Amazon Resource Name (ARN) of the role to assume.
        /// </summary>
        /// <value>RoleARN is the Amazon Resource Name (ARN) of the role to assume.</value>
        [DataMember(Name = "roleARN", EmitDefaultValue = false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Gets or Sets SecretKeySecret
        /// </summary>
        [DataMember(Name = "secretKeySecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector SecretKeySecret { get; set; }

        /// <summary>
        /// UseSDKCreds tells the driver to figure out credentials based on sdk defaults.
        /// </summary>
        /// <value>UseSDKCreds tells the driver to figure out credentials based on sdk defaults.</value>
        [DataMember(Name = "useSDKCreds", EmitDefaultValue = true)]
        public bool UseSDKCreds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1S3ArtifactRepository {\n");
            sb.Append("  AccessKeySecret: ").Append(AccessKeySecret).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  CaSecret: ").Append(CaSecret).Append("\n");
            sb.Append("  CreateBucketIfNotPresent: ").Append(CreateBucketIfNotPresent).Append("\n");
            sb.Append("  EncryptionOptions: ").Append(EncryptionOptions).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Insecure: ").Append(Insecure).Append("\n");
            sb.Append("  KeyFormat: ").Append(KeyFormat).Append("\n");
            sb.Append("  KeyPrefix: ").Append(KeyPrefix).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  RoleARN: ").Append(RoleARN).Append("\n");
            sb.Append("  SecretKeySecret: ").Append(SecretKeySecret).Append("\n");
            sb.Append("  UseSDKCreds: ").Append(UseSDKCreds).Append("\n");
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
