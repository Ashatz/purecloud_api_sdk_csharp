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
    ///  Class for testing App
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AppTests
    {
        private App instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new App();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of App
        /// </summary>
        [Test]
        public void AppInstanceTest()
        {
            Assert.IsInstanceOf<App> (instance, "instance is a App");
        }

        /// <summary>
        /// Test the property 'AppId'
        /// </summary>
        [Test]
        public void AppIdTest()
        {
            // TODO: unit test for the property 'AppId'
        }
        /// <summary>
        /// Test the property 'AppVersion'
        /// </summary>
        [Test]
        public void AppVersionTest()
        {
            // TODO: unit test for the property 'AppVersion'
        }

    }

}