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
    ///  Class for testing LocationEmergencyNumber
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LocationEmergencyNumberTests
    {
        private LocationEmergencyNumber instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LocationEmergencyNumber();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LocationEmergencyNumber
        /// </summary>
        [Test]
        public void LocationEmergencyNumberInstanceTest()
        {
            Assert.IsInstanceOf<LocationEmergencyNumber> (instance, "instance is a LocationEmergencyNumber");
        }

        /// <summary>
        /// Test the property 'E164'
        /// </summary>
        [Test]
        public void E164Test()
        {
            // TODO: unit test for the property 'E164'
        }
        /// <summary>
        /// Test the property 'Number'
        /// </summary>
        [Test]
        public void NumberTest()
        {
            // TODO: unit test for the property 'Number'
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
