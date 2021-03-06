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
    ///  Class for testing SubscriberResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SubscriberResponseTests
    {
        private SubscriberResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SubscriberResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubscriberResponse
        /// </summary>
        [Test]
        public void SubscriberResponseInstanceTest()
        {
            Assert.IsInstanceOf<SubscriberResponse> (instance, "instance is a SubscriberResponse");
        }

        /// <summary>
        /// Test the property 'MessageReturned'
        /// </summary>
        [Test]
        public void MessageReturnedTest()
        {
            // TODO: unit test for the property 'MessageReturned'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status'
        }

    }

}
