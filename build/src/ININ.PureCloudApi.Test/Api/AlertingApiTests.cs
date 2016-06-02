using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Model;

namespace ININ.PureCloudApi.Test
{
    /// <summary>
    ///  Class for testing AlertingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AlertingApiTests
    {
        private AlertingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AlertingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AlertingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<AlertingApi> (instance, "instance is a AlertingApi");
        }

        
        /// <summary>
        /// Test DeleteInteractionstatsAlertsAlertId
        /// </summary>
        [Test]
        public void DeleteInteractionstatsAlertsAlertIdTest()
        {
            // TODO: add unit test for the method 'DeleteInteractionstatsAlertsAlertId'
            string alertId = null; // TODO: replace null with proper value
            instance.DeleteInteractionstatsAlertsAlertId(alertId);
            
        }
        
        /// <summary>
        /// Test DeleteInteractionstatsRulesRuleId
        /// </summary>
        [Test]
        public void DeleteInteractionstatsRulesRuleIdTest()
        {
            // TODO: add unit test for the method 'DeleteInteractionstatsRulesRuleId'
            string ruleId = null; // TODO: replace null with proper value
            instance.DeleteInteractionstatsRulesRuleId(ruleId);
            
        }
        
        /// <summary>
        /// Test GetInteractionstatsAlerts
        /// </summary>
        [Test]
        public void GetInteractionstatsAlertsTest()
        {
            // TODO: add unit test for the method 'GetInteractionstatsAlerts'
            var response = instance.GetInteractionstatsAlerts();
            Assert.IsInstanceOf<InteractionStatsAlertContainer> (response, "response is InteractionStatsAlertContainer");
        }
        
        /// <summary>
        /// Test GetInteractionstatsAlertsAlertId
        /// </summary>
        [Test]
        public void GetInteractionstatsAlertsAlertIdTest()
        {
            // TODO: add unit test for the method 'GetInteractionstatsAlertsAlertId'
            string alertId = null; // TODO: replace null with proper value
            var response = instance.GetInteractionstatsAlertsAlertId(alertId);
            Assert.IsInstanceOf<InteractionStatsAlert> (response, "response is InteractionStatsAlert");
        }
        
        /// <summary>
        /// Test GetInteractionstatsAlertsUnread
        /// </summary>
        [Test]
        public void GetInteractionstatsAlertsUnreadTest()
        {
            // TODO: add unit test for the method 'GetInteractionstatsAlertsUnread'
            var response = instance.GetInteractionstatsAlertsUnread();
            Assert.IsInstanceOf<UnreadMetric> (response, "response is UnreadMetric");
        }
        
        /// <summary>
        /// Test GetInteractionstatsRules
        /// </summary>
        [Test]
        public void GetInteractionstatsRulesTest()
        {
            // TODO: add unit test for the method 'GetInteractionstatsRules'
            var response = instance.GetInteractionstatsRules();
            Assert.IsInstanceOf<InteractionStatsRuleContainer> (response, "response is InteractionStatsRuleContainer");
        }
        
        /// <summary>
        /// Test GetInteractionstatsRulesRuleId
        /// </summary>
        [Test]
        public void GetInteractionstatsRulesRuleIdTest()
        {
            // TODO: add unit test for the method 'GetInteractionstatsRulesRuleId'
            string ruleId = null; // TODO: replace null with proper value
            var response = instance.GetInteractionstatsRulesRuleId(ruleId);
            Assert.IsInstanceOf<InteractionStatsRule> (response, "response is InteractionStatsRule");
        }
        
        /// <summary>
        /// Test PostInteractionstatsRules
        /// </summary>
        [Test]
        public void PostInteractionstatsRulesTest()
        {
            // TODO: add unit test for the method 'PostInteractionstatsRules'
            InteractionStatsRule body = null; // TODO: replace null with proper value
            var response = instance.PostInteractionstatsRules(body);
            Assert.IsInstanceOf<InteractionStatsRule> (response, "response is InteractionStatsRule");
        }
        
        /// <summary>
        /// Test PutInteractionstatsAlertsAlertId
        /// </summary>
        [Test]
        public void PutInteractionstatsAlertsAlertIdTest()
        {
            // TODO: add unit test for the method 'PutInteractionstatsAlertsAlertId'
            string alertId = null; // TODO: replace null with proper value
            UnreadStatus body = null; // TODO: replace null with proper value
            var response = instance.PutInteractionstatsAlertsAlertId(alertId, body);
            Assert.IsInstanceOf<UnreadStatus> (response, "response is UnreadStatus");
        }
        
        /// <summary>
        /// Test PutInteractionstatsRulesRuleId
        /// </summary>
        [Test]
        public void PutInteractionstatsRulesRuleIdTest()
        {
            // TODO: add unit test for the method 'PutInteractionstatsRulesRuleId'
            string ruleId = null; // TODO: replace null with proper value
            InteractionStatsRule body = null; // TODO: replace null with proper value
            var response = instance.PutInteractionstatsRulesRuleId(ruleId, body);
            Assert.IsInstanceOf<InteractionStatsRule> (response, "response is InteractionStatsRule");
        }
        
    }

}
