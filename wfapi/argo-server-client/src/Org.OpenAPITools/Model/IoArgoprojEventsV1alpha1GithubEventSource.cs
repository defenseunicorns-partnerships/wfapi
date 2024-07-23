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
    /// IoArgoprojEventsV1alpha1GithubEventSource
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.GithubEventSource")]
    public partial class IoArgoprojEventsV1alpha1GithubEventSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1GithubEventSource" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="apiToken">apiToken.</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="deleteHookOnFinish">deleteHookOnFinish.</param>
        /// <param name="events">events.</param>
        /// <param name="filter">filter.</param>
        /// <param name="githubApp">githubApp.</param>
        /// <param name="githubBaseURL">githubBaseURL.</param>
        /// <param name="githubUploadURL">githubUploadURL.</param>
        /// <param name="id">id.</param>
        /// <param name="insecure">insecure.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="organizations">Organizations holds the names of organizations (used for organization level webhooks). Not required if Repositories is set..</param>
        /// <param name="owner">owner.</param>
        /// <param name="repositories">Repositories holds the information of repositories, which uses repo owner as the key, and list of repo names as the value. Not required if Organizations is set..</param>
        /// <param name="repository">repository.</param>
        /// <param name="webhook">webhook.</param>
        /// <param name="webhookSecret">webhookSecret.</param>
        public IoArgoprojEventsV1alpha1GithubEventSource(bool active = default(bool), IoK8sApiCoreV1SecretKeySelector apiToken = default(IoK8sApiCoreV1SecretKeySelector), string contentType = default(string), bool deleteHookOnFinish = default(bool), List<string> events = default(List<string>), IoArgoprojEventsV1alpha1EventSourceFilter filter = default(IoArgoprojEventsV1alpha1EventSourceFilter), IoArgoprojEventsV1alpha1GithubAppCreds githubApp = default(IoArgoprojEventsV1alpha1GithubAppCreds), string githubBaseURL = default(string), string githubUploadURL = default(string), string id = default(string), bool insecure = default(bool), Dictionary<string, string> metadata = default(Dictionary<string, string>), List<string> organizations = default(List<string>), string owner = default(string), List<IoArgoprojEventsV1alpha1OwnedRepositories> repositories = default(List<IoArgoprojEventsV1alpha1OwnedRepositories>), string repository = default(string), IoArgoprojEventsV1alpha1WebhookContext webhook = default(IoArgoprojEventsV1alpha1WebhookContext), IoK8sApiCoreV1SecretKeySelector webhookSecret = default(IoK8sApiCoreV1SecretKeySelector))
        {
            this.Active = active;
            this.ApiToken = apiToken;
            this.ContentType = contentType;
            this.DeleteHookOnFinish = deleteHookOnFinish;
            this.Events = events;
            this.Filter = filter;
            this.GithubApp = githubApp;
            this.GithubBaseURL = githubBaseURL;
            this.GithubUploadURL = githubUploadURL;
            this.Id = id;
            this.Insecure = insecure;
            this.Metadata = metadata;
            this.Organizations = organizations;
            this.Owner = owner;
            this.Repositories = repositories;
            this.Repository = repository;
            this.Webhook = webhook;
            this.WebhookSecret = webhookSecret;
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets ApiToken
        /// </summary>
        [DataMember(Name = "apiToken", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector ApiToken { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name = "contentType", EmitDefaultValue = false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or Sets DeleteHookOnFinish
        /// </summary>
        [DataMember(Name = "deleteHookOnFinish", EmitDefaultValue = true)]
        public bool DeleteHookOnFinish { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1EventSourceFilter Filter { get; set; }

        /// <summary>
        /// Gets or Sets GithubApp
        /// </summary>
        [DataMember(Name = "githubApp", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1GithubAppCreds GithubApp { get; set; }

        /// <summary>
        /// Gets or Sets GithubBaseURL
        /// </summary>
        [DataMember(Name = "githubBaseURL", EmitDefaultValue = false)]
        public string GithubBaseURL { get; set; }

        /// <summary>
        /// Gets or Sets GithubUploadURL
        /// </summary>
        [DataMember(Name = "githubUploadURL", EmitDefaultValue = false)]
        public string GithubUploadURL { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Insecure
        /// </summary>
        [DataMember(Name = "insecure", EmitDefaultValue = true)]
        public bool Insecure { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Organizations holds the names of organizations (used for organization level webhooks). Not required if Repositories is set.
        /// </summary>
        /// <value>Organizations holds the names of organizations (used for organization level webhooks). Not required if Repositories is set.</value>
        [DataMember(Name = "organizations", EmitDefaultValue = false)]
        public List<string> Organizations { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public string Owner { get; set; }

        /// <summary>
        /// Repositories holds the information of repositories, which uses repo owner as the key, and list of repo names as the value. Not required if Organizations is set.
        /// </summary>
        /// <value>Repositories holds the information of repositories, which uses repo owner as the key, and list of repo names as the value. Not required if Organizations is set.</value>
        [DataMember(Name = "repositories", EmitDefaultValue = false)]
        public List<IoArgoprojEventsV1alpha1OwnedRepositories> Repositories { get; set; }

        /// <summary>
        /// Gets or Sets Repository
        /// </summary>
        [DataMember(Name = "repository", EmitDefaultValue = false)]
        public string Repository { get; set; }

        /// <summary>
        /// Gets or Sets Webhook
        /// </summary>
        [DataMember(Name = "webhook", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1WebhookContext Webhook { get; set; }

        /// <summary>
        /// Gets or Sets WebhookSecret
        /// </summary>
        [DataMember(Name = "webhookSecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector WebhookSecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1GithubEventSource {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ApiToken: ").Append(ApiToken).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  DeleteHookOnFinish: ").Append(DeleteHookOnFinish).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  GithubApp: ").Append(GithubApp).Append("\n");
            sb.Append("  GithubBaseURL: ").Append(GithubBaseURL).Append("\n");
            sb.Append("  GithubUploadURL: ").Append(GithubUploadURL).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Insecure: ").Append(Insecure).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Organizations: ").Append(Organizations).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Repositories: ").Append(Repositories).Append("\n");
            sb.Append("  Repository: ").Append(Repository).Append("\n");
            sb.Append("  Webhook: ").Append(Webhook).Append("\n");
            sb.Append("  WebhookSecret: ").Append(WebhookSecret).Append("\n");
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
