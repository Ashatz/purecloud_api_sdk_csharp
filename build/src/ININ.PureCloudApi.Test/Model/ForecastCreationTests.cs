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
    ///  Class for testing ForecastCreation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ForecastCreationTests
    {
        private ForecastCreation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ForecastCreation();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ForecastCreation
        /// </summary>
        [Test]
        public void ForecastCreationInstanceTest()
        {
            Assert.IsInstanceOf<ForecastCreation> (instance, "instance is a ForecastCreation");
        }

        /// <summary>
        /// Test the property 'NumberOfPeriods'
        /// </summary>
        [Test]
        public void NumberOfPeriodsTest()
        {
            // TODO: unit test for the property 'NumberOfPeriods'
        }
        /// <summary>
        /// Test the property 'PeriodFrequency'
        /// </summary>
        [Test]
        public void PeriodFrequencyTest()
        {
            // TODO: unit test for the property 'PeriodFrequency'
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
        /// Test the property 'Metrics'
        /// </summary>
        [Test]
        public void MetricsTest()
        {
            // TODO: unit test for the property 'Metrics'
        }
        /// <summary>
        /// Test the property 'ManagementUnitId'
        /// </summary>
        [Test]
        public void ManagementUnitIdTest()
        {
            // TODO: unit test for the property 'ManagementUnitId'
        }
        /// <summary>
        /// Test the property 'CopiedForecastId'
        /// </summary>
        [Test]
        public void CopiedForecastIdTest()
        {
            // TODO: unit test for the property 'CopiedForecastId'
        }

    }

}