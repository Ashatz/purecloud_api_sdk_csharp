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
    public interface IBridgeApi
    {
        
        /// <summary>
        /// Get user actions categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>UserActionCategoryEntityListing</returns>
        UserActionCategoryEntityListing BridgeUseractionsCategoriesGet (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get user actions categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of UserActionCategoryEntityListing</returns>
        ApiResponse<UserActionCategoryEntityListing> BridgeUseractionsCategoriesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get user actions categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of UserActionCategoryEntityListing</returns>
        System.Threading.Tasks.Task<UserActionCategoryEntityListing> BridgeUseractionsCategoriesGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get user actions categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (UserActionCategoryEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserActionCategoryEntityListing>> BridgeUseractionsCategoriesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get user actions metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="expand">requests.inputSchema,requests.successSchema</param>
        /// <returns>UserActionMetadataEntityListing</returns>
        UserActionMetadataEntityListing BridgeUseractionsMetadataGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);
  
        /// <summary>
        /// Get user actions metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="expand">requests.inputSchema,requests.successSchema</param>
        /// <returns>ApiResponse of UserActionMetadataEntityListing</returns>
        ApiResponse<UserActionMetadataEntityListing> BridgeUseractionsMetadataGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);

        /// <summary>
        /// Get user actions metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="expand">requests.inputSchema,requests.successSchema</param>
        /// <returns>Task of UserActionMetadataEntityListing</returns>
        System.Threading.Tasks.Task<UserActionMetadataEntityListing> BridgeUseractionsMetadataGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);

        /// <summary>
        /// Get user actions metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="expand">requests.inputSchema,requests.successSchema</param>
        /// <returns>Task of ApiResponse (UserActionMetadataEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserActionMetadataEntityListing>> BridgeUseractionsMetadataGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);
        
        /// <summary>
        /// Get user action metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name">Name</param>
        /// <param name="expand">requests.inputSchema,requests.successSchema</param>
        /// <returns>Dictionary&lt;string, InlineResponse200&gt;</returns>
        Dictionary<string, InlineResponse200> BridgeUseractionsMetadataNameGet (string name, string expand = null);
  
        /// <summary>
        /// Get user action metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name">Name</param>
        /// <param name="expand">requests.inputSchema,requests.successSchema</param>
        /// <returns>ApiResponse of Dictionary&lt;string, InlineResponse200&gt;</returns>
        ApiResponse<Dictionary<string, InlineResponse200>> BridgeUseractionsMetadataNameGetWithHttpInfo (string name, string expand = null);

        /// <summary>
        /// Get user action metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name">Name</param>
        /// <param name="expand">requests.inputSchema,requests.successSchema</param>
        /// <returns>Task of Dictionary&lt;string, InlineResponse200&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, InlineResponse200>> BridgeUseractionsMetadataNameGetAsync (string name, string expand = null);

        /// <summary>
        /// Get user action metadata
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name">Name</param>
        /// <param name="expand">requests.inputSchema,requests.successSchema</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, InlineResponse200&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, InlineResponse200>>> BridgeUseractionsMetadataNameGetAsyncWithHttpInfo (string name, string expand = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BridgeApi : IBridgeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BridgeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BridgeApi(Configuration configuration = null)
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
        /// Get user actions categories 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>UserActionCategoryEntityListing</returns>
        public UserActionCategoryEntityListing BridgeUseractionsCategoriesGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<UserActionCategoryEntityListing> response = BridgeUseractionsCategoriesGetWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get user actions categories 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of UserActionCategoryEntityListing</returns>
        public ApiResponse< UserActionCategoryEntityListing > BridgeUseractionsCategoriesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/bridge/useractions/categories";
    
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
                throw new ApiException (statusCode, "Error calling BridgeUseractionsCategoriesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BridgeUseractionsCategoriesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserActionCategoryEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserActionCategoryEntityListing) Configuration.ApiClient.Deserialize(response, typeof(UserActionCategoryEntityListing)));
            
        }
    
        /// <summary>
        /// Get user actions categories 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of UserActionCategoryEntityListing</returns>
        public async System.Threading.Tasks.Task<UserActionCategoryEntityListing> BridgeUseractionsCategoriesGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<UserActionCategoryEntityListing> response = await BridgeUseractionsCategoriesGetAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get user actions categories 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (UserActionCategoryEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserActionCategoryEntityListing>> BridgeUseractionsCategoriesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/bridge/useractions/categories";
    
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
                throw new ApiException (statusCode, "Error calling BridgeUseractionsCategoriesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BridgeUseractionsCategoriesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserActionCategoryEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserActionCategoryEntityListing) Configuration.ApiClient.Deserialize(response, typeof(UserActionCategoryEntityListing)));
            
        }
        
        /// <summary>
        /// Get user actions metadata 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="expand">requests.inputSchema,requests.successSchema</param> 
        /// <returns>UserActionMetadataEntityListing</returns>
        public UserActionMetadataEntityListing BridgeUseractionsMetadataGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
             ApiResponse<UserActionMetadataEntityListing> response = BridgeUseractionsMetadataGetWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, expand);
             return response.Data;
        }

        /// <summary>
        /// Get user actions metadata 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="expand">requests.inputSchema,requests.successSchema</param> 
        /// <returns>ApiResponse of UserActionMetadataEntityListing</returns>
        public ApiResponse< UserActionMetadataEntityListing > BridgeUseractionsMetadataGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/bridge/useractions/metadata";
    
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
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BridgeUseractionsMetadataGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BridgeUseractionsMetadataGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserActionMetadataEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserActionMetadataEntityListing) Configuration.ApiClient.Deserialize(response, typeof(UserActionMetadataEntityListing)));
            
        }
    
        /// <summary>
        /// Get user actions metadata 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="expand">requests.inputSchema,requests.successSchema</param>
        /// <returns>Task of UserActionMetadataEntityListing</returns>
        public async System.Threading.Tasks.Task<UserActionMetadataEntityListing> BridgeUseractionsMetadataGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
             ApiResponse<UserActionMetadataEntityListing> response = await BridgeUseractionsMetadataGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, expand);
             return response.Data;

        }

        /// <summary>
        /// Get user actions metadata 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="expand">requests.inputSchema,requests.successSchema</param>
        /// <returns>Task of ApiResponse (UserActionMetadataEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserActionMetadataEntityListing>> BridgeUseractionsMetadataGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/bridge/useractions/metadata";
    
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
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BridgeUseractionsMetadataGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BridgeUseractionsMetadataGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserActionMetadataEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserActionMetadataEntityListing) Configuration.ApiClient.Deserialize(response, typeof(UserActionMetadataEntityListing)));
            
        }
        
        /// <summary>
        /// Get user action metadata 
        /// </summary>
        /// <param name="name">Name</param> 
        /// <param name="expand">requests.inputSchema,requests.successSchema</param> 
        /// <returns>Dictionary&lt;string, InlineResponse200&gt;</returns>
        public Dictionary<string, InlineResponse200> BridgeUseractionsMetadataNameGet (string name, string expand = null)
        {
             ApiResponse<Dictionary<string, InlineResponse200>> response = BridgeUseractionsMetadataNameGetWithHttpInfo(name, expand);
             return response.Data;
        }

        /// <summary>
        /// Get user action metadata 
        /// </summary>
        /// <param name="name">Name</param> 
        /// <param name="expand">requests.inputSchema,requests.successSchema</param> 
        /// <returns>ApiResponse of Dictionary&lt;string, InlineResponse200&gt;</returns>
        public ApiResponse< Dictionary<string, InlineResponse200> > BridgeUseractionsMetadataNameGetWithHttpInfo (string name, string expand = null)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling BridgeUseractionsMetadataNameGet");
            
    
            var path_ = "/api/v1/bridge/useractions/metadata/{name}";
    
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
            if (name != null) pathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling BridgeUseractionsMetadataNameGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BridgeUseractionsMetadataNameGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Dictionary<string, InlineResponse200>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dictionary<string, InlineResponse200>) Configuration.ApiClient.Deserialize(response, typeof(Dictionary<string, InlineResponse200>)));
            
        }
    
        /// <summary>
        /// Get user action metadata 
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="expand">requests.inputSchema,requests.successSchema</param>
        /// <returns>Task of Dictionary&lt;string, InlineResponse200&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, InlineResponse200>> BridgeUseractionsMetadataNameGetAsync (string name, string expand = null)
        {
             ApiResponse<Dictionary<string, InlineResponse200>> response = await BridgeUseractionsMetadataNameGetAsyncWithHttpInfo(name, expand);
             return response.Data;

        }

        /// <summary>
        /// Get user action metadata 
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="expand">requests.inputSchema,requests.successSchema</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, InlineResponse200&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, InlineResponse200>>> BridgeUseractionsMetadataNameGetAsyncWithHttpInfo (string name, string expand = null)
        {
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling BridgeUseractionsMetadataNameGet");
            
    
            var path_ = "/api/v1/bridge/useractions/metadata/{name}";
    
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
            if (name != null) pathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling BridgeUseractionsMetadataNameGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BridgeUseractionsMetadataNameGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Dictionary<string, InlineResponse200>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dictionary<string, InlineResponse200>) Configuration.ApiClient.Deserialize(response, typeof(Dictionary<string, InlineResponse200>)));
            
        }
        
    }
    
}
