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
        /// Test GetAlertingAlert
        /// </summary>
        [Test]
        public void GetAlertingAlertTest()
        {
            // TODO: add unit test for the method 'GetAlertingAlert'
            string alertId = null; // TODO: replace null with proper value
            
            var response = instance.GetAlertingAlert(alertId);
            Assert.IsInstanceOf<Alert> (response, "response is Alert"); 
        }
        
        /// <summary>
        /// Test PutAlertingAlert
        /// </summary>
        [Test]
        public void PutAlertingAlertTest()
        {
            // TODO: add unit test for the method 'PutAlertingAlert'
            string alertId = null; // TODO: replace null with proper value
            Alert body = null; // TODO: replace null with proper value
            
            var response = instance.PutAlertingAlert(alertId, body);
            Assert.IsInstanceOf<Alert> (response, "response is Alert"); 
        }
        
        /// <summary>
        /// Test DeleteAlertingAlert
        /// </summary>
        [Test]
        public void DeleteAlertingAlertTest()
        {
            // TODO: add unit test for the method 'DeleteAlertingAlert'
            string alertId = null; // TODO: replace null with proper value
            
            instance.DeleteAlertingAlert(alertId);
             
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
        /// Test GetAlertingRule
        /// </summary>
        [Test]
        public void GetAlertingRuleTest()
        {
            // TODO: add unit test for the method 'GetAlertingRule'
            string ruleId = null; // TODO: replace null with proper value
            
            var response = instance.GetAlertingRule(ruleId);
            Assert.IsInstanceOf<Rule> (response, "response is Rule"); 
        }
        
        /// <summary>
        /// Test PutAlertingRule
        /// </summary>
        [Test]
        public void PutAlertingRuleTest()
        {
            // TODO: add unit test for the method 'PutAlertingRule'
            string ruleId = null; // TODO: replace null with proper value
            Rule body = null; // TODO: replace null with proper value
            
            var response = instance.PutAlertingRule(ruleId, body);
            Assert.IsInstanceOf<Rule> (response, "response is Rule"); 
        }
        
        /// <summary>
        /// Test DeleteAlertingRule
        /// </summary>
        [Test]
        public void DeleteAlertingRuleTest()
        {
            // TODO: add unit test for the method 'DeleteAlertingRule'
            string ruleId = null; // TODO: replace null with proper value
            
            instance.DeleteAlertingRule(ruleId);
             
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
        /// Test GetReportingSchedule
        /// </summary>
        [Test]
        public void GetReportingScheduleTest()
        {
            // TODO: add unit test for the method 'GetReportingSchedule'
            string scheduleId = null; // TODO: replace null with proper value
            
            var response = instance.GetReportingSchedule(scheduleId);
            Assert.IsInstanceOf<ReportSchedule> (response, "response is ReportSchedule"); 
        }
        
        /// <summary>
        /// Test PutReportingSchedule
        /// </summary>
        [Test]
        public void PutReportingScheduleTest()
        {
            // TODO: add unit test for the method 'PutReportingSchedule'
            string scheduleId = null; // TODO: replace null with proper value
            ReportSchedule body = null; // TODO: replace null with proper value
            
            var response = instance.PutReportingSchedule(scheduleId, body);
            Assert.IsInstanceOf<ReportSchedule> (response, "response is ReportSchedule"); 
        }
        
        /// <summary>
        /// Test DeleteReportingSchedule
        /// </summary>
        [Test]
        public void DeleteReportingScheduleTest()
        {
            // TODO: add unit test for the method 'DeleteReportingSchedule'
            string scheduleId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteReportingSchedule(scheduleId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetReportingScheduleHistory
        /// </summary>
        [Test]
        public void GetReportingScheduleHistoryTest()
        {
            // TODO: add unit test for the method 'GetReportingScheduleHistory'
            string scheduleId = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            
            var response = instance.GetReportingScheduleHistory(scheduleId, pageNumber, pageSize);
            Assert.IsInstanceOf<ReportRunEntryEntityDomainListing> (response, "response is ReportRunEntryEntityDomainListing"); 
        }
        
        /// <summary>
        /// Test GetReportingScheduleHistoryLatest
        /// </summary>
        [Test]
        public void GetReportingScheduleHistoryLatestTest()
        {
            // TODO: add unit test for the method 'GetReportingScheduleHistoryLatest'
            string scheduleId = null; // TODO: replace null with proper value
            
            var response = instance.GetReportingScheduleHistoryLatest(scheduleId);
            Assert.IsInstanceOf<ReportRunEntry> (response, "response is ReportRunEntry"); 
        }
        
        /// <summary>
        /// Test GetReportingScheduleHistory_0
        /// </summary>
        [Test]
        public void GetReportingScheduleHistory_0Test()
        {
            // TODO: add unit test for the method 'GetReportingScheduleHistory_0'
            string runId = null; // TODO: replace null with proper value
            string scheduleId = null; // TODO: replace null with proper value
            
            var response = instance.GetReportingScheduleHistory_0(runId, scheduleId);
            Assert.IsInstanceOf<ReportRunEntry> (response, "response is ReportRunEntry"); 
        }
        
        /// <summary>
        /// Test PostReportingScheduleRunreport
        /// </summary>
        [Test]
        public void PostReportingScheduleRunreportTest()
        {
            // TODO: add unit test for the method 'PostReportingScheduleRunreport'
            string scheduleId = null; // TODO: replace null with proper value
            
            var response = instance.PostReportingScheduleRunreport(scheduleId);
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
        /// Test GetReportingMetadata_0
        /// </summary>
        [Test]
        public void GetReportingMetadata_0Test()
        {
            // TODO: add unit test for the method 'GetReportingMetadata_0'
            string reportId = null; // TODO: replace null with proper value
            string acceptLanguage = null; // TODO: replace null with proper value
            string locale = null; // TODO: replace null with proper value
            
            var response = instance.GetReportingMetadata_0(reportId, acceptLanguage, locale);
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
