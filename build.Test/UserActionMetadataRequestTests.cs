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
    ///  Class for testing UserActionMetadataRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UserActionMetadataRequestTests
    {
        private UserActionMetadataRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserActionMetadataRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserActionMetadataRequest
        /// </summary>
        [Test]
        public void UserActionMetadataRequestInstanceTest()
        {
            Assert.IsInstanceOf<UserActionMetadataRequest> (instance, "instance is a UserActionMetadataRequest");
        }

        /// <summary>
        /// Test the property 'Format'
        /// </summary>
        [Test]
        public void FormatTest()
        {
            // TODO: unit test for the property 'Format'
        }
        /// <summary>
        /// Test the property 'Method'
        /// </summary>
        [Test]
        public void MethodTest()
        {
            // TODO: unit test for the property 'Method'
        }
        /// <summary>
        /// Test the property 'InputSchemaUri'
        /// </summary>
        [Test]
        public void InputSchemaUriTest()
        {
            // TODO: unit test for the property 'InputSchemaUri'
        }
        /// <summary>
        /// Test the property 'SuccessSchemaUri'
        /// </summary>
        [Test]
        public void SuccessSchemaUriTest()
        {
            // TODO: unit test for the property 'SuccessSchemaUri'
        }
        /// <summary>
        /// Test the property 'InputSchema'
        /// </summary>
        [Test]
        public void InputSchemaTest()
        {
            // TODO: unit test for the property 'InputSchema'
        }
        /// <summary>
        /// Test the property 'SuccessSchema'
        /// </summary>
        [Test]
        public void SuccessSchemaTest()
        {
            // TODO: unit test for the property 'SuccessSchema'
        }

    }

}
