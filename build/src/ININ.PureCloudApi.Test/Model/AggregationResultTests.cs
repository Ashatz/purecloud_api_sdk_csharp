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
    ///  Class for testing AggregationResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AggregationResultTests
    {
        private AggregationResult instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AggregationResult();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AggregationResult
        /// </summary>
        [Test]
        public void AggregationResultInstanceTest()
        {
            Assert.IsInstanceOf<AggregationResult> (instance, "instance is a AggregationResult");
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Dimension'
        /// </summary>
        [Test]
        public void DimensionTest()
        {
            // TODO: unit test for the property 'Dimension'
        }
        /// <summary>
        /// Test the property 'Metric'
        /// </summary>
        [Test]
        public void MetricTest()
        {
            // TODO: unit test for the property 'Metric'
        }
        /// <summary>
        /// Test the property 'Count'
        /// </summary>
        [Test]
        public void CountTest()
        {
            // TODO: unit test for the property 'Count'
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