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
    public interface IAttributesApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Delete an existing Attribute.
        /// </summary>
        /// <remarks>
        /// This will remove attribute.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns></returns>
        void DeleteAttributeId (string attributeId);
  
        /// <summary>
        /// Delete an existing Attribute.
        /// </summary>
        /// <remarks>
        /// This will remove attribute.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAttributeIdWithHttpInfo (string attributeId);
        
        /// <summary>
        /// Gets a list of existing attributes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>AttributeEntityListing</returns>
        AttributeEntityListing Get (int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Gets a list of existing attributes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of AttributeEntityListing</returns>
        ApiResponse<AttributeEntityListing> GetWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get details about an existing attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>ININ.PureCloudApi.Model.Attribute</returns>
        ININ.PureCloudApi.Model.Attribute GetAttributeId (string attributeId);
  
        /// <summary>
        /// Get details about an existing attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>ApiResponse of ININ.PureCloudApi.Model.Attribute</returns>
        ApiResponse<ININ.PureCloudApi.Model.Attribute> GetAttributeIdWithHttpInfo (string attributeId);
        
        /// <summary>
        /// Create an attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Attribute</param>
        /// <returns>ININ.PureCloudApi.Model.Attribute</returns>
        ININ.PureCloudApi.Model.Attribute Post (ININ.PureCloudApi.Model.Attribute body = null);
  
        /// <summary>
        /// Create an attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Attribute</param>
        /// <returns>ApiResponse of ININ.PureCloudApi.Model.Attribute</returns>
        ApiResponse<ININ.PureCloudApi.Model.Attribute> PostWithHttpInfo (ININ.PureCloudApi.Model.Attribute body = null);
        
        /// <summary>
        /// Query attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AttributeEntityListing</returns>
        AttributeEntityListing PostQuery (AttributeQueryRequest body = null);
  
        /// <summary>
        /// Query attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AttributeEntityListing</returns>
        ApiResponse<AttributeEntityListing> PostQueryWithHttpInfo (AttributeQueryRequest body = null);
        
        /// <summary>
        /// Update an existing attribute.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, description. The most recent version is required for updates.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>ININ.PureCloudApi.Model.Attribute</returns>
        ININ.PureCloudApi.Model.Attribute PutAttributeId (string attributeId, ININ.PureCloudApi.Model.Attribute body = null);
  
        /// <summary>
        /// Update an existing attribute.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, description. The most recent version is required for updates.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>ApiResponse of ININ.PureCloudApi.Model.Attribute</returns>
        ApiResponse<ININ.PureCloudApi.Model.Attribute> PutAttributeIdWithHttpInfo (string attributeId, ININ.PureCloudApi.Model.Attribute body = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Delete an existing Attribute.
        /// </summary>
        /// <remarks>
        /// This will remove attribute.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAttributeIdAsync (string attributeId);

        /// <summary>
        /// Delete an existing Attribute.
        /// </summary>
        /// <remarks>
        /// This will remove attribute.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAttributeIdAsyncWithHttpInfo (string attributeId);
        
        /// <summary>
        /// Gets a list of existing attributes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of AttributeEntityListing</returns>
        System.Threading.Tasks.Task<AttributeEntityListing> GetAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a list of existing attributes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (AttributeEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttributeEntityListing>> GetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get details about an existing attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ININ.PureCloudApi.Model.Attribute</returns>
        System.Threading.Tasks.Task<ININ.PureCloudApi.Model.Attribute> GetAttributeIdAsync (string attributeId);

        /// <summary>
        /// Get details about an existing attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ApiResponse (ININ.PureCloudApi.Model.Attribute)</returns>
        System.Threading.Tasks.Task<ApiResponse<ININ.PureCloudApi.Model.Attribute>> GetAttributeIdAsyncWithHttpInfo (string attributeId);
        
        /// <summary>
        /// Create an attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ININ.PureCloudApi.Model.Attribute</returns>
        System.Threading.Tasks.Task<ININ.PureCloudApi.Model.Attribute> PostAsync (ININ.PureCloudApi.Model.Attribute body = null);

        /// <summary>
        /// Create an attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ApiResponse (ININ.PureCloudApi.Model.Attribute)</returns>
        System.Threading.Tasks.Task<ApiResponse<ININ.PureCloudApi.Model.Attribute>> PostAsyncWithHttpInfo (ININ.PureCloudApi.Model.Attribute body = null);
        
        /// <summary>
        /// Query attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AttributeEntityListing</returns>
        System.Threading.Tasks.Task<AttributeEntityListing> PostQueryAsync (AttributeQueryRequest body = null);

        /// <summary>
        /// Query attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AttributeEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttributeEntityListing>> PostQueryAsyncWithHttpInfo (AttributeQueryRequest body = null);
        
        /// <summary>
        /// Update an existing attribute.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, description. The most recent version is required for updates.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ININ.PureCloudApi.Model.Attribute</returns>
        System.Threading.Tasks.Task<ININ.PureCloudApi.Model.Attribute> PutAttributeIdAsync (string attributeId, ININ.PureCloudApi.Model.Attribute body = null);

        /// <summary>
        /// Update an existing attribute.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, description. The most recent version is required for updates.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ApiResponse (ININ.PureCloudApi.Model.Attribute)</returns>
        System.Threading.Tasks.Task<ApiResponse<ININ.PureCloudApi.Model.Attribute>> PutAttributeIdAsyncWithHttpInfo (string attributeId, ININ.PureCloudApi.Model.Attribute body = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AttributesApi : IAttributesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AttributesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AttributesApi(Configuration configuration = null)
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
        /// Delete an existing Attribute. This will remove attribute.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param> 
        /// <returns></returns>
        public void DeleteAttributeId (string attributeId)
        {
             DeleteAttributeIdWithHttpInfo(attributeId);
        }

        /// <summary>
        /// Delete an existing Attribute. This will remove attribute.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteAttributeIdWithHttpInfo (string attributeId)
        {
            
            // verify the required parameter 'attributeId' is set
            if (attributeId == null)
                throw new ApiException(400, "Missing required parameter 'attributeId' when calling AttributesApi->DeleteAttributeId");
            
    
            var localVarPath = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) localVarPathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAttributeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAttributeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an existing Attribute. This will remove attribute.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAttributeIdAsync (string attributeId)
        {
             await DeleteAttributeIdAsyncWithHttpInfo(attributeId);

        }

        /// <summary>
        /// Delete an existing Attribute. This will remove attribute.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAttributeIdAsyncWithHttpInfo (string attributeId)
        {
            // verify the required parameter 'attributeId' is set
            if (attributeId == null) throw new ApiException(400, "Missing required parameter 'attributeId' when calling DeleteAttributeId");
            
    
            var localVarPath = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) localVarPathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAttributeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAttributeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Gets a list of existing attributes. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>AttributeEntityListing</returns>
        public AttributeEntityListing Get (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<AttributeEntityListing> localVarResponse = GetWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a list of existing attributes. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of AttributeEntityListing</returns>
        public ApiResponse< AttributeEntityListing > GetWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var localVarPath = "/api/v1/attributes";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Get: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Get: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AttributeEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttributeEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttributeEntityListing)));
            
        }

        
        /// <summary>
        /// Gets a list of existing attributes. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of AttributeEntityListing</returns>
        public async System.Threading.Tasks.Task<AttributeEntityListing> GetAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<AttributeEntityListing> localVarResponse = await GetAsyncWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a list of existing attributes. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (AttributeEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttributeEntityListing>> GetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var localVarPath = "/api/v1/attributes";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Get: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Get: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttributeEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttributeEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttributeEntityListing)));
            
        }
        
        /// <summary>
        /// Get details about an existing attribute. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param> 
        /// <returns>ININ.PureCloudApi.Model.Attribute</returns>
        public ININ.PureCloudApi.Model.Attribute GetAttributeId (string attributeId)
        {
             ApiResponse<ININ.PureCloudApi.Model.Attribute> localVarResponse = GetAttributeIdWithHttpInfo(attributeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get details about an existing attribute. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param> 
        /// <returns>ApiResponse of ININ.PureCloudApi.Model.Attribute</returns>
        public ApiResponse< ININ.PureCloudApi.Model.Attribute > GetAttributeIdWithHttpInfo (string attributeId)
        {
            
            // verify the required parameter 'attributeId' is set
            if (attributeId == null)
                throw new ApiException(400, "Missing required parameter 'attributeId' when calling AttributesApi->GetAttributeId");
            
    
            var localVarPath = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) localVarPathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetAttributeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAttributeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ININ.PureCloudApi.Model.Attribute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ININ.PureCloudApi.Model.Attribute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ININ.PureCloudApi.Model.Attribute)));
            
        }

        
        /// <summary>
        /// Get details about an existing attribute. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ININ.PureCloudApi.Model.Attribute</returns>
        public async System.Threading.Tasks.Task<ININ.PureCloudApi.Model.Attribute> GetAttributeIdAsync (string attributeId)
        {
             ApiResponse<ININ.PureCloudApi.Model.Attribute> localVarResponse = await GetAttributeIdAsyncWithHttpInfo(attributeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get details about an existing attribute. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ApiResponse (ININ.PureCloudApi.Model.Attribute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ININ.PureCloudApi.Model.Attribute>> GetAttributeIdAsyncWithHttpInfo (string attributeId)
        {
            // verify the required parameter 'attributeId' is set
            if (attributeId == null) throw new ApiException(400, "Missing required parameter 'attributeId' when calling GetAttributeId");
            
    
            var localVarPath = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) localVarPathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetAttributeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAttributeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ININ.PureCloudApi.Model.Attribute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ININ.PureCloudApi.Model.Attribute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ININ.PureCloudApi.Model.Attribute)));
            
        }
        
        /// <summary>
        /// Create an attribute. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Attribute</param> 
        /// <returns>ININ.PureCloudApi.Model.Attribute</returns>
        public ININ.PureCloudApi.Model.Attribute Post (ININ.PureCloudApi.Model.Attribute body = null)
        {
             ApiResponse<ININ.PureCloudApi.Model.Attribute> localVarResponse = PostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an attribute. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Attribute</param> 
        /// <returns>ApiResponse of ININ.PureCloudApi.Model.Attribute</returns>
        public ApiResponse< ININ.PureCloudApi.Model.Attribute > PostWithHttpInfo (ININ.PureCloudApi.Model.Attribute body = null)
        {
            
    
            var localVarPath = "/api/v1/attributes";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Post: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Post: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ININ.PureCloudApi.Model.Attribute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ININ.PureCloudApi.Model.Attribute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ININ.PureCloudApi.Model.Attribute)));
            
        }

        
        /// <summary>
        /// Create an attribute. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ININ.PureCloudApi.Model.Attribute</returns>
        public async System.Threading.Tasks.Task<ININ.PureCloudApi.Model.Attribute> PostAsync (ININ.PureCloudApi.Model.Attribute body = null)
        {
             ApiResponse<ININ.PureCloudApi.Model.Attribute> localVarResponse = await PostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an attribute. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ApiResponse (ININ.PureCloudApi.Model.Attribute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ININ.PureCloudApi.Model.Attribute>> PostAsyncWithHttpInfo (ININ.PureCloudApi.Model.Attribute body = null)
        {
            
    
            var localVarPath = "/api/v1/attributes";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Post: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Post: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ININ.PureCloudApi.Model.Attribute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ININ.PureCloudApi.Model.Attribute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ININ.PureCloudApi.Model.Attribute)));
            
        }
        
        /// <summary>
        /// Query attributes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param> 
        /// <returns>AttributeEntityListing</returns>
        public AttributeEntityListing PostQuery (AttributeQueryRequest body = null)
        {
             ApiResponse<AttributeEntityListing> localVarResponse = PostQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query attributes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param> 
        /// <returns>ApiResponse of AttributeEntityListing</returns>
        public ApiResponse< AttributeEntityListing > PostQueryWithHttpInfo (AttributeQueryRequest body = null)
        {
            
    
            var localVarPath = "/api/v1/attributes/query";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AttributeEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttributeEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttributeEntityListing)));
            
        }

        
        /// <summary>
        /// Query attributes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AttributeEntityListing</returns>
        public async System.Threading.Tasks.Task<AttributeEntityListing> PostQueryAsync (AttributeQueryRequest body = null)
        {
             ApiResponse<AttributeEntityListing> localVarResponse = await PostQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query attributes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AttributeEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttributeEntityListing>> PostQueryAsyncWithHttpInfo (AttributeQueryRequest body = null)
        {
            
    
            var localVarPath = "/api/v1/attributes/query";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttributeEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttributeEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttributeEntityListing)));
            
        }
        
        /// <summary>
        /// Update an existing attribute. Fields that can be updated: name, description. The most recent version is required for updates.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param> 
        /// <param name="body">Attribute</param> 
        /// <returns>ININ.PureCloudApi.Model.Attribute</returns>
        public ININ.PureCloudApi.Model.Attribute PutAttributeId (string attributeId, ININ.PureCloudApi.Model.Attribute body = null)
        {
             ApiResponse<ININ.PureCloudApi.Model.Attribute> localVarResponse = PutAttributeIdWithHttpInfo(attributeId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing attribute. Fields that can be updated: name, description. The most recent version is required for updates.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param> 
        /// <param name="body">Attribute</param> 
        /// <returns>ApiResponse of ININ.PureCloudApi.Model.Attribute</returns>
        public ApiResponse< ININ.PureCloudApi.Model.Attribute > PutAttributeIdWithHttpInfo (string attributeId, ININ.PureCloudApi.Model.Attribute body = null)
        {
            
            // verify the required parameter 'attributeId' is set
            if (attributeId == null)
                throw new ApiException(400, "Missing required parameter 'attributeId' when calling AttributesApi->PutAttributeId");
            
    
            var localVarPath = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) localVarPathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PutAttributeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAttributeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ININ.PureCloudApi.Model.Attribute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ININ.PureCloudApi.Model.Attribute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ININ.PureCloudApi.Model.Attribute)));
            
        }

        
        /// <summary>
        /// Update an existing attribute. Fields that can be updated: name, description. The most recent version is required for updates.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ININ.PureCloudApi.Model.Attribute</returns>
        public async System.Threading.Tasks.Task<ININ.PureCloudApi.Model.Attribute> PutAttributeIdAsync (string attributeId, ININ.PureCloudApi.Model.Attribute body = null)
        {
             ApiResponse<ININ.PureCloudApi.Model.Attribute> localVarResponse = await PutAttributeIdAsyncWithHttpInfo(attributeId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an existing attribute. Fields that can be updated: name, description. The most recent version is required for updates.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ApiResponse (ININ.PureCloudApi.Model.Attribute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ININ.PureCloudApi.Model.Attribute>> PutAttributeIdAsyncWithHttpInfo (string attributeId, ININ.PureCloudApi.Model.Attribute body = null)
        {
            // verify the required parameter 'attributeId' is set
            if (attributeId == null) throw new ApiException(400, "Missing required parameter 'attributeId' when calling PutAttributeId");
            
    
            var localVarPath = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) localVarPathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PutAttributeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAttributeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ININ.PureCloudApi.Model.Attribute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ININ.PureCloudApi.Model.Attribute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ININ.PureCloudApi.Model.Attribute)));
            
        }
        
    }
    
}
