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
        /// <summary>
        /// Delete an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns></returns>
        void AnalyticsAlertingAlertsAlertidDelete (string alertId);

        /// <summary>
        /// Delete an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AnalyticsAlertingAlertsAlertidDeleteWithHttpInfo (string alertId);
        /// <summary>
        /// Get an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Alert</returns>
        Alert AnalyticsAlertingAlertsAlertidGet (string alertId);

        /// <summary>
        /// Get an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of Alert</returns>
        ApiResponse<Alert> AnalyticsAlertingAlertsAlertidGetWithHttpInfo (string alertId);
        /// <summary>
        /// Update an alerts unread status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert (optional)</param>
        /// <returns>Alert</returns>
        Alert AnalyticsAlertingAlertsAlertidPut (string alertId, Alert body = null);

        /// <summary>
        /// Update an alerts unread status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert (optional)</param>
        /// <returns>ApiResponse of Alert</returns>
        ApiResponse<Alert> AnalyticsAlertingAlertsAlertidPutWithHttpInfo (string alertId, Alert body = null);
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
        /// <returns>AlertEntityListing</returns>
        AlertEntityListing AnalyticsAlertingAlertsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        /// <returns>ApiResponse of AlertEntityListing</returns>
        ApiResponse<AlertEntityListing> AnalyticsAlertingAlertsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// A count of unread alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UnreadMetric</returns>
        UnreadMetric AnalyticsAlertingAlertsUnreadGet ();

        /// <summary>
        /// A count of unread alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UnreadMetric</returns>
        ApiResponse<UnreadMetric> AnalyticsAlertingAlertsUnreadGetWithHttpInfo ();
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
        /// <returns>RuleEntityListing</returns>
        RuleEntityListing AnalyticsAlertingRulesGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        /// <returns>ApiResponse of RuleEntityListing</returns>
        ApiResponse<RuleEntityListing> AnalyticsAlertingRulesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Rule</returns>
        Rule AnalyticsAlertingRulesPost (Rule body = null);

        /// <summary>
        /// Create an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Rule (optional)</param>
        /// <returns>ApiResponse of Rule</returns>
        ApiResponse<Rule> AnalyticsAlertingRulesPostWithHttpInfo (Rule body = null);
        /// <summary>
        /// Delete an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns></returns>
        void AnalyticsAlertingRulesRuleidDelete (string ruleId);

        /// <summary>
        /// Delete an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AnalyticsAlertingRulesRuleidDeleteWithHttpInfo (string ruleId);
        /// <summary>
        /// Get an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Rule</returns>
        Rule AnalyticsAlertingRulesRuleidGet (string ruleId);

        /// <summary>
        /// Get an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of Rule</returns>
        ApiResponse<Rule> AnalyticsAlertingRulesRuleidGetWithHttpInfo (string ruleId);
        /// <summary>
        /// Update an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Rule</returns>
        Rule AnalyticsAlertingRulesRuleidPut (string ruleId, Rule body = null);

        /// <summary>
        /// Update an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule (optional)</param>
        /// <returns>ApiResponse of Rule</returns>
        ApiResponse<Rule> AnalyticsAlertingRulesRuleidPutWithHttpInfo (string ruleId, Rule body = null);
        /// <summary>
        /// Executes a metrics query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">queryObject (optional)</param>
        /// <returns></returns>
        void AnalyticsMetricsQueryPost (Object body = null);

        /// <summary>
        /// Executes a metrics query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">queryObject (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AnalyticsMetricsQueryPostWithHttpInfo (Object body = null);
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
        /// <returns>ReportMetaDataEntityListing</returns>
        ReportMetaDataEntityListing AnalyticsReportingMetadataGet (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null);

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
        /// <returns>ApiResponse of ReportMetaDataEntityListing</returns>
        ApiResponse<ReportMetaDataEntityListing> AnalyticsReportingMetadataGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null);
        /// <summary>
        /// Get a list of report formats
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;string&gt;</returns>
        List<string> AnalyticsReportingReportformatsGet ();

        /// <summary>
        /// Get a list of report formats
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> AnalyticsReportingReportformatsGetWithHttpInfo ();
        /// <summary>
        /// Get a reporting metadata.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ReportMetaData</returns>
        ReportMetaData AnalyticsReportingReportidMetadataGet (string reportId, string acceptLanguage = null, string locale = null);

        /// <summary>
        /// Get a reporting metadata.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>string</returns>
        string AnalyticsReportingSchedulesScheduleidDelete (string scheduleId);

        /// <summary>
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AnalyticsReportingSchedulesScheduleidDeleteWithHttpInfo (string scheduleId);
        /// <summary>
        /// Get a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportSchedule</returns>
        ReportSchedule AnalyticsReportingSchedulesScheduleidGet (string scheduleId);

        /// <summary>
        /// Get a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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

        /// <summary>
        /// Get most recently completed scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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

        /// <summary>
        /// Executes a segments query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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

        /// <summary>
        /// Delete an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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

        /// <summary>
        /// Update an alerts unread status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Rule>> AnalyticsAlertingRulesPostAsyncWithHttpInfo (Rule body = null);
        /// <summary>
        /// Delete an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AnalyticsAlertingRulesRuleidDeleteAsync (string ruleId);

        /// <summary>
        /// Delete an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Rule>> AnalyticsAlertingRulesRuleidPutAsyncWithHttpInfo (string ruleId, Rule body = null);
        /// <summary>
        /// Executes a metrics query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">queryObject (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AnalyticsMetricsQueryPostAsync (Object body = null);

        /// <summary>
        /// Executes a metrics query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ReportMetaData</returns>
        System.Threading.Tasks.Task<ReportMetaData> AnalyticsReportingReportidMetadataGetAsync (string reportId, string acceptLanguage = null, string locale = null);

        /// <summary>
        /// Get a reporting metadata.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesPostAsyncWithHttpInfo (ReportSchedule body = null);
        /// <summary>
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AnalyticsReportingSchedulesScheduleidDeleteAsync (string scheduleId);

        /// <summary>
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AnalyticsReportingSchedulesScheduleidDeleteAsyncWithHttpInfo (string scheduleId);
        /// <summary>
        /// Get a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportSchedule</returns>
        System.Threading.Tasks.Task<ReportSchedule> AnalyticsReportingSchedulesScheduleidGetAsync (string scheduleId);

        /// <summary>
        /// Get a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesScheduleidGetAsyncWithHttpInfo (string scheduleId);
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
        /// <returns>Task of ReportRunEntryEntityDomainListing</returns>
        System.Threading.Tasks.Task<ReportRunEntryEntityDomainListing> AnalyticsReportingSchedulesScheduleidHistoryGetAsync (string scheduleId, int? pageNumber = null, int? pageSize = null);

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
        /// <returns>Task of ApiResponse (ReportRunEntryEntityDomainListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportRunEntryEntityDomainListing>> AnalyticsReportingSchedulesScheduleidHistoryGetAsyncWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Get most recently completed scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        System.Threading.Tasks.Task<ReportRunEntry> AnalyticsReportingSchedulesScheduleidHistoryLatestGetAsync (string scheduleId);

        /// <summary>
        /// Get most recently completed scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> AnalyticsReportingSchedulesScheduleidHistoryLatestGetAsyncWithHttpInfo (string scheduleId);
        /// <summary>
        /// A completed scheduled report job
        /// </summary>
        /// <remarks>
        /// A completed scheduled report job.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesScheduleidPutAsyncWithHttpInfo (string scheduleId, ReportSchedule body = null);
        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of RunNowResponse</returns>
        System.Threading.Tasks.Task<RunNowResponse> AnalyticsReportingSchedulesScheduleidRunreportPostAsync (string scheduleId);

        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (RunNowResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RunNowResponse>> AnalyticsReportingSchedulesScheduleidRunreportPostAsyncWithHttpInfo (string scheduleId);
        /// <summary>
        /// Get a list of report time periods.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> AnalyticsReportingTimeperiodsGetAsync ();

        /// <summary>
        /// Get a list of report time periods.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> AnalyticsReportingTimeperiodsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Executes a segments query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">queryObject (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AnalyticsSegmentsQueryPostAsync (Object body = null);

        /// <summary>
        /// Executes a segments query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">queryObject (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsSegmentsQueryPostAsyncWithHttpInfo (Object body = null);
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
            if (alertId != null) localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete an alert. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AnalyticsAlertingAlertsAlertidDeleteAsync (string alertId)
        {
             await AnalyticsAlertingAlertsAlertidDeleteAsyncWithHttpInfo(alertId);

        }

        /// <summary>
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
            if (alertId != null) localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get an alert. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Alert</returns>
        public Alert AnalyticsAlertingAlertsAlertidGet (string alertId)
        {
             ApiResponse<Alert> localVarResponse = AnalyticsAlertingAlertsAlertidGetWithHttpInfo(alertId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an alert. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of Alert</returns>
        public ApiResponse< Alert > AnalyticsAlertingAlertsAlertidGetWithHttpInfo (string alertId)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsApi->AnalyticsAlertingAlertsAlertidGet");

            var localVarPath = "/api/v1/analytics/alerting/alerts/{alertId}";
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
            if (alertId != null) localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Alert>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Alert) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Alert)));
            
        }

        /// <summary>
        /// Get an alert. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of Alert</returns>
        public async System.Threading.Tasks.Task<Alert> AnalyticsAlertingAlertsAlertidGetAsync (string alertId)
        {
             ApiResponse<Alert> localVarResponse = await AnalyticsAlertingAlertsAlertidGetAsyncWithHttpInfo(alertId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an alert. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse (Alert)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Alert>> AnalyticsAlertingAlertsAlertidGetAsyncWithHttpInfo (string alertId)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsApi->AnalyticsAlertingAlertsAlertidGet");

            var localVarPath = "/api/v1/analytics/alerting/alerts/{alertId}";
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
            if (alertId != null) localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Alert>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Alert) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Alert)));
            
        }

        /// <summary>
        /// Update an alerts unread status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert (optional)</param>
        /// <returns>Alert</returns>
        public Alert AnalyticsAlertingAlertsAlertidPut (string alertId, Alert body = null)
        {
             ApiResponse<Alert> localVarResponse = AnalyticsAlertingAlertsAlertidPutWithHttpInfo(alertId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an alerts unread status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert (optional)</param>
        /// <returns>ApiResponse of Alert</returns>
        public ApiResponse< Alert > AnalyticsAlertingAlertsAlertidPutWithHttpInfo (string alertId, Alert body = null)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsApi->AnalyticsAlertingAlertsAlertidPut");

            var localVarPath = "/api/v1/analytics/alerting/alerts/{alertId}";
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
            if (alertId != null) localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Alert>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Alert) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Alert)));
            
        }

        /// <summary>
        /// Update an alerts unread status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert (optional)</param>
        /// <returns>Task of Alert</returns>
        public async System.Threading.Tasks.Task<Alert> AnalyticsAlertingAlertsAlertidPutAsync (string alertId, Alert body = null)
        {
             ApiResponse<Alert> localVarResponse = await AnalyticsAlertingAlertsAlertidPutAsyncWithHttpInfo(alertId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an alerts unread status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert (optional)</param>
        /// <returns>Task of ApiResponse (Alert)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Alert>> AnalyticsAlertingAlertsAlertidPutAsyncWithHttpInfo (string alertId, Alert body = null)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsApi->AnalyticsAlertingAlertsAlertidPut");

            var localVarPath = "/api/v1/analytics/alerting/alerts/{alertId}";
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
            if (alertId != null) localVarPathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsAlertidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Alert>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Alert) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Alert)));
            
        }

        /// <summary>
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
             return localVarResponse.Data;
        }

        /// <summary>
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
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AlertEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AlertEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AlertEntityListing)));
            
        }

        /// <summary>
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
             return localVarResponse.Data;

        }

        /// <summary>
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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsUnreadGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingAlertsUnreadGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnreadMetric>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnreadMetric) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnreadMetric)));
            
        }

        /// <summary>
        /// Get a list of rules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">title, description, inAlarm or enabled (optional, default to title)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>RuleEntityListing</returns>
        public RuleEntityListing AnalyticsAlertingRulesGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleEntityListing> localVarResponse = AnalyticsAlertingRulesGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of rules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">title, description, inAlarm or enabled (optional, default to title)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>ApiResponse of RuleEntityListing</returns>
        public ApiResponse< RuleEntityListing > AnalyticsAlertingRulesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/analytics/alerting/rules";
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
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleEntityListing)));
            
        }

        /// <summary>
        /// Get a list of rules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">title, description, inAlarm or enabled (optional, default to title)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of RuleEntityListing</returns>
        public async System.Threading.Tasks.Task<RuleEntityListing> AnalyticsAlertingRulesGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleEntityListing> localVarResponse = await AnalyticsAlertingRulesGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of rules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">title, description, inAlarm or enabled (optional, default to title)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (RuleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleEntityListing>> AnalyticsAlertingRulesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/analytics/alerting/rules";
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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleEntityListing)));
            
        }

        /// <summary>
        /// Create an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Rule</returns>
        public Rule AnalyticsAlertingRulesPost (Rule body = null)
        {
             ApiResponse<Rule> localVarResponse = AnalyticsAlertingRulesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Rule (optional)</param>
        /// <returns>ApiResponse of Rule</returns>
        public ApiResponse< Rule > AnalyticsAlertingRulesPostWithHttpInfo (Rule body = null)
        {

            var localVarPath = "/api/v1/analytics/alerting/rules";
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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Rule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Rule)));
            
        }

        /// <summary>
        /// Create an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Task of Rule</returns>
        public async System.Threading.Tasks.Task<Rule> AnalyticsAlertingRulesPostAsync (Rule body = null)
        {
             ApiResponse<Rule> localVarResponse = await AnalyticsAlertingRulesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Rule>> AnalyticsAlertingRulesPostAsyncWithHttpInfo (Rule body = null)
        {

            var localVarPath = "/api/v1/analytics/alerting/rules";
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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Rule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Rule)));
            
        }

        /// <summary>
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
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AnalyticsAlertingRulesRuleidDeleteAsync (string ruleId)
        {
             await AnalyticsAlertingRulesRuleidDeleteAsyncWithHttpInfo(ruleId);

        }

        /// <summary>
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
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Rule</returns>
        public Rule AnalyticsAlertingRulesRuleidGet (string ruleId)
        {
             ApiResponse<Rule> localVarResponse = AnalyticsAlertingRulesRuleidGetWithHttpInfo(ruleId);
             return localVarResponse.Data;
        }

        /// <summary>
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
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Rule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Rule)));
            
        }

        /// <summary>
        /// Get an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of Rule</returns>
        public async System.Threading.Tasks.Task<Rule> AnalyticsAlertingRulesRuleidGetAsync (string ruleId)
        {
             ApiResponse<Rule> localVarResponse = await AnalyticsAlertingRulesRuleidGetAsyncWithHttpInfo(ruleId);
             return localVarResponse.Data;

        }

        /// <summary>
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
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Rule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Rule)));
            
        }

        /// <summary>
        /// Update an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Rule</returns>
        public Rule AnalyticsAlertingRulesRuleidPut (string ruleId, Rule body = null)
        {
             ApiResponse<Rule> localVarResponse = AnalyticsAlertingRulesRuleidPutWithHttpInfo(ruleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
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
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Rule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Rule)));
            
        }

        /// <summary>
        /// Update an alerting rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule (optional)</param>
        /// <returns>Task of Rule</returns>
        public async System.Threading.Tasks.Task<Rule> AnalyticsAlertingRulesRuleidPutAsync (string ruleId, Rule body = null)
        {
             ApiResponse<Rule> localVarResponse = await AnalyticsAlertingRulesRuleidPutAsyncWithHttpInfo(ruleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
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
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsAlertingRulesRuleidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Rule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Rule)));
            
        }

        /// <summary>
        /// Executes a metrics query against the analytics service 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">queryObject (optional)</param>
        /// <returns></returns>
        public void AnalyticsMetricsQueryPost (Object body = null)
        {
             AnalyticsMetricsQueryPostWithHttpInfo(body);
        }

        /// <summary>
        /// Executes a metrics query against the analytics service 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">queryObject (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AnalyticsMetricsQueryPostWithHttpInfo (Object body = null)
        {

            var localVarPath = "/api/v1/analytics/metrics/query";
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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsMetricsQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsMetricsQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Executes a metrics query against the analytics service 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">queryObject (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AnalyticsMetricsQueryPostAsync (Object body = null)
        {
             await AnalyticsMetricsQueryPostAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Executes a metrics query against the analytics service 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">queryObject (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsMetricsQueryPostAsyncWithHttpInfo (Object body = null)
        {

            var localVarPath = "/api/v1/analytics/metrics/query";
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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsMetricsQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsMetricsQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get list of reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ReportMetaDataEntityListing</returns>
        public ReportMetaDataEntityListing AnalyticsReportingMetadataGet (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {
             ApiResponse<ReportMetaDataEntityListing> localVarResponse = AnalyticsReportingMetadataGetWithHttpInfo(pageNumber, pageSize, acceptLanguage, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>ApiResponse of ReportMetaDataEntityListing</returns>
        public ApiResponse< ReportMetaDataEntityListing > AnalyticsReportingMetadataGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {

            var localVarPath = "/api/v1/analytics/reporting/metadata";
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
            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingMetadataGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingMetadataGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportMetaDataEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaDataEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportMetaDataEntityListing)));
            
        }

        /// <summary>
        /// Get list of reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ReportMetaDataEntityListing</returns>
        public async System.Threading.Tasks.Task<ReportMetaDataEntityListing> AnalyticsReportingMetadataGetAsync (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {
             ApiResponse<ReportMetaDataEntityListing> localVarResponse = await AnalyticsReportingMetadataGetAsyncWithHttpInfo(pageNumber, pageSize, acceptLanguage, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of reporting metadata. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="acceptLanguage">Accepted language (optional)</param>
        /// <param name="locale">Locale (optional)</param>
        /// <returns>Task of ApiResponse (ReportMetaDataEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportMetaDataEntityListing>> AnalyticsReportingMetadataGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {

            var localVarPath = "/api/v1/analytics/reporting/metadata";
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
            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingMetadataGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingMetadataGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportMetaDataEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaDataEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportMetaDataEntityListing)));
            
        }

        /// <summary>
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> AnalyticsReportingReportformatsGet ()
        {
             ApiResponse<List<string>> localVarResponse = AnalyticsReportingReportformatsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > AnalyticsReportingReportformatsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/analytics/reporting/reportformats";
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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingReportformatsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingReportformatsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> AnalyticsReportingReportformatsGetAsync ()
        {
             ApiResponse<List<string>> localVarResponse = await AnalyticsReportingReportformatsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> AnalyticsReportingReportformatsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/analytics/reporting/reportformats";
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingReportformatsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingReportformatsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
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
             return localVarResponse.Data;
        }

        /// <summary>
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
            if (reportId != null) localVarPathParams.Add("reportId", Configuration.ApiClient.ParameterToString(reportId)); // path parameter
            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingReportidMetadataGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingReportidMetadataGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportMetaData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportMetaData)));
            
        }

        /// <summary>
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
             return localVarResponse.Data;

        }

        /// <summary>
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
            if (reportId != null) localVarPathParams.Add("reportId", Configuration.ApiClient.ParameterToString(reportId)); // path parameter
            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter

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
            
        }

        /// <summary>
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
            
        }

        /// <summary>
        /// Delete a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AnalyticsReportingSchedulesScheduleidDeleteAsync (string scheduleId)
        {
             ApiResponse<string> localVarResponse = await AnalyticsReportingSchedulesScheduleidDeleteAsyncWithHttpInfo(scheduleId);
             return localVarResponse.Data;

        }

        /// <summary>
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
            
        }

        /// <summary>
        /// Get list of completed scheduled report jobs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <returns>Task of ReportRunEntryEntityDomainListing</returns>
        public async System.Threading.Tasks.Task<ReportRunEntryEntityDomainListing> AnalyticsReportingSchedulesScheduleidHistoryGetAsync (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportRunEntryEntityDomainListing> localVarResponse = await AnalyticsReportingSchedulesScheduleidHistoryGetAsyncWithHttpInfo(scheduleId, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of completed scheduled report jobs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
        }

        /// <summary>
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        public async System.Threading.Tasks.Task<ReportRunEntry> AnalyticsReportingSchedulesScheduleidHistoryLatestGetAsync (string scheduleId)
        {
             ApiResponse<ReportRunEntry> localVarResponse = await AnalyticsReportingSchedulesScheduleidHistoryLatestGetAsyncWithHttpInfo(scheduleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> AnalyticsReportingSchedulesScheduleidHistoryLatestGetAsyncWithHttpInfo (string scheduleId)
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
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
            
        }

        /// <summary>
        /// A completed scheduled report job A completed scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportRunEntry</returns>
        public ReportRunEntry AnalyticsReportingSchedulesScheduleidHistoryRunidGet (string runId, string scheduleId)
        {
             ApiResponse<ReportRunEntry> localVarResponse = AnalyticsReportingSchedulesScheduleidHistoryRunidGetWithHttpInfo(runId, scheduleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// A completed scheduled report job A completed scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (runId != null) localVarPathParams.Add("runId", Configuration.ApiClient.ParameterToString(runId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportRunEntry>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportRunEntry)));
            
        }

        /// <summary>
        /// A completed scheduled report job A completed scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        public async System.Threading.Tasks.Task<ReportRunEntry> AnalyticsReportingSchedulesScheduleidHistoryRunidGetAsync (string runId, string scheduleId)
        {
             ApiResponse<ReportRunEntry> localVarResponse = await AnalyticsReportingSchedulesScheduleidHistoryRunidGetAsyncWithHttpInfo(runId, scheduleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// A completed scheduled report job A completed scheduled report job.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (runId != null) localVarPathParams.Add("runId", Configuration.ApiClient.ParameterToString(runId)); // path parameter
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportRunEntry>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportRunEntry)));
            
        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ReportSchedule</returns>
        public ReportSchedule AnalyticsReportingSchedulesScheduleidPut (string scheduleId, ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> localVarResponse = AnalyticsReportingSchedulesScheduleidPutWithHttpInfo(scheduleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        public ApiResponse< ReportSchedule > AnalyticsReportingSchedulesScheduleidPutWithHttpInfo (string scheduleId, ReportSchedule body = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidPut");

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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportSchedule)));
            
        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ReportSchedule</returns>
        public async System.Threading.Tasks.Task<ReportSchedule> AnalyticsReportingSchedulesScheduleidPutAsync (string scheduleId, ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> localVarResponse = await AnalyticsReportingSchedulesScheduleidPutAsyncWithHttpInfo(scheduleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule (optional)</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesScheduleidPutAsyncWithHttpInfo (string scheduleId, ReportSchedule body = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->AnalyticsReportingSchedulesScheduleidPut");

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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReportSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportSchedule)));
            
        }

        /// <summary>
        /// Place a scheduled report immediately into the reporting queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>RunNowResponse</returns>
        public RunNowResponse AnalyticsReportingSchedulesScheduleidRunreportPost (string scheduleId)
        {
             ApiResponse<RunNowResponse> localVarResponse = AnalyticsReportingSchedulesScheduleidRunreportPostWithHttpInfo(scheduleId);
             return localVarResponse.Data;
        }

        /// <summary>
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidRunreportPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidRunreportPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RunNowResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RunNowResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RunNowResponse)));
            
        }

        /// <summary>
        /// Place a scheduled report immediately into the reporting queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of RunNowResponse</returns>
        public async System.Threading.Tasks.Task<RunNowResponse> AnalyticsReportingSchedulesScheduleidRunreportPostAsync (string scheduleId)
        {
             ApiResponse<RunNowResponse> localVarResponse = await AnalyticsReportingSchedulesScheduleidRunreportPostAsyncWithHttpInfo(scheduleId);
             return localVarResponse.Data;

        }

        /// <summary>
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidRunreportPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingSchedulesScheduleidRunreportPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RunNowResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RunNowResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RunNowResponse)));
            
        }

        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> AnalyticsReportingTimeperiodsGet ()
        {
             ApiResponse<List<string>> localVarResponse = AnalyticsReportingTimeperiodsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > AnalyticsReportingTimeperiodsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/analytics/reporting/timeperiods";
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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingTimeperiodsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingTimeperiodsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> AnalyticsReportingTimeperiodsGetAsync ()
        {
             ApiResponse<List<string>> localVarResponse = await AnalyticsReportingTimeperiodsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> AnalyticsReportingTimeperiodsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/analytics/reporting/timeperiods";
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingTimeperiodsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsReportingTimeperiodsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Executes a segments query against the analytics service 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">queryObject (optional)</param>
        /// <returns></returns>
        public void AnalyticsSegmentsQueryPost (Object body = null)
        {
             AnalyticsSegmentsQueryPostWithHttpInfo(body);
        }

        /// <summary>
        /// Executes a segments query against the analytics service 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">queryObject (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AnalyticsSegmentsQueryPostWithHttpInfo (Object body = null)
        {

            var localVarPath = "/api/v1/analytics/segments/query";
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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsSegmentsQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsSegmentsQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Executes a segments query against the analytics service 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">queryObject (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AnalyticsSegmentsQueryPostAsync (Object body = null)
        {
             await AnalyticsSegmentsQueryPostAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Executes a segments query against the analytics service 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">queryObject (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsSegmentsQueryPostAsyncWithHttpInfo (Object body = null)
        {

            var localVarPath = "/api/v1/analytics/segments/query";
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
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsSegmentsQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AnalyticsSegmentsQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
