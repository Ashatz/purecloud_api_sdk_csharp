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
    public interface IUserRecordingsApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Delete a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns></returns>
        void DeleteRecordingId (string recordingId);
  
        /// <summary>
        /// Delete a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteRecordingIdWithHttpInfo (string recordingId);
        
        /// <summary>
        /// Get a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation</param>
        /// <returns>UserRecording</returns>
        UserRecording GetRecordingId (string recordingId, string expand = null);
  
        /// <summary>
        /// Get a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation</param>
        /// <returns>ApiResponse of UserRecording</returns>
        ApiResponse<UserRecording> GetRecordingIdWithHttpInfo (string recordingId, string expand = null);
        
        /// <summary>
        /// Download a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>DownloadResponse</returns>
        DownloadResponse GetRecordingIdMedia (string recordingId, string formatId = null);
  
        /// <summary>
        /// Download a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>ApiResponse of DownloadResponse</returns>
        ApiResponse<DownloadResponse> GetRecordingIdMediaWithHttpInfo (string recordingId, string formatId = null);
        
        /// <summary>
        /// Get user recording summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>FaxSummary</returns>
        FaxSummary GetSummary ();
  
        /// <summary>
        /// Get user recording summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of FaxSummary</returns>
        ApiResponse<FaxSummary> GetSummaryWithHttpInfo ();
        
        /// <summary>
        /// Get a list of user recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">conversation</param>
        /// <returns>UserRecordingEntityListing</returns>
        UserRecordingEntityListing GetUserrecordings (int? pageSize = null, int? pageNumber = null, string expand = null);
  
        /// <summary>
        /// Get a list of user recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">conversation</param>
        /// <returns>ApiResponse of UserRecordingEntityListing</returns>
        ApiResponse<UserRecordingEntityListing> GetUserrecordingsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null);
        
        /// <summary>
        /// Update a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording</param>
        /// <param name="expand">conversation</param>
        /// <returns>UserRecording</returns>
        UserRecording PutRecordingId (string recordingId, UserRecording body = null, string expand = null);
  
        /// <summary>
        /// Update a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording</param>
        /// <param name="expand">conversation</param>
        /// <returns>ApiResponse of UserRecording</returns>
        ApiResponse<UserRecording> PutRecordingIdWithHttpInfo (string recordingId, UserRecording body = null, string expand = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Delete a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteRecordingIdAsync (string recordingId);

        /// <summary>
        /// Delete a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRecordingIdAsyncWithHttpInfo (string recordingId);
        
        /// <summary>
        /// Get a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of UserRecording</returns>
        System.Threading.Tasks.Task<UserRecording> GetRecordingIdAsync (string recordingId, string expand = null);

        /// <summary>
        /// Get a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of ApiResponse (UserRecording)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserRecording>> GetRecordingIdAsyncWithHttpInfo (string recordingId, string expand = null);
        
        /// <summary>
        /// Download a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of DownloadResponse</returns>
        System.Threading.Tasks.Task<DownloadResponse> GetRecordingIdMediaAsync (string recordingId, string formatId = null);

        /// <summary>
        /// Download a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> GetRecordingIdMediaAsyncWithHttpInfo (string recordingId, string formatId = null);
        
        /// <summary>
        /// Get user recording summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of FaxSummary</returns>
        System.Threading.Tasks.Task<FaxSummary> GetSummaryAsync ();

        /// <summary>
        /// Get user recording summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (FaxSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxSummary>> GetSummaryAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a list of user recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of UserRecordingEntityListing</returns>
        System.Threading.Tasks.Task<UserRecordingEntityListing> GetUserrecordingsAsync (int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list of user recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of ApiResponse (UserRecordingEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserRecordingEntityListing>> GetUserrecordingsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null);
        
        /// <summary>
        /// Update a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of UserRecording</returns>
        System.Threading.Tasks.Task<UserRecording> PutRecordingIdAsync (string recordingId, UserRecording body = null, string expand = null);

        /// <summary>
        /// Update a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of ApiResponse (UserRecording)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserRecording>> PutRecordingIdAsyncWithHttpInfo (string recordingId, UserRecording body = null, string expand = null);
        
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
        /// Delete a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param> 
        /// <returns></returns>
        public void DeleteRecordingId (string recordingId)
        {
             DeleteRecordingIdWithHttpInfo(recordingId);
        }

        /// <summary>
        /// Delete a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteRecordingIdWithHttpInfo (string recordingId)
        {
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserRecordingsApi->DeleteRecordingId");
            
    
            var localVarPath = "/api/v2/userrecordings/{recordingId}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task DeleteRecordingIdAsync (string recordingId)
        {
             await DeleteRecordingIdAsyncWithHttpInfo(recordingId);

        }

        /// <summary>
        /// Delete a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRecordingIdAsyncWithHttpInfo (string recordingId)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling DeleteRecordingId");
            
    
            var localVarPath = "/api/v2/userrecordings/{recordingId}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRecordingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param> 
        /// <param name="expand">conversation</param> 
        /// <returns>UserRecording</returns>
        public UserRecording GetRecordingId (string recordingId, string expand = null)
        {
             ApiResponse<UserRecording> localVarResponse = GetRecordingIdWithHttpInfo(recordingId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param> 
        /// <param name="expand">conversation</param> 
        /// <returns>ApiResponse of UserRecording</returns>
        public ApiResponse< UserRecording > GetRecordingIdWithHttpInfo (string recordingId, string expand = null)
        {
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserRecordingsApi->GetRecordingId");
            
    
            var localVarPath = "/api/v2/userrecordings/{recordingId}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRecording)));
            
        }

        
        /// <summary>
        /// Get a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of UserRecording</returns>
        public async System.Threading.Tasks.Task<UserRecording> GetRecordingIdAsync (string recordingId, string expand = null)
        {
             ApiResponse<UserRecording> localVarResponse = await GetRecordingIdAsyncWithHttpInfo(recordingId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of ApiResponse (UserRecording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserRecording>> GetRecordingIdAsyncWithHttpInfo (string recordingId, string expand = null)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling GetRecordingId");
            
    
            var localVarPath = "/api/v2/userrecordings/{recordingId}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRecording)));
            
        }
        
        /// <summary>
        /// Download a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param> 
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param> 
        /// <returns>DownloadResponse</returns>
        public DownloadResponse GetRecordingIdMedia (string recordingId, string formatId = null)
        {
             ApiResponse<DownloadResponse> localVarResponse = GetRecordingIdMediaWithHttpInfo(recordingId, formatId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Download a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param> 
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param> 
        /// <returns>ApiResponse of DownloadResponse</returns>
        public ApiResponse< DownloadResponse > GetRecordingIdMediaWithHttpInfo (string recordingId, string formatId = null)
        {
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserRecordingsApi->GetRecordingIdMedia");
            
    
            var localVarPath = "/api/v2/userrecordings/{recordingId}/media";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingIdMedia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingIdMedia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DownloadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DownloadResponse)));
            
        }

        
        /// <summary>
        /// Download a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of DownloadResponse</returns>
        public async System.Threading.Tasks.Task<DownloadResponse> GetRecordingIdMediaAsync (string recordingId, string formatId = null)
        {
             ApiResponse<DownloadResponse> localVarResponse = await GetRecordingIdMediaAsyncWithHttpInfo(recordingId, formatId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Download a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> GetRecordingIdMediaAsyncWithHttpInfo (string recordingId, string formatId = null)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling GetRecordingIdMedia");
            
    
            var localVarPath = "/api/v2/userrecordings/{recordingId}/media";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingIdMedia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingIdMedia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DownloadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DownloadResponse)));
            
        }
        
        /// <summary>
        /// Get user recording summary 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>FaxSummary</returns>
        public FaxSummary GetSummary ()
        {
             ApiResponse<FaxSummary> localVarResponse = GetSummaryWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get user recording summary 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of FaxSummary</returns>
        public ApiResponse< FaxSummary > GetSummaryWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/v2/userrecordings/summary";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetSummary: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSummary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FaxSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSummary)));
            
        }

        
        /// <summary>
        /// Get user recording summary 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of FaxSummary</returns>
        public async System.Threading.Tasks.Task<FaxSummary> GetSummaryAsync ()
        {
             ApiResponse<FaxSummary> localVarResponse = await GetSummaryAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get user recording summary 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (FaxSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxSummary>> GetSummaryAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/v2/userrecordings/summary";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetSummary: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSummary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSummary)));
            
        }
        
        /// <summary>
        /// Get a list of user recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">conversation</param> 
        /// <returns>UserRecordingEntityListing</returns>
        public UserRecordingEntityListing GetUserrecordings (int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<UserRecordingEntityListing> localVarResponse = GetUserrecordingsWithHttpInfo(pageSize, pageNumber, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of user recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">conversation</param> 
        /// <returns>ApiResponse of UserRecordingEntityListing</returns>
        public ApiResponse< UserRecordingEntityListing > GetUserrecordingsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            
    
            var localVarPath = "/api/v2/userrecordings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserrecordings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserrecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserRecordingEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecordingEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRecordingEntityListing)));
            
        }

        
        /// <summary>
        /// Get a list of user recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of UserRecordingEntityListing</returns>
        public async System.Threading.Tasks.Task<UserRecordingEntityListing> GetUserrecordingsAsync (int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<UserRecordingEntityListing> localVarResponse = await GetUserrecordingsAsyncWithHttpInfo(pageSize, pageNumber, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of user recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of ApiResponse (UserRecordingEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserRecordingEntityListing>> GetUserrecordingsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            
    
            var localVarPath = "/api/v2/userrecordings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserrecordings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserrecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRecordingEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecordingEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRecordingEntityListing)));
            
        }
        
        /// <summary>
        /// Update a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param> 
        /// <param name="body">UserRecording</param> 
        /// <param name="expand">conversation</param> 
        /// <returns>UserRecording</returns>
        public UserRecording PutRecordingId (string recordingId, UserRecording body = null, string expand = null)
        {
             ApiResponse<UserRecording> localVarResponse = PutRecordingIdWithHttpInfo(recordingId, body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param> 
        /// <param name="body">UserRecording</param> 
        /// <param name="expand">conversation</param> 
        /// <returns>ApiResponse of UserRecording</returns>
        public ApiResponse< UserRecording > PutRecordingIdWithHttpInfo (string recordingId, UserRecording body = null, string expand = null)
        {
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserRecordingsApi->PutRecordingId");
            
    
            var localVarPath = "/api/v2/userrecordings/{recordingId}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRecording)));
            
        }

        
        /// <summary>
        /// Update a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of UserRecording</returns>
        public async System.Threading.Tasks.Task<UserRecording> PutRecordingIdAsync (string recordingId, UserRecording body = null, string expand = null)
        {
             ApiResponse<UserRecording> localVarResponse = await PutRecordingIdAsyncWithHttpInfo(recordingId, body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a user recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of ApiResponse (UserRecording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserRecording>> PutRecordingIdAsyncWithHttpInfo (string recordingId, UserRecording body = null, string expand = null)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling PutRecordingId");
            
    
            var localVarPath = "/api/v2/userrecordings/{recordingId}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRecording)));
            
        }
        
    }
    
}
