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
    /// WindowsSecurityContextOptions contain Windows-specific options and credentials.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.WindowsSecurityContextOptions")]
    public partial class IoK8sApiCoreV1WindowsSecurityContextOptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1WindowsSecurityContextOptions" /> class.
        /// </summary>
        /// <param name="gmsaCredentialSpec">GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field..</param>
        /// <param name="gmsaCredentialSpecName">GMSACredentialSpecName is the name of the GMSA credential spec to use..</param>
        /// <param name="hostProcess">HostProcess determines if a container should be run as a &#39;Host Process&#39; container. This field is alpha-level and will only be honored by components that enable the WindowsHostProcessContainers feature flag. Setting this field without the feature flag will result in errors when validating the Pod. All of a Pod&#39;s containers must have the same effective HostProcess value (it is not allowed to have a mix of HostProcess containers and non-HostProcess containers).  In addition, if HostProcess is true then HostNetwork must also be set to true..</param>
        /// <param name="runAsUserName">The UserName in Windows to run the entrypoint of the container process. Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence..</param>
        public IoK8sApiCoreV1WindowsSecurityContextOptions(string gmsaCredentialSpec = default(string), string gmsaCredentialSpecName = default(string), bool hostProcess = default(bool), string runAsUserName = default(string))
        {
            this.GmsaCredentialSpec = gmsaCredentialSpec;
            this.GmsaCredentialSpecName = gmsaCredentialSpecName;
            this.HostProcess = hostProcess;
            this.RunAsUserName = runAsUserName;
        }

        /// <summary>
        /// GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field.
        /// </summary>
        /// <value>GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field.</value>
        [DataMember(Name = "gmsaCredentialSpec", EmitDefaultValue = false)]
        public string GmsaCredentialSpec { get; set; }

        /// <summary>
        /// GMSACredentialSpecName is the name of the GMSA credential spec to use.
        /// </summary>
        /// <value>GMSACredentialSpecName is the name of the GMSA credential spec to use.</value>
        [DataMember(Name = "gmsaCredentialSpecName", EmitDefaultValue = false)]
        public string GmsaCredentialSpecName { get; set; }

        /// <summary>
        /// HostProcess determines if a container should be run as a &#39;Host Process&#39; container. This field is alpha-level and will only be honored by components that enable the WindowsHostProcessContainers feature flag. Setting this field without the feature flag will result in errors when validating the Pod. All of a Pod&#39;s containers must have the same effective HostProcess value (it is not allowed to have a mix of HostProcess containers and non-HostProcess containers).  In addition, if HostProcess is true then HostNetwork must also be set to true.
        /// </summary>
        /// <value>HostProcess determines if a container should be run as a &#39;Host Process&#39; container. This field is alpha-level and will only be honored by components that enable the WindowsHostProcessContainers feature flag. Setting this field without the feature flag will result in errors when validating the Pod. All of a Pod&#39;s containers must have the same effective HostProcess value (it is not allowed to have a mix of HostProcess containers and non-HostProcess containers).  In addition, if HostProcess is true then HostNetwork must also be set to true.</value>
        [DataMember(Name = "hostProcess", EmitDefaultValue = true)]
        public bool HostProcess { get; set; }

        /// <summary>
        /// The UserName in Windows to run the entrypoint of the container process. Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        /// </summary>
        /// <value>The UserName in Windows to run the entrypoint of the container process. Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</value>
        [DataMember(Name = "runAsUserName", EmitDefaultValue = false)]
        public string RunAsUserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1WindowsSecurityContextOptions {\n");
            sb.Append("  GmsaCredentialSpec: ").Append(GmsaCredentialSpec).Append("\n");
            sb.Append("  GmsaCredentialSpecName: ").Append(GmsaCredentialSpecName).Append("\n");
            sb.Append("  HostProcess: ").Append(HostProcess).Append("\n");
            sb.Append("  RunAsUserName: ").Append(RunAsUserName).Append("\n");
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
