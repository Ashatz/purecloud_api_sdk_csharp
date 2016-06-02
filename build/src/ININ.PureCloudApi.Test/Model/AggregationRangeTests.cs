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
    ///  Class for testing AggregationRange
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AggregationRangeTests
    {
        private AggregationRange instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AggregationRange();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AggregationRange
        /// </summary>
        [Test]
        public void AggregationRangeInstanceTest()
        {
            Assert.IsInstanceOf<AggregationRange> (instance, "instance is a AggregationRange");
        }

        /// <summary>
        /// Test the property 'Gte'
        /// </summary>
        [Test]
        public void GteTest()
        {
            // TODO: unit test for the property 'Gte'
        }
        /// <summary>
        /// Test the property 'Lt'
        /// </summary>
        [Test]
        public void LtTest()
        {
            // TODO: unit test for the property 'Lt'
        }

    }

}
