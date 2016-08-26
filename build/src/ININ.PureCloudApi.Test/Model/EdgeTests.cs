using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Model;
using ININ.PureCloudApi.Client;
using System.Reflection;

namespace ININ.PureCloudApi.Test
{
    /// <summary>
    ///  Class for testing Edge
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class EdgeTests
    {
        private Edge instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Edge();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Edge
        /// </summary>
        [Test]
        public void EdgeInstanceTest()
        {
            Assert.IsInstanceOf<Edge> (instance, "instance is a Edge");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Version'
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO: unit test for the property 'Version'
        }
        /// <summary>
        /// Test the property 'DateCreated'
        /// </summary>
        [Test]
        public void DateCreatedTest()
        {
            // TODO: unit test for the property 'DateCreated'
        }
        /// <summary>
        /// Test the property 'DateModified'
        /// </summary>
        [Test]
        public void DateModifiedTest()
        {
            // TODO: unit test for the property 'DateModified'
        }
        /// <summary>
        /// Test the property 'ModifiedBy'
        /// </summary>
        [Test]
        public void ModifiedByTest()
        {
            // TODO: unit test for the property 'ModifiedBy'
        }
        /// <summary>
        /// Test the property 'CreatedBy'
        /// </summary>
        [Test]
        public void CreatedByTest()
        {
            // TODO: unit test for the property 'CreatedBy'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO: unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'ModifiedByApp'
        /// </summary>
        [Test]
        public void ModifiedByAppTest()
        {
            // TODO: unit test for the property 'ModifiedByApp'
        }
        /// <summary>
        /// Test the property 'CreatedByApp'
        /// </summary>
        [Test]
        public void CreatedByAppTest()
        {
            // TODO: unit test for the property 'CreatedByApp'
        }
        /// <summary>
        /// Test the property 'Interfaces'
        /// </summary>
        [Test]
        public void InterfacesTest()
        {
            // TODO: unit test for the property 'Interfaces'
        }
        /// <summary>
        /// Test the property 'Make'
        /// </summary>
        [Test]
        public void MakeTest()
        {
            // TODO: unit test for the property 'Make'
        }
        /// <summary>
        /// Test the property 'Model'
        /// </summary>
        [Test]
        public void ModelTest()
        {
            // TODO: unit test for the property 'Model'
        }
        /// <summary>
        /// Test the property 'ApiVersion'
        /// </summary>
        [Test]
        public void ApiVersionTest()
        {
            // TODO: unit test for the property 'ApiVersion'
        }
        /// <summary>
        /// Test the property 'SoftwareVersion'
        /// </summary>
        [Test]
        public void SoftwareVersionTest()
        {
            // TODO: unit test for the property 'SoftwareVersion'
        }
        /// <summary>
        /// Test the property 'SoftwareVersionTimestamp'
        /// </summary>
        [Test]
        public void SoftwareVersionTimestampTest()
        {
            // TODO: unit test for the property 'SoftwareVersionTimestamp'
        }
        /// <summary>
        /// Test the property 'SoftwareVersionPlatform'
        /// </summary>
        [Test]
        public void SoftwareVersionPlatformTest()
        {
            // TODO: unit test for the property 'SoftwareVersionPlatform'
        }
        /// <summary>
        /// Test the property 'SoftwareVersionConfiguration'
        /// </summary>
        [Test]
        public void SoftwareVersionConfigurationTest()
        {
            // TODO: unit test for the property 'SoftwareVersionConfiguration'
        }
        /// <summary>
        /// Test the property 'FullSoftwareVersion'
        /// </summary>
        [Test]
        public void FullSoftwareVersionTest()
        {
            // TODO: unit test for the property 'FullSoftwareVersion'
        }
        /// <summary>
        /// Test the property 'PairingId'
        /// </summary>
        [Test]
        public void PairingIdTest()
        {
            // TODO: unit test for the property 'PairingId'
        }
        /// <summary>
        /// Test the property 'Fingerprint'
        /// </summary>
        [Test]
        public void FingerprintTest()
        {
            // TODO: unit test for the property 'Fingerprint'
        }
        /// <summary>
        /// Test the property 'FingerprintHint'
        /// </summary>
        [Test]
        public void FingerprintHintTest()
        {
            // TODO: unit test for the property 'FingerprintHint'
        }
        /// <summary>
        /// Test the property 'CurrentVersion'
        /// </summary>
        [Test]
        public void CurrentVersionTest()
        {
            // TODO: unit test for the property 'CurrentVersion'
        }
        /// <summary>
        /// Test the property 'StagedVersion'
        /// </summary>
        [Test]
        public void StagedVersionTest()
        {
            // TODO: unit test for the property 'StagedVersion'
        }
        /// <summary>
        /// Test the property 'Patch'
        /// </summary>
        [Test]
        public void PatchTest()
        {
            // TODO: unit test for the property 'Patch'
        }
        /// <summary>
        /// Test the property 'StatusCode'
        /// </summary>
        [Test]
        public void StatusCodeTest()
        {
            // TODO: unit test for the property 'StatusCode'
        }
        /// <summary>
        /// Test the property 'EdgeGroup'
        /// </summary>
        [Test]
        public void EdgeGroupTest()
        {
            // TODO: unit test for the property 'EdgeGroup'
        }
        /// <summary>
        /// Test the property 'Site'
        /// </summary>
        [Test]
        public void SiteTest()
        {
            // TODO: unit test for the property 'Site'
        }
        /// <summary>
        /// Test the property 'SoftwareStatus'
        /// </summary>
        [Test]
        public void SoftwareStatusTest()
        {
            // TODO: unit test for the property 'SoftwareStatus'
        }
        /// <summary>
        /// Test the property 'OnlineStatus'
        /// </summary>
        [Test]
        public void OnlineStatusTest()
        {
            // TODO: unit test for the property 'OnlineStatus'
        }
        /// <summary>
        /// Test the property 'SerialNumber'
        /// </summary>
        [Test]
        public void SerialNumberTest()
        {
            // TODO: unit test for the property 'SerialNumber'
        }
        /// <summary>
        /// Test the property 'PhysicalEdge'
        /// </summary>
        [Test]
        public void PhysicalEdgeTest()
        {
            // TODO: unit test for the property 'PhysicalEdge'
        }
        /// <summary>
        /// Test the property 'Managed'
        /// </summary>
        [Test]
        public void ManagedTest()
        {
            // TODO: unit test for the property 'Managed'
        }
        /// <summary>
        /// Test the property 'EdgeDeploymentType'
        /// </summary>
        [Test]
        public void EdgeDeploymentTypeTest()
        {
            // TODO: unit test for the property 'EdgeDeploymentType'
        }
        /// <summary>
        /// Test the property 'SelfUri'
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri'
        }

    }

}
