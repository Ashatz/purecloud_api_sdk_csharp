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
    public interface IUserRecordingsApi
    {
        
        /// <summary>
        /// Get a list of user recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">conversation</param>
        /// <returns>UserRecordingEntityListing</returns>
        UserRecordingEntityListing UserrecordingsGet (int? pageSize = null, int? pageNumber = null, string expand = null);
  
        /// <summary>
        /// Get a list of user recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">conversation</param>
        /// <returns>ApiResponse of UserRecordingEntityListing</returns>
        ApiResponse<UserRecordingEntityListing> UserrecordingsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list of user recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of UserRecordingEntityListing</returns>
        System.Threading.Tasks.Task<UserRecordingEntityListing> UserrecordingsGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list of user recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of ApiResponse (UserRecordingEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserRecordingEntityListing>> UserrecordingsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null);
        
        /// <summary>
        /// Get user recording summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>FaxSummary</returns>
        FaxSummary UserrecordingsSummaryGet ();
  
        /// <summary>
        /// Get user recording summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of FaxSummary</returns>
        ApiResponse<FaxSummary> UserrecordingsSummaryGetWithHttpInfo ();

        /// <summary>
        /// Get user recording summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of FaxSummary</returns>
        System.Threading.Tasks.Task<FaxSummary> UserrecordingsSummaryGetAsync ();

        /// <summary>
        /// Get user recording summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (FaxSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxSummary>> UserrecordingsSummaryGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation</param>
        /// <returns>UserRecording</returns>
        UserRecording UserrecordingsRecordingidGet (string recordingId, string expand = null);
  
        /// <summary>
        /// Get a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation</param>
        /// <returns>ApiResponse of UserRecording</returns>
        ApiResponse<UserRecording> UserrecordingsRecordingidGetWithHttpInfo (string recordingId, string expand = null);

        /// <summary>
        /// Get a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of UserRecording</returns>
        System.Threading.Tasks.Task<UserRecording> UserrecordingsRecordingidGetAsync (string recordingId, string expand = null);

        /// <summary>
        /// Get a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of ApiResponse (UserRecording)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserRecording>> UserrecordingsRecordingidGetAsyncWithHttpInfo (string recordingId, string expand = null);
        
        /// <summary>
        /// Update a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording</param>
        /// <param name="expand">conversation</param>
        /// <returns>UserRecording</returns>
        UserRecording UserrecordingsRecordingidPut (string recordingId, UserRecording body = null, string expand = null);
  
        /// <summary>
        /// Update a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording</param>
        /// <param name="expand">conversation</param>
        /// <returns>ApiResponse of UserRecording</returns>
        ApiResponse<UserRecording> UserrecordingsRecordingidPutWithHttpInfo (string recordingId, UserRecording body = null, string expand = null);

        /// <summary>
        /// Update a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of UserRecording</returns>
        System.Threading.Tasks.Task<UserRecording> UserrecordingsRecordingidPutAsync (string recordingId, UserRecording body = null, string expand = null);

        /// <summary>
        /// Update a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of ApiResponse (UserRecording)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserRecording>> UserrecordingsRecordingidPutAsyncWithHttpInfo (string recordingId, UserRecording body = null, string expand = null);
        
        /// <summary>
        /// Delete a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns></returns>
        void UserrecordingsRecordingidDelete (string recordingId);
  
        /// <summary>
        /// Delete a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UserrecordingsRecordingidDeleteWithHttpInfo (string recordingId);

        /// <summary>
        /// Delete a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UserrecordingsRecordingidDeleteAsync (string recordingId);

        /// <summary>
        /// Delete a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UserrecordingsRecordingidDeleteAsyncWithHttpInfo (string recordingId);
        
        /// <summary>
        /// Download a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>DownloadResponse</returns>
        DownloadResponse UserrecordingsRecordingidMediaGet (string recordingId, string formatId = null);
  
        /// <summary>
        /// Download a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>ApiResponse of DownloadResponse</returns>
        ApiResponse<DownloadResponse> UserrecordingsRecordingidMediaGetWithHttpInfo (string recordingId, string formatId = null);

        /// <summary>
        /// Download a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of DownloadResponse</returns>
        System.Threading.Tasks.Task<DownloadResponse> UserrecordingsRecordingidMediaGetAsync (string recordingId, string formatId = null);

        /// <summary>
        /// Download a user recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> UserrecordingsRecordingidMediaGetAsyncWithHttpInfo (string recordingId, string formatId = null);
        
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
        /// Get a list of user recordings. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">conversation</param> 
        /// <returns>UserRecordingEntityListing</returns>
        public UserRecordingEntityListing UserrecordingsGet (int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<UserRecordingEntityListing> response = UserrecordingsGetWithHttpInfo(pageSize, pageNumber, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a list of user recordings. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">conversation</param> 
        /// <returns>ApiResponse of UserRecordingEntityListing</returns>
        public ApiResponse< UserRecordingEntityListing > UserrecordingsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/userrecordings";
    
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
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserrecordingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserrecordingsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserRecordingEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecordingEntityListing) Configuration.ApiClient.Deserialize(response, typeof(UserRecordingEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of user recordings. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of UserRecordingEntityListing</returns>
        public async System.Threading.Tasks.Task<UserRecordingEntityListing> UserrecordingsGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<UserRecordingEntityListing> response = await UserrecordingsGetAsyncWithHttpInfo(pageSize, pageNumber, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a list of user recordings. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of ApiResponse (UserRecordingEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserRecordingEntityListing>> UserrecordingsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/userrecordings";
    
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
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserrecordingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserrecordingsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserRecordingEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecordingEntityListing) Configuration.ApiClient.Deserialize(response, typeof(UserRecordingEntityListing)));
            
        }
        
        /// <summary>
        /// Get user recording summary 
        /// </summary>
        /// <returns>FaxSummary</returns>
        public FaxSummary UserrecordingsSummaryGet ()
        {
             ApiResponse<FaxSummary> response = UserrecordingsSummaryGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get user recording summary 
        /// </summary>
        /// <returns>ApiResponse of FaxSummary</returns>
        public ApiResponse< FaxSummary > UserrecordingsSummaryGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/userrecordings/summary";
    
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
                throw new ApiException (statusCode, "Error calling UserrecordingsSummaryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserrecordingsSummaryGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FaxSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSummary) Configuration.ApiClient.Deserialize(response, typeof(FaxSummary)));
            
        }
    
        /// <summary>
        /// Get user recording summary 
        /// </summary>
        /// <returns>Task of FaxSummary</returns>
        public async System.Threading.Tasks.Task<FaxSummary> UserrecordingsSummaryGetAsync ()
        {
             ApiResponse<FaxSummary> response = await UserrecordingsSummaryGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get user recording summary 
        /// </summary>
        /// <returns>Task of ApiResponse (FaxSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxSummary>> UserrecordingsSummaryGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/userrecordings/summary";
    
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
                throw new ApiException (statusCode, "Error calling UserrecordingsSummaryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserrecordingsSummaryGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FaxSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSummary) Configuration.ApiClient.Deserialize(response, typeof(FaxSummary)));
            
        }
        
        /// <summary>
        /// Get a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param> 
        /// <param name="expand">conversation</param> 
        /// <returns>UserRecording</returns>
        public UserRecording UserrecordingsRecordingidGet (string recordingId, string expand = null)
        {
             ApiResponse<UserRecording> response = UserrecordingsRecordingidGetWithHttpInfo(recordingId, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param> 
        /// <param name="expand">conversation</param> 
        /// <returns>ApiResponse of UserRecording</returns>
        public ApiResponse< UserRecording > UserrecordingsRecordingidGetWithHttpInfo (string recordingId, string expand = null)
        {
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserrecordingsRecordingidGet");
            
    
            var path_ = "/api/v1/userrecordings/{recordingId}";
    
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
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserRecording>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecording) Configuration.ApiClient.Deserialize(response, typeof(UserRecording)));
            
        }
    
        /// <summary>
        /// Get a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of UserRecording</returns>
        public async System.Threading.Tasks.Task<UserRecording> UserrecordingsRecordingidGetAsync (string recordingId, string expand = null)
        {
             ApiResponse<UserRecording> response = await UserrecordingsRecordingidGetAsyncWithHttpInfo(recordingId, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of ApiResponse (UserRecording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserRecording>> UserrecordingsRecordingidGetAsyncWithHttpInfo (string recordingId, string expand = null)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserrecordingsRecordingidGet");
            
    
            var path_ = "/api/v1/userrecordings/{recordingId}";
    
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
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserRecording>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecording) Configuration.ApiClient.Deserialize(response, typeof(UserRecording)));
            
        }
        
        /// <summary>
        /// Update a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param> 
        /// <param name="body">UserRecording</param> 
        /// <param name="expand">conversation</param> 
        /// <returns>UserRecording</returns>
        public UserRecording UserrecordingsRecordingidPut (string recordingId, UserRecording body = null, string expand = null)
        {
             ApiResponse<UserRecording> response = UserrecordingsRecordingidPutWithHttpInfo(recordingId, body, expand);
             return response.Data;
        }

        /// <summary>
        /// Update a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param> 
        /// <param name="body">UserRecording</param> 
        /// <param name="expand">conversation</param> 
        /// <returns>ApiResponse of UserRecording</returns>
        public ApiResponse< UserRecording > UserrecordingsRecordingidPutWithHttpInfo (string recordingId, UserRecording body = null, string expand = null)
        {
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserrecordingsRecordingidPut");
            
    
            var path_ = "/api/v1/userrecordings/{recordingId}";
    
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
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserRecording>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecording) Configuration.ApiClient.Deserialize(response, typeof(UserRecording)));
            
        }
    
        /// <summary>
        /// Update a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of UserRecording</returns>
        public async System.Threading.Tasks.Task<UserRecording> UserrecordingsRecordingidPutAsync (string recordingId, UserRecording body = null, string expand = null)
        {
             ApiResponse<UserRecording> response = await UserrecordingsRecordingidPutAsyncWithHttpInfo(recordingId, body, expand);
             return response.Data;

        }

        /// <summary>
        /// Update a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="body">UserRecording</param>
        /// <param name="expand">conversation</param>
        /// <returns>Task of ApiResponse (UserRecording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserRecording>> UserrecordingsRecordingidPutAsyncWithHttpInfo (string recordingId, UserRecording body = null, string expand = null)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserrecordingsRecordingidPut");
            
    
            var path_ = "/api/v1/userrecordings/{recordingId}";
    
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
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserRecording>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRecording) Configuration.ApiClient.Deserialize(response, typeof(UserRecording)));
            
        }
        
        /// <summary>
        /// Delete a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param> 
        /// <returns></returns>
        public void UserrecordingsRecordingidDelete (string recordingId)
        {
             UserrecordingsRecordingidDeleteWithHttpInfo(recordingId);
        }

        /// <summary>
        /// Delete a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UserrecordingsRecordingidDeleteWithHttpInfo (string recordingId)
        {
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserrecordingsRecordingidDelete");
            
    
            var path_ = "/api/v1/userrecordings/{recordingId}";
    
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
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UserrecordingsRecordingidDeleteAsync (string recordingId)
        {
             await UserrecordingsRecordingidDeleteAsyncWithHttpInfo(recordingId);

        }

        /// <summary>
        /// Delete a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UserrecordingsRecordingidDeleteAsyncWithHttpInfo (string recordingId)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserrecordingsRecordingidDelete");
            
    
            var path_ = "/api/v1/userrecordings/{recordingId}";
    
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
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Download a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param> 
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param> 
        /// <returns>DownloadResponse</returns>
        public DownloadResponse UserrecordingsRecordingidMediaGet (string recordingId, string formatId = null)
        {
             ApiResponse<DownloadResponse> response = UserrecordingsRecordingidMediaGetWithHttpInfo(recordingId, formatId);
             return response.Data;
        }

        /// <summary>
        /// Download a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param> 
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param> 
        /// <returns>ApiResponse of DownloadResponse</returns>
        public ApiResponse< DownloadResponse > UserrecordingsRecordingidMediaGetWithHttpInfo (string recordingId, string formatId = null)
        {
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserrecordingsRecordingidMediaGet");
            
    
            var path_ = "/api/v1/userrecordings/{recordingId}/media";
    
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
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            if (formatId != null) queryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidMediaGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidMediaGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DownloadResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(response, typeof(DownloadResponse)));
            
        }
    
        /// <summary>
        /// Download a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of DownloadResponse</returns>
        public async System.Threading.Tasks.Task<DownloadResponse> UserrecordingsRecordingidMediaGetAsync (string recordingId, string formatId = null)
        {
             ApiResponse<DownloadResponse> response = await UserrecordingsRecordingidMediaGetAsyncWithHttpInfo(recordingId, formatId);
             return response.Data;

        }

        /// <summary>
        /// Download a user recording. 
        /// </summary>
        /// <param name="recordingId">User Recording ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> UserrecordingsRecordingidMediaGetAsyncWithHttpInfo (string recordingId, string formatId = null)
        {
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling UserrecordingsRecordingidMediaGet");
            
    
            var path_ = "/api/v1/userrecordings/{recordingId}/media";
    
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
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            if (formatId != null) queryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidMediaGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserrecordingsRecordingidMediaGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DownloadResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(response, typeof(DownloadResponse)));
            
        }
        
    }
    
}
