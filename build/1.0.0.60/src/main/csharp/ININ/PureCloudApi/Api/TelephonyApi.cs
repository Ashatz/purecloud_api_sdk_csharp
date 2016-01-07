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
    public interface ITelephonyApi
    {
        
        /// <summary>
        /// Redirect GET requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <returns></returns>
        void TelephonyBootstrapPhonesIdGet (string id);
  
        /// <summary>
        /// Redirect GET requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TelephonyBootstrapPhonesIdGetWithHttpInfo (string id);

        /// <summary>
        /// Redirect GET requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TelephonyBootstrapPhonesIdGetAsync (string id);

        /// <summary>
        /// Redirect GET requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyBootstrapPhonesIdGetAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Redirect PUT requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <returns></returns>
        void TelephonyBootstrapPhonesIdPut (string id);
  
        /// <summary>
        /// Redirect PUT requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TelephonyBootstrapPhonesIdPutWithHttpInfo (string id);

        /// <summary>
        /// Redirect PUT requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TelephonyBootstrapPhonesIdPutAsync (string id);

        /// <summary>
        /// Redirect PUT requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyBootstrapPhonesIdPutAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Redirect GET requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="file">Requested file</param>
        /// <returns></returns>
        void TelephonyBootstrapPhonesIdFileGet (string id, string file);
  
        /// <summary>
        /// Redirect GET requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="file">Requested file</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TelephonyBootstrapPhonesIdFileGetWithHttpInfo (string id, string file);

        /// <summary>
        /// Redirect GET requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TelephonyBootstrapPhonesIdFileGetAsync (string id, string file);

        /// <summary>
        /// Redirect GET requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyBootstrapPhonesIdFileGetAsyncWithHttpInfo (string id, string file);
        
        /// <summary>
        /// Redirect PUT requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="file">Requested file</param>
        /// <returns></returns>
        void TelephonyBootstrapPhonesIdFilePut (string id, string file);
  
        /// <summary>
        /// Redirect PUT requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="file">Requested file</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TelephonyBootstrapPhonesIdFilePutWithHttpInfo (string id, string file);

        /// <summary>
        /// Redirect PUT requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TelephonyBootstrapPhonesIdFilePutAsync (string id, string file);

        /// <summary>
        /// Redirect PUT requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyBootstrapPhonesIdFilePutAsyncWithHttpInfo (string id, string file);
        
        /// <summary>
        /// Redirect GET requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="path">Requested path</param>
        /// <param name="file">Requested file</param>
        /// <returns></returns>
        void TelephonyBootstrapPhonesIdPathFileGet (string id, string path, string file);
  
        /// <summary>
        /// Redirect GET requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="path">Requested path</param>
        /// <param name="file">Requested file</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TelephonyBootstrapPhonesIdPathFileGetWithHttpInfo (string id, string path, string file);

        /// <summary>
        /// Redirect GET requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="path">Requested path</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TelephonyBootstrapPhonesIdPathFileGetAsync (string id, string path, string file);

        /// <summary>
        /// Redirect GET requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="path">Requested path</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyBootstrapPhonesIdPathFileGetAsyncWithHttpInfo (string id, string path, string file);
        
        /// <summary>
        /// Redirect PUT requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="path">Requested path</param>
        /// <param name="file">Requested file</param>
        /// <returns></returns>
        void TelephonyBootstrapPhonesIdPathFilePut (string id, string path, string file);
  
        /// <summary>
        /// Redirect PUT requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="path">Requested path</param>
        /// <param name="file">Requested file</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TelephonyBootstrapPhonesIdPathFilePutWithHttpInfo (string id, string path, string file);

        /// <summary>
        /// Redirect PUT requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="path">Requested path</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TelephonyBootstrapPhonesIdPathFilePutAsync (string id, string path, string file);

        /// <summary>
        /// Redirect PUT requests to proper edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="path">Requested path</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyBootstrapPhonesIdPathFilePutAsyncWithHttpInfo (string id, string path, string file);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TelephonyApi : ITelephonyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TelephonyApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TelephonyApi(Configuration configuration = null)
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
        /// Redirect GET requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param> 
        /// <returns></returns>
        public void TelephonyBootstrapPhonesIdGet (string id)
        {
             TelephonyBootstrapPhonesIdGetWithHttpInfo(id);
        }

        /// <summary>
        /// Redirect GET requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TelephonyBootstrapPhonesIdGetWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TelephonyBootstrapPhonesIdGet");
            
    
            var path_ = "/api/v1/telephony/bootstrap/phones/{id}";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Redirect GET requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TelephonyBootstrapPhonesIdGetAsync (string id)
        {
             await TelephonyBootstrapPhonesIdGetAsyncWithHttpInfo(id);

        }

        /// <summary>
        /// Redirect GET requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyBootstrapPhonesIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TelephonyBootstrapPhonesIdGet");
            
    
            var path_ = "/api/v1/telephony/bootstrap/phones/{id}";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Redirect PUT requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param> 
        /// <returns></returns>
        public void TelephonyBootstrapPhonesIdPut (string id)
        {
             TelephonyBootstrapPhonesIdPutWithHttpInfo(id);
        }

        /// <summary>
        /// Redirect PUT requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TelephonyBootstrapPhonesIdPutWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TelephonyBootstrapPhonesIdPut");
            
    
            var path_ = "/api/v1/telephony/bootstrap/phones/{id}";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Redirect PUT requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TelephonyBootstrapPhonesIdPutAsync (string id)
        {
             await TelephonyBootstrapPhonesIdPutAsyncWithHttpInfo(id);

        }

        /// <summary>
        /// Redirect PUT requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyBootstrapPhonesIdPutAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TelephonyBootstrapPhonesIdPut");
            
    
            var path_ = "/api/v1/telephony/bootstrap/phones/{id}";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdPut: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Redirect GET requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param> 
        /// <param name="file">Requested file</param> 
        /// <returns></returns>
        public void TelephonyBootstrapPhonesIdFileGet (string id, string file)
        {
             TelephonyBootstrapPhonesIdFileGetWithHttpInfo(id, file);
        }

        /// <summary>
        /// Redirect GET requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param> 
        /// <param name="file">Requested file</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TelephonyBootstrapPhonesIdFileGetWithHttpInfo (string id, string file)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TelephonyBootstrapPhonesIdFileGet");
            
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling TelephonyBootstrapPhonesIdFileGet");
            
    
            var path_ = "/api/v1/telephony/bootstrap/phones/{id}/{file}";
    
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
            if (file != null) pathParams.Add("file", Configuration.ApiClient.ParameterToString(file)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdFileGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdFileGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Redirect GET requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TelephonyBootstrapPhonesIdFileGetAsync (string id, string file)
        {
             await TelephonyBootstrapPhonesIdFileGetAsyncWithHttpInfo(id, file);

        }

        /// <summary>
        /// Redirect GET requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyBootstrapPhonesIdFileGetAsyncWithHttpInfo (string id, string file)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TelephonyBootstrapPhonesIdFileGet");
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling TelephonyBootstrapPhonesIdFileGet");
            
    
            var path_ = "/api/v1/telephony/bootstrap/phones/{id}/{file}";
    
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
            if (file != null) pathParams.Add("file", Configuration.ApiClient.ParameterToString(file)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdFileGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdFileGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Redirect PUT requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param> 
        /// <param name="file">Requested file</param> 
        /// <returns></returns>
        public void TelephonyBootstrapPhonesIdFilePut (string id, string file)
        {
             TelephonyBootstrapPhonesIdFilePutWithHttpInfo(id, file);
        }

        /// <summary>
        /// Redirect PUT requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param> 
        /// <param name="file">Requested file</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TelephonyBootstrapPhonesIdFilePutWithHttpInfo (string id, string file)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TelephonyBootstrapPhonesIdFilePut");
            
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling TelephonyBootstrapPhonesIdFilePut");
            
    
            var path_ = "/api/v1/telephony/bootstrap/phones/{id}/{file}";
    
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
            if (file != null) pathParams.Add("file", Configuration.ApiClient.ParameterToString(file)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdFilePut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdFilePut: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Redirect PUT requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TelephonyBootstrapPhonesIdFilePutAsync (string id, string file)
        {
             await TelephonyBootstrapPhonesIdFilePutAsyncWithHttpInfo(id, file);

        }

        /// <summary>
        /// Redirect PUT requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyBootstrapPhonesIdFilePutAsyncWithHttpInfo (string id, string file)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TelephonyBootstrapPhonesIdFilePut");
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling TelephonyBootstrapPhonesIdFilePut");
            
    
            var path_ = "/api/v1/telephony/bootstrap/phones/{id}/{file}";
    
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
            if (file != null) pathParams.Add("file", Configuration.ApiClient.ParameterToString(file)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdFilePut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdFilePut: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Redirect GET requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param> 
        /// <param name="path">Requested path</param> 
        /// <param name="file">Requested file</param> 
        /// <returns></returns>
        public void TelephonyBootstrapPhonesIdPathFileGet (string id, string path, string file)
        {
             TelephonyBootstrapPhonesIdPathFileGetWithHttpInfo(id, path, file);
        }

        /// <summary>
        /// Redirect GET requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param> 
        /// <param name="path">Requested path</param> 
        /// <param name="file">Requested file</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TelephonyBootstrapPhonesIdPathFileGetWithHttpInfo (string id, string path, string file)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TelephonyBootstrapPhonesIdPathFileGet");
            
            // verify the required parameter 'path' is set
            if (path == null) throw new ApiException(400, "Missing required parameter 'path' when calling TelephonyBootstrapPhonesIdPathFileGet");
            
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling TelephonyBootstrapPhonesIdPathFileGet");
            
    
            var path_ = "/api/v1/telephony/bootstrap/phones/{id}/{path}/{file}";
    
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
            if (path != null) pathParams.Add("path", Configuration.ApiClient.ParameterToString(path)); // path parameter
            if (file != null) pathParams.Add("file", Configuration.ApiClient.ParameterToString(file)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdPathFileGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdPathFileGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Redirect GET requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="path">Requested path</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TelephonyBootstrapPhonesIdPathFileGetAsync (string id, string path, string file)
        {
             await TelephonyBootstrapPhonesIdPathFileGetAsyncWithHttpInfo(id, path, file);

        }

        /// <summary>
        /// Redirect GET requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="path">Requested path</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyBootstrapPhonesIdPathFileGetAsyncWithHttpInfo (string id, string path, string file)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TelephonyBootstrapPhonesIdPathFileGet");
            // verify the required parameter 'path' is set
            if (path == null) throw new ApiException(400, "Missing required parameter 'path' when calling TelephonyBootstrapPhonesIdPathFileGet");
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling TelephonyBootstrapPhonesIdPathFileGet");
            
    
            var path_ = "/api/v1/telephony/bootstrap/phones/{id}/{path}/{file}";
    
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
            if (path != null) pathParams.Add("path", Configuration.ApiClient.ParameterToString(path)); // path parameter
            if (file != null) pathParams.Add("file", Configuration.ApiClient.ParameterToString(file)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdPathFileGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdPathFileGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Redirect PUT requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param> 
        /// <param name="path">Requested path</param> 
        /// <param name="file">Requested file</param> 
        /// <returns></returns>
        public void TelephonyBootstrapPhonesIdPathFilePut (string id, string path, string file)
        {
             TelephonyBootstrapPhonesIdPathFilePutWithHttpInfo(id, path, file);
        }

        /// <summary>
        /// Redirect PUT requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param> 
        /// <param name="path">Requested path</param> 
        /// <param name="file">Requested file</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TelephonyBootstrapPhonesIdPathFilePutWithHttpInfo (string id, string path, string file)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TelephonyBootstrapPhonesIdPathFilePut");
            
            // verify the required parameter 'path' is set
            if (path == null) throw new ApiException(400, "Missing required parameter 'path' when calling TelephonyBootstrapPhonesIdPathFilePut");
            
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling TelephonyBootstrapPhonesIdPathFilePut");
            
    
            var path_ = "/api/v1/telephony/bootstrap/phones/{id}/{path}/{file}";
    
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
            if (path != null) pathParams.Add("path", Configuration.ApiClient.ParameterToString(path)); // path parameter
            if (file != null) pathParams.Add("file", Configuration.ApiClient.ParameterToString(file)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdPathFilePut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdPathFilePut: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Redirect PUT requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="path">Requested path</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TelephonyBootstrapPhonesIdPathFilePutAsync (string id, string path, string file)
        {
             await TelephonyBootstrapPhonesIdPathFilePutAsyncWithHttpInfo(id, path, file);

        }

        /// <summary>
        /// Redirect PUT requests to proper edge 
        /// </summary>
        /// <param name="id">Phone&#39;s physical address AKA MAC address</param>
        /// <param name="path">Requested path</param>
        /// <param name="file">Requested file</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyBootstrapPhonesIdPathFilePutAsyncWithHttpInfo (string id, string path, string file)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TelephonyBootstrapPhonesIdPathFilePut");
            // verify the required parameter 'path' is set
            if (path == null) throw new ApiException(400, "Missing required parameter 'path' when calling TelephonyBootstrapPhonesIdPathFilePut");
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling TelephonyBootstrapPhonesIdPathFilePut");
            
    
            var path_ = "/api/v1/telephony/bootstrap/phones/{id}/{path}/{file}";
    
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
            if (path != null) pathParams.Add("path", Configuration.ApiClient.ParameterToString(path)); // path parameter
            if (file != null) pathParams.Add("file", Configuration.ApiClient.ParameterToString(file)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdPathFilePut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyBootstrapPhonesIdPathFilePut: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
