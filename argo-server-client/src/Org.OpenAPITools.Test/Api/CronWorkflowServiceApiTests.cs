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
    ///  Class for testing CronWorkflowServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CronWorkflowServiceApiTests : IDisposable
    {
        private CronWorkflowServiceApi instance;

        public CronWorkflowServiceApiTests()
        {
            instance = new CronWorkflowServiceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CronWorkflowServiceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CronWorkflowServiceApi
            //Assert.IsType<CronWorkflowServiceApi>(instance);
        }

        /// <summary>
        /// Test CronWorkflowServiceCreateCronWorkflow
        /// </summary>
        [Fact]
        public void CronWorkflowServiceCreateCronWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //IoArgoprojWorkflowV1alpha1CreateCronWorkflowRequest body = null;
            //var response = instance.CronWorkflowServiceCreateCronWorkflow(varNamespace, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1CronWorkflow>(response);
        }

        /// <summary>
        /// Test CronWorkflowServiceDeleteCronWorkflow
        /// </summary>
        [Fact]
        public void CronWorkflowServiceDeleteCronWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //string? deleteOptionsGracePeriodSeconds = null;
            //string? deleteOptionsPreconditionsUid = null;
            //string? deleteOptionsPreconditionsResourceVersion = null;
            //bool? deleteOptionsOrphanDependents = null;
            //string? deleteOptionsPropagationPolicy = null;
            //List<string>? deleteOptionsDryRun = null;
            //var response = instance.CronWorkflowServiceDeleteCronWorkflow(varNamespace, name, deleteOptionsGracePeriodSeconds, deleteOptionsPreconditionsUid, deleteOptionsPreconditionsResourceVersion, deleteOptionsOrphanDependents, deleteOptionsPropagationPolicy, deleteOptionsDryRun);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test CronWorkflowServiceGetCronWorkflow
        /// </summary>
        [Fact]
        public void CronWorkflowServiceGetCronWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //string? getOptionsResourceVersion = null;
            //var response = instance.CronWorkflowServiceGetCronWorkflow(varNamespace, name, getOptionsResourceVersion);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1CronWorkflow>(response);
        }

        /// <summary>
        /// Test CronWorkflowServiceLintCronWorkflow
        /// </summary>
        [Fact]
        public void CronWorkflowServiceLintCronWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //IoArgoprojWorkflowV1alpha1LintCronWorkflowRequest body = null;
            //var response = instance.CronWorkflowServiceLintCronWorkflow(varNamespace, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1CronWorkflow>(response);
        }

        /// <summary>
        /// Test CronWorkflowServiceListCronWorkflows
        /// </summary>
        [Fact]
        public void CronWorkflowServiceListCronWorkflowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string? listOptionsLabelSelector = null;
            //string? listOptionsFieldSelector = null;
            //bool? listOptionsWatch = null;
            //bool? listOptionsAllowWatchBookmarks = null;
            //string? listOptionsResourceVersion = null;
            //string? listOptionsResourceVersionMatch = null;
            //string? listOptionsTimeoutSeconds = null;
            //string? listOptionsLimit = null;
            //string? listOptionsContinue = null;
            //var response = instance.CronWorkflowServiceListCronWorkflows(varNamespace, listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1CronWorkflowList>(response);
        }

        /// <summary>
        /// Test CronWorkflowServiceResumeCronWorkflow
        /// </summary>
        [Fact]
        public void CronWorkflowServiceResumeCronWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //IoArgoprojWorkflowV1alpha1CronWorkflowResumeRequest body = null;
            //var response = instance.CronWorkflowServiceResumeCronWorkflow(varNamespace, name, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1CronWorkflow>(response);
        }

        /// <summary>
        /// Test CronWorkflowServiceSuspendCronWorkflow
        /// </summary>
        [Fact]
        public void CronWorkflowServiceSuspendCronWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //IoArgoprojWorkflowV1alpha1CronWorkflowSuspendRequest body = null;
            //var response = instance.CronWorkflowServiceSuspendCronWorkflow(varNamespace, name, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1CronWorkflow>(response);
        }

        /// <summary>
        /// Test CronWorkflowServiceUpdateCronWorkflow
        /// </summary>
        [Fact]
        public void CronWorkflowServiceUpdateCronWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varNamespace = null;
            //string name = null;
            //IoArgoprojWorkflowV1alpha1UpdateCronWorkflowRequest body = null;
            //var response = instance.CronWorkflowServiceUpdateCronWorkflow(varNamespace, name, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1CronWorkflow>(response);
        }
    }
}
