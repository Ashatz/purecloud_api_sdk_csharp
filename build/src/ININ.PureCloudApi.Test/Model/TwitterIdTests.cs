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
    ///  Class for testing TwitterId
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TwitterIdTests
    {
        private TwitterId instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TwitterId();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TwitterId
        /// </summary>
        [Test]
        public void TwitterIdInstanceTest()
        {
            Assert.IsInstanceOf<TwitterId> (instance, "instance is a TwitterId");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'ScreenName'
        /// </summary>
        [Test]
        public void ScreenNameTest()
        {
            // TODO: unit test for the property 'ScreenName'
        }
        /// <summary>
        /// Test the property 'Verified'
        /// </summary>
        [Test]
        public void VerifiedTest()
        {
            // TODO: unit test for the property 'Verified'
        }
        /// <summary>
        /// Test the property 'ProfileUrl'
        /// </summary>
        [Test]
        public void ProfileUrlTest()
        {
            // TODO: unit test for the property 'ProfileUrl'
        }

    }

}
