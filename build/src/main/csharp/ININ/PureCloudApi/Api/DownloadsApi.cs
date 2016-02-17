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
    public interface IDownloadsApi
    {
        
        /// <summary>
        /// OAuth Callback used during code authorization grant flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="code"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        void GetCallback (string code = null, string state = null);
  
        /// <summary>
        /// OAuth Callback used during code authorization grant flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="code"></param>
        /// <param name="state"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetCallbackWithHttpInfo (string code = null, string state = null);

        /// <summary>
        /// OAuth Callback used during code authorization grant flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="code"></param>
        /// <param name="state"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetCallbackAsync (string code = null, string state = null);

        /// <summary>
        /// OAuth Callback used during code authorization grant flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="code"></param>
        /// <param name="state"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetCallbackAsyncWithHttpInfo (string code = null, string state = null);
        
        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download
        /// </summary>
        /// <remarks>
        /// this method will issue a redirect to the url to the content
        /// </remarks>
        /// <param name="downloadId">Download ID</param>
        /// <param name="contentDisposition"></param>
        /// <returns>UrlResponse</returns>
        UrlResponse Get (string downloadId, string contentDisposition = null);
  
        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download
        /// </summary>
        /// <remarks>
        /// this method will issue a redirect to the url to the content
        /// </remarks>
        /// <param name="downloadId">Download ID</param>
        /// <param name="contentDisposition"></param>
        /// <returns>ApiResponse of UrlResponse</returns>
        ApiResponse<UrlResponse> GetWithHttpInfo (string downloadId, string contentDisposition = null);

        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download
        /// </summary>
        /// <remarks>
        /// this method will issue a redirect to the url to the content
        /// </remarks>
        /// <param name="downloadId">Download ID</param>
        /// <param name="contentDisposition"></param>
        /// <returns>Task of UrlResponse</returns>
        System.Threading.Tasks.Task<UrlResponse> GetAsync (string downloadId, string contentDisposition = null);

        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download
        /// </summary>
        /// <remarks>
        /// this method will issue a redirect to the url to the content
        /// </remarks>
        /// <param name="downloadId">Download ID</param>
        /// <param name="contentDisposition"></param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UrlResponse>> GetAsyncWithHttpInfo (string downloadId, string contentDisposition = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DownloadsApi : IDownloadsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DownloadsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DownloadsApi(Configuration configuration = null)
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
        /// OAuth Callback used during code authorization grant flow. 
        /// </summary>
        /// <param name="code"></param> 
        /// <param name="state"></param> 
        /// <returns></returns>
        public void GetCallback (string code = null, string state = null)
        {
             GetCallbackWithHttpInfo(code, state);
        }

        /// <summary>
        /// OAuth Callback used during code authorization grant flow. 
        /// </summary>
        /// <param name="code"></param> 
        /// <param name="state"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetCallbackWithHttpInfo (string code = null, string state = null)
        {
            
    
            var path_ = "/api/v1/downloads/callback";
    
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
            
            if (code != null) queryParams.Add("code", Configuration.ApiClient.ParameterToString(code)); // query parameter
            if (state != null) queryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetCallback: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCallback: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// OAuth Callback used during code authorization grant flow. 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="state"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetCallbackAsync (string code = null, string state = null)
        {
             await GetCallbackAsyncWithHttpInfo(code, state);

        }

        /// <summary>
        /// OAuth Callback used during code authorization grant flow. 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="state"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetCallbackAsyncWithHttpInfo (string code = null, string state = null)
        {
            
    
            var path_ = "/api/v1/downloads/callback";
    
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
            
            if (code != null) queryParams.Add("code", Configuration.ApiClient.ParameterToString(code)); // query parameter
            if (state != null) queryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetCallback: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCallback: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download this method will issue a redirect to the url to the content
        /// </summary>
        /// <param name="downloadId">Download ID</param> 
        /// <param name="contentDisposition"></param> 
        /// <returns>UrlResponse</returns>
        public UrlResponse Get (string downloadId, string contentDisposition = null)
        {
             ApiResponse<UrlResponse> response = GetWithHttpInfo(downloadId, contentDisposition);
             return response.Data;
        }

        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download this method will issue a redirect to the url to the content
        /// </summary>
        /// <param name="downloadId">Download ID</param> 
        /// <param name="contentDisposition"></param> 
        /// <returns>ApiResponse of UrlResponse</returns>
        public ApiResponse< UrlResponse > GetWithHttpInfo (string downloadId, string contentDisposition = null)
        {
            
            // verify the required parameter 'downloadId' is set
            if (downloadId == null)
                throw new ApiException(400, "Missing required parameter 'downloadId' when calling DownloadsApi->Get");
            
    
            var path_ = "/api/v1/downloads/{downloadId}";
    
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
            if (downloadId != null) pathParams.Add("downloadId", Configuration.ApiClient.ParameterToString(downloadId)); // path parameter
            
            if (contentDisposition != null) queryParams.Add("contentDisposition", Configuration.ApiClient.ParameterToString(contentDisposition)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UrlResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UrlResponse) Configuration.ApiClient.Deserialize(response, typeof(UrlResponse)));
            
        }
    
        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download this method will issue a redirect to the url to the content
        /// </summary>
        /// <param name="downloadId">Download ID</param>
        /// <param name="contentDisposition"></param>
        /// <returns>Task of UrlResponse</returns>
        public async System.Threading.Tasks.Task<UrlResponse> GetAsync (string downloadId, string contentDisposition = null)
        {
             ApiResponse<UrlResponse> response = await GetAsyncWithHttpInfo(downloadId, contentDisposition);
             return response.Data;

        }

        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download this method will issue a redirect to the url to the content
        /// </summary>
        /// <param name="downloadId">Download ID</param>
        /// <param name="contentDisposition"></param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UrlResponse>> GetAsyncWithHttpInfo (string downloadId, string contentDisposition = null)
        {
            // verify the required parameter 'downloadId' is set
            if (downloadId == null) throw new ApiException(400, "Missing required parameter 'downloadId' when calling Get");
            
    
            var path_ = "/api/v1/downloads/{downloadId}";
    
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
            if (downloadId != null) pathParams.Add("downloadId", Configuration.ApiClient.ParameterToString(downloadId)); // path parameter
            
            if (contentDisposition != null) queryParams.Add("contentDisposition", Configuration.ApiClient.ParameterToString(contentDisposition)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UrlResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UrlResponse) Configuration.ApiClient.Deserialize(response, typeof(UrlResponse)));
            
        }
        
    }
    
}
