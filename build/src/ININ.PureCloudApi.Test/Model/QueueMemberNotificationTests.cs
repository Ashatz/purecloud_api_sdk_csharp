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
    ///  Class for testing QueueMemberNotification
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class QueueMemberNotificationTests
    {
        private QueueMemberNotification instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new QueueMemberNotification();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of QueueMemberNotification
        /// </summary>
        [Test]
        public void QueueMemberNotificationInstanceTest()
        {
            Assert.IsInstanceOf<QueueMemberNotification> (instance, "instance is a QueueMemberNotification");
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
        /// Test the property 'QueueId'
        /// </summary>
        [Test]
        public void QueueIdTest()
        {
            // TODO: unit test for the property 'QueueId'
        }
        /// <summary>
        /// Test the property 'Joined'
        /// </summary>
        [Test]
        public void JoinedTest()
        {
            // TODO: unit test for the property 'Joined'
        }
        /// <summary>
        /// Test the property 'AdditionalProperties'
        /// </summary>
        [Test]
        public void AdditionalPropertiesTest()
        {
            // TODO: unit test for the property 'AdditionalProperties'
        }

    }

}
