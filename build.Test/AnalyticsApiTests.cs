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
    [TestFixture]
    public class AnalyticsApiTests
    {
        private AnalyticsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new AnalyticsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AnalyticsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<AnalyticsApi> (instance, "instance is a AnalyticsApi");
        }

        
        /// <summary>
        /// Test GetAlertingAlerts
        /// </summary>
        [Test]
        public void GetAlertingAlertsTest()
        {
            // TODO: add unit test for the method 'GetAlertingAlerts'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetAlertingAlerts(pageNumber, pageSize, sortBy, sortOrder);
            Assert.IsInstanceOf<AlertEntityListing> (response, "response is AlertEntityListing"); 
        }
        
        /// <summary>
        /// Test GetAlertingAlertsUnread
        /// </summary>
        [Test]
        public void GetAlertingAlertsUnreadTest()
        {
            // TODO: add unit test for the method 'GetAlertingAlertsUnread'
            
            var response = instance.GetAlertingAlertsUnread();
            Assert.IsInstanceOf<UnreadMetric> (response, "response is UnreadMetric"); 
        }
        
        /// <summary>
        /// Test GetAlertingAlertsAlertId
        /// </summary>
        [Test]
        public void GetAlertingAlertsAlertIdTest()
        {
            // TODO: add unit test for the method 'GetAlertingAlertsAlertId'
            string alertId = null; // TODO: replace null with proper value
            
            var response = instance.GetAlertingAlertsAlertId(alertId);
            Assert.IsInstanceOf<Alert> (response, "response is Alert"); 
        }
        
        /// <summary>
        /// Test PutAlertingAlertsAlertId
        /// </summary>
        [Test]
        public void PutAlertingAlertsAlertIdTest()
        {
            // TODO: add unit test for the method 'PutAlertingAlertsAlertId'
            string alertId = null; // TODO: replace null with proper value
            Alert body = null; // TODO: replace null with proper value
            
            var response = instance.PutAlertingAlertsAlertId(alertId, body);
            Assert.IsInstanceOf<Alert> (response, "response is Alert"); 
        }
        
        /// <summary>
        /// Test DeleteAlertingAlertsAlertId
        /// </summary>
        [Test]
        public void DeleteAlertingAlertsAlertIdTest()
        {
            // TODO: add unit test for the method 'DeleteAlertingAlertsAlertId'
            string alertId = null; // TODO: replace null with proper value
            
            instance.DeleteAlertingAlertsAlertId(alertId);
             
        }
        
        /// <summary>
        /// Test GetAlertingRules
        /// </summary>
        [Test]
        public void GetAlertingRulesTest()
        {
            // TODO: add unit test for the method 'GetAlertingRules'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetAlertingRules(pageNumber, pageSize, sortBy, sortOrder);
            Assert.IsInstanceOf<RuleEntityListing> (response, "response is RuleEntityListing"); 
        }
        
        /// <summary>
        /// Test PostAlertingRules
        /// </summary>
        [Test]
        public void PostAlertingRulesTest()
        {
            // TODO: add unit test for the method 'PostAlertingRules'
            Rule body = null; // TODO: replace null with proper value
            
            var response = instance.PostAlertingRules(body);
            Assert.IsInstanceOf<Rule> (response, "response is Rule"); 
        }
        
        /// <summary>
        /// Test GetAlertingRulesRuleId
        /// </summary>
        [Test]
        public void GetAlertingRulesRuleIdTest()
        {
            // TODO: add unit test for the method 'GetAlertingRulesRuleId'
            string ruleId = null; // TODO: replace null with proper value
            
            var response = instance.GetAlertingRulesRuleId(ruleId);
            Assert.IsInstanceOf<Rule> (response, "response is Rule"); 
        }
        
        /// <summary>
        /// Test PutAlertingRulesRuleId
        /// </summary>
        [Test]
        public void PutAlertingRulesRuleIdTest()
        {
            // TODO: add unit test for the method 'PutAlertingRulesRuleId'
            string ruleId = null; // TODO: replace null with proper value
            Rule body = null; // TODO: replace null with proper value
            
            var response = instance.PutAlertingRulesRuleId(ruleId, body);
            Assert.IsInstanceOf<Rule> (response, "response is Rule"); 
        }
        
        /// <summary>
        /// Test DeleteAlertingRulesRuleId
        /// </summary>
        [Test]
        public void DeleteAlertingRulesRuleIdTest()
        {
            // TODO: add unit test for the method 'DeleteAlertingRulesRuleId'
            string ruleId = null; // TODO: replace null with proper value
            
            instance.DeleteAlertingRulesRuleId(ruleId);
             
        }
        
        /// <summary>
        /// Test PostMetricsQuery
        /// </summary>
        [Test]
        public void PostMetricsQueryTest()
        {
            // TODO: add unit test for the method 'PostMetricsQuery'
            Body body = null; // TODO: replace null with proper value
            
            instance.PostMetricsQuery(body);
             
        }
        
        /// <summary>
        /// Test GetReportingMetadata
        /// </summary>
        [Test]
        public void GetReportingMetadataTest()
        {
            // TODO: add unit test for the method 'GetReportingMetadata'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string acceptLanguage = null; // TODO: replace null with proper value
            string locale = null; // TODO: replace null with proper value
            
            var response = instance.GetReportingMetadata(pageNumber, pageSize, acceptLanguage, locale);
            Assert.IsInstanceOf<ReportMetaDataEntityListing> (response, "response is ReportMetaDataEntityListing"); 
        }
        
        /// <summary>
        /// Test GetReportingReportformats
        /// </summary>
        [Test]
        public void GetReportingReportformatsTest()
        {
            // TODO: add unit test for the method 'GetReportingReportformats'
            
            var response = instance.GetReportingReportformats();
            Assert.IsInstanceOf<List<string>> (response, "response is List<string>"); 
        }
        
        /// <summary>
        /// Test GetReportingSchedules
        /// </summary>
        [Test]
        public void GetReportingSchedulesTest()
        {
            // TODO: add unit test for the method 'GetReportingSchedules'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            
            var response = instance.GetReportingSchedules(pageNumber, pageSize);
            Assert.IsInstanceOf<ReportScheduleEntityListing> (response, "response is ReportScheduleEntityListing"); 
        }
        
        /// <summary>
        /// Test PostReportingSchedules
        /// </summary>
        [Test]
        public void PostReportingSchedulesTest()
        {
            // TODO: add unit test for the method 'PostReportingSchedules'
            ReportSchedule body = null; // TODO: replace null with proper value
            
            var response = instance.PostReportingSchedules(body);
            Assert.IsInstanceOf<ReportSchedule> (response, "response is ReportSchedule"); 
        }
        
        /// <summary>
        /// Test GetReportingSchedulesScheduleId
        /// </summary>
        [Test]
        public void GetReportingSchedulesScheduleIdTest()
        {
            // TODO: add unit test for the method 'GetReportingSchedulesScheduleId'
            string scheduleId = null; // TODO: replace null with proper value
            
            var response = instance.GetReportingSchedulesScheduleId(scheduleId);
            Assert.IsInstanceOf<ReportSchedule> (response, "response is ReportSchedule"); 
        }
        
        /// <summary>
        /// Test PutReportingSchedulesScheduleId
        /// </summary>
        [Test]
        public void PutReportingSchedulesScheduleIdTest()
        {
            // TODO: add unit test for the method 'PutReportingSchedulesScheduleId'
            string scheduleId = null; // TODO: replace null with proper value
            ReportSchedule body = null; // TODO: replace null with proper value
            
            var response = instance.PutReportingSchedulesScheduleId(scheduleId, body);
            Assert.IsInstanceOf<ReportSchedule> (response, "response is ReportSchedule"); 
        }
        
        /// <summary>
        /// Test DeleteReportingSchedulesScheduleId
        /// </summary>
        [Test]
        public void DeleteReportingSchedulesScheduleIdTest()
        {
            // TODO: add unit test for the method 'DeleteReportingSchedulesScheduleId'
            string scheduleId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteReportingSchedulesScheduleId(scheduleId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetReportingSchedulesScheduleIdHistory
        /// </summary>
        [Test]
        public void GetReportingSchedulesScheduleIdHistoryTest()
        {
            // TODO: add unit test for the method 'GetReportingSchedulesScheduleIdHistory'
            string scheduleId = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            
            var response = instance.GetReportingSchedulesScheduleIdHistory(scheduleId, pageNumber, pageSize);
            Assert.IsInstanceOf<ReportRunEntryEntityDomainListing> (response, "response is ReportRunEntryEntityDomainListing"); 
        }
        
        /// <summary>
        /// Test GetReportingSchedulesScheduleIdHistoryLatest
        /// </summary>
        [Test]
        public void GetReportingSchedulesScheduleIdHistoryLatestTest()
        {
            // TODO: add unit test for the method 'GetReportingSchedulesScheduleIdHistoryLatest'
            string scheduleId = null; // TODO: replace null with proper value
            
            var response = instance.GetReportingSchedulesScheduleIdHistoryLatest(scheduleId);
            Assert.IsInstanceOf<ReportRunEntry> (response, "response is ReportRunEntry"); 
        }
        
        /// <summary>
        /// Test GetReportingSchedulesScheduleIdHistoryRunId
        /// </summary>
        [Test]
        public void GetReportingSchedulesScheduleIdHistoryRunIdTest()
        {
            // TODO: add unit test for the method 'GetReportingSchedulesScheduleIdHistoryRunId'
            string runId = null; // TODO: replace null with proper value
            string scheduleId = null; // TODO: replace null with proper value
            
            var response = instance.GetReportingSchedulesScheduleIdHistoryRunId(runId, scheduleId);
            Assert.IsInstanceOf<ReportRunEntry> (response, "response is ReportRunEntry"); 
        }
        
        /// <summary>
        /// Test PostReportingSchedulesScheduleIdRunreport
        /// </summary>
        [Test]
        public void PostReportingSchedulesScheduleIdRunreportTest()
        {
            // TODO: add unit test for the method 'PostReportingSchedulesScheduleIdRunreport'
            string scheduleId = null; // TODO: replace null with proper value
            
            var response = instance.PostReportingSchedulesScheduleIdRunreport(scheduleId);
            Assert.IsInstanceOf<RunNowResponse> (response, "response is RunNowResponse"); 
        }
        
        /// <summary>
        /// Test GetReportingTimeperiods
        /// </summary>
        [Test]
        public void GetReportingTimeperiodsTest()
        {
            // TODO: add unit test for the method 'GetReportingTimeperiods'
            
            var response = instance.GetReportingTimeperiods();
            Assert.IsInstanceOf<List<string>> (response, "response is List<string>"); 
        }
        
        /// <summary>
        /// Test GetReportingReportIdMetadata
        /// </summary>
        [Test]
        public void GetReportingReportIdMetadataTest()
        {
            // TODO: add unit test for the method 'GetReportingReportIdMetadata'
            string reportId = null; // TODO: replace null with proper value
            string acceptLanguage = null; // TODO: replace null with proper value
            string locale = null; // TODO: replace null with proper value
            
            var response = instance.GetReportingReportIdMetadata(reportId, acceptLanguage, locale);
            Assert.IsInstanceOf<ReportMetaData> (response, "response is ReportMetaData"); 
        }
        
        /// <summary>
        /// Test PostSegmentsQuery
        /// </summary>
        [Test]
        public void PostSegmentsQueryTest()
        {
            // TODO: add unit test for the method 'PostSegmentsQuery'
            Body1 body = null; // TODO: replace null with proper value
            
            instance.PostSegmentsQuery(body);
             
        }
        
    }

}
