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
    ///  Class for testing Adjacents
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AdjacentsTests
    {
        private Adjacents instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Adjacents();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Adjacents
        /// </summary>
        [Test]
        public void AdjacentsInstanceTest()
        {
            Assert.IsInstanceOf<Adjacents> (instance, "instance is a Adjacents");
        }

        /// <summary>
        /// Test the property 'Superiors'
        /// </summary>
        [Test]
        public void SuperiorsTest()
        {
            // TODO: unit test for the property 'Superiors'
        }
        /// <summary>
        /// Test the property 'Siblings'
        /// </summary>
        [Test]
        public void SiblingsTest()
        {
            // TODO: unit test for the property 'Siblings'
        }
        /// <summary>
        /// Test the property 'DirectReports'
        /// </summary>
        [Test]
        public void DirectReportsTest()
        {
            // TODO: unit test for the property 'DirectReports'
        }

    }

}