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
    ///  Class for testing FacetStatistics
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FacetStatisticsTests
    {
        private FacetStatistics instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FacetStatistics();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FacetStatistics
        /// </summary>
        [Test]
        public void FacetStatisticsInstanceTest()
        {
            Assert.IsInstanceOf<FacetStatistics> (instance, "instance is a FacetStatistics");
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
        /// Test the property 'Min'
        /// </summary>
        [Test]
        public void MinTest()
        {
            // TODO: unit test for the property 'Min'
        }
        /// <summary>
        /// Test the property 'Max'
        /// </summary>
        [Test]
        public void MaxTest()
        {
            // TODO: unit test for the property 'Max'
        }
        /// <summary>
        /// Test the property 'Mean'
        /// </summary>
        [Test]
        public void MeanTest()
        {
            // TODO: unit test for the property 'Mean'
        }
        /// <summary>
        /// Test the property 'StdDeviation'
        /// </summary>
        [Test]
        public void StdDeviationTest()
        {
            // TODO: unit test for the property 'StdDeviation'
        }
        /// <summary>
        /// Test the property 'DateMin'
        /// </summary>
        [Test]
        public void DateMinTest()
        {
            // TODO: unit test for the property 'DateMin'
        }
        /// <summary>
        /// Test the property 'DateMax'
        /// </summary>
        [Test]
        public void DateMaxTest()
        {
            // TODO: unit test for the property 'DateMax'
        }

    }

}
