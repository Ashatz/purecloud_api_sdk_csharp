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
    ///  Class for testing ResponseQueryRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ResponseQueryRequestTests
    {
        private ResponseQueryRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ResponseQueryRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ResponseQueryRequest
        /// </summary>
        [Test]
        public void ResponseQueryRequestInstanceTest()
        {
            Assert.IsInstanceOf<ResponseQueryRequest> (instance, "instance is a ResponseQueryRequest");
        }

        /// <summary>
        /// Test the property 'QueryPhrase'
        /// </summary>
        [Test]
        public void QueryPhraseTest()
        {
            // TODO: unit test for the property 'QueryPhrase'
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
        /// Test the property 'Filters'
        /// </summary>
        [Test]
        public void FiltersTest()
        {
            // TODO: unit test for the property 'Filters'
        }

    }

}
