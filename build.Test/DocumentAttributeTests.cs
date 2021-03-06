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
    ///  Class for testing DocumentAttribute
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DocumentAttributeTests
    {
        private DocumentAttribute instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DocumentAttribute();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DocumentAttribute
        /// </summary>
        [Test]
        public void DocumentAttributeInstanceTest()
        {
            Assert.IsInstanceOf<DocumentAttribute> (instance, "instance is a DocumentAttribute");
        }

        /// <summary>
        /// Test the property 'Attribute'
        /// </summary>
        [Test]
        public void AttributeTest()
        {
            // TODO: unit test for the property 'Attribute'
        }
        /// <summary>
        /// Test the property 'Values'
        /// </summary>
        [Test]
        public void ValuesTest()
        {
            // TODO: unit test for the property 'Values'
        }

    }

}
