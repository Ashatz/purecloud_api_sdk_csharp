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
    ///  Class for testing IndexedTransform
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class IndexedTransformTests
    {
        private IndexedTransform instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new IndexedTransform();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IndexedTransform
        /// </summary>
        [Test]
        public void IndexedTransformInstanceTest()
        {
            Assert.IsInstanceOf<IndexedTransform> (instance, "instance is a IndexedTransform");
        }

        /// <summary>
        /// Test the property 'Replaces'
        /// </summary>
        [Test]
        public void ReplacesTest()
        {
            // TODO: unit test for the property 'Replaces'
        }
        /// <summary>
        /// Test the property 'EntityPath'
        /// </summary>
        [Test]
        public void EntityPathTest()
        {
            // TODO: unit test for the property 'EntityPath'
        }
        /// <summary>
        /// Test the property 'Index'
        /// </summary>
        [Test]
        public void IndexTest()
        {
            // TODO: unit test for the property 'Index'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name'
        }

    }

}
