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
    ///  Class for testing CallbackConversationNotificationErrorInfoDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CallbackConversationNotificationErrorInfoDetailsTests
    {
        private CallbackConversationNotificationErrorInfoDetails instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CallbackConversationNotificationErrorInfoDetails();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CallbackConversationNotificationErrorInfoDetails
        /// </summary>
        [Test]
        public void CallbackConversationNotificationErrorInfoDetailsInstanceTest()
        {
            Assert.IsInstanceOf<CallbackConversationNotificationErrorInfoDetails> (instance, "instance is a CallbackConversationNotificationErrorInfoDetails");
        }

        /// <summary>
        /// Test the property 'ErrorCode'
        /// </summary>
        [Test]
        public void ErrorCodeTest()
        {
            // TODO: unit test for the property 'ErrorCode'
        }
        /// <summary>
        /// Test the property 'FieldName'
        /// </summary>
        [Test]
        public void FieldNameTest()
        {
            // TODO: unit test for the property 'FieldName'
        }
        /// <summary>
        /// Test the property 'EntityId'
        /// </summary>
        [Test]
        public void EntityIdTest()
        {
            // TODO: unit test for the property 'EntityId'
        }

    }

}
