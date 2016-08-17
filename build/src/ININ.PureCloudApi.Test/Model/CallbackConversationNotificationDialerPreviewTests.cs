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
    ///  Class for testing CallbackConversationNotificationDialerPreview
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CallbackConversationNotificationDialerPreviewTests
    {
        private CallbackConversationNotificationDialerPreview instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CallbackConversationNotificationDialerPreview();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CallbackConversationNotificationDialerPreview
        /// </summary>
        [Test]
        public void CallbackConversationNotificationDialerPreviewInstanceTest()
        {
            Assert.IsInstanceOf<CallbackConversationNotificationDialerPreview> (instance, "instance is a CallbackConversationNotificationDialerPreview");
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
        /// Test the property 'ContactId'
        /// </summary>
        [Test]
        public void ContactIdTest()
        {
            // TODO: unit test for the property 'ContactId'
        }
        /// <summary>
        /// Test the property 'ContactListId'
        /// </summary>
        [Test]
        public void ContactListIdTest()
        {
            // TODO: unit test for the property 'ContactListId'
        }
        /// <summary>
        /// Test the property 'CampaignId'
        /// </summary>
        [Test]
        public void CampaignIdTest()
        {
            // TODO: unit test for the property 'CampaignId'
        }
        /// <summary>
        /// Test the property 'PhoneNumberColumns'
        /// </summary>
        [Test]
        public void PhoneNumberColumnsTest()
        {
            // TODO: unit test for the property 'PhoneNumberColumns'
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
