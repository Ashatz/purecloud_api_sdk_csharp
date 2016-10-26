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
    public interface IWorkforceManagementApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns></returns>
        void DeleteLongtermforecastsForecastId (string forecastId);

        /// <summary>
        /// Delete a forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLongtermforecastsForecastIdWithHttpInfo (string forecastId);
        /// <summary>
        /// Delete a forecast modification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="forecastModificationId">The forecast Modification id</param>
        /// <returns></returns>
        void DeleteLongtermforecastsForecastIdModificationsForecastmodificationId (string forecastId, string forecastModificationId);

        /// <summary>
        /// Delete a forecast modification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="forecastModificationId">The forecast Modification id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLongtermforecastsForecastIdModificationsForecastmodificationIdWithHttpInfo (string forecastId, string forecastModificationId);
        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Max of 100 userIds per request</param>
        /// <returns>UserScheduleAdherence</returns>
        UserScheduleAdherence GetAdherence (List<string> userId);

        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Max of 100 userIds per request</param>
        /// <returns>ApiResponse of UserScheduleAdherence</returns>
        ApiResponse<UserScheduleAdherence> GetAdherenceWithHttpInfo (List<string> userId);
        /// <summary>
        /// Get forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>Forecast</returns>
        Forecast GetLongtermforecastsForecastId (string forecastId);

        /// <summary>
        /// Get forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>ApiResponse of Forecast</returns>
        ApiResponse<Forecast> GetLongtermforecastsForecastIdWithHttpInfo (string forecastId);
        /// <summary>
        /// Get forecast Modifications
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>List&lt;ForecastModification&gt;</returns>
        List<ForecastModification> GetLongtermforecastsForecastIdModifications (string forecastId);

        /// <summary>
        /// Get forecast Modifications
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>ApiResponse of List&lt;ForecastModification&gt;</returns>
        ApiResponse<List<ForecastModification>> GetLongtermforecastsForecastIdModificationsWithHttpInfo (string forecastId);
        /// <summary>
        /// Create a forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body</param>
        /// <returns>ForecastCreationCompletion</returns>
        ForecastCreationCompletion PostLongtermforecasts (ForecastCreation body);

        /// <summary>
        /// Create a forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body</param>
        /// <returns>ApiResponse of ForecastCreationCompletion</returns>
        ApiResponse<ForecastCreationCompletion> PostLongtermforecastsWithHttpInfo (ForecastCreation body);
        /// <summary>
        /// Create a forecast modification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>ForecastModificationCreation</returns>
        ForecastModificationCreation PostLongtermforecastsForecastIdModifications (string forecastId, ForecastModificationCreation body);

        /// <summary>
        /// Create a forecast modification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>ApiResponse of ForecastModificationCreation</returns>
        ApiResponse<ForecastModificationCreation> PostLongtermforecastsForecastIdModificationsWithHttpInfo (string forecastId, ForecastModificationCreation body);
        /// <summary>
        /// Search forecasts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ForecastMetadataEntityListing</returns>
        ForecastMetadataEntityListing PostLongtermforecastsSearch (ForecastSearchRequest body);

        /// <summary>
        /// Search forecasts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ForecastMetadataEntityListing</returns>
        ApiResponse<ForecastMetadataEntityListing> PostLongtermforecastsSearchWithHttpInfo (ForecastSearchRequest body);
        /// <summary>
        /// Update a forecast modification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>ForecastModification</returns>
        ForecastModification PutLongtermforecastsForecastIdModifications (string forecastId, ForecastModification body);

        /// <summary>
        /// Update a forecast modification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>ApiResponse of ForecastModification</returns>
        ApiResponse<ForecastModification> PutLongtermforecastsForecastIdModificationsWithHttpInfo (string forecastId, ForecastModification body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete a forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLongtermforecastsForecastIdAsync (string forecastId);

        /// <summary>
        /// Delete a forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLongtermforecastsForecastIdAsyncWithHttpInfo (string forecastId);
        /// <summary>
        /// Delete a forecast modification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="forecastModificationId">The forecast Modification id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLongtermforecastsForecastIdModificationsForecastmodificationIdAsync (string forecastId, string forecastModificationId);

        /// <summary>
        /// Delete a forecast modification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="forecastModificationId">The forecast Modification id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLongtermforecastsForecastIdModificationsForecastmodificationIdAsyncWithHttpInfo (string forecastId, string forecastModificationId);
        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Max of 100 userIds per request</param>
        /// <returns>Task of UserScheduleAdherence</returns>
        System.Threading.Tasks.Task<UserScheduleAdherence> GetAdherenceAsync (List<string> userId);

        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Max of 100 userIds per request</param>
        /// <returns>Task of ApiResponse (UserScheduleAdherence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserScheduleAdherence>> GetAdherenceAsyncWithHttpInfo (List<string> userId);
        /// <summary>
        /// Get forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>Task of Forecast</returns>
        System.Threading.Tasks.Task<Forecast> GetLongtermforecastsForecastIdAsync (string forecastId);

        /// <summary>
        /// Get forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>Task of ApiResponse (Forecast)</returns>
        System.Threading.Tasks.Task<ApiResponse<Forecast>> GetLongtermforecastsForecastIdAsyncWithHttpInfo (string forecastId);
        /// <summary>
        /// Get forecast Modifications
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>Task of List&lt;ForecastModification&gt;</returns>
        System.Threading.Tasks.Task<List<ForecastModification>> GetLongtermforecastsForecastIdModificationsAsync (string forecastId);

        /// <summary>
        /// Get forecast Modifications
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>Task of ApiResponse (List&lt;ForecastModification&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ForecastModification>>> GetLongtermforecastsForecastIdModificationsAsyncWithHttpInfo (string forecastId);
        /// <summary>
        /// Create a forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body</param>
        /// <returns>Task of ForecastCreationCompletion</returns>
        System.Threading.Tasks.Task<ForecastCreationCompletion> PostLongtermforecastsAsync (ForecastCreation body);

        /// <summary>
        /// Create a forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body</param>
        /// <returns>Task of ApiResponse (ForecastCreationCompletion)</returns>
        System.Threading.Tasks.Task<ApiResponse<ForecastCreationCompletion>> PostLongtermforecastsAsyncWithHttpInfo (ForecastCreation body);
        /// <summary>
        /// Create a forecast modification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>Task of ForecastModificationCreation</returns>
        System.Threading.Tasks.Task<ForecastModificationCreation> PostLongtermforecastsForecastIdModificationsAsync (string forecastId, ForecastModificationCreation body);

        /// <summary>
        /// Create a forecast modification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>Task of ApiResponse (ForecastModificationCreation)</returns>
        System.Threading.Tasks.Task<ApiResponse<ForecastModificationCreation>> PostLongtermforecastsForecastIdModificationsAsyncWithHttpInfo (string forecastId, ForecastModificationCreation body);
        /// <summary>
        /// Search forecasts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ForecastMetadataEntityListing</returns>
        System.Threading.Tasks.Task<ForecastMetadataEntityListing> PostLongtermforecastsSearchAsync (ForecastSearchRequest body);

        /// <summary>
        /// Search forecasts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ForecastMetadataEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ForecastMetadataEntityListing>> PostLongtermforecastsSearchAsyncWithHttpInfo (ForecastSearchRequest body);
        /// <summary>
        /// Update a forecast modification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>Task of ForecastModification</returns>
        System.Threading.Tasks.Task<ForecastModification> PutLongtermforecastsForecastIdModificationsAsync (string forecastId, ForecastModification body);

        /// <summary>
        /// Update a forecast modification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>Task of ApiResponse (ForecastModification)</returns>
        System.Threading.Tasks.Task<ApiResponse<ForecastModification>> PutLongtermforecastsForecastIdModificationsAsyncWithHttpInfo (string forecastId, ForecastModification body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WorkforceManagementApi : IWorkforceManagementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkforceManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WorkforceManagementApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkforceManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WorkforceManagementApi(Configuration configuration = null)
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        /// Delete a forecast 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns></returns>
        public void DeleteLongtermforecastsForecastId (string forecastId)
        {
             DeleteLongtermforecastsForecastIdWithHttpInfo(forecastId);
        }

        /// <summary>
        /// Delete a forecast 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLongtermforecastsForecastIdWithHttpInfo (string forecastId)
        {
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->DeleteLongtermforecastsForecastId");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts/{forecastId}";
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
            if (forecastId != null) localVarPathParams.Add("forecastId", Configuration.ApiClient.ParameterToString(forecastId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLongtermforecastsForecastId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLongtermforecastsForecastId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete a forecast 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLongtermforecastsForecastIdAsync (string forecastId)
        {
             await DeleteLongtermforecastsForecastIdAsyncWithHttpInfo(forecastId);

        }

        /// <summary>
        /// Delete a forecast 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLongtermforecastsForecastIdAsyncWithHttpInfo (string forecastId)
        {
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->DeleteLongtermforecastsForecastId");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts/{forecastId}";
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
            if (forecastId != null) localVarPathParams.Add("forecastId", Configuration.ApiClient.ParameterToString(forecastId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLongtermforecastsForecastId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLongtermforecastsForecastId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete a forecast modification 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="forecastModificationId">The forecast Modification id</param>
        /// <returns></returns>
        public void DeleteLongtermforecastsForecastIdModificationsForecastmodificationId (string forecastId, string forecastModificationId)
        {
             DeleteLongtermforecastsForecastIdModificationsForecastmodificationIdWithHttpInfo(forecastId, forecastModificationId);
        }

        /// <summary>
        /// Delete a forecast modification 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="forecastModificationId">The forecast Modification id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLongtermforecastsForecastIdModificationsForecastmodificationIdWithHttpInfo (string forecastId, string forecastModificationId)
        {
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->DeleteLongtermforecastsForecastIdModificationsForecastmodificationId");
            // verify the required parameter 'forecastModificationId' is set
            if (forecastModificationId == null)
                throw new ApiException(400, "Missing required parameter 'forecastModificationId' when calling WorkforceManagementApi->DeleteLongtermforecastsForecastIdModificationsForecastmodificationId");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts/{forecastId}/modifications/{forecastModificationId}";
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
            if (forecastId != null) localVarPathParams.Add("forecastId", Configuration.ApiClient.ParameterToString(forecastId)); // path parameter
            if (forecastModificationId != null) localVarPathParams.Add("forecastModificationId", Configuration.ApiClient.ParameterToString(forecastModificationId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLongtermforecastsForecastIdModificationsForecastmodificationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLongtermforecastsForecastIdModificationsForecastmodificationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete a forecast modification 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="forecastModificationId">The forecast Modification id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLongtermforecastsForecastIdModificationsForecastmodificationIdAsync (string forecastId, string forecastModificationId)
        {
             await DeleteLongtermforecastsForecastIdModificationsForecastmodificationIdAsyncWithHttpInfo(forecastId, forecastModificationId);

        }

        /// <summary>
        /// Delete a forecast modification 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="forecastModificationId">The forecast Modification id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLongtermforecastsForecastIdModificationsForecastmodificationIdAsyncWithHttpInfo (string forecastId, string forecastModificationId)
        {
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->DeleteLongtermforecastsForecastIdModificationsForecastmodificationId");
            // verify the required parameter 'forecastModificationId' is set
            if (forecastModificationId == null)
                throw new ApiException(400, "Missing required parameter 'forecastModificationId' when calling WorkforceManagementApi->DeleteLongtermforecastsForecastIdModificationsForecastmodificationId");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts/{forecastId}/modifications/{forecastModificationId}";
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
            if (forecastId != null) localVarPathParams.Add("forecastId", Configuration.ApiClient.ParameterToString(forecastId)); // path parameter
            if (forecastModificationId != null) localVarPathParams.Add("forecastModificationId", Configuration.ApiClient.ParameterToString(forecastModificationId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLongtermforecastsForecastIdModificationsForecastmodificationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLongtermforecastsForecastIdModificationsForecastmodificationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Max of 100 userIds per request</param>
        /// <returns>UserScheduleAdherence</returns>
        public UserScheduleAdherence GetAdherence (List<string> userId)
        {
             ApiResponse<UserScheduleAdherence> localVarResponse = GetAdherenceWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Max of 100 userIds per request</param>
        /// <returns>ApiResponse of UserScheduleAdherence</returns>
        public ApiResponse< UserScheduleAdherence > GetAdherenceWithHttpInfo (List<string> userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetAdherence");

            var localVarPath = "/api/v2/workforcemanagement/adherence";
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
            if (userId != null) localVarQueryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetAdherence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAdherence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserScheduleAdherence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserScheduleAdherence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserScheduleAdherence)));
            
        }

        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Max of 100 userIds per request</param>
        /// <returns>Task of UserScheduleAdherence</returns>
        public async System.Threading.Tasks.Task<UserScheduleAdherence> GetAdherenceAsync (List<string> userId)
        {
             ApiResponse<UserScheduleAdherence> localVarResponse = await GetAdherenceAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Max of 100 userIds per request</param>
        /// <returns>Task of ApiResponse (UserScheduleAdherence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserScheduleAdherence>> GetAdherenceAsyncWithHttpInfo (List<string> userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetAdherence");

            var localVarPath = "/api/v2/workforcemanagement/adherence";
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
            if (userId != null) localVarQueryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetAdherence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAdherence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserScheduleAdherence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserScheduleAdherence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserScheduleAdherence)));
            
        }

        /// <summary>
        /// Get forecast 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>Forecast</returns>
        public Forecast GetLongtermforecastsForecastId (string forecastId)
        {
             ApiResponse<Forecast> localVarResponse = GetLongtermforecastsForecastIdWithHttpInfo(forecastId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get forecast 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>ApiResponse of Forecast</returns>
        public ApiResponse< Forecast > GetLongtermforecastsForecastIdWithHttpInfo (string forecastId)
        {
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->GetLongtermforecastsForecastId");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts/{forecastId}";
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
            if (forecastId != null) localVarPathParams.Add("forecastId", Configuration.ApiClient.ParameterToString(forecastId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetLongtermforecastsForecastId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLongtermforecastsForecastId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Forecast>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Forecast) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Forecast)));
            
        }

        /// <summary>
        /// Get forecast 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>Task of Forecast</returns>
        public async System.Threading.Tasks.Task<Forecast> GetLongtermforecastsForecastIdAsync (string forecastId)
        {
             ApiResponse<Forecast> localVarResponse = await GetLongtermforecastsForecastIdAsyncWithHttpInfo(forecastId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get forecast 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>Task of ApiResponse (Forecast)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Forecast>> GetLongtermforecastsForecastIdAsyncWithHttpInfo (string forecastId)
        {
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->GetLongtermforecastsForecastId");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts/{forecastId}";
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
            if (forecastId != null) localVarPathParams.Add("forecastId", Configuration.ApiClient.ParameterToString(forecastId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetLongtermforecastsForecastId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLongtermforecastsForecastId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Forecast>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Forecast) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Forecast)));
            
        }

        /// <summary>
        /// Get forecast Modifications 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>List&lt;ForecastModification&gt;</returns>
        public List<ForecastModification> GetLongtermforecastsForecastIdModifications (string forecastId)
        {
             ApiResponse<List<ForecastModification>> localVarResponse = GetLongtermforecastsForecastIdModificationsWithHttpInfo(forecastId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get forecast Modifications 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>ApiResponse of List&lt;ForecastModification&gt;</returns>
        public ApiResponse< List<ForecastModification> > GetLongtermforecastsForecastIdModificationsWithHttpInfo (string forecastId)
        {
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->GetLongtermforecastsForecastIdModifications");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts/{forecastId}/modifications";
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
            if (forecastId != null) localVarPathParams.Add("forecastId", Configuration.ApiClient.ParameterToString(forecastId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetLongtermforecastsForecastIdModifications: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLongtermforecastsForecastIdModifications: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ForecastModification>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ForecastModification>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ForecastModification>)));
            
        }

        /// <summary>
        /// Get forecast Modifications 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>Task of List&lt;ForecastModification&gt;</returns>
        public async System.Threading.Tasks.Task<List<ForecastModification>> GetLongtermforecastsForecastIdModificationsAsync (string forecastId)
        {
             ApiResponse<List<ForecastModification>> localVarResponse = await GetLongtermforecastsForecastIdModificationsAsyncWithHttpInfo(forecastId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get forecast Modifications 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <returns>Task of ApiResponse (List&lt;ForecastModification&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ForecastModification>>> GetLongtermforecastsForecastIdModificationsAsyncWithHttpInfo (string forecastId)
        {
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->GetLongtermforecastsForecastIdModifications");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts/{forecastId}/modifications";
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
            if (forecastId != null) localVarPathParams.Add("forecastId", Configuration.ApiClient.ParameterToString(forecastId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetLongtermforecastsForecastIdModifications: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLongtermforecastsForecastIdModifications: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ForecastModification>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ForecastModification>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ForecastModification>)));
            
        }

        /// <summary>
        /// Create a forecast 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body</param>
        /// <returns>ForecastCreationCompletion</returns>
        public ForecastCreationCompletion PostLongtermforecasts (ForecastCreation body)
        {
             ApiResponse<ForecastCreationCompletion> localVarResponse = PostLongtermforecastsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a forecast 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body</param>
        /// <returns>ApiResponse of ForecastCreationCompletion</returns>
        public ApiResponse< ForecastCreationCompletion > PostLongtermforecastsWithHttpInfo (ForecastCreation body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostLongtermforecasts");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecasts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecasts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ForecastCreationCompletion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ForecastCreationCompletion) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ForecastCreationCompletion)));
            
        }

        /// <summary>
        /// Create a forecast 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body</param>
        /// <returns>Task of ForecastCreationCompletion</returns>
        public async System.Threading.Tasks.Task<ForecastCreationCompletion> PostLongtermforecastsAsync (ForecastCreation body)
        {
             ApiResponse<ForecastCreationCompletion> localVarResponse = await PostLongtermforecastsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a forecast 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body</param>
        /// <returns>Task of ApiResponse (ForecastCreationCompletion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ForecastCreationCompletion>> PostLongtermforecastsAsyncWithHttpInfo (ForecastCreation body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostLongtermforecasts");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecasts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecasts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ForecastCreationCompletion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ForecastCreationCompletion) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ForecastCreationCompletion)));
            
        }

        /// <summary>
        /// Create a forecast modification 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>ForecastModificationCreation</returns>
        public ForecastModificationCreation PostLongtermforecastsForecastIdModifications (string forecastId, ForecastModificationCreation body)
        {
             ApiResponse<ForecastModificationCreation> localVarResponse = PostLongtermforecastsForecastIdModificationsWithHttpInfo(forecastId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a forecast modification 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>ApiResponse of ForecastModificationCreation</returns>
        public ApiResponse< ForecastModificationCreation > PostLongtermforecastsForecastIdModificationsWithHttpInfo (string forecastId, ForecastModificationCreation body)
        {
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->PostLongtermforecastsForecastIdModifications");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostLongtermforecastsForecastIdModifications");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts/{forecastId}/modifications";
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
            if (forecastId != null) localVarPathParams.Add("forecastId", Configuration.ApiClient.ParameterToString(forecastId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecastsForecastIdModifications: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecastsForecastIdModifications: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ForecastModificationCreation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ForecastModificationCreation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ForecastModificationCreation)));
            
        }

        /// <summary>
        /// Create a forecast modification 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>Task of ForecastModificationCreation</returns>
        public async System.Threading.Tasks.Task<ForecastModificationCreation> PostLongtermforecastsForecastIdModificationsAsync (string forecastId, ForecastModificationCreation body)
        {
             ApiResponse<ForecastModificationCreation> localVarResponse = await PostLongtermforecastsForecastIdModificationsAsyncWithHttpInfo(forecastId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a forecast modification 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>Task of ApiResponse (ForecastModificationCreation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ForecastModificationCreation>> PostLongtermforecastsForecastIdModificationsAsyncWithHttpInfo (string forecastId, ForecastModificationCreation body)
        {
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->PostLongtermforecastsForecastIdModifications");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostLongtermforecastsForecastIdModifications");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts/{forecastId}/modifications";
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
            if (forecastId != null) localVarPathParams.Add("forecastId", Configuration.ApiClient.ParameterToString(forecastId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecastsForecastIdModifications: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecastsForecastIdModifications: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ForecastModificationCreation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ForecastModificationCreation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ForecastModificationCreation)));
            
        }

        /// <summary>
        /// Search forecasts 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ForecastMetadataEntityListing</returns>
        public ForecastMetadataEntityListing PostLongtermforecastsSearch (ForecastSearchRequest body)
        {
             ApiResponse<ForecastMetadataEntityListing> localVarResponse = PostLongtermforecastsSearchWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search forecasts 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ForecastMetadataEntityListing</returns>
        public ApiResponse< ForecastMetadataEntityListing > PostLongtermforecastsSearchWithHttpInfo (ForecastSearchRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostLongtermforecastsSearch");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts/search";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecastsSearch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecastsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ForecastMetadataEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ForecastMetadataEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ForecastMetadataEntityListing)));
            
        }

        /// <summary>
        /// Search forecasts 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ForecastMetadataEntityListing</returns>
        public async System.Threading.Tasks.Task<ForecastMetadataEntityListing> PostLongtermforecastsSearchAsync (ForecastSearchRequest body)
        {
             ApiResponse<ForecastMetadataEntityListing> localVarResponse = await PostLongtermforecastsSearchAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search forecasts 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ForecastMetadataEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ForecastMetadataEntityListing>> PostLongtermforecastsSearchAsyncWithHttpInfo (ForecastSearchRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostLongtermforecastsSearch");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts/search";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecastsSearch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecastsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ForecastMetadataEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ForecastMetadataEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ForecastMetadataEntityListing)));
            
        }

        /// <summary>
        /// Update a forecast modification 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>ForecastModification</returns>
        public ForecastModification PutLongtermforecastsForecastIdModifications (string forecastId, ForecastModification body)
        {
             ApiResponse<ForecastModification> localVarResponse = PutLongtermforecastsForecastIdModificationsWithHttpInfo(forecastId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a forecast modification 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>ApiResponse of ForecastModification</returns>
        public ApiResponse< ForecastModification > PutLongtermforecastsForecastIdModificationsWithHttpInfo (string forecastId, ForecastModification body)
        {
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->PutLongtermforecastsForecastIdModifications");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PutLongtermforecastsForecastIdModifications");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts/{forecastId}/modifications";
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
            if (forecastId != null) localVarPathParams.Add("forecastId", Configuration.ApiClient.ParameterToString(forecastId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutLongtermforecastsForecastIdModifications: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutLongtermforecastsForecastIdModifications: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ForecastModification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ForecastModification) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ForecastModification)));
            
        }

        /// <summary>
        /// Update a forecast modification 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>Task of ForecastModification</returns>
        public async System.Threading.Tasks.Task<ForecastModification> PutLongtermforecastsForecastIdModificationsAsync (string forecastId, ForecastModification body)
        {
             ApiResponse<ForecastModification> localVarResponse = await PutLongtermforecastsForecastIdModificationsAsyncWithHttpInfo(forecastId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a forecast modification 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="forecastId">The forecast id</param>
        /// <param name="body">The request body</param>
        /// <returns>Task of ApiResponse (ForecastModification)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ForecastModification>> PutLongtermforecastsForecastIdModificationsAsyncWithHttpInfo (string forecastId, ForecastModification body)
        {
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->PutLongtermforecastsForecastIdModifications");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PutLongtermforecastsForecastIdModifications");

            var localVarPath = "/api/v2/workforcemanagement/longtermforecasts/{forecastId}/modifications";
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
            if (forecastId != null) localVarPathParams.Add("forecastId", Configuration.ApiClient.ParameterToString(forecastId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutLongtermforecastsForecastIdModifications: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutLongtermforecastsForecastIdModifications: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ForecastModification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ForecastModification) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ForecastModification)));
            
        }

    }
}
