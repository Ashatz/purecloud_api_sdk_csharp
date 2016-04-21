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
    public interface IPresenceApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>OrganizationPresenceEntityListing</returns>
        OrganizationPresenceEntityListing PresencedefinitionsGet (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of OrganizationPresenceEntityListing</returns>
        ApiResponse<OrganizationPresenceEntityListing> PresencedefinitionsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PresencedefinitionsPost (OrganizationPresence body);

        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PresencedefinitionsPostWithHttpInfo (OrganizationPresence body);
        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PresencedefinitionsPresenceidDelete (string presenceId);

        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PresencedefinitionsPresenceidDeleteWithHttpInfo (string presenceId);
        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PresencedefinitionsPresenceidGet (string presenceId);

        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PresencedefinitionsPresenceidGetWithHttpInfo (string presenceId);
        /// <summary>
        /// Update an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PresencedefinitionsPresenceidPut (string presenceId, OrganizationPresence body);

        /// <summary>
        /// Update an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PresencedefinitionsPresenceidPutWithHttpInfo (string presenceId, OrganizationPresence body);
        /// <summary>
        /// Get an User&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>UserPresenceEntityListing</returns>
        UserPresenceEntityListing UsersUseridPresencesGet (string userId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get an User&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of UserPresenceEntityListing</returns>
        ApiResponse<UserPresenceEntityListing> UsersUseridPresencesGetWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Get a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>UserPresence</returns>
        UserPresence UsersUseridPresencesSourceGet (string userId, string source);

        /// <summary>
        /// Get a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> UsersUseridPresencesSourceGetWithHttpInfo (string userId, string source);
        /// <summary>
        /// Patch a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>UserPresence</returns>
        UserPresence UsersUseridPresencesSourcePatch (string userId, string source, UserPresence body);

        /// <summary>
        /// Patch a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> UsersUseridPresencesSourcePatchWithHttpInfo (string userId, string source, UserPresence body);
        /// <summary>
        /// Update a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>UserPresence</returns>
        UserPresence UsersUseridPresencesSourcePut (string userId, string source, UserPresence body);

        /// <summary>
        /// Update a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> UsersUseridPresencesSourcePutWithHttpInfo (string userId, string source, UserPresence body);
        /// <summary>
        /// Get a user&#39;s Primary UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>UserPresence</returns>
        UserPresence UsersUseridPrimarypresenceGet (string userId);

        /// <summary>
        /// Get a user&#39;s Primary UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> UsersUseridPrimarypresenceGetWithHttpInfo (string userId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of OrganizationPresenceEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationPresenceEntityListing> PresencedefinitionsGetAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (OrganizationPresenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresenceEntityListing>> PresencedefinitionsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPostAsync (OrganizationPresence body);

        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPostAsyncWithHttpInfo (OrganizationPresence body);
        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidDeleteAsync (string presenceId);

        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidDeleteAsyncWithHttpInfo (string presenceId);
        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidGetAsync (string presenceId);

        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidGetAsyncWithHttpInfo (string presenceId);
        /// <summary>
        /// Update an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidPutAsync (string presenceId, OrganizationPresence body);

        /// <summary>
        /// Update an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidPutAsyncWithHttpInfo (string presenceId, OrganizationPresence body);
        /// <summary>
        /// Get an User&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of UserPresenceEntityListing</returns>
        System.Threading.Tasks.Task<UserPresenceEntityListing> UsersUseridPresencesGetAsync (string userId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get an User&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (UserPresenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresenceEntityListing>> UsersUseridPresencesGetAsyncWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Get a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> UsersUseridPresencesSourceGetAsync (string userId, string source);

        /// <summary>
        /// Get a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourceGetAsyncWithHttpInfo (string userId, string source);
        /// <summary>
        /// Patch a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> UsersUseridPresencesSourcePatchAsync (string userId, string source, UserPresence body);

        /// <summary>
        /// Patch a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourcePatchAsyncWithHttpInfo (string userId, string source, UserPresence body);
        /// <summary>
        /// Update a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> UsersUseridPresencesSourcePutAsync (string userId, string source, UserPresence body);

        /// <summary>
        /// Update a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourcePutAsyncWithHttpInfo (string userId, string source, UserPresence body);
        /// <summary>
        /// Get a user&#39;s Primary UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> UsersUseridPrimarypresenceGetAsync (string userId);

        /// <summary>
        /// Get a user&#39;s Primary UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPrimarypresenceGetAsyncWithHttpInfo (string userId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PresenceApi : IPresenceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PresenceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PresenceApi(Configuration configuration = null)
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
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>OrganizationPresenceEntityListing</returns>
        public OrganizationPresenceEntityListing PresencedefinitionsGet (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<OrganizationPresenceEntityListing> localVarResponse = PresencedefinitionsGetWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of OrganizationPresenceEntityListing</returns>
        public ApiResponse< OrganizationPresenceEntityListing > PresencedefinitionsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {

            var localVarPath = "/api/v1/presencedefinitions";
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
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresenceEntityListing)));
            
        }

        /// <summary>
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of OrganizationPresenceEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationPresenceEntityListing> PresencedefinitionsGetAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<OrganizationPresenceEntityListing> localVarResponse = await PresencedefinitionsGetAsyncWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (OrganizationPresenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresenceEntityListing>> PresencedefinitionsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {

            var localVarPath = "/api/v1/presencedefinitions";
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
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresenceEntityListing)));
            
        }

        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PresencedefinitionsPost (OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = PresencedefinitionsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PresencedefinitionsPostWithHttpInfo (OrganizationPresence body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PresencedefinitionsPost");

            var localVarPath = "/api/v1/presencedefinitions";
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
            if (body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }

        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPostAsync (OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await PresencedefinitionsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPostAsyncWithHttpInfo (OrganizationPresence body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PresencedefinitionsPost");

            var localVarPath = "/api/v1/presencedefinitions";
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
            if (body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PresencedefinitionsPresenceidDelete (string presenceId)
        {
             ApiResponse<OrganizationPresence> localVarResponse = PresencedefinitionsPresenceidDeleteWithHttpInfo(presenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PresencedefinitionsPresenceidDeleteWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PresencedefinitionsPresenceidDelete");

            var localVarPath = "/api/v1/presencedefinitions/{presenceId}";
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
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidDeleteAsync (string presenceId)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await PresencedefinitionsPresenceidDeleteAsyncWithHttpInfo(presenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidDeleteAsyncWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PresencedefinitionsPresenceidDelete");

            var localVarPath = "/api/v1/presencedefinitions/{presenceId}";
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
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }

        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PresencedefinitionsPresenceidGet (string presenceId)
        {
             ApiResponse<OrganizationPresence> localVarResponse = PresencedefinitionsPresenceidGetWithHttpInfo(presenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PresencedefinitionsPresenceidGetWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PresencedefinitionsPresenceidGet");

            var localVarPath = "/api/v1/presencedefinitions/{presenceId}";
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
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }

        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidGetAsync (string presenceId)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await PresencedefinitionsPresenceidGetAsyncWithHttpInfo(presenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidGetAsyncWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PresencedefinitionsPresenceidGet");

            var localVarPath = "/api/v1/presencedefinitions/{presenceId}";
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
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PresencedefinitionsPresenceidPut (string presenceId, OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = PresencedefinitionsPresenceidPutWithHttpInfo(presenceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PresencedefinitionsPresenceidPutWithHttpInfo (string presenceId, OrganizationPresence body)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PresencedefinitionsPresenceidPut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PresencedefinitionsPresenceidPut");

            var localVarPath = "/api/v1/presencedefinitions/{presenceId}";
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
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
            if (body.GetType() != typeof(byte[]))
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidPutAsync (string presenceId, OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await PresencedefinitionsPresenceidPutAsyncWithHttpInfo(presenceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidPutAsyncWithHttpInfo (string presenceId, OrganizationPresence body)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PresencedefinitionsPresenceidPut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PresencedefinitionsPresenceidPut");

            var localVarPath = "/api/v1/presencedefinitions/{presenceId}";
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
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
            if (body.GetType() != typeof(byte[]))
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }

        /// <summary>
        /// Get an User&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>UserPresenceEntityListing</returns>
        public UserPresenceEntityListing UsersUseridPresencesGet (string userId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<UserPresenceEntityListing> localVarResponse = UsersUseridPresencesGetWithHttpInfo(userId, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an User&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of UserPresenceEntityListing</returns>
        public ApiResponse< UserPresenceEntityListing > UsersUseridPresencesGetWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesGet");

            var localVarPath = "/api/v1/users/{userId}/presences";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresenceEntityListing)));
            
        }

        /// <summary>
        /// Get an User&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of UserPresenceEntityListing</returns>
        public async System.Threading.Tasks.Task<UserPresenceEntityListing> UsersUseridPresencesGetAsync (string userId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<UserPresenceEntityListing> localVarResponse = await UsersUseridPresencesGetAsyncWithHttpInfo(userId, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an User&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (UserPresenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresenceEntityListing>> UsersUseridPresencesGetAsyncWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesGet");

            var localVarPath = "/api/v1/users/{userId}/presences";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresenceEntityListing)));
            
        }

        /// <summary>
        /// Get a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>UserPresence</returns>
        public UserPresence UsersUseridPresencesSourceGet (string userId, string source)
        {
             ApiResponse<UserPresence> localVarResponse = UsersUseridPresencesSourceGetWithHttpInfo(userId, source);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > UsersUseridPresencesSourceGetWithHttpInfo (string userId, string source)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesSourceGet");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->UsersUseridPresencesSourceGet");

            var localVarPath = "/api/v1/users/{userId}/presences/{source}";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (source != null) localVarPathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }

        /// <summary>
        /// Get a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> UsersUseridPresencesSourceGetAsync (string userId, string source)
        {
             ApiResponse<UserPresence> localVarResponse = await UsersUseridPresencesSourceGetAsyncWithHttpInfo(userId, source);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourceGetAsyncWithHttpInfo (string userId, string source)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesSourceGet");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->UsersUseridPresencesSourceGet");

            var localVarPath = "/api/v1/users/{userId}/presences/{source}";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (source != null) localVarPathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }

        /// <summary>
        /// Patch a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>UserPresence</returns>
        public UserPresence UsersUseridPresencesSourcePatch (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> localVarResponse = UsersUseridPresencesSourcePatchWithHttpInfo(userId, source, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > UsersUseridPresencesSourcePatchWithHttpInfo (string userId, string source, UserPresence body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesSourcePatch");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->UsersUseridPresencesSourcePatch");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->UsersUseridPresencesSourcePatch");

            var localVarPath = "/api/v1/users/{userId}/presences/{source}";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (source != null) localVarPathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
            if (body.GetType() != typeof(byte[]))
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }

        /// <summary>
        /// Patch a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> UsersUseridPresencesSourcePatchAsync (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> localVarResponse = await UsersUseridPresencesSourcePatchAsyncWithHttpInfo(userId, source, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourcePatchAsyncWithHttpInfo (string userId, string source, UserPresence body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesSourcePatch");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->UsersUseridPresencesSourcePatch");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->UsersUseridPresencesSourcePatch");

            var localVarPath = "/api/v1/users/{userId}/presences/{source}";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (source != null) localVarPathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
            if (body.GetType() != typeof(byte[]))
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }

        /// <summary>
        /// Update a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>UserPresence</returns>
        public UserPresence UsersUseridPresencesSourcePut (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> localVarResponse = UsersUseridPresencesSourcePutWithHttpInfo(userId, source, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > UsersUseridPresencesSourcePutWithHttpInfo (string userId, string source, UserPresence body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesSourcePut");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->UsersUseridPresencesSourcePut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->UsersUseridPresencesSourcePut");

            var localVarPath = "/api/v1/users/{userId}/presences/{source}";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (source != null) localVarPathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
            if (body.GetType() != typeof(byte[]))
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }

        /// <summary>
        /// Update a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> UsersUseridPresencesSourcePutAsync (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> localVarResponse = await UsersUseridPresencesSourcePutAsyncWithHttpInfo(userId, source, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourcePutAsyncWithHttpInfo (string userId, string source, UserPresence body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesSourcePut");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->UsersUseridPresencesSourcePut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->UsersUseridPresencesSourcePut");

            var localVarPath = "/api/v1/users/{userId}/presences/{source}";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (source != null) localVarPathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
            if (body.GetType() != typeof(byte[]))
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }

        /// <summary>
        /// Get a user&#39;s Primary UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>UserPresence</returns>
        public UserPresence UsersUseridPrimarypresenceGet (string userId)
        {
             ApiResponse<UserPresence> localVarResponse = UsersUseridPrimarypresenceGetWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user&#39;s Primary UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > UsersUseridPrimarypresenceGetWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPrimarypresenceGet");

            var localVarPath = "/api/v1/users/{userId}/primarypresence";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresenceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresenceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }

        /// <summary>
        /// Get a user&#39;s Primary UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> UsersUseridPrimarypresenceGetAsync (string userId)
        {
             ApiResponse<UserPresence> localVarResponse = await UsersUseridPrimarypresenceGetAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user&#39;s Primary UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPrimarypresenceGetAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPrimarypresenceGet");

            var localVarPath = "/api/v1/users/{userId}/primarypresence";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresenceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresenceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }

    }
}
