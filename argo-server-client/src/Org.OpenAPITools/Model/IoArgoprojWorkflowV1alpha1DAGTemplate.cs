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
    /// DAGTemplate is a template subtype for directed acyclic graph templates
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.DAGTemplate")]
    public partial class IoArgoprojWorkflowV1alpha1DAGTemplate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1DAGTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoArgoprojWorkflowV1alpha1DAGTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1DAGTemplate" /> class.
        /// </summary>
        /// <param name="failFast">This flag is for DAG logic. The DAG logic has a built-in \&quot;fail fast\&quot; feature to stop scheduling new steps, as soon as it detects that one of the DAG nodes is failed. Then it waits until all DAG nodes are completed before failing the DAG itself. The FailFast flag default is true,  if set to false, it will allow a DAG to run all branches of the DAG to completion (either success or failure), regardless of the failed outcomes of branches in the DAG. More info and example about this feature at https://github.com/argoproj/argo-workflows/issues/1442.</param>
        /// <param name="target">Target are one or more names of targets to execute in a DAG.</param>
        /// <param name="tasks">Tasks are a list of DAG tasks (required).</param>
        public IoArgoprojWorkflowV1alpha1DAGTemplate(bool failFast = default(bool), string target = default(string), List<IoArgoprojWorkflowV1alpha1DAGTask> tasks = default(List<IoArgoprojWorkflowV1alpha1DAGTask>))
        {
            // to ensure "tasks" is required (not null)
            if (tasks == null)
            {
                throw new ArgumentNullException("tasks is a required property for IoArgoprojWorkflowV1alpha1DAGTemplate and cannot be null");
            }
            this.Tasks = tasks;
            this.FailFast = failFast;
            this.Target = target;
        }

        /// <summary>
        /// This flag is for DAG logic. The DAG logic has a built-in \&quot;fail fast\&quot; feature to stop scheduling new steps, as soon as it detects that one of the DAG nodes is failed. Then it waits until all DAG nodes are completed before failing the DAG itself. The FailFast flag default is true,  if set to false, it will allow a DAG to run all branches of the DAG to completion (either success or failure), regardless of the failed outcomes of branches in the DAG. More info and example about this feature at https://github.com/argoproj/argo-workflows/issues/1442
        /// </summary>
        /// <value>This flag is for DAG logic. The DAG logic has a built-in \&quot;fail fast\&quot; feature to stop scheduling new steps, as soon as it detects that one of the DAG nodes is failed. Then it waits until all DAG nodes are completed before failing the DAG itself. The FailFast flag default is true,  if set to false, it will allow a DAG to run all branches of the DAG to completion (either success or failure), regardless of the failed outcomes of branches in the DAG. More info and example about this feature at https://github.com/argoproj/argo-workflows/issues/1442</value>
        [DataMember(Name = "failFast", EmitDefaultValue = true)]
        public bool FailFast { get; set; }

        /// <summary>
        /// Target are one or more names of targets to execute in a DAG
        /// </summary>
        /// <value>Target are one or more names of targets to execute in a DAG</value>
        [DataMember(Name = "target", EmitDefaultValue = false)]
        public string Target { get; set; }

        /// <summary>
        /// Tasks are a list of DAG tasks
        /// </summary>
        /// <value>Tasks are a list of DAG tasks</value>
        [DataMember(Name = "tasks", IsRequired = true, EmitDefaultValue = true)]
        public List<IoArgoprojWorkflowV1alpha1DAGTask> Tasks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1DAGTemplate {\n");
            sb.Append("  FailFast: ").Append(FailFast).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
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
