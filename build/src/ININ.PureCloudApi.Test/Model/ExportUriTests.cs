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
    ///  Class for testing ExportUri
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ExportUriTests
    {
        private ExportUri instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExportUri();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExportUri
        /// </summary>
        [Test]
        public void ExportUriInstanceTest()
        {
            Assert.IsInstanceOf<ExportUri> (instance, "instance is a ExportUri");
        }

        /// <summary>
        /// Test the property 'Uri'
        /// </summary>
        [Test]
        public void UriTest()
        {
            // TODO: unit test for the property 'Uri'
        }
        /// <summary>
        /// Test the property 'ExportTimestamp'
        /// </summary>
        [Test]
        public void ExportTimestampTest()
        {
            // TODO: unit test for the property 'ExportTimestamp'
        }

    }

}
