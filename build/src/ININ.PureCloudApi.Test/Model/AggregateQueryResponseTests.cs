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
    ///  Class for testing AggregateQueryResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AggregateQueryResponseTests
    {
        private AggregateQueryResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AggregateQueryResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AggregateQueryResponse
        /// </summary>
        [Test]
        public void AggregateQueryResponseInstanceTest()
        {
            Assert.IsInstanceOf<AggregateQueryResponse> (instance, "instance is a AggregateQueryResponse");
        }

        /// <summary>
        /// Test the property 'Results'
        /// </summary>
        [Test]
        public void ResultsTest()
        {
            // TODO: unit test for the property 'Results'
        }

    }

}
