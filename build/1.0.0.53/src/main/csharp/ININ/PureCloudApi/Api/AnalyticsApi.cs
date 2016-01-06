using System;
using System.IO;
using System.Collections.Generic;
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
        
        /// <summary>
        /// Get a list of alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">title, startTime, endTime, description or unread</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>AlertEntityListing</returns>
        AlertEntityListing AnalyticsAlertingAlertsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Get a list of alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">title, startTime, endTime, description or unread</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>ApiResponse of AlertEntityListing</returns>
        ApiResponse<AlertEntityListing> AnalyticsAlertingAlertsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">title, startTime, endTime, description or unread</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>Task of AlertEntityListing</returns>
        System.Threading.Tasks.Task<AlertEntityListing> AnalyticsAlertingAlertsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">title, startTime, endTime, description or unread</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>Task of ApiResponse (AlertEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlertEntityListing>> AnalyticsAlertingAlertsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// A count of unread alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>UnreadMetric</returns>
        UnreadMetric AnalyticsAlertingAlertsUnreadGet ();
  
        /// <summary>
        /// A count of unread alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of UnreadMetric</returns>
        ApiResponse<UnreadMetric> AnalyticsAlertingAlertsUnreadGetWithHttpInfo ();

        /// <summary>
        /// A count of unread alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of UnreadMetric</returns>
        System.Threading.Tasks.Task<UnreadMetric> AnalyticsAlertingAlertsUnreadGetAsync ();

        /// <summary>
        /// A count of unread alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (UnreadMetric)</returns>
        System.Threading.Tasks.Task<ApiResponse<UnreadMetric>> AnalyticsAlertingAlertsUnreadGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Alert</returns>
        Alert AnalyticsAlertingAlertsAlertidGet (string alertId);
  
        /// <summary>
        /// Get an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of Alert</returns>
        ApiResponse<Alert> AnalyticsAlertingAlertsAlertidGetWithHttpInfo (string alertId);

        /// <summary>
        /// Get an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of Alert</returns>
        System.Threading.Tasks.Task<Alert> AnalyticsAlertingAlertsAlertidGetAsync (string alertId);

        /// <summary>
        /// Get an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse (Alert)</returns>
        System.Threading.Tasks.Task<ApiResponse<Alert>> AnalyticsAlertingAlertsAlertidGetAsyncWithHttpInfo (string alertId);
        
        /// <summary>
        /// Update an alerts unread status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert</param>
        /// <returns>Alert</returns>
        Alert AnalyticsAlertingAlertsAlertidPut (string alertId, Alert body = null);
  
        /// <summary>
        /// Update an alerts unread status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert</param>
        /// <returns>ApiResponse of Alert</returns>
        ApiResponse<Alert> AnalyticsAlertingAlertsAlertidPutWithHttpInfo (string alertId, Alert body = null);

        /// <summary>
        /// Update an alerts unread status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert</param>
        /// <returns>Task of Alert</returns>
        System.Threading.Tasks.Task<Alert> AnalyticsAlertingAlertsAlertidPutAsync (string alertId, Alert body = null);

        /// <summary>
        /// Update an alerts unread status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert</param>
        /// <returns>Task of ApiResponse (Alert)</returns>
        System.Threading.Tasks.Task<ApiResponse<Alert>> AnalyticsAlertingAlertsAlertidPutAsyncWithHttpInfo (string alertId, Alert body = null);
        
        /// <summary>
        /// Delete an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns></returns>
        void AnalyticsAlertingAlertsAlertidDelete (string alertId);
  
        /// <summary>
        /// Delete an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AnalyticsAlertingAlertsAlertidDeleteWithHttpInfo (string alertId);

        /// <summary>
        /// Delete an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AnalyticsAlertingAlertsAlertidDeleteAsync (string alertId);

        /// <summary>
        /// Delete an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsAlertingAlertsAlertidDeleteAsyncWithHttpInfo (string alertId);
        
        /// <summary>
        /// Get a list of rules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">title, description, inAlarm or enabled</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>RuleEntityListing</returns>
        RuleEntityListing AnalyticsAlertingRulesGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Get a list of rules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">title, description, inAlarm or enabled</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>ApiResponse of RuleEntityListing</returns>
        ApiResponse<RuleEntityListing> AnalyticsAlertingRulesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of rules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">title, description, inAlarm or enabled</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>Task of RuleEntityListing</returns>
        System.Threading.Tasks.Task<RuleEntityListing> AnalyticsAlertingRulesGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of rules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">title, description, inAlarm or enabled</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>Task of ApiResponse (RuleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleEntityListing>> AnalyticsAlertingRulesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Rule</param>
        /// <returns>Rule</returns>
        Rule AnalyticsAlertingRulesPost (Rule body = null);
  
        /// <summary>
        /// Create an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Rule</param>
        /// <returns>ApiResponse of Rule</returns>
        ApiResponse<Rule> AnalyticsAlertingRulesPostWithHttpInfo (Rule body = null);

        /// <summary>
        /// Create an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Rule</param>
        /// <returns>Task of Rule</returns>
        System.Threading.Tasks.Task<Rule> AnalyticsAlertingRulesPostAsync (Rule body = null);

        /// <summary>
        /// Create an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Rule</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Rule>> AnalyticsAlertingRulesPostAsyncWithHttpInfo (Rule body = null);
        
        /// <summary>
        /// Get an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Rule</returns>
        Rule AnalyticsAlertingRulesRuleidGet (string ruleId);
  
        /// <summary>
        /// Get an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of Rule</returns>
        ApiResponse<Rule> AnalyticsAlertingRulesRuleidGetWithHttpInfo (string ruleId);

        /// <summary>
        /// Get an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of Rule</returns>
        System.Threading.Tasks.Task<Rule> AnalyticsAlertingRulesRuleidGetAsync (string ruleId);

        /// <summary>
        /// Get an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Rule>> AnalyticsAlertingRulesRuleidGetAsyncWithHttpInfo (string ruleId);
        
        /// <summary>
        /// Update an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule</param>
        /// <returns>Rule</returns>
        Rule AnalyticsAlertingRulesRuleidPut (string ruleId, Rule body = null);
  
        /// <summary>
        /// Update an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule</param>
        /// <returns>ApiResponse of Rule</returns>
        ApiResponse<Rule> AnalyticsAlertingRulesRuleidPutWithHttpInfo (string ruleId, Rule body = null);

        /// <summary>
        /// Update an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule</param>
        /// <returns>Task of Rule</returns>
        System.Threading.Tasks.Task<Rule> AnalyticsAlertingRulesRuleidPutAsync (string ruleId, Rule body = null);

        /// <summary>
        /// Update an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Rule>> AnalyticsAlertingRulesRuleidPutAsyncWithHttpInfo (string ruleId, Rule body = null);
        
        /// <summary>
        /// Delete an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns></returns>
        void AnalyticsAlertingRulesRuleidDelete (string ruleId);
  
        /// <summary>
        /// Delete an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AnalyticsAlertingRulesRuleidDeleteWithHttpInfo (string ruleId);

        /// <summary>
        /// Delete an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AnalyticsAlertingRulesRuleidDeleteAsync (string ruleId);

        /// <summary>
        /// Delete an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsAlertingRulesRuleidDeleteAsyncWithHttpInfo (string ruleId);
        
        /// <summary>
        /// Executes a metrics query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns></returns>
        void AnalyticsMetricsQueryPost (Body body = null);
  
        /// <summary>
        /// Executes a metrics query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AnalyticsMetricsQueryPostWithHttpInfo (Body body = null);

        /// <summary>
        /// Executes a metrics query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AnalyticsMetricsQueryPostAsync (Body body = null);

        /// <summary>
        /// Executes a metrics query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsMetricsQueryPostAsyncWithHttpInfo (Body body = null);
        
        /// <summary>
        /// Executes a query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <param name="version">Version number</param>
        /// <returns></returns>
        void AnalyticsQueryPost (Body1 body = null, string version = null);
  
        /// <summary>
        /// Executes a query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <param name="version">Version number</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AnalyticsQueryPostWithHttpInfo (Body1 body = null, string version = null);

        /// <summary>
        /// Executes a query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <param name="version">Version number</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AnalyticsQueryPostAsync (Body1 body = null, string version = null);

        /// <summary>
        /// Executes a query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <param name="version">Version number</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsQueryPostAsyncWithHttpInfo (Body1 body = null, string version = null);
        
        /// <summary>
        /// Get list of reporting metadata.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="acceptLanguage">Accepted language</param>
        /// <param name="locale">Locale</param>
        /// <returns>ReportMetaDataEntityListing</returns>
        ReportMetaDataEntityListing AnalyticsReportingMetadataGet (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null);
  
        /// <summary>
        /// Get list of reporting metadata.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="acceptLanguage">Accepted language</param>
        /// <param name="locale">Locale</param>
        /// <returns>ApiResponse of ReportMetaDataEntityListing</returns>
        ApiResponse<ReportMetaDataEntityListing> AnalyticsReportingMetadataGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null);

        /// <summary>
        /// Get list of reporting metadata.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="acceptLanguage">Accepted language</param>
        /// <param name="locale">Locale</param>
        /// <returns>Task of ReportMetaDataEntityListing</returns>
        System.Threading.Tasks.Task<ReportMetaDataEntityListing> AnalyticsReportingMetadataGetAsync (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null);

        /// <summary>
        /// Get list of reporting metadata.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="acceptLanguage">Accepted language</param>
        /// <param name="locale">Locale</param>
        /// <returns>Task of ApiResponse (ReportMetaDataEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportMetaDataEntityListing>> AnalyticsReportingMetadataGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null);
        
        /// <summary>
        /// Get a list of report formats
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <returns>List&lt;string&gt;</returns>
        List<string> AnalyticsReportingReportformatsGet ();
  
        /// <summary>
        /// Get a list of report formats
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> AnalyticsReportingReportformatsGetWithHttpInfo ();

        /// <summary>
        /// Get a list of report formats
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> AnalyticsReportingReportformatsGetAsync ();

        /// <summary>
        /// Get a list of report formats
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> AnalyticsReportingReportformatsGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a list of scheduled report jobs
        /// </summary>
        /// <remarks>
        /// Get a list of scheduled report jobs.
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ReportScheduleEntityListing</returns>
        ReportScheduleEntityListing AnalyticsReportingSchedulesGet (int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Get a list of scheduled report jobs
        /// </summary>
        /// <remarks>
        /// Get a list of scheduled report jobs.
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of ReportScheduleEntityListing</returns>
        ApiResponse<ReportScheduleEntityListing> AnalyticsReportingSchedulesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of scheduled report jobs
        /// </summary>
        /// <remarks>
        /// Get a list of scheduled report jobs.
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ReportScheduleEntityListing</returns>
        System.Threading.Tasks.Task<ReportScheduleEntityListing> AnalyticsReportingSchedulesGetAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of scheduled report jobs
        /// </summary>
        /// <remarks>
        /// Get a list of scheduled report jobs.
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (ReportScheduleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportScheduleEntityListing>> AnalyticsReportingSchedulesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Create a scheduled report job
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <param name="body">ReportSchedule</param>
        /// <returns>ReportSchedule</returns>
        ReportSchedule AnalyticsReportingSchedulesPost (ReportSchedule body = null);
  
        /// <summary>
        /// Create a scheduled report job
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <param name="body">ReportSchedule</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        ApiResponse<ReportSchedule> AnalyticsReportingSchedulesPostWithHttpInfo (ReportSchedule body = null);

        /// <summary>
        /// Create a scheduled report job
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <param name="body">ReportSchedule</param>
        /// <returns>Task of ReportSchedule</returns>
        System.Threading.Tasks.Task<ReportSchedule> AnalyticsReportingSchedulesPostAsync (ReportSchedule body = null);

        /// <summary>
        /// Create a scheduled report job
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <param name="body">ReportSchedule</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesPostAsyncWithHttpInfo (ReportSchedule body = null);
        
        /// <summary>
        /// Get a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportSchedule</returns>
        ReportSchedule AnalyticsReportingSchedulesScheduleidGet (string scheduleId);
  
        /// <summary>
        /// Get a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        ApiResponse<ReportSchedule> AnalyticsReportingSchedulesScheduleidGetWithHttpInfo (string scheduleId);

        /// <summary>
        /// Get a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportSchedule</returns>
        System.Threading.Tasks.Task<ReportSchedule> AnalyticsReportingSchedulesScheduleidGetAsync (string scheduleId);

        /// <summary>
        /// Get a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesScheduleidGetAsyncWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Update a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule</param>
        /// <returns>ReportSchedule</returns>
        ReportSchedule AnalyticsReportingSchedulesScheduleidPut (string scheduleId, ReportSchedule body = null);
  
        /// <summary>
        /// Update a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        ApiResponse<ReportSchedule> AnalyticsReportingSchedulesScheduleidPutWithHttpInfo (string scheduleId, ReportSchedule body = null);

        /// <summary>
        /// Update a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule</param>
        /// <returns>Task of ReportSchedule</returns>
        System.Threading.Tasks.Task<ReportSchedule> AnalyticsReportingSchedulesScheduleidPutAsync (string scheduleId, ReportSchedule body = null);

        /// <summary>
        /// Update a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesScheduleidPutAsyncWithHttpInfo (string scheduleId, ReportSchedule body = null);
        
        /// <summary>
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>string</returns>
        string AnalyticsReportingSchedulesScheduleidDelete (string scheduleId);
  
        /// <summary>
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AnalyticsReportingSchedulesScheduleidDeleteWithHttpInfo (string scheduleId);

        /// <summary>
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AnalyticsReportingSchedulesScheduleidDeleteAsync (string scheduleId);

        /// <summary>
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AnalyticsReportingSchedulesScheduleidDeleteAsyncWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Get list of completed scheduled report jobs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns>ReportRunEntryEntityDomainListing</returns>
        ReportRunEntryEntityDomainListing AnalyticsReportingSchedulesScheduleidHistoryGet (string scheduleId, int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Get list of completed scheduled report jobs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns>ApiResponse of ReportRunEntryEntityDomainListing</returns>
        ApiResponse<ReportRunEntryEntityDomainListing> AnalyticsReportingSchedulesScheduleidHistoryGetWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get list of completed scheduled report jobs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns>Task of ReportRunEntryEntityDomainListing</returns>
        System.Threading.Tasks.Task<ReportRunEntryEntityDomainListing> AnalyticsReportingSchedulesScheduleidHistoryGetAsync (string scheduleId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get list of completed scheduled report jobs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns>Task of ApiResponse (ReportRunEntryEntityDomainListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportRunEntryEntityDomainListing>> AnalyticsReportingSchedulesScheduleidHistoryGetAsyncWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get most recently completed scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportRunEntry</returns>
        ReportRunEntry AnalyticsReportingSchedulesScheduleidHistoryLatestGet (string scheduleId);
  
        /// <summary>
        /// Get most recently completed scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportRunEntry</returns>
        ApiResponse<ReportRunEntry> AnalyticsReportingSchedulesScheduleidHistoryLatestGetWithHttpInfo (string scheduleId);

        /// <summary>
        /// Get most recently completed scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        System.Threading.Tasks.Task<ReportRunEntry> AnalyticsReportingSchedulesScheduleidHistoryLatestGetAsync (string scheduleId);

        /// <summary>
        /// Get most recently completed scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> AnalyticsReportingSchedulesScheduleidHistoryLatestGetAsyncWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// A completed scheduled report job
        /// </summary>
        /// <remarks>
        /// A completed scheduled report job.
        /// </remarks>
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
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportRunEntry</returns>
        ApiResponse<ReportRunEntry> AnalyticsReportingSchedulesScheduleidHistoryRunidGetWithHttpInfo (string runId, string scheduleId);

        /// <summary>
        /// A completed scheduled report job
        /// </summary>
        /// <remarks>
        /// A completed scheduled report job.
        /// </remarks>
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
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> AnalyticsReportingSchedulesScheduleidHistoryRunidGetAsyncWithHttpInfo (string runId, string scheduleId);
        
        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>RunNowResponse</returns>
        RunNowResponse AnalyticsReportingSchedulesScheduleidRunreportPost (string scheduleId);
  
        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of RunNowResponse</returns>
        ApiResponse<RunNowResponse> AnalyticsReportingSchedulesScheduleidRunreportPostWithHttpInfo (string scheduleId);

        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of RunNowResponse</returns>
        System.Threading.Tasks.Task<RunNowResponse> AnalyticsReportingSchedulesScheduleidRunreportPostAsync (string scheduleId);

        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (RunNowResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RunNowResponse>> AnalyticsReportingSchedulesScheduleidRunreportPostAsyncWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Get a list of report time periods.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;string&gt;</returns>
        List<string> AnalyticsReportingTimeperiodsGet ();
  
        /// <summary>
        /// Get a list of report time periods.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> AnalyticsReportingTimeperiodsGetWithHttpInfo ();

        /// <summary>
        /// Get a list of report time periods.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> AnalyticsReportingTimeperiodsGetAsync ();

        /// <summary>
        /// Get a list of report time periods.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> AnalyticsReportingTimeperiodsGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a reporting metadata.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language</param>
        /// <param name="locale">Locale</param>
        /// <returns>ReportMetaData</returns>
        ReportMetaData AnalyticsReportingReportidMetadataGet (string reportId, string acceptLanguage = null, string locale = null);
  
        /// <summary>
        /// Get a reporting metadata.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language</param>
        /// <param name="locale">Locale</param>
        /// <returns>ApiResponse of ReportMetaData</returns>
        ApiResponse<ReportMetaData> AnalyticsReportingReportidMetadataGetWithHttpInfo (string reportId, string acceptLanguage = null, string locale = null);

        /// <summary>
        /// Get a reporting metadata.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language</param>
        /// <param name="locale">Locale</param>
        /// <returns>Task of ReportMetaData</returns>
        System.Threading.Tasks.Task<ReportMetaData> AnalyticsReportingReportidMetadataGetAsync (string reportId, string acceptLanguage = null, string locale = null);

        /// <summary>
        /// Get a reporting metadata.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language</param>
        /// <param name="locale">Locale</param>
        /// <returns>Task of ApiResponse (ReportMetaData)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportMetaData>> AnalyticsReportingReportidMetadataGetAsyncWithHttpInfo (string reportId, string acceptLanguage = null, string locale = null);
        
        /// <summary>
        /// Executes a segments query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns></returns>
        void AnalyticsSegmentsQueryPost (Body2 body = null);
  
        /// <summary>
        /// Executes a segments query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AnalyticsSegmentsQueryPostWithHttpInfo (Body2 body = null);

        /// <summary>
        /// Executes a segments query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AnalyticsSegmentsQueryPostAsync (Body2 body = null);

        /// <summary>
        /// Executes a segments query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsSegmentsQueryPostAsyncWithHttpInfo (Body2 body = null);
        
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
        /// Get a list of alerts. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">title, startTime, endTime, description or unread</param> 
        /// <param name="sortOrder">ascending or descending</param> 
        /// <returns>AlertEntityListing</returns>
        public AlertEntityListing AnalyticsAlertingAlertsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<AlertEntityListing> response = AnalyticsAlertingAlertsGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Get a list of alerts. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">title, startTime, endTime, description or unread</param> 
        /// <param name="sortOrder">ascending or descending</param> 
        /// <returns>ApiResponse of AlertEntityListing</returns>
        public ApiResponse< AlertEntityListing > AnalyticsAlertingAlertsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/analytics/alerting/alerts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AlertEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AlertEntityListing) Configuration.ApiClient.Deserialize(response, typeof(AlertEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of alerts. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">title, startTime, endTime, description or unread</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>Task of AlertEntityListing</returns>
        public async System.Threading.Tasks.Task<AlertEntityListing> AnalyticsAlertingAlertsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<AlertEntityListing> response = await AnalyticsAlertingAlertsGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Get a list of alerts. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">title, startTime, endTime, description or unread</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>Task of ApiResponse (AlertEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AlertEntityListing>> AnalyticsAlertingAlertsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/analytics/alerting/alerts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AlertEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AlertEntityListing) Configuration.ApiClient.Deserialize(response, typeof(AlertEntityListing)));
            
        }
        
        /// <summary>
        /// A count of unread alerts. 
        /// </summary>
        /// <returns>UnreadMetric</returns>
        public UnreadMetric AnalyticsAlertingAlertsUnreadGet ()
        {
             ApiResponse<UnreadMetric> response = AnalyticsAlertingAlertsUnreadGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// A count of unread alerts. 
        /// </summary>
        /// <returns>ApiResponse of UnreadMetric</returns>
        public ApiResponse< UnreadMetric > AnalyticsAlertingAlertsUnreadGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/unread";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsUnreadGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsUnreadGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UnreadMetric>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnreadMetric) Configuration.ApiClient.Deserialize(response, typeof(UnreadMetric)));
            
        }
    
        /// <summary>
        /// A count of unread alerts. 
        /// </summary>
        /// <returns>Task of UnreadMetric</returns>
        public async System.Threading.Tasks.Task<UnreadMetric> AnalyticsAlertingAlertsUnreadGetAsync ()
        {
             ApiResponse<UnreadMetric> response = await AnalyticsAlertingAlertsUnreadGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// A count of unread alerts. 
        /// </summary>
        /// <returns>Task of ApiResponse (UnreadMetric)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UnreadMetric>> AnalyticsAlertingAlertsUnreadGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/unread";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsUnreadGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsUnreadGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UnreadMetric>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnreadMetric) Configuration.ApiClient.Deserialize(response, typeof(UnreadMetric)));
            
        }
        
        /// <summary>
        /// Get an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param> 
        /// <returns>Alert</returns>
        public Alert AnalyticsAlertingAlertsAlertidGet (string alertId)
        {
             ApiResponse<Alert> response = AnalyticsAlertingAlertsAlertidGetWithHttpInfo(alertId);
             return response.Data;
        }

        /// <summary>
        /// Get an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param> 
        /// <returns>ApiResponse of Alert</returns>
        public ApiResponse< Alert > AnalyticsAlertingAlertsAlertidGetWithHttpInfo (string alertId)
        {
            
            // verify the required parameter 'alertId' is set
            if (alertId == null) throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsAlertingAlertsAlertidGet");
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/{alertId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (alertId != null) pathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsAlertidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsAlertidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Alert>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Alert) Configuration.ApiClient.Deserialize(response, typeof(Alert)));
            
        }
    
        /// <summary>
        /// Get an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of Alert</returns>
        public async System.Threading.Tasks.Task<Alert> AnalyticsAlertingAlertsAlertidGetAsync (string alertId)
        {
             ApiResponse<Alert> response = await AnalyticsAlertingAlertsAlertidGetAsyncWithHttpInfo(alertId);
             return response.Data;

        }

        /// <summary>
        /// Get an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse (Alert)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Alert>> AnalyticsAlertingAlertsAlertidGetAsyncWithHttpInfo (string alertId)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null) throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsAlertingAlertsAlertidGet");
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/{alertId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (alertId != null) pathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsAlertidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsAlertidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Alert>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Alert) Configuration.ApiClient.Deserialize(response, typeof(Alert)));
            
        }
        
        /// <summary>
        /// Update an alerts unread status. 
        /// </summary>
        /// <param name="alertId">Alert ID</param> 
        /// <param name="body">Alert</param> 
        /// <returns>Alert</returns>
        public Alert AnalyticsAlertingAlertsAlertidPut (string alertId, Alert body = null)
        {
             ApiResponse<Alert> response = AnalyticsAlertingAlertsAlertidPutWithHttpInfo(alertId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an alerts unread status. 
        /// </summary>
        /// <param name="alertId">Alert ID</param> 
        /// <param name="body">Alert</param> 
        /// <returns>ApiResponse of Alert</returns>
        public ApiResponse< Alert > AnalyticsAlertingAlertsAlertidPutWithHttpInfo (string alertId, Alert body = null)
        {
            
            // verify the required parameter 'alertId' is set
            if (alertId == null) throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsAlertingAlertsAlertidPut");
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/{alertId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (alertId != null) pathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsAlertidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsAlertidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Alert>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Alert) Configuration.ApiClient.Deserialize(response, typeof(Alert)));
            
        }
    
        /// <summary>
        /// Update an alerts unread status. 
        /// </summary>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert</param>
        /// <returns>Task of Alert</returns>
        public async System.Threading.Tasks.Task<Alert> AnalyticsAlertingAlertsAlertidPutAsync (string alertId, Alert body = null)
        {
             ApiResponse<Alert> response = await AnalyticsAlertingAlertsAlertidPutAsyncWithHttpInfo(alertId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an alerts unread status. 
        /// </summary>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert</param>
        /// <returns>Task of ApiResponse (Alert)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Alert>> AnalyticsAlertingAlertsAlertidPutAsyncWithHttpInfo (string alertId, Alert body = null)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null) throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsAlertingAlertsAlertidPut");
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/{alertId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (alertId != null) pathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsAlertidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsAlertidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Alert>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Alert) Configuration.ApiClient.Deserialize(response, typeof(Alert)));
            
        }
        
        /// <summary>
        /// Delete an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param> 
        /// <returns></returns>
        public void AnalyticsAlertingAlertsAlertidDelete (string alertId)
        {
             AnalyticsAlertingAlertsAlertidDeleteWithHttpInfo(alertId);
        }

        /// <summary>
        /// Delete an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AnalyticsAlertingAlertsAlertidDeleteWithHttpInfo (string alertId)
        {
            
            // verify the required parameter 'alertId' is set
            if (alertId == null) throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsAlertingAlertsAlertidDelete");
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/{alertId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (alertId != null) pathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsAlertidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsAlertidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AnalyticsAlertingAlertsAlertidDeleteAsync (string alertId)
        {
             await AnalyticsAlertingAlertsAlertidDeleteAsyncWithHttpInfo(alertId);

        }

        /// <summary>
        /// Delete an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsAlertingAlertsAlertidDeleteAsyncWithHttpInfo (string alertId)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null) throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsAlertingAlertsAlertidDelete");
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/{alertId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (alertId != null) pathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsAlertidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingAlertsAlertidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a list of rules. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">title, description, inAlarm or enabled</param> 
        /// <param name="sortOrder">ascending or descending</param> 
        /// <returns>RuleEntityListing</returns>
        public RuleEntityListing AnalyticsAlertingRulesGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleEntityListing> response = AnalyticsAlertingRulesGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Get a list of rules. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">title, description, inAlarm or enabled</param> 
        /// <param name="sortOrder">ascending or descending</param> 
        /// <returns>ApiResponse of RuleEntityListing</returns>
        public ApiResponse< RuleEntityListing > AnalyticsAlertingRulesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/analytics/alerting/rules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<RuleEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleEntityListing) Configuration.ApiClient.Deserialize(response, typeof(RuleEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of rules. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">title, description, inAlarm or enabled</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>Task of RuleEntityListing</returns>
        public async System.Threading.Tasks.Task<RuleEntityListing> AnalyticsAlertingRulesGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleEntityListing> response = await AnalyticsAlertingRulesGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Get a list of rules. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">title, description, inAlarm or enabled</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>Task of ApiResponse (RuleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleEntityListing>> AnalyticsAlertingRulesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/analytics/alerting/rules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RuleEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleEntityListing) Configuration.ApiClient.Deserialize(response, typeof(RuleEntityListing)));
            
        }
        
        /// <summary>
        /// Create an alerting rule. 
        /// </summary>
        /// <param name="body">Rule</param> 
        /// <returns>Rule</returns>
        public Rule AnalyticsAlertingRulesPost (Rule body = null)
        {
             ApiResponse<Rule> response = AnalyticsAlertingRulesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an alerting rule. 
        /// </summary>
        /// <param name="body">Rule</param> 
        /// <returns>ApiResponse of Rule</returns>
        public ApiResponse< Rule > AnalyticsAlertingRulesPostWithHttpInfo (Rule body = null)
        {
            
    
            var path_ = "/api/v1/analytics/alerting/rules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Rule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(response, typeof(Rule)));
            
        }
    
        /// <summary>
        /// Create an alerting rule. 
        /// </summary>
        /// <param name="body">Rule</param>
        /// <returns>Task of Rule</returns>
        public async System.Threading.Tasks.Task<Rule> AnalyticsAlertingRulesPostAsync (Rule body = null)
        {
             ApiResponse<Rule> response = await AnalyticsAlertingRulesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an alerting rule. 
        /// </summary>
        /// <param name="body">Rule</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Rule>> AnalyticsAlertingRulesPostAsyncWithHttpInfo (Rule body = null)
        {
            
    
            var path_ = "/api/v1/analytics/alerting/rules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Rule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(response, typeof(Rule)));
            
        }
        
        /// <summary>
        /// Get an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param> 
        /// <returns>Rule</returns>
        public Rule AnalyticsAlertingRulesRuleidGet (string ruleId)
        {
             ApiResponse<Rule> response = AnalyticsAlertingRulesRuleidGetWithHttpInfo(ruleId);
             return response.Data;
        }

        /// <summary>
        /// Get an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param> 
        /// <returns>ApiResponse of Rule</returns>
        public ApiResponse< Rule > AnalyticsAlertingRulesRuleidGetWithHttpInfo (string ruleId)
        {
            
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling AnalyticsAlertingRulesRuleidGet");
            
    
            var path_ = "/api/v1/analytics/alerting/rules/{ruleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (ruleId != null) pathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesRuleidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesRuleidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Rule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(response, typeof(Rule)));
            
        }
    
        /// <summary>
        /// Get an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of Rule</returns>
        public async System.Threading.Tasks.Task<Rule> AnalyticsAlertingRulesRuleidGetAsync (string ruleId)
        {
             ApiResponse<Rule> response = await AnalyticsAlertingRulesRuleidGetAsyncWithHttpInfo(ruleId);
             return response.Data;

        }

        /// <summary>
        /// Get an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Rule>> AnalyticsAlertingRulesRuleidGetAsyncWithHttpInfo (string ruleId)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling AnalyticsAlertingRulesRuleidGet");
            
    
            var path_ = "/api/v1/analytics/alerting/rules/{ruleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (ruleId != null) pathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesRuleidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesRuleidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Rule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(response, typeof(Rule)));
            
        }
        
        /// <summary>
        /// Update an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param> 
        /// <param name="body">Rule</param> 
        /// <returns>Rule</returns>
        public Rule AnalyticsAlertingRulesRuleidPut (string ruleId, Rule body = null)
        {
             ApiResponse<Rule> response = AnalyticsAlertingRulesRuleidPutWithHttpInfo(ruleId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param> 
        /// <param name="body">Rule</param> 
        /// <returns>ApiResponse of Rule</returns>
        public ApiResponse< Rule > AnalyticsAlertingRulesRuleidPutWithHttpInfo (string ruleId, Rule body = null)
        {
            
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling AnalyticsAlertingRulesRuleidPut");
            
    
            var path_ = "/api/v1/analytics/alerting/rules/{ruleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (ruleId != null) pathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesRuleidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesRuleidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Rule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(response, typeof(Rule)));
            
        }
    
        /// <summary>
        /// Update an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule</param>
        /// <returns>Task of Rule</returns>
        public async System.Threading.Tasks.Task<Rule> AnalyticsAlertingRulesRuleidPutAsync (string ruleId, Rule body = null)
        {
             ApiResponse<Rule> response = await AnalyticsAlertingRulesRuleidPutAsyncWithHttpInfo(ruleId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Rule>> AnalyticsAlertingRulesRuleidPutAsyncWithHttpInfo (string ruleId, Rule body = null)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling AnalyticsAlertingRulesRuleidPut");
            
    
            var path_ = "/api/v1/analytics/alerting/rules/{ruleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (ruleId != null) pathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesRuleidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesRuleidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Rule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(response, typeof(Rule)));
            
        }
        
        /// <summary>
        /// Delete an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param> 
        /// <returns></returns>
        public void AnalyticsAlertingRulesRuleidDelete (string ruleId)
        {
             AnalyticsAlertingRulesRuleidDeleteWithHttpInfo(ruleId);
        }

        /// <summary>
        /// Delete an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AnalyticsAlertingRulesRuleidDeleteWithHttpInfo (string ruleId)
        {
            
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling AnalyticsAlertingRulesRuleidDelete");
            
    
            var path_ = "/api/v1/analytics/alerting/rules/{ruleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (ruleId != null) pathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesRuleidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesRuleidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AnalyticsAlertingRulesRuleidDeleteAsync (string ruleId)
        {
             await AnalyticsAlertingRulesRuleidDeleteAsyncWithHttpInfo(ruleId);

        }

        /// <summary>
        /// Delete an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsAlertingRulesRuleidDeleteAsyncWithHttpInfo (string ruleId)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling AnalyticsAlertingRulesRuleidDelete");
            
    
            var path_ = "/api/v1/analytics/alerting/rules/{ruleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (ruleId != null) pathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesRuleidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsAlertingRulesRuleidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Executes a metrics query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param> 
        /// <returns></returns>
        public void AnalyticsMetricsQueryPost (Body body = null)
        {
             AnalyticsMetricsQueryPostWithHttpInfo(body);
        }

        /// <summary>
        /// Executes a metrics query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AnalyticsMetricsQueryPostWithHttpInfo (Body body = null)
        {
            
    
            var path_ = "/api/v1/analytics/metrics/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsMetricsQueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsMetricsQueryPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Executes a metrics query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AnalyticsMetricsQueryPostAsync (Body body = null)
        {
             await AnalyticsMetricsQueryPostAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Executes a metrics query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsMetricsQueryPostAsyncWithHttpInfo (Body body = null)
        {
            
    
            var path_ = "/api/v1/analytics/metrics/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsMetricsQueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsMetricsQueryPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Executes a query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param> 
        /// <param name="version">Version number</param> 
        /// <returns></returns>
        public void AnalyticsQueryPost (Body1 body = null, string version = null)
        {
             AnalyticsQueryPostWithHttpInfo(body, version);
        }

        /// <summary>
        /// Executes a query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param> 
        /// <param name="version">Version number</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AnalyticsQueryPostWithHttpInfo (Body1 body = null, string version = null)
        {
            
    
            var path_ = "/api/v1/analytics/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (version != null) queryParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsQueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsQueryPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Executes a query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param>
        /// <param name="version">Version number</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AnalyticsQueryPostAsync (Body1 body = null, string version = null)
        {
             await AnalyticsQueryPostAsyncWithHttpInfo(body, version);

        }

        /// <summary>
        /// Executes a query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param>
        /// <param name="version">Version number</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsQueryPostAsyncWithHttpInfo (Body1 body = null, string version = null)
        {
            
    
            var path_ = "/api/v1/analytics/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (version != null) queryParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsQueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsQueryPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get list of reporting metadata. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="acceptLanguage">Accepted language</param> 
        /// <param name="locale">Locale</param> 
        /// <returns>ReportMetaDataEntityListing</returns>
        public ReportMetaDataEntityListing AnalyticsReportingMetadataGet (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {
             ApiResponse<ReportMetaDataEntityListing> response = AnalyticsReportingMetadataGetWithHttpInfo(pageNumber, pageSize, acceptLanguage, locale);
             return response.Data;
        }

        /// <summary>
        /// Get list of reporting metadata. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="acceptLanguage">Accepted language</param> 
        /// <param name="locale">Locale</param> 
        /// <returns>ApiResponse of ReportMetaDataEntityListing</returns>
        public ApiResponse< ReportMetaDataEntityListing > AnalyticsReportingMetadataGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {
            
    
            var path_ = "/api/v1/analytics/reporting/metadata";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (locale != null) queryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
            
            if (acceptLanguage != null) headerParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingMetadataGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingMetadataGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ReportMetaDataEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaDataEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ReportMetaDataEntityListing)));
            
        }
    
        /// <summary>
        /// Get list of reporting metadata. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="acceptLanguage">Accepted language</param>
        /// <param name="locale">Locale</param>
        /// <returns>Task of ReportMetaDataEntityListing</returns>
        public async System.Threading.Tasks.Task<ReportMetaDataEntityListing> AnalyticsReportingMetadataGetAsync (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {
             ApiResponse<ReportMetaDataEntityListing> response = await AnalyticsReportingMetadataGetAsyncWithHttpInfo(pageNumber, pageSize, acceptLanguage, locale);
             return response.Data;

        }

        /// <summary>
        /// Get list of reporting metadata. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="acceptLanguage">Accepted language</param>
        /// <param name="locale">Locale</param>
        /// <returns>Task of ApiResponse (ReportMetaDataEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportMetaDataEntityListing>> AnalyticsReportingMetadataGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {
            
    
            var path_ = "/api/v1/analytics/reporting/metadata";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (locale != null) queryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
            
            if (acceptLanguage != null) headerParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingMetadataGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingMetadataGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportMetaDataEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaDataEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ReportMetaDataEntityListing)));
            
        }
        
        /// <summary>
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> AnalyticsReportingReportformatsGet ()
        {
             ApiResponse<List<string>> response = AnalyticsReportingReportformatsGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > AnalyticsReportingReportformatsGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/analytics/reporting/reportformats";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingReportformatsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingReportformatsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
    
        /// <summary>
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> AnalyticsReportingReportformatsGetAsync ()
        {
             ApiResponse<List<string>> response = await AnalyticsReportingReportformatsGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> AnalyticsReportingReportformatsGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/analytics/reporting/reportformats";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingReportformatsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingReportformatsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
        
        /// <summary>
        /// Get a list of scheduled report jobs Get a list of scheduled report jobs.
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ReportScheduleEntityListing</returns>
        public ReportScheduleEntityListing AnalyticsReportingSchedulesGet (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportScheduleEntityListing> response = AnalyticsReportingSchedulesGetWithHttpInfo(pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Get a list of scheduled report jobs Get a list of scheduled report jobs.
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of ReportScheduleEntityListing</returns>
        public ApiResponse< ReportScheduleEntityListing > AnalyticsReportingSchedulesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/analytics/reporting/schedules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ReportScheduleEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportScheduleEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ReportScheduleEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of scheduled report jobs Get a list of scheduled report jobs.
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ReportScheduleEntityListing</returns>
        public async System.Threading.Tasks.Task<ReportScheduleEntityListing> AnalyticsReportingSchedulesGetAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportScheduleEntityListing> response = await AnalyticsReportingSchedulesGetAsyncWithHttpInfo(pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Get a list of scheduled report jobs Get a list of scheduled report jobs.
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (ReportScheduleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportScheduleEntityListing>> AnalyticsReportingSchedulesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/analytics/reporting/schedules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportScheduleEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportScheduleEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ReportScheduleEntityListing)));
            
        }
        
        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <param name="body">ReportSchedule</param> 
        /// <returns>ReportSchedule</returns>
        public ReportSchedule AnalyticsReportingSchedulesPost (ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> response = AnalyticsReportingSchedulesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <param name="body">ReportSchedule</param> 
        /// <returns>ApiResponse of ReportSchedule</returns>
        public ApiResponse< ReportSchedule > AnalyticsReportingSchedulesPostWithHttpInfo (ReportSchedule body = null)
        {
            
    
            var path_ = "/api/v1/analytics/reporting/schedules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ReportSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(response, typeof(ReportSchedule)));
            
        }
    
        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <param name="body">ReportSchedule</param>
        /// <returns>Task of ReportSchedule</returns>
        public async System.Threading.Tasks.Task<ReportSchedule> AnalyticsReportingSchedulesPostAsync (ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> response = await AnalyticsReportingSchedulesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <param name="body">ReportSchedule</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesPostAsyncWithHttpInfo (ReportSchedule body = null)
        {
            
    
            var path_ = "/api/v1/analytics/reporting/schedules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(response, typeof(ReportSchedule)));
            
        }
        
        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ReportSchedule</returns>
        public ReportSchedule AnalyticsReportingSchedulesScheduleidGet (string scheduleId)
        {
             ApiResponse<ReportSchedule> response = AnalyticsReportingSchedulesScheduleidGetWithHttpInfo(scheduleId);
             return response.Data;
        }

        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of ReportSchedule</returns>
        public ApiResponse< ReportSchedule > AnalyticsReportingSchedulesScheduleidGetWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsReportingSchedulesScheduleidGet");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ReportSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(response, typeof(ReportSchedule)));
            
        }
    
        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportSchedule</returns>
        public async System.Threading.Tasks.Task<ReportSchedule> AnalyticsReportingSchedulesScheduleidGetAsync (string scheduleId)
        {
             ApiResponse<ReportSchedule> response = await AnalyticsReportingSchedulesScheduleidGetAsyncWithHttpInfo(scheduleId);
             return response.Data;

        }

        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesScheduleidGetAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsReportingSchedulesScheduleidGet");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(response, typeof(ReportSchedule)));
            
        }
        
        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <param name="body">ReportSchedule</param> 
        /// <returns>ReportSchedule</returns>
        public ReportSchedule AnalyticsReportingSchedulesScheduleidPut (string scheduleId, ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> response = AnalyticsReportingSchedulesScheduleidPutWithHttpInfo(scheduleId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <param name="body">ReportSchedule</param> 
        /// <returns>ApiResponse of ReportSchedule</returns>
        public ApiResponse< ReportSchedule > AnalyticsReportingSchedulesScheduleidPutWithHttpInfo (string scheduleId, ReportSchedule body = null)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsReportingSchedulesScheduleidPut");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ReportSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(response, typeof(ReportSchedule)));
            
        }
    
        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule</param>
        /// <returns>Task of ReportSchedule</returns>
        public async System.Threading.Tasks.Task<ReportSchedule> AnalyticsReportingSchedulesScheduleidPutAsync (string scheduleId, ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> response = await AnalyticsReportingSchedulesScheduleidPutAsyncWithHttpInfo(scheduleId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> AnalyticsReportingSchedulesScheduleidPutAsyncWithHttpInfo (string scheduleId, ReportSchedule body = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsReportingSchedulesScheduleidPut");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(response, typeof(ReportSchedule)));
            
        }
        
        /// <summary>
        /// Delete a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>string</returns>
        public string AnalyticsReportingSchedulesScheduleidDelete (string scheduleId)
        {
             ApiResponse<string> response = AnalyticsReportingSchedulesScheduleidDeleteWithHttpInfo(scheduleId);
             return response.Data;
        }

        /// <summary>
        /// Delete a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AnalyticsReportingSchedulesScheduleidDeleteWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsReportingSchedulesScheduleidDelete");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AnalyticsReportingSchedulesScheduleidDeleteAsync (string scheduleId)
        {
             ApiResponse<string> response = await AnalyticsReportingSchedulesScheduleidDeleteAsyncWithHttpInfo(scheduleId);
             return response.Data;

        }

        /// <summary>
        /// Delete a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AnalyticsReportingSchedulesScheduleidDeleteAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsReportingSchedulesScheduleidDelete");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get list of completed scheduled report jobs. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <param name="pageNumber"></param> 
        /// <param name="pageSize"></param> 
        /// <returns>ReportRunEntryEntityDomainListing</returns>
        public ReportRunEntryEntityDomainListing AnalyticsReportingSchedulesScheduleidHistoryGet (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportRunEntryEntityDomainListing> response = AnalyticsReportingSchedulesScheduleidHistoryGetWithHttpInfo(scheduleId, pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Get list of completed scheduled report jobs. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <param name="pageNumber"></param> 
        /// <param name="pageSize"></param> 
        /// <returns>ApiResponse of ReportRunEntryEntityDomainListing</returns>
        public ApiResponse< ReportRunEntryEntityDomainListing > AnalyticsReportingSchedulesScheduleidHistoryGetWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsReportingSchedulesScheduleidHistoryGet");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/history";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ReportRunEntryEntityDomainListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntryEntityDomainListing) Configuration.ApiClient.Deserialize(response, typeof(ReportRunEntryEntityDomainListing)));
            
        }
    
        /// <summary>
        /// Get list of completed scheduled report jobs. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns>Task of ReportRunEntryEntityDomainListing</returns>
        public async System.Threading.Tasks.Task<ReportRunEntryEntityDomainListing> AnalyticsReportingSchedulesScheduleidHistoryGetAsync (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportRunEntryEntityDomainListing> response = await AnalyticsReportingSchedulesScheduleidHistoryGetAsyncWithHttpInfo(scheduleId, pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Get list of completed scheduled report jobs. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns>Task of ApiResponse (ReportRunEntryEntityDomainListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportRunEntryEntityDomainListing>> AnalyticsReportingSchedulesScheduleidHistoryGetAsyncWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsReportingSchedulesScheduleidHistoryGet");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/history";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportRunEntryEntityDomainListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntryEntityDomainListing) Configuration.ApiClient.Deserialize(response, typeof(ReportRunEntryEntityDomainListing)));
            
        }
        
        /// <summary>
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ReportRunEntry</returns>
        public ReportRunEntry AnalyticsReportingSchedulesScheduleidHistoryLatestGet (string scheduleId)
        {
             ApiResponse<ReportRunEntry> response = AnalyticsReportingSchedulesScheduleidHistoryLatestGetWithHttpInfo(scheduleId);
             return response.Data;
        }

        /// <summary>
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of ReportRunEntry</returns>
        public ApiResponse< ReportRunEntry > AnalyticsReportingSchedulesScheduleidHistoryLatestGetWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsReportingSchedulesScheduleidHistoryLatestGet");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/history/latest";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryLatestGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryLatestGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ReportRunEntry>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(response, typeof(ReportRunEntry)));
            
        }
    
        /// <summary>
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        public async System.Threading.Tasks.Task<ReportRunEntry> AnalyticsReportingSchedulesScheduleidHistoryLatestGetAsync (string scheduleId)
        {
             ApiResponse<ReportRunEntry> response = await AnalyticsReportingSchedulesScheduleidHistoryLatestGetAsyncWithHttpInfo(scheduleId);
             return response.Data;

        }

        /// <summary>
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> AnalyticsReportingSchedulesScheduleidHistoryLatestGetAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsReportingSchedulesScheduleidHistoryLatestGet");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/history/latest";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryLatestGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryLatestGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportRunEntry>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(response, typeof(ReportRunEntry)));
            
        }
        
        /// <summary>
        /// A completed scheduled report job A completed scheduled report job.
        /// </summary>
        /// <param name="runId">Run ID</param> 
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ReportRunEntry</returns>
        public ReportRunEntry AnalyticsReportingSchedulesScheduleidHistoryRunidGet (string runId, string scheduleId)
        {
             ApiResponse<ReportRunEntry> response = AnalyticsReportingSchedulesScheduleidHistoryRunidGetWithHttpInfo(runId, scheduleId);
             return response.Data;
        }

        /// <summary>
        /// A completed scheduled report job A completed scheduled report job.
        /// </summary>
        /// <param name="runId">Run ID</param> 
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of ReportRunEntry</returns>
        public ApiResponse< ReportRunEntry > AnalyticsReportingSchedulesScheduleidHistoryRunidGetWithHttpInfo (string runId, string scheduleId)
        {
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet");
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/history/{runId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (runId != null) pathParams.Add("runId", Configuration.ApiClient.ParameterToString(runId)); // path parameter
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ReportRunEntry>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(response, typeof(ReportRunEntry)));
            
        }
    
        /// <summary>
        /// A completed scheduled report job A completed scheduled report job.
        /// </summary>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        public async System.Threading.Tasks.Task<ReportRunEntry> AnalyticsReportingSchedulesScheduleidHistoryRunidGetAsync (string runId, string scheduleId)
        {
             ApiResponse<ReportRunEntry> response = await AnalyticsReportingSchedulesScheduleidHistoryRunidGetAsyncWithHttpInfo(runId, scheduleId);
             return response.Data;

        }

        /// <summary>
        /// A completed scheduled report job A completed scheduled report job.
        /// </summary>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> AnalyticsReportingSchedulesScheduleidHistoryRunidGetAsyncWithHttpInfo (string runId, string scheduleId)
        {
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/history/{runId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (runId != null) pathParams.Add("runId", Configuration.ApiClient.ParameterToString(runId)); // path parameter
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidHistoryRunidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportRunEntry>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(response, typeof(ReportRunEntry)));
            
        }
        
        /// <summary>
        /// Place a scheduled report immediately into the reporting queue 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>RunNowResponse</returns>
        public RunNowResponse AnalyticsReportingSchedulesScheduleidRunreportPost (string scheduleId)
        {
             ApiResponse<RunNowResponse> response = AnalyticsReportingSchedulesScheduleidRunreportPostWithHttpInfo(scheduleId);
             return response.Data;
        }

        /// <summary>
        /// Place a scheduled report immediately into the reporting queue 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of RunNowResponse</returns>
        public ApiResponse< RunNowResponse > AnalyticsReportingSchedulesScheduleidRunreportPostWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsReportingSchedulesScheduleidRunreportPost");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/runreport";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidRunreportPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidRunreportPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<RunNowResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RunNowResponse) Configuration.ApiClient.Deserialize(response, typeof(RunNowResponse)));
            
        }
    
        /// <summary>
        /// Place a scheduled report immediately into the reporting queue 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of RunNowResponse</returns>
        public async System.Threading.Tasks.Task<RunNowResponse> AnalyticsReportingSchedulesScheduleidRunreportPostAsync (string scheduleId)
        {
             ApiResponse<RunNowResponse> response = await AnalyticsReportingSchedulesScheduleidRunreportPostAsyncWithHttpInfo(scheduleId);
             return response.Data;

        }

        /// <summary>
        /// Place a scheduled report immediately into the reporting queue 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (RunNowResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RunNowResponse>> AnalyticsReportingSchedulesScheduleidRunreportPostAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsReportingSchedulesScheduleidRunreportPost");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/runreport";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidRunreportPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingSchedulesScheduleidRunreportPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RunNowResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RunNowResponse) Configuration.ApiClient.Deserialize(response, typeof(RunNowResponse)));
            
        }
        
        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> AnalyticsReportingTimeperiodsGet ()
        {
             ApiResponse<List<string>> response = AnalyticsReportingTimeperiodsGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > AnalyticsReportingTimeperiodsGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/analytics/reporting/timeperiods";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingTimeperiodsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingTimeperiodsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
    
        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> AnalyticsReportingTimeperiodsGetAsync ()
        {
             ApiResponse<List<string>> response = await AnalyticsReportingTimeperiodsGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> AnalyticsReportingTimeperiodsGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/analytics/reporting/timeperiods";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingTimeperiodsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingTimeperiodsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
        
        /// <summary>
        /// Get a reporting metadata. 
        /// </summary>
        /// <param name="reportId">Report ID</param> 
        /// <param name="acceptLanguage">Accepted language</param> 
        /// <param name="locale">Locale</param> 
        /// <returns>ReportMetaData</returns>
        public ReportMetaData AnalyticsReportingReportidMetadataGet (string reportId, string acceptLanguage = null, string locale = null)
        {
             ApiResponse<ReportMetaData> response = AnalyticsReportingReportidMetadataGetWithHttpInfo(reportId, acceptLanguage, locale);
             return response.Data;
        }

        /// <summary>
        /// Get a reporting metadata. 
        /// </summary>
        /// <param name="reportId">Report ID</param> 
        /// <param name="acceptLanguage">Accepted language</param> 
        /// <param name="locale">Locale</param> 
        /// <returns>ApiResponse of ReportMetaData</returns>
        public ApiResponse< ReportMetaData > AnalyticsReportingReportidMetadataGetWithHttpInfo (string reportId, string acceptLanguage = null, string locale = null)
        {
            
            // verify the required parameter 'reportId' is set
            if (reportId == null) throw new ApiException(400, "Missing required parameter 'reportId' when calling AnalyticsReportingReportidMetadataGet");
            
    
            var path_ = "/api/v1/analytics/reporting/{reportId}/metadata";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (reportId != null) pathParams.Add("reportId", Configuration.ApiClient.ParameterToString(reportId)); // path parameter
            
            if (locale != null) queryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
            
            if (acceptLanguage != null) headerParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingReportidMetadataGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingReportidMetadataGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ReportMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaData) Configuration.ApiClient.Deserialize(response, typeof(ReportMetaData)));
            
        }
    
        /// <summary>
        /// Get a reporting metadata. 
        /// </summary>
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language</param>
        /// <param name="locale">Locale</param>
        /// <returns>Task of ReportMetaData</returns>
        public async System.Threading.Tasks.Task<ReportMetaData> AnalyticsReportingReportidMetadataGetAsync (string reportId, string acceptLanguage = null, string locale = null)
        {
             ApiResponse<ReportMetaData> response = await AnalyticsReportingReportidMetadataGetAsyncWithHttpInfo(reportId, acceptLanguage, locale);
             return response.Data;

        }

        /// <summary>
        /// Get a reporting metadata. 
        /// </summary>
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language</param>
        /// <param name="locale">Locale</param>
        /// <returns>Task of ApiResponse (ReportMetaData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportMetaData>> AnalyticsReportingReportidMetadataGetAsyncWithHttpInfo (string reportId, string acceptLanguage = null, string locale = null)
        {
            // verify the required parameter 'reportId' is set
            if (reportId == null) throw new ApiException(400, "Missing required parameter 'reportId' when calling AnalyticsReportingReportidMetadataGet");
            
    
            var path_ = "/api/v1/analytics/reporting/{reportId}/metadata";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (reportId != null) pathParams.Add("reportId", Configuration.ApiClient.ParameterToString(reportId)); // path parameter
            
            if (locale != null) queryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter
            
            if (acceptLanguage != null) headerParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingReportidMetadataGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsReportingReportidMetadataGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaData) Configuration.ApiClient.Deserialize(response, typeof(ReportMetaData)));
            
        }
        
        /// <summary>
        /// Executes a segments query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param> 
        /// <returns></returns>
        public void AnalyticsSegmentsQueryPost (Body2 body = null)
        {
             AnalyticsSegmentsQueryPostWithHttpInfo(body);
        }

        /// <summary>
        /// Executes a segments query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AnalyticsSegmentsQueryPostWithHttpInfo (Body2 body = null)
        {
            
    
            var path_ = "/api/v1/analytics/segments/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsSegmentsQueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsSegmentsQueryPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Executes a segments query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AnalyticsSegmentsQueryPostAsync (Body2 body = null)
        {
             await AnalyticsSegmentsQueryPostAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Executes a segments query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AnalyticsSegmentsQueryPostAsyncWithHttpInfo (Body2 body = null)
        {
            
    
            var path_ = "/api/v1/analytics/segments/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AnalyticsSegmentsQueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AnalyticsSegmentsQueryPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
