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
    ///  Class for testing Participant
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ParticipantTests
    {
        private Participant instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Participant();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Participant
        /// </summary>
        [Test]
        public void ParticipantInstanceTest()
        {
            Assert.IsInstanceOf<Participant> (instance, "instance is a Participant");
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
        /// Test the property 'StartTime'
        /// </summary>
        [Test]
        public void StartTimeTest()
        {
            // TODO: unit test for the property 'StartTime'
        }
        /// <summary>
        /// Test the property 'EndTime'
        /// </summary>
        [Test]
        public void EndTimeTest()
        {
            // TODO: unit test for the property 'EndTime'
        }
        /// <summary>
        /// Test the property 'ConnectedTime'
        /// </summary>
        [Test]
        public void ConnectedTimeTest()
        {
            // TODO: unit test for the property 'ConnectedTime'
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
        /// Test the property 'UserUri'
        /// </summary>
        [Test]
        public void UserUriTest()
        {
            // TODO: unit test for the property 'UserUri'
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
        /// Test the property 'ExternalContactId'
        /// </summary>
        [Test]
        public void ExternalContactIdTest()
        {
            // TODO: unit test for the property 'ExternalContactId'
        }
        /// <summary>
        /// Test the property 'QueueId'
        /// </summary>
        [Test]
        public void QueueIdTest()
        {
            // TODO: unit test for the property 'QueueId'
        }
        /// <summary>
        /// Test the property 'GroupId'
        /// </summary>
        [Test]
        public void GroupIdTest()
        {
            // TODO: unit test for the property 'GroupId'
        }
        /// <summary>
        /// Test the property 'QueueName'
        /// </summary>
        [Test]
        public void QueueNameTest()
        {
            // TODO: unit test for the property 'QueueName'
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
        /// Test the property 'ParticipantType'
        /// </summary>
        [Test]
        public void ParticipantTypeTest()
        {
            // TODO: unit test for the property 'ParticipantType'
        }
        /// <summary>
        /// Test the property 'ConsultParticipantId'
        /// </summary>
        [Test]
        public void ConsultParticipantIdTest()
        {
            // TODO: unit test for the property 'ConsultParticipantId'
        }
        /// <summary>
        /// Test the property 'Address'
        /// </summary>
        [Test]
        public void AddressTest()
        {
            // TODO: unit test for the property 'Address'
        }
        /// <summary>
        /// Test the property 'Ani'
        /// </summary>
        [Test]
        public void AniTest()
        {
            // TODO: unit test for the property 'Ani'
        }
        /// <summary>
        /// Test the property 'Dnis'
        /// </summary>
        [Test]
        public void DnisTest()
        {
            // TODO: unit test for the property 'Dnis'
        }
        /// <summary>
        /// Test the property 'Locale'
        /// </summary>
        [Test]
        public void LocaleTest()
        {
            // TODO: unit test for the property 'Locale'
        }
        /// <summary>
        /// Test the property 'WrapupRequired'
        /// </summary>
        [Test]
        public void WrapupRequiredTest()
        {
            // TODO: unit test for the property 'WrapupRequired'
        }
        /// <summary>
        /// Test the property 'WrapupPrompt'
        /// </summary>
        [Test]
        public void WrapupPromptTest()
        {
            // TODO: unit test for the property 'WrapupPrompt'
        }
        /// <summary>
        /// Test the property 'WrapupTimeoutMs'
        /// </summary>
        [Test]
        public void WrapupTimeoutMsTest()
        {
            // TODO: unit test for the property 'WrapupTimeoutMs'
        }
        /// <summary>
        /// Test the property 'WrapupSkipped'
        /// </summary>
        [Test]
        public void WrapupSkippedTest()
        {
            // TODO: unit test for the property 'WrapupSkipped'
        }
        /// <summary>
        /// Test the property 'Wrapup'
        /// </summary>
        [Test]
        public void WrapupTest()
        {
            // TODO: unit test for the property 'Wrapup'
        }
        /// <summary>
        /// Test the property 'MonitoredParticipantId'
        /// </summary>
        [Test]
        public void MonitoredParticipantIdTest()
        {
            // TODO: unit test for the property 'MonitoredParticipantId'
        }
        /// <summary>
        /// Test the property 'Attributes'
        /// </summary>
        [Test]
        public void AttributesTest()
        {
            // TODO: unit test for the property 'Attributes'
        }
        /// <summary>
        /// Test the property 'Calls'
        /// </summary>
        [Test]
        public void CallsTest()
        {
            // TODO: unit test for the property 'Calls'
        }
        /// <summary>
        /// Test the property 'Callbacks'
        /// </summary>
        [Test]
        public void CallbacksTest()
        {
            // TODO: unit test for the property 'Callbacks'
        }
        /// <summary>
        /// Test the property 'Chats'
        /// </summary>
        [Test]
        public void ChatsTest()
        {
            // TODO: unit test for the property 'Chats'
        }
        /// <summary>
        /// Test the property 'Emails'
        /// </summary>
        [Test]
        public void EmailsTest()
        {
            // TODO: unit test for the property 'Emails'
        }
        /// <summary>
        /// Test the property 'SocialExpressions'
        /// </summary>
        [Test]
        public void SocialExpressionsTest()
        {
            // TODO: unit test for the property 'SocialExpressions'
        }
        /// <summary>
        /// Test the property 'Videos'
        /// </summary>
        [Test]
        public void VideosTest()
        {
            // TODO: unit test for the property 'Videos'
        }
        /// <summary>
        /// Test the property 'Evaluations'
        /// </summary>
        [Test]
        public void EvaluationsTest()
        {
            // TODO: unit test for the property 'Evaluations'
        }

    }

}
