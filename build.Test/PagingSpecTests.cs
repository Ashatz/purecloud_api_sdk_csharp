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
    ///  Class for testing PagingSpec
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PagingSpecTests
    {
        private PagingSpec instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PagingSpec();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PagingSpec
        /// </summary>
        [Test]
        public void PagingSpecInstanceTest()
        {
            Assert.IsInstanceOf<PagingSpec> (instance, "instance is a PagingSpec");
        }

        /// <summary>
        /// Test the property 'PageSize'
        /// </summary>
        [Test]
        public void PageSizeTest()
        {
            // TODO: unit test for the property 'PageSize'
        }
        /// <summary>
        /// Test the property 'PageNumber'
        /// </summary>
        [Test]
        public void PageNumberTest()
        {
            // TODO: unit test for the property 'PageNumber'
        }

    }

}
