using System;
using System.IO;
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
        AlertEntityListing GetAlertingAlerts (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<AlertEntityListing> GetAlertingAlertsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<AlertEntityListing> GetAlertingAlertsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<AlertEntityListing>> GetAlertingAlertsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// A count of unread alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>UnreadMetric</returns>
        UnreadMetric GetAlertingAlertsUnread ();
  
        /// <summary>
        /// A count of unread alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of UnreadMetric</returns>
        ApiResponse<UnreadMetric> GetAlertingAlertsUnreadWithHttpInfo ();

        /// <summary>
        /// A count of unread alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of UnreadMetric</returns>
        System.Threading.Tasks.Task<UnreadMetric> GetAlertingAlertsUnreadAsync ();

        /// <summary>
        /// A count of unread alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (UnreadMetric)</returns>
        System.Threading.Tasks.Task<ApiResponse<UnreadMetric>> GetAlertingAlertsUnreadAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Alert</returns>
        Alert GetAlertingAlertsAlertId (string alertId);
  
        /// <summary>
        /// Get an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of Alert</returns>
        ApiResponse<Alert> GetAlertingAlertsAlertIdWithHttpInfo (string alertId);

        /// <summary>
        /// Get an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of Alert</returns>
        System.Threading.Tasks.Task<Alert> GetAlertingAlertsAlertIdAsync (string alertId);

        /// <summary>
        /// Get an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse (Alert)</returns>
        System.Threading.Tasks.Task<ApiResponse<Alert>> GetAlertingAlertsAlertIdAsyncWithHttpInfo (string alertId);
        
        /// <summary>
        /// Update an alerts unread status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert</param>
        /// <returns>Alert</returns>
        Alert PutAlertingAlertsAlertId (string alertId, Alert body = null);
  
        /// <summary>
        /// Update an alerts unread status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert</param>
        /// <returns>ApiResponse of Alert</returns>
        ApiResponse<Alert> PutAlertingAlertsAlertIdWithHttpInfo (string alertId, Alert body = null);

        /// <summary>
        /// Update an alerts unread status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert</param>
        /// <returns>Task of Alert</returns>
        System.Threading.Tasks.Task<Alert> PutAlertingAlertsAlertIdAsync (string alertId, Alert body = null);

        /// <summary>
        /// Update an alerts unread status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert</param>
        /// <returns>Task of ApiResponse (Alert)</returns>
        System.Threading.Tasks.Task<ApiResponse<Alert>> PutAlertingAlertsAlertIdAsyncWithHttpInfo (string alertId, Alert body = null);
        
        /// <summary>
        /// Delete an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns></returns>
        void DeleteAlertingAlertsAlertId (string alertId);
  
        /// <summary>
        /// Delete an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAlertingAlertsAlertIdWithHttpInfo (string alertId);

        /// <summary>
        /// Delete an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAlertingAlertsAlertIdAsync (string alertId);

        /// <summary>
        /// Delete an alert.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAlertingAlertsAlertIdAsyncWithHttpInfo (string alertId);
        
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
        RuleEntityListing GetAlertingRules (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<RuleEntityListing> GetAlertingRulesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<RuleEntityListing> GetAlertingRulesAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<RuleEntityListing>> GetAlertingRulesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Rule</param>
        /// <returns>Rule</returns>
        Rule PostAlertingRules (Rule body = null);
  
        /// <summary>
        /// Create an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Rule</param>
        /// <returns>ApiResponse of Rule</returns>
        ApiResponse<Rule> PostAlertingRulesWithHttpInfo (Rule body = null);

        /// <summary>
        /// Create an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Rule</param>
        /// <returns>Task of Rule</returns>
        System.Threading.Tasks.Task<Rule> PostAlertingRulesAsync (Rule body = null);

        /// <summary>
        /// Create an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Rule</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Rule>> PostAlertingRulesAsyncWithHttpInfo (Rule body = null);
        
        /// <summary>
        /// Get an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Rule</returns>
        Rule GetAlertingRulesRuleId (string ruleId);
  
        /// <summary>
        /// Get an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of Rule</returns>
        ApiResponse<Rule> GetAlertingRulesRuleIdWithHttpInfo (string ruleId);

        /// <summary>
        /// Get an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of Rule</returns>
        System.Threading.Tasks.Task<Rule> GetAlertingRulesRuleIdAsync (string ruleId);

        /// <summary>
        /// Get an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Rule>> GetAlertingRulesRuleIdAsyncWithHttpInfo (string ruleId);
        
        /// <summary>
        /// Update an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule</param>
        /// <returns>Rule</returns>
        Rule PutAlertingRulesRuleId (string ruleId, Rule body = null);
  
        /// <summary>
        /// Update an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule</param>
        /// <returns>ApiResponse of Rule</returns>
        ApiResponse<Rule> PutAlertingRulesRuleIdWithHttpInfo (string ruleId, Rule body = null);

        /// <summary>
        /// Update an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule</param>
        /// <returns>Task of Rule</returns>
        System.Threading.Tasks.Task<Rule> PutAlertingRulesRuleIdAsync (string ruleId, Rule body = null);

        /// <summary>
        /// Update an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Rule>> PutAlertingRulesRuleIdAsyncWithHttpInfo (string ruleId, Rule body = null);
        
        /// <summary>
        /// Delete an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns></returns>
        void DeleteAlertingRulesRuleId (string ruleId);
  
        /// <summary>
        /// Delete an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAlertingRulesRuleIdWithHttpInfo (string ruleId);

        /// <summary>
        /// Delete an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAlertingRulesRuleIdAsync (string ruleId);

        /// <summary>
        /// Delete an alerting rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAlertingRulesRuleIdAsyncWithHttpInfo (string ruleId);
        
        /// <summary>
        /// Executes a metrics query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns></returns>
        void PostMetricsQuery (Body body = null);
  
        /// <summary>
        /// Executes a metrics query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostMetricsQueryWithHttpInfo (Body body = null);

        /// <summary>
        /// Executes a metrics query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostMetricsQueryAsync (Body body = null);

        /// <summary>
        /// Executes a metrics query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostMetricsQueryAsyncWithHttpInfo (Body body = null);
        
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
        ReportMetaDataEntityListing GetReportingMetadata (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null);
  
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
        ApiResponse<ReportMetaDataEntityListing> GetReportingMetadataWithHttpInfo (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null);

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
        System.Threading.Tasks.Task<ReportMetaDataEntityListing> GetReportingMetadataAsync (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<ReportMetaDataEntityListing>> GetReportingMetadataAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null);
        
        /// <summary>
        /// Get a list of report formats
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetReportingReportformats ();
  
        /// <summary>
        /// Get a list of report formats
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> GetReportingReportformatsWithHttpInfo ();

        /// <summary>
        /// Get a list of report formats
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> GetReportingReportformatsAsync ();

        /// <summary>
        /// Get a list of report formats
        /// </summary>
        /// <remarks>
        /// Get a list of report formats.
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> GetReportingReportformatsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a list of scheduled report jobs
        /// </summary>
        /// <remarks>
        /// Get a list of scheduled report jobs.
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ReportScheduleEntityListing</returns>
        ReportScheduleEntityListing GetReportingSchedules (int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Get a list of scheduled report jobs
        /// </summary>
        /// <remarks>
        /// Get a list of scheduled report jobs.
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of ReportScheduleEntityListing</returns>
        ApiResponse<ReportScheduleEntityListing> GetReportingSchedulesWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of scheduled report jobs
        /// </summary>
        /// <remarks>
        /// Get a list of scheduled report jobs.
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ReportScheduleEntityListing</returns>
        System.Threading.Tasks.Task<ReportScheduleEntityListing> GetReportingSchedulesAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a list of scheduled report jobs
        /// </summary>
        /// <remarks>
        /// Get a list of scheduled report jobs.
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (ReportScheduleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportScheduleEntityListing>> GetReportingSchedulesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Create a scheduled report job
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <param name="body">ReportSchedule</param>
        /// <returns>ReportSchedule</returns>
        ReportSchedule PostReportingSchedules (ReportSchedule body = null);
  
        /// <summary>
        /// Create a scheduled report job
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <param name="body">ReportSchedule</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        ApiResponse<ReportSchedule> PostReportingSchedulesWithHttpInfo (ReportSchedule body = null);

        /// <summary>
        /// Create a scheduled report job
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <param name="body">ReportSchedule</param>
        /// <returns>Task of ReportSchedule</returns>
        System.Threading.Tasks.Task<ReportSchedule> PostReportingSchedulesAsync (ReportSchedule body = null);

        /// <summary>
        /// Create a scheduled report job
        /// </summary>
        /// <remarks>
        /// Create a scheduled report job.
        /// </remarks>
        /// <param name="body">ReportSchedule</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> PostReportingSchedulesAsyncWithHttpInfo (ReportSchedule body = null);
        
        /// <summary>
        /// Get a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportSchedule</returns>
        ReportSchedule GetReportingSchedulesScheduleId (string scheduleId);
  
        /// <summary>
        /// Get a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        ApiResponse<ReportSchedule> GetReportingSchedulesScheduleIdWithHttpInfo (string scheduleId);

        /// <summary>
        /// Get a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportSchedule</returns>
        System.Threading.Tasks.Task<ReportSchedule> GetReportingSchedulesScheduleIdAsync (string scheduleId);

        /// <summary>
        /// Get a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> GetReportingSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Update a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule</param>
        /// <returns>ReportSchedule</returns>
        ReportSchedule PutReportingSchedulesScheduleId (string scheduleId, ReportSchedule body = null);
  
        /// <summary>
        /// Update a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule</param>
        /// <returns>ApiResponse of ReportSchedule</returns>
        ApiResponse<ReportSchedule> PutReportingSchedulesScheduleIdWithHttpInfo (string scheduleId, ReportSchedule body = null);

        /// <summary>
        /// Update a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule</param>
        /// <returns>Task of ReportSchedule</returns>
        System.Threading.Tasks.Task<ReportSchedule> PutReportingSchedulesScheduleIdAsync (string scheduleId, ReportSchedule body = null);

        /// <summary>
        /// Update a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> PutReportingSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId, ReportSchedule body = null);
        
        /// <summary>
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>string</returns>
        string DeleteReportingSchedulesScheduleId (string scheduleId);
  
        /// <summary>
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteReportingSchedulesScheduleIdWithHttpInfo (string scheduleId);

        /// <summary>
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteReportingSchedulesScheduleIdAsync (string scheduleId);

        /// <summary>
        /// Delete a scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteReportingSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId);
        
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
        ReportRunEntryEntityDomainListing GetReportingSchedulesScheduleIdHistory (string scheduleId, int? pageNumber = null, int? pageSize = null);
  
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
        ApiResponse<ReportRunEntryEntityDomainListing> GetReportingSchedulesScheduleIdHistoryWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null);

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
        System.Threading.Tasks.Task<ReportRunEntryEntityDomainListing> GetReportingSchedulesScheduleIdHistoryAsync (string scheduleId, int? pageNumber = null, int? pageSize = null);

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
        System.Threading.Tasks.Task<ApiResponse<ReportRunEntryEntityDomainListing>> GetReportingSchedulesScheduleIdHistoryAsyncWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get most recently completed scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportRunEntry</returns>
        ReportRunEntry GetReportingSchedulesScheduleIdHistoryLatest (string scheduleId);
  
        /// <summary>
        /// Get most recently completed scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportRunEntry</returns>
        ApiResponse<ReportRunEntry> GetReportingSchedulesScheduleIdHistoryLatestWithHttpInfo (string scheduleId);

        /// <summary>
        /// Get most recently completed scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        System.Threading.Tasks.Task<ReportRunEntry> GetReportingSchedulesScheduleIdHistoryLatestAsync (string scheduleId);

        /// <summary>
        /// Get most recently completed scheduled report job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> GetReportingSchedulesScheduleIdHistoryLatestAsyncWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// A completed scheduled report job
        /// </summary>
        /// <remarks>
        /// A completed scheduled report job.
        /// </remarks>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ReportRunEntry</returns>
        ReportRunEntry GetReportingSchedulesScheduleIdHistoryRunId (string runId, string scheduleId);
  
        /// <summary>
        /// A completed scheduled report job
        /// </summary>
        /// <remarks>
        /// A completed scheduled report job.
        /// </remarks>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of ReportRunEntry</returns>
        ApiResponse<ReportRunEntry> GetReportingSchedulesScheduleIdHistoryRunIdWithHttpInfo (string runId, string scheduleId);

        /// <summary>
        /// A completed scheduled report job
        /// </summary>
        /// <remarks>
        /// A completed scheduled report job.
        /// </remarks>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        System.Threading.Tasks.Task<ReportRunEntry> GetReportingSchedulesScheduleIdHistoryRunIdAsync (string runId, string scheduleId);

        /// <summary>
        /// A completed scheduled report job
        /// </summary>
        /// <remarks>
        /// A completed scheduled report job.
        /// </remarks>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> GetReportingSchedulesScheduleIdHistoryRunIdAsyncWithHttpInfo (string runId, string scheduleId);
        
        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>RunNowResponse</returns>
        RunNowResponse PostReportingSchedulesScheduleIdRunreport (string scheduleId);
  
        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of RunNowResponse</returns>
        ApiResponse<RunNowResponse> PostReportingSchedulesScheduleIdRunreportWithHttpInfo (string scheduleId);

        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of RunNowResponse</returns>
        System.Threading.Tasks.Task<RunNowResponse> PostReportingSchedulesScheduleIdRunreportAsync (string scheduleId);

        /// <summary>
        /// Place a scheduled report immediately into the reporting queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (RunNowResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RunNowResponse>> PostReportingSchedulesScheduleIdRunreportAsyncWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Get a list of report time periods.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetReportingTimeperiods ();
  
        /// <summary>
        /// Get a list of report time periods.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> GetReportingTimeperiodsWithHttpInfo ();

        /// <summary>
        /// Get a list of report time periods.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> GetReportingTimeperiodsAsync ();

        /// <summary>
        /// Get a list of report time periods.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> GetReportingTimeperiodsAsyncWithHttpInfo ();
        
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
        ReportMetaData GetReportingReportIdMetadata (string reportId, string acceptLanguage = null, string locale = null);
  
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
        ApiResponse<ReportMetaData> GetReportingReportIdMetadataWithHttpInfo (string reportId, string acceptLanguage = null, string locale = null);

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
        System.Threading.Tasks.Task<ReportMetaData> GetReportingReportIdMetadataAsync (string reportId, string acceptLanguage = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<ReportMetaData>> GetReportingReportIdMetadataAsyncWithHttpInfo (string reportId, string acceptLanguage = null, string locale = null);
        
        /// <summary>
        /// Executes a segments query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns></returns>
        void PostSegmentsQuery (Body1 body = null);
  
        /// <summary>
        /// Executes a segments query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostSegmentsQueryWithHttpInfo (Body1 body = null);

        /// <summary>
        /// Executes a segments query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostSegmentsQueryAsync (Body1 body = null);

        /// <summary>
        /// Executes a segments query against the analytics service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">queryObject</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostSegmentsQueryAsyncWithHttpInfo (Body1 body = null);
        
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
        public AlertEntityListing GetAlertingAlerts (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<AlertEntityListing> response = GetAlertingAlertsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public ApiResponse< AlertEntityListing > GetAlertingAlertsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/analytics/alerting/alerts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAlertingAlerts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAlertingAlerts: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<AlertEntityListing> GetAlertingAlertsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<AlertEntityListing> response = await GetAlertingAlertsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<AlertEntityListing>> GetAlertingAlertsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/analytics/alerting/alerts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAlertingAlerts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAlertingAlerts: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AlertEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AlertEntityListing) Configuration.ApiClient.Deserialize(response, typeof(AlertEntityListing)));
            
        }
        
        /// <summary>
        /// A count of unread alerts. 
        /// </summary>
        /// <returns>UnreadMetric</returns>
        public UnreadMetric GetAlertingAlertsUnread ()
        {
             ApiResponse<UnreadMetric> response = GetAlertingAlertsUnreadWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// A count of unread alerts. 
        /// </summary>
        /// <returns>ApiResponse of UnreadMetric</returns>
        public ApiResponse< UnreadMetric > GetAlertingAlertsUnreadWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/unread";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAlertingAlertsUnread: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAlertingAlertsUnread: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UnreadMetric>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnreadMetric) Configuration.ApiClient.Deserialize(response, typeof(UnreadMetric)));
            
        }
    
        /// <summary>
        /// A count of unread alerts. 
        /// </summary>
        /// <returns>Task of UnreadMetric</returns>
        public async System.Threading.Tasks.Task<UnreadMetric> GetAlertingAlertsUnreadAsync ()
        {
             ApiResponse<UnreadMetric> response = await GetAlertingAlertsUnreadAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// A count of unread alerts. 
        /// </summary>
        /// <returns>Task of ApiResponse (UnreadMetric)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UnreadMetric>> GetAlertingAlertsUnreadAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/unread";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAlertingAlertsUnread: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAlertingAlertsUnread: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UnreadMetric>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnreadMetric) Configuration.ApiClient.Deserialize(response, typeof(UnreadMetric)));
            
        }
        
        /// <summary>
        /// Get an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param> 
        /// <returns>Alert</returns>
        public Alert GetAlertingAlertsAlertId (string alertId)
        {
             ApiResponse<Alert> response = GetAlertingAlertsAlertIdWithHttpInfo(alertId);
             return response.Data;
        }

        /// <summary>
        /// Get an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param> 
        /// <returns>ApiResponse of Alert</returns>
        public ApiResponse< Alert > GetAlertingAlertsAlertIdWithHttpInfo (string alertId)
        {
            
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsApi->GetAlertingAlertsAlertId");
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/{alertId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAlertingAlertsAlertId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAlertingAlertsAlertId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Alert>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Alert) Configuration.ApiClient.Deserialize(response, typeof(Alert)));
            
        }
    
        /// <summary>
        /// Get an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of Alert</returns>
        public async System.Threading.Tasks.Task<Alert> GetAlertingAlertsAlertIdAsync (string alertId)
        {
             ApiResponse<Alert> response = await GetAlertingAlertsAlertIdAsyncWithHttpInfo(alertId);
             return response.Data;

        }

        /// <summary>
        /// Get an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse (Alert)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Alert>> GetAlertingAlertsAlertIdAsyncWithHttpInfo (string alertId)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null) throw new ApiException(400, "Missing required parameter 'alertId' when calling GetAlertingAlertsAlertId");
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/{alertId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAlertingAlertsAlertId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAlertingAlertsAlertId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Alert PutAlertingAlertsAlertId (string alertId, Alert body = null)
        {
             ApiResponse<Alert> response = PutAlertingAlertsAlertIdWithHttpInfo(alertId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an alerts unread status. 
        /// </summary>
        /// <param name="alertId">Alert ID</param> 
        /// <param name="body">Alert</param> 
        /// <returns>ApiResponse of Alert</returns>
        public ApiResponse< Alert > PutAlertingAlertsAlertIdWithHttpInfo (string alertId, Alert body = null)
        {
            
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsApi->PutAlertingAlertsAlertId");
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/{alertId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (alertId != null) pathParams.Add("alertId", Configuration.ApiClient.ParameterToString(alertId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutAlertingAlertsAlertId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutAlertingAlertsAlertId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Alert> PutAlertingAlertsAlertIdAsync (string alertId, Alert body = null)
        {
             ApiResponse<Alert> response = await PutAlertingAlertsAlertIdAsyncWithHttpInfo(alertId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an alerts unread status. 
        /// </summary>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">Alert</param>
        /// <returns>Task of ApiResponse (Alert)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Alert>> PutAlertingAlertsAlertIdAsyncWithHttpInfo (string alertId, Alert body = null)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null) throw new ApiException(400, "Missing required parameter 'alertId' when calling PutAlertingAlertsAlertId");
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/{alertId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutAlertingAlertsAlertId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutAlertingAlertsAlertId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Alert>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Alert) Configuration.ApiClient.Deserialize(response, typeof(Alert)));
            
        }
        
        /// <summary>
        /// Delete an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param> 
        /// <returns></returns>
        public void DeleteAlertingAlertsAlertId (string alertId)
        {
             DeleteAlertingAlertsAlertIdWithHttpInfo(alertId);
        }

        /// <summary>
        /// Delete an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteAlertingAlertsAlertIdWithHttpInfo (string alertId)
        {
            
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AnalyticsApi->DeleteAlertingAlertsAlertId");
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/{alertId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteAlertingAlertsAlertId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteAlertingAlertsAlertId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAlertingAlertsAlertIdAsync (string alertId)
        {
             await DeleteAlertingAlertsAlertIdAsyncWithHttpInfo(alertId);

        }

        /// <summary>
        /// Delete an alert. 
        /// </summary>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAlertingAlertsAlertIdAsyncWithHttpInfo (string alertId)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null) throw new ApiException(400, "Missing required parameter 'alertId' when calling DeleteAlertingAlertsAlertId");
            
    
            var path_ = "/api/v1/analytics/alerting/alerts/{alertId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteAlertingAlertsAlertId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteAlertingAlertsAlertId: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public RuleEntityListing GetAlertingRules (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleEntityListing> response = GetAlertingRulesWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public ApiResponse< RuleEntityListing > GetAlertingRulesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/analytics/alerting/rules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAlertingRules: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAlertingRules: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<RuleEntityListing> GetAlertingRulesAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleEntityListing> response = await GetAlertingRulesAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<RuleEntityListing>> GetAlertingRulesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/analytics/alerting/rules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAlertingRules: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAlertingRules: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RuleEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleEntityListing) Configuration.ApiClient.Deserialize(response, typeof(RuleEntityListing)));
            
        }
        
        /// <summary>
        /// Create an alerting rule. 
        /// </summary>
        /// <param name="body">Rule</param> 
        /// <returns>Rule</returns>
        public Rule PostAlertingRules (Rule body = null)
        {
             ApiResponse<Rule> response = PostAlertingRulesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an alerting rule. 
        /// </summary>
        /// <param name="body">Rule</param> 
        /// <returns>ApiResponse of Rule</returns>
        public ApiResponse< Rule > PostAlertingRulesWithHttpInfo (Rule body = null)
        {
            
    
            var path_ = "/api/v1/analytics/alerting/rules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostAlertingRules: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostAlertingRules: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Rule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(response, typeof(Rule)));
            
        }
    
        /// <summary>
        /// Create an alerting rule. 
        /// </summary>
        /// <param name="body">Rule</param>
        /// <returns>Task of Rule</returns>
        public async System.Threading.Tasks.Task<Rule> PostAlertingRulesAsync (Rule body = null)
        {
             ApiResponse<Rule> response = await PostAlertingRulesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an alerting rule. 
        /// </summary>
        /// <param name="body">Rule</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Rule>> PostAlertingRulesAsyncWithHttpInfo (Rule body = null)
        {
            
    
            var path_ = "/api/v1/analytics/alerting/rules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostAlertingRules: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostAlertingRules: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Rule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(response, typeof(Rule)));
            
        }
        
        /// <summary>
        /// Get an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param> 
        /// <returns>Rule</returns>
        public Rule GetAlertingRulesRuleId (string ruleId)
        {
             ApiResponse<Rule> response = GetAlertingRulesRuleIdWithHttpInfo(ruleId);
             return response.Data;
        }

        /// <summary>
        /// Get an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param> 
        /// <returns>ApiResponse of Rule</returns>
        public ApiResponse< Rule > GetAlertingRulesRuleIdWithHttpInfo (string ruleId)
        {
            
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AnalyticsApi->GetAlertingRulesRuleId");
            
    
            var path_ = "/api/v1/analytics/alerting/rules/{ruleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAlertingRulesRuleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAlertingRulesRuleId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Rule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(response, typeof(Rule)));
            
        }
    
        /// <summary>
        /// Get an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of Rule</returns>
        public async System.Threading.Tasks.Task<Rule> GetAlertingRulesRuleIdAsync (string ruleId)
        {
             ApiResponse<Rule> response = await GetAlertingRulesRuleIdAsyncWithHttpInfo(ruleId);
             return response.Data;

        }

        /// <summary>
        /// Get an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Rule>> GetAlertingRulesRuleIdAsyncWithHttpInfo (string ruleId)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling GetAlertingRulesRuleId");
            
    
            var path_ = "/api/v1/analytics/alerting/rules/{ruleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAlertingRulesRuleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAlertingRulesRuleId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Rule PutAlertingRulesRuleId (string ruleId, Rule body = null)
        {
             ApiResponse<Rule> response = PutAlertingRulesRuleIdWithHttpInfo(ruleId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param> 
        /// <param name="body">Rule</param> 
        /// <returns>ApiResponse of Rule</returns>
        public ApiResponse< Rule > PutAlertingRulesRuleIdWithHttpInfo (string ruleId, Rule body = null)
        {
            
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AnalyticsApi->PutAlertingRulesRuleId");
            
    
            var path_ = "/api/v1/analytics/alerting/rules/{ruleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (ruleId != null) pathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutAlertingRulesRuleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutAlertingRulesRuleId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Rule> PutAlertingRulesRuleIdAsync (string ruleId, Rule body = null)
        {
             ApiResponse<Rule> response = await PutAlertingRulesRuleIdAsyncWithHttpInfo(ruleId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">Rule</param>
        /// <returns>Task of ApiResponse (Rule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Rule>> PutAlertingRulesRuleIdAsyncWithHttpInfo (string ruleId, Rule body = null)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling PutAlertingRulesRuleId");
            
    
            var path_ = "/api/v1/analytics/alerting/rules/{ruleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutAlertingRulesRuleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutAlertingRulesRuleId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Rule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rule) Configuration.ApiClient.Deserialize(response, typeof(Rule)));
            
        }
        
        /// <summary>
        /// Delete an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param> 
        /// <returns></returns>
        public void DeleteAlertingRulesRuleId (string ruleId)
        {
             DeleteAlertingRulesRuleIdWithHttpInfo(ruleId);
        }

        /// <summary>
        /// Delete an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteAlertingRulesRuleIdWithHttpInfo (string ruleId)
        {
            
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AnalyticsApi->DeleteAlertingRulesRuleId");
            
    
            var path_ = "/api/v1/analytics/alerting/rules/{ruleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteAlertingRulesRuleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteAlertingRulesRuleId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAlertingRulesRuleIdAsync (string ruleId)
        {
             await DeleteAlertingRulesRuleIdAsyncWithHttpInfo(ruleId);

        }

        /// <summary>
        /// Delete an alerting rule. 
        /// </summary>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAlertingRulesRuleIdAsyncWithHttpInfo (string ruleId)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling DeleteAlertingRulesRuleId");
            
    
            var path_ = "/api/v1/analytics/alerting/rules/{ruleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteAlertingRulesRuleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteAlertingRulesRuleId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Executes a metrics query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param> 
        /// <returns></returns>
        public void PostMetricsQuery (Body body = null)
        {
             PostMetricsQueryWithHttpInfo(body);
        }

        /// <summary>
        /// Executes a metrics query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostMetricsQueryWithHttpInfo (Body body = null)
        {
            
    
            var path_ = "/api/v1/analytics/metrics/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostMetricsQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostMetricsQuery: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Executes a metrics query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostMetricsQueryAsync (Body body = null)
        {
             await PostMetricsQueryAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Executes a metrics query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostMetricsQueryAsyncWithHttpInfo (Body body = null)
        {
            
    
            var path_ = "/api/v1/analytics/metrics/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostMetricsQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostMetricsQuery: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public ReportMetaDataEntityListing GetReportingMetadata (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {
             ApiResponse<ReportMetaDataEntityListing> response = GetReportingMetadataWithHttpInfo(pageNumber, pageSize, acceptLanguage, locale);
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
        public ApiResponse< ReportMetaDataEntityListing > GetReportingMetadataWithHttpInfo (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {
            
    
            var path_ = "/api/v1/analytics/reporting/metadata";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingMetadata: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingMetadata: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ReportMetaDataEntityListing> GetReportingMetadataAsync (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {
             ApiResponse<ReportMetaDataEntityListing> response = await GetReportingMetadataAsyncWithHttpInfo(pageNumber, pageSize, acceptLanguage, locale);
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
        public async System.Threading.Tasks.Task<ApiResponse<ReportMetaDataEntityListing>> GetReportingMetadataAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)
        {
            
    
            var path_ = "/api/v1/analytics/reporting/metadata";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingMetadata: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingMetadata: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportMetaDataEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaDataEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ReportMetaDataEntityListing)));
            
        }
        
        /// <summary>
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetReportingReportformats ()
        {
             ApiResponse<List<string>> response = GetReportingReportformatsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > GetReportingReportformatsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/analytics/reporting/reportformats";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingReportformats: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingReportformats: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
    
        /// <summary>
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> GetReportingReportformatsAsync ()
        {
             ApiResponse<List<string>> response = await GetReportingReportformatsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get a list of report formats Get a list of report formats.
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> GetReportingReportformatsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/analytics/reporting/reportformats";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingReportformats: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingReportformats: " + response.ErrorMessage, response.ErrorMessage);

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
        public ReportScheduleEntityListing GetReportingSchedules (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportScheduleEntityListing> response = GetReportingSchedulesWithHttpInfo(pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Get a list of scheduled report jobs Get a list of scheduled report jobs.
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of ReportScheduleEntityListing</returns>
        public ApiResponse< ReportScheduleEntityListing > GetReportingSchedulesWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/analytics/reporting/schedules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingSchedules: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingSchedules: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ReportScheduleEntityListing> GetReportingSchedulesAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportScheduleEntityListing> response = await GetReportingSchedulesAsyncWithHttpInfo(pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Get a list of scheduled report jobs Get a list of scheduled report jobs.
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (ReportScheduleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportScheduleEntityListing>> GetReportingSchedulesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/analytics/reporting/schedules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingSchedules: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingSchedules: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportScheduleEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportScheduleEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ReportScheduleEntityListing)));
            
        }
        
        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <param name="body">ReportSchedule</param> 
        /// <returns>ReportSchedule</returns>
        public ReportSchedule PostReportingSchedules (ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> response = PostReportingSchedulesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <param name="body">ReportSchedule</param> 
        /// <returns>ApiResponse of ReportSchedule</returns>
        public ApiResponse< ReportSchedule > PostReportingSchedulesWithHttpInfo (ReportSchedule body = null)
        {
            
    
            var path_ = "/api/v1/analytics/reporting/schedules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostReportingSchedules: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostReportingSchedules: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ReportSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(response, typeof(ReportSchedule)));
            
        }
    
        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <param name="body">ReportSchedule</param>
        /// <returns>Task of ReportSchedule</returns>
        public async System.Threading.Tasks.Task<ReportSchedule> PostReportingSchedulesAsync (ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> response = await PostReportingSchedulesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a scheduled report job Create a scheduled report job.
        /// </summary>
        /// <param name="body">ReportSchedule</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> PostReportingSchedulesAsyncWithHttpInfo (ReportSchedule body = null)
        {
            
    
            var path_ = "/api/v1/analytics/reporting/schedules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostReportingSchedules: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostReportingSchedules: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(response, typeof(ReportSchedule)));
            
        }
        
        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ReportSchedule</returns>
        public ReportSchedule GetReportingSchedulesScheduleId (string scheduleId)
        {
             ApiResponse<ReportSchedule> response = GetReportingSchedulesScheduleIdWithHttpInfo(scheduleId);
             return response.Data;
        }

        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of ReportSchedule</returns>
        public ApiResponse< ReportSchedule > GetReportingSchedulesScheduleIdWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->GetReportingSchedulesScheduleId");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ReportSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(response, typeof(ReportSchedule)));
            
        }
    
        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportSchedule</returns>
        public async System.Threading.Tasks.Task<ReportSchedule> GetReportingSchedulesScheduleIdAsync (string scheduleId)
        {
             ApiResponse<ReportSchedule> response = await GetReportingSchedulesScheduleIdAsyncWithHttpInfo(scheduleId);
             return response.Data;

        }

        /// <summary>
        /// Get a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> GetReportingSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling GetReportingSchedulesScheduleId");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleId: " + response.ErrorMessage, response.ErrorMessage);

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
        public ReportSchedule PutReportingSchedulesScheduleId (string scheduleId, ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> response = PutReportingSchedulesScheduleIdWithHttpInfo(scheduleId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <param name="body">ReportSchedule</param> 
        /// <returns>ApiResponse of ReportSchedule</returns>
        public ApiResponse< ReportSchedule > PutReportingSchedulesScheduleIdWithHttpInfo (string scheduleId, ReportSchedule body = null)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->PutReportingSchedulesScheduleId");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutReportingSchedulesScheduleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutReportingSchedulesScheduleId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ReportSchedule> PutReportingSchedulesScheduleIdAsync (string scheduleId, ReportSchedule body = null)
        {
             ApiResponse<ReportSchedule> response = await PutReportingSchedulesScheduleIdAsyncWithHttpInfo(scheduleId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body">ReportSchedule</param>
        /// <returns>Task of ApiResponse (ReportSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportSchedule>> PutReportingSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId, ReportSchedule body = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling PutReportingSchedulesScheduleId");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutReportingSchedulesScheduleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutReportingSchedulesScheduleId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportSchedule) Configuration.ApiClient.Deserialize(response, typeof(ReportSchedule)));
            
        }
        
        /// <summary>
        /// Delete a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>string</returns>
        public string DeleteReportingSchedulesScheduleId (string scheduleId)
        {
             ApiResponse<string> response = DeleteReportingSchedulesScheduleIdWithHttpInfo(scheduleId);
             return response.Data;
        }

        /// <summary>
        /// Delete a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteReportingSchedulesScheduleIdWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->DeleteReportingSchedulesScheduleId");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteReportingSchedulesScheduleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteReportingSchedulesScheduleId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteReportingSchedulesScheduleIdAsync (string scheduleId)
        {
             ApiResponse<string> response = await DeleteReportingSchedulesScheduleIdAsyncWithHttpInfo(scheduleId);
             return response.Data;

        }

        /// <summary>
        /// Delete a scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteReportingSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling DeleteReportingSchedulesScheduleId");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteReportingSchedulesScheduleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteReportingSchedulesScheduleId: " + response.ErrorMessage, response.ErrorMessage);

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
        public ReportRunEntryEntityDomainListing GetReportingSchedulesScheduleIdHistory (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportRunEntryEntityDomainListing> response = GetReportingSchedulesScheduleIdHistoryWithHttpInfo(scheduleId, pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Get list of completed scheduled report jobs. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <param name="pageNumber"></param> 
        /// <param name="pageSize"></param> 
        /// <returns>ApiResponse of ReportRunEntryEntityDomainListing</returns>
        public ApiResponse< ReportRunEntryEntityDomainListing > GetReportingSchedulesScheduleIdHistoryWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->GetReportingSchedulesScheduleIdHistory");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/history";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleIdHistory: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleIdHistory: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ReportRunEntryEntityDomainListing> GetReportingSchedulesScheduleIdHistoryAsync (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ReportRunEntryEntityDomainListing> response = await GetReportingSchedulesScheduleIdHistoryAsyncWithHttpInfo(scheduleId, pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Get list of completed scheduled report jobs. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns>Task of ApiResponse (ReportRunEntryEntityDomainListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportRunEntryEntityDomainListing>> GetReportingSchedulesScheduleIdHistoryAsyncWithHttpInfo (string scheduleId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling GetReportingSchedulesScheduleIdHistory");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/history";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleIdHistory: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleIdHistory: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportRunEntryEntityDomainListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntryEntityDomainListing) Configuration.ApiClient.Deserialize(response, typeof(ReportRunEntryEntityDomainListing)));
            
        }
        
        /// <summary>
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ReportRunEntry</returns>
        public ReportRunEntry GetReportingSchedulesScheduleIdHistoryLatest (string scheduleId)
        {
             ApiResponse<ReportRunEntry> response = GetReportingSchedulesScheduleIdHistoryLatestWithHttpInfo(scheduleId);
             return response.Data;
        }

        /// <summary>
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of ReportRunEntry</returns>
        public ApiResponse< ReportRunEntry > GetReportingSchedulesScheduleIdHistoryLatestWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->GetReportingSchedulesScheduleIdHistoryLatest");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/history/latest";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleIdHistoryLatest: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleIdHistoryLatest: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ReportRunEntry>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(response, typeof(ReportRunEntry)));
            
        }
    
        /// <summary>
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ReportRunEntry</returns>
        public async System.Threading.Tasks.Task<ReportRunEntry> GetReportingSchedulesScheduleIdHistoryLatestAsync (string scheduleId)
        {
             ApiResponse<ReportRunEntry> response = await GetReportingSchedulesScheduleIdHistoryLatestAsyncWithHttpInfo(scheduleId);
             return response.Data;

        }

        /// <summary>
        /// Get most recently completed scheduled report job. 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> GetReportingSchedulesScheduleIdHistoryLatestAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling GetReportingSchedulesScheduleIdHistoryLatest");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/history/latest";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleIdHistoryLatest: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleIdHistoryLatest: " + response.ErrorMessage, response.ErrorMessage);

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
        public ReportRunEntry GetReportingSchedulesScheduleIdHistoryRunId (string runId, string scheduleId)
        {
             ApiResponse<ReportRunEntry> response = GetReportingSchedulesScheduleIdHistoryRunIdWithHttpInfo(runId, scheduleId);
             return response.Data;
        }

        /// <summary>
        /// A completed scheduled report job A completed scheduled report job.
        /// </summary>
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
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/history/{runId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleIdHistoryRunId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleIdHistoryRunId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ReportRunEntry> GetReportingSchedulesScheduleIdHistoryRunIdAsync (string runId, string scheduleId)
        {
             ApiResponse<ReportRunEntry> response = await GetReportingSchedulesScheduleIdHistoryRunIdAsyncWithHttpInfo(runId, scheduleId);
             return response.Data;

        }

        /// <summary>
        /// A completed scheduled report job A completed scheduled report job.
        /// </summary>
        /// <param name="runId">Run ID</param>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (ReportRunEntry)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportRunEntry>> GetReportingSchedulesScheduleIdHistoryRunIdAsyncWithHttpInfo (string runId, string scheduleId)
        {
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling GetReportingSchedulesScheduleIdHistoryRunId");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling GetReportingSchedulesScheduleIdHistoryRunId");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/history/{runId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleIdHistoryRunId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingSchedulesScheduleIdHistoryRunId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportRunEntry>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportRunEntry) Configuration.ApiClient.Deserialize(response, typeof(ReportRunEntry)));
            
        }
        
        /// <summary>
        /// Place a scheduled report immediately into the reporting queue 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>RunNowResponse</returns>
        public RunNowResponse PostReportingSchedulesScheduleIdRunreport (string scheduleId)
        {
             ApiResponse<RunNowResponse> response = PostReportingSchedulesScheduleIdRunreportWithHttpInfo(scheduleId);
             return response.Data;
        }

        /// <summary>
        /// Place a scheduled report immediately into the reporting queue 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of RunNowResponse</returns>
        public ApiResponse< RunNowResponse > PostReportingSchedulesScheduleIdRunreportWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AnalyticsApi->PostReportingSchedulesScheduleIdRunreport");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/runreport";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostReportingSchedulesScheduleIdRunreport: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostReportingSchedulesScheduleIdRunreport: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<RunNowResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RunNowResponse) Configuration.ApiClient.Deserialize(response, typeof(RunNowResponse)));
            
        }
    
        /// <summary>
        /// Place a scheduled report immediately into the reporting queue 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of RunNowResponse</returns>
        public async System.Threading.Tasks.Task<RunNowResponse> PostReportingSchedulesScheduleIdRunreportAsync (string scheduleId)
        {
             ApiResponse<RunNowResponse> response = await PostReportingSchedulesScheduleIdRunreportAsyncWithHttpInfo(scheduleId);
             return response.Data;

        }

        /// <summary>
        /// Place a scheduled report immediately into the reporting queue 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (RunNowResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RunNowResponse>> PostReportingSchedulesScheduleIdRunreportAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling PostReportingSchedulesScheduleIdRunreport");
            
    
            var path_ = "/api/v1/analytics/reporting/schedules/{scheduleId}/runreport";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostReportingSchedulesScheduleIdRunreport: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostReportingSchedulesScheduleIdRunreport: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RunNowResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RunNowResponse) Configuration.ApiClient.Deserialize(response, typeof(RunNowResponse)));
            
        }
        
        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetReportingTimeperiods ()
        {
             ApiResponse<List<string>> response = GetReportingTimeperiodsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > GetReportingTimeperiodsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/analytics/reporting/timeperiods";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingTimeperiods: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingTimeperiods: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
    
        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> GetReportingTimeperiodsAsync ()
        {
             ApiResponse<List<string>> response = await GetReportingTimeperiodsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get a list of report time periods. 
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> GetReportingTimeperiodsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/analytics/reporting/timeperiods";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingTimeperiods: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingTimeperiods: " + response.ErrorMessage, response.ErrorMessage);

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
        public ReportMetaData GetReportingReportIdMetadata (string reportId, string acceptLanguage = null, string locale = null)
        {
             ApiResponse<ReportMetaData> response = GetReportingReportIdMetadataWithHttpInfo(reportId, acceptLanguage, locale);
             return response.Data;
        }

        /// <summary>
        /// Get a reporting metadata. 
        /// </summary>
        /// <param name="reportId">Report ID</param> 
        /// <param name="acceptLanguage">Accepted language</param> 
        /// <param name="locale">Locale</param> 
        /// <returns>ApiResponse of ReportMetaData</returns>
        public ApiResponse< ReportMetaData > GetReportingReportIdMetadataWithHttpInfo (string reportId, string acceptLanguage = null, string locale = null)
        {
            
            // verify the required parameter 'reportId' is set
            if (reportId == null)
                throw new ApiException(400, "Missing required parameter 'reportId' when calling AnalyticsApi->GetReportingReportIdMetadata");
            
    
            var path_ = "/api/v1/analytics/reporting/{reportId}/metadata";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingReportIdMetadata: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingReportIdMetadata: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ReportMetaData> GetReportingReportIdMetadataAsync (string reportId, string acceptLanguage = null, string locale = null)
        {
             ApiResponse<ReportMetaData> response = await GetReportingReportIdMetadataAsyncWithHttpInfo(reportId, acceptLanguage, locale);
             return response.Data;

        }

        /// <summary>
        /// Get a reporting metadata. 
        /// </summary>
        /// <param name="reportId">Report ID</param>
        /// <param name="acceptLanguage">Accepted language</param>
        /// <param name="locale">Locale</param>
        /// <returns>Task of ApiResponse (ReportMetaData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportMetaData>> GetReportingReportIdMetadataAsyncWithHttpInfo (string reportId, string acceptLanguage = null, string locale = null)
        {
            // verify the required parameter 'reportId' is set
            if (reportId == null) throw new ApiException(400, "Missing required parameter 'reportId' when calling GetReportingReportIdMetadata");
            
    
            var path_ = "/api/v1/analytics/reporting/{reportId}/metadata";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetReportingReportIdMetadata: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetReportingReportIdMetadata: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReportMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportMetaData) Configuration.ApiClient.Deserialize(response, typeof(ReportMetaData)));
            
        }
        
        /// <summary>
        /// Executes a segments query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param> 
        /// <returns></returns>
        public void PostSegmentsQuery (Body1 body = null)
        {
             PostSegmentsQueryWithHttpInfo(body);
        }

        /// <summary>
        /// Executes a segments query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostSegmentsQueryWithHttpInfo (Body1 body = null)
        {
            
    
            var path_ = "/api/v1/analytics/segments/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostSegmentsQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSegmentsQuery: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Executes a segments query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostSegmentsQueryAsync (Body1 body = null)
        {
             await PostSegmentsQueryAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Executes a segments query against the analytics service 
        /// </summary>
        /// <param name="body">queryObject</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostSegmentsQueryAsyncWithHttpInfo (Body1 body = null)
        {
            
    
            var path_ = "/api/v1/analytics/segments/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostSegmentsQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSegmentsQuery: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
