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
    /// ArchiveStrategy describes how to archive files/directory when saving artifacts
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.ArchiveStrategy")]
    public partial class IoArgoprojWorkflowV1alpha1ArchiveStrategy : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1ArchiveStrategy" /> class.
        /// </summary>
        /// <param name="none">NoneStrategy indicates to skip tar process and upload the files or directory tree as independent files. Note that if the artifact is a directory, the artifact driver must support the ability to save/load the directory appropriately..</param>
        /// <param name="tar">tar.</param>
        /// <param name="zip">ZipStrategy will unzip zipped input artifacts.</param>
        public IoArgoprojWorkflowV1alpha1ArchiveStrategy(Object none = default(Object), IoArgoprojWorkflowV1alpha1TarStrategy tar = default(IoArgoprojWorkflowV1alpha1TarStrategy), Object zip = default(Object))
        {
            this.None = none;
            this.Tar = tar;
            this.Zip = zip;
        }

        /// <summary>
        /// NoneStrategy indicates to skip tar process and upload the files or directory tree as independent files. Note that if the artifact is a directory, the artifact driver must support the ability to save/load the directory appropriately.
        /// </summary>
        /// <value>NoneStrategy indicates to skip tar process and upload the files or directory tree as independent files. Note that if the artifact is a directory, the artifact driver must support the ability to save/load the directory appropriately.</value>
        [DataMember(Name = "none", EmitDefaultValue = false)]
        public Object None { get; set; }

        /// <summary>
        /// Gets or Sets Tar
        /// </summary>
        [DataMember(Name = "tar", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1TarStrategy Tar { get; set; }

        /// <summary>
        /// ZipStrategy will unzip zipped input artifacts
        /// </summary>
        /// <value>ZipStrategy will unzip zipped input artifacts</value>
        [DataMember(Name = "zip", EmitDefaultValue = false)]
        public Object Zip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1ArchiveStrategy {\n");
            sb.Append("  None: ").Append(None).Append("\n");
            sb.Append("  Tar: ").Append(Tar).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
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
