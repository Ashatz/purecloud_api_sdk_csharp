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
        /// Get decisions download link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">The decisions file download id</param>
        /// <param name="downloadfilename">The file name used to get the download url (optional, default to downloadfilename)</param>
        /// <returns>DecisionsDownloadLink</returns>
        DecisionsDownloadLink GetDecisionsDownloadsDownloadId (string downloadId, string downloadfilename = null);

        /// <summary>
        /// Get decisions download link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">The decisions file download id</param>
        /// <param name="downloadfilename">The file name used to get the download url (optional, default to downloadfilename)</param>
        /// <returns>ApiResponse of DecisionsDownloadLink</returns>
        ApiResponse<DecisionsDownloadLink> GetDecisionsDownloadsDownloadIdWithHttpInfo (string downloadId, string downloadfilename = null);
        /// <summary>
        /// Get a list of time off requests for any user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>TimeOffRequestList</returns>
        TimeOffRequestList GetManagementunitsMuIdUsersUserIdTimeoffrequests (string muId, string userId, bool? recentlyReviewed = null);

        /// <summary>
        /// Get a list of time off requests for any user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>ApiResponse of TimeOffRequestList</returns>
        ApiResponse<TimeOffRequestList> GetManagementunitsMuIdUsersUserIdTimeoffrequestsWithHttpInfo (string muId, string userId, bool? recentlyReviewed = null);
        /// <summary>
        /// Get a time off request by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>TimeOffRequest</returns>
        TimeOffRequest GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId (string muId, string userId, string timeOffRequestId);

        /// <summary>
        /// Get a time off request by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>ApiResponse of TimeOffRequest</returns>
        ApiResponse<TimeOffRequest> GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestIdWithHttpInfo (string muId, string userId, string timeOffRequestId);
        /// <summary>
        /// Get a list of time off requests for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>TimeOffRequestList</returns>
        TimeOffRequestList GetTimeoffrequests (bool? recentlyReviewed = null);

        /// <summary>
        /// Get a list of time off requests for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>ApiResponse of TimeOffRequestList</returns>
        ApiResponse<TimeOffRequestList> GetTimeoffrequestsWithHttpInfo (bool? recentlyReviewed = null);
        /// <summary>
        /// Get a time off request for the current user by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>TimeOffRequest</returns>
        TimeOffRequest GetTimeoffrequestsTimeoffrequestId (string timeOffRequestId);

        /// <summary>
        /// Get a time off request for the current user by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>ApiResponse of TimeOffRequest</returns>
        ApiResponse<TimeOffRequest> GetTimeoffrequestsTimeoffrequestIdWithHttpInfo (string timeOffRequestId);
        /// <summary>
        /// Mark a time off request for the current user as read or unread
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void PatchTimeoffrequestsTimeoffrequestId (string timeOffRequestId, TimeOffRequestPatch body = null);

        /// <summary>
        /// Mark a time off request for the current user as read or unread
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchTimeoffrequestsTimeoffrequestIdWithHttpInfo (string timeOffRequestId, TimeOffRequestPatch body = null);
        /// <summary>
        /// Download decisions files metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>DecisionsFileMetadataEntityListing</returns>
        DecisionsFileMetadataEntityListing PostDecisionsDownloadsSearch (ForecastSearchRequest body);

        /// <summary>
        /// Download decisions files metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DecisionsFileMetadataEntityListing</returns>
        ApiResponse<DecisionsFileMetadataEntityListing> PostDecisionsDownloadsSearchWithHttpInfo (ForecastSearchRequest body);
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
        #endregion Synchronous Operations
        #region Asynchronous Operations
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
        /// Get decisions download link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">The decisions file download id</param>
        /// <param name="downloadfilename">The file name used to get the download url (optional, default to downloadfilename)</param>
        /// <returns>Task of DecisionsDownloadLink</returns>
        System.Threading.Tasks.Task<DecisionsDownloadLink> GetDecisionsDownloadsDownloadIdAsync (string downloadId, string downloadfilename = null);

        /// <summary>
        /// Get decisions download link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">The decisions file download id</param>
        /// <param name="downloadfilename">The file name used to get the download url (optional, default to downloadfilename)</param>
        /// <returns>Task of ApiResponse (DecisionsDownloadLink)</returns>
        System.Threading.Tasks.Task<ApiResponse<DecisionsDownloadLink>> GetDecisionsDownloadsDownloadIdAsyncWithHttpInfo (string downloadId, string downloadfilename = null);
        /// <summary>
        /// Get a list of time off requests for any user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of TimeOffRequestList</returns>
        System.Threading.Tasks.Task<TimeOffRequestList> GetManagementunitsMuIdUsersUserIdTimeoffrequestsAsync (string muId, string userId, bool? recentlyReviewed = null);

        /// <summary>
        /// Get a list of time off requests for any user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestList)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestList>> GetManagementunitsMuIdUsersUserIdTimeoffrequestsAsyncWithHttpInfo (string muId, string userId, bool? recentlyReviewed = null);
        /// <summary>
        /// Get a time off request by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of TimeOffRequest</returns>
        System.Threading.Tasks.Task<TimeOffRequest> GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestIdAsync (string muId, string userId, string timeOffRequestId);

        /// <summary>
        /// Get a time off request by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of ApiResponse (TimeOffRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequest>> GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestIdAsyncWithHttpInfo (string muId, string userId, string timeOffRequestId);
        /// <summary>
        /// Get a list of time off requests for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of TimeOffRequestList</returns>
        System.Threading.Tasks.Task<TimeOffRequestList> GetTimeoffrequestsAsync (bool? recentlyReviewed = null);

        /// <summary>
        /// Get a list of time off requests for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestList)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestList>> GetTimeoffrequestsAsyncWithHttpInfo (bool? recentlyReviewed = null);
        /// <summary>
        /// Get a time off request for the current user by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of TimeOffRequest</returns>
        System.Threading.Tasks.Task<TimeOffRequest> GetTimeoffrequestsTimeoffrequestIdAsync (string timeOffRequestId);

        /// <summary>
        /// Get a time off request for the current user by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of ApiResponse (TimeOffRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequest>> GetTimeoffrequestsTimeoffrequestIdAsyncWithHttpInfo (string timeOffRequestId);
        /// <summary>
        /// Mark a time off request for the current user as read or unread
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchTimeoffrequestsTimeoffrequestIdAsync (string timeOffRequestId, TimeOffRequestPatch body = null);

        /// <summary>
        /// Mark a time off request for the current user as read or unread
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchTimeoffrequestsTimeoffrequestIdAsyncWithHttpInfo (string timeOffRequestId, TimeOffRequestPatch body = null);
        /// <summary>
        /// Download decisions files metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of DecisionsFileMetadataEntityListing</returns>
        System.Threading.Tasks.Task<DecisionsFileMetadataEntityListing> PostDecisionsDownloadsSearchAsync (ForecastSearchRequest body);

        /// <summary>
        /// Download decisions files metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DecisionsFileMetadataEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DecisionsFileMetadataEntityListing>> PostDecisionsDownloadsSearchAsyncWithHttpInfo (ForecastSearchRequest body);
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAdherence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAdherence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserScheduleAdherence>(localVarStatusCode,
                localVarHeaders,
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAdherence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAdherence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserScheduleAdherence>(localVarStatusCode,
                localVarHeaders,
                (UserScheduleAdherence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserScheduleAdherence)));
            
        }

        /// <summary>
        /// Get decisions download link 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">The decisions file download id</param>
        /// <param name="downloadfilename">The file name used to get the download url (optional, default to downloadfilename)</param>
        /// <returns>DecisionsDownloadLink</returns>
        public DecisionsDownloadLink GetDecisionsDownloadsDownloadId (string downloadId, string downloadfilename = null)
        {
             ApiResponse<DecisionsDownloadLink> localVarResponse = GetDecisionsDownloadsDownloadIdWithHttpInfo(downloadId, downloadfilename);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get decisions download link 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">The decisions file download id</param>
        /// <param name="downloadfilename">The file name used to get the download url (optional, default to downloadfilename)</param>
        /// <returns>ApiResponse of DecisionsDownloadLink</returns>
        public ApiResponse< DecisionsDownloadLink > GetDecisionsDownloadsDownloadIdWithHttpInfo (string downloadId, string downloadfilename = null)
        {
            // verify the required parameter 'downloadId' is set
            if (downloadId == null)
                throw new ApiException(400, "Missing required parameter 'downloadId' when calling WorkforceManagementApi->GetDecisionsDownloadsDownloadId");

            var localVarPath = "/api/v2/workforcemanagement/decisions/downloads/{downloadId}";
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
            if (downloadId != null) localVarPathParams.Add("downloadId", Configuration.ApiClient.ParameterToString(downloadId)); // path parameter
            if (downloadfilename != null) localVarQueryParams.Add("downloadfilename", Configuration.ApiClient.ParameterToString(downloadfilename)); // query parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDecisionsDownloadsDownloadId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDecisionsDownloadsDownloadId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DecisionsDownloadLink>(localVarStatusCode,
                localVarHeaders,
                (DecisionsDownloadLink) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionsDownloadLink)));
            
        }

        /// <summary>
        /// Get decisions download link 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">The decisions file download id</param>
        /// <param name="downloadfilename">The file name used to get the download url (optional, default to downloadfilename)</param>
        /// <returns>Task of DecisionsDownloadLink</returns>
        public async System.Threading.Tasks.Task<DecisionsDownloadLink> GetDecisionsDownloadsDownloadIdAsync (string downloadId, string downloadfilename = null)
        {
             ApiResponse<DecisionsDownloadLink> localVarResponse = await GetDecisionsDownloadsDownloadIdAsyncWithHttpInfo(downloadId, downloadfilename);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get decisions download link 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">The decisions file download id</param>
        /// <param name="downloadfilename">The file name used to get the download url (optional, default to downloadfilename)</param>
        /// <returns>Task of ApiResponse (DecisionsDownloadLink)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DecisionsDownloadLink>> GetDecisionsDownloadsDownloadIdAsyncWithHttpInfo (string downloadId, string downloadfilename = null)
        {
            // verify the required parameter 'downloadId' is set
            if (downloadId == null)
                throw new ApiException(400, "Missing required parameter 'downloadId' when calling WorkforceManagementApi->GetDecisionsDownloadsDownloadId");

            var localVarPath = "/api/v2/workforcemanagement/decisions/downloads/{downloadId}";
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
            if (downloadId != null) localVarPathParams.Add("downloadId", Configuration.ApiClient.ParameterToString(downloadId)); // path parameter
            if (downloadfilename != null) localVarQueryParams.Add("downloadfilename", Configuration.ApiClient.ParameterToString(downloadfilename)); // query parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDecisionsDownloadsDownloadId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDecisionsDownloadsDownloadId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DecisionsDownloadLink>(localVarStatusCode,
                localVarHeaders,
                (DecisionsDownloadLink) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionsDownloadLink)));
            
        }

        /// <summary>
        /// Get a list of time off requests for any user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>TimeOffRequestList</returns>
        public TimeOffRequestList GetManagementunitsMuIdUsersUserIdTimeoffrequests (string muId, string userId, bool? recentlyReviewed = null)
        {
             ApiResponse<TimeOffRequestList> localVarResponse = GetManagementunitsMuIdUsersUserIdTimeoffrequestsWithHttpInfo(muId, userId, recentlyReviewed);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of time off requests for any user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>ApiResponse of TimeOffRequestList</returns>
        public ApiResponse< TimeOffRequestList > GetManagementunitsMuIdUsersUserIdTimeoffrequestsWithHttpInfo (string muId, string userId, bool? recentlyReviewed = null)
        {
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetManagementunitsMuIdUsersUserIdTimeoffrequests");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetManagementunitsMuIdUsersUserIdTimeoffrequests");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests";
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
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId)); // path parameter
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (recentlyReviewed != null) localVarQueryParams.Add("recentlyReviewed", Configuration.ApiClient.ParameterToString(recentlyReviewed)); // query parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetManagementunitsMuIdUsersUserIdTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetManagementunitsMuIdUsersUserIdTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)));
            
        }

        /// <summary>
        /// Get a list of time off requests for any user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of TimeOffRequestList</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestList> GetManagementunitsMuIdUsersUserIdTimeoffrequestsAsync (string muId, string userId, bool? recentlyReviewed = null)
        {
             ApiResponse<TimeOffRequestList> localVarResponse = await GetManagementunitsMuIdUsersUserIdTimeoffrequestsAsyncWithHttpInfo(muId, userId, recentlyReviewed);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of time off requests for any user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestList>> GetManagementunitsMuIdUsersUserIdTimeoffrequestsAsyncWithHttpInfo (string muId, string userId, bool? recentlyReviewed = null)
        {
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetManagementunitsMuIdUsersUserIdTimeoffrequests");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetManagementunitsMuIdUsersUserIdTimeoffrequests");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests";
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
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId)); // path parameter
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (recentlyReviewed != null) localVarQueryParams.Add("recentlyReviewed", Configuration.ApiClient.ParameterToString(recentlyReviewed)); // query parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetManagementunitsMuIdUsersUserIdTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetManagementunitsMuIdUsersUserIdTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)));
            
        }

        /// <summary>
        /// Get a time off request by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>TimeOffRequest</returns>
        public TimeOffRequest GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId (string muId, string userId, string timeOffRequestId)
        {
             ApiResponse<TimeOffRequest> localVarResponse = GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestIdWithHttpInfo(muId, userId, timeOffRequestId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a time off request by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>ApiResponse of TimeOffRequest</returns>
        public ApiResponse< TimeOffRequest > GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestIdWithHttpInfo (string muId, string userId, string timeOffRequestId)
        {
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId");
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId}";
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
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId)); // path parameter
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", Configuration.ApiClient.ParameterToString(timeOffRequestId)); // path parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequest>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequest)));
            
        }

        /// <summary>
        /// Get a time off request by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of TimeOffRequest</returns>
        public async System.Threading.Tasks.Task<TimeOffRequest> GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestIdAsync (string muId, string userId, string timeOffRequestId)
        {
             ApiResponse<TimeOffRequest> localVarResponse = await GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestIdAsyncWithHttpInfo(muId, userId, timeOffRequestId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a time off request by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of ApiResponse (TimeOffRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequest>> GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestIdAsyncWithHttpInfo (string muId, string userId, string timeOffRequestId)
        {
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId");
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId}";
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
            if (muId != null) localVarPathParams.Add("muId", Configuration.ApiClient.ParameterToString(muId)); // path parameter
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", Configuration.ApiClient.ParameterToString(timeOffRequestId)); // path parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequest>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequest)));
            
        }

        /// <summary>
        /// Get a list of time off requests for the current user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>TimeOffRequestList</returns>
        public TimeOffRequestList GetTimeoffrequests (bool? recentlyReviewed = null)
        {
             ApiResponse<TimeOffRequestList> localVarResponse = GetTimeoffrequestsWithHttpInfo(recentlyReviewed);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of time off requests for the current user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>ApiResponse of TimeOffRequestList</returns>
        public ApiResponse< TimeOffRequestList > GetTimeoffrequestsWithHttpInfo (bool? recentlyReviewed = null)
        {

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests";
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
            if (recentlyReviewed != null) localVarQueryParams.Add("recentlyReviewed", Configuration.ApiClient.ParameterToString(recentlyReviewed)); // query parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)));
            
        }

        /// <summary>
        /// Get a list of time off requests for the current user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of TimeOffRequestList</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestList> GetTimeoffrequestsAsync (bool? recentlyReviewed = null)
        {
             ApiResponse<TimeOffRequestList> localVarResponse = await GetTimeoffrequestsAsyncWithHttpInfo(recentlyReviewed);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of time off requests for the current user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestList>> GetTimeoffrequestsAsyncWithHttpInfo (bool? recentlyReviewed = null)
        {

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests";
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
            if (recentlyReviewed != null) localVarQueryParams.Add("recentlyReviewed", Configuration.ApiClient.ParameterToString(recentlyReviewed)); // query parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)));
            
        }

        /// <summary>
        /// Get a time off request for the current user by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>TimeOffRequest</returns>
        public TimeOffRequest GetTimeoffrequestsTimeoffrequestId (string timeOffRequestId)
        {
             ApiResponse<TimeOffRequest> localVarResponse = GetTimeoffrequestsTimeoffrequestIdWithHttpInfo(timeOffRequestId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a time off request for the current user by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>ApiResponse of TimeOffRequest</returns>
        public ApiResponse< TimeOffRequest > GetTimeoffrequestsTimeoffrequestIdWithHttpInfo (string timeOffRequestId)
        {
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->GetTimeoffrequestsTimeoffrequestId");

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}";
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
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", Configuration.ApiClient.ParameterToString(timeOffRequestId)); // path parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTimeoffrequestsTimeoffrequestId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTimeoffrequestsTimeoffrequestId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequest>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequest)));
            
        }

        /// <summary>
        /// Get a time off request for the current user by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of TimeOffRequest</returns>
        public async System.Threading.Tasks.Task<TimeOffRequest> GetTimeoffrequestsTimeoffrequestIdAsync (string timeOffRequestId)
        {
             ApiResponse<TimeOffRequest> localVarResponse = await GetTimeoffrequestsTimeoffrequestIdAsyncWithHttpInfo(timeOffRequestId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a time off request for the current user by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of ApiResponse (TimeOffRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequest>> GetTimeoffrequestsTimeoffrequestIdAsyncWithHttpInfo (string timeOffRequestId)
        {
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->GetTimeoffrequestsTimeoffrequestId");

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}";
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
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", Configuration.ApiClient.ParameterToString(timeOffRequestId)); // path parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTimeoffrequestsTimeoffrequestId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTimeoffrequestsTimeoffrequestId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequest>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequest)));
            
        }

        /// <summary>
        /// Mark a time off request for the current user as read or unread 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void PatchTimeoffrequestsTimeoffrequestId (string timeOffRequestId, TimeOffRequestPatch body = null)
        {
             PatchTimeoffrequestsTimeoffrequestIdWithHttpInfo(timeOffRequestId, body);
        }

        /// <summary>
        /// Mark a time off request for the current user as read or unread 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchTimeoffrequestsTimeoffrequestIdWithHttpInfo (string timeOffRequestId, TimeOffRequestPatch body = null)
        {
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->PatchTimeoffrequestsTimeoffrequestId");

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}";
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
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", Configuration.ApiClient.ParameterToString(timeOffRequestId)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTimeoffrequestsTimeoffrequestId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTimeoffrequestsTimeoffrequestId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Mark a time off request for the current user as read or unread 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchTimeoffrequestsTimeoffrequestIdAsync (string timeOffRequestId, TimeOffRequestPatch body = null)
        {
             await PatchTimeoffrequestsTimeoffrequestIdAsyncWithHttpInfo(timeOffRequestId, body);

        }

        /// <summary>
        /// Mark a time off request for the current user as read or unread 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchTimeoffrequestsTimeoffrequestIdAsyncWithHttpInfo (string timeOffRequestId, TimeOffRequestPatch body = null)
        {
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->PatchTimeoffrequestsTimeoffrequestId");

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}";
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
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", Configuration.ApiClient.ParameterToString(timeOffRequestId)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTimeoffrequestsTimeoffrequestId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTimeoffrequestsTimeoffrequestId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Download decisions files metadata 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>DecisionsFileMetadataEntityListing</returns>
        public DecisionsFileMetadataEntityListing PostDecisionsDownloadsSearch (ForecastSearchRequest body)
        {
             ApiResponse<DecisionsFileMetadataEntityListing> localVarResponse = PostDecisionsDownloadsSearchWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Download decisions files metadata 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DecisionsFileMetadataEntityListing</returns>
        public ApiResponse< DecisionsFileMetadataEntityListing > PostDecisionsDownloadsSearchWithHttpInfo (ForecastSearchRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostDecisionsDownloadsSearch");

            var localVarPath = "/api/v2/workforcemanagement/decisions/downloads/search";
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostDecisionsDownloadsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDecisionsDownloadsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DecisionsFileMetadataEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DecisionsFileMetadataEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionsFileMetadataEntityListing)));
            
        }

        /// <summary>
        /// Download decisions files metadata 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of DecisionsFileMetadataEntityListing</returns>
        public async System.Threading.Tasks.Task<DecisionsFileMetadataEntityListing> PostDecisionsDownloadsSearchAsync (ForecastSearchRequest body)
        {
             ApiResponse<DecisionsFileMetadataEntityListing> localVarResponse = await PostDecisionsDownloadsSearchAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Download decisions files metadata 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DecisionsFileMetadataEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DecisionsFileMetadataEntityListing>> PostDecisionsDownloadsSearchAsyncWithHttpInfo (ForecastSearchRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostDecisionsDownloadsSearch");

            var localVarPath = "/api/v2/workforcemanagement/decisions/downloads/search";
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostDecisionsDownloadsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDecisionsDownloadsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DecisionsFileMetadataEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DecisionsFileMetadataEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionsFileMetadataEntityListing)));
            
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecasts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecasts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ForecastCreationCompletion>(localVarStatusCode,
                localVarHeaders,
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecasts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLongtermforecasts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ForecastCreationCompletion>(localVarStatusCode,
                localVarHeaders,
                (ForecastCreationCompletion) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ForecastCreationCompletion)));
            
        }

    }
}
