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
    ///  Class for testing ForecastFilterAttributes
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ForecastFilterAttributesTests
    {
        private ForecastFilterAttributes instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ForecastFilterAttributes();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ForecastFilterAttributes
        /// </summary>
        [Test]
        public void ForecastFilterAttributesInstanceTest()
        {
            Assert.IsInstanceOf<ForecastFilterAttributes> (instance, "instance is a ForecastFilterAttributes");
        }

        /// <summary>
        /// Test the property 'Languages'
        /// </summary>
        [Test]
        public void LanguagesTest()
        {
            // TODO: unit test for the property 'Languages'
        }
        /// <summary>
        /// Test the property 'QueueIds'
        /// </summary>
        [Test]
        public void QueueIdsTest()
        {
            // TODO: unit test for the property 'QueueIds'
        }
        /// <summary>
        /// Test the property 'MediaTypes'
        /// </summary>
        [Test]
        public void MediaTypesTest()
        {
            // TODO: unit test for the property 'MediaTypes'
        }

    }

}
