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
    ///  Class for testing CurrentUserScheduleRequestBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CurrentUserScheduleRequestBodyTests
    {
        private CurrentUserScheduleRequestBody instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CurrentUserScheduleRequestBody();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CurrentUserScheduleRequestBody
        /// </summary>
        [Test]
        public void CurrentUserScheduleRequestBodyInstanceTest()
        {
            Assert.IsInstanceOf<CurrentUserScheduleRequestBody> (instance, "instance is a CurrentUserScheduleRequestBody");
        }

        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Test]
        public void StartDateTest()
        {
            // TODO: unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'EndDate'
        /// </summary>
        [Test]
        public void EndDateTest()
        {
            // TODO: unit test for the property 'EndDate'
        }

    }

}
