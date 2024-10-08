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
    /// Volume represents a named volume in a pod that may be accessed by any container in the pod.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.Volume")]
    public partial class IoK8sApiCoreV1Volume : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1Volume" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1Volume() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1Volume" /> class.
        /// </summary>
        /// <param name="awsElasticBlockStore">awsElasticBlockStore.</param>
        /// <param name="azureDisk">azureDisk.</param>
        /// <param name="azureFile">azureFile.</param>
        /// <param name="cephfs">cephfs.</param>
        /// <param name="cinder">cinder.</param>
        /// <param name="configMap">configMap.</param>
        /// <param name="csi">csi.</param>
        /// <param name="downwardAPI">downwardAPI.</param>
        /// <param name="emptyDir">emptyDir.</param>
        /// <param name="ephemeral">ephemeral.</param>
        /// <param name="fc">fc.</param>
        /// <param name="flexVolume">flexVolume.</param>
        /// <param name="flocker">flocker.</param>
        /// <param name="gcePersistentDisk">gcePersistentDisk.</param>
        /// <param name="gitRepo">gitRepo.</param>
        /// <param name="glusterfs">glusterfs.</param>
        /// <param name="hostPath">hostPath.</param>
        /// <param name="iscsi">iscsi.</param>
        /// <param name="name">Volume&#39;s name. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names (required).</param>
        /// <param name="nfs">nfs.</param>
        /// <param name="persistentVolumeClaim">persistentVolumeClaim.</param>
        /// <param name="photonPersistentDisk">photonPersistentDisk.</param>
        /// <param name="portworxVolume">portworxVolume.</param>
        /// <param name="projected">projected.</param>
        /// <param name="quobyte">quobyte.</param>
        /// <param name="rbd">rbd.</param>
        /// <param name="scaleIO">scaleIO.</param>
        /// <param name="secret">secret.</param>
        /// <param name="storageos">storageos.</param>
        /// <param name="vsphereVolume">vsphereVolume.</param>
        public IoK8sApiCoreV1Volume(IoK8sApiCoreV1AWSElasticBlockStoreVolumeSource awsElasticBlockStore = default(IoK8sApiCoreV1AWSElasticBlockStoreVolumeSource), IoK8sApiCoreV1AzureDiskVolumeSource azureDisk = default(IoK8sApiCoreV1AzureDiskVolumeSource), IoK8sApiCoreV1AzureFileVolumeSource azureFile = default(IoK8sApiCoreV1AzureFileVolumeSource), IoK8sApiCoreV1CephFSVolumeSource cephfs = default(IoK8sApiCoreV1CephFSVolumeSource), IoK8sApiCoreV1CinderVolumeSource cinder = default(IoK8sApiCoreV1CinderVolumeSource), IoK8sApiCoreV1ConfigMapVolumeSource configMap = default(IoK8sApiCoreV1ConfigMapVolumeSource), IoK8sApiCoreV1CSIVolumeSource csi = default(IoK8sApiCoreV1CSIVolumeSource), IoK8sApiCoreV1DownwardAPIVolumeSource downwardAPI = default(IoK8sApiCoreV1DownwardAPIVolumeSource), IoK8sApiCoreV1EmptyDirVolumeSource emptyDir = default(IoK8sApiCoreV1EmptyDirVolumeSource), IoK8sApiCoreV1EphemeralVolumeSource ephemeral = default(IoK8sApiCoreV1EphemeralVolumeSource), IoK8sApiCoreV1FCVolumeSource fc = default(IoK8sApiCoreV1FCVolumeSource), IoK8sApiCoreV1FlexVolumeSource flexVolume = default(IoK8sApiCoreV1FlexVolumeSource), IoK8sApiCoreV1FlockerVolumeSource flocker = default(IoK8sApiCoreV1FlockerVolumeSource), IoK8sApiCoreV1GCEPersistentDiskVolumeSource gcePersistentDisk = default(IoK8sApiCoreV1GCEPersistentDiskVolumeSource), IoK8sApiCoreV1GitRepoVolumeSource gitRepo = default(IoK8sApiCoreV1GitRepoVolumeSource), IoK8sApiCoreV1GlusterfsVolumeSource glusterfs = default(IoK8sApiCoreV1GlusterfsVolumeSource), IoK8sApiCoreV1HostPathVolumeSource hostPath = default(IoK8sApiCoreV1HostPathVolumeSource), IoK8sApiCoreV1ISCSIVolumeSource iscsi = default(IoK8sApiCoreV1ISCSIVolumeSource), string name = default(string), IoK8sApiCoreV1NFSVolumeSource nfs = default(IoK8sApiCoreV1NFSVolumeSource), IoK8sApiCoreV1PersistentVolumeClaimVolumeSource persistentVolumeClaim = default(IoK8sApiCoreV1PersistentVolumeClaimVolumeSource), IoK8sApiCoreV1PhotonPersistentDiskVolumeSource photonPersistentDisk = default(IoK8sApiCoreV1PhotonPersistentDiskVolumeSource), IoK8sApiCoreV1PortworxVolumeSource portworxVolume = default(IoK8sApiCoreV1PortworxVolumeSource), IoK8sApiCoreV1ProjectedVolumeSource projected = default(IoK8sApiCoreV1ProjectedVolumeSource), IoK8sApiCoreV1QuobyteVolumeSource quobyte = default(IoK8sApiCoreV1QuobyteVolumeSource), IoK8sApiCoreV1RBDVolumeSource rbd = default(IoK8sApiCoreV1RBDVolumeSource), IoK8sApiCoreV1ScaleIOVolumeSource scaleIO = default(IoK8sApiCoreV1ScaleIOVolumeSource), IoK8sApiCoreV1SecretVolumeSource secret = default(IoK8sApiCoreV1SecretVolumeSource), IoK8sApiCoreV1StorageOSVolumeSource storageos = default(IoK8sApiCoreV1StorageOSVolumeSource), IoK8sApiCoreV1VsphereVirtualDiskVolumeSource vsphereVolume = default(IoK8sApiCoreV1VsphereVirtualDiskVolumeSource))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for IoK8sApiCoreV1Volume and cannot be null");
            }
            this.Name = name;
            this.AwsElasticBlockStore = awsElasticBlockStore;
            this.AzureDisk = azureDisk;
            this.AzureFile = azureFile;
            this.Cephfs = cephfs;
            this.Cinder = cinder;
            this.ConfigMap = configMap;
            this.Csi = csi;
            this.DownwardAPI = downwardAPI;
            this.EmptyDir = emptyDir;
            this.Ephemeral = ephemeral;
            this.Fc = fc;
            this.FlexVolume = flexVolume;
            this.Flocker = flocker;
            this.GcePersistentDisk = gcePersistentDisk;
            this.GitRepo = gitRepo;
            this.Glusterfs = glusterfs;
            this.HostPath = hostPath;
            this.Iscsi = iscsi;
            this.Nfs = nfs;
            this.PersistentVolumeClaim = persistentVolumeClaim;
            this.PhotonPersistentDisk = photonPersistentDisk;
            this.PortworxVolume = portworxVolume;
            this.Projected = projected;
            this.Quobyte = quobyte;
            this.Rbd = rbd;
            this.ScaleIO = scaleIO;
            this.Secret = secret;
            this.Storageos = storageos;
            this.VsphereVolume = vsphereVolume;
        }

        /// <summary>
        /// Gets or Sets AwsElasticBlockStore
        /// </summary>
        [DataMember(Name = "awsElasticBlockStore", EmitDefaultValue = false)]
        public IoK8sApiCoreV1AWSElasticBlockStoreVolumeSource AwsElasticBlockStore { get; set; }

        /// <summary>
        /// Gets or Sets AzureDisk
        /// </summary>
        [DataMember(Name = "azureDisk", EmitDefaultValue = false)]
        public IoK8sApiCoreV1AzureDiskVolumeSource AzureDisk { get; set; }

        /// <summary>
        /// Gets or Sets AzureFile
        /// </summary>
        [DataMember(Name = "azureFile", EmitDefaultValue = false)]
        public IoK8sApiCoreV1AzureFileVolumeSource AzureFile { get; set; }

        /// <summary>
        /// Gets or Sets Cephfs
        /// </summary>
        [DataMember(Name = "cephfs", EmitDefaultValue = false)]
        public IoK8sApiCoreV1CephFSVolumeSource Cephfs { get; set; }

        /// <summary>
        /// Gets or Sets Cinder
        /// </summary>
        [DataMember(Name = "cinder", EmitDefaultValue = false)]
        public IoK8sApiCoreV1CinderVolumeSource Cinder { get; set; }

        /// <summary>
        /// Gets or Sets ConfigMap
        /// </summary>
        [DataMember(Name = "configMap", EmitDefaultValue = false)]
        public IoK8sApiCoreV1ConfigMapVolumeSource ConfigMap { get; set; }

        /// <summary>
        /// Gets or Sets Csi
        /// </summary>
        [DataMember(Name = "csi", EmitDefaultValue = false)]
        public IoK8sApiCoreV1CSIVolumeSource Csi { get; set; }

        /// <summary>
        /// Gets or Sets DownwardAPI
        /// </summary>
        [DataMember(Name = "downwardAPI", EmitDefaultValue = false)]
        public IoK8sApiCoreV1DownwardAPIVolumeSource DownwardAPI { get; set; }

        /// <summary>
        /// Gets or Sets EmptyDir
        /// </summary>
        [DataMember(Name = "emptyDir", EmitDefaultValue = false)]
        public IoK8sApiCoreV1EmptyDirVolumeSource EmptyDir { get; set; }

        /// <summary>
        /// Gets or Sets Ephemeral
        /// </summary>
        [DataMember(Name = "ephemeral", EmitDefaultValue = false)]
        public IoK8sApiCoreV1EphemeralVolumeSource Ephemeral { get; set; }

        /// <summary>
        /// Gets or Sets Fc
        /// </summary>
        [DataMember(Name = "fc", EmitDefaultValue = false)]
        public IoK8sApiCoreV1FCVolumeSource Fc { get; set; }

        /// <summary>
        /// Gets or Sets FlexVolume
        /// </summary>
        [DataMember(Name = "flexVolume", EmitDefaultValue = false)]
        public IoK8sApiCoreV1FlexVolumeSource FlexVolume { get; set; }

        /// <summary>
        /// Gets or Sets Flocker
        /// </summary>
        [DataMember(Name = "flocker", EmitDefaultValue = false)]
        public IoK8sApiCoreV1FlockerVolumeSource Flocker { get; set; }

        /// <summary>
        /// Gets or Sets GcePersistentDisk
        /// </summary>
        [DataMember(Name = "gcePersistentDisk", EmitDefaultValue = false)]
        public IoK8sApiCoreV1GCEPersistentDiskVolumeSource GcePersistentDisk { get; set; }

        /// <summary>
        /// Gets or Sets GitRepo
        /// </summary>
        [DataMember(Name = "gitRepo", EmitDefaultValue = false)]
        public IoK8sApiCoreV1GitRepoVolumeSource GitRepo { get; set; }

        /// <summary>
        /// Gets or Sets Glusterfs
        /// </summary>
        [DataMember(Name = "glusterfs", EmitDefaultValue = false)]
        public IoK8sApiCoreV1GlusterfsVolumeSource Glusterfs { get; set; }

        /// <summary>
        /// Gets or Sets HostPath
        /// </summary>
        [DataMember(Name = "hostPath", EmitDefaultValue = false)]
        public IoK8sApiCoreV1HostPathVolumeSource HostPath { get; set; }

        /// <summary>
        /// Gets or Sets Iscsi
        /// </summary>
        [DataMember(Name = "iscsi", EmitDefaultValue = false)]
        public IoK8sApiCoreV1ISCSIVolumeSource Iscsi { get; set; }

        /// <summary>
        /// Volume&#39;s name. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        /// <value>Volume&#39;s name. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Nfs
        /// </summary>
        [DataMember(Name = "nfs", EmitDefaultValue = false)]
        public IoK8sApiCoreV1NFSVolumeSource Nfs { get; set; }

        /// <summary>
        /// Gets or Sets PersistentVolumeClaim
        /// </summary>
        [DataMember(Name = "persistentVolumeClaim", EmitDefaultValue = false)]
        public IoK8sApiCoreV1PersistentVolumeClaimVolumeSource PersistentVolumeClaim { get; set; }

        /// <summary>
        /// Gets or Sets PhotonPersistentDisk
        /// </summary>
        [DataMember(Name = "photonPersistentDisk", EmitDefaultValue = false)]
        public IoK8sApiCoreV1PhotonPersistentDiskVolumeSource PhotonPersistentDisk { get; set; }

        /// <summary>
        /// Gets or Sets PortworxVolume
        /// </summary>
        [DataMember(Name = "portworxVolume", EmitDefaultValue = false)]
        public IoK8sApiCoreV1PortworxVolumeSource PortworxVolume { get; set; }

        /// <summary>
        /// Gets or Sets Projected
        /// </summary>
        [DataMember(Name = "projected", EmitDefaultValue = false)]
        public IoK8sApiCoreV1ProjectedVolumeSource Projected { get; set; }

        /// <summary>
        /// Gets or Sets Quobyte
        /// </summary>
        [DataMember(Name = "quobyte", EmitDefaultValue = false)]
        public IoK8sApiCoreV1QuobyteVolumeSource Quobyte { get; set; }

        /// <summary>
        /// Gets or Sets Rbd
        /// </summary>
        [DataMember(Name = "rbd", EmitDefaultValue = false)]
        public IoK8sApiCoreV1RBDVolumeSource Rbd { get; set; }

        /// <summary>
        /// Gets or Sets ScaleIO
        /// </summary>
        [DataMember(Name = "scaleIO", EmitDefaultValue = false)]
        public IoK8sApiCoreV1ScaleIOVolumeSource ScaleIO { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name = "secret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretVolumeSource Secret { get; set; }

        /// <summary>
        /// Gets or Sets Storageos
        /// </summary>
        [DataMember(Name = "storageos", EmitDefaultValue = false)]
        public IoK8sApiCoreV1StorageOSVolumeSource Storageos { get; set; }

        /// <summary>
        /// Gets or Sets VsphereVolume
        /// </summary>
        [DataMember(Name = "vsphereVolume", EmitDefaultValue = false)]
        public IoK8sApiCoreV1VsphereVirtualDiskVolumeSource VsphereVolume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1Volume {\n");
            sb.Append("  AwsElasticBlockStore: ").Append(AwsElasticBlockStore).Append("\n");
            sb.Append("  AzureDisk: ").Append(AzureDisk).Append("\n");
            sb.Append("  AzureFile: ").Append(AzureFile).Append("\n");
            sb.Append("  Cephfs: ").Append(Cephfs).Append("\n");
            sb.Append("  Cinder: ").Append(Cinder).Append("\n");
            sb.Append("  ConfigMap: ").Append(ConfigMap).Append("\n");
            sb.Append("  Csi: ").Append(Csi).Append("\n");
            sb.Append("  DownwardAPI: ").Append(DownwardAPI).Append("\n");
            sb.Append("  EmptyDir: ").Append(EmptyDir).Append("\n");
            sb.Append("  Ephemeral: ").Append(Ephemeral).Append("\n");
            sb.Append("  Fc: ").Append(Fc).Append("\n");
            sb.Append("  FlexVolume: ").Append(FlexVolume).Append("\n");
            sb.Append("  Flocker: ").Append(Flocker).Append("\n");
            sb.Append("  GcePersistentDisk: ").Append(GcePersistentDisk).Append("\n");
            sb.Append("  GitRepo: ").Append(GitRepo).Append("\n");
            sb.Append("  Glusterfs: ").Append(Glusterfs).Append("\n");
            sb.Append("  HostPath: ").Append(HostPath).Append("\n");
            sb.Append("  Iscsi: ").Append(Iscsi).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Nfs: ").Append(Nfs).Append("\n");
            sb.Append("  PersistentVolumeClaim: ").Append(PersistentVolumeClaim).Append("\n");
            sb.Append("  PhotonPersistentDisk: ").Append(PhotonPersistentDisk).Append("\n");
            sb.Append("  PortworxVolume: ").Append(PortworxVolume).Append("\n");
            sb.Append("  Projected: ").Append(Projected).Append("\n");
            sb.Append("  Quobyte: ").Append(Quobyte).Append("\n");
            sb.Append("  Rbd: ").Append(Rbd).Append("\n");
            sb.Append("  ScaleIO: ").Append(ScaleIO).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  Storageos: ").Append(Storageos).Append("\n");
            sb.Append("  VsphereVolume: ").Append(VsphereVolume).Append("\n");
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
