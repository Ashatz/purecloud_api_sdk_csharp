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
    ///  Class for testing ConversationNotificationAddress
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ConversationNotificationAddressTests
    {
        private ConversationNotificationAddress instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConversationNotificationAddress();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConversationNotificationAddress
        /// </summary>
        [Test]
        public void ConversationNotificationAddressInstanceTest()
        {
            Assert.IsInstanceOf<ConversationNotificationAddress> (instance, "instance is a ConversationNotificationAddress");
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
        /// Test the property 'NameRaw'
        /// </summary>
        [Test]
        public void NameRawTest()
        {
            // TODO: unit test for the property 'NameRaw'
        }
        /// <summary>
        /// Test the property 'AddressNormalized'
        /// </summary>
        [Test]
        public void AddressNormalizedTest()
        {
            // TODO: unit test for the property 'AddressNormalized'
        }
        /// <summary>
        /// Test the property 'AddressRaw'
        /// </summary>
        [Test]
        public void AddressRawTest()
        {
            // TODO: unit test for the property 'AddressRaw'
        }
        /// <summary>
        /// Test the property 'AddressDisplayable'
        /// </summary>
        [Test]
        public void AddressDisplayableTest()
        {
            // TODO: unit test for the property 'AddressDisplayable'
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