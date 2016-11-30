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
    ///  Class for testing DocumentDataNotificationWorkspaceData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DocumentDataNotificationWorkspaceDataTests
    {
        private DocumentDataNotificationWorkspaceData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DocumentDataNotificationWorkspaceData();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DocumentDataNotificationWorkspaceData
        /// </summary>
        [Test]
        public void DocumentDataNotificationWorkspaceDataInstanceTest()
        {
            Assert.IsInstanceOf<DocumentDataNotificationWorkspaceData> (instance, "instance is a DocumentDataNotificationWorkspaceData");
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
