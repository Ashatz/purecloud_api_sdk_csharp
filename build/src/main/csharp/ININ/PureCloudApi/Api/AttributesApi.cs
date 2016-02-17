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
        AttributeEntityListing Get (int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Gets a list of existing attributes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of AttributeEntityListing</returns>
        ApiResponse<AttributeEntityListing> GetWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Gets a list of existing attributes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (AttributeEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttributeEntityListing>> GetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Create an attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Attribute</param>
        /// <returns>Attribute</returns>
        Attribute Create (Attribute body = null);
  
        /// <summary>
        /// Create an attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Attribute</param>
        /// <returns>ApiResponse of Attribute</returns>
        ApiResponse<Attribute> CreateWithHttpInfo (Attribute body = null);

        /// <summary>
        /// Create an attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Attribute</param>
        /// <returns>Task of Attribute</returns>
        System.Threading.Tasks.Task<Attribute> CreateAsync (Attribute body = null);

        /// <summary>
        /// Create an attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ApiResponse (Attribute)</returns>
        System.Threading.Tasks.Task<ApiResponse<Attribute>> CreateAsyncWithHttpInfo (Attribute body = null);
        
        /// <summary>
        /// Query attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">query</param>
        /// <returns>AttributeEntityListing</returns>
        AttributeEntityListing CreateQuery (AttributeQueryRequest body = null);
  
        /// <summary>
        /// Query attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AttributeEntityListing</returns>
        ApiResponse<AttributeEntityListing> CreateQueryWithHttpInfo (AttributeQueryRequest body = null);

        /// <summary>
        /// Query attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">query</param>
        /// <returns>Task of AttributeEntityListing</returns>
        System.Threading.Tasks.Task<AttributeEntityListing> CreateQueryAsync (AttributeQueryRequest body = null);

        /// <summary>
        /// Query attributes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AttributeEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttributeEntityListing>> CreateQueryAsyncWithHttpInfo (AttributeQueryRequest body = null);
        
        /// <summary>
        /// Get details about an existing attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Attribute</returns>
        Attribute GetAttribute (string attributeId);
  
        /// <summary>
        /// Get details about an existing attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>ApiResponse of Attribute</returns>
        ApiResponse<Attribute> GetAttributeWithHttpInfo (string attributeId);

        /// <summary>
        /// Get details about an existing attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of Attribute</returns>
        System.Threading.Tasks.Task<Attribute> GetAttributeAsync (string attributeId);

        /// <summary>
        /// Get details about an existing attribute.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ApiResponse (Attribute)</returns>
        System.Threading.Tasks.Task<ApiResponse<Attribute>> GetAttributeAsyncWithHttpInfo (string attributeId);
        
        /// <summary>
        /// Update an existing attribute.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, description. The most recent version is required for updates.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>Attribute</returns>
        Attribute UpdateAttribute (string attributeId, Attribute body = null);
  
        /// <summary>
        /// Update an existing attribute.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, description. The most recent version is required for updates.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>ApiResponse of Attribute</returns>
        ApiResponse<Attribute> UpdateAttributeWithHttpInfo (string attributeId, Attribute body = null);

        /// <summary>
        /// Update an existing attribute.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, description. The most recent version is required for updates.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>Task of Attribute</returns>
        System.Threading.Tasks.Task<Attribute> UpdateAttributeAsync (string attributeId, Attribute body = null);

        /// <summary>
        /// Update an existing attribute.
        /// </summary>
        /// <remarks>
        /// Fields that can be updated: name, description. The most recent version is required for updates.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ApiResponse (Attribute)</returns>
        System.Threading.Tasks.Task<ApiResponse<Attribute>> UpdateAttributeAsyncWithHttpInfo (string attributeId, Attribute body = null);
        
        /// <summary>
        /// Delete an existing Attribute.
        /// </summary>
        /// <remarks>
        /// This will remove attribute.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns></returns>
        void DeleteAttribute (string attributeId);
  
        /// <summary>
        /// Delete an existing Attribute.
        /// </summary>
        /// <remarks>
        /// This will remove attribute.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAttributeWithHttpInfo (string attributeId);

        /// <summary>
        /// Delete an existing Attribute.
        /// </summary>
        /// <remarks>
        /// This will remove attribute.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAttributeAsync (string attributeId);

        /// <summary>
        /// Delete an existing Attribute.
        /// </summary>
        /// <remarks>
        /// This will remove attribute.
        /// </remarks>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAttributeAsyncWithHttpInfo (string attributeId);
        
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
        public AttributeEntityListing Get (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<AttributeEntityListing> response = GetWithHttpInfo(pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of existing attributes. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of AttributeEntityListing</returns>
        public ApiResponse< AttributeEntityListing > GetWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/attributes";
    
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
        public async System.Threading.Tasks.Task<AttributeEntityListing> GetAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<AttributeEntityListing> response = await GetAsyncWithHttpInfo(pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of existing attributes. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (AttributeEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttributeEntityListing>> GetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/attributes";
    
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

            return new ApiResponse<AttributeEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttributeEntityListing) Configuration.ApiClient.Deserialize(response, typeof(AttributeEntityListing)));
            
        }
        
        /// <summary>
        /// Create an attribute. 
        /// </summary>
        /// <param name="body">Attribute</param> 
        /// <returns>Attribute</returns>
        public Attribute Create (Attribute body = null)
        {
             ApiResponse<Attribute> response = CreateWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an attribute. 
        /// </summary>
        /// <param name="body">Attribute</param> 
        /// <returns>ApiResponse of Attribute</returns>
        public ApiResponse< Attribute > CreateWithHttpInfo (Attribute body = null)
        {
            
    
            var path_ = "/api/v1/attributes";
    
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
    
            return new ApiResponse<Attribute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Attribute) Configuration.ApiClient.Deserialize(response, typeof(Attribute)));
            
        }
    
        /// <summary>
        /// Create an attribute. 
        /// </summary>
        /// <param name="body">Attribute</param>
        /// <returns>Task of Attribute</returns>
        public async System.Threading.Tasks.Task<Attribute> CreateAsync (Attribute body = null)
        {
             ApiResponse<Attribute> response = await CreateAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an attribute. 
        /// </summary>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ApiResponse (Attribute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Attribute>> CreateAsyncWithHttpInfo (Attribute body = null)
        {
            
    
            var path_ = "/api/v1/attributes";
    
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

            return new ApiResponse<Attribute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Attribute) Configuration.ApiClient.Deserialize(response, typeof(Attribute)));
            
        }
        
        /// <summary>
        /// Query attributes 
        /// </summary>
        /// <param name="body">query</param> 
        /// <returns>AttributeEntityListing</returns>
        public AttributeEntityListing CreateQuery (AttributeQueryRequest body = null)
        {
             ApiResponse<AttributeEntityListing> response = CreateQueryWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Query attributes 
        /// </summary>
        /// <param name="body">query</param> 
        /// <returns>ApiResponse of AttributeEntityListing</returns>
        public ApiResponse< AttributeEntityListing > CreateQueryWithHttpInfo (AttributeQueryRequest body = null)
        {
            
    
            var path_ = "/api/v1/attributes/query";
    
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
                throw new ApiException (statusCode, "Error calling CreateQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateQuery: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AttributeEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttributeEntityListing) Configuration.ApiClient.Deserialize(response, typeof(AttributeEntityListing)));
            
        }
    
        /// <summary>
        /// Query attributes 
        /// </summary>
        /// <param name="body">query</param>
        /// <returns>Task of AttributeEntityListing</returns>
        public async System.Threading.Tasks.Task<AttributeEntityListing> CreateQueryAsync (AttributeQueryRequest body = null)
        {
             ApiResponse<AttributeEntityListing> response = await CreateQueryAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Query attributes 
        /// </summary>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AttributeEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttributeEntityListing>> CreateQueryAsyncWithHttpInfo (AttributeQueryRequest body = null)
        {
            
    
            var path_ = "/api/v1/attributes/query";
    
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
                throw new ApiException (statusCode, "Error calling CreateQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateQuery: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AttributeEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttributeEntityListing) Configuration.ApiClient.Deserialize(response, typeof(AttributeEntityListing)));
            
        }
        
        /// <summary>
        /// Get details about an existing attribute. 
        /// </summary>
        /// <param name="attributeId">Attribute ID</param> 
        /// <returns>Attribute</returns>
        public Attribute GetAttribute (string attributeId)
        {
             ApiResponse<Attribute> response = GetAttributeWithHttpInfo(attributeId);
             return response.Data;
        }

        /// <summary>
        /// Get details about an existing attribute. 
        /// </summary>
        /// <param name="attributeId">Attribute ID</param> 
        /// <returns>ApiResponse of Attribute</returns>
        public ApiResponse< Attribute > GetAttributeWithHttpInfo (string attributeId)
        {
            
            // verify the required parameter 'attributeId' is set
            if (attributeId == null) throw new ApiException(400, "Missing required parameter 'attributeId' when calling GetAttribute");
            
    
            var path_ = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) pathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetAttribute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAttribute: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Attribute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Attribute) Configuration.ApiClient.Deserialize(response, typeof(Attribute)));
            
        }
    
        /// <summary>
        /// Get details about an existing attribute. 
        /// </summary>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of Attribute</returns>
        public async System.Threading.Tasks.Task<Attribute> GetAttributeAsync (string attributeId)
        {
             ApiResponse<Attribute> response = await GetAttributeAsyncWithHttpInfo(attributeId);
             return response.Data;

        }

        /// <summary>
        /// Get details about an existing attribute. 
        /// </summary>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ApiResponse (Attribute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Attribute>> GetAttributeAsyncWithHttpInfo (string attributeId)
        {
            // verify the required parameter 'attributeId' is set
            if (attributeId == null) throw new ApiException(400, "Missing required parameter 'attributeId' when calling GetAttribute");
            
    
            var path_ = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) pathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetAttribute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAttribute: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Attribute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Attribute) Configuration.ApiClient.Deserialize(response, typeof(Attribute)));
            
        }
        
        /// <summary>
        /// Update an existing attribute. Fields that can be updated: name, description. The most recent version is required for updates.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param> 
        /// <param name="body">Attribute</param> 
        /// <returns>Attribute</returns>
        public Attribute UpdateAttribute (string attributeId, Attribute body = null)
        {
             ApiResponse<Attribute> response = UpdateAttributeWithHttpInfo(attributeId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an existing attribute. Fields that can be updated: name, description. The most recent version is required for updates.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param> 
        /// <param name="body">Attribute</param> 
        /// <returns>ApiResponse of Attribute</returns>
        public ApiResponse< Attribute > UpdateAttributeWithHttpInfo (string attributeId, Attribute body = null)
        {
            
            // verify the required parameter 'attributeId' is set
            if (attributeId == null) throw new ApiException(400, "Missing required parameter 'attributeId' when calling UpdateAttribute");
            
    
            var path_ = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) pathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateAttribute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateAttribute: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Attribute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Attribute) Configuration.ApiClient.Deserialize(response, typeof(Attribute)));
            
        }
    
        /// <summary>
        /// Update an existing attribute. Fields that can be updated: name, description. The most recent version is required for updates.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>Task of Attribute</returns>
        public async System.Threading.Tasks.Task<Attribute> UpdateAttributeAsync (string attributeId, Attribute body = null)
        {
             ApiResponse<Attribute> response = await UpdateAttributeAsyncWithHttpInfo(attributeId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an existing attribute. Fields that can be updated: name, description. The most recent version is required for updates.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param>
        /// <param name="body">Attribute</param>
        /// <returns>Task of ApiResponse (Attribute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Attribute>> UpdateAttributeAsyncWithHttpInfo (string attributeId, Attribute body = null)
        {
            // verify the required parameter 'attributeId' is set
            if (attributeId == null) throw new ApiException(400, "Missing required parameter 'attributeId' when calling UpdateAttribute");
            
    
            var path_ = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) pathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateAttribute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateAttribute: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Attribute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Attribute) Configuration.ApiClient.Deserialize(response, typeof(Attribute)));
            
        }
        
        /// <summary>
        /// Delete an existing Attribute. This will remove attribute.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param> 
        /// <returns></returns>
        public void DeleteAttribute (string attributeId)
        {
             DeleteAttributeWithHttpInfo(attributeId);
        }

        /// <summary>
        /// Delete an existing Attribute. This will remove attribute.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteAttributeWithHttpInfo (string attributeId)
        {
            
            // verify the required parameter 'attributeId' is set
            if (attributeId == null) throw new ApiException(400, "Missing required parameter 'attributeId' when calling DeleteAttribute");
            
    
            var path_ = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) pathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteAttribute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteAttribute: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an existing Attribute. This will remove attribute.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAttributeAsync (string attributeId)
        {
             await DeleteAttributeAsyncWithHttpInfo(attributeId);

        }

        /// <summary>
        /// Delete an existing Attribute. This will remove attribute.
        /// </summary>
        /// <param name="attributeId">Attribute ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAttributeAsyncWithHttpInfo (string attributeId)
        {
            // verify the required parameter 'attributeId' is set
            if (attributeId == null) throw new ApiException(400, "Missing required parameter 'attributeId' when calling DeleteAttribute");
            
    
            var path_ = "/api/v1/attributes/{attributeId}";
    
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
            if (attributeId != null) pathParams.Add("attributeId", Configuration.ApiClient.ParameterToString(attributeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteAttribute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteAttribute: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
