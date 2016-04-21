using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace ININ.PureCloudApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAnalyticsApi
    {
        #region Synchronous Operations
<<<<<<< HEAD
        /// <summary>
        /// Delete an alert.
=======
        /// <summary>
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>string</returns>
        string DeleteReportingSchedulesScheduleId (string scheduleId);

        /// <summary>
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteReportingSchedulesScheduleIdWithHttpInfo (string scheduleId);
        /// <summary>
        /// Get a conversation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>AnalyticsConversation</returns>
        AnalyticsConversation GetConversationsConversationIdDetails (string conversationId);

        /// <summary>
        /// Get a conversation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of AnalyticsConversation</returns>
        ApiResponse<AnalyticsConversation> GetConversationsConversationIdDetailsWithHttpInfo (string conversationId);
        /// <summary>
        /// Get list of reporting metadata.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ReportMetaDataEntityListing</returns>
        ReportMetaDataEntityListing GetReportingMetadata (int? pageNumber = null, int? pageSize = null, string locale = null);

        /// <summary>
        /// Get list of reporting metadata.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ApiResponse of ReportMetaDataEntityListing</returns>
        ApiResponse<ReportMetaDataEntityListing> GetReportingMetadataWithHttpInfo (int? pageNumber = null, int? pageSize = null, string locale = null);
        /// <summary>
        /// Get a reporting metadata.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <returns></returns>
        void AnalyticsAlertingAlertsAlertidDelete (string alertId);

        /// <summary>
        /// Delete an alert.
=======
        /// <param name="reportId">Report ID</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ReportMetaData</returns>
        ReportMetaData GetReportingReportIdMetadata (string reportId, string locale = null);

        /// <summary>
        /// Get a reporting metadata.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AnalyticsAlertingAlertsAlertidDeleteWithHttpInfo (string alertId);
=======
        /// <param name="reportId">Report ID</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ApiResponse of ReportMetaData</returns>
        ApiResponse<ReportMetaData> GetReportingReportIdMetadataWithHttpInfo (string reportId, string locale = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get a list of report formats
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <returns>Alert</returns>
        Alert AnalyticsAlertingAlertsAlertidGet (string alertId);
=======
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetReportingReportformats ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get a list of report formats
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of Alert</returns>
        ApiResponse<Alert> AnalyticsAlertingAlertsAlertidGetWithHttpInfo (string alertId);
=======
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> GetReportingReportformatsWithHttpInfo ();
        /// <summary>
        /// Get a list of scheduled report jobs
        /// </summary>
        /// <remarks>
        /// Get a list of scheduled report jobs.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ReportScheduleEntityListing</returns>
        ReportScheduleEntityListing GetReportingSchedules (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of scheduled report jobs
        /// </summary>
        /// <remarks>
        /// Get a list of scheduled report jobs.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of ReportScheduleEntityListing</returns>
        ApiResponse<ReportScheduleEntityListing> GetReportingSchedulesWithHttpInfo (int? pageNumber = null, int? pageSize = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert (optional)</param>
        /// <returns>Alert</returns>
        Alert AnalyticsAlertingAlertsAlertidPut (string alertId, Alert body = null);
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportSchedule</returns>
        ReportSchedule GetReportingSchedulesScheduleId (string scheduleId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert (optional)</param>
        /// <returns>ApiResponse of Alert</returns>
        ApiResponse<Alert> AnalyticsAlertingAlertsAlertidPutWithHttpInfo (string alertId, Alert body = null);
        /// <summary>
        /// Get a list of alerts.
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        ApiResponse<ReportSchedule> GetReportingSchedulesScheduleIdWithHttpInfo (string scheduleId);
        /// <summary>
        /// Get list of completed scheduled report jobs.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">title, startTime, endTime, description or unread (optional, default to startTime)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>AlertEntityListing</returns>
        AlertEntityListing AnalyticsAlertingAlertsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of alerts.
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>ReportRunEntryEntityDomainListing</returns>
        ReportRunEntryEntityDomainListing GetReportingSchedulesScheduleIdHistory (string scheduleId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get list of completed scheduled report jobs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>ApiResponse of ReportRunEntryEntityDomainListing</returns>
        ApiResponse<ReportRunEntryEntityDomainListing> GetReportingSchedulesScheduleIdHistoryWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Get most recently completed scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportRunEntry</returns>
        ReportRunEntry GetReportingSchedulesScheduleIdHistoryLatest (string scheduleId);

        /// <summary>
        /// Get most recently completed scheduled report job.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">title, startTime, endTime, description or unread (optional, default to startTime)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>ApiResponse of AlertEntityListing</returns>
        ApiResponse<AlertEntityListing> AnalyticsAlertingAlertsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// A count of unread alerts.
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportRunEntry</returns>
        ApiResponse<ReportRunEntry> GetReportingSchedulesScheduleIdHistoryLatestWithHttpInfo (string scheduleId);
        /// <summary>
        /// A completed scheduled report job
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// A completed scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>UnreadMetric</returns>
        UnreadMetric AnalyticsAlertingAlertsUnreadGet ();

        /// <summary>
        /// A count of unread alerts.
=======
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportRunEntry</returns>
        ReportRunEntry GetReportingSchedulesScheduleIdHistoryRunId (string runId, string scheduleId);

        /// <summary>
        /// A completed scheduled report job
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// A completed scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of UnreadMetric</returns>
        ApiResponse<UnreadMetric> AnalyticsAlertingAlertsUnreadGetWithHttpInfo ();
=======
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportRunEntry</returns>
        ApiResponse<ReportRunEntry> GetReportingSchedulesScheduleIdHistoryRunIdWithHttpInfo (string runId, string scheduleId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get a list of report time periods.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">title, description, inAlarm or enabled (optional, default to title)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>RuleEntityListing</returns>
        RuleEntityListing AnalyticsAlertingRulesGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
=======
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetReportingTimeperiods ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get a list of report time periods.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">title, description, inAlarm or enabled (optional, default to title)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>ApiResponse of RuleEntityListing</returns>
        ApiResponse<RuleEntityListing> AnalyticsAlertingRulesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
=======
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> GetReportingTimeperiodsWithHttpInfo ();
        /// <summary>
        /// Query for conversation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>AggregateQueryResponse</returns>
        AggregateQueryResponse PostConversationsAggregatesQuery (AggregationQuery body = null);

        /// <summary>
        /// Query for conversation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of AggregateQueryResponse</returns>
        ApiResponse<AggregateQueryResponse> PostConversationsAggregatesQueryWithHttpInfo (AggregationQuery body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Index conversation properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Rule (optional)</param>
        /// <returns>Rule</returns>
        Rule AnalyticsAlertingRulesPost (Rule body = null);
=======
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request (optional)</param>
        /// <returns>PropertyIndexRequest</returns>
        PropertyIndexRequest PostConversationsConversationIdDetailsProperties (string conversationId, PropertyIndexRequest body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Index conversation properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Rule (optional)</param>
        /// <returns>ApiResponse of Rule</returns>
        ApiResponse<Rule> AnalyticsAlertingRulesPostWithHttpInfo (Rule body = null);
        /// <summary>
        /// Delete an alerting rule.
=======
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request (optional)</param>
        /// <returns>ApiResponse of PropertyIndexRequest</returns>
        ApiResponse<PropertyIndexRequest> PostConversationsConversationIdDetailsPropertiesWithHttpInfo (string conversationId, PropertyIndexRequest body = null);
        /// <summary>
        /// Query for conversation details
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="ruleId">Rule ID</param>
        /// <returns></returns>
        void AnalyticsAlertingRulesRuleidDelete (string ruleId);

        /// <summary>
        /// Delete an alerting rule.
=======
        /// <param name="body">query (optional)</param>
        /// <returns>AnalyticsConversationQueryResponse</returns>
        AnalyticsConversationQueryResponse PostConversationsDetailsQuery (ConversationQuery body = null);

        /// <summary>
        /// Query for conversation details
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AnalyticsAlertingRulesRuleidDeleteWithHttpInfo (string ruleId);
=======
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of AnalyticsConversationQueryResponse</returns>
        ApiResponse<AnalyticsConversationQueryResponse> PostConversationsDetailsQueryWithHttpInfo (ConversationQuery body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Rule</returns>
        Rule AnalyticsAlertingRulesRuleidGet (string ruleId);
=======
        /// <param name="body">query (optional)</param>
        /// <returns>AggregateQueryResponse</returns>
        AggregateQueryResponse PostEvaluationsAggregatesQuery (AggregationQuery body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of Rule</returns>
        ApiResponse<Rule> AnalyticsAlertingRulesRuleidGetWithHttpInfo (string ruleId);
=======
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of AggregateQueryResponse</returns>
        ApiResponse<AggregateQueryResponse> PostEvaluationsAggregatesQueryWithHttpInfo (AggregationQuery body = null);
        /// <summary>
        /// Query for queue observations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>ObservationQueryResponse</returns>
        ObservationQueryResponse PostQueuesObservationsQuery (ObservationQuery body = null);

        /// <summary>
        /// Query for queue observations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of ObservationQueryResponse</returns>
        ApiResponse<ObservationQueryResponse> PostQueuesObservationsQueryWithHttpInfo (ObservationQuery body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Create a scheduled report job
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Rule</returns>
        Rule AnalyticsAlertingRulesRuleidPut (string ruleId, Rule body = null);
=======
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ReportSchedule</returns>
        ReportSchedule PostReportingSchedules (ReportSchedule body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Create a scheduled report job
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule (optional)</param>
        /// <returns>ApiResponse of Rule</returns>
        ApiResponse<Rule> AnalyticsAlertingRulesRuleidPutWithHttpInfo (string ruleId, Rule body = null);
        /// <summary>
        /// Executes a metrics query against the analytics service
=======
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        ApiResponse<ReportSchedule> PostReportingSchedulesWithHttpInfo (ReportSchedule body = null);
        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">queryObject (optional)</param>
        /// <returns></returns>
        void AnalyticsMetricsQueryPost (Object body = null);

        /// <summary>
        /// Executes a metrics query against the analytics service
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>RunNowResponse</returns>
        RunNowResponse PostReportingSchedulesScheduleIdRunreport (string scheduleId);

        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">queryObject (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AnalyticsMetricsQueryPostWithHttpInfo (Object body = null);
        /// <summary>
        /// Get list of reporting metadata.
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of RunNowResponse</returns>
        ApiResponse<RunNowResponse> PostReportingSchedulesScheduleIdRunreportWithHttpInfo (string scheduleId);
        /// <summary>
        /// Query for user aggregates
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ReportMetaDataEntityListing</returns>
        ReportMetaDataEntityListing AnalyticsReportingMetadataGet (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null);

        /// <summary>
        /// Get list of reporting metadata.
=======
        /// <param name="body">query (optional)</param>
        /// <returns>PresenceQueryResponse</returns>
        PresenceQueryResponse PostUsersAggregatesQuery (AggregationQuery body = null);

        /// <summary>
        /// Query for user aggregates
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ApiResponse of ReportMetaDataEntityListing</returns>
        ApiResponse<ReportMetaDataEntityListing> AnalyticsReportingMetadataGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null);
        /// <summary>
        /// Get a list of report formats
=======
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of PresenceQueryResponse</returns>
        ApiResponse<PresenceQueryResponse> PostUsersAggregatesQueryWithHttpInfo (AggregationQuery body = null);
        /// <summary>
        /// Query for user observations
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>List&lt;string&gt;</returns>
        List<string> AnalyticsReportingReportformatsGet ();

        /// <summary>
        /// Get a list of report formats
=======
        /// <param name="body">query (optional)</param>
        /// <returns>ObservationQueryResponse</returns>
        ObservationQueryResponse PostUsersObservationsQuery (ObservationQuery body = null);

        /// <summary>
        /// Query for user observations
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> AnalyticsReportingReportformatsGetWithHttpInfo ();
        /// <summary>
        /// Get a reporting metadata.
=======
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of ObservationQueryResponse</returns>
        ApiResponse<ObservationQueryResponse> PostUsersObservationsQueryWithHttpInfo (ObservationQuery body = null);
        /// <summary>
        /// Update a scheduled report job.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ReportMetaData</returns>
        ReportMetaData AnalyticsReportingReportidMetadataGet (string reportId, string acceptLanguage = null, string locale = null);

        /// <summary>
        /// Get a reporting metadata.
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ReportSchedule</returns>
        ReportSchedule PutReportingSchedulesScheduleId (string scheduleId, ReportSchedule body = null);

        /// <summary>
        /// Update a scheduled report job.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ApiResponse of ReportMetaData</returns>
        ApiResponse<ReportMetaData> AnalyticsReportingReportidMetadataGetWithHttpInfo (string reportId, string acceptLanguage = null, string locale = null);
        /// <summary>
        /// Get a list of scheduled report jobs
        /// </summary>
        /// <remarks>
        /// Get a list of scheduled report jobs.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ReportScheduleEntityListing</returns>
        ReportScheduleEntityListing AnalyticsReportingSchedulesGet (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of scheduled report jobs
        /// </summary>
        /// <remarks>
        /// Get a list of scheduled report jobs.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of ReportScheduleEntityListing</returns>
        ApiResponse<ReportScheduleEntityListing> AnalyticsReportingSchedulesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Create a scheduled report job
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ReportSchedule</returns>
        ReportSchedule AnalyticsReportingSchedulesPost (ReportSchedule body = null);

        /// <summary>
        /// Create a scheduled report job
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        ApiResponse<ReportSchedule> AnalyticsReportingSchedulesPostWithHttpInfo (ReportSchedule body = null);
        /// <summary>
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        ApiResponse<ReportSchedule> PutReportingSchedulesScheduleIdWithHttpInfo (string scheduleId, ReportSchedule body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
<<<<<<< HEAD
        /// <returns>string</returns>
        string AnalyticsReportingSchedulesScheduleidDelete (string scheduleId);
=======
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteReportingSchedulesScheduleIdAsync (string scheduleId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
<<<<<<< HEAD
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AnalyticsReportingSchedulesScheduleidDeleteWithHttpInfo (string scheduleId);
        /// <summary>
        /// Get a scheduled report job.
=======
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteReportingSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId);
        /// <summary>
        /// Get a conversation by id
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportSchedule</returns>
        ReportSchedule AnalyticsReportingSchedulesScheduleidGet (string scheduleId);

        /// <summary>
        /// Get a scheduled report job.
=======
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of AnalyticsConversation</returns>
        System.Threading.Tasks.Task<AnalyticsConversation> GetConversationsConversationIdDetailsAsync (string conversationId);

        /// <summary>
        /// Get a conversation by id
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        ApiResponse<ReportSchedule> AnalyticsReportingSchedulesScheduleidGetWithHttpInfo (string scheduleId);
        /// <summary>
        /// Get list of completed scheduled report jobs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>ReportRunEntryEntityDomainListing</returns>
        ReportRunEntryEntityDomainListing AnalyticsReportingSchedulesScheduleidHistoryGet (string scheduleId, int? pageNumber = null, int? pageSize = null);

=======
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (AnalyticsConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnalyticsConversation>> GetConversationsConversationIdDetailsAsyncWithHttpInfo (string conversationId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get list of completed scheduled report jobs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>ApiResponse of ReportRunEntryEntityDomainListing</returns>
        ApiResponse<ReportRunEntryEntityDomainListing> AnalyticsReportingSchedulesScheduleidHistoryGetWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Get most recently completed scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportRunEntry</returns>
        ReportRunEntry AnalyticsReportingSchedulesScheduleidHistoryLatestGet (string scheduleId);
=======
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ReportMetaDataEntityListing</returns>
        System.Threading.Tasks.Task<ReportMetaDataEntityListing> GetReportingMetadataAsync (int? pageNumber = null, int? pageSize = null, string locale = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get most recently completed scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportRunEntry</returns>
        ApiResponse<ReportRunEntry> AnalyticsReportingSchedulesScheduleidHistoryLatestGetWithHttpInfo (string scheduleId);
        /// <summary>
        /// A completed scheduled report job
        /// </summary>
        /// <remarks>
        /// A completed scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportRunEntry</returns>
        ReportRunEntry AnalyticsReportingSchedulesScheduleidHistoryRunidGet (string runId, string scheduleId);

        /// <summary>
        /// A completed scheduled report job
        /// </summary>
        /// <remarks>
        /// A completed scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportRunEntry</returns>
        ApiResponse<ReportRunEntry> AnalyticsReportingSchedulesScheduleidHistoryRunidGetWithHttpInfo (string runId, string scheduleId);
        /// <summary>
        /// Update a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ReportSchedule</returns>
        ReportSchedule AnalyticsReportingSchedulesScheduleidPut (string scheduleId, ReportSchedule body = null);

        /// <summary>
        /// Update a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        ApiResponse<ReportSchedule> AnalyticsReportingSchedulesScheduleidPutWithHttpInfo (string scheduleId, ReportSchedule body = null);
        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>RunNowResponse</returns>
        RunNowResponse AnalyticsReportingSchedulesScheduleidRunreportPost (string scheduleId);

        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of RunNowResponse</returns>
        ApiResponse<RunNowResponse> AnalyticsReportingSchedulesScheduleidRunreportPostWithHttpInfo (string scheduleId);
        /// <summary>
        /// Get a list of report time periods.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;string&gt;</returns>
        List<string> AnalyticsReportingTimeperiodsGet ();

        /// <summary>
        /// Get a list of report time periods.
=======
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ApiResponse (ReportMetaDataEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportMetaDataEntityListing>> GetReportingMetadataAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string locale = null);
        /// <summary>
        /// Get a reporting metadata.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Report ID</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ReportMetaData</returns>
        System.Threading.Tasks.Task<ReportMetaData> GetReportingReportIdMetadataAsync (string reportId, string locale = null);

        /// <summary>
        /// Get a reporting metadata.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> AnalyticsReportingTimeperiodsGetWithHttpInfo ();
        /// <summary>
        /// Executes a segments query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">queryObject (optional)</param>
        /// <returns></returns>
        void AnalyticsSegmentsQueryPost (Object body = null);

=======
        /// <param name="reportId">Report ID</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ApiResponse (ReportMetaData)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportMetaData>> GetReportingReportIdMetadataAsyncWithHttpInfo (string reportId, string locale = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Executes a segments query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">queryObject (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AnalyticsSegmentsQueryPostWithHttpInfo (Object body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AnalyticsAlertingAlertsAlertidDeleteAsync (string alertId);
=======
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> GetReportingReportformatsAsync ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Delete an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsAlertingAlertsAlertidDeleteAsyncWithHttpInfo (string alertId);
        /// <summary>
        /// Get an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of Alert</returns>
        System.Threading.Tasks.Task<Alert> AnalyticsAlertingAlertsAlertidGetAsync (string alertId);

        /// <summary>
        /// Get an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse (Alert)</returns>
        System.Threading.Tasks.Task<ApiResponse<Alert>> AnalyticsAlertingAlertsAlertidGetAsyncWithHttpInfo (string alertId);
        /// <summary>
        /// Update an alerts unread status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert (optional)</param>
        /// <returns>Task of Alert</returns>
        System.Threading.Tasks.Task<Alert> AnalyticsAlertingAlertsAlertidPutAsync (string alertId, Alert body = null);

=======
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> GetReportingReportformatsAsyncWithHttpInfo ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Update an alerts unread status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert (optional)</param>
        /// <returns>Task of ApiResponse (Alert)</returns>
        System.Threading.Tasks.Task<ApiResponse<Alert>> AnalyticsAlertingAlertsAlertidPutAsyncWithHttpInfo (string alertId, Alert body = null);
        /// <summary>
        /// Get a list of alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">title, startTime, endTime, description or unread (optional, default to startTime)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of AlertEntityListing</returns>
        System.Threading.Tasks.Task<AlertEntityListing> AnalyticsAlertingAlertsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
=======
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ReportScheduleEntityListing</returns>
        System.Threading.Tasks.Task<ReportScheduleEntityListing> GetReportingSchedulesAsync (int? pageNumber = null, int? pageSize = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get a list of alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
<<<<<<< HEAD
        /// <param name="sortBy">title, startTime, endTime, description or unread (optional, default to startTime)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (AlertEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlertEntityListing>> AnalyticsAlertingAlertsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// A count of unread alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UnreadMetric</returns>
        System.Threading.Tasks.Task<UnreadMetric> AnalyticsAlertingAlertsUnreadGetAsync ();

        /// <summary>
        /// A count of unread alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UnreadMetric)</returns>
        System.Threading.Tasks.Task<ApiResponse<UnreadMetric>> AnalyticsAlertingAlertsUnreadGetAsyncWithHttpInfo ();
        /// <summary>
        /// Get a list of rules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">title, description, inAlarm or enabled (optional, default to title)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of RuleEntityListing</returns>
        System.Threading.Tasks.Task<RuleEntityListing> AnalyticsAlertingRulesGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of rules.
=======
        /// <returns>Task of ApiResponse (ReportScheduleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportScheduleEntityListing>> GetReportingSchedulesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Get a scheduled report job.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">title, description, inAlarm or enabled (optional, default to title)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (RuleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleEntityListing>> AnalyticsAlertingRulesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Task of Rule</returns>
        System.Threading.Tasks.Task<Rule> AnalyticsAlertingRulesPostAsync (Rule body = null);

        /// <summary>
        /// Create an alerting rule.
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportSchedule</returns>
        System.Threading.Tasks.Task<ReportSchedule> GetReportingSchedulesScheduleIdAsync (string scheduleId);

        /// <summary>
        /// Get a scheduled report job.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Rule (optional)</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Rule>> AnalyticsAlertingRulesPostAsyncWithHttpInfo (Rule body = null);
        /// <summary>
        /// Delete an alerting rule.
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> GetReportingSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId);
        /// <summary>
        /// Get list of completed scheduled report jobs.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AnalyticsAlertingRulesRuleidDeleteAsync (string ruleId);

        /// <summary>
        /// Delete an alerting rule.
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>Task of ReportRunEntryEntityDomainListing</returns>
        System.Threading.Tasks.Task<ReportRunEntryEntityDomainListing> GetReportingSchedulesScheduleIdHistoryAsync (string scheduleId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get list of completed scheduled report jobs.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsAlertingRulesRuleidDeleteAsyncWithHttpInfo (string ruleId);
        /// <summary>
        /// Get an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of Rule</returns>
        System.Threading.Tasks.Task<Rule> AnalyticsAlertingRulesRuleidGetAsync (string ruleId);

        /// <summary>
        /// Get an alerting rule.
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ReportRunEntryEntityDomainListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportRunEntryEntityDomainListing>> GetReportingSchedulesScheduleIdHistoryAsyncWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Get most recently completed scheduled report job.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Rule>> AnalyticsAlertingRulesRuleidGetAsyncWithHttpInfo (string ruleId);
        /// <summary>
        /// Update an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Task of Rule</returns>
        System.Threading.Tasks.Task<Rule> AnalyticsAlertingRulesRuleidPutAsync (string ruleId, Rule body = null);

        /// <summary>
        /// Update an alerting rule.
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        System.Threading.Tasks.Task<ReportRunEntry> GetReportingSchedulesScheduleIdHistoryLatestAsync (string scheduleId);

        /// <summary>
        /// Get most recently completed scheduled report job.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Rule>> AnalyticsAlertingRulesRuleidPutAsyncWithHttpInfo (string ruleId, Rule body = null);
        /// <summary>
        /// Executes a metrics query against the analytics service
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> GetReportingSchedulesScheduleIdHistoryLatestAsyncWithHttpInfo (string scheduleId);
        /// <summary>
        /// A completed scheduled report job
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// A completed scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">queryObject (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AnalyticsMetricsQueryPostAsync (Object body = null);

        /// <summary>
        /// Executes a metrics query against the analytics service
=======
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        System.Threading.Tasks.Task<ReportRunEntry> GetReportingSchedulesScheduleIdHistoryRunIdAsync (string runId, string scheduleId);

        /// <summary>
        /// A completed scheduled report job
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// A completed scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">queryObject (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsMetricsQueryPostAsyncWithHttpInfo (Object body = null);
        /// <summary>
        /// Get list of reporting metadata.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ReportMetaDataEntityListing</returns>
        System.Threading.Tasks.Task<ReportMetaDataEntityListing> AnalyticsReportingMetadataGetAsync (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null);

        /// <summary>
        /// Get list of reporting metadata.
=======
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> GetReportingSchedulesScheduleIdHistoryRunIdAsyncWithHttpInfo (string runId, string scheduleId);
        /// <summary>
        /// Get a list of report time periods.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ApiResponse (ReportMetaDataEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportMetaDataEntityListing>> AnalyticsReportingMetadataGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null);
        /// <summary>
        /// Get a list of report formats
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> AnalyticsReportingReportformatsGetAsync ();

        /// <summary>
        /// Get a list of report formats
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> AnalyticsReportingReportformatsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Get a reporting metadata.
=======
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> GetReportingTimeperiodsAsync ();

        /// <summary>
        /// Get a list of report time periods.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ReportMetaData</returns>
        System.Threading.Tasks.Task<ReportMetaData> AnalyticsReportingReportidMetadataGetAsync (string reportId, string acceptLanguage = null, string locale = null);

        /// <summary>
        /// Get a reporting metadata.
=======
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> GetReportingTimeperiodsAsyncWithHttpInfo ();
        /// <summary>
        /// Query for conversation aggregates
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ApiResponse (ReportMetaData)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportMetaData>> AnalyticsReportingReportidMetadataGetAsyncWithHttpInfo (string reportId, string acceptLanguage = null, string locale = null);
        /// <summary>
        /// Get a list of scheduled report jobs
        /// </summary>
        /// <remarks>
        /// Get a list of scheduled report jobs.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ReportScheduleEntityListing</returns>
        System.Threading.Tasks.Task<ReportScheduleEntityListing> AnalyticsReportingSchedulesGetAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of scheduled report jobs
        /// </summary>
        /// <remarks>
        /// Get a list of scheduled report jobs.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ReportScheduleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportScheduleEntityListing>> AnalyticsReportingSchedulesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Create a scheduled report job
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ReportSchedule</returns>
        System.Threading.Tasks.Task<ReportSchedule> AnalyticsReportingSchedulesPostAsync (ReportSchedule body = null);

        /// <summary>
        /// Create a scheduled report job
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of AggregateQueryResponse</returns>
        System.Threading.Tasks.Task<AggregateQueryResponse> PostConversationsAggregatesQueryAsync (AggregationQuery body = null);

        /// <summary>
        /// Query for conversation aggregates
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesPostAsyncWithHttpInfo (ReportSchedule body = null);
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (AggregateQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AggregateQueryResponse>> PostConversationsAggregatesQueryAsyncWithHttpInfo (AggregationQuery body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Index conversation properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AnalyticsReportingSchedulesScheduleidDeleteAsync (string scheduleId);
=======
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request (optional)</param>
        /// <returns>Task of PropertyIndexRequest</returns>
        System.Threading.Tasks.Task<PropertyIndexRequest> PostConversationsConversationIdDetailsPropertiesAsync (string conversationId, PropertyIndexRequest body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Index conversation properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AnalyticsReportingSchedulesScheduleidDeleteAsyncWithHttpInfo (string scheduleId);
        /// <summary>
        /// Get a scheduled report job.
=======
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request (optional)</param>
        /// <returns>Task of ApiResponse (PropertyIndexRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropertyIndexRequest>> PostConversationsConversationIdDetailsPropertiesAsyncWithHttpInfo (string conversationId, PropertyIndexRequest body = null);
        /// <summary>
        /// Query for conversation details
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportSchedule</returns>
        System.Threading.Tasks.Task<ReportSchedule> AnalyticsReportingSchedulesScheduleidGetAsync (string scheduleId);

        /// <summary>
        /// Get a scheduled report job.
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of AnalyticsConversationQueryResponse</returns>
        System.Threading.Tasks.Task<AnalyticsConversationQueryResponse> PostConversationsDetailsQueryAsync (ConversationQuery body = null);

        /// <summary>
        /// Query for conversation details
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesScheduleidGetAsyncWithHttpInfo (string scheduleId);
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (AnalyticsConversationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnalyticsConversationQueryResponse>> PostConversationsDetailsQueryAsyncWithHttpInfo (ConversationQuery body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>Task of ReportRunEntryEntityDomainListing</returns>
        System.Threading.Tasks.Task<ReportRunEntryEntityDomainListing> AnalyticsReportingSchedulesScheduleidHistoryGetAsync (string scheduleId, int? pageNumber = null, int? pageSize = null);
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of AggregateQueryResponse</returns>
        System.Threading.Tasks.Task<AggregateQueryResponse> PostEvaluationsAggregatesQueryAsync (AggregationQuery body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ReportRunEntryEntityDomainListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportRunEntryEntityDomainListing>> AnalyticsReportingSchedulesScheduleidHistoryGetAsyncWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Get most recently completed scheduled report job.
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (AggregateQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AggregateQueryResponse>> PostEvaluationsAggregatesQueryAsyncWithHttpInfo (AggregationQuery body = null);
        /// <summary>
        /// Query for queue observations
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        System.Threading.Tasks.Task<ReportRunEntry> AnalyticsReportingSchedulesScheduleidHistoryLatestGetAsync (string scheduleId);

        /// <summary>
        /// Get most recently completed scheduled report job.
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ObservationQueryResponse</returns>
        System.Threading.Tasks.Task<ObservationQueryResponse> PostQueuesObservationsQueryAsync (ObservationQuery body = null);

        /// <summary>
        /// Query for queue observations
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> AnalyticsReportingSchedulesScheduleidHistoryLatestGetAsyncWithHttpInfo (string scheduleId);
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (ObservationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObservationQueryResponse>> PostQueuesObservationsQueryAsyncWithHttpInfo (ObservationQuery body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Create a scheduled report job
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        System.Threading.Tasks.Task<ReportRunEntry> AnalyticsReportingSchedulesScheduleidHistoryRunidGetAsync (string runId, string scheduleId);

        /// <summary>
        /// A completed scheduled report job
        /// </summary>
        /// <remarks>
        /// A completed scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> AnalyticsReportingSchedulesScheduleidHistoryRunidGetAsyncWithHttpInfo (string runId, string scheduleId);
        /// <summary>
        /// Update a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ReportSchedule</returns>
        System.Threading.Tasks.Task<ReportSchedule> AnalyticsReportingSchedulesScheduleidPutAsync (string scheduleId, ReportSchedule body = null);

        /// <summary>
        /// Update a scheduled report job.
=======
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ReportSchedule</returns>
        System.Threading.Tasks.Task<ReportSchedule> PostReportingSchedulesAsync (ReportSchedule body = null);

        /// <summary>
        /// Create a scheduled report job
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesScheduleidPutAsyncWithHttpInfo (string scheduleId, ReportSchedule body = null);
=======
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> PostReportingSchedulesAsyncWithHttpInfo (ReportSchedule body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of RunNowResponse</returns>
        System.Threading.Tasks.Task<RunNowResponse> PostReportingSchedulesScheduleIdRunreportAsync (string scheduleId);

        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (RunNowResponse)</returns>
<<<<<<< HEAD
        System.Threading.Tasks.Task<ApiResponse<RunNowResponse>> AnalyticsReportingSchedulesScheduleidRunreportPostAsyncWithHttpInfo (string scheduleId);
        /// <summary>
        /// Get a list of report time periods.
=======
        System.Threading.Tasks.Task<ApiResponse<RunNowResponse>> PostReportingSchedulesScheduleIdRunreportAsyncWithHttpInfo (string scheduleId);
        /// <summary>
        /// Query for user aggregates
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> AnalyticsReportingTimeperiodsGetAsync ();

        /// <summary>
        /// Get a list of report time periods.
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of PresenceQueryResponse</returns>
        System.Threading.Tasks.Task<PresenceQueryResponse> PostUsersAggregatesQueryAsync (AggregationQuery body = null);

        /// <summary>
        /// Query for user aggregates
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> AnalyticsReportingTimeperiodsGetAsyncWithHttpInfo ();
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (PresenceQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PresenceQueryResponse>> PostUsersAggregatesQueryAsyncWithHttpInfo (AggregationQuery body = null);
        /// <summary>
        /// Query for user observations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ObservationQueryResponse</returns>
        System.Threading.Tasks.Task<ObservationQueryResponse> PostUsersObservationsQueryAsync (ObservationQuery body = null);

        /// <summary>
        /// Query for user observations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (ObservationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObservationQueryResponse>> PostUsersObservationsQueryAsyncWithHttpInfo (ObservationQuery body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Update a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">queryObject (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AnalyticsSegmentsQueryPostAsync (Object body = null);
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ReportSchedule</returns>
        System.Threading.Tasks.Task<ReportSchedule> PutReportingSchedulesScheduleIdAsync (string scheduleId, ReportSchedule body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Update a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">queryObject (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsSegmentsQueryPostAsyncWithHttpInfo (Object body = null);
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> PutReportingSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId, ReportSchedule body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AnalyticsApi : IAnalyticsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AnalyticsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AnalyticsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
<<<<<<< HEAD

        /// <summary>
        /// Delete an alert. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns></returns>
        public void AnalyticsAlertingAlertsAlertidDelete (string alertId)
        {
             AnalyticsAlertingAlertsAlertidDeleteWithHttpInfo(alertId);
        }

        /// <summary>
        /// Delete an alert. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AnalyticsAlertingAlertsAlertidDeleteWithHttpInfo (string alertId)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsApi->AnalyticsAlertingAlertsAlertidDelete");

            var localVarPath = "/api/v1/analytics/alerting/alerts/{alertId}";
=======

        /// <summary>
        /// Delete a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>string</returns>
        public string DeleteReportingSchedulesScheduleId (string scheduleId)
        {
             ApiResponse<string> localVarResponse = DeleteReportingSchedulesScheduleIdWithHttpInfo(scheduleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteReportingSchedulesScheduleIdWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->DeleteReportingSchedulesScheduleId");

            var localVarPath = "/api/v2/analytics/reporting/schedules/{scheduleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReportingSchedulesScheduleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReportingSchedulesScheduleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteReportingSchedulesScheduleIdAsync (string scheduleId)
        {
             ApiResponse<string> localVarResponse = await DeleteReportingSchedulesScheduleIdAsyncWithHttpInfo(scheduleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteReportingSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->DeleteReportingSchedulesScheduleId");

            var localVarPath = "/api/v2/analytics/reporting/schedules/{scheduleId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
<<<<<<< HEAD
                "application/json"
            };
=======
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReportingSchedulesScheduleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReportingSchedulesScheduleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>AnalyticsConversation</returns>
        public AnalyticsConversation GetConversationsConversationIdDetails (string conversationId)
        {
             ApiResponse<AnalyticsConversation> localVarResponse = GetConversationsConversationIdDetailsWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of AnalyticsConversation</returns>
        public ApiResponse< AnalyticsConversation > GetConversationsConversationIdDetailsWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling AnalyticsApi->GetConversationsConversationIdDetails");

            var localVarPath = "/api/v2/analytics/conversations/{conversationId}/details";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (alertId != null) localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter
=======
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdDetails: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdDetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversation)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete an alert. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AnalyticsAlertingAlertsAlertidDeleteAsync (string alertId)
        {
             await AnalyticsAlertingAlertsAlertidDeleteAsyncWithHttpInfo(alertId);
=======
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of AnalyticsConversation</returns>
        public async System.Threading.Tasks.Task<AnalyticsConversation> GetConversationsConversationIdDetailsAsync (string conversationId)
        {
             ApiResponse<AnalyticsConversation> localVarResponse = await GetConversationsConversationIdDetailsAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
        /// Delete an alert. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsAlertingAlertsAlertidDeleteAsyncWithHttpInfo (string alertId)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsApi->AnalyticsAlertingAlertsAlertidDelete");

            var localVarPath = "/api/v1/analytics/alerting/alerts/{alertId}";
=======
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (AnalyticsConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnalyticsConversation>> GetConversationsConversationIdDetailsAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling AnalyticsApi->GetConversationsConversationIdDetails");

            var localVarPath = "/api/v2/analytics/conversations/{conversationId}/details";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (alertId != null) localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter
=======
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdDetails: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdDetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversation)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get list of reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <returns>Alert</returns>
        public Alert AnalyticsAlertingAlertsAlertidGet (string alertId)
        {
             ApiResponse<Alert> localVarResponse = AnalyticsAlertingAlertsAlertidGetWithHttpInfo(alertId);
=======
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ReportMetaDataEntityListing</returns>
        public ReportMetaDataEntityListing GetReportingMetadata (int? pageNumber = null, int? pageSize = null, string locale = null)
        {
             ApiResponse<ReportMetaDataEntityListing> localVarResponse = GetReportingMetadataWithHttpInfo(pageNumber, pageSize, locale);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of Alert</returns>
        public ApiResponse< Alert > AnalyticsAlertingAlertsAlertidGetWithHttpInfo (string alertId)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsApi->AnalyticsAlertingAlertsAlertidGet");

            var localVarPath = "/api/v1/analytics/alerting/alerts/{alertId}";
=======
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ApiResponse of ReportMetaDataEntityListing</returns>
        public ApiResponse< ReportMetaDataEntityListing > GetReportingMetadataWithHttpInfo (int? pageNumber = null, int? pageSize = null, string locale = null)
        {

            var localVarPath = "/api/v2/analytics/reporting/metadata";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (alertId != null) localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter
=======
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Alert>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Alert) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Alert)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingMetadata: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingMetadata: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportMetaDataEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaDataEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportMetaDataEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get list of reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of Alert</returns>
        public async System.Threading.Tasks.Task<Alert> AnalyticsAlertingAlertsAlertidGetAsync (string alertId)
        {
             ApiResponse<Alert> localVarResponse = await AnalyticsAlertingAlertsAlertidGetAsyncWithHttpInfo(alertId);
=======
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ReportMetaDataEntityListing</returns>
        public async System.Threading.Tasks.Task<ReportMetaDataEntityListing> GetReportingMetadataAsync (int? pageNumber = null, int? pageSize = null, string locale = null)
        {
             ApiResponse<ReportMetaDataEntityListing> localVarResponse = await GetReportingMetadataAsyncWithHttpInfo(pageNumber, pageSize, locale);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse (Alert)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Alert>> AnalyticsAlertingAlertsAlertidGetAsyncWithHttpInfo (string alertId)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsApi->AnalyticsAlertingAlertsAlertidGet");

            var localVarPath = "/api/v1/analytics/alerting/alerts/{alertId}";
=======
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ApiResponse (ReportMetaDataEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportMetaDataEntityListing>> GetReportingMetadataAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string locale = null)
        {

            var localVarPath = "/api/v2/analytics/reporting/metadata";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (alertId != null) localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter
=======
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Alert>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Alert) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Alert)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingMetadata: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingMetadata: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportMetaDataEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaDataEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportMetaDataEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get a reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert (optional)</param>
        /// <returns>Alert</returns>
        public Alert AnalyticsAlertingAlertsAlertidPut (string alertId, Alert body = null)
        {
             ApiResponse<Alert> localVarResponse = AnalyticsAlertingAlertsAlertidPutWithHttpInfo(alertId, body);
=======
        /// <param name="reportId">Report ID</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ReportMetaData</returns>
        public ReportMetaData GetReportingReportIdMetadata (string reportId, string locale = null)
        {
             ApiResponse<ReportMetaData> localVarResponse = GetReportingReportIdMetadataWithHttpInfo(reportId, locale);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert (optional)</param>
        /// <returns>ApiResponse of Alert</returns>
        public ApiResponse< Alert > AnalyticsAlertingAlertsAlertidPutWithHttpInfo (string alertId, Alert body = null)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsApi->AnalyticsAlertingAlertsAlertidPut");

            var localVarPath = "/api/v1/analytics/alerting/alerts/{alertId}";
=======
        /// <param name="reportId">Report ID</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ApiResponse of ReportMetaData</returns>
        public ApiResponse< ReportMetaData > GetReportingReportIdMetadataWithHttpInfo (string reportId, string locale = null)
        {
            // verify the required parameter 'reportId' is set
            if (reportId == null)
                throw new ApiException(400, "Missing required parameter 'reportId' when calling AnalyticsApi->GetReportingReportIdMetadata");

            var localVarPath = "/api/v2/analytics/reporting/{reportId}/metadata";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (alertId != null) localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (reportId != null) localVarPathParams.Add("reportId", Configuration.ApiClient.ParameterToString(reportId)); // path parameter
            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Alert>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Alert) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Alert)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingReportIdMetadata: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingReportIdMetadata: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportMetaData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportMetaData)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get a reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert (optional)</param>
        /// <returns>Task of Alert</returns>
        public async System.Threading.Tasks.Task<Alert> AnalyticsAlertingAlertsAlertidPutAsync (string alertId, Alert body = null)
        {
             ApiResponse<Alert> localVarResponse = await AnalyticsAlertingAlertsAlertidPutAsyncWithHttpInfo(alertId, body);
=======
        /// <param name="reportId">Report ID</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ReportMetaData</returns>
        public async System.Threading.Tasks.Task<ReportMetaData> GetReportingReportIdMetadataAsync (string reportId, string locale = null)
        {
             ApiResponse<ReportMetaData> localVarResponse = await GetReportingReportIdMetadataAsyncWithHttpInfo(reportId, locale);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert (optional)</param>
        /// <returns>Task of ApiResponse (Alert)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Alert>> AnalyticsAlertingAlertsAlertidPutAsyncWithHttpInfo (string alertId, Alert body = null)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsApi->AnalyticsAlertingAlertsAlertidPut");

            var localVarPath = "/api/v1/analytics/alerting/alerts/{alertId}";
=======
        /// <param name="reportId">Report ID</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ApiResponse (ReportMetaData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportMetaData>> GetReportingReportIdMetadataAsyncWithHttpInfo (string reportId, string locale = null)
        {
            // verify the required parameter 'reportId' is set
            if (reportId == null)
                throw new ApiException(400, "Missing required parameter 'reportId' when calling AnalyticsApi->GetReportingReportIdMetadata");

            var localVarPath = "/api/v2/analytics/reporting/{reportId}/metadata";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (alertId != null) localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (reportId != null) localVarPathParams.Add("reportId", Configuration.ApiClient.ParameterToString(reportId)); // path parameter
            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Alert>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Alert) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Alert)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingReportIdMetadata: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingReportIdMetadata: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportMetaData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportMetaData)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of alerts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">title, startTime, endTime, description or unread (optional, default to startTime)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>AlertEntityListing</returns>
        public AlertEntityListing AnalyticsAlertingAlertsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<AlertEntityListing> localVarResponse = AnalyticsAlertingAlertsGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
=======
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetReportingReportformats ()
        {
             ApiResponse<List<string>> localVarResponse = GetReportingReportformatsWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of alerts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">title, startTime, endTime, description or unread (optional, default to startTime)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>ApiResponse of AlertEntityListing</returns>
        public ApiResponse< AlertEntityListing > AnalyticsAlertingAlertsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/analytics/alerting/alerts";
=======
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > GetReportingReportformatsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/analytics/reporting/reportformats";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AlertEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AlertEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AlertEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingReportformats: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingReportformats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of alerts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">title, startTime, endTime, description or unread (optional, default to startTime)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of AlertEntityListing</returns>
        public async System.Threading.Tasks.Task<AlertEntityListing> AnalyticsAlertingAlertsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<AlertEntityListing> localVarResponse = await AnalyticsAlertingAlertsGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
=======
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> GetReportingReportformatsAsync ()
        {
             ApiResponse<List<string>> localVarResponse = await GetReportingReportformatsAsyncWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of alerts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">title, startTime, endTime, description or unread (optional, default to startTime)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (AlertEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AlertEntityListing>> AnalyticsAlertingAlertsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/analytics/alerting/alerts";
=======
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> GetReportingReportformatsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/analytics/reporting/reportformats";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AlertEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AlertEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AlertEntityListing)));
            
        }

        /// <summary>
        /// A count of unread alerts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UnreadMetric</returns>
        public UnreadMetric AnalyticsAlertingAlertsUnreadGet ()
        {
             ApiResponse<UnreadMetric> localVarResponse = AnalyticsAlertingAlertsUnreadGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// A count of unread alerts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UnreadMetric</returns>
        public ApiResponse< UnreadMetric > AnalyticsAlertingAlertsUnreadGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/analytics/alerting/alerts/unread";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsUnreadGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsUnreadGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnreadMetric>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnreadMetric) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnreadMetric)));
            
        }

        /// <summary>
        /// A count of unread alerts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UnreadMetric</returns>
        public async System.Threading.Tasks.Task<UnreadMetric> AnalyticsAlertingAlertsUnreadGetAsync ()
        {
             ApiResponse<UnreadMetric> localVarResponse = await AnalyticsAlertingAlertsUnreadGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// A count of unread alerts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UnreadMetric)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UnreadMetric>> AnalyticsAlertingAlertsUnreadGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/analytics/alerting/alerts/unread";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
=======

            // authentication (PureCloud Auth) required
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);
<<<<<<< HEAD

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsUnreadGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsUnreadGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnreadMetric>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnreadMetric) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnreadMetric)));
=======

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingReportformats: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingReportformats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get a list of scheduled report jobs Get a list of scheduled report jobs.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
<<<<<<< HEAD
        /// <param name="sortBy">title, description, inAlarm or enabled (optional, default to title)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>RuleEntityListing</returns>
        public RuleEntityListing AnalyticsAlertingRulesGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleEntityListing> localVarResponse = AnalyticsAlertingRulesGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
=======
        /// <returns>ReportScheduleEntityListing</returns>
        public ReportScheduleEntityListing GetReportingSchedules (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportScheduleEntityListing> localVarResponse = GetReportingSchedulesWithHttpInfo(pageNumber, pageSize);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of scheduled report jobs Get a list of scheduled report jobs.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
<<<<<<< HEAD
        /// <param name="sortBy">title, description, inAlarm or enabled (optional, default to title)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>ApiResponse of RuleEntityListing</returns>
        public ApiResponse< RuleEntityListing > AnalyticsAlertingRulesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/analytics/alerting/rules";
=======
        /// <returns>ApiResponse of ReportScheduleEntityListing</returns>
        public ApiResponse< ReportScheduleEntityListing > GetReportingSchedulesWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {

            var localVarPath = "/api/v2/analytics/reporting/schedules";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
<<<<<<< HEAD
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedules: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportScheduleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportScheduleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportScheduleEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get a list of scheduled report jobs Get a list of scheduled report jobs.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
<<<<<<< HEAD
        /// <param name="sortBy">title, description, inAlarm or enabled (optional, default to title)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of RuleEntityListing</returns>
        public async System.Threading.Tasks.Task<RuleEntityListing> AnalyticsAlertingRulesGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleEntityListing> localVarResponse = await AnalyticsAlertingRulesGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
=======
        /// <returns>Task of ReportScheduleEntityListing</returns>
        public async System.Threading.Tasks.Task<ReportScheduleEntityListing> GetReportingSchedulesAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportScheduleEntityListing> localVarResponse = await GetReportingSchedulesAsyncWithHttpInfo(pageNumber, pageSize);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of scheduled report jobs Get a list of scheduled report jobs.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
<<<<<<< HEAD
        /// <param name="sortBy">title, description, inAlarm or enabled (optional, default to title)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (RuleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleEntityListing>> AnalyticsAlertingRulesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/analytics/alerting/rules";
=======
        /// <returns>Task of ApiResponse (ReportScheduleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportScheduleEntityListing>> GetReportingSchedulesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {

            var localVarPath = "/api/v2/analytics/reporting/schedules";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
<<<<<<< HEAD
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedules: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportScheduleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportScheduleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportScheduleEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Rule (optional)</param>
        /// <returns>Rule</returns>
        public Rule AnalyticsAlertingRulesPost (Rule body = null)
        {
             ApiResponse<Rule> localVarResponse = AnalyticsAlertingRulesPostWithHttpInfo(body);
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportSchedule</returns>
        public ReportSchedule GetReportingSchedulesScheduleId (string scheduleId)
        {
             ApiResponse<ReportSchedule> localVarResponse = GetReportingSchedulesScheduleIdWithHttpInfo(scheduleId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Rule (optional)</param>
        /// <returns>ApiResponse of Rule</returns>
        public ApiResponse< Rule > AnalyticsAlertingRulesPostWithHttpInfo (Rule body = null)
        {

            var localVarPath = "/api/v1/analytics/alerting/rules";
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        public ApiResponse< ReportSchedule > GetReportingSchedulesScheduleIdWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->GetReportingSchedulesScheduleId");

            var localVarPath = "/api/v2/analytics/reporting/schedules/{scheduleId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Rule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Rule)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportSchedule)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Rule (optional)</param>
        /// <returns>Task of Rule</returns>
        public async System.Threading.Tasks.Task<Rule> AnalyticsAlertingRulesPostAsync (Rule body = null)
        {
             ApiResponse<Rule> localVarResponse = await AnalyticsAlertingRulesPostAsyncWithHttpInfo(body);
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportSchedule</returns>
        public async System.Threading.Tasks.Task<ReportSchedule> GetReportingSchedulesScheduleIdAsync (string scheduleId)
        {
             ApiResponse<ReportSchedule> localVarResponse = await GetReportingSchedulesScheduleIdAsyncWithHttpInfo(scheduleId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Rule (optional)</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Rule>> AnalyticsAlertingRulesPostAsyncWithHttpInfo (Rule body = null)
        {

            var localVarPath = "/api/v1/analytics/alerting/rules";
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> GetReportingSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->GetReportingSchedulesScheduleId");

            var localVarPath = "/api/v2/analytics/reporting/schedules/{scheduleId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Rule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Rule)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportSchedule)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns></returns>
        public void AnalyticsAlertingRulesRuleidDelete (string ruleId)
        {
             AnalyticsAlertingRulesRuleidDeleteWithHttpInfo(ruleId);
        }

        /// <summary>
        /// Delete an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AnalyticsAlertingRulesRuleidDeleteWithHttpInfo (string ruleId)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AnalyticsApi->AnalyticsAlertingRulesRuleidDelete");

            var localVarPath = "/api/v1/analytics/alerting/rules/{ruleId}";
=======
        /// Get list of completed scheduled report jobs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>ReportRunEntryEntityDomainListing</returns>
        public ReportRunEntryEntityDomainListing GetReportingSchedulesScheduleIdHistory (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportRunEntryEntityDomainListing> localVarResponse = GetReportingSchedulesScheduleIdHistoryWithHttpInfo(scheduleId, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of completed scheduled report jobs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>ApiResponse of ReportRunEntryEntityDomainListing</returns>
        public ApiResponse< ReportRunEntryEntityDomainListing > GetReportingSchedulesScheduleIdHistoryWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->GetReportingSchedulesScheduleIdHistory");

            var localVarPath = "/api/v2/analytics/reporting/schedules/{scheduleId}/history";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
=======
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleIdHistory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleIdHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportRunEntryEntityDomainListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntryEntityDomainListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportRunEntryEntityDomainListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AnalyticsAlertingRulesRuleidDeleteAsync (string ruleId)
        {
             await AnalyticsAlertingRulesRuleidDeleteAsyncWithHttpInfo(ruleId);
=======
        /// Get list of completed scheduled report jobs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>Task of ReportRunEntryEntityDomainListing</returns>
        public async System.Threading.Tasks.Task<ReportRunEntryEntityDomainListing> GetReportingSchedulesScheduleIdHistoryAsync (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportRunEntryEntityDomainListing> localVarResponse = await GetReportingSchedulesScheduleIdHistoryAsyncWithHttpInfo(scheduleId, pageNumber, pageSize);
             return localVarResponse.Data;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
        /// Delete an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsAlertingRulesRuleidDeleteAsyncWithHttpInfo (string ruleId)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AnalyticsApi->AnalyticsAlertingRulesRuleidDelete");

            var localVarPath = "/api/v1/analytics/alerting/rules/{ruleId}";
=======
        /// Get list of completed scheduled report jobs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ReportRunEntryEntityDomainListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportRunEntryEntityDomainListing>> GetReportingSchedulesScheduleIdHistoryAsyncWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->GetReportingSchedulesScheduleIdHistory");

            var localVarPath = "/api/v2/analytics/reporting/schedules/{scheduleId}/history";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
=======
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleIdHistory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleIdHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportRunEntryEntityDomainListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntryEntityDomainListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportRunEntryEntityDomainListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Get an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Rule</returns>
        public Rule AnalyticsAlertingRulesRuleidGet (string ruleId)
        {
             ApiResponse<Rule> localVarResponse = AnalyticsAlertingRulesRuleidGetWithHttpInfo(ruleId);
=======
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportRunEntry</returns>
        public ReportRunEntry GetReportingSchedulesScheduleIdHistoryLatest (string scheduleId)
        {
             ApiResponse<ReportRunEntry> localVarResponse = GetReportingSchedulesScheduleIdHistoryLatestWithHttpInfo(scheduleId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of Rule</returns>
        public ApiResponse< Rule > AnalyticsAlertingRulesRuleidGetWithHttpInfo (string ruleId)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AnalyticsApi->AnalyticsAlertingRulesRuleidGet");

            var localVarPath = "/api/v1/analytics/alerting/rules/{ruleId}";
=======
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportRunEntry</returns>
        public ApiResponse< ReportRunEntry > GetReportingSchedulesScheduleIdHistoryLatestWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->GetReportingSchedulesScheduleIdHistoryLatest");

            var localVarPath = "/api/v2/analytics/reporting/schedules/{scheduleId}/history/latest";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
=======
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Rule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Rule)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleIdHistoryLatest: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleIdHistoryLatest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportRunEntry>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportRunEntry)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of Rule</returns>
        public async System.Threading.Tasks.Task<Rule> AnalyticsAlertingRulesRuleidGetAsync (string ruleId)
        {
             ApiResponse<Rule> localVarResponse = await AnalyticsAlertingRulesRuleidGetAsyncWithHttpInfo(ruleId);
=======
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        public async System.Threading.Tasks.Task<ReportRunEntry> GetReportingSchedulesScheduleIdHistoryLatestAsync (string scheduleId)
        {
             ApiResponse<ReportRunEntry> localVarResponse = await GetReportingSchedulesScheduleIdHistoryLatestAsyncWithHttpInfo(scheduleId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Rule>> AnalyticsAlertingRulesRuleidGetAsyncWithHttpInfo (string ruleId)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AnalyticsApi->AnalyticsAlertingRulesRuleidGet");

            var localVarPath = "/api/v1/analytics/alerting/rules/{ruleId}";
=======
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> GetReportingSchedulesScheduleIdHistoryLatestAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->GetReportingSchedulesScheduleIdHistoryLatest");

            var localVarPath = "/api/v2/analytics/reporting/schedules/{scheduleId}/history/latest";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
=======
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Rule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Rule)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleIdHistoryLatest: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleIdHistoryLatest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportRunEntry>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportRunEntry)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Rule</returns>
        public Rule AnalyticsAlertingRulesRuleidPut (string ruleId, Rule body = null)
        {
             ApiResponse<Rule> localVarResponse = AnalyticsAlertingRulesRuleidPutWithHttpInfo(ruleId, body);
=======
        /// A completed scheduled report job A completed scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportRunEntry</returns>
        public ReportRunEntry GetReportingSchedulesScheduleIdHistoryRunId (string runId, string scheduleId)
        {
             ApiResponse<ReportRunEntry> localVarResponse = GetReportingSchedulesScheduleIdHistoryRunIdWithHttpInfo(runId, scheduleId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Update an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule (optional)</param>
        /// <returns>ApiResponse of Rule</returns>
        public ApiResponse< Rule > AnalyticsAlertingRulesRuleidPutWithHttpInfo (string ruleId, Rule body = null)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AnalyticsApi->AnalyticsAlertingRulesRuleidPut");

            var localVarPath = "/api/v1/analytics/alerting/rules/{ruleId}";
=======
        /// A completed scheduled report job A completed scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportRunEntry</returns>
        public ApiResponse< ReportRunEntry > GetReportingSchedulesScheduleIdHistoryRunIdWithHttpInfo (string runId, string scheduleId)
        {
            // verify the required parameter 'runId' is set
            if (runId == null)
                throw new ApiException(400, "Missing required parameter 'runId' when calling AnalyticsApi->GetReportingSchedulesScheduleIdHistoryRunId");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->GetReportingSchedulesScheduleIdHistoryRunId");

            var localVarPath = "/api/v2/analytics/reporting/schedules/{scheduleId}/history/{runId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (runId != null) localVarPathParams.Add("runId", Configuration.ApiClient.ParameterToString(runId)); // path parameter
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Rule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Rule)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleIdHistoryRunId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleIdHistoryRunId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportRunEntry>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportRunEntry)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Task of Rule</returns>
        public async System.Threading.Tasks.Task<Rule> AnalyticsAlertingRulesRuleidPutAsync (string ruleId, Rule body = null)
        {
             ApiResponse<Rule> localVarResponse = await AnalyticsAlertingRulesRuleidPutAsyncWithHttpInfo(ruleId, body);
=======
        /// A completed scheduled report job A completed scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        public async System.Threading.Tasks.Task<ReportRunEntry> GetReportingSchedulesScheduleIdHistoryRunIdAsync (string runId, string scheduleId)
        {
             ApiResponse<ReportRunEntry> localVarResponse = await GetReportingSchedulesScheduleIdHistoryRunIdAsyncWithHttpInfo(runId, scheduleId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Update an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Rule>> AnalyticsAlertingRulesRuleidPutAsyncWithHttpInfo (string ruleId, Rule body = null)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AnalyticsApi->AnalyticsAlertingRulesRuleidPut");

            var localVarPath = "/api/v1/analytics/alerting/rules/{ruleId}";
=======
        /// A completed scheduled report job A completed scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> GetReportingSchedulesScheduleIdHistoryRunIdAsyncWithHttpInfo (string runId, string scheduleId)
        {
            // verify the required parameter 'runId' is set
            if (runId == null)
                throw new ApiException(400, "Missing required parameter 'runId' when calling AnalyticsApi->GetReportingSchedulesScheduleIdHistoryRunId");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->GetReportingSchedulesScheduleIdHistoryRunId");

            var localVarPath = "/api/v2/analytics/reporting/schedules/{scheduleId}/history/{runId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (runId != null) localVarPathParams.Add("runId", Configuration.ApiClient.ParameterToString(runId)); // path parameter
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Rule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Rule)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleIdHistoryRunId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingSchedulesScheduleIdHistoryRunId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportRunEntry>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportRunEntry)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">queryObject (optional)</param>
        /// <returns></returns>
        public void AnalyticsMetricsQueryPost (Object body = null)
=======
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetReportingTimeperiods ()
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        {
             ApiResponse<List<string>> localVarResponse = GetReportingTimeperiodsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">queryObject (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AnalyticsMetricsQueryPostWithHttpInfo (Object body = null)
        {

            var localVarPath = "/api/v1/analytics/metrics/query";
=======
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > GetReportingTimeperiodsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/analytics/reporting/timeperiods";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsMetricsQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsMetricsQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingTimeperiods: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingTimeperiods: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        }

        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">queryObject (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AnalyticsMetricsQueryPostAsync (Object body = null)
=======
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> GetReportingTimeperiodsAsync ()
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        {
             ApiResponse<List<string>> localVarResponse = await GetReportingTimeperiodsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">queryObject (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsMetricsQueryPostAsyncWithHttpInfo (Object body = null)
        {

            var localVarPath = "/api/v1/analytics/metrics/query";
=======
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> GetReportingTimeperiodsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/analytics/reporting/timeperiods";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsMetricsQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsMetricsQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetReportingTimeperiods: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReportingTimeperiods: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
<<<<<<< HEAD
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        }

        /// <summary>
        /// Query for conversation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ReportMetaDataEntityListing</returns>
        public ReportMetaDataEntityListing AnalyticsReportingMetadataGet (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {
             ApiResponse<ReportMetaDataEntityListing> localVarResponse = AnalyticsReportingMetadataGetWithHttpInfo(pageNumber, pageSize, acceptLanguage, locale);
=======
        /// <param name="body">query (optional)</param>
        /// <returns>AggregateQueryResponse</returns>
        public AggregateQueryResponse PostConversationsAggregatesQuery (AggregationQuery body = null)
        {
             ApiResponse<AggregateQueryResponse> localVarResponse = PostConversationsAggregatesQueryWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for conversation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ApiResponse of ReportMetaDataEntityListing</returns>
        public ApiResponse< ReportMetaDataEntityListing > AnalyticsReportingMetadataGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {

            var localVarPath = "/api/v1/analytics/reporting/metadata";
=======
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of AggregateQueryResponse</returns>
        public ApiResponse< AggregateQueryResponse > PostConversationsAggregatesQueryWithHttpInfo (AggregationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/conversations/aggregates/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingMetadataGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingMetadataGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportMetaDataEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaDataEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportMetaDataEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregateQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AggregateQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregateQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Query for conversation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ReportMetaDataEntityListing</returns>
        public async System.Threading.Tasks.Task<ReportMetaDataEntityListing> AnalyticsReportingMetadataGetAsync (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {
             ApiResponse<ReportMetaDataEntityListing> localVarResponse = await AnalyticsReportingMetadataGetAsyncWithHttpInfo(pageNumber, pageSize, acceptLanguage, locale);
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of AggregateQueryResponse</returns>
        public async System.Threading.Tasks.Task<AggregateQueryResponse> PostConversationsAggregatesQueryAsync (AggregationQuery body = null)
        {
             ApiResponse<AggregateQueryResponse> localVarResponse = await PostConversationsAggregatesQueryAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for conversation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ApiResponse (ReportMetaDataEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportMetaDataEntityListing>> AnalyticsReportingMetadataGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {

            var localVarPath = "/api/v1/analytics/reporting/metadata";
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (AggregateQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AggregateQueryResponse>> PostConversationsAggregatesQueryAsyncWithHttpInfo (AggregationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/conversations/aggregates/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingMetadataGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingMetadataGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportMetaDataEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaDataEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportMetaDataEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregateQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AggregateQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregateQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>List&lt;string&gt;</returns>
        public List<string> AnalyticsReportingReportformatsGet ()
        {
             ApiResponse<List<string>> localVarResponse = AnalyticsReportingReportformatsGetWithHttpInfo();
=======
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request (optional)</param>
        /// <returns>PropertyIndexRequest</returns>
        public PropertyIndexRequest PostConversationsConversationIdDetailsProperties (string conversationId, PropertyIndexRequest body = null)
        {
             ApiResponse<PropertyIndexRequest> localVarResponse = PostConversationsConversationIdDetailsPropertiesWithHttpInfo(conversationId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > AnalyticsReportingReportformatsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/analytics/reporting/reportformats";
=======
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request (optional)</param>
        /// <returns>ApiResponse of PropertyIndexRequest</returns>
        public ApiResponse< PropertyIndexRequest > PostConversationsConversationIdDetailsPropertiesWithHttpInfo (string conversationId, PropertyIndexRequest body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling AnalyticsApi->PostConversationsConversationIdDetailsProperties");

            var localVarPath = "/api/v2/analytics/conversations/{conversationId}/details/properties";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingReportformatsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingReportformatsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDetailsProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDetailsProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropertyIndexRequest>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropertyIndexRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyIndexRequest)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> AnalyticsReportingReportformatsGetAsync ()
        {
             ApiResponse<List<string>> localVarResponse = await AnalyticsReportingReportformatsGetAsyncWithHttpInfo();
=======
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request (optional)</param>
        /// <returns>Task of PropertyIndexRequest</returns>
        public async System.Threading.Tasks.Task<PropertyIndexRequest> PostConversationsConversationIdDetailsPropertiesAsync (string conversationId, PropertyIndexRequest body = null)
        {
             ApiResponse<PropertyIndexRequest> localVarResponse = await PostConversationsConversationIdDetailsPropertiesAsyncWithHttpInfo(conversationId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> AnalyticsReportingReportformatsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/analytics/reporting/reportformats";
=======
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request (optional)</param>
        /// <returns>Task of ApiResponse (PropertyIndexRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropertyIndexRequest>> PostConversationsConversationIdDetailsPropertiesAsyncWithHttpInfo (string conversationId, PropertyIndexRequest body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling AnalyticsApi->PostConversationsConversationIdDetailsProperties");

            var localVarPath = "/api/v2/analytics/conversations/{conversationId}/details/properties";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingReportformatsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingReportformatsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDetailsProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDetailsProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropertyIndexRequest>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropertyIndexRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyIndexRequest)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ReportMetaData</returns>
        public ReportMetaData AnalyticsReportingReportidMetadataGet (string reportId, string acceptLanguage = null, string locale = null)
        {
             ApiResponse<ReportMetaData> localVarResponse = AnalyticsReportingReportidMetadataGetWithHttpInfo(reportId, acceptLanguage, locale);
=======
        /// Query for conversation details 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>AnalyticsConversationQueryResponse</returns>
        public AnalyticsConversationQueryResponse PostConversationsDetailsQuery (ConversationQuery body = null)
        {
             ApiResponse<AnalyticsConversationQueryResponse> localVarResponse = PostConversationsDetailsQueryWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ApiResponse of ReportMetaData</returns>
        public ApiResponse< ReportMetaData > AnalyticsReportingReportidMetadataGetWithHttpInfo (string reportId, string acceptLanguage = null, string locale = null)
        {
            // verify the required parameter 'reportId' is set
            if (reportId == null)
                throw new ApiException(400, "Missing required parameter 'reportId' when calling AnalyticsApi->AnalyticsReportingReportidMetadataGet");

            var localVarPath = "/api/v1/analytics/reporting/{reportId}/metadata";
=======
        /// Query for conversation details 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of AnalyticsConversationQueryResponse</returns>
        public ApiResponse< AnalyticsConversationQueryResponse > PostConversationsDetailsQueryWithHttpInfo (ConversationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/conversations/details/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (reportId != null) localVarPathParams.Add("reportId", Configuration.ApiClient.ParameterToString(reportId)); // path parameter
            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingReportidMetadataGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingReportidMetadataGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportMetaData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportMetaData)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsDetailsQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsDetailsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsConversationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversationQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ReportMetaData</returns>
        public async System.Threading.Tasks.Task<ReportMetaData> AnalyticsReportingReportidMetadataGetAsync (string reportId, string acceptLanguage = null, string locale = null)
        {
             ApiResponse<ReportMetaData> localVarResponse = await AnalyticsReportingReportidMetadataGetAsyncWithHttpInfo(reportId, acceptLanguage, locale);
=======
        /// Query for conversation details 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of AnalyticsConversationQueryResponse</returns>
        public async System.Threading.Tasks.Task<AnalyticsConversationQueryResponse> PostConversationsDetailsQueryAsync (ConversationQuery body = null)
        {
             ApiResponse<AnalyticsConversationQueryResponse> localVarResponse = await PostConversationsDetailsQueryAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get a reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ApiResponse (ReportMetaData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportMetaData>> AnalyticsReportingReportidMetadataGetAsyncWithHttpInfo (string reportId, string acceptLanguage = null, string locale = null)
        {
            // verify the required parameter 'reportId' is set
            if (reportId == null)
                throw new ApiException(400, "Missing required parameter 'reportId' when calling AnalyticsApi->AnalyticsReportingReportidMetadataGet");

            var localVarPath = "/api/v1/analytics/reporting/{reportId}/metadata";
=======
        /// Query for conversation details 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (AnalyticsConversationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnalyticsConversationQueryResponse>> PostConversationsDetailsQueryAsyncWithHttpInfo (ConversationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/conversations/details/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (reportId != null) localVarPathParams.Add("reportId", Configuration.ApiClient.ParameterToString(reportId)); // path parameter
            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingReportidMetadataGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingReportidMetadataGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportMetaData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportMetaData)));
            
        }

        /// <summary>
        /// Get a list of scheduled report jobs Get a list of scheduled report jobs.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ReportScheduleEntityListing</returns>
        public ReportScheduleEntityListing AnalyticsReportingSchedulesGet (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportScheduleEntityListing> localVarResponse = AnalyticsReportingSchedulesGetWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of scheduled report jobs Get a list of scheduled report jobs.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of ReportScheduleEntityListing</returns>
        public ApiResponse< ReportScheduleEntityListing > AnalyticsReportingSchedulesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {

            var localVarPath = "/api/v1/analytics/reporting/schedules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportScheduleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportScheduleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportScheduleEntityListing)));
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsDetailsQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsDetailsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsConversationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversationQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of scheduled report jobs Get a list of scheduled report jobs.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ReportScheduleEntityListing</returns>
        public async System.Threading.Tasks.Task<ReportScheduleEntityListing> AnalyticsReportingSchedulesGetAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportScheduleEntityListing> localVarResponse = await AnalyticsReportingSchedulesGetAsyncWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of scheduled report jobs Get a list of scheduled report jobs.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ReportScheduleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportScheduleEntityListing>> AnalyticsReportingSchedulesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {

            var localVarPath = "/api/v1/analytics/reporting/schedules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportScheduleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportScheduleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportScheduleEntityListing)));
            
        }

        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ReportSchedule</returns>
        public ReportSchedule AnalyticsReportingSchedulesPost (ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> localVarResponse = AnalyticsReportingSchedulesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        public ApiResponse< ReportSchedule > AnalyticsReportingSchedulesPostWithHttpInfo (ReportSchedule body = null)
        {

            var localVarPath = "/api/v1/analytics/reporting/schedules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
=======
        /// Query for evaluation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>AggregateQueryResponse</returns>
        public AggregateQueryResponse PostEvaluationsAggregatesQuery (AggregationQuery body = null)
        {
             ApiResponse<AggregateQueryResponse> localVarResponse = PostEvaluationsAggregatesQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for evaluation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of AggregateQueryResponse</returns>
        public ApiResponse< AggregateQueryResponse > PostEvaluationsAggregatesQueryWithHttpInfo (AggregationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/evaluations/aggregates/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body.GetType() != typeof(byte[]))
<<<<<<< HEAD
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportSchedule)));
            
        }

        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ReportSchedule</returns>
        public async System.Threading.Tasks.Task<ReportSchedule> AnalyticsReportingSchedulesPostAsync (ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> localVarResponse = await AnalyticsReportingSchedulesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesPostAsyncWithHttpInfo (ReportSchedule body = null)
        {

            var localVarPath = "/api/v1/analytics/reporting/schedules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
<<<<<<< HEAD
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportSchedule)));
            
        }

        /// <summary>
        /// Delete a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>string</returns>
        public string AnalyticsReportingSchedulesScheduleidDelete (string scheduleId)
        {
             ApiResponse<string> localVarResponse = AnalyticsReportingSchedulesScheduleidDeleteWithHttpInfo(scheduleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AnalyticsReportingSchedulesScheduleidDeleteWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidDelete");

            var localVarPath = "/api/v1/analytics/reporting/schedules/{scheduleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEvaluationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEvaluationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregateQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AggregateQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregateQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AnalyticsReportingSchedulesScheduleidDeleteAsync (string scheduleId)
        {
             ApiResponse<string> localVarResponse = await AnalyticsReportingSchedulesScheduleidDeleteAsyncWithHttpInfo(scheduleId);
=======
        /// Query for evaluation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of AggregateQueryResponse</returns>
        public async System.Threading.Tasks.Task<AggregateQueryResponse> PostEvaluationsAggregatesQueryAsync (AggregationQuery body = null)
        {
             ApiResponse<AggregateQueryResponse> localVarResponse = await PostEvaluationsAggregatesQueryAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AnalyticsReportingSchedulesScheduleidDeleteAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidDelete");

            var localVarPath = "/api/v1/analytics/reporting/schedules/{scheduleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportSchedule</returns>
        public ReportSchedule AnalyticsReportingSchedulesScheduleidGet (string scheduleId)
        {
             ApiResponse<ReportSchedule> localVarResponse = AnalyticsReportingSchedulesScheduleidGetWithHttpInfo(scheduleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        public ApiResponse< ReportSchedule > AnalyticsReportingSchedulesScheduleidGetWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidGet");

            var localVarPath = "/api/v1/analytics/reporting/schedules/{scheduleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
=======
        /// Query for evaluation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (AggregateQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AggregateQueryResponse>> PostEvaluationsAggregatesQueryAsyncWithHttpInfo (AggregationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/evaluations/aggregates/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportSchedule)));
            
        }

        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportSchedule</returns>
        public async System.Threading.Tasks.Task<ReportSchedule> AnalyticsReportingSchedulesScheduleidGetAsync (string scheduleId)
        {
             ApiResponse<ReportSchedule> localVarResponse = await AnalyticsReportingSchedulesScheduleidGetAsyncWithHttpInfo(scheduleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesScheduleidGetAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidGet");

            var localVarPath = "/api/v1/analytics/reporting/schedules/{scheduleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportSchedule)));
            
        }

        /// <summary>
        /// Get list of completed scheduled report jobs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>ReportRunEntryEntityDomainListing</returns>
        public ReportRunEntryEntityDomainListing AnalyticsReportingSchedulesScheduleidHistoryGet (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportRunEntryEntityDomainListing> localVarResponse = AnalyticsReportingSchedulesScheduleidHistoryGetWithHttpInfo(scheduleId, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of completed scheduled report jobs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>ApiResponse of ReportRunEntryEntityDomainListing</returns>
        public ApiResponse< ReportRunEntryEntityDomainListing > AnalyticsReportingSchedulesScheduleidHistoryGetWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidHistoryGet");

            var localVarPath = "/api/v1/analytics/reporting/schedules/{scheduleId}/history";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportRunEntryEntityDomainListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntryEntityDomainListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportRunEntryEntityDomainListing)));
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEvaluationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEvaluationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregateQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AggregateQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregateQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Query for queue observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>Task of ReportRunEntryEntityDomainListing</returns>
        public async System.Threading.Tasks.Task<ReportRunEntryEntityDomainListing> AnalyticsReportingSchedulesScheduleidHistoryGetAsync (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportRunEntryEntityDomainListing> localVarResponse = await AnalyticsReportingSchedulesScheduleidHistoryGetAsyncWithHttpInfo(scheduleId, pageNumber, pageSize);
             return localVarResponse.Data;

=======
        /// <param name="body">query (optional)</param>
        /// <returns>ObservationQueryResponse</returns>
        public ObservationQueryResponse PostQueuesObservationsQuery (ObservationQuery body = null)
        {
             ApiResponse<ObservationQueryResponse> localVarResponse = PostQueuesObservationsQueryWithHttpInfo(body);
             return localVarResponse.Data;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        }

        /// <summary>
        /// Query for queue observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ReportRunEntryEntityDomainListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportRunEntryEntityDomainListing>> AnalyticsReportingSchedulesScheduleidHistoryGetAsyncWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidHistoryGet");

            var localVarPath = "/api/v1/analytics/reporting/schedules/{scheduleId}/history";
=======
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of ObservationQueryResponse</returns>
        public ApiResponse< ObservationQueryResponse > PostQueuesObservationsQueryWithHttpInfo (ObservationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/queues/observations/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
<<<<<<< HEAD
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportRunEntryEntityDomainListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntryEntityDomainListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportRunEntryEntityDomainListing)));
            
        }

        /// <summary>
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportRunEntry</returns>
        public ReportRunEntry AnalyticsReportingSchedulesScheduleidHistoryLatestGet (string scheduleId)
        {
             ApiResponse<ReportRunEntry> localVarResponse = AnalyticsReportingSchedulesScheduleidHistoryLatestGetWithHttpInfo(scheduleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportRunEntry</returns>
        public ApiResponse< ReportRunEntry > AnalyticsReportingSchedulesScheduleidHistoryLatestGetWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidHistoryLatestGet");

            var localVarPath = "/api/v1/analytics/reporting/schedules/{scheduleId}/history/latest";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryLatestGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryLatestGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportRunEntry>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportRunEntry)));
=======
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesObservationsQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesObservationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObservationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObservationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObservationQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Query for queue observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        public async System.Threading.Tasks.Task<ReportRunEntry> AnalyticsReportingSchedulesScheduleidHistoryLatestGetAsync (string scheduleId)
        {
             ApiResponse<ReportRunEntry> localVarResponse = await AnalyticsReportingSchedulesScheduleidHistoryLatestGetAsyncWithHttpInfo(scheduleId);
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ObservationQueryResponse</returns>
        public async System.Threading.Tasks.Task<ObservationQueryResponse> PostQueuesObservationsQueryAsync (ObservationQuery body = null)
        {
             ApiResponse<ObservationQueryResponse> localVarResponse = await PostQueuesObservationsQueryAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for queue observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> AnalyticsReportingSchedulesScheduleidHistoryLatestGetAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidHistoryLatestGet");

            var localVarPath = "/api/v1/analytics/reporting/schedules/{scheduleId}/history/latest";
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (ObservationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObservationQueryResponse>> PostQueuesObservationsQueryAsyncWithHttpInfo (ObservationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/queues/observations/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryLatestGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryLatestGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportRunEntry>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportRunEntry)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesObservationsQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesObservationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObservationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObservationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObservationQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportRunEntry</returns>
        public ReportRunEntry AnalyticsReportingSchedulesScheduleidHistoryRunidGet (string runId, string scheduleId)
        {
             ApiResponse<ReportRunEntry> localVarResponse = AnalyticsReportingSchedulesScheduleidHistoryRunidGetWithHttpInfo(runId, scheduleId);
=======
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ReportSchedule</returns>
        public ReportSchedule PostReportingSchedules (ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> localVarResponse = PostReportingSchedulesWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportRunEntry</returns>
        public ApiResponse< ReportRunEntry > AnalyticsReportingSchedulesScheduleidHistoryRunidGetWithHttpInfo (string runId, string scheduleId)
        {
            // verify the required parameter 'runId' is set
            if (runId == null)
                throw new ApiException(400, "Missing required parameter 'runId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidHistoryRunidGet");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidHistoryRunidGet");

            var localVarPath = "/api/v1/analytics/reporting/schedules/{scheduleId}/history/{runId}";
=======
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        public ApiResponse< ReportSchedule > PostReportingSchedulesWithHttpInfo (ReportSchedule body = null)
        {

            var localVarPath = "/api/v2/analytics/reporting/schedules";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (runId != null) localVarPathParams.Add("runId", Configuration.ApiClient.ParameterToString(runId)); // path parameter
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportRunEntry>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportRunEntry)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostReportingSchedules: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostReportingSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportSchedule)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        public async System.Threading.Tasks.Task<ReportRunEntry> AnalyticsReportingSchedulesScheduleidHistoryRunidGetAsync (string runId, string scheduleId)
        {
             ApiResponse<ReportRunEntry> localVarResponse = await AnalyticsReportingSchedulesScheduleidHistoryRunidGetAsyncWithHttpInfo(runId, scheduleId);
=======
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ReportSchedule</returns>
        public async System.Threading.Tasks.Task<ReportSchedule> PostReportingSchedulesAsync (ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> localVarResponse = await PostReportingSchedulesAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> AnalyticsReportingSchedulesScheduleidHistoryRunidGetAsyncWithHttpInfo (string runId, string scheduleId)
        {
            // verify the required parameter 'runId' is set
            if (runId == null)
                throw new ApiException(400, "Missing required parameter 'runId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidHistoryRunidGet");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidHistoryRunidGet");

            var localVarPath = "/api/v1/analytics/reporting/schedules/{scheduleId}/history/{runId}";
=======
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> PostReportingSchedulesAsyncWithHttpInfo (ReportSchedule body = null)
        {

            var localVarPath = "/api/v2/analytics/reporting/schedules";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (runId != null) localVarPathParams.Add("runId", Configuration.ApiClient.ParameterToString(runId)); // path parameter
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportRunEntry>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportRunEntry)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostReportingSchedules: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostReportingSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportSchedule)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
<<<<<<< HEAD
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ReportSchedule</returns>
        public ReportSchedule AnalyticsReportingSchedulesScheduleidPut (string scheduleId, ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> localVarResponse = AnalyticsReportingSchedulesScheduleidPutWithHttpInfo(scheduleId, body);
=======
        /// <returns>RunNowResponse</returns>
        public RunNowResponse PostReportingSchedulesScheduleIdRunreport (string scheduleId)
        {
             ApiResponse<RunNowResponse> localVarResponse = PostReportingSchedulesScheduleIdRunreportWithHttpInfo(scheduleId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
<<<<<<< HEAD
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        public ApiResponse< ReportSchedule > AnalyticsReportingSchedulesScheduleidPutWithHttpInfo (string scheduleId, ReportSchedule body = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidPut");

            var localVarPath = "/api/v1/analytics/reporting/schedules/{scheduleId}";
=======
        /// <returns>ApiResponse of RunNowResponse</returns>
        public ApiResponse< RunNowResponse > PostReportingSchedulesScheduleIdRunreportWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->PostReportingSchedulesScheduleIdRunreport");

            var localVarPath = "/api/v2/analytics/reporting/schedules/{scheduleId}/runreport";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportSchedule)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostReportingSchedulesScheduleIdRunreport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostReportingSchedulesScheduleIdRunreport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RunNowResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RunNowResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RunNowResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
<<<<<<< HEAD
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ReportSchedule</returns>
        public async System.Threading.Tasks.Task<ReportSchedule> AnalyticsReportingSchedulesScheduleidPutAsync (string scheduleId, ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> localVarResponse = await AnalyticsReportingSchedulesScheduleidPutAsyncWithHttpInfo(scheduleId, body);
=======
        /// <returns>Task of RunNowResponse</returns>
        public async System.Threading.Tasks.Task<RunNowResponse> PostReportingSchedulesScheduleIdRunreportAsync (string scheduleId)
        {
             ApiResponse<RunNowResponse> localVarResponse = await PostReportingSchedulesScheduleIdRunreportAsyncWithHttpInfo(scheduleId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
<<<<<<< HEAD
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesScheduleidPutAsyncWithHttpInfo (string scheduleId, ReportSchedule body = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidPut");

            var localVarPath = "/api/v1/analytics/reporting/schedules/{scheduleId}";
=======
        /// <returns>Task of ApiResponse (RunNowResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RunNowResponse>> PostReportingSchedulesScheduleIdRunreportAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->PostReportingSchedulesScheduleIdRunreport");

            var localVarPath = "/api/v2/analytics/reporting/schedules/{scheduleId}/runreport";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportSchedule)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostReportingSchedulesScheduleIdRunreport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostReportingSchedulesScheduleIdRunreport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RunNowResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RunNowResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RunNowResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Place a scheduled report immediately into the reporting queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>RunNowResponse</returns>
        public RunNowResponse AnalyticsReportingSchedulesScheduleidRunreportPost (string scheduleId)
        {
             ApiResponse<RunNowResponse> localVarResponse = AnalyticsReportingSchedulesScheduleidRunreportPostWithHttpInfo(scheduleId);
=======
        /// Query for user aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>PresenceQueryResponse</returns>
        public PresenceQueryResponse PostUsersAggregatesQuery (AggregationQuery body = null)
        {
             ApiResponse<PresenceQueryResponse> localVarResponse = PostUsersAggregatesQueryWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Place a scheduled report immediately into the reporting queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of RunNowResponse</returns>
        public ApiResponse< RunNowResponse > AnalyticsReportingSchedulesScheduleidRunreportPostWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidRunreportPost");

            var localVarPath = "/api/v1/analytics/reporting/schedules/{scheduleId}/runreport";
=======
        /// Query for user aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of PresenceQueryResponse</returns>
        public ApiResponse< PresenceQueryResponse > PostUsersAggregatesQueryWithHttpInfo (AggregationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/users/aggregates/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidRunreportPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidRunreportPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RunNowResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RunNowResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RunNowResponse)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostUsersAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsersAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PresenceQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PresenceQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PresenceQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Place a scheduled report immediately into the reporting queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of RunNowResponse</returns>
        public async System.Threading.Tasks.Task<RunNowResponse> AnalyticsReportingSchedulesScheduleidRunreportPostAsync (string scheduleId)
        {
             ApiResponse<RunNowResponse> localVarResponse = await AnalyticsReportingSchedulesScheduleidRunreportPostAsyncWithHttpInfo(scheduleId);
=======
        /// Query for user aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of PresenceQueryResponse</returns>
        public async System.Threading.Tasks.Task<PresenceQueryResponse> PostUsersAggregatesQueryAsync (AggregationQuery body = null)
        {
             ApiResponse<PresenceQueryResponse> localVarResponse = await PostUsersAggregatesQueryAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Place a scheduled report immediately into the reporting queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (RunNowResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RunNowResponse>> AnalyticsReportingSchedulesScheduleidRunreportPostAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidRunreportPost");

            var localVarPath = "/api/v1/analytics/reporting/schedules/{scheduleId}/runreport";
=======
        /// Query for user aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (PresenceQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PresenceQueryResponse>> PostUsersAggregatesQueryAsyncWithHttpInfo (AggregationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/users/aggregates/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidRunreportPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidRunreportPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RunNowResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RunNowResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RunNowResponse)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostUsersAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsersAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PresenceQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PresenceQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PresenceQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of report time periods. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> AnalyticsReportingTimeperiodsGet ()
        {
             ApiResponse<List<string>> localVarResponse = AnalyticsReportingTimeperiodsGetWithHttpInfo();
=======
        /// Query for user observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>ObservationQueryResponse</returns>
        public ObservationQueryResponse PostUsersObservationsQuery (ObservationQuery body = null)
        {
             ApiResponse<ObservationQueryResponse> localVarResponse = PostUsersObservationsQueryWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of report time periods. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > AnalyticsReportingTimeperiodsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/analytics/reporting/timeperiods";
=======
        /// Query for user observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of ObservationQueryResponse</returns>
        public ApiResponse< ObservationQueryResponse > PostUsersObservationsQueryWithHttpInfo (ObservationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/users/observations/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingTimeperiodsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingTimeperiodsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostUsersObservationsQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsersObservationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObservationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObservationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObservationQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of report time periods. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> AnalyticsReportingTimeperiodsGetAsync ()
        {
             ApiResponse<List<string>> localVarResponse = await AnalyticsReportingTimeperiodsGetAsyncWithHttpInfo();
=======
        /// Query for user observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ObservationQueryResponse</returns>
        public async System.Threading.Tasks.Task<ObservationQueryResponse> PostUsersObservationsQueryAsync (ObservationQuery body = null)
        {
             ApiResponse<ObservationQueryResponse> localVarResponse = await PostUsersObservationsQueryAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of report time periods. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> AnalyticsReportingTimeperiodsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/analytics/reporting/timeperiods";
=======
        /// Query for user observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (ObservationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObservationQueryResponse>> PostUsersObservationsQueryAsyncWithHttpInfo (ObservationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/users/observations/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingTimeperiodsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingTimeperiodsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostUsersObservationsQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUsersObservationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObservationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObservationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObservationQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">queryObject (optional)</param>
        /// <returns></returns>
        public void AnalyticsSegmentsQueryPost (Object body = null)
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ReportSchedule</returns>
        public ReportSchedule PutReportingSchedulesScheduleId (string scheduleId, ReportSchedule body = null)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        {
             ApiResponse<ReportSchedule> localVarResponse = PutReportingSchedulesScheduleIdWithHttpInfo(scheduleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">queryObject (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AnalyticsSegmentsQueryPostWithHttpInfo (Object body = null)
        {

            var localVarPath = "/api/v1/analytics/segments/query";
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        public ApiResponse< ReportSchedule > PutReportingSchedulesScheduleIdWithHttpInfo (string scheduleId, ReportSchedule body = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->PutReportingSchedulesScheduleId");

            var localVarPath = "/api/v2/analytics/reporting/schedules/{scheduleId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsSegmentsQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsSegmentsQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
=======
                throw new ApiException (localVarStatusCode, "Error calling PutReportingSchedulesScheduleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutReportingSchedulesScheduleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportSchedule)));
            
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">queryObject (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AnalyticsSegmentsQueryPostAsync (Object body = null)
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ReportSchedule</returns>
        public async System.Threading.Tasks.Task<ReportSchedule> PutReportingSchedulesScheduleIdAsync (string scheduleId, ReportSchedule body = null)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        {
             ApiResponse<ReportSchedule> localVarResponse = await PutReportingSchedulesScheduleIdAsyncWithHttpInfo(scheduleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">queryObject (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsSegmentsQueryPostAsyncWithHttpInfo (Object body = null)
        {

            var localVarPath = "/api/v1/analytics/segments/query";
=======
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> PutReportingSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId, ReportSchedule body = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->PutReportingSchedulesScheduleId");

            var localVarPath = "/api/v2/analytics/reporting/schedules/{scheduleId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsSegmentsQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsSegmentsQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutReportingSchedulesScheduleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutReportingSchedulesScheduleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportSchedule)));
            
<<<<<<< HEAD
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        }

    }
}
