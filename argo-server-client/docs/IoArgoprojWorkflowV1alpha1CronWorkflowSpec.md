# Org.OpenAPITools.Model.IoArgoprojWorkflowV1alpha1CronWorkflowSpec
CronWorkflowSpec is the specification of a CronWorkflow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConcurrencyPolicy** | **string** | ConcurrencyPolicy is the K8s-style concurrency policy that will be used | [optional]
**FailedJobsHistoryLimit** | **int** | FailedJobsHistoryLimit is the number of failed jobs to be kept at a time | [optional]
**Schedule** | **string** | Schedule is a schedule to run the Workflow in Cron format |
**Schedules** | **List&lt;string&gt;** | Schedules is a list of schedules to run the Workflow in Cron format | [optional]
**StartingDeadlineSeconds** | **int** | StartingDeadlineSeconds is the K8s-style deadline that will limit the time a CronWorkflow will be run after its original scheduled time if it is missed. | [optional]
**StopStrategy** | [**IoArgoprojWorkflowV1alpha1StopStrategy**](IoArgoprojWorkflowV1alpha1StopStrategy.md) |  | [optional]
**SuccessfulJobsHistoryLimit** | **int** | SuccessfulJobsHistoryLimit is the number of successful jobs to be kept at a time | [optional]
**Suspend** | **bool** | Suspend is a flag that will stop new CronWorkflows from running if set to true | [optional]
**Timezone** | **string** | Timezone is the timezone against which the cron schedule will be calculated, e.g. \&quot;Asia/Tokyo\&quot;. Default is machine&#39;s local time. | [optional]
**WorkflowMetadata** | [**IoK8sApimachineryPkgApisMetaV1ObjectMeta**](IoK8sApimachineryPkgApisMetaV1ObjectMeta.md) |  | [optional]
**WorkflowSpec** | [**IoArgoprojWorkflowV1alpha1WorkflowSpec**](IoArgoprojWorkflowV1alpha1WorkflowSpec.md) |  |

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
