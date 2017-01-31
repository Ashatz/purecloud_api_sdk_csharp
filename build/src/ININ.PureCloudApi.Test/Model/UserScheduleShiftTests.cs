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
    ///  Class for testing UserScheduleShift
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UserScheduleShiftTests
    {
        private UserScheduleShift instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserScheduleShift();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserScheduleShift
        /// </summary>
        [Test]
        public void UserScheduleShiftInstanceTest()
        {
            Assert.IsInstanceOf<UserScheduleShift> (instance, "instance is a UserScheduleShift");
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
        /// Test the property 'LengthInMinutes'
        /// </summary>
        [Test]
        public void LengthInMinutesTest()
        {
            // TODO: unit test for the property 'LengthInMinutes'
        }
        /// <summary>
        /// Test the property 'Activities'
        /// </summary>
        [Test]
        public void ActivitiesTest()
        {
            // TODO: unit test for the property 'Activities'
        }

    }

}
