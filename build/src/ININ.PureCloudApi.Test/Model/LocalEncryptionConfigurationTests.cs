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
    ///  Class for testing LocalEncryptionConfiguration
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LocalEncryptionConfigurationTests
    {
        private LocalEncryptionConfiguration instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LocalEncryptionConfiguration();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LocalEncryptionConfiguration
        /// </summary>
        [Test]
        public void LocalEncryptionConfigurationInstanceTest()
        {
            Assert.IsInstanceOf<LocalEncryptionConfiguration> (instance, "instance is a LocalEncryptionConfiguration");
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
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Test]
        public void UrlTest()
        {
            // TODO: unit test for the property 'Url'
        }
        /// <summary>
        /// Test the property 'ApiId'
        /// </summary>
        [Test]
        public void ApiIdTest()
        {
            // TODO: unit test for the property 'ApiId'
        }
        /// <summary>
        /// Test the property 'ApiKey'
        /// </summary>
        [Test]
        public void ApiKeyTest()
        {
            // TODO: unit test for the property 'ApiKey'
        }
        /// <summary>
        /// Test the property 'SelfUri'
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri'
        }

    }

}