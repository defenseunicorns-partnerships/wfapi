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
    ///  Class for testing ArchivedWorkflowServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ArchivedWorkflowServiceApiTests : IDisposable
    {
        private ArchivedWorkflowServiceApi instance;

        public ArchivedWorkflowServiceApiTests()
        {
            instance = new ArchivedWorkflowServiceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ArchivedWorkflowServiceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ArchivedWorkflowServiceApi
            //Assert.IsType<ArchivedWorkflowServiceApi>(instance);
        }

        /// <summary>
        /// Test ArchivedWorkflowServiceDeleteArchivedWorkflow
        /// </summary>
        [Fact]
        public void ArchivedWorkflowServiceDeleteArchivedWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uid = null;
            //string? varNamespace = null;
            //var response = instance.ArchivedWorkflowServiceDeleteArchivedWorkflow(uid, varNamespace);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ArchivedWorkflowServiceGetArchivedWorkflow
        /// </summary>
        [Fact]
        public void ArchivedWorkflowServiceGetArchivedWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uid = null;
            //string? varNamespace = null;
            //string? name = null;
            //var response = instance.ArchivedWorkflowServiceGetArchivedWorkflow(uid, varNamespace, name);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1Workflow>(response);
        }

        /// <summary>
        /// Test ArchivedWorkflowServiceListArchivedWorkflowLabelKeys
        /// </summary>
        [Fact]
        public void ArchivedWorkflowServiceListArchivedWorkflowLabelKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? varNamespace = null;
            //var response = instance.ArchivedWorkflowServiceListArchivedWorkflowLabelKeys(varNamespace);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1LabelKeys>(response);
        }

        /// <summary>
        /// Test ArchivedWorkflowServiceListArchivedWorkflowLabelValues
        /// </summary>
        [Fact]
        public void ArchivedWorkflowServiceListArchivedWorkflowLabelValuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? listOptionsLabelSelector = null;
            //string? listOptionsFieldSelector = null;
            //bool? listOptionsWatch = null;
            //bool? listOptionsAllowWatchBookmarks = null;
            //string? listOptionsResourceVersion = null;
            //string? listOptionsResourceVersionMatch = null;
            //string? listOptionsTimeoutSeconds = null;
            //string? listOptionsLimit = null;
            //string? listOptionsContinue = null;
            //string? varNamespace = null;
            //var response = instance.ArchivedWorkflowServiceListArchivedWorkflowLabelValues(listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue, varNamespace);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1LabelValues>(response);
        }

        /// <summary>
        /// Test ArchivedWorkflowServiceListArchivedWorkflows
        /// </summary>
        [Fact]
        public void ArchivedWorkflowServiceListArchivedWorkflowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? listOptionsLabelSelector = null;
            //string? listOptionsFieldSelector = null;
            //bool? listOptionsWatch = null;
            //bool? listOptionsAllowWatchBookmarks = null;
            //string? listOptionsResourceVersion = null;
            //string? listOptionsResourceVersionMatch = null;
            //string? listOptionsTimeoutSeconds = null;
            //string? listOptionsLimit = null;
            //string? listOptionsContinue = null;
            //string? namePrefix = null;
            //string? varNamespace = null;
            //var response = instance.ArchivedWorkflowServiceListArchivedWorkflows(listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue, namePrefix, varNamespace);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1WorkflowList>(response);
        }

        /// <summary>
        /// Test ArchivedWorkflowServiceResubmitArchivedWorkflow
        /// </summary>
        [Fact]
        public void ArchivedWorkflowServiceResubmitArchivedWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uid = null;
            //IoArgoprojWorkflowV1alpha1ResubmitArchivedWorkflowRequest body = null;
            //var response = instance.ArchivedWorkflowServiceResubmitArchivedWorkflow(uid, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1Workflow>(response);
        }

        /// <summary>
        /// Test ArchivedWorkflowServiceRetryArchivedWorkflow
        /// </summary>
        [Fact]
        public void ArchivedWorkflowServiceRetryArchivedWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uid = null;
            //IoArgoprojWorkflowV1alpha1RetryArchivedWorkflowRequest body = null;
            //var response = instance.ArchivedWorkflowServiceRetryArchivedWorkflow(uid, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1Workflow>(response);
        }
    }
}
