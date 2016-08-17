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
    ///  Class for testing ConversationNotificationDisconnectReason
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ConversationNotificationDisconnectReasonTests
    {
        private ConversationNotificationDisconnectReason instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConversationNotificationDisconnectReason();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConversationNotificationDisconnectReason
        /// </summary>
        [Test]
        public void ConversationNotificationDisconnectReasonInstanceTest()
        {
            Assert.IsInstanceOf<ConversationNotificationDisconnectReason> (instance, "instance is a ConversationNotificationDisconnectReason");
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
        /// Test the property 'Code'
        /// </summary>
        [Test]
        public void CodeTest()
        {
            // TODO: unit test for the property 'Code'
        }
        /// <summary>
        /// Test the property 'Phrase'
        /// </summary>
        [Test]
        public void PhraseTest()
        {
            // TODO: unit test for the property 'Phrase'
        }

    }

}