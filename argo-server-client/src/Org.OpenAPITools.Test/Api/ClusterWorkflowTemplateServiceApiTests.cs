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
    ///  Class for testing ClusterWorkflowTemplateServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ClusterWorkflowTemplateServiceApiTests : IDisposable
    {
        private ClusterWorkflowTemplateServiceApi instance;

        public ClusterWorkflowTemplateServiceApiTests()
        {
            instance = new ClusterWorkflowTemplateServiceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClusterWorkflowTemplateServiceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ClusterWorkflowTemplateServiceApi
            //Assert.IsType<ClusterWorkflowTemplateServiceApi>(instance);
        }

        /// <summary>
        /// Test ClusterWorkflowTemplateServiceCreateClusterWorkflowTemplate
        /// </summary>
        [Fact]
        public void ClusterWorkflowTemplateServiceCreateClusterWorkflowTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateCreateRequest body = null;
            //var response = instance.ClusterWorkflowTemplateServiceCreateClusterWorkflowTemplate(body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate>(response);
        }

        /// <summary>
        /// Test ClusterWorkflowTemplateServiceDeleteClusterWorkflowTemplate
        /// </summary>
        [Fact]
        public void ClusterWorkflowTemplateServiceDeleteClusterWorkflowTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string? deleteOptionsGracePeriodSeconds = null;
            //string? deleteOptionsPreconditionsUid = null;
            //string? deleteOptionsPreconditionsResourceVersion = null;
            //bool? deleteOptionsOrphanDependents = null;
            //string? deleteOptionsPropagationPolicy = null;
            //List<string>? deleteOptionsDryRun = null;
            //var response = instance.ClusterWorkflowTemplateServiceDeleteClusterWorkflowTemplate(name, deleteOptionsGracePeriodSeconds, deleteOptionsPreconditionsUid, deleteOptionsPreconditionsResourceVersion, deleteOptionsOrphanDependents, deleteOptionsPropagationPolicy, deleteOptionsDryRun);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ClusterWorkflowTemplateServiceGetClusterWorkflowTemplate
        /// </summary>
        [Fact]
        public void ClusterWorkflowTemplateServiceGetClusterWorkflowTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string? getOptionsResourceVersion = null;
            //var response = instance.ClusterWorkflowTemplateServiceGetClusterWorkflowTemplate(name, getOptionsResourceVersion);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate>(response);
        }

        /// <summary>
        /// Test ClusterWorkflowTemplateServiceLintClusterWorkflowTemplate
        /// </summary>
        [Fact]
        public void ClusterWorkflowTemplateServiceLintClusterWorkflowTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateLintRequest body = null;
            //var response = instance.ClusterWorkflowTemplateServiceLintClusterWorkflowTemplate(body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate>(response);
        }

        /// <summary>
        /// Test ClusterWorkflowTemplateServiceListClusterWorkflowTemplates
        /// </summary>
        [Fact]
        public void ClusterWorkflowTemplateServiceListClusterWorkflowTemplatesTest()
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
            //var response = instance.ClusterWorkflowTemplateServiceListClusterWorkflowTemplates(listOptionsLabelSelector, listOptionsFieldSelector, listOptionsWatch, listOptionsAllowWatchBookmarks, listOptionsResourceVersion, listOptionsResourceVersionMatch, listOptionsTimeoutSeconds, listOptionsLimit, listOptionsContinue);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateList>(response);
        }

        /// <summary>
        /// Test ClusterWorkflowTemplateServiceUpdateClusterWorkflowTemplate
        /// </summary>
        [Fact]
        public void ClusterWorkflowTemplateServiceUpdateClusterWorkflowTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplateUpdateRequest body = null;
            //var response = instance.ClusterWorkflowTemplateServiceUpdateClusterWorkflowTemplate(name, body);
            //Assert.IsType<IoArgoprojWorkflowV1alpha1ClusterWorkflowTemplate>(response);
        }
    }
}
