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
        LibraryEntityListing GetLibraries (int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Gets a list of existing response libraries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of LibraryEntityListing</returns>
        ApiResponse<LibraryEntityListing> GetLibrariesWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a list of existing response libraries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of LibraryEntityListing</returns>
        System.Threading.Tasks.Task<LibraryEntityListing> GetLibrariesAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a list of existing response libraries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (LibraryEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LibraryEntityListing>> GetLibrariesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Create a response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Library</param>
        /// <returns>Library</returns>
        Library PostLibraries (Library body = null);
  
        /// <summary>
        /// Create a response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Library</param>
        /// <returns>ApiResponse of Library</returns>
        ApiResponse<Library> PostLibrariesWithHttpInfo (Library body = null);

        /// <summary>
        /// Create a response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Library</param>
        /// <returns>Task of Library</returns>
        System.Threading.Tasks.Task<Library> PostLibrariesAsync (Library body = null);

        /// <summary>
        /// Create a response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Library</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        System.Threading.Tasks.Task<ApiResponse<Library>> PostLibrariesAsyncWithHttpInfo (Library body = null);
        
        /// <summary>
        /// Get details about an existing response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Library</returns>
        Library GetLibrariesLibraryId (string libraryId);
  
        /// <summary>
        /// Get details about an existing response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns>ApiResponse of Library</returns>
        ApiResponse<Library> GetLibrariesLibraryIdWithHttpInfo (string libraryId);

        /// <summary>
        /// Get details about an existing response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of Library</returns>
        System.Threading.Tasks.Task<Library> GetLibrariesLibraryIdAsync (string libraryId);

        /// <summary>
        /// Get details about an existing response library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        System.Threading.Tasks.Task<ApiResponse<Library>> GetLibrariesLibraryIdAsyncWithHttpInfo (string libraryId);
        
        /// <summary>
        /// Update an existing response library.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name. The most recent version is required for updates.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>Library</returns>
        Library PutLibrariesLibraryId (string libraryId, Library body = null);
  
        /// <summary>
        /// Update an existing response library.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name. The most recent version is required for updates.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>ApiResponse of Library</returns>
        ApiResponse<Library> PutLibrariesLibraryIdWithHttpInfo (string libraryId, Library body = null);

        /// <summary>
        /// Update an existing response library.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name. The most recent version is required for updates.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>Task of Library</returns>
        System.Threading.Tasks.Task<Library> PutLibrariesLibraryIdAsync (string libraryId, Library body = null);

        /// <summary>
        /// Update an existing response library.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name. The most recent version is required for updates.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        System.Threading.Tasks.Task<ApiResponse<Library>> PutLibrariesLibraryIdAsyncWithHttpInfo (string libraryId, Library body = null);
        
        /// <summary>
        /// Delete an existing response library.
        /// </summary>
        /// <remarks>
        /// This will remove any responses associated with the library.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns></returns>
        void DeleteLibrariesLibraryId (string libraryId);
  
        /// <summary>
        /// Delete an existing response library.
        /// </summary>
        /// <remarks>
        /// This will remove any responses associated with the library.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLibrariesLibraryIdWithHttpInfo (string libraryId);

        /// <summary>
        /// Delete an existing response library.
        /// </summary>
        /// <remarks>
        /// This will remove any responses associated with the library.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLibrariesLibraryIdAsync (string libraryId);

        /// <summary>
        /// Delete an existing response library.
        /// </summary>
        /// <remarks>
        /// This will remove any responses associated with the library.
        /// </remarks>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLibrariesLibraryIdAsyncWithHttpInfo (string libraryId);
        
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
        ResponseEntityListing GetResponses (string libraryId, int? pageNumber = null, int? pageSize = null);
  
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
        ApiResponse<ResponseEntityListing> GetResponsesWithHttpInfo (string libraryId, int? pageNumber = null, int? pageSize = null);

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
        System.Threading.Tasks.Task<ResponseEntityListing> GetResponsesAsync (string libraryId, int? pageNumber = null, int? pageSize = null);

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
        System.Threading.Tasks.Task<ApiResponse<ResponseEntityListing>> GetResponsesAsyncWithHttpInfo (string libraryId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Create a response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>Response</returns>
        Response PostResponses (Response body = null);
  
        /// <summary>
        /// Create a response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> PostResponsesWithHttpInfo (Response body = null);

        /// <summary>
        /// Create a response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> PostResponsesAsync (Response body = null);

        /// <summary>
        /// Create a response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> PostResponsesAsyncWithHttpInfo (Response body = null);
        
        /// <summary>
        /// Query responses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>ResponseQueryResults</returns>
        ResponseQueryResults PostResponsesQuery (ResponseQueryRequest body = null);
  
        /// <summary>
        /// Query responses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>ApiResponse of ResponseQueryResults</returns>
        ApiResponse<ResponseQueryResults> PostResponsesQueryWithHttpInfo (ResponseQueryRequest body = null);

        /// <summary>
        /// Query responses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>Task of ResponseQueryResults</returns>
        System.Threading.Tasks.Task<ResponseQueryResults> PostResponsesQueryAsync (ResponseQueryRequest body = null);

        /// <summary>
        /// Query responses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (ResponseQueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseQueryResults>> PostResponsesQueryAsyncWithHttpInfo (ResponseQueryRequest body = null);
        
        /// <summary>
        /// Get details about an existing response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns>Response</returns>
        Response GetResponsesResponseId (string responseId);
  
        /// <summary>
        /// Get details about an existing response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> GetResponsesResponseIdWithHttpInfo (string responseId);

        /// <summary>
        /// Get details about an existing response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> GetResponsesResponseIdAsync (string responseId);

        /// <summary>
        /// Get details about an existing response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> GetResponsesResponseIdAsyncWithHttpInfo (string responseId);
        
        /// <summary>
        /// Update an existing response.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>Response</returns>
        Response PutResponsesResponseId (string responseId, Response body = null);
  
        /// <summary>
        /// Update an existing response.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> PutResponsesResponseIdWithHttpInfo (string responseId, Response body = null);

        /// <summary>
        /// Update an existing response.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> PutResponsesResponseIdAsync (string responseId, Response body = null);

        /// <summary>
        /// Update an existing response.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> PutResponsesResponseIdAsyncWithHttpInfo (string responseId, Response body = null);
        
        /// <summary>
        /// Delete an existing response.
        /// </summary>
        /// <remarks>
        /// This will remove the response from any libraries associated with it.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns></returns>
        void DeleteResponsesResponseId (string responseId);
  
        /// <summary>
        /// Delete an existing response.
        /// </summary>
        /// <remarks>
        /// This will remove the response from any libraries associated with it.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteResponsesResponseIdWithHttpInfo (string responseId);

        /// <summary>
        /// Delete an existing response.
        /// </summary>
        /// <remarks>
        /// This will remove the response from any libraries associated with it.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteResponsesResponseIdAsync (string responseId);

        /// <summary>
        /// Delete an existing response.
        /// </summary>
        /// <remarks>
        /// This will remove the response from any libraries associated with it.
        /// </remarks>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteResponsesResponseIdAsyncWithHttpInfo (string responseId);
        
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
        public LibraryEntityListing GetLibraries (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<LibraryEntityListing> response = GetLibrariesWithHttpInfo(pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of existing response libraries. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of LibraryEntityListing</returns>
        public ApiResponse< LibraryEntityListing > GetLibrariesWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/libraries";
    
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
                throw new ApiException (statusCode, "Error calling GetLibraries: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetLibraries: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<LibraryEntityListing> GetLibrariesAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<LibraryEntityListing> response = await GetLibrariesAsyncWithHttpInfo(pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of existing response libraries. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (LibraryEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LibraryEntityListing>> GetLibrariesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/libraries";
    
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
                throw new ApiException (statusCode, "Error calling GetLibraries: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetLibraries: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LibraryEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LibraryEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LibraryEntityListing)));
            
        }
        
        /// <summary>
        /// Create a response library. 
        /// </summary>
        /// <param name="body">Library</param> 
        /// <returns>Library</returns>
        public Library PostLibraries (Library body = null)
        {
             ApiResponse<Library> response = PostLibrariesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a response library. 
        /// </summary>
        /// <param name="body">Library</param> 
        /// <returns>ApiResponse of Library</returns>
        public ApiResponse< Library > PostLibrariesWithHttpInfo (Library body = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/libraries";
    
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
                throw new ApiException (statusCode, "Error calling PostLibraries: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostLibraries: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Library>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(response, typeof(Library)));
            
        }
    
        /// <summary>
        /// Create a response library. 
        /// </summary>
        /// <param name="body">Library</param>
        /// <returns>Task of Library</returns>
        public async System.Threading.Tasks.Task<Library> PostLibrariesAsync (Library body = null)
        {
             ApiResponse<Library> response = await PostLibrariesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a response library. 
        /// </summary>
        /// <param name="body">Library</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Library>> PostLibrariesAsyncWithHttpInfo (Library body = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/libraries";
    
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
                throw new ApiException (statusCode, "Error calling PostLibraries: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostLibraries: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Library>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(response, typeof(Library)));
            
        }
        
        /// <summary>
        /// Get details about an existing response library. 
        /// </summary>
        /// <param name="libraryId">Library ID</param> 
        /// <returns>Library</returns>
        public Library GetLibrariesLibraryId (string libraryId)
        {
             ApiResponse<Library> response = GetLibrariesLibraryIdWithHttpInfo(libraryId);
             return response.Data;
        }

        /// <summary>
        /// Get details about an existing response library. 
        /// </summary>
        /// <param name="libraryId">Library ID</param> 
        /// <returns>ApiResponse of Library</returns>
        public ApiResponse< Library > GetLibrariesLibraryIdWithHttpInfo (string libraryId)
        {
            
            // verify the required parameter 'libraryId' is set
            if (libraryId == null)
                throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->GetLibrariesLibraryId");
            
    
            var path_ = "/api/v1/responsemanagement/libraries/{libraryId}";
    
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
            if (libraryId != null) pathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetLibrariesLibraryId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetLibrariesLibraryId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Library>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(response, typeof(Library)));
            
        }
    
        /// <summary>
        /// Get details about an existing response library. 
        /// </summary>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of Library</returns>
        public async System.Threading.Tasks.Task<Library> GetLibrariesLibraryIdAsync (string libraryId)
        {
             ApiResponse<Library> response = await GetLibrariesLibraryIdAsyncWithHttpInfo(libraryId);
             return response.Data;

        }

        /// <summary>
        /// Get details about an existing response library. 
        /// </summary>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Library>> GetLibrariesLibraryIdAsyncWithHttpInfo (string libraryId)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null) throw new ApiException(400, "Missing required parameter 'libraryId' when calling GetLibrariesLibraryId");
            
    
            var path_ = "/api/v1/responsemanagement/libraries/{libraryId}";
    
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
            if (libraryId != null) pathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetLibrariesLibraryId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetLibrariesLibraryId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Library PutLibrariesLibraryId (string libraryId, Library body = null)
        {
             ApiResponse<Library> response = PutLibrariesLibraryIdWithHttpInfo(libraryId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an existing response library. Fields that can be updated: name. The most recent version is required for updates.
        /// </summary>
        /// <param name="libraryId">Library ID</param> 
        /// <param name="body">Library</param> 
        /// <returns>ApiResponse of Library</returns>
        public ApiResponse< Library > PutLibrariesLibraryIdWithHttpInfo (string libraryId, Library body = null)
        {
            
            // verify the required parameter 'libraryId' is set
            if (libraryId == null)
                throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->PutLibrariesLibraryId");
            
    
            var path_ = "/api/v1/responsemanagement/libraries/{libraryId}";
    
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
            if (libraryId != null) pathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutLibrariesLibraryId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutLibrariesLibraryId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Library> PutLibrariesLibraryIdAsync (string libraryId, Library body = null)
        {
             ApiResponse<Library> response = await PutLibrariesLibraryIdAsyncWithHttpInfo(libraryId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an existing response library. Fields that can be updated: name. The most recent version is required for updates.
        /// </summary>
        /// <param name="libraryId">Library ID</param>
        /// <param name="body">Library</param>
        /// <returns>Task of ApiResponse (Library)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Library>> PutLibrariesLibraryIdAsyncWithHttpInfo (string libraryId, Library body = null)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null) throw new ApiException(400, "Missing required parameter 'libraryId' when calling PutLibrariesLibraryId");
            
    
            var path_ = "/api/v1/responsemanagement/libraries/{libraryId}";
    
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
            if (libraryId != null) pathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutLibrariesLibraryId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutLibrariesLibraryId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Library>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Library) Configuration.ApiClient.Deserialize(response, typeof(Library)));
            
        }
        
        /// <summary>
        /// Delete an existing response library. This will remove any responses associated with the library.
        /// </summary>
        /// <param name="libraryId">Library ID</param> 
        /// <returns></returns>
        public void DeleteLibrariesLibraryId (string libraryId)
        {
             DeleteLibrariesLibraryIdWithHttpInfo(libraryId);
        }

        /// <summary>
        /// Delete an existing response library. This will remove any responses associated with the library.
        /// </summary>
        /// <param name="libraryId">Library ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLibrariesLibraryIdWithHttpInfo (string libraryId)
        {
            
            // verify the required parameter 'libraryId' is set
            if (libraryId == null)
                throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->DeleteLibrariesLibraryId");
            
    
            var path_ = "/api/v1/responsemanagement/libraries/{libraryId}";
    
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
            if (libraryId != null) pathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteLibrariesLibraryId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteLibrariesLibraryId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an existing response library. This will remove any responses associated with the library.
        /// </summary>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLibrariesLibraryIdAsync (string libraryId)
        {
             await DeleteLibrariesLibraryIdAsyncWithHttpInfo(libraryId);

        }

        /// <summary>
        /// Delete an existing response library. This will remove any responses associated with the library.
        /// </summary>
        /// <param name="libraryId">Library ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLibrariesLibraryIdAsyncWithHttpInfo (string libraryId)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null) throw new ApiException(400, "Missing required parameter 'libraryId' when calling DeleteLibrariesLibraryId");
            
    
            var path_ = "/api/v1/responsemanagement/libraries/{libraryId}";
    
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
            if (libraryId != null) pathParams.Add("libraryId", Configuration.ApiClient.ParameterToString(libraryId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteLibrariesLibraryId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteLibrariesLibraryId: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public ResponseEntityListing GetResponses (string libraryId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ResponseEntityListing> response = GetResponsesWithHttpInfo(libraryId, pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of existing responses. 
        /// </summary>
        /// <param name="libraryId">Library ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of ResponseEntityListing</returns>
        public ApiResponse< ResponseEntityListing > GetResponsesWithHttpInfo (string libraryId, int? pageNumber = null, int? pageSize = null)
        {
            
            // verify the required parameter 'libraryId' is set
            if (libraryId == null)
                throw new ApiException(400, "Missing required parameter 'libraryId' when calling ResponseManagementApi->GetResponses");
            
    
            var path_ = "/api/v1/responsemanagement/responses";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetResponses: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetResponses: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ResponseEntityListing> GetResponsesAsync (string libraryId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<ResponseEntityListing> response = await GetResponsesAsyncWithHttpInfo(libraryId, pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of existing responses. 
        /// </summary>
        /// <param name="libraryId">Library ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (ResponseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseEntityListing>> GetResponsesAsyncWithHttpInfo (string libraryId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'libraryId' is set
            if (libraryId == null) throw new ApiException(400, "Missing required parameter 'libraryId' when calling GetResponses");
            
    
            var path_ = "/api/v1/responsemanagement/responses";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetResponses: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetResponses: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ResponseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ResponseEntityListing)));
            
        }
        
        /// <summary>
        /// Create a response. 
        /// </summary>
        /// <param name="body">Response</param> 
        /// <returns>Response</returns>
        public Response PostResponses (Response body = null)
        {
             ApiResponse<Response> response = PostResponsesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a response. 
        /// </summary>
        /// <param name="body">Response</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > PostResponsesWithHttpInfo (Response body = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/responses";
    
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
                throw new ApiException (statusCode, "Error calling PostResponses: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostResponses: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Response>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(response, typeof(Response)));
            
        }
    
        /// <summary>
        /// Create a response. 
        /// </summary>
        /// <param name="body">Response</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> PostResponsesAsync (Response body = null)
        {
             ApiResponse<Response> response = await PostResponsesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a response. 
        /// </summary>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> PostResponsesAsyncWithHttpInfo (Response body = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/responses";
    
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
                throw new ApiException (statusCode, "Error calling PostResponses: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostResponses: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Response>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(response, typeof(Response)));
            
        }
        
        /// <summary>
        /// Query responses 
        /// </summary>
        /// <param name="body">Response</param> 
        /// <returns>ResponseQueryResults</returns>
        public ResponseQueryResults PostResponsesQuery (ResponseQueryRequest body = null)
        {
             ApiResponse<ResponseQueryResults> response = PostResponsesQueryWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Query responses 
        /// </summary>
        /// <param name="body">Response</param> 
        /// <returns>ApiResponse of ResponseQueryResults</returns>
        public ApiResponse< ResponseQueryResults > PostResponsesQueryWithHttpInfo (ResponseQueryRequest body = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/responses/query";
    
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
                throw new ApiException (statusCode, "Error calling PostResponsesQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostResponsesQuery: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ResponseQueryResults>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseQueryResults) Configuration.ApiClient.Deserialize(response, typeof(ResponseQueryResults)));
            
        }
    
        /// <summary>
        /// Query responses 
        /// </summary>
        /// <param name="body">Response</param>
        /// <returns>Task of ResponseQueryResults</returns>
        public async System.Threading.Tasks.Task<ResponseQueryResults> PostResponsesQueryAsync (ResponseQueryRequest body = null)
        {
             ApiResponse<ResponseQueryResults> response = await PostResponsesQueryAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Query responses 
        /// </summary>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (ResponseQueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseQueryResults>> PostResponsesQueryAsyncWithHttpInfo (ResponseQueryRequest body = null)
        {
            
    
            var path_ = "/api/v1/responsemanagement/responses/query";
    
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
                throw new ApiException (statusCode, "Error calling PostResponsesQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostResponsesQuery: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ResponseQueryResults>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseQueryResults) Configuration.ApiClient.Deserialize(response, typeof(ResponseQueryResults)));
            
        }
        
        /// <summary>
        /// Get details about an existing response. 
        /// </summary>
        /// <param name="responseId">Response ID</param> 
        /// <returns>Response</returns>
        public Response GetResponsesResponseId (string responseId)
        {
             ApiResponse<Response> response = GetResponsesResponseIdWithHttpInfo(responseId);
             return response.Data;
        }

        /// <summary>
        /// Get details about an existing response. 
        /// </summary>
        /// <param name="responseId">Response ID</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > GetResponsesResponseIdWithHttpInfo (string responseId)
        {
            
            // verify the required parameter 'responseId' is set
            if (responseId == null)
                throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponseManagementApi->GetResponsesResponseId");
            
    
            var path_ = "/api/v1/responsemanagement/responses/{responseId}";
    
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
            if (responseId != null) pathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetResponsesResponseId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetResponsesResponseId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Response>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(response, typeof(Response)));
            
        }
    
        /// <summary>
        /// Get details about an existing response. 
        /// </summary>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> GetResponsesResponseIdAsync (string responseId)
        {
             ApiResponse<Response> response = await GetResponsesResponseIdAsyncWithHttpInfo(responseId);
             return response.Data;

        }

        /// <summary>
        /// Get details about an existing response. 
        /// </summary>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> GetResponsesResponseIdAsyncWithHttpInfo (string responseId)
        {
            // verify the required parameter 'responseId' is set
            if (responseId == null) throw new ApiException(400, "Missing required parameter 'responseId' when calling GetResponsesResponseId");
            
    
            var path_ = "/api/v1/responsemanagement/responses/{responseId}";
    
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
            if (responseId != null) pathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetResponsesResponseId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetResponsesResponseId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Response PutResponsesResponseId (string responseId, Response body = null)
        {
             ApiResponse<Response> response = PutResponsesResponseIdWithHttpInfo(responseId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an existing response. Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </summary>
        /// <param name="responseId">Response ID</param> 
        /// <param name="body">Response</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > PutResponsesResponseIdWithHttpInfo (string responseId, Response body = null)
        {
            
            // verify the required parameter 'responseId' is set
            if (responseId == null)
                throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponseManagementApi->PutResponsesResponseId");
            
    
            var path_ = "/api/v1/responsemanagement/responses/{responseId}";
    
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
            if (responseId != null) pathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutResponsesResponseId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutResponsesResponseId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Response> PutResponsesResponseIdAsync (string responseId, Response body = null)
        {
             ApiResponse<Response> response = await PutResponsesResponseIdAsyncWithHttpInfo(responseId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an existing response. Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.
        /// </summary>
        /// <param name="responseId">Response ID</param>
        /// <param name="body">Response</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> PutResponsesResponseIdAsyncWithHttpInfo (string responseId, Response body = null)
        {
            // verify the required parameter 'responseId' is set
            if (responseId == null) throw new ApiException(400, "Missing required parameter 'responseId' when calling PutResponsesResponseId");
            
    
            var path_ = "/api/v1/responsemanagement/responses/{responseId}";
    
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
            if (responseId != null) pathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutResponsesResponseId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutResponsesResponseId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Response>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(response, typeof(Response)));
            
        }
        
        /// <summary>
        /// Delete an existing response. This will remove the response from any libraries associated with it.
        /// </summary>
        /// <param name="responseId">Response ID</param> 
        /// <returns></returns>
        public void DeleteResponsesResponseId (string responseId)
        {
             DeleteResponsesResponseIdWithHttpInfo(responseId);
        }

        /// <summary>
        /// Delete an existing response. This will remove the response from any libraries associated with it.
        /// </summary>
        /// <param name="responseId">Response ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteResponsesResponseIdWithHttpInfo (string responseId)
        {
            
            // verify the required parameter 'responseId' is set
            if (responseId == null)
                throw new ApiException(400, "Missing required parameter 'responseId' when calling ResponseManagementApi->DeleteResponsesResponseId");
            
    
            var path_ = "/api/v1/responsemanagement/responses/{responseId}";
    
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
            if (responseId != null) pathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteResponsesResponseId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteResponsesResponseId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an existing response. This will remove the response from any libraries associated with it.
        /// </summary>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteResponsesResponseIdAsync (string responseId)
        {
             await DeleteResponsesResponseIdAsyncWithHttpInfo(responseId);

        }

        /// <summary>
        /// Delete an existing response. This will remove the response from any libraries associated with it.
        /// </summary>
        /// <param name="responseId">Response ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteResponsesResponseIdAsyncWithHttpInfo (string responseId)
        {
            // verify the required parameter 'responseId' is set
            if (responseId == null) throw new ApiException(400, "Missing required parameter 'responseId' when calling DeleteResponsesResponseId");
            
    
            var path_ = "/api/v1/responsemanagement/responses/{responseId}";
    
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
            if (responseId != null) pathParams.Add("responseId", Configuration.ApiClient.ParameterToString(responseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteResponsesResponseId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteResponsesResponseId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
