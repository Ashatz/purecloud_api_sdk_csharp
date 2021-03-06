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
    ///  Class for testing TransformLens
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TransformLensTests
    {
        private TransformLens instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TransformLens();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransformLens
        /// </summary>
        [Test]
        public void TransformLensInstanceTest()
        {
            Assert.IsInstanceOf<TransformLens> (instance, "instance is a TransformLens");
        }

        /// <summary>
        /// Test the property 'Replace'
        /// </summary>
        [Test]
        public void ReplaceTest()
        {
            // TODO: unit test for the property 'Replace'
        }
        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO: unit test for the property 'Value'
        }

    }

}
