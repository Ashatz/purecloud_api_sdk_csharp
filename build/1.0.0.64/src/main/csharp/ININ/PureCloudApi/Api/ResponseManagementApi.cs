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
    public interface IResponseManagementApi
    {
        
        /// <summary>
        /// Gets a list of existing response libraries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>LibraryEntityListing</returns>
        LibraryEntityListing ResponsemanagementLibrariesGet (int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Gets a list of existing response libraries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of LibraryEntityListing</returns>
        ApiResponse<LibraryEntityListing> ResponsemanagementLibrariesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a list of existing response libraries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of LibraryEntityListing</returns>
        System.Threading.Tasks.Task<LibraryEntityListing> ResponsemanagementLibrariesGetAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a list of existing response libraries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (LibraryEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LibraryEntityListing>> ResponsemanagementLibrariesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Create a response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Library</param>
        /// <returns>Library</returns>
        Library ResponsemanagementLibrariesPost (Library body = null);
  
        /// <summary>
        /// Create a response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Library</param>
        /// <returns>ApiResponse of Library</returns>
        ApiResponse<Library> ResponsemanagementLibrariesPostWithHttpInfo (Library body = null);

        /// <summary>
        /// Create a response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Library</param>
        /// <returns>Task of Library</returns>
        System.Threading.Tasks.Task<Library> ResponsemanagementLibrariesPostAsync (Library body = null);

        /// <summary>
        /// Create a response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Library</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        System.Threading.Tasks.Task<ApiResponse<Library>> ResponsemanagementLibrariesPostAsyncWithHttpInfo (Library body = null);
        
        /// <summary>
        /// Get details about an existing response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Library</returns>
        Library ResponsemanagementLibrariesLibraryidGet (string libraryId);
  
        /// <summary>
        /// Get details about an existing response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns>ApiResponse of Library</returns>
        ApiResponse<Library> ResponsemanagementLibrariesLibraryidGetWithHttpInfo (string libraryId);

        /// <summary>
        /// Get details about an existing response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of Library</returns>
        System.Threading.Tasks.Task<Library> ResponsemanagementLibrariesLibraryidGetAsync (string libraryId);

        /// <summary>
        /// Get details about an existing response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        System.Threading.Tasks.Task<ApiResponse<Library>> ResponsemanagementLibrariesLibraryidGetAsyncWithHttpInfo (string libraryId);
        
        /// <summary>
        /// Update an existing response library.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name. The most recent version is required for updates.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>Library</returns>
        Library ResponsemanagementLibrariesLibraryidPut (string libraryId, Library body = null);
  
        /// <summary>
        /// Update an existing response library.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name. The most recent version is required for updates.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>ApiResponse of Library</returns>
        ApiResponse<Library> ResponsemanagementLibrariesLibraryidPutWithHttpInfo (string libraryId, Library body = null);

        /// <summary>
        /// Update an existing response library.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name. The most recent version is required for updates.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>Task of Library</returns>
        System.Threading.Tasks.Task<Library> ResponsemanagementLibrariesLibraryidPutAsync (string libraryId, Library body = null);

        /// <summary>
        /// Update an existing response library.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name. The most recent version is required for updates.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        System.Threading.Tasks.Task<ApiResponse<Library>> ResponsemanagementLibrariesLibraryidPutAsyncWithHttpInfo (string libraryId, Library body = null);
        
        /// <summary>
        /// Delete an existing response library.
        /// </summary>
        /// <remarks>
        /// This will remove any responses associated with the library.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns></returns>
        void ResponsemanagementLibrariesLibraryidDelete (string libraryId);
  
        /// <summary>
        /// Delete an existing response library.
        /// </summary>
        /// <remarks>
        /// This will remove any responses associated with the library.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ResponsemanagementLibrariesLibraryidDeleteWithHttpInfo (string libraryId);

        /// <summary>
        /// Delete an existing response library.
        /// </summary>
        /// <remarks>
        /// This will remove any responses associated with the library.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ResponsemanagementLibrariesLibraryidDeleteAsync (string libraryId);

        /// <summary>
        /// Delete an existing response library.
        /// </summary>
        /// <remarks>
        /// This will remove any responses associated with the library.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ResponsemanagementLibrariesLibraryidDeleteAsyncWithHttpInfo (string libraryId);
        
        /// <summary>
        /// Gets a list of existing responses.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ResponseEntityListing</returns>
        ResponseEntityListing ResponsemanagementResponsesGet (string libraryId, int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Gets a list of existing responses.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of ResponseEntityListing</returns>
        ApiResponse<ResponseEntityListing> ResponsemanagementResponsesGetWithHttpInfo (string libraryId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a list of existing responses.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ResponseEntityListing</returns>
        System.Threading.Tasks.Task<ResponseEntityListing> ResponsemanagementResponsesGetAsync (string libraryId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a list of existing responses.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (ResponseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseEntityListing>> ResponsemanagementResponsesGetAsyncWithHttpInfo (string libraryId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Create a response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>Response</returns>
        Response ResponsemanagementResponsesPost (Response body = null);
  
        /// <summary>
        /// Create a response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> ResponsemanagementResponsesPostWithHttpInfo (Response body = null);

        /// <summary>
        /// Create a response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> ResponsemanagementResponsesPostAsync (Response body = null);

        /// <summary>
        /// Create a response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> ResponsemanagementResponsesPostAsyncWithHttpInfo (Response body = null);
        
        /// <summary>
        /// Query responses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>ResponseQueryResults</returns>
        ResponseQueryResults ResponsemanagementResponsesQueryPost (ResponseQueryRequest body = null);
  
        /// <summary>
        /// Query responses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>ApiResponse of ResponseQueryResults</returns>
        ApiResponse<ResponseQueryResults> ResponsemanagementResponsesQueryPostWithHttpInfo (ResponseQueryRequest body = null);

        /// <summary>
        /// Query responses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>Task of ResponseQueryResults</returns>
        System.Threading.Tasks.Task<ResponseQueryResults> ResponsemanagementResponsesQueryPostAsync (ResponseQueryRequest body = null);

        /// <summary>
        /// Query responses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (ResponseQueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseQueryResults>> ResponsemanagementResponsesQueryPostAsyncWithHttpInfo (ResponseQueryRequest body = null);
        
        /// <summary>
        /// Get details about an existing response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns>Response</returns>
        Response ResponsemanagementResponsesResponseidGet (string responseId);
  
        /// <summary>
        /// Get details about an existing response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> ResponsemanagementResponsesResponseidGetWithHttpInfo (string responseId);

        /// <summary>
        /// Get details about an existing response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> ResponsemanagementResponsesResponseidGetAsync (string responseId);

        /// <summary>
        /// Get details about an existing response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> ResponsemanagementResponsesResponseidGetAsyncWithHttpInfo (string responseId);
        
        /// <summary>
        /// Update an existing response.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>Response</returns>
        Response ResponsemanagementResponsesResponseidPut (string responseId, Response body = null);
  
        /// <summary>
        /// Update an existing response.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> ResponsemanagementResponsesResponseidPutWithHttpInfo (string responseId, Response body = null);

        /// <summary>
        /// Update an existing response.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> ResponsemanagementResponsesResponseidPutAsync (string responseId, Response body = null);

        /// <summary>
        /// Update an existing response.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> ResponsemanagementResponsesResponseidPutAsyncWithHttpInfo (string responseId, Response body = null);
        
        /// <summary>
        /// Delete an existing response.
        /// </summary>
        /// <remarks>
        /// This will remove the response from any libraries associated with it.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns></returns>
        void ResponsemanagementResponsesResponseidDelete (string responseId);
  
        /// <summary>
        /// Delete an existing response.
        /// </summary>
        /// <remarks>
        /// This will remove the response from any libraries associated with it.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ResponsemanagementResponsesResponseidDeleteWithHttpInfo (string responseId);

        /// <summary>
        /// Delete an existing response.
        /// </summary>
        /// <remarks>
        /// This will remove the response from any libraries associated with it.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ResponsemanagementResponsesResponseidDeleteAsync (string responseId);

        /// <summary>
        /// Delete an existing response.
        /// </summary>
        /// <remarks>
        /// This will remove the response from any libraries associated with it.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ResponsemanagementResponsesResponseidDeleteAsyncWithHttpInfo (string responseId);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ResponseManagementApi : IResponseManagementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ResponseManagementApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
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
        /// Gets a list of existing response libraries. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>LibraryEntityListing</returns>
        public LibraryEntityListing ResponsemanagementLibrariesGet (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<LibraryEntityListing> response = ResponsemanagementLibrariesGetWithHttpInfo(pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of existing response libraries. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of LibraryEntityListing</returns>
        public ApiResponse< LibraryEntityListing > ResponsemanagementLibrariesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/libraries";
    
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LibraryEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LibraryEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LibraryEntityListing)));
            
        }
    
        /// <summary>
        /// Gets a list of existing response libraries. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of LibraryEntityListing</returns>
        public async System.Threading.Tasks.Task<LibraryEntityListing> ResponsemanagementLibrariesGetAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<LibraryEntityListing> response = await ResponsemanagementLibrariesGetAsyncWithHttpInfo(pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of existing response libraries. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (LibraryEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LibraryEntityListing>> ResponsemanagementLibrariesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/libraries";
    
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LibraryEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LibraryEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LibraryEntityListing)));
            
        }
        
        /// <summary>
        /// Create a response library. 
        /// </summary>
        /// <param name="body">Library</param> 
        /// <returns>Library</returns>
        public Library ResponsemanagementLibrariesPost (Library body = null)
        {
             ApiResponse<Library> response = ResponsemanagementLibrariesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a response library. 
        /// </summary>
        /// <param name="body">Library</param> 
        /// <returns>ApiResponse of Library</returns>
        public ApiResponse< Library > ResponsemanagementLibrariesPostWithHttpInfo (Library body = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/libraries";
    
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Library>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(response, typeof(Library)));
            
        }
    
        /// <summary>
        /// Create a response library. 
        /// </summary>
        /// <param name="body">Library</param>
        /// <returns>Task of Library</returns>
        public async System.Threading.Tasks.Task<Library> ResponsemanagementLibrariesPostAsync (Library body = null)
        {
             ApiResponse<Library> response = await ResponsemanagementLibrariesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a response library. 
        /// </summary>
        /// <param name="body">Library</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Library>> ResponsemanagementLibrariesPostAsyncWithHttpInfo (Library body = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/libraries";
    
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Library>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(response, typeof(Library)));
            
        }
        
        /// <summary>
        /// Get details about an existing response library. 
        /// </summary>
        /// <param name="libraryId">Library ID</param> 
        /// <returns>Library</returns>
        public Library ResponsemanagementLibrariesLibraryidGet (string libraryId)
        {
             ApiResponse<Library> response = ResponsemanagementLibrariesLibraryidGetWithHttpInfo(libraryId);
             return response.Data;
        }

        /// <summary>
        /// Get details about an existing response library. 
        /// </summary>
        /// <param name="libraryId">Library ID</param> 
        /// <returns>ApiResponse of Library</returns>
        public ApiResponse< Library > ResponsemanagementLibrariesLibraryidGetWithHttpInfo (string libraryId)
        {
            
            // verify the required parameter 'libraryId' is set
            if (libraryId == null) throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponsemanagementLibrariesLibraryidGet");
            
    
            var path_ = "/api/v1/responsemanagement/libraries/{libraryId}";
    
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
            if (libraryId != null) pathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesLibraryidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesLibraryidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Library>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(response, typeof(Library)));
            
        }
    
        /// <summary>
        /// Get details about an existing response library. 
        /// </summary>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of Library</returns>
        public async System.Threading.Tasks.Task<Library> ResponsemanagementLibrariesLibraryidGetAsync (string libraryId)
        {
             ApiResponse<Library> response = await ResponsemanagementLibrariesLibraryidGetAsyncWithHttpInfo(libraryId);
             return response.Data;

        }

        /// <summary>
        /// Get details about an existing response library. 
        /// </summary>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Library>> ResponsemanagementLibrariesLibraryidGetAsyncWithHttpInfo (string libraryId)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null) throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponsemanagementLibrariesLibraryidGet");
            
    
            var path_ = "/api/v1/responsemanagement/libraries/{libraryId}";
    
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
            if (libraryId != null) pathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesLibraryidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesLibraryidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Library>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(response, typeof(Library)));
            
        }
        
        /// <summary>
        /// Update an existing response library. Fields that can be updated: name. The most recent version is required for updates.
        /// </summary>
        /// <param name="libraryId">Library ID</param> 
        /// <param name="body">Library</param> 
        /// <returns>Library</returns>
        public Library ResponsemanagementLibrariesLibraryidPut (string libraryId, Library body = null)
        {
             ApiResponse<Library> response = ResponsemanagementLibrariesLibraryidPutWithHttpInfo(libraryId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an existing response library. Fields that can be updated: name. The most recent version is required for updates.
        /// </summary>
        /// <param name="libraryId">Library ID</param> 
        /// <param name="body">Library</param> 
        /// <returns>ApiResponse of Library</returns>
        public ApiResponse< Library > ResponsemanagementLibrariesLibraryidPutWithHttpInfo (string libraryId, Library body = null)
        {
            
            // verify the required parameter 'libraryId' is set
            if (libraryId == null) throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponsemanagementLibrariesLibraryidPut");
            
    
            var path_ = "/api/v1/responsemanagement/libraries/{libraryId}";
    
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
            if (libraryId != null) pathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesLibraryidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesLibraryidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Library>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(response, typeof(Library)));
            
        }
    
        /// <summary>
        /// Update an existing response library. Fields that can be updated: name. The most recent version is required for updates.
        /// </summary>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>Task of Library</returns>
        public async System.Threading.Tasks.Task<Library> ResponsemanagementLibrariesLibraryidPutAsync (string libraryId, Library body = null)
        {
             ApiResponse<Library> response = await ResponsemanagementLibrariesLibraryidPutAsyncWithHttpInfo(libraryId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an existing response library. Fields that can be updated: name. The most recent version is required for updates.
        /// </summary>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Library>> ResponsemanagementLibrariesLibraryidPutAsyncWithHttpInfo (string libraryId, Library body = null)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null) throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponsemanagementLibrariesLibraryidPut");
            
    
            var path_ = "/api/v1/responsemanagement/libraries/{libraryId}";
    
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
            if (libraryId != null) pathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesLibraryidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesLibraryidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Library>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(response, typeof(Library)));
            
        }
        
        /// <summary>
        /// Delete an existing response library. This will remove any responses associated with the library.
        /// </summary>
        /// <param name="libraryId">Library ID</param> 
        /// <returns></returns>
        public void ResponsemanagementLibrariesLibraryidDelete (string libraryId)
        {
             ResponsemanagementLibrariesLibraryidDeleteWithHttpInfo(libraryId);
        }

        /// <summary>
        /// Delete an existing response library. This will remove any responses associated with the library.
        /// </summary>
        /// <param name="libraryId">Library ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ResponsemanagementLibrariesLibraryidDeleteWithHttpInfo (string libraryId)
        {
            
            // verify the required parameter 'libraryId' is set
            if (libraryId == null) throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponsemanagementLibrariesLibraryidDelete");
            
    
            var path_ = "/api/v1/responsemanagement/libraries/{libraryId}";
    
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
            if (libraryId != null) pathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesLibraryidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesLibraryidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an existing response library. This will remove any responses associated with the library.
        /// </summary>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ResponsemanagementLibrariesLibraryidDeleteAsync (string libraryId)
        {
             await ResponsemanagementLibrariesLibraryidDeleteAsyncWithHttpInfo(libraryId);

        }

        /// <summary>
        /// Delete an existing response library. This will remove any responses associated with the library.
        /// </summary>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ResponsemanagementLibrariesLibraryidDeleteAsyncWithHttpInfo (string libraryId)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null) throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponsemanagementLibrariesLibraryidDelete");
            
    
            var path_ = "/api/v1/responsemanagement/libraries/{libraryId}";
    
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
            if (libraryId != null) pathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesLibraryidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementLibrariesLibraryidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Gets a list of existing responses. 
        /// </summary>
        /// <param name="libraryId">Library ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ResponseEntityListing</returns>
        public ResponseEntityListing ResponsemanagementResponsesGet (string libraryId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ResponseEntityListing> response = ResponsemanagementResponsesGetWithHttpInfo(libraryId, pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of existing responses. 
        /// </summary>
        /// <param name="libraryId">Library ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of ResponseEntityListing</returns>
        public ApiResponse< ResponseEntityListing > ResponsemanagementResponsesGetWithHttpInfo (string libraryId, int? pageNumber = null, int? pageSize = null)
        {
            
            // verify the required parameter 'libraryId' is set
            if (libraryId == null) throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponsemanagementResponsesGet");
            
    
            var path_ = "/api/v1/responsemanagement/responses";
    
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
            
            if (libraryId != null) queryParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // query parameter
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ResponseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ResponseEntityListing)));
            
        }
    
        /// <summary>
        /// Gets a list of existing responses. 
        /// </summary>
        /// <param name="libraryId">Library ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ResponseEntityListing</returns>
        public async System.Threading.Tasks.Task<ResponseEntityListing> ResponsemanagementResponsesGetAsync (string libraryId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ResponseEntityListing> response = await ResponsemanagementResponsesGetAsyncWithHttpInfo(libraryId, pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of existing responses. 
        /// </summary>
        /// <param name="libraryId">Library ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (ResponseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseEntityListing>> ResponsemanagementResponsesGetAsyncWithHttpInfo (string libraryId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null) throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponsemanagementResponsesGet");
            
    
            var path_ = "/api/v1/responsemanagement/responses";
    
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
            
            if (libraryId != null) queryParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // query parameter
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ResponseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ResponseEntityListing)));
            
        }
        
        /// <summary>
        /// Create a response. 
        /// </summary>
        /// <param name="body">Response</param> 
        /// <returns>Response</returns>
        public Response ResponsemanagementResponsesPost (Response body = null)
        {
             ApiResponse<Response> response = ResponsemanagementResponsesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a response. 
        /// </summary>
        /// <param name="body">Response</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > ResponsemanagementResponsesPostWithHttpInfo (Response body = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/responses";
    
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Response>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(response, typeof(Response)));
            
        }
    
        /// <summary>
        /// Create a response. 
        /// </summary>
        /// <param name="body">Response</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> ResponsemanagementResponsesPostAsync (Response body = null)
        {
             ApiResponse<Response> response = await ResponsemanagementResponsesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a response. 
        /// </summary>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> ResponsemanagementResponsesPostAsyncWithHttpInfo (Response body = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/responses";
    
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Response>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(response, typeof(Response)));
            
        }
        
        /// <summary>
        /// Query responses 
        /// </summary>
        /// <param name="body">Response</param> 
        /// <returns>ResponseQueryResults</returns>
        public ResponseQueryResults ResponsemanagementResponsesQueryPost (ResponseQueryRequest body = null)
        {
             ApiResponse<ResponseQueryResults> response = ResponsemanagementResponsesQueryPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Query responses 
        /// </summary>
        /// <param name="body">Response</param> 
        /// <returns>ApiResponse of ResponseQueryResults</returns>
        public ApiResponse< ResponseQueryResults > ResponsemanagementResponsesQueryPostWithHttpInfo (ResponseQueryRequest body = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/responses/query";
    
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesQueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesQueryPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ResponseQueryResults>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseQueryResults) Configuration.ApiClient.Deserialize(response, typeof(ResponseQueryResults)));
            
        }
    
        /// <summary>
        /// Query responses 
        /// </summary>
        /// <param name="body">Response</param>
        /// <returns>Task of ResponseQueryResults</returns>
        public async System.Threading.Tasks.Task<ResponseQueryResults> ResponsemanagementResponsesQueryPostAsync (ResponseQueryRequest body = null)
        {
             ApiResponse<ResponseQueryResults> response = await ResponsemanagementResponsesQueryPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Query responses 
        /// </summary>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (ResponseQueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseQueryResults>> ResponsemanagementResponsesQueryPostAsyncWithHttpInfo (ResponseQueryRequest body = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/responses/query";
    
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesQueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesQueryPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ResponseQueryResults>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseQueryResults) Configuration.ApiClient.Deserialize(response, typeof(ResponseQueryResults)));
            
        }
        
        /// <summary>
        /// Get details about an existing response. 
        /// </summary>
        /// <param name="responseId">Response ID</param> 
        /// <returns>Response</returns>
        public Response ResponsemanagementResponsesResponseidGet (string responseId)
        {
             ApiResponse<Response> response = ResponsemanagementResponsesResponseidGetWithHttpInfo(responseId);
             return response.Data;
        }

        /// <summary>
        /// Get details about an existing response. 
        /// </summary>
        /// <param name="responseId">Response ID</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > ResponsemanagementResponsesResponseidGetWithHttpInfo (string responseId)
        {
            
            // verify the required parameter 'responseId' is set
            if (responseId == null) throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponsemanagementResponsesResponseidGet");
            
    
            var path_ = "/api/v1/responsemanagement/responses/{responseId}";
    
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
            if (responseId != null) pathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesResponseidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesResponseidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Response>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(response, typeof(Response)));
            
        }
    
        /// <summary>
        /// Get details about an existing response. 
        /// </summary>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> ResponsemanagementResponsesResponseidGetAsync (string responseId)
        {
             ApiResponse<Response> response = await ResponsemanagementResponsesResponseidGetAsyncWithHttpInfo(responseId);
             return response.Data;

        }

        /// <summary>
        /// Get details about an existing response. 
        /// </summary>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> ResponsemanagementResponsesResponseidGetAsyncWithHttpInfo (string responseId)
        {
            // verify the required parameter 'responseId' is set
            if (responseId == null) throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponsemanagementResponsesResponseidGet");
            
    
            var path_ = "/api/v1/responsemanagement/responses/{responseId}";
    
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
            if (responseId != null) pathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesResponseidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesResponseidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Response>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(response, typeof(Response)));
            
        }
        
        /// <summary>
        /// Update an existing response. Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </summary>
        /// <param name="responseId">Response ID</param> 
        /// <param name="body">Response</param> 
        /// <returns>Response</returns>
        public Response ResponsemanagementResponsesResponseidPut (string responseId, Response body = null)
        {
             ApiResponse<Response> response = ResponsemanagementResponsesResponseidPutWithHttpInfo(responseId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an existing response. Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </summary>
        /// <param name="responseId">Response ID</param> 
        /// <param name="body">Response</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > ResponsemanagementResponsesResponseidPutWithHttpInfo (string responseId, Response body = null)
        {
            
            // verify the required parameter 'responseId' is set
            if (responseId == null) throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponsemanagementResponsesResponseidPut");
            
    
            var path_ = "/api/v1/responsemanagement/responses/{responseId}";
    
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
            if (responseId != null) pathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesResponseidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesResponseidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Response>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(response, typeof(Response)));
            
        }
    
        /// <summary>
        /// Update an existing response. Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </summary>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> ResponsemanagementResponsesResponseidPutAsync (string responseId, Response body = null)
        {
             ApiResponse<Response> response = await ResponsemanagementResponsesResponseidPutAsyncWithHttpInfo(responseId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an existing response. Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </summary>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> ResponsemanagementResponsesResponseidPutAsyncWithHttpInfo (string responseId, Response body = null)
        {
            // verify the required parameter 'responseId' is set
            if (responseId == null) throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponsemanagementResponsesResponseidPut");
            
    
            var path_ = "/api/v1/responsemanagement/responses/{responseId}";
    
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
            if (responseId != null) pathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesResponseidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesResponseidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Response>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(response, typeof(Response)));
            
        }
        
        /// <summary>
        /// Delete an existing response. This will remove the response from any libraries associated with it.
        /// </summary>
        /// <param name="responseId">Response ID</param> 
        /// <returns></returns>
        public void ResponsemanagementResponsesResponseidDelete (string responseId)
        {
             ResponsemanagementResponsesResponseidDeleteWithHttpInfo(responseId);
        }

        /// <summary>
        /// Delete an existing response. This will remove the response from any libraries associated with it.
        /// </summary>
        /// <param name="responseId">Response ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ResponsemanagementResponsesResponseidDeleteWithHttpInfo (string responseId)
        {
            
            // verify the required parameter 'responseId' is set
            if (responseId == null) throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponsemanagementResponsesResponseidDelete");
            
    
            var path_ = "/api/v1/responsemanagement/responses/{responseId}";
    
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
            if (responseId != null) pathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesResponseidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesResponseidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an existing response. This will remove the response from any libraries associated with it.
        /// </summary>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ResponsemanagementResponsesResponseidDeleteAsync (string responseId)
        {
             await ResponsemanagementResponsesResponseidDeleteAsyncWithHttpInfo(responseId);

        }

        /// <summary>
        /// Delete an existing response. This will remove the response from any libraries associated with it.
        /// </summary>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ResponsemanagementResponsesResponseidDeleteAsyncWithHttpInfo (string responseId)
        {
            // verify the required parameter 'responseId' is set
            if (responseId == null) throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponsemanagementResponsesResponseidDelete");
            
    
            var path_ = "/api/v1/responsemanagement/responses/{responseId}";
    
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
            if (responseId != null) pathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesResponseidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ResponsemanagementResponsesResponseidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
