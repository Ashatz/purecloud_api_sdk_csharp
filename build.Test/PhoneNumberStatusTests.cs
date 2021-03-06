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
    ///  Class for testing PhoneNumberStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PhoneNumberStatusTests
    {
        private PhoneNumberStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PhoneNumberStatus();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PhoneNumberStatus
        /// </summary>
        [Test]
        public void PhoneNumberStatusInstanceTest()
        {
            Assert.IsInstanceOf<PhoneNumberStatus> (instance, "instance is a PhoneNumberStatus");
        }

        /// <summary>
        /// Test the property 'Callable'
        /// </summary>
        [Test]
        public void CallableTest()
        {
            // TODO: unit test for the property 'Callable'
        }

    }

}
