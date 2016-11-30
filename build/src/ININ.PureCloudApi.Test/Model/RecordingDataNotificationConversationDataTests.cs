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
    ///  Class for testing RecordingDataNotificationConversationData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RecordingDataNotificationConversationDataTests
    {
        private RecordingDataNotificationConversationData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RecordingDataNotificationConversationData();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RecordingDataNotificationConversationData
        /// </summary>
        [Test]
        public void RecordingDataNotificationConversationDataInstanceTest()
        {
            Assert.IsInstanceOf<RecordingDataNotificationConversationData> (instance, "instance is a RecordingDataNotificationConversationData");
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
