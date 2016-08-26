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
    ///  Class for testing AnalyticsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
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
        /// Test GetConversationsConversationIdDetails
        /// </summary>
        [Test]
        public void GetConversationsConversationIdDetailsTest()
        {
            // TODO: add unit test for the method 'GetConversationsConversationIdDetails'
            string conversationId = null; // TODO: replace null with proper value
            var response = instance.GetConversationsConversationIdDetails(conversationId);
            Assert.IsInstanceOf<AnalyticsConversation> (response, "response is AnalyticsConversation");
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
            string locale = null; // TODO: replace null with proper value
            var response = instance.GetReportingMetadata(pageNumber, pageSize, locale);
            Assert.IsInstanceOf<ReportMetaDataEntityListing> (response, "response is ReportMetaDataEntityListing");
        }
        
        /// <summary>
        /// Test GetReportingReportIdMetadata
        /// </summary>
        [Test]
        public void GetReportingReportIdMetadataTest()
        {
            // TODO: add unit test for the method 'GetReportingReportIdMetadata'
            string reportId = null; // TODO: replace null with proper value
            string locale = null; // TODO: replace null with proper value
            var response = instance.GetReportingReportIdMetadata(reportId, locale);
            Assert.IsInstanceOf<ReportMetaData> (response, "response is ReportMetaData");
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
        /// Test PostConversationsAggregatesQuery
        /// </summary>
        [Test]
        public void PostConversationsAggregatesQueryTest()
        {
            // TODO: add unit test for the method 'PostConversationsAggregatesQuery'
            AggregationQuery body = null; // TODO: replace null with proper value
            var response = instance.PostConversationsAggregatesQuery(body);
            Assert.IsInstanceOf<AggregateQueryResponse> (response, "response is AggregateQueryResponse");
        }
        
        /// <summary>
        /// Test PostConversationsConversationIdDetailsProperties
        /// </summary>
        [Test]
        public void PostConversationsConversationIdDetailsPropertiesTest()
        {
            // TODO: add unit test for the method 'PostConversationsConversationIdDetailsProperties'
            string conversationId = null; // TODO: replace null with proper value
            PropertyIndexRequest body = null; // TODO: replace null with proper value
            var response = instance.PostConversationsConversationIdDetailsProperties(conversationId, body);
            Assert.IsInstanceOf<PropertyIndexRequest> (response, "response is PropertyIndexRequest");
        }
        
        /// <summary>
        /// Test PostConversationsDetailsQuery
        /// </summary>
        [Test]
        public void PostConversationsDetailsQueryTest()
        {
            // TODO: add unit test for the method 'PostConversationsDetailsQuery'
            ConversationQuery body = null; // TODO: replace null with proper value
            var response = instance.PostConversationsDetailsQuery(body);
            Assert.IsInstanceOf<AnalyticsConversationQueryResponse> (response, "response is AnalyticsConversationQueryResponse");
        }
        
        /// <summary>
        /// Test PostEvaluationsAggregatesQuery
        /// </summary>
        [Test]
        public void PostEvaluationsAggregatesQueryTest()
        {
            // TODO: add unit test for the method 'PostEvaluationsAggregatesQuery'
            AggregationQuery body = null; // TODO: replace null with proper value
            var response = instance.PostEvaluationsAggregatesQuery(body);
            Assert.IsInstanceOf<AggregateQueryResponse> (response, "response is AggregateQueryResponse");
        }
        
        /// <summary>
        /// Test PostQueuesObservationsQuery
        /// </summary>
        [Test]
        public void PostQueuesObservationsQueryTest()
        {
            // TODO: add unit test for the method 'PostQueuesObservationsQuery'
            ObservationQuery body = null; // TODO: replace null with proper value
            var response = instance.PostQueuesObservationsQuery(body);
            Assert.IsInstanceOf<QualifierMappingObservationQueryResponse> (response, "response is QualifierMappingObservationQueryResponse");
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
        /// Test PostUsersAggregatesQuery
        /// </summary>
        [Test]
        public void PostUsersAggregatesQueryTest()
        {
            // TODO: add unit test for the method 'PostUsersAggregatesQuery'
            AggregationQuery body = null; // TODO: replace null with proper value
            var response = instance.PostUsersAggregatesQuery(body);
            Assert.IsInstanceOf<PresenceQueryResponse> (response, "response is PresenceQueryResponse");
        }
        
        /// <summary>
        /// Test PostUsersObservationsQuery
        /// </summary>
        [Test]
        public void PostUsersObservationsQueryTest()
        {
            // TODO: add unit test for the method 'PostUsersObservationsQuery'
            ObservationQuery body = null; // TODO: replace null with proper value
            var response = instance.PostUsersObservationsQuery(body);
            Assert.IsInstanceOf<ObservationQueryResponse> (response, "response is ObservationQueryResponse");
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
        
    }

}
