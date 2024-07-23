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
    ///  Class for testing IoK8sApiCoreV1Affinity
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IoK8sApiCoreV1AffinityTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IoK8sApiCoreV1Affinity
        //private IoK8sApiCoreV1Affinity instance;

        public IoK8sApiCoreV1AffinityTests()
        {
            // TODO uncomment below to create an instance of IoK8sApiCoreV1Affinity
            //instance = new IoK8sApiCoreV1Affinity();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IoK8sApiCoreV1Affinity
        /// </summary>
        [Fact]
        public void IoK8sApiCoreV1AffinityInstanceTest()
        {
            // TODO uncomment below to test "IsType" IoK8sApiCoreV1Affinity
            //Assert.IsType<IoK8sApiCoreV1Affinity>(instance);
        }

        /// <summary>
        /// Test the property 'NodeAffinity'
        /// </summary>
        [Fact]
        public void NodeAffinityTest()
        {
            // TODO unit test for the property 'NodeAffinity'
        }

        /// <summary>
        /// Test the property 'PodAffinity'
        /// </summary>
        [Fact]
        public void PodAffinityTest()
        {
            // TODO unit test for the property 'PodAffinity'
        }

        /// <summary>
        /// Test the property 'PodAntiAffinity'
        /// </summary>
        [Fact]
        public void PodAntiAffinityTest()
        {
            // TODO unit test for the property 'PodAntiAffinity'
        }
    }
}
