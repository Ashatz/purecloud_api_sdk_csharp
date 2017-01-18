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
    ///  Class for testing UserPresenceRule
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UserPresenceRuleTests
    {
        private UserPresenceRule instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserPresenceRule();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserPresenceRule
        /// </summary>
        [Test]
        public void UserPresenceRuleInstanceTest()
        {
            Assert.IsInstanceOf<UserPresenceRule> (instance, "instance is a UserPresenceRule");
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
        /// Test the property 'PresenceUser'
        /// </summary>
        [Test]
        public void PresenceUserTest()
        {
            // TODO: unit test for the property 'PresenceUser'
        }
        /// <summary>
        /// Test the property 'PresenceType'
        /// </summary>
        [Test]
        public void PresenceTypeTest()
        {
            // TODO: unit test for the property 'PresenceType'
        }
        /// <summary>
        /// Test the property 'PresenceValue'
        /// </summary>
        [Test]
        public void PresenceValueTest()
        {
            // TODO: unit test for the property 'PresenceValue'
        }
        /// <summary>
        /// Test the property 'PresenceLimitInSeconds'
        /// </summary>
        [Test]
        public void PresenceLimitInSecondsTest()
        {
            // TODO: unit test for the property 'PresenceLimitInSeconds'
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
        /// Test the property 'SelfUri'
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri'
        }

    }

}