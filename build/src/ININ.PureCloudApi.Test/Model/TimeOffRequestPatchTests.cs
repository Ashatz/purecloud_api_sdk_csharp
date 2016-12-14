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
    ///  Class for testing TimeOffRequestPatch
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TimeOffRequestPatchTests
    {
        private TimeOffRequestPatch instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TimeOffRequestPatch();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TimeOffRequestPatch
        /// </summary>
        [Test]
        public void TimeOffRequestPatchInstanceTest()
        {
            Assert.IsInstanceOf<TimeOffRequestPatch> (instance, "instance is a TimeOffRequestPatch");
        }

        /// <summary>
        /// Test the property 'MarkedAsRead'
        /// </summary>
        [Test]
        public void MarkedAsReadTest()
        {
            // TODO: unit test for the property 'MarkedAsRead'
        }

    }

}
