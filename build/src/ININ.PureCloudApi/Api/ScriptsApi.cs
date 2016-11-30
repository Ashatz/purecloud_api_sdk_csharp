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
    public interface IScriptsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the published scripts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>ScriptEntityListing</returns>
        ScriptEntityListing GetPublished (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null);

        /// <summary>
        /// Get the published scripts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>ApiResponse of ScriptEntityListing</returns>
        ApiResponse<ScriptEntityListing> GetPublishedWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null);
        /// <summary>
        /// Get the published script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Script</returns>
        Script GetPublishedScriptId (string scriptId);

        /// <summary>
        /// Get the published script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of Script</returns>
        ApiResponse<Script> GetPublishedScriptIdWithHttpInfo (string scriptId);
        /// <summary>
        /// Get the list of published pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>List&lt;Page&gt;</returns>
        List<Page> GetPublishedScriptIdPages (string scriptId);

        /// <summary>
        /// Get the list of published pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of List&lt;Page&gt;</returns>
        ApiResponse<List<Page>> GetPublishedScriptIdPagesWithHttpInfo (string scriptId);
        /// <summary>
        /// Get the published page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Page</returns>
        Page GetPublishedScriptIdPagesPageId (string scriptId, string pageId);

        /// <summary>
        /// Get the published page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>ApiResponse of Page</returns>
        ApiResponse<Page> GetPublishedScriptIdPagesPageIdWithHttpInfo (string scriptId, string pageId);
        /// <summary>
        /// Get the published variables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Object</returns>
        Object GetPublishedScriptIdVariables (string scriptId);

        /// <summary>
        /// Get the published variables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GetPublishedScriptIdVariablesWithHttpInfo (string scriptId);
        /// <summary>
        /// Get a script
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Script</returns>
        Script GetScriptId (string scriptId);

        /// <summary>
        /// Get a script
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of Script</returns>
        ApiResponse<Script> GetScriptIdWithHttpInfo (string scriptId);
        /// <summary>
        /// Get the list of pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>List&lt;Page&gt;</returns>
        List<Page> GetScriptIdPages (string scriptId);

        /// <summary>
        /// Get the list of pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of List&lt;Page&gt;</returns>
        ApiResponse<List<Page>> GetScriptIdPagesWithHttpInfo (string scriptId);
        /// <summary>
        /// Get a page
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Page</returns>
        Page GetScriptIdPagesPageId (string scriptId, string pageId);

        /// <summary>
        /// Get a page
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>ApiResponse of Page</returns>
        ApiResponse<Page> GetScriptIdPagesPageIdWithHttpInfo (string scriptId, string pageId);
        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>ScriptEntityListing</returns>
        ScriptEntityListing GetScripts (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>ApiResponse of ScriptEntityListing</returns>
        ApiResponse<ScriptEntityListing> GetScriptsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get the published scripts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>Task of ScriptEntityListing</returns>
        System.Threading.Tasks.Task<ScriptEntityListing> GetPublishedAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null);

        /// <summary>
        /// Get the published scripts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> GetPublishedAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null);
        /// <summary>
        /// Get the published script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of Script</returns>
        System.Threading.Tasks.Task<Script> GetPublishedScriptIdAsync (string scriptId);

        /// <summary>
        /// Get the published script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        System.Threading.Tasks.Task<ApiResponse<Script>> GetPublishedScriptIdAsyncWithHttpInfo (string scriptId);
        /// <summary>
        /// Get the list of published pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of List&lt;Page&gt;</returns>
        System.Threading.Tasks.Task<List<Page>> GetPublishedScriptIdPagesAsync (string scriptId);

        /// <summary>
        /// Get the list of published pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Page>>> GetPublishedScriptIdPagesAsyncWithHttpInfo (string scriptId);
        /// <summary>
        /// Get the published page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of Page</returns>
        System.Threading.Tasks.Task<Page> GetPublishedScriptIdPagesPageIdAsync (string scriptId, string pageId);

        /// <summary>
        /// Get the published page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of ApiResponse (Page)</returns>
        System.Threading.Tasks.Task<ApiResponse<Page>> GetPublishedScriptIdPagesPageIdAsyncWithHttpInfo (string scriptId, string pageId);
        /// <summary>
        /// Get the published variables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GetPublishedScriptIdVariablesAsync (string scriptId);

        /// <summary>
        /// Get the published variables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetPublishedScriptIdVariablesAsyncWithHttpInfo (string scriptId);
        /// <summary>
        /// Get a script
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of Script</returns>
        System.Threading.Tasks.Task<Script> GetScriptIdAsync (string scriptId);

        /// <summary>
        /// Get a script
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        System.Threading.Tasks.Task<ApiResponse<Script>> GetScriptIdAsyncWithHttpInfo (string scriptId);
        /// <summary>
        /// Get the list of pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of List&lt;Page&gt;</returns>
        System.Threading.Tasks.Task<List<Page>> GetScriptIdPagesAsync (string scriptId);

        /// <summary>
        /// Get the list of pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Page>>> GetScriptIdPagesAsyncWithHttpInfo (string scriptId);
        /// <summary>
        /// Get a page
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of Page</returns>
        System.Threading.Tasks.Task<Page> GetScriptIdPagesPageIdAsync (string scriptId, string pageId);

        /// <summary>
        /// Get a page
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of ApiResponse (Page)</returns>
        System.Threading.Tasks.Task<ApiResponse<Page>> GetScriptIdPagesPageIdAsyncWithHttpInfo (string scriptId, string pageId);
        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>Task of ScriptEntityListing</returns>
        System.Threading.Tasks.Task<ScriptEntityListing> GetScriptsAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> GetScriptsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ScriptsApi : IScriptsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScriptsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ScriptsApi(Configuration configuration = null)
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
        /// Get the published scripts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>ScriptEntityListing</returns>
        public ScriptEntityListing GetPublished (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null)
        {
             ApiResponse<ScriptEntityListing> localVarResponse = GetPublishedWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published scripts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>ApiResponse of ScriptEntityListing</returns>
        public ApiResponse< ScriptEntityListing > GetPublishedWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null)
        {

            var localVarPath = "/api/v2/scripts/published";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (feature != null) localVarQueryParams.Add("feature", Configuration.ApiClient.ParameterToString(feature)); // query parameter
            if (flowId != null) localVarQueryParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetPublished: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPublished: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScriptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)));
            
        }

        /// <summary>
        /// Get the published scripts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>Task of ScriptEntityListing</returns>
        public async System.Threading.Tasks.Task<ScriptEntityListing> GetPublishedAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null)
        {
             ApiResponse<ScriptEntityListing> localVarResponse = await GetPublishedAsyncWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published scripts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> GetPublishedAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null)
        {

            var localVarPath = "/api/v2/scripts/published";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (feature != null) localVarQueryParams.Add("feature", Configuration.ApiClient.ParameterToString(feature)); // query parameter
            if (flowId != null) localVarQueryParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetPublished: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPublished: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScriptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)));
            
        }

        /// <summary>
        /// Get the published script. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Script</returns>
        public Script GetPublishedScriptId (string scriptId)
        {
             ApiResponse<Script> localVarResponse = GetPublishedScriptIdWithHttpInfo(scriptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published script. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of Script</returns>
        public ApiResponse< Script > GetPublishedScriptIdWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetPublishedScriptId");

            var localVarPath = "/api/v2/scripts/published/{scriptId}";
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
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Script>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)));
            
        }

        /// <summary>
        /// Get the published script. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of Script</returns>
        public async System.Threading.Tasks.Task<Script> GetPublishedScriptIdAsync (string scriptId)
        {
             ApiResponse<Script> localVarResponse = await GetPublishedScriptIdAsyncWithHttpInfo(scriptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published script. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Script>> GetPublishedScriptIdAsyncWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetPublishedScriptId");

            var localVarPath = "/api/v2/scripts/published/{scriptId}";
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
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Script>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)));
            
        }

        /// <summary>
        /// Get the list of published pages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>List&lt;Page&gt;</returns>
        public List<Page> GetPublishedScriptIdPages (string scriptId)
        {
             ApiResponse<List<Page>> localVarResponse = GetPublishedScriptIdPagesWithHttpInfo(scriptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of published pages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of List&lt;Page&gt;</returns>
        public ApiResponse< List<Page> > GetPublishedScriptIdPagesWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetPublishedScriptIdPages");

            var localVarPath = "/api/v2/scripts/published/{scriptId}/pages";
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
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptIdPages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptIdPages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Page>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Page>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Page>)));
            
        }

        /// <summary>
        /// Get the list of published pages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of List&lt;Page&gt;</returns>
        public async System.Threading.Tasks.Task<List<Page>> GetPublishedScriptIdPagesAsync (string scriptId)
        {
             ApiResponse<List<Page>> localVarResponse = await GetPublishedScriptIdPagesAsyncWithHttpInfo(scriptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of published pages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Page>>> GetPublishedScriptIdPagesAsyncWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetPublishedScriptIdPages");

            var localVarPath = "/api/v2/scripts/published/{scriptId}/pages";
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
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptIdPages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptIdPages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Page>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Page>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Page>)));
            
        }

        /// <summary>
        /// Get the published page. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Page</returns>
        public Page GetPublishedScriptIdPagesPageId (string scriptId, string pageId)
        {
             ApiResponse<Page> localVarResponse = GetPublishedScriptIdPagesPageIdWithHttpInfo(scriptId, pageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published page. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>ApiResponse of Page</returns>
        public ApiResponse< Page > GetPublishedScriptIdPagesPageIdWithHttpInfo (string scriptId, string pageId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetPublishedScriptIdPagesPageId");
            // verify the required parameter 'pageId' is set
            if (pageId == null)
                throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsApi->GetPublishedScriptIdPagesPageId");

            var localVarPath = "/api/v2/scripts/published/{scriptId}/pages/{pageId}";
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
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            if (pageId != null) localVarPathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptIdPagesPageId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptIdPagesPageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Page>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Page) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Page)));
            
        }

        /// <summary>
        /// Get the published page. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of Page</returns>
        public async System.Threading.Tasks.Task<Page> GetPublishedScriptIdPagesPageIdAsync (string scriptId, string pageId)
        {
             ApiResponse<Page> localVarResponse = await GetPublishedScriptIdPagesPageIdAsyncWithHttpInfo(scriptId, pageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published page. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of ApiResponse (Page)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Page>> GetPublishedScriptIdPagesPageIdAsyncWithHttpInfo (string scriptId, string pageId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetPublishedScriptIdPagesPageId");
            // verify the required parameter 'pageId' is set
            if (pageId == null)
                throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsApi->GetPublishedScriptIdPagesPageId");

            var localVarPath = "/api/v2/scripts/published/{scriptId}/pages/{pageId}";
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
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            if (pageId != null) localVarPathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptIdPagesPageId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptIdPagesPageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Page>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Page) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Page)));
            
        }

        /// <summary>
        /// Get the published variables 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Object</returns>
        public Object GetPublishedScriptIdVariables (string scriptId)
        {
             ApiResponse<Object> localVarResponse = GetPublishedScriptIdVariablesWithHttpInfo(scriptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published variables 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GetPublishedScriptIdVariablesWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetPublishedScriptIdVariables");

            var localVarPath = "/api/v2/scripts/published/{scriptId}/variables";
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
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptIdVariables: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptIdVariables: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Get the published variables 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GetPublishedScriptIdVariablesAsync (string scriptId)
        {
             ApiResponse<Object> localVarResponse = await GetPublishedScriptIdVariablesAsyncWithHttpInfo(scriptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published variables 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetPublishedScriptIdVariablesAsyncWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetPublishedScriptIdVariables");

            var localVarPath = "/api/v2/scripts/published/{scriptId}/variables";
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
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptIdVariables: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedScriptIdVariables: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Get a script 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Script</returns>
        public Script GetScriptId (string scriptId)
        {
             ApiResponse<Script> localVarResponse = GetScriptIdWithHttpInfo(scriptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a script 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of Script</returns>
        public ApiResponse< Script > GetScriptIdWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptId");

            var localVarPath = "/api/v2/scripts/{scriptId}";
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
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Script>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)));
            
        }

        /// <summary>
        /// Get a script 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of Script</returns>
        public async System.Threading.Tasks.Task<Script> GetScriptIdAsync (string scriptId)
        {
             ApiResponse<Script> localVarResponse = await GetScriptIdAsyncWithHttpInfo(scriptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a script 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Script>> GetScriptIdAsyncWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptId");

            var localVarPath = "/api/v2/scripts/{scriptId}";
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
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Script>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)));
            
        }

        /// <summary>
        /// Get the list of pages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>List&lt;Page&gt;</returns>
        public List<Page> GetScriptIdPages (string scriptId)
        {
             ApiResponse<List<Page>> localVarResponse = GetScriptIdPagesWithHttpInfo(scriptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of pages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of List&lt;Page&gt;</returns>
        public ApiResponse< List<Page> > GetScriptIdPagesWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptIdPages");

            var localVarPath = "/api/v2/scripts/{scriptId}/pages";
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
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptIdPages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptIdPages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Page>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Page>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Page>)));
            
        }

        /// <summary>
        /// Get the list of pages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of List&lt;Page&gt;</returns>
        public async System.Threading.Tasks.Task<List<Page>> GetScriptIdPagesAsync (string scriptId)
        {
             ApiResponse<List<Page>> localVarResponse = await GetScriptIdPagesAsyncWithHttpInfo(scriptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of pages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Page>>> GetScriptIdPagesAsyncWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptIdPages");

            var localVarPath = "/api/v2/scripts/{scriptId}/pages";
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
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptIdPages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptIdPages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Page>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Page>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Page>)));
            
        }

        /// <summary>
        /// Get a page 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Page</returns>
        public Page GetScriptIdPagesPageId (string scriptId, string pageId)
        {
             ApiResponse<Page> localVarResponse = GetScriptIdPagesPageIdWithHttpInfo(scriptId, pageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a page 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>ApiResponse of Page</returns>
        public ApiResponse< Page > GetScriptIdPagesPageIdWithHttpInfo (string scriptId, string pageId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptIdPagesPageId");
            // verify the required parameter 'pageId' is set
            if (pageId == null)
                throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsApi->GetScriptIdPagesPageId");

            var localVarPath = "/api/v2/scripts/{scriptId}/pages/{pageId}";
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
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            if (pageId != null) localVarPathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptIdPagesPageId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptIdPagesPageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Page>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Page) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Page)));
            
        }

        /// <summary>
        /// Get a page 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of Page</returns>
        public async System.Threading.Tasks.Task<Page> GetScriptIdPagesPageIdAsync (string scriptId, string pageId)
        {
             ApiResponse<Page> localVarResponse = await GetScriptIdPagesPageIdAsyncWithHttpInfo(scriptId, pageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a page 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of ApiResponse (Page)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Page>> GetScriptIdPagesPageIdAsyncWithHttpInfo (string scriptId, string pageId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null)
                throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsApi->GetScriptIdPagesPageId");
            // verify the required parameter 'pageId' is set
            if (pageId == null)
                throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsApi->GetScriptIdPagesPageId");

            var localVarPath = "/api/v2/scripts/{scriptId}/pages/{pageId}";
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
            if (scriptId != null) localVarPathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            if (pageId != null) localVarPathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScriptIdPagesPageId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScriptIdPagesPageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Page>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Page) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Page)));
            
        }

        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>ScriptEntityListing</returns>
        public ScriptEntityListing GetScripts (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScriptEntityListing> localVarResponse = GetScriptsWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>ApiResponse of ScriptEntityListing</returns>
        public ApiResponse< ScriptEntityListing > GetScriptsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/scripts";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (feature != null) localVarQueryParams.Add("feature", Configuration.ApiClient.ParameterToString(feature)); // query parameter
            if (flowId != null) localVarQueryParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScripts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScripts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScriptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)));
            
        }

        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>Task of ScriptEntityListing</returns>
        public async System.Threading.Tasks.Task<ScriptEntityListing> GetScriptsAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScriptEntityListing> localVarResponse = await GetScriptsAsyncWithHttpInfo(pageSize, pageNumber, expand, name, feature, flowId, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name filter (optional)</param>
        /// <param name="feature">Feature filter (optional)</param>
        /// <param name="flowId">Secure flow id filter (optional)</param>
        /// <param name="sortBy">SortBy (optional)</param>
        /// <param name="sortOrder">SortOrder (optional)</param>
        /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> GetScriptsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/scripts";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (feature != null) localVarQueryParams.Add("feature", Configuration.ApiClient.ParameterToString(feature)); // query parameter
            if (flowId != null) localVarQueryParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScripts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScripts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScriptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)));
            
        }

    }
}
