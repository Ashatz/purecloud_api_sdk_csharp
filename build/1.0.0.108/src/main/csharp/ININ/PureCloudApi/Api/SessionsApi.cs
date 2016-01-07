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
    public interface ISessionsApi
    {
        
        /// <summary>
        /// Get all the sessions for your auth token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>SessionEntityListing</returns>
        SessionEntityListing SessionsGet (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get all the sessions for your auth token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of SessionEntityListing</returns>
        ApiResponse<SessionEntityListing> SessionsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all the sessions for your auth token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of SessionEntityListing</returns>
        System.Threading.Tasks.Task<SessionEntityListing> SessionsGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all the sessions for your auth token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SessionEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SessionEntityListing>> SessionsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Create a new session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Session</returns>
        Session SessionsPost (SessionRequest body = null);
  
        /// <summary>
        /// Create a new session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Session</returns>
        ApiResponse<Session> SessionsPostWithHttpInfo (SessionRequest body = null);

        /// <summary>
        /// Create a new session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Session</returns>
        System.Threading.Tasks.Task<Session> SessionsPostAsync (SessionRequest body = null);

        /// <summary>
        /// Create a new session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Session)</returns>
        System.Threading.Tasks.Task<ApiResponse<Session>> SessionsPostAsyncWithHttpInfo (SessionRequest body = null);
        
        /// <summary>
        /// Retrieve a client session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sessionId">Session ID</param>
        /// <returns>Session</returns>
        Session SessionsSessionidGet (string sessionId);
  
        /// <summary>
        /// Retrieve a client session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sessionId">Session ID</param>
        /// <returns>ApiResponse of Session</returns>
        ApiResponse<Session> SessionsSessionidGetWithHttpInfo (string sessionId);

        /// <summary>
        /// Retrieve a client session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sessionId">Session ID</param>
        /// <returns>Task of Session</returns>
        System.Threading.Tasks.Task<Session> SessionsSessionidGetAsync (string sessionId);

        /// <summary>
        /// Retrieve a client session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sessionId">Session ID</param>
        /// <returns>Task of ApiResponse (Session)</returns>
        System.Threading.Tasks.Task<ApiResponse<Session>> SessionsSessionidGetAsyncWithHttpInfo (string sessionId);
        
        /// <summary>
        /// Remove a session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sessionId">Session ID</param>
        /// <returns>Session</returns>
        Session SessionsSessionidDelete (string sessionId);
  
        /// <summary>
        /// Remove a session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sessionId">Session ID</param>
        /// <returns>ApiResponse of Session</returns>
        ApiResponse<Session> SessionsSessionidDeleteWithHttpInfo (string sessionId);

        /// <summary>
        /// Remove a session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sessionId">Session ID</param>
        /// <returns>Task of Session</returns>
        System.Threading.Tasks.Task<Session> SessionsSessionidDeleteAsync (string sessionId);

        /// <summary>
        /// Remove a session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sessionId">Session ID</param>
        /// <returns>Task of ApiResponse (Session)</returns>
        System.Threading.Tasks.Task<ApiResponse<Session>> SessionsSessionidDeleteAsyncWithHttpInfo (string sessionId);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SessionsApi : ISessionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SessionsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SessionsApi(Configuration configuration = null)
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
        /// Get all the sessions for your auth token. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>SessionEntityListing</returns>
        public SessionEntityListing SessionsGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SessionEntityListing> response = SessionsGetWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get all the sessions for your auth token. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of SessionEntityListing</returns>
        public ApiResponse< SessionEntityListing > SessionsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/sessions";
    
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
                throw new ApiException (statusCode, "Error calling SessionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SessionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SessionEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SessionEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SessionEntityListing)));
            
        }
    
        /// <summary>
        /// Get all the sessions for your auth token. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of SessionEntityListing</returns>
        public async System.Threading.Tasks.Task<SessionEntityListing> SessionsGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SessionEntityListing> response = await SessionsGetAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get all the sessions for your auth token. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SessionEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SessionEntityListing>> SessionsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/sessions";
    
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
                throw new ApiException (statusCode, "Error calling SessionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SessionsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SessionEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SessionEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SessionEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new session. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Session</returns>
        public Session SessionsPost (SessionRequest body = null)
        {
             ApiResponse<Session> response = SessionsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new session. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Session</returns>
        public ApiResponse< Session > SessionsPostWithHttpInfo (SessionRequest body = null)
        {
            
    
            var path_ = "/api/v1/sessions";
    
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
                throw new ApiException (statusCode, "Error calling SessionsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SessionsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Session>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Session) Configuration.ApiClient.Deserialize(response, typeof(Session)));
            
        }
    
        /// <summary>
        /// Create a new session. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Session</returns>
        public async System.Threading.Tasks.Task<Session> SessionsPostAsync (SessionRequest body = null)
        {
             ApiResponse<Session> response = await SessionsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new session. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Session)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Session>> SessionsPostAsyncWithHttpInfo (SessionRequest body = null)
        {
            
    
            var path_ = "/api/v1/sessions";
    
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
                throw new ApiException (statusCode, "Error calling SessionsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SessionsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Session>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Session) Configuration.ApiClient.Deserialize(response, typeof(Session)));
            
        }
        
        /// <summary>
        /// Retrieve a client session. 
        /// </summary>
        /// <param name="sessionId">Session ID</param> 
        /// <returns>Session</returns>
        public Session SessionsSessionidGet (string sessionId)
        {
             ApiResponse<Session> response = SessionsSessionidGetWithHttpInfo(sessionId);
             return response.Data;
        }

        /// <summary>
        /// Retrieve a client session. 
        /// </summary>
        /// <param name="sessionId">Session ID</param> 
        /// <returns>ApiResponse of Session</returns>
        public ApiResponse< Session > SessionsSessionidGetWithHttpInfo (string sessionId)
        {
            
            // verify the required parameter 'sessionId' is set
            if (sessionId == null) throw new ApiException(400, "Missing required parameter 'sessionId' when calling SessionsSessionidGet");
            
    
            var path_ = "/api/v1/sessions/{sessionId}";
    
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
            if (sessionId != null) pathParams.Add("sessionId", Configuration.ApiClient.ParameterToString(sessionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SessionsSessionidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SessionsSessionidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Session>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Session) Configuration.ApiClient.Deserialize(response, typeof(Session)));
            
        }
    
        /// <summary>
        /// Retrieve a client session. 
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <returns>Task of Session</returns>
        public async System.Threading.Tasks.Task<Session> SessionsSessionidGetAsync (string sessionId)
        {
             ApiResponse<Session> response = await SessionsSessionidGetAsyncWithHttpInfo(sessionId);
             return response.Data;

        }

        /// <summary>
        /// Retrieve a client session. 
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <returns>Task of ApiResponse (Session)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Session>> SessionsSessionidGetAsyncWithHttpInfo (string sessionId)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null) throw new ApiException(400, "Missing required parameter 'sessionId' when calling SessionsSessionidGet");
            
    
            var path_ = "/api/v1/sessions/{sessionId}";
    
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
            if (sessionId != null) pathParams.Add("sessionId", Configuration.ApiClient.ParameterToString(sessionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SessionsSessionidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SessionsSessionidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Session>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Session) Configuration.ApiClient.Deserialize(response, typeof(Session)));
            
        }
        
        /// <summary>
        /// Remove a session. 
        /// </summary>
        /// <param name="sessionId">Session ID</param> 
        /// <returns>Session</returns>
        public Session SessionsSessionidDelete (string sessionId)
        {
             ApiResponse<Session> response = SessionsSessionidDeleteWithHttpInfo(sessionId);
             return response.Data;
        }

        /// <summary>
        /// Remove a session. 
        /// </summary>
        /// <param name="sessionId">Session ID</param> 
        /// <returns>ApiResponse of Session</returns>
        public ApiResponse< Session > SessionsSessionidDeleteWithHttpInfo (string sessionId)
        {
            
            // verify the required parameter 'sessionId' is set
            if (sessionId == null) throw new ApiException(400, "Missing required parameter 'sessionId' when calling SessionsSessionidDelete");
            
    
            var path_ = "/api/v1/sessions/{sessionId}";
    
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
            if (sessionId != null) pathParams.Add("sessionId", Configuration.ApiClient.ParameterToString(sessionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SessionsSessionidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SessionsSessionidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Session>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Session) Configuration.ApiClient.Deserialize(response, typeof(Session)));
            
        }
    
        /// <summary>
        /// Remove a session. 
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <returns>Task of Session</returns>
        public async System.Threading.Tasks.Task<Session> SessionsSessionidDeleteAsync (string sessionId)
        {
             ApiResponse<Session> response = await SessionsSessionidDeleteAsyncWithHttpInfo(sessionId);
             return response.Data;

        }

        /// <summary>
        /// Remove a session. 
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <returns>Task of ApiResponse (Session)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Session>> SessionsSessionidDeleteAsyncWithHttpInfo (string sessionId)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null) throw new ApiException(400, "Missing required parameter 'sessionId' when calling SessionsSessionidDelete");
            
    
            var path_ = "/api/v1/sessions/{sessionId}";
    
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
            if (sessionId != null) pathParams.Add("sessionId", Configuration.ApiClient.ParameterToString(sessionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SessionsSessionidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SessionsSessionidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Session>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Session) Configuration.ApiClient.Deserialize(response, typeof(Session)));
            
        }
        
    }
    
}
