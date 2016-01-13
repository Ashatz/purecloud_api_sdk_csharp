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
    public interface IPresenceApi
    {
        
        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>OrganizationPresenceEntityListing</returns>
        OrganizationPresenceEntityListing PresencedefinitionsGet (int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of OrganizationPresenceEntityListing</returns>
        ApiResponse<OrganizationPresenceEntityListing> PresencedefinitionsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of OrganizationPresenceEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationPresenceEntityListing> PresencedefinitionsGetAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (OrganizationPresenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresenceEntityListing>> PresencedefinitionsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PresencedefinitionsPost (OrganizationPresence body);
  
        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PresencedefinitionsPostWithHttpInfo (OrganizationPresence body);

        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPostAsync (OrganizationPresence body);

        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPostAsyncWithHttpInfo (OrganizationPresence body);
        
        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PresencedefinitionsPresenceidGet (string presenceId);
  
        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PresencedefinitionsPresenceidGetWithHttpInfo (string presenceId);

        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidGetAsync (string presenceId);

        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidGetAsyncWithHttpInfo (string presenceId);
        
        /// <summary>
        /// Update an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PresencedefinitionsPresenceidPutWithHttpInfo (string presenceId, OrganizationPresence body);

        /// <summary>
        /// Update an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidPutAsyncWithHttpInfo (string presenceId, OrganizationPresence body);
        
        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PresencedefinitionsPresenceidDelete (string presenceId);
  
        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PresencedefinitionsPresenceidDeleteWithHttpInfo (string presenceId);

        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidDeleteAsync (string presenceId);

        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidDeleteAsyncWithHttpInfo (string presenceId);
        
        /// <summary>
        /// Get an User&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>UserPresenceEntityListing</returns>
        UserPresenceEntityListing UsersUseridPresencesGet (string userId, int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Get an User&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of UserPresenceEntityListing</returns>
        ApiResponse<UserPresenceEntityListing> UsersUseridPresencesGetWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get an User&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of UserPresenceEntityListing</returns>
        System.Threading.Tasks.Task<UserPresenceEntityListing> UsersUseridPresencesGetAsync (string userId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get an User&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (UserPresenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresenceEntityListing>> UsersUseridPresencesGetAsyncWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> UsersUseridPresencesSourceGetWithHttpInfo (string userId, string source);

        /// <summary>
        /// Get a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourceGetAsyncWithHttpInfo (string userId, string source);
        
        /// <summary>
        /// Update a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> UsersUseridPresencesSourcePutWithHttpInfo (string userId, string source, UserPresence body);

        /// <summary>
        /// Update a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourcePutAsyncWithHttpInfo (string userId, string source, UserPresence body);
        
        /// <summary>
        /// Patch a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> UsersUseridPresencesSourcePatchWithHttpInfo (string userId, string source, UserPresence body);

        /// <summary>
        /// Patch a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourcePatchAsyncWithHttpInfo (string userId, string source, UserPresence body);
        
        /// <summary>
        /// Get a user&#39;s Primary UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>UserPresence</returns>
        UserPresence UsersUseridPrimarypresenceGet (string userId);
  
        /// <summary>
        /// Get a user&#39;s Primary UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> UsersUseridPrimarypresenceGetWithHttpInfo (string userId);

        /// <summary>
        /// Get a user&#39;s Primary UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> UsersUseridPrimarypresenceGetAsync (string userId);

        /// <summary>
        /// Get a user&#39;s Primary UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPrimarypresenceGetAsyncWithHttpInfo (string userId);
        
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
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>OrganizationPresenceEntityListing</returns>
        public OrganizationPresenceEntityListing PresencedefinitionsGet (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<OrganizationPresenceEntityListing> response = PresencedefinitionsGetWithHttpInfo(pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of OrganizationPresenceEntityListing</returns>
        public ApiResponse< OrganizationPresenceEntityListing > PresencedefinitionsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/presencedefinitions";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PresencedefinitionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PresencedefinitionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrganizationPresenceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresenceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresenceEntityListing)));
            
        }
    
        /// <summary>
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of OrganizationPresenceEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationPresenceEntityListing> PresencedefinitionsGetAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<OrganizationPresenceEntityListing> response = await PresencedefinitionsGetAsyncWithHttpInfo(pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (OrganizationPresenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresenceEntityListing>> PresencedefinitionsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/presencedefinitions";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PresencedefinitionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PresencedefinitionsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrganizationPresenceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresenceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresenceEntityListing)));
            
        }
        
        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <param name="body">The OrganizationPresence to create</param> 
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PresencedefinitionsPost (OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> response = PresencedefinitionsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <param name="body">The OrganizationPresence to create</param> 
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PresencedefinitionsPostWithHttpInfo (OrganizationPresence body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PresencedefinitionsPost");
            
    
            var path_ = "/api/v1/presencedefinitions";
    
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
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrganizationPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresence)));
            
        }
    
        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPostAsync (OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> response = await PresencedefinitionsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPostAsyncWithHttpInfo (OrganizationPresence body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PresencedefinitionsPost");
            
    
            var path_ = "/api/v1/presencedefinitions";
    
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
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresence)));
            
        }
        
        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param> 
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PresencedefinitionsPresenceidGet (string presenceId)
        {
             ApiResponse<OrganizationPresence> response = PresencedefinitionsPresenceidGetWithHttpInfo(presenceId);
             return response.Data;
        }

        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param> 
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PresencedefinitionsPresenceidGetWithHttpInfo (string presenceId)
        {
            
            // verify the required parameter 'presenceId' is set
            if (presenceId == null) throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresencedefinitionsPresenceidGet");
            
    
            var path_ = "/api/v1/presencedefinitions/{presenceId}";
    
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
            if (presenceId != null) pathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPresenceidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPresenceidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrganizationPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresence)));
            
        }
    
        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidGetAsync (string presenceId)
        {
             ApiResponse<OrganizationPresence> response = await PresencedefinitionsPresenceidGetAsyncWithHttpInfo(presenceId);
             return response.Data;

        }

        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidGetAsyncWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null) throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresencedefinitionsPresenceidGet");
            
    
            var path_ = "/api/v1/presencedefinitions/{presenceId}";
    
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
            if (presenceId != null) pathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPresenceidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPresenceidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresence)));
            
        }
        
        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param> 
        /// <param name="body">The OrganizationPresence to update</param> 
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PresencedefinitionsPresenceidPut (string presenceId, OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> response = PresencedefinitionsPresenceidPutWithHttpInfo(presenceId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param> 
        /// <param name="body">The OrganizationPresence to update</param> 
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PresencedefinitionsPresenceidPutWithHttpInfo (string presenceId, OrganizationPresence body)
        {
            
            // verify the required parameter 'presenceId' is set
            if (presenceId == null) throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresencedefinitionsPresenceidPut");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PresencedefinitionsPresenceidPut");
            
    
            var path_ = "/api/v1/presencedefinitions/{presenceId}";
    
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
            if (presenceId != null) pathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPresenceidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPresenceidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrganizationPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresence)));
            
        }
    
        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidPutAsync (string presenceId, OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> response = await PresencedefinitionsPresenceidPutAsyncWithHttpInfo(presenceId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidPutAsyncWithHttpInfo (string presenceId, OrganizationPresence body)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null) throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresencedefinitionsPresenceidPut");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PresencedefinitionsPresenceidPut");
            
    
            var path_ = "/api/v1/presencedefinitions/{presenceId}";
    
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
            if (presenceId != null) pathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPresenceidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPresenceidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresence)));
            
        }
        
        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param> 
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PresencedefinitionsPresenceidDelete (string presenceId)
        {
             ApiResponse<OrganizationPresence> response = PresencedefinitionsPresenceidDeleteWithHttpInfo(presenceId);
             return response.Data;
        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param> 
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PresencedefinitionsPresenceidDeleteWithHttpInfo (string presenceId)
        {
            
            // verify the required parameter 'presenceId' is set
            if (presenceId == null) throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresencedefinitionsPresenceidDelete");
            
    
            var path_ = "/api/v1/presencedefinitions/{presenceId}";
    
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
            if (presenceId != null) pathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPresenceidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPresenceidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrganizationPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresence)));
            
        }
    
        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidDeleteAsync (string presenceId)
        {
             ApiResponse<OrganizationPresence> response = await PresencedefinitionsPresenceidDeleteAsyncWithHttpInfo(presenceId);
             return response.Data;

        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidDeleteAsyncWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null) throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresencedefinitionsPresenceidDelete");
            
    
            var path_ = "/api/v1/presencedefinitions/{presenceId}";
    
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
            if (presenceId != null) pathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPresenceidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PresencedefinitionsPresenceidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresence)));
            
        }
        
        /// <summary>
        /// Get an User&#39;s list of Presences 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>UserPresenceEntityListing</returns>
        public UserPresenceEntityListing UsersUseridPresencesGet (string userId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<UserPresenceEntityListing> response = UsersUseridPresencesGetWithHttpInfo(userId, pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Get an User&#39;s list of Presences 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of UserPresenceEntityListing</returns>
        public ApiResponse< UserPresenceEntityListing > UsersUseridPresencesGetWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridPresencesGet");
            
    
            var path_ = "/api/v1/users/{userId}/presences";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserPresenceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresenceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(UserPresenceEntityListing)));
            
        }
    
        /// <summary>
        /// Get an User&#39;s list of Presences 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of UserPresenceEntityListing</returns>
        public async System.Threading.Tasks.Task<UserPresenceEntityListing> UsersUseridPresencesGetAsync (string userId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<UserPresenceEntityListing> response = await UsersUseridPresencesGetAsyncWithHttpInfo(userId, pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Get an User&#39;s list of Presences 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (UserPresenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresenceEntityListing>> UsersUseridPresencesGetAsyncWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridPresencesGet");
            
    
            var path_ = "/api/v1/users/{userId}/presences";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserPresenceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresenceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(UserPresenceEntityListing)));
            
        }
        
        /// <summary>
        /// Get a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="source">Source</param> 
        /// <returns>UserPresence</returns>
        public UserPresence UsersUseridPresencesSourceGet (string userId, string source)
        {
             ApiResponse<UserPresence> response = UsersUseridPresencesSourceGetWithHttpInfo(userId, source);
             return response.Data;
        }

        /// <summary>
        /// Get a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="source">Source</param> 
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > UsersUseridPresencesSourceGetWithHttpInfo (string userId, string source)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridPresencesSourceGet");
            
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling UsersUseridPresencesSourceGet");
            
    
            var path_ = "/api/v1/users/{userId}/presences/{source}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (source != null) pathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesSourceGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesSourceGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(response, typeof(UserPresence)));
            
        }
    
        /// <summary>
        /// Get a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> UsersUseridPresencesSourceGetAsync (string userId, string source)
        {
             ApiResponse<UserPresence> response = await UsersUseridPresencesSourceGetAsyncWithHttpInfo(userId, source);
             return response.Data;

        }

        /// <summary>
        /// Get a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourceGetAsyncWithHttpInfo (string userId, string source)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridPresencesSourceGet");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling UsersUseridPresencesSourceGet");
            
    
            var path_ = "/api/v1/users/{userId}/presences/{source}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (source != null) pathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesSourceGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesSourceGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(response, typeof(UserPresence)));
            
        }
        
        /// <summary>
        /// Update a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="source">Source</param> 
        /// <param name="body">The updated UserPresence</param> 
        /// <returns>UserPresence</returns>
        public UserPresence UsersUseridPresencesSourcePut (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> response = UsersUseridPresencesSourcePutWithHttpInfo(userId, source, body);
             return response.Data;
        }

        /// <summary>
        /// Update a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="source">Source</param> 
        /// <param name="body">The updated UserPresence</param> 
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > UsersUseridPresencesSourcePutWithHttpInfo (string userId, string source, UserPresence body)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridPresencesSourcePut");
            
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling UsersUseridPresencesSourcePut");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UsersUseridPresencesSourcePut");
            
    
            var path_ = "/api/v1/users/{userId}/presences/{source}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (source != null) pathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesSourcePut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesSourcePut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(response, typeof(UserPresence)));
            
        }
    
        /// <summary>
        /// Update a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> UsersUseridPresencesSourcePutAsync (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> response = await UsersUseridPresencesSourcePutAsyncWithHttpInfo(userId, source, body);
             return response.Data;

        }

        /// <summary>
        /// Update a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourcePutAsyncWithHttpInfo (string userId, string source, UserPresence body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridPresencesSourcePut");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling UsersUseridPresencesSourcePut");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UsersUseridPresencesSourcePut");
            
    
            var path_ = "/api/v1/users/{userId}/presences/{source}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (source != null) pathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesSourcePut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesSourcePut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(response, typeof(UserPresence)));
            
        }
        
        /// <summary>
        /// Patch a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="source">Source</param> 
        /// <param name="body">The patched UserPresence</param> 
        /// <returns>UserPresence</returns>
        public UserPresence UsersUseridPresencesSourcePatch (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> response = UsersUseridPresencesSourcePatchWithHttpInfo(userId, source, body);
             return response.Data;
        }

        /// <summary>
        /// Patch a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="source">Source</param> 
        /// <param name="body">The patched UserPresence</param> 
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > UsersUseridPresencesSourcePatchWithHttpInfo (string userId, string source, UserPresence body)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridPresencesSourcePatch");
            
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling UsersUseridPresencesSourcePatch");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UsersUseridPresencesSourcePatch");
            
    
            var path_ = "/api/v1/users/{userId}/presences/{source}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (source != null) pathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesSourcePatch: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesSourcePatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(response, typeof(UserPresence)));
            
        }
    
        /// <summary>
        /// Patch a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> UsersUseridPresencesSourcePatchAsync (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> response = await UsersUseridPresencesSourcePatchAsyncWithHttpInfo(userId, source, body);
             return response.Data;

        }

        /// <summary>
        /// Patch a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourcePatchAsyncWithHttpInfo (string userId, string source, UserPresence body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridPresencesSourcePatch");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling UsersUseridPresencesSourcePatch");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UsersUseridPresencesSourcePatch");
            
    
            var path_ = "/api/v1/users/{userId}/presences/{source}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (source != null) pathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesSourcePatch: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridPresencesSourcePatch: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(response, typeof(UserPresence)));
            
        }
        
        /// <summary>
        /// Get a user&#39;s Primary UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>UserPresence</returns>
        public UserPresence UsersUseridPrimarypresenceGet (string userId)
        {
             ApiResponse<UserPresence> response = UsersUseridPrimarypresenceGetWithHttpInfo(userId);
             return response.Data;
        }

        /// <summary>
        /// Get a user&#39;s Primary UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > UsersUseridPrimarypresenceGetWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridPrimarypresenceGet");
            
    
            var path_ = "/api/v1/users/{userId}/primarypresence";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling UsersUseridPrimarypresenceGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridPrimarypresenceGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(response, typeof(UserPresence)));
            
        }
    
        /// <summary>
        /// Get a user&#39;s Primary UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> UsersUseridPrimarypresenceGetAsync (string userId)
        {
             ApiResponse<UserPresence> response = await UsersUseridPrimarypresenceGetAsyncWithHttpInfo(userId);
             return response.Data;

        }

        /// <summary>
        /// Get a user&#39;s Primary UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPrimarypresenceGetAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridPrimarypresenceGet");
            
    
            var path_ = "/api/v1/users/{userId}/primarypresence";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling UsersUseridPrimarypresenceGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridPrimarypresenceGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(response, typeof(UserPresence)));
            
        }
        
    }
    
}
