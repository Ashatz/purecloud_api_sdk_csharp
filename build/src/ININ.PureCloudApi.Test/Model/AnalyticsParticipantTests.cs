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
    ///  Class for testing AnalyticsParticipant
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AnalyticsParticipantTests
    {
        private AnalyticsParticipant instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AnalyticsParticipant();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AnalyticsParticipant
        /// </summary>
        [Test]
        public void AnalyticsParticipantInstanceTest()
        {
            Assert.IsInstanceOf<AnalyticsParticipant> (instance, "instance is a AnalyticsParticipant");
        }

        /// <summary>
        /// Test the property 'ParticipantId'
        /// </summary>
        [Test]
        public void ParticipantIdTest()
        {
            // TODO: unit test for the property 'ParticipantId'
        }
        /// <summary>
        /// Test the property 'ParticipantName'
        /// </summary>
        [Test]
        public void ParticipantNameTest()
        {
            // TODO: unit test for the property 'ParticipantName'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO: unit test for the property 'UserId'
        }
        /// <summary>
        /// Test the property 'Purpose'
        /// </summary>
        [Test]
        public void PurposeTest()
        {
            // TODO: unit test for the property 'Purpose'
        }
        /// <summary>
        /// Test the property 'Sessions'
        /// </summary>
        [Test]
        public void SessionsTest()
        {
            // TODO: unit test for the property 'Sessions'
        }

    }

}
