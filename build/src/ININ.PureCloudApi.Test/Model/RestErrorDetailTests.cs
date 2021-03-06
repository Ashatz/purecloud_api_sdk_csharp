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
    ///  Class for testing RestErrorDetail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RestErrorDetailTests
    {
        private RestErrorDetail instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RestErrorDetail();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RestErrorDetail
        /// </summary>
        [Test]
        public void RestErrorDetailInstanceTest()
        {
            Assert.IsInstanceOf<RestErrorDetail> (instance, "instance is a RestErrorDetail");
        }

        /// <summary>
        /// Test the property 'Error'
        /// </summary>
        [Test]
        public void ErrorTest()
        {
            // TODO: unit test for the property 'Error'
        }
        /// <summary>
        /// Test the property 'Details'
        /// </summary>
        [Test]
        public void DetailsTest()
        {
            // TODO: unit test for the property 'Details'
        }

    }

}
