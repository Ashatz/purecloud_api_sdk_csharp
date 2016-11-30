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
    ///  Class for testing AvailableTranslations
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AvailableTranslationsTests
    {
        private AvailableTranslations instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AvailableTranslations();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AvailableTranslations
        /// </summary>
        [Test]
        public void AvailableTranslationsInstanceTest()
        {
            Assert.IsInstanceOf<AvailableTranslations> (instance, "instance is a AvailableTranslations");
        }

        /// <summary>
        /// Test the property 'OrgSpecific'
        /// </summary>
        [Test]
        public void OrgSpecificTest()
        {
            // TODO: unit test for the property 'OrgSpecific'
        }
        /// <summary>
        /// Test the property 'Builtin'
        /// </summary>
        [Test]
        public void BuiltinTest()
        {
            // TODO: unit test for the property 'Builtin'
        }

    }

}