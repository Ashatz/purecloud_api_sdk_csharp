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
    ///  Class for testing HeartBeatAlertNotificationNotificationUsers
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class HeartBeatAlertNotificationNotificationUsersTests
    {
        private HeartBeatAlertNotificationNotificationUsers instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HeartBeatAlertNotificationNotificationUsers();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HeartBeatAlertNotificationNotificationUsers
        /// </summary>
        [Test]
        public void HeartBeatAlertNotificationNotificationUsersInstanceTest()
        {
            Assert.IsInstanceOf<HeartBeatAlertNotificationNotificationUsers> (instance, "instance is a HeartBeatAlertNotificationNotificationUsers");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'DisplayName'
        /// </summary>
        [Test]
        public void DisplayNameTest()
        {
            // TODO: unit test for the property 'DisplayName'
        }

    }

}