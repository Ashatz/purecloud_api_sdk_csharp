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
    public interface ISuggestApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Search using q64
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        JsonNodeSearchResponse GetSearch (string q64 = null, List<string> expand = null, bool? profile = null);

        /// <summary>
        /// Search using q64
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        ApiResponse<JsonNodeSearchResponse> GetSearchWithHttpInfo (string q64 = null, List<string> expand = null, bool? profile = null);
        /// <summary>
        /// Suggest using q64
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        JsonNodeSearchResponse GetSuggest (string q64 = null, bool? profile = null);

        /// <summary>
        /// Suggest using q64
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        ApiResponse<JsonNodeSearchResponse> GetSuggestWithHttpInfo (string q64 = null, bool? profile = null);
        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        JsonNodeSearchResponse PostSearch (SearchRequest body = null, bool? profile = null);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        ApiResponse<JsonNodeSearchResponse> PostSearchWithHttpInfo (SearchRequest body = null, bool? profile = null);
        /// <summary>
        /// Suggest
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        JsonNodeSearchResponse PostSuggest (SuggestSearchRequest body = null, bool? profile = null);

        /// <summary>
        /// Suggest
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        ApiResponse<JsonNodeSearchResponse> PostSuggestWithHttpInfo (SuggestSearchRequest body = null, bool? profile = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Search using q64
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        System.Threading.Tasks.Task<JsonNodeSearchResponse> GetSearchAsync (string q64 = null, List<string> expand = null, bool? profile = null);

        /// <summary>
        /// Search using q64
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> GetSearchAsyncWithHttpInfo (string q64 = null, List<string> expand = null, bool? profile = null);
        /// <summary>
        /// Suggest using q64
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        System.Threading.Tasks.Task<JsonNodeSearchResponse> GetSuggestAsync (string q64 = null, bool? profile = null);

        /// <summary>
        /// Suggest using q64
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> GetSuggestAsyncWithHttpInfo (string q64 = null, bool? profile = null);
        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        System.Threading.Tasks.Task<JsonNodeSearchResponse> PostSearchAsync (SearchRequest body = null, bool? profile = null);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> PostSearchAsyncWithHttpInfo (SearchRequest body = null, bool? profile = null);
        /// <summary>
        /// Suggest
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        System.Threading.Tasks.Task<JsonNodeSearchResponse> PostSuggestAsync (SuggestSearchRequest body = null, bool? profile = null);

        /// <summary>
        /// Suggest
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> PostSuggestAsyncWithHttpInfo (SuggestSearchRequest body = null, bool? profile = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SuggestApi : ISuggestApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SuggestApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SuggestApi(Configuration configuration = null)
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
        /// Search using q64 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        public JsonNodeSearchResponse GetSearch (string q64 = null, List<string> expand = null, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = GetSearchWithHttpInfo(q64, expand, profile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search using q64 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        public ApiResponse< JsonNodeSearchResponse > GetSearchWithHttpInfo (string q64 = null, List<string> expand = null, bool? profile = null)
        {

            var localVarPath = "/api/v2/search";
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
            if (q64 != null) localVarQueryParams.Add("q64", Configuration.ApiClient.ParameterToString(q64)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetSearch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

        /// <summary>
        /// Search using q64 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        public async System.Threading.Tasks.Task<JsonNodeSearchResponse> GetSearchAsync (string q64 = null, List<string> expand = null, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = await GetSearchAsyncWithHttpInfo(q64, expand, profile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search using q64 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> GetSearchAsyncWithHttpInfo (string q64 = null, List<string> expand = null, bool? profile = null)
        {

            var localVarPath = "/api/v2/search";
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
            if (q64 != null) localVarQueryParams.Add("q64", Configuration.ApiClient.ParameterToString(q64)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetSearch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

        /// <summary>
        /// Suggest using q64 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        public JsonNodeSearchResponse GetSuggest (string q64 = null, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = GetSuggestWithHttpInfo(q64, profile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Suggest using q64 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        public ApiResponse< JsonNodeSearchResponse > GetSuggestWithHttpInfo (string q64 = null, bool? profile = null)
        {

            var localVarPath = "/api/v2/search/suggest";
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
            if (q64 != null) localVarQueryParams.Add("q64", Configuration.ApiClient.ParameterToString(q64)); // query parameter
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetSuggest: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSuggest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

        /// <summary>
        /// Suggest using q64 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        public async System.Threading.Tasks.Task<JsonNodeSearchResponse> GetSuggestAsync (string q64 = null, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = await GetSuggestAsyncWithHttpInfo(q64, profile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Suggest using q64 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64"> (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> GetSuggestAsyncWithHttpInfo (string q64 = null, bool? profile = null)
        {

            var localVarPath = "/api/v2/search/suggest";
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
            if (q64 != null) localVarQueryParams.Add("q64", Configuration.ApiClient.ParameterToString(q64)); // query parameter
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetSuggest: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSuggest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

        /// <summary>
        /// Search 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        public JsonNodeSearchResponse PostSearch (SearchRequest body = null, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = PostSearchWithHttpInfo(body, profile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        public ApiResponse< JsonNodeSearchResponse > PostSearchWithHttpInfo (SearchRequest body = null, bool? profile = null)
        {

            var localVarPath = "/api/v2/search";
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
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostSearch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

        /// <summary>
        /// Search 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        public async System.Threading.Tasks.Task<JsonNodeSearchResponse> PostSearchAsync (SearchRequest body = null, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = await PostSearchAsyncWithHttpInfo(body, profile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> PostSearchAsyncWithHttpInfo (SearchRequest body = null, bool? profile = null)
        {

            var localVarPath = "/api/v2/search";
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
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostSearch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

        /// <summary>
        /// Suggest 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>JsonNodeSearchResponse</returns>
        public JsonNodeSearchResponse PostSuggest (SuggestSearchRequest body = null, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = PostSuggestWithHttpInfo(body, profile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Suggest 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>ApiResponse of JsonNodeSearchResponse</returns>
        public ApiResponse< JsonNodeSearchResponse > PostSuggestWithHttpInfo (SuggestSearchRequest body = null, bool? profile = null)
        {

            var localVarPath = "/api/v2/search/suggest";
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
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostSuggest: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSuggest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

        /// <summary>
        /// Suggest 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of JsonNodeSearchResponse</returns>
        public async System.Threading.Tasks.Task<JsonNodeSearchResponse> PostSuggestAsync (SuggestSearchRequest body = null, bool? profile = null)
        {
             ApiResponse<JsonNodeSearchResponse> localVarResponse = await PostSuggestAsyncWithHttpInfo(body, profile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Suggest 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options (optional)</param>
        /// <param name="profile"> (optional, default to true)</param>
        /// <returns>Task of ApiResponse (JsonNodeSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonNodeSearchResponse>> PostSuggestAsyncWithHttpInfo (SuggestSearchRequest body = null, bool? profile = null)
        {

            var localVarPath = "/api/v2/search/suggest";
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
            if (profile != null) localVarQueryParams.Add("profile", Configuration.ApiClient.ParameterToString(profile)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostSuggest: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSuggest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonNodeSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JsonNodeSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonNodeSearchResponse)));
            
        }

    }
}
