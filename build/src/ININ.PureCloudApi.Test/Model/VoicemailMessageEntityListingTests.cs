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
    ///  Class for testing VoicemailMessageEntityListing
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class VoicemailMessageEntityListingTests
    {
        private VoicemailMessageEntityListing instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VoicemailMessageEntityListing();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VoicemailMessageEntityListing
        /// </summary>
        [Test]
        public void VoicemailMessageEntityListingInstanceTest()
        {
            Assert.IsInstanceOf<VoicemailMessageEntityListing> (instance, "instance is a VoicemailMessageEntityListing");
        }

        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Test]
        public void TotalTest()
        {
            // TODO: unit test for the property 'Total'
        }
        /// <summary>
        /// Test the property 'Entities'
        /// </summary>
        [Test]
        public void EntitiesTest()
        {
            // TODO: unit test for the property 'Entities'
        }
        /// <summary>
        /// Test the property 'SelfUri'
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri'
        }

    }

}