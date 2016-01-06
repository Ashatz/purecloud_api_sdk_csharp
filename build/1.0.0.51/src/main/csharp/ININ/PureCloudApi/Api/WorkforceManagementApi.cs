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
    public interface IWorkforceManagementApi
    {
        
        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>List&lt;ManagementUnit&gt;</returns>
        List<ManagementUnit> WorkforcemanagementManagementunitsGet (string selector = null, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>ApiResponse of List&lt;ManagementUnit&gt;</returns>
        ApiResponse<List<ManagementUnit>> WorkforcemanagementManagementunitsGetWithHttpInfo (string selector = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of List&lt;ManagementUnit&gt;</returns>
        System.Threading.Tasks.Task<List<ManagementUnit>> WorkforcemanagementManagementunitsGetAsync (string selector = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of ApiResponse (List&lt;ManagementUnit&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ManagementUnit>>> WorkforcemanagementManagementunitsGetAsyncWithHttpInfo (string selector = null, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Add a management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <param name="body">body</param>
        /// <returns>ManagementUnit</returns>
        ManagementUnit WorkforcemanagementManagementunitsPost (string selector = null, PutManagementUnit body = null);
  
        /// <summary>
        /// Add a management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <param name="body">body</param>
        /// <returns>ApiResponse of ManagementUnit</returns>
        ApiResponse<ManagementUnit> WorkforcemanagementManagementunitsPostWithHttpInfo (string selector = null, PutManagementUnit body = null);

        /// <summary>
        /// Add a management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <param name="body">body</param>
        /// <returns>Task of ManagementUnit</returns>
        System.Threading.Tasks.Task<ManagementUnit> WorkforcemanagementManagementunitsPostAsync (string selector = null, PutManagementUnit body = null);

        /// <summary>
        /// Add a management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse (ManagementUnit)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagementUnit>> WorkforcemanagementManagementunitsPostAsyncWithHttpInfo (string selector = null, PutManagementUnit body = null);
        
        /// <summary>
        /// Get management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <returns>ManagementUnit</returns>
        ManagementUnit WorkforcemanagementManagementunitsIdGet (string id, string selector = null);
  
        /// <summary>
        /// Get management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <returns>ApiResponse of ManagementUnit</returns>
        ApiResponse<ManagementUnit> WorkforcemanagementManagementunitsIdGetWithHttpInfo (string id, string selector = null);

        /// <summary>
        /// Get management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <returns>Task of ManagementUnit</returns>
        System.Threading.Tasks.Task<ManagementUnit> WorkforcemanagementManagementunitsIdGetAsync (string id, string selector = null);

        /// <summary>
        /// Get management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <returns>Task of ApiResponse (ManagementUnit)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagementUnit>> WorkforcemanagementManagementunitsIdGetAsyncWithHttpInfo (string id, string selector = null);
        
        /// <summary>
        /// Delete management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <returns></returns>
        void WorkforcemanagementManagementunitsIdDelete (string id);
  
        /// <summary>
        /// Delete management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> WorkforcemanagementManagementunitsIdDeleteWithHttpInfo (string id);

        /// <summary>
        /// Delete management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task WorkforcemanagementManagementunitsIdDeleteAsync (string id);

        /// <summary>
        /// Delete management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> WorkforcemanagementManagementunitsIdDeleteAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Execute the managment unit batch command
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="body">body</param>
        /// <returns>BatchReply</returns>
        BatchReply WorkforcemanagementManagementunitsIdBatchPost (string id, BatchCommand body = null);
  
        /// <summary>
        /// Execute the managment unit batch command
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="body">body</param>
        /// <returns>ApiResponse of BatchReply</returns>
        ApiResponse<BatchReply> WorkforcemanagementManagementunitsIdBatchPostWithHttpInfo (string id, BatchCommand body = null);

        /// <summary>
        /// Execute the managment unit batch command
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="body">body</param>
        /// <returns>Task of BatchReply</returns>
        System.Threading.Tasks.Task<BatchReply> WorkforcemanagementManagementunitsIdBatchPostAsync (string id, BatchCommand body = null);

        /// <summary>
        /// Execute the managment unit batch command
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse (BatchReply)</returns>
        System.Threading.Tasks.Task<ApiResponse<BatchReply>> WorkforcemanagementManagementunitsIdBatchPostAsyncWithHttpInfo (string id, BatchCommand body = null);
        
        /// <summary>
        /// Set timezone for the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="body">body</param>
        /// <returns></returns>
        void WorkforcemanagementManagementunitsIdTimezonePost (string id, ManagementUnitTimezone body = null);
  
        /// <summary>
        /// Set timezone for the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="body">body</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> WorkforcemanagementManagementunitsIdTimezonePostWithHttpInfo (string id, ManagementUnitTimezone body = null);

        /// <summary>
        /// Set timezone for the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="body">body</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task WorkforcemanagementManagementunitsIdTimezonePostAsync (string id, ManagementUnitTimezone body = null);

        /// <summary>
        /// Set timezone for the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> WorkforcemanagementManagementunitsIdTimezonePostAsyncWithHttpInfo (string id, ManagementUnitTimezone body = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WorkforceManagementApi : IWorkforceManagementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkforceManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WorkforceManagementApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
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
        /// Get management units 
        /// </summary>
        /// <param name="selector">insert reference to nice selector description here</param> 
        /// <param name="pageSize"></param> 
        /// <param name="pageNumber"></param> 
        /// <returns>List&lt;ManagementUnit&gt;</returns>
        public List<ManagementUnit> WorkforcemanagementManagementunitsGet (string selector = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<List<ManagementUnit>> response = WorkforcemanagementManagementunitsGetWithHttpInfo(selector, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get management units 
        /// </summary>
        /// <param name="selector">insert reference to nice selector description here</param> 
        /// <param name="pageSize"></param> 
        /// <param name="pageNumber"></param> 
        /// <returns>ApiResponse of List&lt;ManagementUnit&gt;</returns>
        public ApiResponse< List<ManagementUnit> > WorkforcemanagementManagementunitsGetWithHttpInfo (string selector = null, int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/workforcemanagement/managementunits";
    
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
            
            if (selector != null) queryParams.Add("selector", Configuration.ApiClient.ParameterToString(selector)); // query parameter
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
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<ManagementUnit>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ManagementUnit>) Configuration.ApiClient.Deserialize(response, typeof(List<ManagementUnit>)));
            
        }
    
        /// <summary>
        /// Get management units 
        /// </summary>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of List&lt;ManagementUnit&gt;</returns>
        public async System.Threading.Tasks.Task<List<ManagementUnit>> WorkforcemanagementManagementunitsGetAsync (string selector = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<List<ManagementUnit>> response = await WorkforcemanagementManagementunitsGetAsyncWithHttpInfo(selector, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get management units 
        /// </summary>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of ApiResponse (List&lt;ManagementUnit&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ManagementUnit>>> WorkforcemanagementManagementunitsGetAsyncWithHttpInfo (string selector = null, int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/workforcemanagement/managementunits";
    
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
            
            if (selector != null) queryParams.Add("selector", Configuration.ApiClient.ParameterToString(selector)); // query parameter
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
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<ManagementUnit>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ManagementUnit>) Configuration.ApiClient.Deserialize(response, typeof(List<ManagementUnit>)));
            
        }
        
        /// <summary>
        /// Add a management unit 
        /// </summary>
        /// <param name="selector">insert reference to nice selector description here</param> 
        /// <param name="body">body</param> 
        /// <returns>ManagementUnit</returns>
        public ManagementUnit WorkforcemanagementManagementunitsPost (string selector = null, PutManagementUnit body = null)
        {
             ApiResponse<ManagementUnit> response = WorkforcemanagementManagementunitsPostWithHttpInfo(selector, body);
             return response.Data;
        }

        /// <summary>
        /// Add a management unit 
        /// </summary>
        /// <param name="selector">insert reference to nice selector description here</param> 
        /// <param name="body">body</param> 
        /// <returns>ApiResponse of ManagementUnit</returns>
        public ApiResponse< ManagementUnit > WorkforcemanagementManagementunitsPostWithHttpInfo (string selector = null, PutManagementUnit body = null)
        {
            
    
            var path_ = "/api/v1/workforcemanagement/managementunits";
    
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
            
            if (selector != null) queryParams.Add("selector", Configuration.ApiClient.ParameterToString(selector)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ManagementUnit>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagementUnit) Configuration.ApiClient.Deserialize(response, typeof(ManagementUnit)));
            
        }
    
        /// <summary>
        /// Add a management unit 
        /// </summary>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <param name="body">body</param>
        /// <returns>Task of ManagementUnit</returns>
        public async System.Threading.Tasks.Task<ManagementUnit> WorkforcemanagementManagementunitsPostAsync (string selector = null, PutManagementUnit body = null)
        {
             ApiResponse<ManagementUnit> response = await WorkforcemanagementManagementunitsPostAsyncWithHttpInfo(selector, body);
             return response.Data;

        }

        /// <summary>
        /// Add a management unit 
        /// </summary>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse (ManagementUnit)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagementUnit>> WorkforcemanagementManagementunitsPostAsyncWithHttpInfo (string selector = null, PutManagementUnit body = null)
        {
            
    
            var path_ = "/api/v1/workforcemanagement/managementunits";
    
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
            
            if (selector != null) queryParams.Add("selector", Configuration.ApiClient.ParameterToString(selector)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ManagementUnit>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagementUnit) Configuration.ApiClient.Deserialize(response, typeof(ManagementUnit)));
            
        }
        
        /// <summary>
        /// Get management unit 
        /// </summary>
        /// <param name="id">The id of the management unit.</param> 
        /// <param name="selector">insert reference to nice selector description here</param> 
        /// <returns>ManagementUnit</returns>
        public ManagementUnit WorkforcemanagementManagementunitsIdGet (string id, string selector = null)
        {
             ApiResponse<ManagementUnit> response = WorkforcemanagementManagementunitsIdGetWithHttpInfo(id, selector);
             return response.Data;
        }

        /// <summary>
        /// Get management unit 
        /// </summary>
        /// <param name="id">The id of the management unit.</param> 
        /// <param name="selector">insert reference to nice selector description here</param> 
        /// <returns>ApiResponse of ManagementUnit</returns>
        public ApiResponse< ManagementUnit > WorkforcemanagementManagementunitsIdGetWithHttpInfo (string id, string selector = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WorkforcemanagementManagementunitsIdGet");
            
    
            var path_ = "/api/v1/workforcemanagement/managementunits/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (selector != null) queryParams.Add("selector", Configuration.ApiClient.ParameterToString(selector)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ManagementUnit>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagementUnit) Configuration.ApiClient.Deserialize(response, typeof(ManagementUnit)));
            
        }
    
        /// <summary>
        /// Get management unit 
        /// </summary>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <returns>Task of ManagementUnit</returns>
        public async System.Threading.Tasks.Task<ManagementUnit> WorkforcemanagementManagementunitsIdGetAsync (string id, string selector = null)
        {
             ApiResponse<ManagementUnit> response = await WorkforcemanagementManagementunitsIdGetAsyncWithHttpInfo(id, selector);
             return response.Data;

        }

        /// <summary>
        /// Get management unit 
        /// </summary>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="selector">insert reference to nice selector description here</param>
        /// <returns>Task of ApiResponse (ManagementUnit)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagementUnit>> WorkforcemanagementManagementunitsIdGetAsyncWithHttpInfo (string id, string selector = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WorkforcemanagementManagementunitsIdGet");
            
    
            var path_ = "/api/v1/workforcemanagement/managementunits/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (selector != null) queryParams.Add("selector", Configuration.ApiClient.ParameterToString(selector)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ManagementUnit>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagementUnit) Configuration.ApiClient.Deserialize(response, typeof(ManagementUnit)));
            
        }
        
        /// <summary>
        /// Delete management unit 
        /// </summary>
        /// <param name="id">The id of the management unit.</param> 
        /// <returns></returns>
        public void WorkforcemanagementManagementunitsIdDelete (string id)
        {
             WorkforcemanagementManagementunitsIdDeleteWithHttpInfo(id);
        }

        /// <summary>
        /// Delete management unit 
        /// </summary>
        /// <param name="id">The id of the management unit.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> WorkforcemanagementManagementunitsIdDeleteWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WorkforcemanagementManagementunitsIdDelete");
            
    
            var path_ = "/api/v1/workforcemanagement/managementunits/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete management unit 
        /// </summary>
        /// <param name="id">The id of the management unit.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task WorkforcemanagementManagementunitsIdDeleteAsync (string id)
        {
             await WorkforcemanagementManagementunitsIdDeleteAsyncWithHttpInfo(id);

        }

        /// <summary>
        /// Delete management unit 
        /// </summary>
        /// <param name="id">The id of the management unit.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> WorkforcemanagementManagementunitsIdDeleteAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WorkforcemanagementManagementunitsIdDelete");
            
    
            var path_ = "/api/v1/workforcemanagement/managementunits/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Execute the managment unit batch command 
        /// </summary>
        /// <param name="id">The id of the management unit.</param> 
        /// <param name="body">body</param> 
        /// <returns>BatchReply</returns>
        public BatchReply WorkforcemanagementManagementunitsIdBatchPost (string id, BatchCommand body = null)
        {
             ApiResponse<BatchReply> response = WorkforcemanagementManagementunitsIdBatchPostWithHttpInfo(id, body);
             return response.Data;
        }

        /// <summary>
        /// Execute the managment unit batch command 
        /// </summary>
        /// <param name="id">The id of the management unit.</param> 
        /// <param name="body">body</param> 
        /// <returns>ApiResponse of BatchReply</returns>
        public ApiResponse< BatchReply > WorkforcemanagementManagementunitsIdBatchPostWithHttpInfo (string id, BatchCommand body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WorkforcemanagementManagementunitsIdBatchPost");
            
    
            var path_ = "/api/v1/workforcemanagement/managementunits/{id}/batch";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdBatchPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdBatchPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<BatchReply>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BatchReply) Configuration.ApiClient.Deserialize(response, typeof(BatchReply)));
            
        }
    
        /// <summary>
        /// Execute the managment unit batch command 
        /// </summary>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="body">body</param>
        /// <returns>Task of BatchReply</returns>
        public async System.Threading.Tasks.Task<BatchReply> WorkforcemanagementManagementunitsIdBatchPostAsync (string id, BatchCommand body = null)
        {
             ApiResponse<BatchReply> response = await WorkforcemanagementManagementunitsIdBatchPostAsyncWithHttpInfo(id, body);
             return response.Data;

        }

        /// <summary>
        /// Execute the managment unit batch command 
        /// </summary>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse (BatchReply)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BatchReply>> WorkforcemanagementManagementunitsIdBatchPostAsyncWithHttpInfo (string id, BatchCommand body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WorkforcemanagementManagementunitsIdBatchPost");
            
    
            var path_ = "/api/v1/workforcemanagement/managementunits/{id}/batch";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdBatchPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdBatchPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<BatchReply>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BatchReply) Configuration.ApiClient.Deserialize(response, typeof(BatchReply)));
            
        }
        
        /// <summary>
        /// Set timezone for the management unit 
        /// </summary>
        /// <param name="id">The id of the management unit.</param> 
        /// <param name="body">body</param> 
        /// <returns></returns>
        public void WorkforcemanagementManagementunitsIdTimezonePost (string id, ManagementUnitTimezone body = null)
        {
             WorkforcemanagementManagementunitsIdTimezonePostWithHttpInfo(id, body);
        }

        /// <summary>
        /// Set timezone for the management unit 
        /// </summary>
        /// <param name="id">The id of the management unit.</param> 
        /// <param name="body">body</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> WorkforcemanagementManagementunitsIdTimezonePostWithHttpInfo (string id, ManagementUnitTimezone body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WorkforcemanagementManagementunitsIdTimezonePost");
            
    
            var path_ = "/api/v1/workforcemanagement/managementunits/{id}/timezone";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdTimezonePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdTimezonePost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Set timezone for the management unit 
        /// </summary>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="body">body</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task WorkforcemanagementManagementunitsIdTimezonePostAsync (string id, ManagementUnitTimezone body = null)
        {
             await WorkforcemanagementManagementunitsIdTimezonePostAsyncWithHttpInfo(id, body);

        }

        /// <summary>
        /// Set timezone for the management unit 
        /// </summary>
        /// <param name="id">The id of the management unit.</param>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> WorkforcemanagementManagementunitsIdTimezonePostAsyncWithHttpInfo (string id, ManagementUnitTimezone body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WorkforcemanagementManagementunitsIdTimezonePost");
            
    
            var path_ = "/api/v1/workforcemanagement/managementunits/{id}/timezone";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdTimezonePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WorkforcemanagementManagementunitsIdTimezonePost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
