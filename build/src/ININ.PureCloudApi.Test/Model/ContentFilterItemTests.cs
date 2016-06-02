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
    ///  Class for testing ContentFilterItem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ContentFilterItemTests
    {
        private ContentFilterItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContentFilterItem();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContentFilterItem
        /// </summary>
        [Test]
        public void ContentFilterItemInstanceTest()
        {
            Assert.IsInstanceOf<ContentFilterItem> (instance, "instance is a ContentFilterItem");
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
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property '_Operator'
        /// </summary>
        [Test]
        public void _OperatorTest()
        {
            // TODO: unit test for the property '_Operator'
        }
        /// <summary>
        /// Test the property 'Values'
        /// </summary>
        [Test]
        public void ValuesTest()
        {
            // TODO: unit test for the property 'Values'
        }

    }

}
