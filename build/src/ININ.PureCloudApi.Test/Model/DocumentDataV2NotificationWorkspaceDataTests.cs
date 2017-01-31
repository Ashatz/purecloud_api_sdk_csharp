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
    ///  Class for testing DocumentDataV2NotificationWorkspaceData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DocumentDataV2NotificationWorkspaceDataTests
    {
        private DocumentDataV2NotificationWorkspaceData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DocumentDataV2NotificationWorkspaceData();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DocumentDataV2NotificationWorkspaceData
        /// </summary>
        [Test]
        public void DocumentDataV2NotificationWorkspaceDataInstanceTest()
        {
            Assert.IsInstanceOf<DocumentDataV2NotificationWorkspaceData> (instance, "instance is a DocumentDataV2NotificationWorkspaceData");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id'
        }

    }

}