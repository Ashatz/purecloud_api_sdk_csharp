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
    public interface IArchitectApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies (optional, default to false)</param>
        /// <returns></returns>
        void FlowsDelete (List<string> id, bool? ignoreDependencies = null);

        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> FlowsDeleteWithHttpInfo (List<string> id, bool? ignoreDependencies = null);
        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <returns>FlowEntityListing</returns>
        FlowEntityListing FlowsGet (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null);

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <returns>ApiResponse of FlowEntityListing</returns>
        ApiResponse<FlowEntityListing> FlowsGetWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null);
        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Flow</returns>
        Flow FlowsPost (Flow body = null);

        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> FlowsPostWithHttpInfo (Flow body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies (optional, default to false)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task FlowsDeleteAsync (List<string> id, bool? ignoreDependencies = null);

        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies (optional, default to false)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> FlowsDeleteAsyncWithHttpInfo (List<string> id, bool? ignoreDependencies = null);
        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <returns>Task of FlowEntityListing</returns>
        System.Threading.Tasks.Task<FlowEntityListing> FlowsGetAsync (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null);

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <returns>Task of ApiResponse (FlowEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowEntityListing>> FlowsGetAsyncWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null);
        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> FlowsPostAsync (Flow body = null);

        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsPostAsyncWithHttpInfo (Flow body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ArchitectApi : IArchitectApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ArchitectApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ArchitectApi(Configuration configuration = null)
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
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies (optional, default to false)</param>
        /// <returns></returns>
        public void FlowsDelete (List<string> id, bool? ignoreDependencies = null)
        {
             FlowsDeleteWithHttpInfo(id, ignoreDependencies);
        }

        /// <summary>
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> FlowsDeleteWithHttpInfo (List<string> id, bool? ignoreDependencies = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->FlowsDelete");

            var localVarPath = "/api/v1/flows";
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (ignoreDependencies != null) localVarQueryParams.Add("ignoreDependencies", Configuration.ApiClient.ParameterToString(ignoreDependencies)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling FlowsDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FlowsDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies (optional, default to false)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task FlowsDeleteAsync (List<string> id, bool? ignoreDependencies = null)
        {
             await FlowsDeleteAsyncWithHttpInfo(id, ignoreDependencies);

        }

        /// <summary>
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies (optional, default to false)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> FlowsDeleteAsyncWithHttpInfo (List<string> id, bool? ignoreDependencies = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->FlowsDelete");

            var localVarPath = "/api/v1/flows";
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (ignoreDependencies != null) localVarQueryParams.Add("ignoreDependencies", Configuration.ApiClient.ParameterToString(ignoreDependencies)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling FlowsDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FlowsDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <returns>FlowEntityListing</returns>
        public FlowEntityListing FlowsGet (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null)
        {
             ApiResponse<FlowEntityListing> localVarResponse = FlowsGetWithHttpInfo(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, lockedBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <returns>ApiResponse of FlowEntityListing</returns>
        public ApiResponse< FlowEntityListing > FlowsGetWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null)
        {

            var localVarPath = "/api/v1/flows";
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
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) localVarQueryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            if (publishVersionId != null) localVarQueryParams.Add("publishVersionId", Configuration.ApiClient.ParameterToString(publishVersionId)); // query parameter
            if (lockedBy != null) localVarQueryParams.Add("lockedBy", Configuration.ApiClient.ParameterToString(lockedBy)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling FlowsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FlowsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowEntityListing)));
            
        }

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <returns>Task of FlowEntityListing</returns>
        public async System.Threading.Tasks.Task<FlowEntityListing> FlowsGetAsync (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null)
        {
             ApiResponse<FlowEntityListing> localVarResponse = await FlowsGetAsyncWithHttpInfo(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, lockedBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <returns>Task of ApiResponse (FlowEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowEntityListing>> FlowsGetAsyncWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null)
        {

            var localVarPath = "/api/v1/flows";
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
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) localVarQueryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            if (publishVersionId != null) localVarQueryParams.Add("publishVersionId", Configuration.ApiClient.ParameterToString(publishVersionId)); // query parameter
            if (lockedBy != null) localVarQueryParams.Add("lockedBy", Configuration.ApiClient.ParameterToString(lockedBy)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling FlowsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FlowsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowEntityListing)));
            
        }

        /// <summary>
        /// Create flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Flow</returns>
        public Flow FlowsPost (Flow body = null)
        {
             ApiResponse<Flow> localVarResponse = FlowsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > FlowsPostWithHttpInfo (Flow body = null)
        {

            var localVarPath = "/api/v1/flows";
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
                throw new ApiException (localVarStatusCode, "Error calling FlowsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FlowsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        /// <summary>
        /// Create flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> FlowsPostAsync (Flow body = null)
        {
             ApiResponse<Flow> localVarResponse = await FlowsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsPostAsyncWithHttpInfo (Flow body = null)
        {

            var localVarPath = "/api/v1/flows";
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
                throw new ApiException (localVarStatusCode, "Error calling FlowsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FlowsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

    }
}
