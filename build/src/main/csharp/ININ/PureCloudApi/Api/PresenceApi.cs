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
        OrganizationPresenceEntityListing Get (int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of OrganizationPresenceEntityListing</returns>
        ApiResponse<OrganizationPresenceEntityListing> GetWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of OrganizationPresenceEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationPresenceEntityListing> GetAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (OrganizationPresenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresenceEntityListing>> GetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence Create (OrganizationPresence body);
  
        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> CreateWithHttpInfo (OrganizationPresence body);

        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> CreateAsync (OrganizationPresence body);

        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> CreateAsyncWithHttpInfo (OrganizationPresence body);
        
        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence GetPresence (string presenceId);
  
        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> GetPresenceWithHttpInfo (string presenceId);

        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> GetPresenceAsync (string presenceId);

        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> GetPresenceAsyncWithHttpInfo (string presenceId);
        
        /// <summary>
        /// Update an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence UpdatePresence (string presenceId, OrganizationPresence body);
  
        /// <summary>
        /// Update an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> UpdatePresenceWithHttpInfo (string presenceId, OrganizationPresence body);

        /// <summary>
        /// Update an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> UpdatePresenceAsync (string presenceId, OrganizationPresence body);

        /// <summary>
        /// Update an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> UpdatePresenceAsyncWithHttpInfo (string presenceId, OrganizationPresence body);
        
        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence DeletePresence (string presenceId);
  
        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> DeletePresenceWithHttpInfo (string presenceId);

        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> DeletePresenceAsync (string presenceId);

        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> DeletePresenceAsyncWithHttpInfo (string presenceId);
        
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
        UserPresenceEntityListing GetUserPresences (string userId, int? pageNumber = null, int? pageSize = null);
  
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
        ApiResponse<UserPresenceEntityListing> GetUserPresencesWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null);

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
        System.Threading.Tasks.Task<UserPresenceEntityListing> GetUserPresencesAsync (string userId, int? pageNumber = null, int? pageSize = null);

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
        System.Threading.Tasks.Task<ApiResponse<UserPresenceEntityListing>> GetUserPresencesAsyncWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>UserPresence</returns>
        UserPresence GetUserPresencesBySource (string userId, string source);
  
        /// <summary>
        /// Get a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> GetUserPresencesBySourceWithHttpInfo (string userId, string source);

        /// <summary>
        /// Get a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> GetUserPresencesBySourceAsync (string userId, string source);

        /// <summary>
        /// Get a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> GetUserPresencesBySourceAsyncWithHttpInfo (string userId, string source);
        
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
        UserPresence UpdateUserPresencesBySource (string userId, string source, UserPresence body);
  
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
        ApiResponse<UserPresence> UpdateUserPresencesBySourceWithHttpInfo (string userId, string source, UserPresence body);

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
        System.Threading.Tasks.Task<UserPresence> UpdateUserPresencesBySourceAsync (string userId, string source, UserPresence body);

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
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> UpdateUserPresencesBySourceAsyncWithHttpInfo (string userId, string source, UserPresence body);
        
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
        UserPresence PatchUserPresencesBySource (string userId, string source, UserPresence body);
  
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
        ApiResponse<UserPresence> PatchUserPresencesBySourceWithHttpInfo (string userId, string source, UserPresence body);

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
        System.Threading.Tasks.Task<UserPresence> PatchUserPresencesBySourceAsync (string userId, string source, UserPresence body);

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
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> PatchUserPresencesBySourceAsyncWithHttpInfo (string userId, string source, UserPresence body);
        
        /// <summary>
        /// Get a user&#39;s Primary UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>UserPresence</returns>
        UserPresence GetUserPrimarypresence (string userId);
  
        /// <summary>
        /// Get a user&#39;s Primary UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> GetUserPrimarypresenceWithHttpInfo (string userId);

        /// <summary>
        /// Get a user&#39;s Primary UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> GetUserPrimarypresenceAsync (string userId);

        /// <summary>
        /// Get a user&#39;s Primary UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> GetUserPrimarypresenceAsyncWithHttpInfo (string userId);
        
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
        public OrganizationPresenceEntityListing Get (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<OrganizationPresenceEntityListing> response = GetWithHttpInfo(pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of OrganizationPresenceEntityListing</returns>
        public ApiResponse< OrganizationPresenceEntityListing > GetWithHttpInfo (int? pageNumber = null, int? pageSize = null)
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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<OrganizationPresenceEntityListing> GetAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<OrganizationPresenceEntityListing> response = await GetAsyncWithHttpInfo(pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (OrganizationPresenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresenceEntityListing>> GetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrganizationPresenceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresenceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresenceEntityListing)));
            
        }
        
        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <param name="body">The OrganizationPresence to create</param> 
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence Create (OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> response = CreateWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <param name="body">The OrganizationPresence to create</param> 
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > CreateWithHttpInfo (OrganizationPresence body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Create");
            
    
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
                throw new ApiException (statusCode, "Error calling Create: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrganizationPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresence)));
            
        }
    
        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> CreateAsync (OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> response = await CreateAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> CreateAsyncWithHttpInfo (OrganizationPresence body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Create");
            
    
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
                throw new ApiException (statusCode, "Error calling Create: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresence)));
            
        }
        
        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param> 
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence GetPresence (string presenceId)
        {
             ApiResponse<OrganizationPresence> response = GetPresenceWithHttpInfo(presenceId);
             return response.Data;
        }

        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param> 
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > GetPresenceWithHttpInfo (string presenceId)
        {
            
            // verify the required parameter 'presenceId' is set
            if (presenceId == null) throw new ApiException(400, "Missing required parameter 'presenceId' when calling GetPresence");
            
    
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
                throw new ApiException (statusCode, "Error calling GetPresence: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPresence: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrganizationPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresence)));
            
        }
    
        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> GetPresenceAsync (string presenceId)
        {
             ApiResponse<OrganizationPresence> response = await GetPresenceAsyncWithHttpInfo(presenceId);
             return response.Data;

        }

        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> GetPresenceAsyncWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null) throw new ApiException(400, "Missing required parameter 'presenceId' when calling GetPresence");
            
    
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
                throw new ApiException (statusCode, "Error calling GetPresence: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPresence: " + response.ErrorMessage, response.ErrorMessage);

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
        public OrganizationPresence UpdatePresence (string presenceId, OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> response = UpdatePresenceWithHttpInfo(presenceId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param> 
        /// <param name="body">The OrganizationPresence to update</param> 
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > UpdatePresenceWithHttpInfo (string presenceId, OrganizationPresence body)
        {
            
            // verify the required parameter 'presenceId' is set
            if (presenceId == null) throw new ApiException(400, "Missing required parameter 'presenceId' when calling UpdatePresence");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdatePresence");
            
    
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
                throw new ApiException (statusCode, "Error calling UpdatePresence: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdatePresence: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<OrganizationPresence> UpdatePresenceAsync (string presenceId, OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> response = await UpdatePresenceAsyncWithHttpInfo(presenceId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> UpdatePresenceAsyncWithHttpInfo (string presenceId, OrganizationPresence body)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null) throw new ApiException(400, "Missing required parameter 'presenceId' when calling UpdatePresence");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdatePresence");
            
    
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
                throw new ApiException (statusCode, "Error calling UpdatePresence: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdatePresence: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresence)));
            
        }
        
        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param> 
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence DeletePresence (string presenceId)
        {
             ApiResponse<OrganizationPresence> response = DeletePresenceWithHttpInfo(presenceId);
             return response.Data;
        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param> 
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > DeletePresenceWithHttpInfo (string presenceId)
        {
            
            // verify the required parameter 'presenceId' is set
            if (presenceId == null) throw new ApiException(400, "Missing required parameter 'presenceId' when calling DeletePresence");
            
    
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
                throw new ApiException (statusCode, "Error calling DeletePresence: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeletePresence: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrganizationPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(response, typeof(OrganizationPresence)));
            
        }
    
        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> DeletePresenceAsync (string presenceId)
        {
             ApiResponse<OrganizationPresence> response = await DeletePresenceAsyncWithHttpInfo(presenceId);
             return response.Data;

        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> DeletePresenceAsyncWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null) throw new ApiException(400, "Missing required parameter 'presenceId' when calling DeletePresence");
            
    
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
                throw new ApiException (statusCode, "Error calling DeletePresence: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeletePresence: " + response.ErrorMessage, response.ErrorMessage);

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
        public UserPresenceEntityListing GetUserPresences (string userId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<UserPresenceEntityListing> response = GetUserPresencesWithHttpInfo(userId, pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Get an User&#39;s list of Presences 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of UserPresenceEntityListing</returns>
        public ApiResponse< UserPresenceEntityListing > GetUserPresencesWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserPresences");
            
    
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
                throw new ApiException (statusCode, "Error calling GetUserPresences: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserPresences: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<UserPresenceEntityListing> GetUserPresencesAsync (string userId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<UserPresenceEntityListing> response = await GetUserPresencesAsyncWithHttpInfo(userId, pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Get an User&#39;s list of Presences 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (UserPresenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresenceEntityListing>> GetUserPresencesAsyncWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserPresences");
            
    
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
                throw new ApiException (statusCode, "Error calling GetUserPresences: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserPresences: " + response.ErrorMessage, response.ErrorMessage);

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
        public UserPresence GetUserPresencesBySource (string userId, string source)
        {
             ApiResponse<UserPresence> response = GetUserPresencesBySourceWithHttpInfo(userId, source);
             return response.Data;
        }

        /// <summary>
        /// Get a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="source">Source</param> 
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > GetUserPresencesBySourceWithHttpInfo (string userId, string source)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserPresencesBySource");
            
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling GetUserPresencesBySource");
            
    
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
                throw new ApiException (statusCode, "Error calling GetUserPresencesBySource: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserPresencesBySource: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<UserPresence> GetUserPresencesBySourceAsync (string userId, string source)
        {
             ApiResponse<UserPresence> response = await GetUserPresencesBySourceAsyncWithHttpInfo(userId, source);
             return response.Data;

        }

        /// <summary>
        /// Get a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> GetUserPresencesBySourceAsyncWithHttpInfo (string userId, string source)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserPresencesBySource");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling GetUserPresencesBySource");
            
    
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
                throw new ApiException (statusCode, "Error calling GetUserPresencesBySource: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserPresencesBySource: " + response.ErrorMessage, response.ErrorMessage);

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
        public UserPresence UpdateUserPresencesBySource (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> response = UpdateUserPresencesBySourceWithHttpInfo(userId, source, body);
             return response.Data;
        }

        /// <summary>
        /// Update a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="source">Source</param> 
        /// <param name="body">The updated UserPresence</param> 
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > UpdateUserPresencesBySourceWithHttpInfo (string userId, string source, UserPresence body)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateUserPresencesBySource");
            
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling UpdateUserPresencesBySource");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateUserPresencesBySource");
            
    
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
                throw new ApiException (statusCode, "Error calling UpdateUserPresencesBySource: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateUserPresencesBySource: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<UserPresence> UpdateUserPresencesBySourceAsync (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> response = await UpdateUserPresencesBySourceAsyncWithHttpInfo(userId, source, body);
             return response.Data;

        }

        /// <summary>
        /// Update a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> UpdateUserPresencesBySourceAsyncWithHttpInfo (string userId, string source, UserPresence body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateUserPresencesBySource");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling UpdateUserPresencesBySource");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateUserPresencesBySource");
            
    
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
                throw new ApiException (statusCode, "Error calling UpdateUserPresencesBySource: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateUserPresencesBySource: " + response.ErrorMessage, response.ErrorMessage);

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
        public UserPresence PatchUserPresencesBySource (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> response = PatchUserPresencesBySourceWithHttpInfo(userId, source, body);
             return response.Data;
        }

        /// <summary>
        /// Patch a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="source">Source</param> 
        /// <param name="body">The patched UserPresence</param> 
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > PatchUserPresencesBySourceWithHttpInfo (string userId, string source, UserPresence body)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling PatchUserPresencesBySource");
            
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling PatchUserPresencesBySource");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchUserPresencesBySource");
            
    
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
                throw new ApiException (statusCode, "Error calling PatchUserPresencesBySource: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchUserPresencesBySource: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<UserPresence> PatchUserPresencesBySourceAsync (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> response = await PatchUserPresencesBySourceAsyncWithHttpInfo(userId, source, body);
             return response.Data;

        }

        /// <summary>
        /// Patch a UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> PatchUserPresencesBySourceAsyncWithHttpInfo (string userId, string source, UserPresence body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling PatchUserPresencesBySource");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling PatchUserPresencesBySource");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchUserPresencesBySource");
            
    
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
                throw new ApiException (statusCode, "Error calling PatchUserPresencesBySource: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchUserPresencesBySource: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(response, typeof(UserPresence)));
            
        }
        
        /// <summary>
        /// Get a user&#39;s Primary UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>UserPresence</returns>
        public UserPresence GetUserPrimarypresence (string userId)
        {
             ApiResponse<UserPresence> response = GetUserPrimarypresenceWithHttpInfo(userId);
             return response.Data;
        }

        /// <summary>
        /// Get a user&#39;s Primary UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > GetUserPrimarypresenceWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserPrimarypresence");
            
    
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
                throw new ApiException (statusCode, "Error calling GetUserPrimarypresence: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserPrimarypresence: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(response, typeof(UserPresence)));
            
        }
    
        /// <summary>
        /// Get a user&#39;s Primary UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> GetUserPrimarypresenceAsync (string userId)
        {
             ApiResponse<UserPresence> response = await GetUserPrimarypresenceAsyncWithHttpInfo(userId);
             return response.Data;

        }

        /// <summary>
        /// Get a user&#39;s Primary UserPresence 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> GetUserPrimarypresenceAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserPrimarypresence");
            
    
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
                throw new ApiException (statusCode, "Error calling GetUserPrimarypresence: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserPrimarypresence: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserPresence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(response, typeof(UserPresence)));
            
        }
        
    }
    
}
