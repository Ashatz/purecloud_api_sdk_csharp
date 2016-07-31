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
    ///  Class for testing FaxStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FaxStatusTests
    {
        private FaxStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FaxStatus();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FaxStatus
        /// </summary>
        [Test]
        public void FaxStatusInstanceTest()
        {
            Assert.IsInstanceOf<FaxStatus> (instance, "instance is a FaxStatus");
        }

        /// <summary>
        /// Test the property 'Direction'
        /// </summary>
        [Test]
        public void DirectionTest()
        {
            // TODO: unit test for the property 'Direction'
        }
        /// <summary>
        /// Test the property 'ExpectedPages'
        /// </summary>
        [Test]
        public void ExpectedPagesTest()
        {
            // TODO: unit test for the property 'ExpectedPages'
        }
        /// <summary>
        /// Test the property 'ActivePage'
        /// </summary>
        [Test]
        public void ActivePageTest()
        {
            // TODO: unit test for the property 'ActivePage'
        }
        /// <summary>
        /// Test the property 'LinesTransmitted'
        /// </summary>
        [Test]
        public void LinesTransmittedTest()
        {
            // TODO: unit test for the property 'LinesTransmitted'
        }
        /// <summary>
        /// Test the property 'BytesTransmitted'
        /// </summary>
        [Test]
        public void BytesTransmittedTest()
        {
            // TODO: unit test for the property 'BytesTransmitted'
        }
        /// <summary>
        /// Test the property 'BaudRate'
        /// </summary>
        [Test]
        public void BaudRateTest()
        {
            // TODO: unit test for the property 'BaudRate'
        }
        /// <summary>
        /// Test the property 'PageErrors'
        /// </summary>
        [Test]
        public void PageErrorsTest()
        {
            // TODO: unit test for the property 'PageErrors'
        }
        /// <summary>
        /// Test the property 'LineErrors'
        /// </summary>
        [Test]
        public void LineErrorsTest()
        {
            // TODO: unit test for the property 'LineErrors'
        }

    }

}
