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
    ///  Class for testing AggregationResultEntry
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AggregationResultEntryTests
    {
        private AggregationResultEntry instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AggregationResultEntry();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AggregationResultEntry
        /// </summary>
        [Test]
        public void AggregationResultEntryInstanceTest()
        {
            Assert.IsInstanceOf<AggregationResultEntry> (instance, "instance is a AggregationResultEntry");
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
        /// Test the property 'Value'
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO: unit test for the property 'Value'
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
