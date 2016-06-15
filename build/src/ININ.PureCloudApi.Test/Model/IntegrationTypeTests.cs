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
    ///  Class for testing IntegrationType
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class IntegrationTypeTests
    {
        private IntegrationType instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new IntegrationType();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IntegrationType
        /// </summary>
        [Test]
        public void IntegrationTypeInstanceTest()
        {
            Assert.IsInstanceOf<IntegrationType> (instance, "instance is a IntegrationType");
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
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Provider'
        /// </summary>
        [Test]
        public void ProviderTest()
        {
            // TODO: unit test for the property 'Provider'
        }
        /// <summary>
        /// Test the property 'Images'
        /// </summary>
        [Test]
        public void ImagesTest()
        {
            // TODO: unit test for the property 'Images'
        }
        /// <summary>
        /// Test the property 'ConfigPropertiesSchemaUri'
        /// </summary>
        [Test]
        public void ConfigPropertiesSchemaUriTest()
        {
            // TODO: unit test for the property 'ConfigPropertiesSchemaUri'
        }
        /// <summary>
        /// Test the property 'ConfigAdvancedSchemaUri'
        /// </summary>
        [Test]
        public void ConfigAdvancedSchemaUriTest()
        {
            // TODO: unit test for the property 'ConfigAdvancedSchemaUri'
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