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
    /// SecurityContext holds security configuration that will be applied to a container. Some fields are present in both SecurityContext and PodSecurityContext.  When both are set, the values in SecurityContext take precedence.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.SecurityContext")]
    public partial class IoK8sApiCoreV1SecurityContext : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1SecurityContext" /> class.
        /// </summary>
        /// <param name="allowPrivilegeEscalation">AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process. This bool directly controls if the no_new_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP_SYS_ADMIN Note that this field cannot be set when spec.os.name is windows..</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="privileged">Run container in privileged mode. Processes in privileged containers are essentially equivalent to root on the host. Defaults to false. Note that this field cannot be set when spec.os.name is windows..</param>
        /// <param name="procMount">procMount denotes the type of proc mount to use for the containers. The default is DefaultProcMount which uses the container runtime defaults for readonly paths and masked paths. This requires the ProcMountType feature flag to be enabled. Note that this field cannot be set when spec.os.name is windows..</param>
        /// <param name="readOnlyRootFilesystem">Whether this container has a read-only root filesystem. Default is false. Note that this field cannot be set when spec.os.name is windows..</param>
        /// <param name="runAsGroup">The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows..</param>
        /// <param name="runAsNonRoot">Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence..</param>
        /// <param name="runAsUser">The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows..</param>
        /// <param name="seLinuxOptions">seLinuxOptions.</param>
        /// <param name="seccompProfile">seccompProfile.</param>
        /// <param name="windowsOptions">windowsOptions.</param>
        public IoK8sApiCoreV1SecurityContext(bool allowPrivilegeEscalation = default(bool), IoK8sApiCoreV1Capabilities capabilities = default(IoK8sApiCoreV1Capabilities), bool privileged = default(bool), string procMount = default(string), bool readOnlyRootFilesystem = default(bool), int runAsGroup = default(int), bool runAsNonRoot = default(bool), int runAsUser = default(int), IoK8sApiCoreV1SELinuxOptions seLinuxOptions = default(IoK8sApiCoreV1SELinuxOptions), IoK8sApiCoreV1SeccompProfile seccompProfile = default(IoK8sApiCoreV1SeccompProfile), IoK8sApiCoreV1WindowsSecurityContextOptions windowsOptions = default(IoK8sApiCoreV1WindowsSecurityContextOptions))
        {
            this.AllowPrivilegeEscalation = allowPrivilegeEscalation;
            this.Capabilities = capabilities;
            this.Privileged = privileged;
            this.ProcMount = procMount;
            this.ReadOnlyRootFilesystem = readOnlyRootFilesystem;
            this.RunAsGroup = runAsGroup;
            this.RunAsNonRoot = runAsNonRoot;
            this.RunAsUser = runAsUser;
            this.SeLinuxOptions = seLinuxOptions;
            this.SeccompProfile = seccompProfile;
            this.WindowsOptions = windowsOptions;
        }

        /// <summary>
        /// AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process. This bool directly controls if the no_new_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP_SYS_ADMIN Note that this field cannot be set when spec.os.name is windows.
        /// </summary>
        /// <value>AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process. This bool directly controls if the no_new_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP_SYS_ADMIN Note that this field cannot be set when spec.os.name is windows.</value>
        [DataMember(Name = "allowPrivilegeEscalation", EmitDefaultValue = true)]
        public bool AllowPrivilegeEscalation { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public IoK8sApiCoreV1Capabilities Capabilities { get; set; }

        /// <summary>
        /// Run container in privileged mode. Processes in privileged containers are essentially equivalent to root on the host. Defaults to false. Note that this field cannot be set when spec.os.name is windows.
        /// </summary>
        /// <value>Run container in privileged mode. Processes in privileged containers are essentially equivalent to root on the host. Defaults to false. Note that this field cannot be set when spec.os.name is windows.</value>
        [DataMember(Name = "privileged", EmitDefaultValue = true)]
        public bool Privileged { get; set; }

        /// <summary>
        /// procMount denotes the type of proc mount to use for the containers. The default is DefaultProcMount which uses the container runtime defaults for readonly paths and masked paths. This requires the ProcMountType feature flag to be enabled. Note that this field cannot be set when spec.os.name is windows.
        /// </summary>
        /// <value>procMount denotes the type of proc mount to use for the containers. The default is DefaultProcMount which uses the container runtime defaults for readonly paths and masked paths. This requires the ProcMountType feature flag to be enabled. Note that this field cannot be set when spec.os.name is windows.</value>
        [DataMember(Name = "procMount", EmitDefaultValue = false)]
        public string ProcMount { get; set; }

        /// <summary>
        /// Whether this container has a read-only root filesystem. Default is false. Note that this field cannot be set when spec.os.name is windows.
        /// </summary>
        /// <value>Whether this container has a read-only root filesystem. Default is false. Note that this field cannot be set when spec.os.name is windows.</value>
        [DataMember(Name = "readOnlyRootFilesystem", EmitDefaultValue = true)]
        public bool ReadOnlyRootFilesystem { get; set; }

        /// <summary>
        /// The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.
        /// </summary>
        /// <value>The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</value>
        [DataMember(Name = "runAsGroup", EmitDefaultValue = false)]
        public int RunAsGroup { get; set; }

        /// <summary>
        /// Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        /// </summary>
        /// <value>Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</value>
        [DataMember(Name = "runAsNonRoot", EmitDefaultValue = true)]
        public bool RunAsNonRoot { get; set; }

        /// <summary>
        /// The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.
        /// </summary>
        /// <value>The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</value>
        [DataMember(Name = "runAsUser", EmitDefaultValue = false)]
        public int RunAsUser { get; set; }

        /// <summary>
        /// Gets or Sets SeLinuxOptions
        /// </summary>
        [DataMember(Name = "seLinuxOptions", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SELinuxOptions SeLinuxOptions { get; set; }

        /// <summary>
        /// Gets or Sets SeccompProfile
        /// </summary>
        [DataMember(Name = "seccompProfile", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SeccompProfile SeccompProfile { get; set; }

        /// <summary>
        /// Gets or Sets WindowsOptions
        /// </summary>
        [DataMember(Name = "windowsOptions", EmitDefaultValue = false)]
        public IoK8sApiCoreV1WindowsSecurityContextOptions WindowsOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1SecurityContext {\n");
            sb.Append("  AllowPrivilegeEscalation: ").Append(AllowPrivilegeEscalation).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  Privileged: ").Append(Privileged).Append("\n");
            sb.Append("  ProcMount: ").Append(ProcMount).Append("\n");
            sb.Append("  ReadOnlyRootFilesystem: ").Append(ReadOnlyRootFilesystem).Append("\n");
            sb.Append("  RunAsGroup: ").Append(RunAsGroup).Append("\n");
            sb.Append("  RunAsNonRoot: ").Append(RunAsNonRoot).Append("\n");
            sb.Append("  RunAsUser: ").Append(RunAsUser).Append("\n");
            sb.Append("  SeLinuxOptions: ").Append(SeLinuxOptions).Append("\n");
            sb.Append("  SeccompProfile: ").Append(SeccompProfile).Append("\n");
            sb.Append("  WindowsOptions: ").Append(WindowsOptions).Append("\n");
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
