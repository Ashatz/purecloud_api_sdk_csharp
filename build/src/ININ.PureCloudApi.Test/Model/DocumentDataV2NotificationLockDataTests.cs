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
    ///  Class for testing DocumentDataV2NotificationLockData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DocumentDataV2NotificationLockDataTests
    {
        private DocumentDataV2NotificationLockData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DocumentDataV2NotificationLockData();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DocumentDataV2NotificationLockData
        /// </summary>
        [Test]
        public void DocumentDataV2NotificationLockDataInstanceTest()
        {
            Assert.IsInstanceOf<DocumentDataV2NotificationLockData> (instance, "instance is a DocumentDataV2NotificationLockData");
        }

        /// <summary>
        /// Test the property 'LockedBy'
        /// </summary>
        [Test]
        public void LockedByTest()
        {
            // TODO: unit test for the property 'LockedBy'
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
        /// Test the property 'DateExpires'
        /// </summary>
        [Test]
        public void DateExpiresTest()
        {
            // TODO: unit test for the property 'DateExpires'
        }

    }

}
