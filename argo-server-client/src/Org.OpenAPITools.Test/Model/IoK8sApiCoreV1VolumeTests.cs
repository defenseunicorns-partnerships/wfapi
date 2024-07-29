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
    ///  Class for testing IoK8sApiCoreV1Volume
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IoK8sApiCoreV1VolumeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IoK8sApiCoreV1Volume
        //private IoK8sApiCoreV1Volume instance;

        public IoK8sApiCoreV1VolumeTests()
        {
            // TODO uncomment below to create an instance of IoK8sApiCoreV1Volume
            //instance = new IoK8sApiCoreV1Volume();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IoK8sApiCoreV1Volume
        /// </summary>
        [Fact]
        public void IoK8sApiCoreV1VolumeInstanceTest()
        {
            // TODO uncomment below to test "IsType" IoK8sApiCoreV1Volume
            //Assert.IsType<IoK8sApiCoreV1Volume>(instance);
        }

        /// <summary>
        /// Test the property 'AwsElasticBlockStore'
        /// </summary>
        [Fact]
        public void AwsElasticBlockStoreTest()
        {
            // TODO unit test for the property 'AwsElasticBlockStore'
        }

        /// <summary>
        /// Test the property 'AzureDisk'
        /// </summary>
        [Fact]
        public void AzureDiskTest()
        {
            // TODO unit test for the property 'AzureDisk'
        }

        /// <summary>
        /// Test the property 'AzureFile'
        /// </summary>
        [Fact]
        public void AzureFileTest()
        {
            // TODO unit test for the property 'AzureFile'
        }

        /// <summary>
        /// Test the property 'Cephfs'
        /// </summary>
        [Fact]
        public void CephfsTest()
        {
            // TODO unit test for the property 'Cephfs'
        }

        /// <summary>
        /// Test the property 'Cinder'
        /// </summary>
        [Fact]
        public void CinderTest()
        {
            // TODO unit test for the property 'Cinder'
        }

        /// <summary>
        /// Test the property 'ConfigMap'
        /// </summary>
        [Fact]
        public void ConfigMapTest()
        {
            // TODO unit test for the property 'ConfigMap'
        }

        /// <summary>
        /// Test the property 'Csi'
        /// </summary>
        [Fact]
        public void CsiTest()
        {
            // TODO unit test for the property 'Csi'
        }

        /// <summary>
        /// Test the property 'DownwardAPI'
        /// </summary>
        [Fact]
        public void DownwardAPITest()
        {
            // TODO unit test for the property 'DownwardAPI'
        }

        /// <summary>
        /// Test the property 'EmptyDir'
        /// </summary>
        [Fact]
        public void EmptyDirTest()
        {
            // TODO unit test for the property 'EmptyDir'
        }

        /// <summary>
        /// Test the property 'Ephemeral'
        /// </summary>
        [Fact]
        public void EphemeralTest()
        {
            // TODO unit test for the property 'Ephemeral'
        }

        /// <summary>
        /// Test the property 'Fc'
        /// </summary>
        [Fact]
        public void FcTest()
        {
            // TODO unit test for the property 'Fc'
        }

        /// <summary>
        /// Test the property 'FlexVolume'
        /// </summary>
        [Fact]
        public void FlexVolumeTest()
        {
            // TODO unit test for the property 'FlexVolume'
        }

        /// <summary>
        /// Test the property 'Flocker'
        /// </summary>
        [Fact]
        public void FlockerTest()
        {
            // TODO unit test for the property 'Flocker'
        }

        /// <summary>
        /// Test the property 'GcePersistentDisk'
        /// </summary>
        [Fact]
        public void GcePersistentDiskTest()
        {
            // TODO unit test for the property 'GcePersistentDisk'
        }

        /// <summary>
        /// Test the property 'GitRepo'
        /// </summary>
        [Fact]
        public void GitRepoTest()
        {
            // TODO unit test for the property 'GitRepo'
        }

        /// <summary>
        /// Test the property 'Glusterfs'
        /// </summary>
        [Fact]
        public void GlusterfsTest()
        {
            // TODO unit test for the property 'Glusterfs'
        }

        /// <summary>
        /// Test the property 'HostPath'
        /// </summary>
        [Fact]
        public void HostPathTest()
        {
            // TODO unit test for the property 'HostPath'
        }

        /// <summary>
        /// Test the property 'Iscsi'
        /// </summary>
        [Fact]
        public void IscsiTest()
        {
            // TODO unit test for the property 'Iscsi'
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'Nfs'
        /// </summary>
        [Fact]
        public void NfsTest()
        {
            // TODO unit test for the property 'Nfs'
        }

        /// <summary>
        /// Test the property 'PersistentVolumeClaim'
        /// </summary>
        [Fact]
        public void PersistentVolumeClaimTest()
        {
            // TODO unit test for the property 'PersistentVolumeClaim'
        }

        /// <summary>
        /// Test the property 'PhotonPersistentDisk'
        /// </summary>
        [Fact]
        public void PhotonPersistentDiskTest()
        {
            // TODO unit test for the property 'PhotonPersistentDisk'
        }

        /// <summary>
        /// Test the property 'PortworxVolume'
        /// </summary>
        [Fact]
        public void PortworxVolumeTest()
        {
            // TODO unit test for the property 'PortworxVolume'
        }

        /// <summary>
        /// Test the property 'Projected'
        /// </summary>
        [Fact]
        public void ProjectedTest()
        {
            // TODO unit test for the property 'Projected'
        }

        /// <summary>
        /// Test the property 'Quobyte'
        /// </summary>
        [Fact]
        public void QuobyteTest()
        {
            // TODO unit test for the property 'Quobyte'
        }

        /// <summary>
        /// Test the property 'Rbd'
        /// </summary>
        [Fact]
        public void RbdTest()
        {
            // TODO unit test for the property 'Rbd'
        }

        /// <summary>
        /// Test the property 'ScaleIO'
        /// </summary>
        [Fact]
        public void ScaleIOTest()
        {
            // TODO unit test for the property 'ScaleIO'
        }

        /// <summary>
        /// Test the property 'Secret'
        /// </summary>
        [Fact]
        public void SecretTest()
        {
            // TODO unit test for the property 'Secret'
        }

        /// <summary>
        /// Test the property 'Storageos'
        /// </summary>
        [Fact]
        public void StorageosTest()
        {
            // TODO unit test for the property 'Storageos'
        }

        /// <summary>
        /// Test the property 'VsphereVolume'
        /// </summary>
        [Fact]
        public void VsphereVolumeTest()
        {
            // TODO unit test for the property 'VsphereVolume'
        }
    }
}