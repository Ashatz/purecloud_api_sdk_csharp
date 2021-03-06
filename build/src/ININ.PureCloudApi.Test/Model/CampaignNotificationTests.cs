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
    ///  Class for testing CampaignNotification
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CampaignNotificationTests
    {
        private CampaignNotification instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CampaignNotification();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CampaignNotification
        /// </summary>
        [Test]
        public void CampaignNotificationInstanceTest()
        {
            Assert.IsInstanceOf<CampaignNotification> (instance, "instance is a CampaignNotification");
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
        /// Test the property 'DateCreated'
        /// </summary>
        [Test]
        public void DateCreatedTest()
        {
            // TODO: unit test for the property 'DateCreated'
        }
        /// <summary>
        /// Test the property 'DateModified'
        /// </summary>
        [Test]
        public void DateModifiedTest()
        {
            // TODO: unit test for the property 'DateModified'
        }
        /// <summary>
        /// Test the property 'Version'
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO: unit test for the property 'Version'
        }
        /// <summary>
        /// Test the property 'ContactList'
        /// </summary>
        [Test]
        public void ContactListTest()
        {
            // TODO: unit test for the property 'ContactList'
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
        /// Test the property 'DialingMode'
        /// </summary>
        [Test]
        public void DialingModeTest()
        {
            // TODO: unit test for the property 'DialingMode'
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
        /// Test the property 'EdgeGroup'
        /// </summary>
        [Test]
        public void EdgeGroupTest()
        {
            // TODO: unit test for the property 'EdgeGroup'
        }
        /// <summary>
        /// Test the property 'CampaignStatus'
        /// </summary>
        [Test]
        public void CampaignStatusTest()
        {
            // TODO: unit test for the property 'CampaignStatus'
        }
        /// <summary>
        /// Test the property 'PhoneColumns'
        /// </summary>
        [Test]
        public void PhoneColumnsTest()
        {
            // TODO: unit test for the property 'PhoneColumns'
        }
        /// <summary>
        /// Test the property 'AbandonRate'
        /// </summary>
        [Test]
        public void AbandonRateTest()
        {
            // TODO: unit test for the property 'AbandonRate'
        }
        /// <summary>
        /// Test the property 'DncLists'
        /// </summary>
        [Test]
        public void DncListsTest()
        {
            // TODO: unit test for the property 'DncLists'
        }
        /// <summary>
        /// Test the property 'CallableTimeSet'
        /// </summary>
        [Test]
        public void CallableTimeSetTest()
        {
            // TODO: unit test for the property 'CallableTimeSet'
        }
        /// <summary>
        /// Test the property 'CallAnalysisResponseSet'
        /// </summary>
        [Test]
        public void CallAnalysisResponseSetTest()
        {
            // TODO: unit test for the property 'CallAnalysisResponseSet'
        }
        /// <summary>
        /// Test the property 'CallerName'
        /// </summary>
        [Test]
        public void CallerNameTest()
        {
            // TODO: unit test for the property 'CallerName'
        }
        /// <summary>
        /// Test the property 'CallerAddress'
        /// </summary>
        [Test]
        public void CallerAddressTest()
        {
            // TODO: unit test for the property 'CallerAddress'
        }
        /// <summary>
        /// Test the property 'OutboundLineCount'
        /// </summary>
        [Test]
        public void OutboundLineCountTest()
        {
            // TODO: unit test for the property 'OutboundLineCount'
        }
        /// <summary>
        /// Test the property 'Errors'
        /// </summary>
        [Test]
        public void ErrorsTest()
        {
            // TODO: unit test for the property 'Errors'
        }
        /// <summary>
        /// Test the property 'RuleSets'
        /// </summary>
        [Test]
        public void RuleSetsTest()
        {
            // TODO: unit test for the property 'RuleSets'
        }
        /// <summary>
        /// Test the property 'SkipPreviewDisabled'
        /// </summary>
        [Test]
        public void SkipPreviewDisabledTest()
        {
            // TODO: unit test for the property 'SkipPreviewDisabled'
        }
        /// <summary>
        /// Test the property 'PreviewTimeOutSeconds'
        /// </summary>
        [Test]
        public void PreviewTimeOutSecondsTest()
        {
            // TODO: unit test for the property 'PreviewTimeOutSeconds'
        }
        /// <summary>
        /// Test the property 'SingleNumberPreview'
        /// </summary>
        [Test]
        public void SingleNumberPreviewTest()
        {
            // TODO: unit test for the property 'SingleNumberPreview'
        }
        /// <summary>
        /// Test the property 'ContactSort'
        /// </summary>
        [Test]
        public void ContactSortTest()
        {
            // TODO: unit test for the property 'ContactSort'
        }
        /// <summary>
        /// Test the property 'NoAnswerTimeout'
        /// </summary>
        [Test]
        public void NoAnswerTimeoutTest()
        {
            // TODO: unit test for the property 'NoAnswerTimeout'
        }
        /// <summary>
        /// Test the property 'CallAnalysisLanguage'
        /// </summary>
        [Test]
        public void CallAnalysisLanguageTest()
        {
            // TODO: unit test for the property 'CallAnalysisLanguage'
        }
        /// <summary>
        /// Test the property 'Priority'
        /// </summary>
        [Test]
        public void PriorityTest()
        {
            // TODO: unit test for the property 'Priority'
        }
        /// <summary>
        /// Test the property 'AdditionalProperties'
        /// </summary>
        [Test]
        public void AdditionalPropertiesTest()
        {
            // TODO: unit test for the property 'AdditionalProperties'
        }

    }

}
