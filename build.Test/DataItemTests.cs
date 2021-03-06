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
    ///  Class for testing DataItem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DataItemTests
    {
        private DataItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DataItem();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DataItem
        /// </summary>
        [Test]
        public void DataItemInstanceTest()
        {
            Assert.IsInstanceOf<DataItem> (instance, "instance is a DataItem");
        }

        /// <summary>
        /// Test the property 'DataItemId'
        /// </summary>
        [Test]
        public void DataItemIdTest()
        {
            // TODO: unit test for the property 'DataItemId'
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
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type'
        }

    }

}
