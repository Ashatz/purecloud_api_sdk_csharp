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
    public interface IResponseManagementApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete an existing response library.
        /// </summary>
        /// <remarks>
        /// This will remove any responses associated with the library.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns></returns>
        void DeleteLibrariesLibraryId (string libraryId);

        /// <summary>
        /// Delete an existing response library.
        /// </summary>
        /// <remarks>
        /// This will remove any responses associated with the library.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLibrariesLibraryIdWithHttpInfo (string libraryId);
        /// <summary>
        /// Delete an existing response.
        /// </summary>
        /// <remarks>
        /// This will remove the response from any libraries associated with it.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns></returns>
        void DeleteResponsesResponseId (string responseId);

        /// <summary>
        /// Delete an existing response.
        /// </summary>
        /// <remarks>
        /// This will remove the response from any libraries associated with it.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteResponsesResponseIdWithHttpInfo (string responseId);
        /// <summary>
        /// Gets a list of existing response libraries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>LibraryEntityListing</returns>
        LibraryEntityListing GetLibraries (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a list of existing response libraries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of LibraryEntityListing</returns>
        ApiResponse<LibraryEntityListing> GetLibrariesWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Get details about an existing response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Library</returns>
        Library GetLibrariesLibraryId (string libraryId);

        /// <summary>
        /// Get details about an existing response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns>ApiResponse of Library</returns>
        ApiResponse<Library> GetLibrariesLibraryIdWithHttpInfo (string libraryId);
        /// <summary>
        /// Gets a list of existing responses.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ResponseEntityListing</returns>
        ResponseEntityListing GetResponses (string libraryId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a list of existing responses.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of ResponseEntityListing</returns>
        ApiResponse<ResponseEntityListing> GetResponsesWithHttpInfo (string libraryId, int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Get details about an existing response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns>Response</returns>
        Response GetResponsesResponseId (string responseId);

        /// <summary>
        /// Get details about an existing response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> GetResponsesResponseIdWithHttpInfo (string responseId);
        /// <summary>
        /// Create a response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Library</param>
        /// <returns>Library</returns>
        Library PostLibraries (Library body);

        /// <summary>
        /// Create a response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Library</param>
        /// <returns>ApiResponse of Library</returns>
        ApiResponse<Library> PostLibrariesWithHttpInfo (Library body);
        /// <summary>
        /// Create a response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>Response</returns>
        Response PostResponses (Response body);

        /// <summary>
        /// Create a response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> PostResponsesWithHttpInfo (Response body);
        /// <summary>
        /// Query responses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>ResponseQueryResults</returns>
        ResponseQueryResults PostResponsesQuery (ResponseQueryRequest body);

        /// <summary>
        /// Query responses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>ApiResponse of ResponseQueryResults</returns>
        ApiResponse<ResponseQueryResults> PostResponsesQueryWithHttpInfo (ResponseQueryRequest body);
        /// <summary>
        /// Update an existing response library.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name. The most recent version is required for updates.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>Library</returns>
        Library PutLibrariesLibraryId (string libraryId, Library body);

        /// <summary>
        /// Update an existing response library.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name. The most recent version is required for updates.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>ApiResponse of Library</returns>
        ApiResponse<Library> PutLibrariesLibraryIdWithHttpInfo (string libraryId, Library body);
        /// <summary>
        /// Update an existing response.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>Response</returns>
        Response PutResponsesResponseId (string responseId, Response body);

        /// <summary>
        /// Update an existing response.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> PutResponsesResponseIdWithHttpInfo (string responseId, Response body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete an existing response library.
        /// </summary>
        /// <remarks>
        /// This will remove any responses associated with the library.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLibrariesLibraryIdAsync (string libraryId);

        /// <summary>
        /// Delete an existing response library.
        /// </summary>
        /// <remarks>
        /// This will remove any responses associated with the library.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLibrariesLibraryIdAsyncWithHttpInfo (string libraryId);
        /// <summary>
        /// Delete an existing response.
        /// </summary>
        /// <remarks>
        /// This will remove the response from any libraries associated with it.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteResponsesResponseIdAsync (string responseId);

        /// <summary>
        /// Delete an existing response.
        /// </summary>
        /// <remarks>
        /// This will remove the response from any libraries associated with it.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteResponsesResponseIdAsyncWithHttpInfo (string responseId);
        /// <summary>
        /// Gets a list of existing response libraries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of LibraryEntityListing</returns>
        System.Threading.Tasks.Task<LibraryEntityListing> GetLibrariesAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a list of existing response libraries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (LibraryEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LibraryEntityListing>> GetLibrariesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Get details about an existing response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of Library</returns>
        System.Threading.Tasks.Task<Library> GetLibrariesLibraryIdAsync (string libraryId);

        /// <summary>
        /// Get details about an existing response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        System.Threading.Tasks.Task<ApiResponse<Library>> GetLibrariesLibraryIdAsyncWithHttpInfo (string libraryId);
        /// <summary>
        /// Gets a list of existing responses.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ResponseEntityListing</returns>
        System.Threading.Tasks.Task<ResponseEntityListing> GetResponsesAsync (string libraryId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a list of existing responses.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ResponseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseEntityListing>> GetResponsesAsyncWithHttpInfo (string libraryId, int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Get details about an existing response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> GetResponsesResponseIdAsync (string responseId);

        /// <summary>
        /// Get details about an existing response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> GetResponsesResponseIdAsyncWithHttpInfo (string responseId);
        /// <summary>
        /// Create a response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Library</param>
        /// <returns>Task of Library</returns>
        System.Threading.Tasks.Task<Library> PostLibrariesAsync (Library body);

        /// <summary>
        /// Create a response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Library</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        System.Threading.Tasks.Task<ApiResponse<Library>> PostLibrariesAsyncWithHttpInfo (Library body);
        /// <summary>
        /// Create a response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> PostResponsesAsync (Response body);

        /// <summary>
        /// Create a response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> PostResponsesAsyncWithHttpInfo (Response body);
        /// <summary>
        /// Query responses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>Task of ResponseQueryResults</returns>
        System.Threading.Tasks.Task<ResponseQueryResults> PostResponsesQueryAsync (ResponseQueryRequest body);

        /// <summary>
        /// Query responses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (ResponseQueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseQueryResults>> PostResponsesQueryAsyncWithHttpInfo (ResponseQueryRequest body);
        /// <summary>
        /// Update an existing response library.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name. The most recent version is required for updates.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>Task of Library</returns>
        System.Threading.Tasks.Task<Library> PutLibrariesLibraryIdAsync (string libraryId, Library body);

        /// <summary>
        /// Update an existing response library.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name. The most recent version is required for updates.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        System.Threading.Tasks.Task<ApiResponse<Library>> PutLibrariesLibraryIdAsyncWithHttpInfo (string libraryId, Library body);
        /// <summary>
        /// Update an existing response.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> PutResponsesResponseIdAsync (string responseId, Response body);

        /// <summary>
        /// Update an existing response.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> PutResponsesResponseIdAsyncWithHttpInfo (string responseId, Response body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ResponseManagementApi : IResponseManagementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ResponseManagementApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ResponseManagementApi(Configuration configuration = null)
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
        /// Delete an existing response library. This will remove any responses associated with the library.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns></returns>
        public void DeleteLibrariesLibraryId (string libraryId)
        {
             DeleteLibrariesLibraryIdWithHttpInfo(libraryId);
        }

        /// <summary>
        /// Delete an existing response library. This will remove any responses associated with the library.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLibrariesLibraryIdWithHttpInfo (string libraryId)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null)
                throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->DeleteLibrariesLibraryId");

            var localVarPath = "/api/v2/responsemanagement/libraries/{libraryId}";
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
            if (libraryId != null) localVarPathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLibrariesLibraryId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLibrariesLibraryId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete an existing response library. This will remove any responses associated with the library.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLibrariesLibraryIdAsync (string libraryId)
        {
             await DeleteLibrariesLibraryIdAsyncWithHttpInfo(libraryId);

        }

        /// <summary>
        /// Delete an existing response library. This will remove any responses associated with the library.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLibrariesLibraryIdAsyncWithHttpInfo (string libraryId)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null)
                throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->DeleteLibrariesLibraryId");

            var localVarPath = "/api/v2/responsemanagement/libraries/{libraryId}";
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
            if (libraryId != null) localVarPathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLibrariesLibraryId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLibrariesLibraryId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete an existing response. This will remove the response from any libraries associated with it.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns></returns>
        public void DeleteResponsesResponseId (string responseId)
        {
             DeleteResponsesResponseIdWithHttpInfo(responseId);
        }

        /// <summary>
        /// Delete an existing response. This will remove the response from any libraries associated with it.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteResponsesResponseIdWithHttpInfo (string responseId)
        {
            // verify the required parameter 'responseId' is set
            if (responseId == null)
                throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponseManagementApi->DeleteResponsesResponseId");

            var localVarPath = "/api/v2/responsemanagement/responses/{responseId}";
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
            if (responseId != null) localVarPathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteResponsesResponseId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteResponsesResponseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete an existing response. This will remove the response from any libraries associated with it.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteResponsesResponseIdAsync (string responseId)
        {
             await DeleteResponsesResponseIdAsyncWithHttpInfo(responseId);

        }

        /// <summary>
        /// Delete an existing response. This will remove the response from any libraries associated with it.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteResponsesResponseIdAsyncWithHttpInfo (string responseId)
        {
            // verify the required parameter 'responseId' is set
            if (responseId == null)
                throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponseManagementApi->DeleteResponsesResponseId");

            var localVarPath = "/api/v2/responsemanagement/responses/{responseId}";
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
            if (responseId != null) localVarPathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteResponsesResponseId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteResponsesResponseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Gets a list of existing response libraries. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>LibraryEntityListing</returns>
        public LibraryEntityListing GetLibraries (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<LibraryEntityListing> localVarResponse = GetLibrariesWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a list of existing response libraries. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of LibraryEntityListing</returns>
        public ApiResponse< LibraryEntityListing > GetLibrariesWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {

            var localVarPath = "/api/v2/responsemanagement/libraries";
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
                throw new ApiException (localVarStatusCode, "Error calling GetLibraries: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLibraries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LibraryEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LibraryEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LibraryEntityListing)));
            
        }

        /// <summary>
        /// Gets a list of existing response libraries. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of LibraryEntityListing</returns>
        public async System.Threading.Tasks.Task<LibraryEntityListing> GetLibrariesAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<LibraryEntityListing> localVarResponse = await GetLibrariesAsyncWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a list of existing response libraries. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (LibraryEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LibraryEntityListing>> GetLibrariesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {

            var localVarPath = "/api/v2/responsemanagement/libraries";
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
                throw new ApiException (localVarStatusCode, "Error calling GetLibraries: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLibraries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LibraryEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LibraryEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LibraryEntityListing)));
            
        }

        /// <summary>
        /// Get details about an existing response library. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Library</returns>
        public Library GetLibrariesLibraryId (string libraryId)
        {
             ApiResponse<Library> localVarResponse = GetLibrariesLibraryIdWithHttpInfo(libraryId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get details about an existing response library. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns>ApiResponse of Library</returns>
        public ApiResponse< Library > GetLibrariesLibraryIdWithHttpInfo (string libraryId)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null)
                throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->GetLibrariesLibraryId");

            var localVarPath = "/api/v2/responsemanagement/libraries/{libraryId}";
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
            if (libraryId != null) localVarPathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetLibrariesLibraryId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLibrariesLibraryId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Library>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Library)));
            
        }

        /// <summary>
        /// Get details about an existing response library. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of Library</returns>
        public async System.Threading.Tasks.Task<Library> GetLibrariesLibraryIdAsync (string libraryId)
        {
             ApiResponse<Library> localVarResponse = await GetLibrariesLibraryIdAsyncWithHttpInfo(libraryId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get details about an existing response library. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Library>> GetLibrariesLibraryIdAsyncWithHttpInfo (string libraryId)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null)
                throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->GetLibrariesLibraryId");

            var localVarPath = "/api/v2/responsemanagement/libraries/{libraryId}";
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
            if (libraryId != null) localVarPathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetLibrariesLibraryId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLibrariesLibraryId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Library>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Library)));
            
        }

        /// <summary>
        /// Gets a list of existing responses. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ResponseEntityListing</returns>
        public ResponseEntityListing GetResponses (string libraryId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ResponseEntityListing> localVarResponse = GetResponsesWithHttpInfo(libraryId, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a list of existing responses. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of ResponseEntityListing</returns>
        public ApiResponse< ResponseEntityListing > GetResponsesWithHttpInfo (string libraryId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null)
                throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->GetResponses");

            var localVarPath = "/api/v2/responsemanagement/responses";
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
            if (libraryId != null) localVarQueryParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetResponses: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetResponses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseEntityListing)));
            
        }

        /// <summary>
        /// Gets a list of existing responses. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ResponseEntityListing</returns>
        public async System.Threading.Tasks.Task<ResponseEntityListing> GetResponsesAsync (string libraryId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ResponseEntityListing> localVarResponse = await GetResponsesAsyncWithHttpInfo(libraryId, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a list of existing responses. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ResponseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseEntityListing>> GetResponsesAsyncWithHttpInfo (string libraryId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null)
                throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->GetResponses");

            var localVarPath = "/api/v2/responsemanagement/responses";
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
            if (libraryId != null) localVarQueryParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetResponses: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetResponses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseEntityListing)));
            
        }

        /// <summary>
        /// Get details about an existing response. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns>Response</returns>
        public Response GetResponsesResponseId (string responseId)
        {
             ApiResponse<Response> localVarResponse = GetResponsesResponseIdWithHttpInfo(responseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get details about an existing response. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > GetResponsesResponseIdWithHttpInfo (string responseId)
        {
            // verify the required parameter 'responseId' is set
            if (responseId == null)
                throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponseManagementApi->GetResponsesResponseId");

            var localVarPath = "/api/v2/responsemanagement/responses/{responseId}";
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
            if (responseId != null) localVarPathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetResponsesResponseId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetResponsesResponseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

        /// <summary>
        /// Get details about an existing response. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> GetResponsesResponseIdAsync (string responseId)
        {
             ApiResponse<Response> localVarResponse = await GetResponsesResponseIdAsyncWithHttpInfo(responseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get details about an existing response. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> GetResponsesResponseIdAsyncWithHttpInfo (string responseId)
        {
            // verify the required parameter 'responseId' is set
            if (responseId == null)
                throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponseManagementApi->GetResponsesResponseId");

            var localVarPath = "/api/v2/responsemanagement/responses/{responseId}";
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
            if (responseId != null) localVarPathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetResponsesResponseId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetResponsesResponseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

        /// <summary>
        /// Create a response library. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Library</param>
        /// <returns>Library</returns>
        public Library PostLibraries (Library body)
        {
             ApiResponse<Library> localVarResponse = PostLibrariesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a response library. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Library</param>
        /// <returns>ApiResponse of Library</returns>
        public ApiResponse< Library > PostLibrariesWithHttpInfo (Library body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostLibraries");

            var localVarPath = "/api/v2/responsemanagement/libraries";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLibraries: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLibraries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Library>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Library)));
            
        }

        /// <summary>
        /// Create a response library. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Library</param>
        /// <returns>Task of Library</returns>
        public async System.Threading.Tasks.Task<Library> PostLibrariesAsync (Library body)
        {
             ApiResponse<Library> localVarResponse = await PostLibrariesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a response library. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Library</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Library>> PostLibrariesAsyncWithHttpInfo (Library body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostLibraries");

            var localVarPath = "/api/v2/responsemanagement/libraries";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLibraries: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLibraries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Library>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Library)));
            
        }

        /// <summary>
        /// Create a response. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>Response</returns>
        public Response PostResponses (Response body)
        {
             ApiResponse<Response> localVarResponse = PostResponsesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a response. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > PostResponsesWithHttpInfo (Response body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponses");

            var localVarPath = "/api/v2/responsemanagement/responses";
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
                throw new ApiException (localVarStatusCode, "Error calling PostResponses: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostResponses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

        /// <summary>
        /// Create a response. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> PostResponsesAsync (Response body)
        {
             ApiResponse<Response> localVarResponse = await PostResponsesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a response. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> PostResponsesAsyncWithHttpInfo (Response body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponses");

            var localVarPath = "/api/v2/responsemanagement/responses";
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
                throw new ApiException (localVarStatusCode, "Error calling PostResponses: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostResponses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

        /// <summary>
        /// Query responses 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>ResponseQueryResults</returns>
        public ResponseQueryResults PostResponsesQuery (ResponseQueryRequest body)
        {
             ApiResponse<ResponseQueryResults> localVarResponse = PostResponsesQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query responses 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>ApiResponse of ResponseQueryResults</returns>
        public ApiResponse< ResponseQueryResults > PostResponsesQueryWithHttpInfo (ResponseQueryRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponsesQuery");

            var localVarPath = "/api/v2/responsemanagement/responses/query";
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
                throw new ApiException (localVarStatusCode, "Error calling PostResponsesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostResponsesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseQueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseQueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseQueryResults)));
            
        }

        /// <summary>
        /// Query responses 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>Task of ResponseQueryResults</returns>
        public async System.Threading.Tasks.Task<ResponseQueryResults> PostResponsesQueryAsync (ResponseQueryRequest body)
        {
             ApiResponse<ResponseQueryResults> localVarResponse = await PostResponsesQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query responses 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (ResponseQueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseQueryResults>> PostResponsesQueryAsyncWithHttpInfo (ResponseQueryRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PostResponsesQuery");

            var localVarPath = "/api/v2/responsemanagement/responses/query";
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
                throw new ApiException (localVarStatusCode, "Error calling PostResponsesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostResponsesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseQueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseQueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseQueryResults)));
            
        }

        /// <summary>
        /// Update an existing response library. Fields that can be updated: name. The most recent version is required for updates.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>Library</returns>
        public Library PutLibrariesLibraryId (string libraryId, Library body)
        {
             ApiResponse<Library> localVarResponse = PutLibrariesLibraryIdWithHttpInfo(libraryId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing response library. Fields that can be updated: name. The most recent version is required for updates.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>ApiResponse of Library</returns>
        public ApiResponse< Library > PutLibrariesLibraryIdWithHttpInfo (string libraryId, Library body)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null)
                throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->PutLibrariesLibraryId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PutLibrariesLibraryId");

            var localVarPath = "/api/v2/responsemanagement/libraries/{libraryId}";
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
            if (libraryId != null) localVarPathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PutLibrariesLibraryId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutLibrariesLibraryId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Library>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Library)));
            
        }

        /// <summary>
        /// Update an existing response library. Fields that can be updated: name. The most recent version is required for updates.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>Task of Library</returns>
        public async System.Threading.Tasks.Task<Library> PutLibrariesLibraryIdAsync (string libraryId, Library body)
        {
             ApiResponse<Library> localVarResponse = await PutLibrariesLibraryIdAsyncWithHttpInfo(libraryId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an existing response library. Fields that can be updated: name. The most recent version is required for updates.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Library>> PutLibrariesLibraryIdAsyncWithHttpInfo (string libraryId, Library body)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null)
                throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->PutLibrariesLibraryId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PutLibrariesLibraryId");

            var localVarPath = "/api/v2/responsemanagement/libraries/{libraryId}";
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
            if (libraryId != null) localVarPathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PutLibrariesLibraryId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutLibrariesLibraryId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Library>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Library)));
            
        }

        /// <summary>
        /// Update an existing response. Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>Response</returns>
        public Response PutResponsesResponseId (string responseId, Response body)
        {
             ApiResponse<Response> localVarResponse = PutResponsesResponseIdWithHttpInfo(responseId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing response. Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > PutResponsesResponseIdWithHttpInfo (string responseId, Response body)
        {
            // verify the required parameter 'responseId' is set
            if (responseId == null)
                throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponseManagementApi->PutResponsesResponseId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PutResponsesResponseId");

            var localVarPath = "/api/v2/responsemanagement/responses/{responseId}";
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
            if (responseId != null) localVarPathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PutResponsesResponseId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutResponsesResponseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

        /// <summary>
        /// Update an existing response. Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> PutResponsesResponseIdAsync (string responseId, Response body)
        {
             ApiResponse<Response> localVarResponse = await PutResponsesResponseIdAsyncWithHttpInfo(responseId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an existing response. Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> PutResponsesResponseIdAsyncWithHttpInfo (string responseId, Response body)
        {
            // verify the required parameter 'responseId' is set
            if (responseId == null)
                throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponseManagementApi->PutResponsesResponseId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ResponseManagementApi->PutResponsesResponseId");

            var localVarPath = "/api/v2/responsemanagement/responses/{responseId}";
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
            if (responseId != null) localVarPathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PutResponsesResponseId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutResponsesResponseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

    }
}
