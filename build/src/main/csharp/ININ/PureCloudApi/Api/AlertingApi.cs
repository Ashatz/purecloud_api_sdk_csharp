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
    public interface IAlertingApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns></returns>
        void DeleteInteractionstatsAlertsAlertId (string alertId);

        /// <summary>
        /// Delete an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteInteractionstatsAlertsAlertIdWithHttpInfo (string alertId);
        /// <summary>
        /// Delete an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns></returns>
        void DeleteInteractionstatsRulesRuleId (string ruleId);

        /// <summary>
        /// Delete an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteInteractionstatsRulesRuleIdWithHttpInfo (string ruleId);
        /// <summary>
        /// Get interaction stats alert list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InteractionStatsAlertContainer</returns>
        InteractionStatsAlertContainer GetInteractionstatsAlerts ();

        /// <summary>
        /// Get interaction stats alert list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InteractionStatsAlertContainer</returns>
        ApiResponse<InteractionStatsAlertContainer> GetInteractionstatsAlertsWithHttpInfo ();
        /// <summary>
        /// Get an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>InteractionStatsAlert</returns>
        InteractionStatsAlert GetInteractionstatsAlertsAlertId (string alertId);

        /// <summary>
        /// Get an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of InteractionStatsAlert</returns>
        ApiResponse<InteractionStatsAlert> GetInteractionstatsAlertsAlertIdWithHttpInfo (string alertId);
        /// <summary>
        /// Gets user unread count of interaction stats alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UnreadMetric</returns>
        UnreadMetric GetInteractionstatsAlertsUnread ();

        /// <summary>
        /// Gets user unread count of interaction stats alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UnreadMetric</returns>
        ApiResponse<UnreadMetric> GetInteractionstatsAlertsUnreadWithHttpInfo ();
        /// <summary>
        /// Get an interaction stats rule list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InteractionStatsRuleContainer</returns>
        InteractionStatsRuleContainer GetInteractionstatsRules ();

        /// <summary>
        /// Get an interaction stats rule list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InteractionStatsRuleContainer</returns>
        ApiResponse<InteractionStatsRuleContainer> GetInteractionstatsRulesWithHttpInfo ();
        /// <summary>
        /// Get an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>InteractionStatsRule</returns>
        InteractionStatsRule GetInteractionstatsRulesRuleId (string ruleId);

        /// <summary>
        /// Get an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of InteractionStatsRule</returns>
        ApiResponse<InteractionStatsRule> GetInteractionstatsRulesRuleIdWithHttpInfo (string ruleId);
        /// <summary>
        /// Create an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>InteractionStatsRule</returns>
        InteractionStatsRule PostInteractionstatsRules (InteractionStatsRule body = null);

        /// <summary>
        /// Create an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>ApiResponse of InteractionStatsRule</returns>
        ApiResponse<InteractionStatsRule> PostInteractionstatsRulesWithHttpInfo (InteractionStatsRule body = null);
        /// <summary>
        /// Update an interaction stats alert read status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert (optional)</param>
        /// <returns>UnreadStatus</returns>
        UnreadStatus PutInteractionstatsAlertsAlertId (string alertId, UnreadStatus body = null);

        /// <summary>
        /// Update an interaction stats alert read status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert (optional)</param>
        /// <returns>ApiResponse of UnreadStatus</returns>
        ApiResponse<UnreadStatus> PutInteractionstatsAlertsAlertIdWithHttpInfo (string alertId, UnreadStatus body = null);
        /// <summary>
        /// Update an interaction stats rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>InteractionStatsRule</returns>
        InteractionStatsRule PutInteractionstatsRulesRuleId (string ruleId, InteractionStatsRule body = null);

        /// <summary>
        /// Update an interaction stats rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>ApiResponse of InteractionStatsRule</returns>
        ApiResponse<InteractionStatsRule> PutInteractionstatsRulesRuleIdWithHttpInfo (string ruleId, InteractionStatsRule body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteInteractionstatsAlertsAlertIdAsync (string alertId);

        /// <summary>
        /// Delete an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInteractionstatsAlertsAlertIdAsyncWithHttpInfo (string alertId);
        /// <summary>
        /// Delete an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteInteractionstatsRulesRuleIdAsync (string ruleId);

        /// <summary>
        /// Delete an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInteractionstatsRulesRuleIdAsyncWithHttpInfo (string ruleId);
        /// <summary>
        /// Get interaction stats alert list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InteractionStatsAlertContainer</returns>
        System.Threading.Tasks.Task<InteractionStatsAlertContainer> GetInteractionstatsAlertsAsync ();

        /// <summary>
        /// Get interaction stats alert list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InteractionStatsAlertContainer)</returns>
        System.Threading.Tasks.Task<ApiResponse<InteractionStatsAlertContainer>> GetInteractionstatsAlertsAsyncWithHttpInfo ();
        /// <summary>
        /// Get an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of InteractionStatsAlert</returns>
        System.Threading.Tasks.Task<InteractionStatsAlert> GetInteractionstatsAlertsAlertIdAsync (string alertId);

        /// <summary>
        /// Get an interaction stats alert
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse (InteractionStatsAlert)</returns>
        System.Threading.Tasks.Task<ApiResponse<InteractionStatsAlert>> GetInteractionstatsAlertsAlertIdAsyncWithHttpInfo (string alertId);
        /// <summary>
        /// Gets user unread count of interaction stats alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UnreadMetric</returns>
        System.Threading.Tasks.Task<UnreadMetric> GetInteractionstatsAlertsUnreadAsync ();

        /// <summary>
        /// Gets user unread count of interaction stats alerts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UnreadMetric)</returns>
        System.Threading.Tasks.Task<ApiResponse<UnreadMetric>> GetInteractionstatsAlertsUnreadAsyncWithHttpInfo ();
        /// <summary>
        /// Get an interaction stats rule list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InteractionStatsRuleContainer</returns>
        System.Threading.Tasks.Task<InteractionStatsRuleContainer> GetInteractionstatsRulesAsync ();

        /// <summary>
        /// Get an interaction stats rule list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InteractionStatsRuleContainer)</returns>
        System.Threading.Tasks.Task<ApiResponse<InteractionStatsRuleContainer>> GetInteractionstatsRulesAsyncWithHttpInfo ();
        /// <summary>
        /// Get an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of InteractionStatsRule</returns>
        System.Threading.Tasks.Task<InteractionStatsRule> GetInteractionstatsRulesRuleIdAsync (string ruleId);

        /// <summary>
        /// Get an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse (InteractionStatsRule)</returns>
        System.Threading.Tasks.Task<ApiResponse<InteractionStatsRule>> GetInteractionstatsRulesRuleIdAsyncWithHttpInfo (string ruleId);
        /// <summary>
        /// Create an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>Task of InteractionStatsRule</returns>
        System.Threading.Tasks.Task<InteractionStatsRule> PostInteractionstatsRulesAsync (InteractionStatsRule body = null);

        /// <summary>
        /// Create an interaction stats rule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsRule)</returns>
        System.Threading.Tasks.Task<ApiResponse<InteractionStatsRule>> PostInteractionstatsRulesAsyncWithHttpInfo (InteractionStatsRule body = null);
        /// <summary>
        /// Update an interaction stats alert read status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert (optional)</param>
        /// <returns>Task of UnreadStatus</returns>
        System.Threading.Tasks.Task<UnreadStatus> PutInteractionstatsAlertsAlertIdAsync (string alertId, UnreadStatus body = null);

        /// <summary>
        /// Update an interaction stats alert read status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert (optional)</param>
        /// <returns>Task of ApiResponse (UnreadStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<UnreadStatus>> PutInteractionstatsAlertsAlertIdAsyncWithHttpInfo (string alertId, UnreadStatus body = null);
        /// <summary>
        /// Update an interaction stats rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>Task of InteractionStatsRule</returns>
        System.Threading.Tasks.Task<InteractionStatsRule> PutInteractionstatsRulesRuleIdAsync (string ruleId, InteractionStatsRule body = null);

        /// <summary>
        /// Update an interaction stats rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsRule)</returns>
        System.Threading.Tasks.Task<ApiResponse<InteractionStatsRule>> PutInteractionstatsRulesRuleIdAsyncWithHttpInfo (string ruleId, InteractionStatsRule body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AlertingApi : IAlertingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlertingApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlertingApi(Configuration configuration = null)
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
        /// Delete an interaction stats alert 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns></returns>
        public void DeleteInteractionstatsAlertsAlertId (string alertId)
        {
             DeleteInteractionstatsAlertsAlertIdWithHttpInfo(alertId);
        }

        /// <summary>
        /// Delete an interaction stats alert 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteInteractionstatsAlertsAlertIdWithHttpInfo (string alertId)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->DeleteInteractionstatsAlertsAlertId");

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/{alertId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInteractionstatsAlertsAlertId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInteractionstatsAlertsAlertId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete an interaction stats alert 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteInteractionstatsAlertsAlertIdAsync (string alertId)
        {
             await DeleteInteractionstatsAlertsAlertIdAsyncWithHttpInfo(alertId);

        }

        /// <summary>
        /// Delete an interaction stats alert 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInteractionstatsAlertsAlertIdAsyncWithHttpInfo (string alertId)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->DeleteInteractionstatsAlertsAlertId");

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/{alertId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInteractionstatsAlertsAlertId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInteractionstatsAlertsAlertId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete an interaction stats rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns></returns>
        public void DeleteInteractionstatsRulesRuleId (string ruleId)
        {
             DeleteInteractionstatsRulesRuleIdWithHttpInfo(ruleId);
        }

        /// <summary>
        /// Delete an interaction stats rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteInteractionstatsRulesRuleIdWithHttpInfo (string ruleId)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->DeleteInteractionstatsRulesRuleId");

            var localVarPath = "/api/v2/alerting/interactionstats/rules/{ruleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInteractionstatsRulesRuleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInteractionstatsRulesRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete an interaction stats rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteInteractionstatsRulesRuleIdAsync (string ruleId)
        {
             await DeleteInteractionstatsRulesRuleIdAsyncWithHttpInfo(ruleId);

        }

        /// <summary>
        /// Delete an interaction stats rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInteractionstatsRulesRuleIdAsyncWithHttpInfo (string ruleId)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->DeleteInteractionstatsRulesRuleId");

            var localVarPath = "/api/v2/alerting/interactionstats/rules/{ruleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInteractionstatsRulesRuleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInteractionstatsRulesRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get interaction stats alert list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InteractionStatsAlertContainer</returns>
        public InteractionStatsAlertContainer GetInteractionstatsAlerts ()
        {
             ApiResponse<InteractionStatsAlertContainer> localVarResponse = GetInteractionstatsAlertsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get interaction stats alert list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InteractionStatsAlertContainer</returns>
        public ApiResponse< InteractionStatsAlertContainer > GetInteractionstatsAlertsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/alerting/interactionstats/alerts";
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
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsAlerts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsAlerts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsAlertContainer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InteractionStatsAlertContainer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsAlertContainer)));
            
        }

        /// <summary>
        /// Get interaction stats alert list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InteractionStatsAlertContainer</returns>
        public async System.Threading.Tasks.Task<InteractionStatsAlertContainer> GetInteractionstatsAlertsAsync ()
        {
             ApiResponse<InteractionStatsAlertContainer> localVarResponse = await GetInteractionstatsAlertsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get interaction stats alert list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InteractionStatsAlertContainer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InteractionStatsAlertContainer>> GetInteractionstatsAlertsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/alerting/interactionstats/alerts";
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
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsAlerts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsAlerts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsAlertContainer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InteractionStatsAlertContainer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsAlertContainer)));
            
        }

        /// <summary>
        /// Get an interaction stats alert 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>InteractionStatsAlert</returns>
        public InteractionStatsAlert GetInteractionstatsAlertsAlertId (string alertId)
        {
             ApiResponse<InteractionStatsAlert> localVarResponse = GetInteractionstatsAlertsAlertIdWithHttpInfo(alertId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an interaction stats alert 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>ApiResponse of InteractionStatsAlert</returns>
        public ApiResponse< InteractionStatsAlert > GetInteractionstatsAlertsAlertIdWithHttpInfo (string alertId)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->GetInteractionstatsAlertsAlertId");

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/{alertId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsAlertsAlertId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsAlertsAlertId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsAlert>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InteractionStatsAlert) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsAlert)));
            
        }

        /// <summary>
        /// Get an interaction stats alert 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of InteractionStatsAlert</returns>
        public async System.Threading.Tasks.Task<InteractionStatsAlert> GetInteractionstatsAlertsAlertIdAsync (string alertId)
        {
             ApiResponse<InteractionStatsAlert> localVarResponse = await GetInteractionstatsAlertsAlertIdAsyncWithHttpInfo(alertId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an interaction stats alert 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <returns>Task of ApiResponse (InteractionStatsAlert)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InteractionStatsAlert>> GetInteractionstatsAlertsAlertIdAsyncWithHttpInfo (string alertId)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->GetInteractionstatsAlertsAlertId");

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/{alertId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsAlertsAlertId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsAlertsAlertId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsAlert>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InteractionStatsAlert) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsAlert)));
            
        }

        /// <summary>
        /// Gets user unread count of interaction stats alerts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UnreadMetric</returns>
        public UnreadMetric GetInteractionstatsAlertsUnread ()
        {
             ApiResponse<UnreadMetric> localVarResponse = GetInteractionstatsAlertsUnreadWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets user unread count of interaction stats alerts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UnreadMetric</returns>
        public ApiResponse< UnreadMetric > GetInteractionstatsAlertsUnreadWithHttpInfo ()
        {

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/unread";
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
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsAlertsUnread: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsAlertsUnread: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnreadMetric>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnreadMetric) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnreadMetric)));
            
        }

        /// <summary>
        /// Gets user unread count of interaction stats alerts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UnreadMetric</returns>
        public async System.Threading.Tasks.Task<UnreadMetric> GetInteractionstatsAlertsUnreadAsync ()
        {
             ApiResponse<UnreadMetric> localVarResponse = await GetInteractionstatsAlertsUnreadAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets user unread count of interaction stats alerts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UnreadMetric)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UnreadMetric>> GetInteractionstatsAlertsUnreadAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/unread";
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
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsAlertsUnread: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsAlertsUnread: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnreadMetric>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnreadMetric) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnreadMetric)));
            
        }

        /// <summary>
        /// Get an interaction stats rule list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InteractionStatsRuleContainer</returns>
        public InteractionStatsRuleContainer GetInteractionstatsRules ()
        {
             ApiResponse<InteractionStatsRuleContainer> localVarResponse = GetInteractionstatsRulesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an interaction stats rule list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InteractionStatsRuleContainer</returns>
        public ApiResponse< InteractionStatsRuleContainer > GetInteractionstatsRulesWithHttpInfo ()
        {

            var localVarPath = "/api/v2/alerting/interactionstats/rules";
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
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsRules: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRuleContainer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InteractionStatsRuleContainer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRuleContainer)));
            
        }

        /// <summary>
        /// Get an interaction stats rule list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InteractionStatsRuleContainer</returns>
        public async System.Threading.Tasks.Task<InteractionStatsRuleContainer> GetInteractionstatsRulesAsync ()
        {
             ApiResponse<InteractionStatsRuleContainer> localVarResponse = await GetInteractionstatsRulesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an interaction stats rule list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InteractionStatsRuleContainer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InteractionStatsRuleContainer>> GetInteractionstatsRulesAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/alerting/interactionstats/rules";
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
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsRules: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRuleContainer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InteractionStatsRuleContainer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRuleContainer)));
            
        }

        /// <summary>
        /// Get an interaction stats rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>InteractionStatsRule</returns>
        public InteractionStatsRule GetInteractionstatsRulesRuleId (string ruleId)
        {
             ApiResponse<InteractionStatsRule> localVarResponse = GetInteractionstatsRulesRuleIdWithHttpInfo(ruleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an interaction stats rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>ApiResponse of InteractionStatsRule</returns>
        public ApiResponse< InteractionStatsRule > GetInteractionstatsRulesRuleIdWithHttpInfo (string ruleId)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->GetInteractionstatsRulesRuleId");

            var localVarPath = "/api/v2/alerting/interactionstats/rules/{ruleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsRulesRuleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsRulesRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InteractionStatsRule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRule)));
            
        }

        /// <summary>
        /// Get an interaction stats rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of InteractionStatsRule</returns>
        public async System.Threading.Tasks.Task<InteractionStatsRule> GetInteractionstatsRulesRuleIdAsync (string ruleId)
        {
             ApiResponse<InteractionStatsRule> localVarResponse = await GetInteractionstatsRulesRuleIdAsyncWithHttpInfo(ruleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an interaction stats rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <returns>Task of ApiResponse (InteractionStatsRule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InteractionStatsRule>> GetInteractionstatsRulesRuleIdAsyncWithHttpInfo (string ruleId)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->GetInteractionstatsRulesRuleId");

            var localVarPath = "/api/v2/alerting/interactionstats/rules/{ruleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsRulesRuleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInteractionstatsRulesRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InteractionStatsRule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRule)));
            
        }

        /// <summary>
        /// Create an interaction stats rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>InteractionStatsRule</returns>
        public InteractionStatsRule PostInteractionstatsRules (InteractionStatsRule body = null)
        {
             ApiResponse<InteractionStatsRule> localVarResponse = PostInteractionstatsRulesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an interaction stats rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>ApiResponse of InteractionStatsRule</returns>
        public ApiResponse< InteractionStatsRule > PostInteractionstatsRulesWithHttpInfo (InteractionStatsRule body = null)
        {

            var localVarPath = "/api/v2/alerting/interactionstats/rules";
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
                throw new ApiException (localVarStatusCode, "Error calling PostInteractionstatsRules: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostInteractionstatsRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InteractionStatsRule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRule)));
            
        }

        /// <summary>
        /// Create an interaction stats rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>Task of InteractionStatsRule</returns>
        public async System.Threading.Tasks.Task<InteractionStatsRule> PostInteractionstatsRulesAsync (InteractionStatsRule body = null)
        {
             ApiResponse<InteractionStatsRule> localVarResponse = await PostInteractionstatsRulesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an interaction stats rule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsRule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InteractionStatsRule>> PostInteractionstatsRulesAsyncWithHttpInfo (InteractionStatsRule body = null)
        {

            var localVarPath = "/api/v2/alerting/interactionstats/rules";
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
                throw new ApiException (localVarStatusCode, "Error calling PostInteractionstatsRules: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostInteractionstatsRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InteractionStatsRule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRule)));
            
        }

        /// <summary>
        /// Update an interaction stats alert read status 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert (optional)</param>
        /// <returns>UnreadStatus</returns>
        public UnreadStatus PutInteractionstatsAlertsAlertId (string alertId, UnreadStatus body = null)
        {
             ApiResponse<UnreadStatus> localVarResponse = PutInteractionstatsAlertsAlertIdWithHttpInfo(alertId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an interaction stats alert read status 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert (optional)</param>
        /// <returns>ApiResponse of UnreadStatus</returns>
        public ApiResponse< UnreadStatus > PutInteractionstatsAlertsAlertIdWithHttpInfo (string alertId, UnreadStatus body = null)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->PutInteractionstatsAlertsAlertId");

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/{alertId}";
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
                throw new ApiException (localVarStatusCode, "Error calling PutInteractionstatsAlertsAlertId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutInteractionstatsAlertsAlertId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnreadStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnreadStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnreadStatus)));
            
        }

        /// <summary>
        /// Update an interaction stats alert read status 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert (optional)</param>
        /// <returns>Task of UnreadStatus</returns>
        public async System.Threading.Tasks.Task<UnreadStatus> PutInteractionstatsAlertsAlertIdAsync (string alertId, UnreadStatus body = null)
        {
             ApiResponse<UnreadStatus> localVarResponse = await PutInteractionstatsAlertsAlertIdAsyncWithHttpInfo(alertId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an interaction stats alert read status 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alertId">Alert ID</param>
        /// <param name="body">InteractionStatsAlert (optional)</param>
        /// <returns>Task of ApiResponse (UnreadStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UnreadStatus>> PutInteractionstatsAlertsAlertIdAsyncWithHttpInfo (string alertId, UnreadStatus body = null)
        {
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling AlertingApi->PutInteractionstatsAlertsAlertId");

            var localVarPath = "/api/v2/alerting/interactionstats/alerts/{alertId}";
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
                throw new ApiException (localVarStatusCode, "Error calling PutInteractionstatsAlertsAlertId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutInteractionstatsAlertsAlertId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnreadStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnreadStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnreadStatus)));
            
        }

        /// <summary>
        /// Update an interaction stats rule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>InteractionStatsRule</returns>
        public InteractionStatsRule PutInteractionstatsRulesRuleId (string ruleId, InteractionStatsRule body = null)
        {
             ApiResponse<InteractionStatsRule> localVarResponse = PutInteractionstatsRulesRuleIdWithHttpInfo(ruleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an interaction stats rule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>ApiResponse of InteractionStatsRule</returns>
        public ApiResponse< InteractionStatsRule > PutInteractionstatsRulesRuleIdWithHttpInfo (string ruleId, InteractionStatsRule body = null)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->PutInteractionstatsRulesRuleId");

            var localVarPath = "/api/v2/alerting/interactionstats/rules/{ruleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling PutInteractionstatsRulesRuleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutInteractionstatsRulesRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InteractionStatsRule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRule)));
            
        }

        /// <summary>
        /// Update an interaction stats rule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>Task of InteractionStatsRule</returns>
        public async System.Threading.Tasks.Task<InteractionStatsRule> PutInteractionstatsRulesRuleIdAsync (string ruleId, InteractionStatsRule body = null)
        {
             ApiResponse<InteractionStatsRule> localVarResponse = await PutInteractionstatsRulesRuleIdAsyncWithHttpInfo(ruleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an interaction stats rule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID</param>
        /// <param name="body">AlertingRule (optional)</param>
        /// <returns>Task of ApiResponse (InteractionStatsRule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InteractionStatsRule>> PutInteractionstatsRulesRuleIdAsyncWithHttpInfo (string ruleId, InteractionStatsRule body = null)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling AlertingApi->PutInteractionstatsRulesRuleId");

            var localVarPath = "/api/v2/alerting/interactionstats/rules/{ruleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling PutInteractionstatsRulesRuleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutInteractionstatsRulesRuleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InteractionStatsRule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InteractionStatsRule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InteractionStatsRule)));
            
        }

    }
}
