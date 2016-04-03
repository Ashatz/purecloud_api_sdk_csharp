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
    public interface IPresenceApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence DeletePresenceId (string presenceId);
  
        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> DeletePresenceIdWithHttpInfo (string presenceId);
        
        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence GetPresenceId (string presenceId);
  
        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> GetPresenceIdWithHttpInfo (string presenceId);
        
        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>OrganizationPresenceEntityListing</returns>
        OrganizationPresenceEntityListing GetPresencedefinitions (int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of OrganizationPresenceEntityListing</returns>
        ApiResponse<OrganizationPresenceEntityListing> GetPresencedefinitionsWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get a user&#39;s Presence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <returns>UserPresence</returns>
        UserPresence GetUserIdPresencesSource (string userId, string source);
  
        /// <summary>
        /// Get a user&#39;s Presence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> GetUserIdPresencesSourceWithHttpInfo (string userId, string source);
        
        /// <summary>
        /// Patch a user&#39;s Presence
        /// </summary>
        /// <remarks>
        /// The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <param name="body"></param>
        /// <returns>UserPresence</returns>
        UserPresence PatchUserIdPresencesSource (string userId, string source, UserPresence body = null);
  
        /// <summary>
        /// Patch a user&#39;s Presence
        /// </summary>
        /// <remarks>
        /// The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> PatchUserIdPresencesSourceWithHttpInfo (string userId, string source, UserPresence body = null);
        
        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PostPresencedefinitions (OrganizationPresence body);
  
        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PostPresencedefinitionsWithHttpInfo (OrganizationPresence body);
        
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
        OrganizationPresence PutPresenceId (string presenceId, OrganizationPresence body);
  
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
        ApiResponse<OrganizationPresence> PutPresenceIdWithHttpInfo (string presenceId, OrganizationPresence body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> DeletePresenceIdAsync (string presenceId);

        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> DeletePresenceIdAsyncWithHttpInfo (string presenceId);
        
        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> GetPresenceIdAsync (string presenceId);

        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> GetPresenceIdAsyncWithHttpInfo (string presenceId);
        
        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of OrganizationPresenceEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationPresenceEntityListing> GetPresencedefinitionsAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (OrganizationPresenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresenceEntityListing>> GetPresencedefinitionsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get a user&#39;s Presence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> GetUserIdPresencesSourceAsync (string userId, string source);

        /// <summary>
        /// Get a user&#39;s Presence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> GetUserIdPresencesSourceAsyncWithHttpInfo (string userId, string source);
        
        /// <summary>
        /// Patch a user&#39;s Presence
        /// </summary>
        /// <remarks>
        /// The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <param name="body"></param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> PatchUserIdPresencesSourceAsync (string userId, string source, UserPresence body = null);

        /// <summary>
        /// Patch a user&#39;s Presence
        /// </summary>
        /// <remarks>
        /// The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> PatchUserIdPresencesSourceAsyncWithHttpInfo (string userId, string source, UserPresence body = null);
        
        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PostPresencedefinitionsAsync (OrganizationPresence body);

        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PostPresencedefinitionsAsyncWithHttpInfo (OrganizationPresence body);
        
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
        System.Threading.Tasks.Task<OrganizationPresence> PutPresenceIdAsync (string presenceId, OrganizationPresence body);

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
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PutPresenceIdAsyncWithHttpInfo (string presenceId, OrganizationPresence body);
        
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
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param> 
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence DeletePresenceId (string presenceId)
        {
             ApiResponse<OrganizationPresence> localVarResponse = DeletePresenceIdWithHttpInfo(presenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param> 
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > DeletePresenceIdWithHttpInfo (string presenceId)
        {
            
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->DeletePresenceId");
            
    
            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeletePresenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePresenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<OrganizationPresence> DeletePresenceIdAsync (string presenceId)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await DeletePresenceIdAsyncWithHttpInfo(presenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> DeletePresenceIdAsyncWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null) throw new ApiException(400, "Missing required parameter 'presenceId' when calling DeletePresenceId");
            
    
            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeletePresenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePresenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public OrganizationPresence GetPresenceId (string presenceId)
        {
             ApiResponse<OrganizationPresence> localVarResponse = GetPresenceIdWithHttpInfo(presenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param> 
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > GetPresenceIdWithHttpInfo (string presenceId)
        {
            
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->GetPresenceId");
            
    
            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<OrganizationPresence> GetPresenceIdAsync (string presenceId)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await GetPresenceIdAsyncWithHttpInfo(presenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> GetPresenceIdAsyncWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null) throw new ApiException(400, "Missing required parameter 'presenceId' when calling GetPresenceId");
            
    
            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }
        
        /// <summary>
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>OrganizationPresenceEntityListing</returns>
        public OrganizationPresenceEntityListing GetPresencedefinitions (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<OrganizationPresenceEntityListing> localVarResponse = GetPresencedefinitionsWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of OrganizationPresenceEntityListing</returns>
        public ApiResponse< OrganizationPresenceEntityListing > GetPresencedefinitionsWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var localVarPath = "/api/v2/presencedefinitions";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinitions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrganizationPresenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresenceEntityListing)));
            
        }

        
        /// <summary>
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of OrganizationPresenceEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationPresenceEntityListing> GetPresencedefinitionsAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<OrganizationPresenceEntityListing> localVarResponse = await GetPresencedefinitionsAsyncWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (OrganizationPresenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresenceEntityListing>> GetPresencedefinitionsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var localVarPath = "/api/v2/presencedefinitions";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinitions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresenceEntityListing)));
            
        }
        
        /// <summary>
        /// Get a user&#39;s Presence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param> 
        /// <param name="source">source</param> 
        /// <returns>UserPresence</returns>
        public UserPresence GetUserIdPresencesSource (string userId, string source)
        {
             ApiResponse<UserPresence> localVarResponse = GetUserIdPresencesSourceWithHttpInfo(userId, source);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user&#39;s Presence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param> 
        /// <param name="source">source</param> 
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > GetUserIdPresencesSourceWithHttpInfo (string userId, string source)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->GetUserIdPresencesSource");
            
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->GetUserIdPresencesSource");
            
    
            var localVarPath = "/api/v2/users/{userId}/presences/{source}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdPresencesSource: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdPresencesSource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }

        
        /// <summary>
        /// Get a user&#39;s Presence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> GetUserIdPresencesSourceAsync (string userId, string source)
        {
             ApiResponse<UserPresence> localVarResponse = await GetUserIdPresencesSourceAsyncWithHttpInfo(userId, source);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user&#39;s Presence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> GetUserIdPresencesSourceAsyncWithHttpInfo (string userId, string source)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserIdPresencesSource");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling GetUserIdPresencesSource");
            
    
            var localVarPath = "/api/v2/users/{userId}/presences/{source}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdPresencesSource: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdPresencesSource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }
        
        /// <summary>
        /// Patch a user&#39;s Presence The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param> 
        /// <param name="source">source</param> 
        /// <param name="body"></param> 
        /// <returns>UserPresence</returns>
        public UserPresence PatchUserIdPresencesSource (string userId, string source, UserPresence body = null)
        {
             ApiResponse<UserPresence> localVarResponse = PatchUserIdPresencesSourceWithHttpInfo(userId, source, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch a user&#39;s Presence The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param> 
        /// <param name="source">source</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > PatchUserIdPresencesSourceWithHttpInfo (string userId, string source, UserPresence body = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->PatchUserIdPresencesSource");
            
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->PatchUserIdPresencesSource");
            
    
            var localVarPath = "/api/v2/users/{userId}/presences/{source}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PatchUserIdPresencesSource: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserIdPresencesSource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }

        
        /// <summary>
        /// Patch a user&#39;s Presence The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <param name="body"></param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> PatchUserIdPresencesSourceAsync (string userId, string source, UserPresence body = null)
        {
             ApiResponse<UserPresence> localVarResponse = await PatchUserIdPresencesSourceAsyncWithHttpInfo(userId, source, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch a user&#39;s Presence The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> PatchUserIdPresencesSourceAsyncWithHttpInfo (string userId, string source, UserPresence body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling PatchUserIdPresencesSource");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling PatchUserIdPresencesSource");
            
    
            var localVarPath = "/api/v2/users/{userId}/presences/{source}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PatchUserIdPresencesSource: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserIdPresencesSource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }
        
        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param> 
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PostPresencedefinitions (OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = PostPresencedefinitionsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param> 
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PostPresencedefinitionsWithHttpInfo (OrganizationPresence body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PostPresencedefinitions");
            
    
            var localVarPath = "/api/v2/presencedefinitions";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostPresencedefinitions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostPresencedefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<OrganizationPresence> PostPresencedefinitionsAsync (OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await PostPresencedefinitionsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PostPresencedefinitionsAsyncWithHttpInfo (OrganizationPresence body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostPresencedefinitions");
            
    
            var localVarPath = "/api/v2/presencedefinitions";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostPresencedefinitions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostPresencedefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public OrganizationPresence PutPresenceId (string presenceId, OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = PutPresenceIdWithHttpInfo(presenceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param> 
        /// <param name="body">The OrganizationPresence to update</param> 
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PutPresenceIdWithHttpInfo (string presenceId, OrganizationPresence body)
        {
            
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PutPresenceId");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PutPresenceId");
            
    
            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<OrganizationPresence> PutPresenceIdAsync (string presenceId, OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await PutPresenceIdAsyncWithHttpInfo(presenceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PutPresenceIdAsyncWithHttpInfo (string presenceId, OrganizationPresence body)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null) throw new ApiException(400, "Missing required parameter 'presenceId' when calling PutPresenceId");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PutPresenceId");
            
    
            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }
        
    }
    
}
