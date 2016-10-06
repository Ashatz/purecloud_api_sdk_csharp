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
    ///  Class for testing UserConversationSummaryNotificationMediaSummary
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UserConversationSummaryNotificationMediaSummaryTests
    {
        private UserConversationSummaryNotificationMediaSummary instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserConversationSummaryNotificationMediaSummary();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserConversationSummaryNotificationMediaSummary
        /// </summary>
        [Test]
        public void UserConversationSummaryNotificationMediaSummaryInstanceTest()
        {
            Assert.IsInstanceOf<UserConversationSummaryNotificationMediaSummary> (instance, "instance is a UserConversationSummaryNotificationMediaSummary");
        }

        /// <summary>
        /// Test the property 'ContactCenter'
        /// </summary>
        [Test]
        public void ContactCenterTest()
        {
            // TODO: unit test for the property 'ContactCenter'
        }
        /// <summary>
        /// Test the property 'Enterprise'
        /// </summary>
        [Test]
        public void EnterpriseTest()
        {
            // TODO: unit test for the property 'Enterprise'
        }

    }

}
