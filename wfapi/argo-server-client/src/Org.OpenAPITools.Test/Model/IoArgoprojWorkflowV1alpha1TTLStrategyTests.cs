/*
 * Argo Workflows API
 *
 * Argo Workflows is an open source container-native workflow engine for orchestrating parallel jobs on Kubernetes. For more information, please see https://argo-workflows.readthedocs.io/en/latest/
 *
 * The version of the OpenAPI document: VERSION
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test.Model
{
    /// <summary>
    ///  Class for testing IoArgoprojWorkflowV1alpha1TTLStrategy
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IoArgoprojWorkflowV1alpha1TTLStrategyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IoArgoprojWorkflowV1alpha1TTLStrategy
        //private IoArgoprojWorkflowV1alpha1TTLStrategy instance;

        public IoArgoprojWorkflowV1alpha1TTLStrategyTests()
        {
            // TODO uncomment below to create an instance of IoArgoprojWorkflowV1alpha1TTLStrategy
            //instance = new IoArgoprojWorkflowV1alpha1TTLStrategy();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IoArgoprojWorkflowV1alpha1TTLStrategy
        /// </summary>
        [Fact]
        public void IoArgoprojWorkflowV1alpha1TTLStrategyInstanceTest()
        {
            // TODO uncomment below to test "IsType" IoArgoprojWorkflowV1alpha1TTLStrategy
            //Assert.IsType<IoArgoprojWorkflowV1alpha1TTLStrategy>(instance);
        }

        /// <summary>
        /// Test the property 'SecondsAfterCompletion'
        /// </summary>
        [Fact]
        public void SecondsAfterCompletionTest()
        {
            // TODO unit test for the property 'SecondsAfterCompletion'
        }

        /// <summary>
        /// Test the property 'SecondsAfterFailure'
        /// </summary>
        [Fact]
        public void SecondsAfterFailureTest()
        {
            // TODO unit test for the property 'SecondsAfterFailure'
        }

        /// <summary>
        /// Test the property 'SecondsAfterSuccess'
        /// </summary>
        [Fact]
        public void SecondsAfterSuccessTest()
        {
            // TODO unit test for the property 'SecondsAfterSuccess'
        }
    }
}
