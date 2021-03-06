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
    ///  Class for testing HeartBeatRuleNotification
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class HeartBeatRuleNotificationTests
    {
        private HeartBeatRuleNotification instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HeartBeatRuleNotification();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HeartBeatRuleNotification
        /// </summary>
        [Test]
        public void HeartBeatRuleNotificationInstanceTest()
        {
            Assert.IsInstanceOf<HeartBeatRuleNotification> (instance, "instance is a HeartBeatRuleNotification");
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
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'SenderId'
        /// </summary>
        [Test]
        public void SenderIdTest()
        {
            // TODO: unit test for the property 'SenderId'
        }
        /// <summary>
        /// Test the property 'HeartBeatTimeoutInMinutes'
        /// </summary>
        [Test]
        public void HeartBeatTimeoutInMinutesTest()
        {
            // TODO: unit test for the property 'HeartBeatTimeoutInMinutes'
        }
        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Test]
        public void EnabledTest()
        {
            // TODO: unit test for the property 'Enabled'
        }
        /// <summary>
        /// Test the property 'InAlarm'
        /// </summary>
        [Test]
        public void InAlarmTest()
        {
            // TODO: unit test for the property 'InAlarm'
        }
        /// <summary>
        /// Test the property 'NotificationUsers'
        /// </summary>
        [Test]
        public void NotificationUsersTest()
        {
            // TODO: unit test for the property 'NotificationUsers'
        }
        /// <summary>
        /// Test the property 'AlertTypes'
        /// </summary>
        [Test]
        public void AlertTypesTest()
        {
            // TODO: unit test for the property 'AlertTypes'
        }
        /// <summary>
        /// Test the property 'RuleType'
        /// </summary>
        [Test]
        public void RuleTypeTest()
        {
            // TODO: unit test for the property 'RuleType'
        }

    }

}
