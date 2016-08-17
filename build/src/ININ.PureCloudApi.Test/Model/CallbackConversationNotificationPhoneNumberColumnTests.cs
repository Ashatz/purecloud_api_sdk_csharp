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
    ///  Class for testing CallbackConversationNotificationPhoneNumberColumn
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CallbackConversationNotificationPhoneNumberColumnTests
    {
        private CallbackConversationNotificationPhoneNumberColumn instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CallbackConversationNotificationPhoneNumberColumn();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CallbackConversationNotificationPhoneNumberColumn
        /// </summary>
        [Test]
        public void CallbackConversationNotificationPhoneNumberColumnInstanceTest()
        {
            Assert.IsInstanceOf<CallbackConversationNotificationPhoneNumberColumn> (instance, "instance is a CallbackConversationNotificationPhoneNumberColumn");
        }

        /// <summary>
        /// Test the property 'ColumnName'
        /// </summary>
        [Test]
        public void ColumnNameTest()
        {
            // TODO: unit test for the property 'ColumnName'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type'
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
