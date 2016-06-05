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
    ///  Class for testing EmbeddedSignatureView
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class EmbeddedSignatureViewTests
    {
        private EmbeddedSignatureView instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EmbeddedSignatureView();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EmbeddedSignatureView
        /// </summary>
        [Test]
        public void EmbeddedSignatureViewInstanceTest()
        {
            Assert.IsInstanceOf<EmbeddedSignatureView> (instance, "instance is a EmbeddedSignatureView");
        }

        /// <summary>
        /// Test the property 'View'
        /// </summary>
        [Test]
        public void ViewTest()
        {
            // TODO: unit test for the property 'View'
        }
        /// <summary>
        /// Test the property 'EnvelopeId'
        /// </summary>
        [Test]
        public void EnvelopeIdTest()
        {
            // TODO: unit test for the property 'EnvelopeId'
        }

    }

}
