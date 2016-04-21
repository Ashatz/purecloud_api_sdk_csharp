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
    public interface IOrphanedRecordingsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets all orphan recordings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <returns>OrphanRecordingListing</returns>
        OrphanRecordingListing OrphanrecordingsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null);

        /// <summary>
        /// Gets all orphan recordings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <returns>ApiResponse of OrphanRecordingListing</returns>
        ApiResponse<OrphanRecordingListing> OrphanrecordingsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null);
        /// <summary>
        ///  deletes a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>OrphanRecording</returns>
        OrphanRecording OrphanrecordingsOrphanidDelete (string orphanId);

        /// <summary>
        ///  deletes a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>ApiResponse of OrphanRecording</returns>
        ApiResponse<OrphanRecording> OrphanrecordingsOrphanidDeleteWithHttpInfo (string orphanId);
        /// <summary>
        /// Gets a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>OrphanRecording</returns>
        OrphanRecording OrphanrecordingsOrphanidGet (string orphanId);

        /// <summary>
        /// Gets a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>ApiResponse of OrphanRecording</returns>
        ApiResponse<OrphanRecording> OrphanrecordingsOrphanidGetWithHttpInfo (string orphanId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets all orphan recordings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <returns>Task of OrphanRecordingListing</returns>
        System.Threading.Tasks.Task<OrphanRecordingListing> OrphanrecordingsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null);

        /// <summary>
        /// Gets all orphan recordings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <returns>Task of ApiResponse (OrphanRecordingListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrphanRecordingListing>> OrphanrecordingsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null);
        /// <summary>
        ///  deletes a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of OrphanRecording</returns>
        System.Threading.Tasks.Task<OrphanRecording> OrphanrecordingsOrphanidDeleteAsync (string orphanId);

        /// <summary>
        ///  deletes a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of ApiResponse (OrphanRecording)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrphanRecording>> OrphanrecordingsOrphanidDeleteAsyncWithHttpInfo (string orphanId);
        /// <summary>
        /// Gets a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of OrphanRecording</returns>
        System.Threading.Tasks.Task<OrphanRecording> OrphanrecordingsOrphanidGetAsync (string orphanId);

        /// <summary>
        /// Gets a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of ApiResponse (OrphanRecording)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrphanRecording>> OrphanrecordingsOrphanidGetAsyncWithHttpInfo (string orphanId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrphanedRecordingsApi : IOrphanedRecordingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrphanedRecordingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrphanedRecordingsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrphanedRecordingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrphanedRecordingsApi(Configuration configuration = null)
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
        /// Gets all orphan recordings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <returns>OrphanRecordingListing</returns>
        public OrphanRecordingListing OrphanrecordingsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null)
        {
             ApiResponse<OrphanRecordingListing> localVarResponse = OrphanrecordingsGetWithHttpInfo(pageSize, pageNumber, sortBy, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets all orphan recordings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <returns>ApiResponse of OrphanRecordingListing</returns>
        public ApiResponse< OrphanRecordingListing > OrphanrecordingsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null)
        {

            var localVarPath = "/api/v1/orphanrecordings";
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
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OrphanrecordingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OrphanrecordingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecordingListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrphanRecordingListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecordingListing)));
            
        }

        /// <summary>
        /// Gets all orphan recordings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <returns>Task of OrphanRecordingListing</returns>
        public async System.Threading.Tasks.Task<OrphanRecordingListing> OrphanrecordingsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null)
        {
             ApiResponse<OrphanRecordingListing> localVarResponse = await OrphanrecordingsGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets all orphan recordings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <returns>Task of ApiResponse (OrphanRecordingListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrphanRecordingListing>> OrphanrecordingsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null)
        {

            var localVarPath = "/api/v1/orphanrecordings";
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
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OrphanrecordingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OrphanrecordingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecordingListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrphanRecordingListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecordingListing)));
            
        }

        /// <summary>
        ///  deletes a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>OrphanRecording</returns>
        public OrphanRecording OrphanrecordingsOrphanidDelete (string orphanId)
        {
             ApiResponse<OrphanRecording> localVarResponse = OrphanrecordingsOrphanidDeleteWithHttpInfo(orphanId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  deletes a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>ApiResponse of OrphanRecording</returns>
        public ApiResponse< OrphanRecording > OrphanrecordingsOrphanidDeleteWithHttpInfo (string orphanId)
        {
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling OrphanedRecordingsApi->OrphanrecordingsOrphanidDelete");

            var localVarPath = "/api/v1/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", Configuration.ApiClient.ParameterToString(orphanId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OrphanrecordingsOrphanidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OrphanrecordingsOrphanidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrphanRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecording)));
            
        }

        /// <summary>
        ///  deletes a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of OrphanRecording</returns>
        public async System.Threading.Tasks.Task<OrphanRecording> OrphanrecordingsOrphanidDeleteAsync (string orphanId)
        {
             ApiResponse<OrphanRecording> localVarResponse = await OrphanrecordingsOrphanidDeleteAsyncWithHttpInfo(orphanId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  deletes a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of ApiResponse (OrphanRecording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrphanRecording>> OrphanrecordingsOrphanidDeleteAsyncWithHttpInfo (string orphanId)
        {
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling OrphanedRecordingsApi->OrphanrecordingsOrphanidDelete");

            var localVarPath = "/api/v1/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", Configuration.ApiClient.ParameterToString(orphanId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OrphanrecordingsOrphanidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OrphanrecordingsOrphanidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrphanRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecording)));
            
        }

        /// <summary>
        /// Gets a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>OrphanRecording</returns>
        public OrphanRecording OrphanrecordingsOrphanidGet (string orphanId)
        {
             ApiResponse<OrphanRecording> localVarResponse = OrphanrecordingsOrphanidGetWithHttpInfo(orphanId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>ApiResponse of OrphanRecording</returns>
        public ApiResponse< OrphanRecording > OrphanrecordingsOrphanidGetWithHttpInfo (string orphanId)
        {
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling OrphanedRecordingsApi->OrphanrecordingsOrphanidGet");

            var localVarPath = "/api/v1/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", Configuration.ApiClient.ParameterToString(orphanId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OrphanrecordingsOrphanidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OrphanrecordingsOrphanidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrphanRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecording)));
            
        }

        /// <summary>
        /// Gets a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of OrphanRecording</returns>
        public async System.Threading.Tasks.Task<OrphanRecording> OrphanrecordingsOrphanidGetAsync (string orphanId)
        {
             ApiResponse<OrphanRecording> localVarResponse = await OrphanrecordingsOrphanidGetAsyncWithHttpInfo(orphanId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of ApiResponse (OrphanRecording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrphanRecording>> OrphanrecordingsOrphanidGetAsyncWithHttpInfo (string orphanId)
        {
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling OrphanedRecordingsApi->OrphanrecordingsOrphanidGet");

            var localVarPath = "/api/v1/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", Configuration.ApiClient.ParameterToString(orphanId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OrphanrecordingsOrphanidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OrphanrecordingsOrphanidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrphanRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecording)));
            
        }

    }
}
