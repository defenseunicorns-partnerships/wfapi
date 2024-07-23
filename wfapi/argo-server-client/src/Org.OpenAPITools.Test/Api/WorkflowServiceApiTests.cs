/*
 * Argo Workflows API
 *
 * Argo Workflows is an open source container-native workflow engine for orchestrating parallel jobs on Kubernetes. For more information, please see https://argo-workflows.readthedocs.io/en/latest/
 *
 * The version of the OpenAPI document: VERSION
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing WorkflowServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WorkflowServiceApiTests : IDisposable
    {
        private WorkflowServiceApi instance;

        public WorkflowServiceApiTests()
        {
            instance = new WorkflowServiceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WorkflowServiceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WorkflowServiceApi
            //Assert.IsType<WorkflowServiceApi>(instance);
        }

        /// <summary>
        /// Test WorkflowServiceCreateWorkflow
        /// </summary>
        [Fact]
        public void WorkflowServiceCreateWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //IoArgoprojWorkflowV1alpha1WorkflowCreateRequest body = null;
            //var response = instance.WorkflowServiceCreateWorkflow(varNamespace, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1Workflow>(response);
        }

        /// <summary>
        /// Test WorkflowServiceDeleteWorkflow
        /// </summary>
        [Fact]
        public void WorkflowServiceDeleteWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //string deleteOptionsGracePeriodSeconds = null;
            //string deleteOptionsPreconditionsUid = null;
            //string deleteOptionsPreconditionsResourceVersion = null;
            //bool? deleteOptionsOrphanDependents = null;
            //string deleteOptionsPropagationPolicy = null;
            //List<string> deleteOptionsDryRun = null;
            //bool? force = null;
            //var response = instance.WorkflowServiceDeleteWorkflow(varNamespace, name, deleteOptionsGracePeriodSeconds, deleteOptionsPreconditionsUid, deleteOptionsPreconditionsResourceVersion, deleteOptionsOrphanDependents, deleteOptionsPropagationPolicy, deleteOptionsDryRun, force);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test WorkflowServiceGetWorkflow
        /// </summary>
        [Fact]
        public void WorkflowServiceGetWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //string getOptionsResourceVersion = null;
            //string fields = null;
            //var response = instance.WorkflowServiceGetWorkflow(varNamespace, name, getOptionsResourceVersion, fields);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1Workflow>(response);
        }

        /// <summary>
        /// Test WorkflowServiceLintWorkflow
        /// </summary>
        [Fact]
        public void WorkflowServiceLintWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //IoArgoprojWorkflowV1alpha1WorkflowLintRequest body = null;
            //var response = instance.WorkflowServiceLintWorkflow(varNamespace, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1Workflow>(response);
        }

        /// <summary>
        /// Test WorkflowServiceListWorkflows
        /// </summary>
        [Fact]
        public void WorkflowServiceListWorkflowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string listOptionsLabelSelector = null;
            //string listOptionsFieldSelector = null;
            //bool? listOptionsWatch = null;
            //bool? listOptionsAllowWatchBookmarks = null;
            //string listOptionsResourceVersion = null;
            //string listOptionsResourceVersionMatch = null;
            //string listOptionsTimeoutSeconds = null;
            //string listOptionsLimit = null;
            //string listOptionsContinue = null;
            //string fields = null;
            //var response = instance.WorkflowServiceListWorkflows(varNamespace, listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue, fields);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1WorkflowList>(response);
        }

        /// <summary>
        /// Test WorkflowServicePodLogs
        /// </summary>
        [Fact]
        public void WorkflowServicePodLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //string podName = null;
            //string logOptionsContainer = null;
            //bool? logOptionsFollow = null;
            //bool? logOptionsPrevious = null;
            //string logOptionsSinceSeconds = null;
            //string logOptionsSinceTimeSeconds = null;
            //int? logOptionsSinceTimeNanos = null;
            //bool? logOptionsTimestamps = null;
            //string logOptionsTailLines = null;
            //string logOptionsLimitBytes = null;
            //bool? logOptionsInsecureSkipTLSVerifyBackend = null;
            //string grep = null;
            //string selector = null;
            //var response = instance.WorkflowServicePodLogs(varNamespace, name, podName, logOptionsContainer, logOptionsFollow, logOptionsPrevious, logOptionsSinceSeconds, logOptionsSinceTimeSeconds, logOptionsSinceTimeNanos, logOptionsTimestamps, logOptionsTailLines, logOptionsLimitBytes, logOptionsInsecureSkipTLSVerifyBackend, grep, selector);
            //Assert.IsType<StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry>(response);
        }

        /// <summary>
        /// Test WorkflowServiceResubmitWorkflow
        /// </summary>
        [Fact]
        public void WorkflowServiceResubmitWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //IoArgoprojWorkflowV1alpha1WorkflowResubmitRequest body = null;
            //var response = instance.WorkflowServiceResubmitWorkflow(varNamespace, name, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1Workflow>(response);
        }

        /// <summary>
        /// Test WorkflowServiceResumeWorkflow
        /// </summary>
        [Fact]
        public void WorkflowServiceResumeWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //IoArgoprojWorkflowV1alpha1WorkflowResumeRequest body = null;
            //var response = instance.WorkflowServiceResumeWorkflow(varNamespace, name, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1Workflow>(response);
        }

        /// <summary>
        /// Test WorkflowServiceRetryWorkflow
        /// </summary>
        [Fact]
        public void WorkflowServiceRetryWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //IoArgoprojWorkflowV1alpha1WorkflowRetryRequest body = null;
            //var response = instance.WorkflowServiceRetryWorkflow(varNamespace, name, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1Workflow>(response);
        }

        /// <summary>
        /// Test WorkflowServiceSetWorkflow
        /// </summary>
        [Fact]
        public void WorkflowServiceSetWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //IoArgoprojWorkflowV1alpha1WorkflowSetRequest body = null;
            //var response = instance.WorkflowServiceSetWorkflow(varNamespace, name, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1Workflow>(response);
        }

        /// <summary>
        /// Test WorkflowServiceStopWorkflow
        /// </summary>
        [Fact]
        public void WorkflowServiceStopWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //IoArgoprojWorkflowV1alpha1WorkflowStopRequest body = null;
            //var response = instance.WorkflowServiceStopWorkflow(varNamespace, name, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1Workflow>(response);
        }

        /// <summary>
        /// Test WorkflowServiceSubmitWorkflow
        /// </summary>
        [Fact]
        public void WorkflowServiceSubmitWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //IoArgoprojWorkflowV1alpha1WorkflowSubmitRequest body = null;
            //var response = instance.WorkflowServiceSubmitWorkflow(varNamespace, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1Workflow>(response);
        }

        /// <summary>
        /// Test WorkflowServiceSuspendWorkflow
        /// </summary>
        [Fact]
        public void WorkflowServiceSuspendWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //IoArgoprojWorkflowV1alpha1WorkflowSuspendRequest body = null;
            //var response = instance.WorkflowServiceSuspendWorkflow(varNamespace, name, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1Workflow>(response);
        }

        /// <summary>
        /// Test WorkflowServiceTerminateWorkflow
        /// </summary>
        [Fact]
        public void WorkflowServiceTerminateWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //IoArgoprojWorkflowV1alpha1WorkflowTerminateRequest body = null;
            //var response = instance.WorkflowServiceTerminateWorkflow(varNamespace, name, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1Workflow>(response);
        }

        /// <summary>
        /// Test WorkflowServiceWatchEvents
        /// </summary>
        [Fact]
        public void WorkflowServiceWatchEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string listOptionsLabelSelector = null;
            //string listOptionsFieldSelector = null;
            //bool? listOptionsWatch = null;
            //bool? listOptionsAllowWatchBookmarks = null;
            //string listOptionsResourceVersion = null;
            //string listOptionsResourceVersionMatch = null;
            //string listOptionsTimeoutSeconds = null;
            //string listOptionsLimit = null;
            //string listOptionsContinue = null;
            //var response = instance.WorkflowServiceWatchEvents(varNamespace, listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue);
            //Assert.IsType<StreamResultOfIoK8sApiCoreV1Event>(response);
        }

        /// <summary>
        /// Test WorkflowServiceWatchWorkflows
        /// </summary>
        [Fact]
        public void WorkflowServiceWatchWorkflowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string listOptionsLabelSelector = null;
            //string listOptionsFieldSelector = null;
            //bool? listOptionsWatch = null;
            //bool? listOptionsAllowWatchBookmarks = null;
            //string listOptionsResourceVersion = null;
            //string listOptionsResourceVersionMatch = null;
            //string listOptionsTimeoutSeconds = null;
            //string listOptionsLimit = null;
            //string listOptionsContinue = null;
            //string fields = null;
            //var response = instance.WorkflowServiceWatchWorkflows(varNamespace, listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue, fields);
            //Assert.IsType<StreamResultOfIoArgoprojWorkflowV1alpha1WorkflowWatchEvent>(response);
        }

        /// <summary>
        /// Test WorkflowServiceWorkflowLogs
        /// </summary>
        [Fact]
        public void WorkflowServiceWorkflowLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //string podName = null;
            //string logOptionsContainer = null;
            //bool? logOptionsFollow = null;
            //bool? logOptionsPrevious = null;
            //string logOptionsSinceSeconds = null;
            //string logOptionsSinceTimeSeconds = null;
            //int? logOptionsSinceTimeNanos = null;
            //bool? logOptionsTimestamps = null;
            //string logOptionsTailLines = null;
            //string logOptionsLimitBytes = null;
            //bool? logOptionsInsecureSkipTLSVerifyBackend = null;
            //string grep = null;
            //string selector = null;
            //var response = instance.WorkflowServiceWorkflowLogs(varNamespace, name, podName, logOptionsContainer, logOptionsFollow, logOptionsPrevious, logOptionsSinceSeconds, logOptionsSinceTimeSeconds, logOptionsSinceTimeNanos, logOptionsTimestamps, logOptionsTailLines, logOptionsLimitBytes, logOptionsInsecureSkipTLSVerifyBackend, grep, selector);
            //Assert.IsType<StreamResultOfIoArgoprojWorkflowV1alpha1LogEntry>(response);
        }
    }
}
