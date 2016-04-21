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
    public interface IDownloadsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// OAuth Callback used during code authorization grant flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <returns></returns>
        void DownloadsCallbackGet (string code = null, string state = null);

        /// <summary>
        /// OAuth Callback used during code authorization grant flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DownloadsCallbackGetWithHttpInfo (string code = null, string state = null);
        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download
        /// </summary>
        /// <remarks>
        /// this method will issue a redirect to the url to the content
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">Download ID</param>
        /// <param name="contentDisposition"> (optional, default to attachment)</param>
        /// <returns>UrlResponse</returns>
        UrlResponse DownloadsDownloadidGet (string downloadId, string contentDisposition = null);

        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download
        /// </summary>
        /// <remarks>
        /// this method will issue a redirect to the url to the content
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">Download ID</param>
        /// <param name="contentDisposition"> (optional, default to attachment)</param>
        /// <returns>ApiResponse of UrlResponse</returns>
        ApiResponse<UrlResponse> DownloadsDownloadidGetWithHttpInfo (string downloadId, string contentDisposition = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// OAuth Callback used during code authorization grant flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DownloadsCallbackGetAsync (string code = null, string state = null);

        /// <summary>
        /// OAuth Callback used during code authorization grant flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DownloadsCallbackGetAsyncWithHttpInfo (string code = null, string state = null);
        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download
        /// </summary>
        /// <remarks>
        /// this method will issue a redirect to the url to the content
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">Download ID</param>
        /// <param name="contentDisposition"> (optional, default to attachment)</param>
        /// <returns>Task of UrlResponse</returns>
        System.Threading.Tasks.Task<UrlResponse> DownloadsDownloadidGetAsync (string downloadId, string contentDisposition = null);

        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download
        /// </summary>
        /// <remarks>
        /// this method will issue a redirect to the url to the content
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">Download ID</param>
        /// <param name="contentDisposition"> (optional, default to attachment)</param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UrlResponse>> DownloadsDownloadidGetAsyncWithHttpInfo (string downloadId, string contentDisposition = null);
        #endregion Asynchronous Operations
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

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        /// OAuth Callback used during code authorization grant flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <returns></returns>
        public void DownloadsCallbackGet (string code = null, string state = null)
        {
             DownloadsCallbackGetWithHttpInfo(code, state);
        }

        /// <summary>
        /// OAuth Callback used during code authorization grant flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DownloadsCallbackGetWithHttpInfo (string code = null, string state = null)
        {

            var localVarPath = "/api/v1/downloads/callback";
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
            if (code != null) localVarQueryParams.Add("code", Configuration.ApiClient.ParameterToString(code)); // query parameter
            if (state != null) localVarQueryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DownloadsCallbackGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DownloadsCallbackGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// OAuth Callback used during code authorization grant flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DownloadsCallbackGetAsync (string code = null, string state = null)
        {
             await DownloadsCallbackGetAsyncWithHttpInfo(code, state);

        }

        /// <summary>
        /// OAuth Callback used during code authorization grant flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DownloadsCallbackGetAsyncWithHttpInfo (string code = null, string state = null)
        {

            var localVarPath = "/api/v1/downloads/callback";
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
            if (code != null) localVarQueryParams.Add("code", Configuration.ApiClient.ParameterToString(code)); // query parameter
            if (state != null) localVarQueryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DownloadsCallbackGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DownloadsCallbackGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download this method will issue a redirect to the url to the content
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">Download ID</param>
        /// <param name="contentDisposition"> (optional, default to attachment)</param>
        /// <returns>UrlResponse</returns>
        public UrlResponse DownloadsDownloadidGet (string downloadId, string contentDisposition = null)
        {
             ApiResponse<UrlResponse> localVarResponse = DownloadsDownloadidGetWithHttpInfo(downloadId, contentDisposition);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download this method will issue a redirect to the url to the content
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">Download ID</param>
        /// <param name="contentDisposition"> (optional, default to attachment)</param>
        /// <returns>ApiResponse of UrlResponse</returns>
        public ApiResponse< UrlResponse > DownloadsDownloadidGetWithHttpInfo (string downloadId, string contentDisposition = null)
        {
            // verify the required parameter 'downloadId' is set
            if (downloadId == null)
                throw new ApiException(400, "Missing required parameter 'downloadId' when calling DownloadsApi->DownloadsDownloadidGet");

            var localVarPath = "/api/v1/downloads/{downloadId}";
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
            if (downloadId != null) localVarPathParams.Add("downloadId", Configuration.ApiClient.ParameterToString(downloadId)); // path parameter
            if (contentDisposition != null) localVarQueryParams.Add("contentDisposition", Configuration.ApiClient.ParameterToString(contentDisposition)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DownloadsDownloadidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DownloadsDownloadidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UrlResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UrlResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UrlResponse)));
            
        }

        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download this method will issue a redirect to the url to the content
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">Download ID</param>
        /// <param name="contentDisposition"> (optional, default to attachment)</param>
        /// <returns>Task of UrlResponse</returns>
        public async System.Threading.Tasks.Task<UrlResponse> DownloadsDownloadidGetAsync (string downloadId, string contentDisposition = null)
        {
             ApiResponse<UrlResponse> localVarResponse = await DownloadsDownloadidGetAsyncWithHttpInfo(downloadId, contentDisposition);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Issues a redirect to a signed secure download URL for specified download this method will issue a redirect to the url to the content
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadId">Download ID</param>
        /// <param name="contentDisposition"> (optional, default to attachment)</param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UrlResponse>> DownloadsDownloadidGetAsyncWithHttpInfo (string downloadId, string contentDisposition = null)
        {
            // verify the required parameter 'downloadId' is set
            if (downloadId == null)
                throw new ApiException(400, "Missing required parameter 'downloadId' when calling DownloadsApi->DownloadsDownloadidGet");

            var localVarPath = "/api/v1/downloads/{downloadId}";
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
            if (downloadId != null) localVarPathParams.Add("downloadId", Configuration.ApiClient.ParameterToString(downloadId)); // path parameter
            if (contentDisposition != null) localVarQueryParams.Add("contentDisposition", Configuration.ApiClient.ParameterToString(contentDisposition)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DownloadsDownloadidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DownloadsDownloadidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UrlResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UrlResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UrlResponse)));
            
        }

    }
}
