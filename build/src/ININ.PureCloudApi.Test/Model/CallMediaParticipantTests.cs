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
    ///  Class for testing CallMediaParticipant
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CallMediaParticipantTests
    {
        private CallMediaParticipant instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CallMediaParticipant();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CallMediaParticipant
        /// </summary>
        [Test]
        public void CallMediaParticipantInstanceTest()
        {
            Assert.IsInstanceOf<CallMediaParticipant> (instance, "instance is a CallMediaParticipant");
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
        /// Test the property 'Address'
        /// </summary>
        [Test]
        public void AddressTest()
        {
            // TODO: unit test for the property 'Address'
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
        /// Test the property 'ConnectedTime'
        /// </summary>
        [Test]
        public void ConnectedTimeTest()
        {
            // TODO: unit test for the property 'ConnectedTime'
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
        /// Test the property 'StartHoldTime'
        /// </summary>
        [Test]
        public void StartHoldTimeTest()
        {
            // TODO: unit test for the property 'StartHoldTime'
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
        /// Test the property 'State'
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO: unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'Direction'
        /// </summary>
        [Test]
        public void DirectionTest()
        {
            // TODO: unit test for the property 'Direction'
        }
        /// <summary>
        /// Test the property 'DisconnectType'
        /// </summary>
        [Test]
        public void DisconnectTypeTest()
        {
            // TODO: unit test for the property 'DisconnectType'
        }
        /// <summary>
        /// Test the property 'Held'
        /// </summary>
        [Test]
        public void HeldTest()
        {
            // TODO: unit test for the property 'Held'
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
        /// Test the property 'User'
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User'
        }
        /// <summary>
        /// Test the property 'Queue'
        /// </summary>
        [Test]
        public void QueueTest()
        {
            // TODO: unit test for the property 'Queue'
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
        /// Test the property 'ErrorInfo'
        /// </summary>
        [Test]
        public void ErrorInfoTest()
        {
            // TODO: unit test for the property 'ErrorInfo'
        }
        /// <summary>
        /// Test the property 'Script'
        /// </summary>
        [Test]
        public void ScriptTest()
        {
            // TODO: unit test for the property 'Script'
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
        /// Test the property 'Muted'
        /// </summary>
        [Test]
        public void MutedTest()
        {
            // TODO: unit test for the property 'Muted'
        }
        /// <summary>
        /// Test the property 'Confined'
        /// </summary>
        [Test]
        public void ConfinedTest()
        {
            // TODO: unit test for the property 'Confined'
        }
        /// <summary>
        /// Test the property 'Recording'
        /// </summary>
        [Test]
        public void RecordingTest()
        {
            // TODO: unit test for the property 'Recording'
        }
        /// <summary>
        /// Test the property 'RecordingState'
        /// </summary>
        [Test]
        public void RecordingStateTest()
        {
            // TODO: unit test for the property 'RecordingState'
        }
        /// <summary>
        /// Test the property 'Group'
        /// </summary>
        [Test]
        public void GroupTest()
        {
            // TODO: unit test for the property 'Group'
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
        /// Test the property 'DocumentId'
        /// </summary>
        [Test]
        public void DocumentIdTest()
        {
            // TODO: unit test for the property 'DocumentId'
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
        /// Test the property 'ConsultParticipantId'
        /// </summary>
        [Test]
        public void ConsultParticipantIdTest()
        {
            // TODO: unit test for the property 'ConsultParticipantId'
        }

    }

}
