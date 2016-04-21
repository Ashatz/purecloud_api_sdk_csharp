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
    public interface IUserRecordingsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a list of user recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>UserRecordingEntityListing</returns>
        UserRecordingEntityListing UserrecordingsGet (int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list of user recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>ApiResponse of UserRecordingEntityListing</returns>
        ApiResponse<UserRecordingEntityListing> UserrecordingsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null);
        /// <summary>
        /// Delete a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns></returns>
        void UserrecordingsRecordingidDelete (string recordingId);

        /// <summary>
        /// Delete a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UserrecordingsRecordingidDeleteWithHttpInfo (string recordingId);
        /// <summary>
        /// Get a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>UserRecording</returns>
        UserRecording UserrecordingsRecordingidGet (string recordingId, string expand = null);

        /// <summary>
        /// Get a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>ApiResponse of UserRecording</returns>
        ApiResponse<UserRecording> UserrecordingsRecordingidGetWithHttpInfo (string recordingId, string expand = null);
        /// <summary>
        /// Download a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>DownloadResponse</returns>
        DownloadResponse UserrecordingsRecordingidMediaGet (string recordingId, string formatId = null);

        /// <summary>
        /// Download a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>ApiResponse of DownloadResponse</returns>
        ApiResponse<DownloadResponse> UserrecordingsRecordingidMediaGetWithHttpInfo (string recordingId, string formatId = null);
        /// <summary>
        /// Update a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording (optional)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>UserRecording</returns>
        UserRecording UserrecordingsRecordingidPut (string recordingId, UserRecording body = null, string expand = null);

        /// <summary>
        /// Update a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording (optional)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>ApiResponse of UserRecording</returns>
        ApiResponse<UserRecording> UserrecordingsRecordingidPutWithHttpInfo (string recordingId, UserRecording body = null, string expand = null);
        /// <summary>
        /// Get user recording summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>FaxSummary</returns>
        FaxSummary UserrecordingsSummaryGet ();

        /// <summary>
        /// Get user recording summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of FaxSummary</returns>
        ApiResponse<FaxSummary> UserrecordingsSummaryGetWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a list of user recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>Task of UserRecordingEntityListing</returns>
        System.Threading.Tasks.Task<UserRecordingEntityListing> UserrecordingsGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list of user recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>Task of ApiResponse (UserRecordingEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserRecordingEntityListing>> UserrecordingsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null);
        /// <summary>
        /// Delete a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UserrecordingsRecordingidDeleteAsync (string recordingId);

        /// <summary>
        /// Delete a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UserrecordingsRecordingidDeleteAsyncWithHttpInfo (string recordingId);
        /// <summary>
        /// Get a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>Task of UserRecording</returns>
        System.Threading.Tasks.Task<UserRecording> UserrecordingsRecordingidGetAsync (string recordingId, string expand = null);

        /// <summary>
        /// Get a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>Task of ApiResponse (UserRecording)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserRecording>> UserrecordingsRecordingidGetAsyncWithHttpInfo (string recordingId, string expand = null);
        /// <summary>
        /// Download a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>Task of DownloadResponse</returns>
        System.Threading.Tasks.Task<DownloadResponse> UserrecordingsRecordingidMediaGetAsync (string recordingId, string formatId = null);

        /// <summary>
        /// Download a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> UserrecordingsRecordingidMediaGetAsyncWithHttpInfo (string recordingId, string formatId = null);
        /// <summary>
        /// Update a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording (optional)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>Task of UserRecording</returns>
        System.Threading.Tasks.Task<UserRecording> UserrecordingsRecordingidPutAsync (string recordingId, UserRecording body = null, string expand = null);

        /// <summary>
        /// Update a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording (optional)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>Task of ApiResponse (UserRecording)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserRecording>> UserrecordingsRecordingidPutAsyncWithHttpInfo (string recordingId, UserRecording body = null, string expand = null);
        /// <summary>
        /// Get user recording summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of FaxSummary</returns>
        System.Threading.Tasks.Task<FaxSummary> UserrecordingsSummaryGetAsync ();

        /// <summary>
        /// Get user recording summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (FaxSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxSummary>> UserrecordingsSummaryGetAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserRecordingsApi : IUserRecordingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRecordingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserRecordingsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRecordingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserRecordingsApi(Configuration configuration = null)
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
        /// Get a list of user recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>UserRecordingEntityListing</returns>
        public UserRecordingEntityListing UserrecordingsGet (int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<UserRecordingEntityListing> localVarResponse = UserrecordingsGetWithHttpInfo(pageSize, pageNumber, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of user recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>ApiResponse of UserRecordingEntityListing</returns>
        public ApiResponse< UserRecordingEntityListing > UserrecordingsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null)
        {

            var localVarPath = "/api/v1/userrecordings";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRecordingEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecordingEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRecordingEntityListing)));
            
        }

        /// <summary>
        /// Get a list of user recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>Task of UserRecordingEntityListing</returns>
        public async System.Threading.Tasks.Task<UserRecordingEntityListing> UserrecordingsGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<UserRecordingEntityListing> localVarResponse = await UserrecordingsGetAsyncWithHttpInfo(pageSize, pageNumber, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of user recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>Task of ApiResponse (UserRecordingEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserRecordingEntityListing>> UserrecordingsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null)
        {

            var localVarPath = "/api/v1/userrecordings";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRecordingEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecordingEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRecordingEntityListing)));
            
        }

        /// <summary>
        /// Delete a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns></returns>
        public void UserrecordingsRecordingidDelete (string recordingId)
        {
             UserrecordingsRecordingidDeleteWithHttpInfo(recordingId);
        }

        /// <summary>
        /// Delete a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UserrecordingsRecordingidDeleteWithHttpInfo (string recordingId)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserRecordingsApi->UserrecordingsRecordingidDelete");

            var localVarPath = "/api/v1/userrecordings/{recordingId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UserrecordingsRecordingidDeleteAsync (string recordingId)
        {
             await UserrecordingsRecordingidDeleteAsyncWithHttpInfo(recordingId);

        }

        /// <summary>
        /// Delete a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UserrecordingsRecordingidDeleteAsyncWithHttpInfo (string recordingId)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserRecordingsApi->UserrecordingsRecordingidDelete");

            var localVarPath = "/api/v1/userrecordings/{recordingId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>UserRecording</returns>
        public UserRecording UserrecordingsRecordingidGet (string recordingId, string expand = null)
        {
             ApiResponse<UserRecording> localVarResponse = UserrecordingsRecordingidGetWithHttpInfo(recordingId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>ApiResponse of UserRecording</returns>
        public ApiResponse< UserRecording > UserrecordingsRecordingidGetWithHttpInfo (string recordingId, string expand = null)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserRecordingsApi->UserrecordingsRecordingidGet");

            var localVarPath = "/api/v1/userrecordings/{recordingId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRecording)));
            
        }

        /// <summary>
        /// Get a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>Task of UserRecording</returns>
        public async System.Threading.Tasks.Task<UserRecording> UserrecordingsRecordingidGetAsync (string recordingId, string expand = null)
        {
             ApiResponse<UserRecording> localVarResponse = await UserrecordingsRecordingidGetAsyncWithHttpInfo(recordingId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>Task of ApiResponse (UserRecording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserRecording>> UserrecordingsRecordingidGetAsyncWithHttpInfo (string recordingId, string expand = null)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserRecordingsApi->UserrecordingsRecordingidGet");

            var localVarPath = "/api/v1/userrecordings/{recordingId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRecording)));
            
        }

        /// <summary>
        /// Download a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>DownloadResponse</returns>
        public DownloadResponse UserrecordingsRecordingidMediaGet (string recordingId, string formatId = null)
        {
             ApiResponse<DownloadResponse> localVarResponse = UserrecordingsRecordingidMediaGetWithHttpInfo(recordingId, formatId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Download a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>ApiResponse of DownloadResponse</returns>
        public ApiResponse< DownloadResponse > UserrecordingsRecordingidMediaGetWithHttpInfo (string recordingId, string formatId = null)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserRecordingsApi->UserrecordingsRecordingidMediaGet");

            var localVarPath = "/api/v1/userrecordings/{recordingId}/media";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidMediaGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidMediaGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DownloadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DownloadResponse)));
            
        }

        /// <summary>
        /// Download a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>Task of DownloadResponse</returns>
        public async System.Threading.Tasks.Task<DownloadResponse> UserrecordingsRecordingidMediaGetAsync (string recordingId, string formatId = null)
        {
             ApiResponse<DownloadResponse> localVarResponse = await UserrecordingsRecordingidMediaGetAsyncWithHttpInfo(recordingId, formatId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Download a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> UserrecordingsRecordingidMediaGetAsyncWithHttpInfo (string recordingId, string formatId = null)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserRecordingsApi->UserrecordingsRecordingidMediaGet");

            var localVarPath = "/api/v1/userrecordings/{recordingId}/media";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidMediaGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidMediaGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DownloadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DownloadResponse)));
            
        }

        /// <summary>
        /// Update a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording (optional)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>UserRecording</returns>
        public UserRecording UserrecordingsRecordingidPut (string recordingId, UserRecording body = null, string expand = null)
        {
             ApiResponse<UserRecording> localVarResponse = UserrecordingsRecordingidPutWithHttpInfo(recordingId, body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording (optional)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>ApiResponse of UserRecording</returns>
        public ApiResponse< UserRecording > UserrecordingsRecordingidPutWithHttpInfo (string recordingId, UserRecording body = null, string expand = null)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserRecordingsApi->UserrecordingsRecordingidPut");

            var localVarPath = "/api/v1/userrecordings/{recordingId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRecording)));
            
        }

        /// <summary>
        /// Update a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording (optional)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>Task of UserRecording</returns>
        public async System.Threading.Tasks.Task<UserRecording> UserrecordingsRecordingidPutAsync (string recordingId, UserRecording body = null, string expand = null)
        {
             ApiResponse<UserRecording> localVarResponse = await UserrecordingsRecordingidPutAsyncWithHttpInfo(recordingId, body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording (optional)</param>
        /// <param name="expand">conversation (optional)</param>
        /// <returns>Task of ApiResponse (UserRecording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserRecording>> UserrecordingsRecordingidPutAsyncWithHttpInfo (string recordingId, UserRecording body = null, string expand = null)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserRecordingsApi->UserrecordingsRecordingidPut");

            var localVarPath = "/api/v1/userrecordings/{recordingId}";
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsRecordingidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRecording)));
            
        }

        /// <summary>
        /// Get user recording summary 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>FaxSummary</returns>
        public FaxSummary UserrecordingsSummaryGet ()
        {
             ApiResponse<FaxSummary> localVarResponse = UserrecordingsSummaryGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get user recording summary 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of FaxSummary</returns>
        public ApiResponse< FaxSummary > UserrecordingsSummaryGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/userrecordings/summary";
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
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsSummaryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsSummaryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSummary)));
            
        }

        /// <summary>
        /// Get user recording summary 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of FaxSummary</returns>
        public async System.Threading.Tasks.Task<FaxSummary> UserrecordingsSummaryGetAsync ()
        {
             ApiResponse<FaxSummary> localVarResponse = await UserrecordingsSummaryGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get user recording summary 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (FaxSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxSummary>> UserrecordingsSummaryGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/userrecordings/summary";
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
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsSummaryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UserrecordingsSummaryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSummary)));
            
        }

    }
}
