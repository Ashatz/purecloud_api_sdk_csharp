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
    ///  Class for testing CodesRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CodesRequestTests
    {
        private CodesRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CodesRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CodesRequest
        /// </summary>
        [Test]
        public void CodesRequestInstanceTest()
        {
            Assert.IsInstanceOf<CodesRequest> (instance, "instance is a CodesRequest");
        }

        /// <summary>
        /// Test the property 'OrganizationId'
        /// </summary>
        [Test]
        public void OrganizationIdTest()
        {
            // TODO: unit test for the property 'OrganizationId'
        }
        /// <summary>
        /// Test the property 'AddCommunicationCode'
        /// </summary>
        [Test]
        public void AddCommunicationCodeTest()
        {
            // TODO: unit test for the property 'AddCommunicationCode'
        }

    }

}
