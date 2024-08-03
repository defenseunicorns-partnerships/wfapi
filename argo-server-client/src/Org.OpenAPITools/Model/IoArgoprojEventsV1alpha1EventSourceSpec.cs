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
    /// IoArgoprojEventsV1alpha1EventSourceSpec
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.EventSourceSpec")]
    public partial class IoArgoprojEventsV1alpha1EventSourceSpec : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1EventSourceSpec" /> class.
        /// </summary>
        /// <param name="amqp">amqp.</param>
        /// <param name="azureEventsHub">azureEventsHub.</param>
        /// <param name="azureQueueStorage">azureQueueStorage.</param>
        /// <param name="azureServiceBus">azureServiceBus.</param>
        /// <param name="bitbucket">bitbucket.</param>
        /// <param name="bitbucketserver">bitbucketserver.</param>
        /// <param name="calendar">calendar.</param>
        /// <param name="emitter">emitter.</param>
        /// <param name="eventBusName">eventBusName.</param>
        /// <param name="file">file.</param>
        /// <param name="generic">generic.</param>
        /// <param name="gerrit">gerrit.</param>
        /// <param name="github">github.</param>
        /// <param name="gitlab">gitlab.</param>
        /// <param name="hdfs">hdfs.</param>
        /// <param name="kafka">kafka.</param>
        /// <param name="minio">minio.</param>
        /// <param name="mqtt">mqtt.</param>
        /// <param name="nats">nats.</param>
        /// <param name="nsq">nsq.</param>
        /// <param name="pubSub">pubSub.</param>
        /// <param name="pulsar">pulsar.</param>
        /// <param name="redis">redis.</param>
        /// <param name="redisStream">redisStream.</param>
        /// <param name="replicas">replicas.</param>
        /// <param name="resource">resource.</param>
        /// <param name="service">service.</param>
        /// <param name="sftp">sftp.</param>
        /// <param name="slack">slack.</param>
        /// <param name="sns">sns.</param>
        /// <param name="sqs">sqs.</param>
        /// <param name="storageGrid">storageGrid.</param>
        /// <param name="stripe">stripe.</param>
        /// <param name="template">template.</param>
        /// <param name="webhook">webhook.</param>
        public IoArgoprojEventsV1alpha1EventSourceSpec(Dictionary<string, IoArgoprojEventsV1alpha1AMQPEventSource> amqp = default(Dictionary<string, IoArgoprojEventsV1alpha1AMQPEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1AzureEventsHubEventSource> azureEventsHub = default(Dictionary<string, IoArgoprojEventsV1alpha1AzureEventsHubEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1AzureQueueStorageEventSource> azureQueueStorage = default(Dictionary<string, IoArgoprojEventsV1alpha1AzureQueueStorageEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1AzureServiceBusEventSource> azureServiceBus = default(Dictionary<string, IoArgoprojEventsV1alpha1AzureServiceBusEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1BitbucketEventSource> bitbucket = default(Dictionary<string, IoArgoprojEventsV1alpha1BitbucketEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1BitbucketServerEventSource> bitbucketserver = default(Dictionary<string, IoArgoprojEventsV1alpha1BitbucketServerEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1CalendarEventSource> calendar = default(Dictionary<string, IoArgoprojEventsV1alpha1CalendarEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1EmitterEventSource> emitter = default(Dictionary<string, IoArgoprojEventsV1alpha1EmitterEventSource>), string eventBusName = default(string), Dictionary<string, IoArgoprojEventsV1alpha1FileEventSource> file = default(Dictionary<string, IoArgoprojEventsV1alpha1FileEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1GenericEventSource> generic = default(Dictionary<string, IoArgoprojEventsV1alpha1GenericEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1GerritEventSource> gerrit = default(Dictionary<string, IoArgoprojEventsV1alpha1GerritEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1GithubEventSource> github = default(Dictionary<string, IoArgoprojEventsV1alpha1GithubEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1GitlabEventSource> gitlab = default(Dictionary<string, IoArgoprojEventsV1alpha1GitlabEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1HDFSEventSource> hdfs = default(Dictionary<string, IoArgoprojEventsV1alpha1HDFSEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1KafkaEventSource> kafka = default(Dictionary<string, IoArgoprojEventsV1alpha1KafkaEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1S3Artifact> minio = default(Dictionary<string, IoArgoprojEventsV1alpha1S3Artifact>), Dictionary<string, IoArgoprojEventsV1alpha1MQTTEventSource> mqtt = default(Dictionary<string, IoArgoprojEventsV1alpha1MQTTEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1NATSEventsSource> nats = default(Dictionary<string, IoArgoprojEventsV1alpha1NATSEventsSource>), Dictionary<string, IoArgoprojEventsV1alpha1NSQEventSource> nsq = default(Dictionary<string, IoArgoprojEventsV1alpha1NSQEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1PubSubEventSource> pubSub = default(Dictionary<string, IoArgoprojEventsV1alpha1PubSubEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1PulsarEventSource> pulsar = default(Dictionary<string, IoArgoprojEventsV1alpha1PulsarEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1RedisEventSource> redis = default(Dictionary<string, IoArgoprojEventsV1alpha1RedisEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1RedisStreamEventSource> redisStream = default(Dictionary<string, IoArgoprojEventsV1alpha1RedisStreamEventSource>), int replicas = default(int), Dictionary<string, IoArgoprojEventsV1alpha1ResourceEventSource> resource = default(Dictionary<string, IoArgoprojEventsV1alpha1ResourceEventSource>), IoArgoprojEventsV1alpha1Service service = default(IoArgoprojEventsV1alpha1Service), Dictionary<string, IoArgoprojEventsV1alpha1SFTPEventSource> sftp = default(Dictionary<string, IoArgoprojEventsV1alpha1SFTPEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1SlackEventSource> slack = default(Dictionary<string, IoArgoprojEventsV1alpha1SlackEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1SNSEventSource> sns = default(Dictionary<string, IoArgoprojEventsV1alpha1SNSEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1SQSEventSource> sqs = default(Dictionary<string, IoArgoprojEventsV1alpha1SQSEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1StorageGridEventSource> storageGrid = default(Dictionary<string, IoArgoprojEventsV1alpha1StorageGridEventSource>), Dictionary<string, IoArgoprojEventsV1alpha1StripeEventSource> stripe = default(Dictionary<string, IoArgoprojEventsV1alpha1StripeEventSource>), IoArgoprojEventsV1alpha1Template template = default(IoArgoprojEventsV1alpha1Template), Dictionary<string, IoArgoprojEventsV1alpha1WebhookEventSource> webhook = default(Dictionary<string, IoArgoprojEventsV1alpha1WebhookEventSource>))
        {
            this.Amqp = amqp;
            this.AzureEventsHub = azureEventsHub;
            this.AzureQueueStorage = azureQueueStorage;
            this.AzureServiceBus = azureServiceBus;
            this.Bitbucket = bitbucket;
            this.Bitbucketserver = bitbucketserver;
            this.Calendar = calendar;
            this.Emitter = emitter;
            this.EventBusName = eventBusName;
            this.File = file;
            this.Generic = generic;
            this.Gerrit = gerrit;
            this.Github = github;
            this.Gitlab = gitlab;
            this.Hdfs = hdfs;
            this.Kafka = kafka;
            this.Minio = minio;
            this.Mqtt = mqtt;
            this.Nats = nats;
            this.Nsq = nsq;
            this.PubSub = pubSub;
            this.Pulsar = pulsar;
            this.Redis = redis;
            this.RedisStream = redisStream;
            this.Replicas = replicas;
            this.Resource = resource;
            this.Service = service;
            this.Sftp = sftp;
            this.Slack = slack;
            this.Sns = sns;
            this.Sqs = sqs;
            this.StorageGrid = storageGrid;
            this.Stripe = stripe;
            this.Template = template;
            this.Webhook = webhook;
        }

        /// <summary>
        /// Gets or Sets Amqp
        /// </summary>
        [DataMember(Name = "amqp", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1AMQPEventSource> Amqp { get; set; }

        /// <summary>
        /// Gets or Sets AzureEventsHub
        /// </summary>
        [DataMember(Name = "azureEventsHub", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1AzureEventsHubEventSource> AzureEventsHub { get; set; }

        /// <summary>
        /// Gets or Sets AzureQueueStorage
        /// </summary>
        [DataMember(Name = "azureQueueStorage", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1AzureQueueStorageEventSource> AzureQueueStorage { get; set; }

        /// <summary>
        /// Gets or Sets AzureServiceBus
        /// </summary>
        [DataMember(Name = "azureServiceBus", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1AzureServiceBusEventSource> AzureServiceBus { get; set; }

        /// <summary>
        /// Gets or Sets Bitbucket
        /// </summary>
        [DataMember(Name = "bitbucket", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1BitbucketEventSource> Bitbucket { get; set; }

        /// <summary>
        /// Gets or Sets Bitbucketserver
        /// </summary>
        [DataMember(Name = "bitbucketserver", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1BitbucketServerEventSource> Bitbucketserver { get; set; }

        /// <summary>
        /// Gets or Sets Calendar
        /// </summary>
        [DataMember(Name = "calendar", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1CalendarEventSource> Calendar { get; set; }

        /// <summary>
        /// Gets or Sets Emitter
        /// </summary>
        [DataMember(Name = "emitter", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1EmitterEventSource> Emitter { get; set; }

        /// <summary>
        /// Gets or Sets EventBusName
        /// </summary>
        [DataMember(Name = "eventBusName", EmitDefaultValue = false)]
        public string EventBusName { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1FileEventSource> File { get; set; }

        /// <summary>
        /// Gets or Sets Generic
        /// </summary>
        [DataMember(Name = "generic", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1GenericEventSource> Generic { get; set; }

        /// <summary>
        /// Gets or Sets Gerrit
        /// </summary>
        [DataMember(Name = "gerrit", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1GerritEventSource> Gerrit { get; set; }

        /// <summary>
        /// Gets or Sets Github
        /// </summary>
        [DataMember(Name = "github", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1GithubEventSource> Github { get; set; }

        /// <summary>
        /// Gets or Sets Gitlab
        /// </summary>
        [DataMember(Name = "gitlab", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1GitlabEventSource> Gitlab { get; set; }

        /// <summary>
        /// Gets or Sets Hdfs
        /// </summary>
        [DataMember(Name = "hdfs", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1HDFSEventSource> Hdfs { get; set; }

        /// <summary>
        /// Gets or Sets Kafka
        /// </summary>
        [DataMember(Name = "kafka", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1KafkaEventSource> Kafka { get; set; }

        /// <summary>
        /// Gets or Sets Minio
        /// </summary>
        [DataMember(Name = "minio", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1S3Artifact> Minio { get; set; }

        /// <summary>
        /// Gets or Sets Mqtt
        /// </summary>
        [DataMember(Name = "mqtt", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1MQTTEventSource> Mqtt { get; set; }

        /// <summary>
        /// Gets or Sets Nats
        /// </summary>
        [DataMember(Name = "nats", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1NATSEventsSource> Nats { get; set; }

        /// <summary>
        /// Gets or Sets Nsq
        /// </summary>
        [DataMember(Name = "nsq", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1NSQEventSource> Nsq { get; set; }

        /// <summary>
        /// Gets or Sets PubSub
        /// </summary>
        [DataMember(Name = "pubSub", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1PubSubEventSource> PubSub { get; set; }

        /// <summary>
        /// Gets or Sets Pulsar
        /// </summary>
        [DataMember(Name = "pulsar", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1PulsarEventSource> Pulsar { get; set; }

        /// <summary>
        /// Gets or Sets Redis
        /// </summary>
        [DataMember(Name = "redis", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1RedisEventSource> Redis { get; set; }

        /// <summary>
        /// Gets or Sets RedisStream
        /// </summary>
        [DataMember(Name = "redisStream", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1RedisStreamEventSource> RedisStream { get; set; }

        /// <summary>
        /// Gets or Sets Replicas
        /// </summary>
        [DataMember(Name = "replicas", EmitDefaultValue = false)]
        public int Replicas { get; set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1ResourceEventSource> Resource { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name = "service", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1Service Service { get; set; }

        /// <summary>
        /// Gets or Sets Sftp
        /// </summary>
        [DataMember(Name = "sftp", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1SFTPEventSource> Sftp { get; set; }

        /// <summary>
        /// Gets or Sets Slack
        /// </summary>
        [DataMember(Name = "slack", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1SlackEventSource> Slack { get; set; }

        /// <summary>
        /// Gets or Sets Sns
        /// </summary>
        [DataMember(Name = "sns", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1SNSEventSource> Sns { get; set; }

        /// <summary>
        /// Gets or Sets Sqs
        /// </summary>
        [DataMember(Name = "sqs", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1SQSEventSource> Sqs { get; set; }

        /// <summary>
        /// Gets or Sets StorageGrid
        /// </summary>
        [DataMember(Name = "storageGrid", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1StorageGridEventSource> StorageGrid { get; set; }

        /// <summary>
        /// Gets or Sets Stripe
        /// </summary>
        [DataMember(Name = "stripe", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1StripeEventSource> Stripe { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1Template Template { get; set; }

        /// <summary>
        /// Gets or Sets Webhook
        /// </summary>
        [DataMember(Name = "webhook", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojEventsV1alpha1WebhookEventSource> Webhook { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1EventSourceSpec {\n");
            sb.Append("  Amqp: ").Append(Amqp).Append("\n");
            sb.Append("  AzureEventsHub: ").Append(AzureEventsHub).Append("\n");
            sb.Append("  AzureQueueStorage: ").Append(AzureQueueStorage).Append("\n");
            sb.Append("  AzureServiceBus: ").Append(AzureServiceBus).Append("\n");
            sb.Append("  Bitbucket: ").Append(Bitbucket).Append("\n");
            sb.Append("  Bitbucketserver: ").Append(Bitbucketserver).Append("\n");
            sb.Append("  Calendar: ").Append(Calendar).Append("\n");
            sb.Append("  Emitter: ").Append(Emitter).Append("\n");
            sb.Append("  EventBusName: ").Append(EventBusName).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Generic: ").Append(Generic).Append("\n");
            sb.Append("  Gerrit: ").Append(Gerrit).Append("\n");
            sb.Append("  Github: ").Append(Github).Append("\n");
            sb.Append("  Gitlab: ").Append(Gitlab).Append("\n");
            sb.Append("  Hdfs: ").Append(Hdfs).Append("\n");
            sb.Append("  Kafka: ").Append(Kafka).Append("\n");
            sb.Append("  Minio: ").Append(Minio).Append("\n");
            sb.Append("  Mqtt: ").Append(Mqtt).Append("\n");
            sb.Append("  Nats: ").Append(Nats).Append("\n");
            sb.Append("  Nsq: ").Append(Nsq).Append("\n");
            sb.Append("  PubSub: ").Append(PubSub).Append("\n");
            sb.Append("  Pulsar: ").Append(Pulsar).Append("\n");
            sb.Append("  Redis: ").Append(Redis).Append("\n");
            sb.Append("  RedisStream: ").Append(RedisStream).Append("\n");
            sb.Append("  Replicas: ").Append(Replicas).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Sftp: ").Append(Sftp).Append("\n");
            sb.Append("  Slack: ").Append(Slack).Append("\n");
            sb.Append("  Sns: ").Append(Sns).Append("\n");
            sb.Append("  Sqs: ").Append(Sqs).Append("\n");
            sb.Append("  StorageGrid: ").Append(StorageGrid).Append("\n");
            sb.Append("  Stripe: ").Append(Stripe).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Webhook: ").Append(Webhook).Append("\n");
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
