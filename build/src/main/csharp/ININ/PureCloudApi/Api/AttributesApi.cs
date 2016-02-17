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
        
        /// <summary>
        /// Gets a list of existing attributes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>AttributeEntityListing</returns>
        AttributeEntityListing GetAttributes (int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Gets a list of existing attributes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of AttributeEntityListing</returns>
        ApiResponse<AttributeEntityListing> GetAttributesWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a list of existing attributes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of AttributeEntityListing</returns>
        System.Threading.Tasks.Task<AttributeEntityListing> GetAttributesAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a list of existing attributes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (AttributeEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttributeEntityListing>> GetAttributesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Create an attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Attribute</param>
        /// <returns>ININ.PureCloudApi.Model.Attribute</returns>
        ININ.PureCloudApi.Model.Attribute PostAttributes (ININ.PureCloudApi.Model.Attribute body = null);
  
        /// <summary>
        /// Create an attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Attribute</param>
        /// <returns>ApiResponse of ININ.PureCloudApi.Model.Attribute</returns>
        ApiResponse<ININ.PureCloudApi.Model.Attribute> PostAttributesWithHttpInfo (ININ.PureCloudApi.Model.Attribute body = null);

        /// <summary>
        /// Create an attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ININ.PureCloudApi.Model.Attribute</returns>
        System.Threading.Tasks.Task<ININ.PureCloudApi.Model.Attribute> PostAttributesAsync (ININ.PureCloudApi.Model.Attribute body = null);

        /// <summary>
        /// Create an attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ApiResponse (ININ.PureCloudApi.Model.Attribute)</returns>
        System.Threading.Tasks.Task<ApiResponse<ININ.PureCloudApi.Model.Attribute>> PostAttributesAsyncWithHttpInfo (ININ.PureCloudApi.Model.Attribute body = null);
        
        /// <summary>
        /// Query attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">query</param>
        /// <returns>AttributeEntityListing</returns>
        AttributeEntityListing PostQuery (AttributeQueryRequest body = null);
  
        /// <summary>
        /// Query attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AttributeEntityListing</returns>
        ApiResponse<AttributeEntityListing> PostQueryWithHttpInfo (AttributeQueryRequest body = null);

        /// <summary>
        /// Query attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">query</param>
        /// <returns>Task of AttributeEntityListing</returns>
        System.Threading.Tasks.Task<AttributeEntityListing> PostQueryAsync (AttributeQueryRequest body = null);

        /// <summary>
        /// Query attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AttributeEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttributeEntityListing>> PostQueryAsyncWithHttpInfo (AttributeQueryRequest body = null);
        
        /// <summary>
        /// Get details about an existing attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>ININ.PureCloudApi.Model.Attribute</returns>
        ININ.PureCloudApi.Model.Attribute Get (string attributeId);
  
        /// <summary>
        /// Get details about an existing attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>ApiResponse of ININ.PureCloudApi.Model.Attribute</returns>
        ApiResponse<ININ.PureCloudApi.Model.Attribute> GetWithHttpInfo (string attributeId);

        /// <summary>
        /// Get details about an existing attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ININ.PureCloudApi.Model.Attribute</returns>
        System.Threading.Tasks.Task<ININ.PureCloudApi.Model.Attribute> GetAsync (string attributeId);

        /// <summary>
        /// Get details about an existing attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ApiResponse (ININ.PureCloudApi.Model.Attribute)</returns>
        System.Threading.Tasks.Task<ApiResponse<ININ.PureCloudApi.Model.Attribute>> GetAsyncWithHttpInfo (string attributeId);
        
        /// <summary>
        /// Update an existing attribute.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, description. The most recent version is required for updates.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>ININ.PureCloudApi.Model.Attribute</returns>
        ININ.PureCloudApi.Model.Attribute Put (string attributeId, ININ.PureCloudApi.Model.Attribute body = null);
  
        /// <summary>
        /// Update an existing attribute.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, description. The most recent version is required for updates.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>ApiResponse of ININ.PureCloudApi.Model.Attribute</returns>
        ApiResponse<ININ.PureCloudApi.Model.Attribute> PutWithHttpInfo (string attributeId, ININ.PureCloudApi.Model.Attribute body = null);

        /// <summary>
        /// Update an existing attribute.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, description. The most recent version is required for updates.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ININ.PureCloudApi.Model.Attribute</returns>
        System.Threading.Tasks.Task<ININ.PureCloudApi.Model.Attribute> PutAsync (string attributeId, ININ.PureCloudApi.Model.Attribute body = null);

        /// <summary>
        /// Update an existing attribute.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, description. The most recent version is required for updates.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ApiResponse (ININ.PureCloudApi.Model.Attribute)</returns>
        System.Threading.Tasks.Task<ApiResponse<ININ.PureCloudApi.Model.Attribute>> PutAsyncWithHttpInfo (string attributeId, ININ.PureCloudApi.Model.Attribute body = null);
        
        /// <summary>
        /// Delete an existing Attribute.
        /// </summary>
        /// <remarks>
        /// This will remove attribute.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns></returns>
        void Delete (string attributeId);
  
        /// <summary>
        /// Delete an existing Attribute.
        /// </summary>
        /// <remarks>
        /// This will remove attribute.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWithHttpInfo (string attributeId);

        /// <summary>
        /// Delete an existing Attribute.
        /// </summary>
        /// <remarks>
        /// This will remove attribute.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAsync (string attributeId);

        /// <summary>
        /// Delete an existing Attribute.
        /// </summary>
        /// <remarks>
        /// This will remove attribute.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo (string attributeId);
        
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
        /// Gets a list of existing attributes. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>AttributeEntityListing</returns>
        public AttributeEntityListing GetAttributes (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<AttributeEntityListing> response = GetAttributesWithHttpInfo(pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of existing attributes. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of AttributeEntityListing</returns>
        public ApiResponse< AttributeEntityListing > GetAttributesWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/attributes";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetAttributes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAttributes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AttributeEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttributeEntityListing) Configuration.ApiClient.Deserialize(response, typeof(AttributeEntityListing)));
            
        }
    
        /// <summary>
        /// Gets a list of existing attributes. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of AttributeEntityListing</returns>
        public async System.Threading.Tasks.Task<AttributeEntityListing> GetAttributesAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<AttributeEntityListing> response = await GetAttributesAsyncWithHttpInfo(pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of existing attributes. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (AttributeEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttributeEntityListing>> GetAttributesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/attributes";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetAttributes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAttributes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AttributeEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttributeEntityListing) Configuration.ApiClient.Deserialize(response, typeof(AttributeEntityListing)));
            
        }
        
        /// <summary>
        /// Create an attribute. 
        /// </summary>
        /// <param name="body">Attribute</param> 
        /// <returns>ININ.PureCloudApi.Model.Attribute</returns>
        public ININ.PureCloudApi.Model.Attribute PostAttributes (ININ.PureCloudApi.Model.Attribute body = null)
        {
             ApiResponse<ININ.PureCloudApi.Model.Attribute> response = PostAttributesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an attribute. 
        /// </summary>
        /// <param name="body">Attribute</param> 
        /// <returns>ApiResponse of ININ.PureCloudApi.Model.Attribute</returns>
        public ApiResponse< ININ.PureCloudApi.Model.Attribute > PostAttributesWithHttpInfo (ININ.PureCloudApi.Model.Attribute body = null)
        {
            
    
            var path_ = "/api/v1/attributes";
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostAttributes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostAttributes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ININ.PureCloudApi.Model.Attribute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ININ.PureCloudApi.Model.Attribute) Configuration.ApiClient.Deserialize(response, typeof(ININ.PureCloudApi.Model.Attribute)));
            
        }
    
        /// <summary>
        /// Create an attribute. 
        /// </summary>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ININ.PureCloudApi.Model.Attribute</returns>
        public async System.Threading.Tasks.Task<ININ.PureCloudApi.Model.Attribute> PostAttributesAsync (ININ.PureCloudApi.Model.Attribute body = null)
        {
             ApiResponse<ININ.PureCloudApi.Model.Attribute> response = await PostAttributesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an attribute. 
        /// </summary>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ApiResponse (ININ.PureCloudApi.Model.Attribute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ININ.PureCloudApi.Model.Attribute>> PostAttributesAsyncWithHttpInfo (ININ.PureCloudApi.Model.Attribute body = null)
        {
            
    
            var path_ = "/api/v1/attributes";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostAttributes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostAttributes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ININ.PureCloudApi.Model.Attribute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ININ.PureCloudApi.Model.Attribute) Configuration.ApiClient.Deserialize(response, typeof(ININ.PureCloudApi.Model.Attribute)));
            
        }
        
        /// <summary>
        /// Query attributes 
        /// </summary>
        /// <param name="body">query</param> 
        /// <returns>AttributeEntityListing</returns>
        public AttributeEntityListing PostQuery (AttributeQueryRequest body = null)
        {
             ApiResponse<AttributeEntityListing> response = PostQueryWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Query attributes 
        /// </summary>
        /// <param name="body">query</param> 
        /// <returns>ApiResponse of AttributeEntityListing</returns>
        public ApiResponse< AttributeEntityListing > PostQueryWithHttpInfo (AttributeQueryRequest body = null)
        {
            
    
            var path_ = "/api/v1/attributes/query";
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostQuery: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AttributeEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttributeEntityListing) Configuration.ApiClient.Deserialize(response, typeof(AttributeEntityListing)));
            
        }
    
        /// <summary>
        /// Query attributes 
        /// </summary>
        /// <param name="body">query</param>
        /// <returns>Task of AttributeEntityListing</returns>
        public async System.Threading.Tasks.Task<AttributeEntityListing> PostQueryAsync (AttributeQueryRequest body = null)
        {
             ApiResponse<AttributeEntityListing> response = await PostQueryAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Query attributes 
        /// </summary>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AttributeEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttributeEntityListing>> PostQueryAsyncWithHttpInfo (AttributeQueryRequest body = null)
        {
            
    
            var path_ = "/api/v1/attributes/query";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostQuery: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AttributeEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttributeEntityListing) Configuration.ApiClient.Deserialize(response, typeof(AttributeEntityListing)));
            
        }
        
        /// <summary>
        /// Get details about an existing attribute. 
        /// </summary>
        /// <param name="attributeId">Attribute ID</param> 
        /// <returns>ININ.PureCloudApi.Model.Attribute</returns>
        public ININ.PureCloudApi.Model.Attribute Get (string attributeId)
        {
             ApiResponse<ININ.PureCloudApi.Model.Attribute> response = GetWithHttpInfo(attributeId);
             return response.Data;
        }

        /// <summary>
        /// Get details about an existing attribute. 
        /// </summary>
        /// <param name="attributeId">Attribute ID</param> 
        /// <returns>ApiResponse of ININ.PureCloudApi.Model.Attribute</returns>
        public ApiResponse< ININ.PureCloudApi.Model.Attribute > GetWithHttpInfo (string attributeId)
        {
            
            // verify the required parameter 'attributeId' is set
            if (attributeId == null)
                throw new ApiException(400, "Missing required parameter 'attributeId' when calling AttributesApi->Get");
            
    
            var path_ = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) pathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
            

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
    
            return new ApiResponse<ININ.PureCloudApi.Model.Attribute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ININ.PureCloudApi.Model.Attribute) Configuration.ApiClient.Deserialize(response, typeof(ININ.PureCloudApi.Model.Attribute)));
            
        }
    
        /// <summary>
        /// Get details about an existing attribute. 
        /// </summary>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ININ.PureCloudApi.Model.Attribute</returns>
        public async System.Threading.Tasks.Task<ININ.PureCloudApi.Model.Attribute> GetAsync (string attributeId)
        {
             ApiResponse<ININ.PureCloudApi.Model.Attribute> response = await GetAsyncWithHttpInfo(attributeId);
             return response.Data;

        }

        /// <summary>
        /// Get details about an existing attribute. 
        /// </summary>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ApiResponse (ININ.PureCloudApi.Model.Attribute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ININ.PureCloudApi.Model.Attribute>> GetAsyncWithHttpInfo (string attributeId)
        {
            // verify the required parameter 'attributeId' is set
            if (attributeId == null) throw new ApiException(400, "Missing required parameter 'attributeId' when calling Get");
            
    
            var path_ = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) pathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
            

            
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

            return new ApiResponse<ININ.PureCloudApi.Model.Attribute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ININ.PureCloudApi.Model.Attribute) Configuration.ApiClient.Deserialize(response, typeof(ININ.PureCloudApi.Model.Attribute)));
            
        }
        
        /// <summary>
        /// Update an existing attribute. Fields that can be updated: name, description. The most recent version is required for updates.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param> 
        /// <param name="body">Attribute</param> 
        /// <returns>ININ.PureCloudApi.Model.Attribute</returns>
        public ININ.PureCloudApi.Model.Attribute Put (string attributeId, ININ.PureCloudApi.Model.Attribute body = null)
        {
             ApiResponse<ININ.PureCloudApi.Model.Attribute> response = PutWithHttpInfo(attributeId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an existing attribute. Fields that can be updated: name, description. The most recent version is required for updates.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param> 
        /// <param name="body">Attribute</param> 
        /// <returns>ApiResponse of ININ.PureCloudApi.Model.Attribute</returns>
        public ApiResponse< ININ.PureCloudApi.Model.Attribute > PutWithHttpInfo (string attributeId, ININ.PureCloudApi.Model.Attribute body = null)
        {
            
            // verify the required parameter 'attributeId' is set
            if (attributeId == null)
                throw new ApiException(400, "Missing required parameter 'attributeId' when calling AttributesApi->Put");
            
    
            var path_ = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) pathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Put: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Put: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ININ.PureCloudApi.Model.Attribute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ININ.PureCloudApi.Model.Attribute) Configuration.ApiClient.Deserialize(response, typeof(ININ.PureCloudApi.Model.Attribute)));
            
        }
    
        /// <summary>
        /// Update an existing attribute. Fields that can be updated: name, description. The most recent version is required for updates.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ININ.PureCloudApi.Model.Attribute</returns>
        public async System.Threading.Tasks.Task<ININ.PureCloudApi.Model.Attribute> PutAsync (string attributeId, ININ.PureCloudApi.Model.Attribute body = null)
        {
             ApiResponse<ININ.PureCloudApi.Model.Attribute> response = await PutAsyncWithHttpInfo(attributeId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an existing attribute. Fields that can be updated: name, description. The most recent version is required for updates.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ApiResponse (ININ.PureCloudApi.Model.Attribute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ININ.PureCloudApi.Model.Attribute>> PutAsyncWithHttpInfo (string attributeId, ININ.PureCloudApi.Model.Attribute body = null)
        {
            // verify the required parameter 'attributeId' is set
            if (attributeId == null) throw new ApiException(400, "Missing required parameter 'attributeId' when calling Put");
            
    
            var path_ = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) pathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Put: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Put: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ININ.PureCloudApi.Model.Attribute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ININ.PureCloudApi.Model.Attribute) Configuration.ApiClient.Deserialize(response, typeof(ININ.PureCloudApi.Model.Attribute)));
            
        }
        
        /// <summary>
        /// Delete an existing Attribute. This will remove attribute.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param> 
        /// <returns></returns>
        public void Delete (string attributeId)
        {
             DeleteWithHttpInfo(attributeId);
        }

        /// <summary>
        /// Delete an existing Attribute. This will remove attribute.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWithHttpInfo (string attributeId)
        {
            
            // verify the required parameter 'attributeId' is set
            if (attributeId == null)
                throw new ApiException(400, "Missing required parameter 'attributeId' when calling AttributesApi->Delete");
            
    
            var path_ = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) pathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Delete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Delete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an existing Attribute. This will remove attribute.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAsync (string attributeId)
        {
             await DeleteAsyncWithHttpInfo(attributeId);

        }

        /// <summary>
        /// Delete an existing Attribute. This will remove attribute.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo (string attributeId)
        {
            // verify the required parameter 'attributeId' is set
            if (attributeId == null) throw new ApiException(400, "Missing required parameter 'attributeId' when calling Delete");
            
    
            var path_ = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) pathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Delete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Delete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
