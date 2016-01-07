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
    public interface IComplianceApi
    {
        
        /// <summary>
        /// Get information about HIPAA compliance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>HIPAAConfig</returns>
        HIPAAConfig ComplianceHipaaGet ();
  
        /// <summary>
        /// Get information about HIPAA compliance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of HIPAAConfig</returns>
        ApiResponse<HIPAAConfig> ComplianceHipaaGetWithHttpInfo ();

        /// <summary>
        /// Get information about HIPAA compliance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of HIPAAConfig</returns>
        System.Threading.Tasks.Task<HIPAAConfig> ComplianceHipaaGetAsync ();

        /// <summary>
        /// Get information about HIPAA compliance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (HIPAAConfig)</returns>
        System.Threading.Tasks.Task<ApiResponse<HIPAAConfig>> ComplianceHipaaGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update HIPAA compliance options
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>HIPAAConfig</returns>
        HIPAAConfig ComplianceHipaaPut (HIPAAConfig body = null);
  
        /// <summary>
        /// Update HIPAA compliance options
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of HIPAAConfig</returns>
        ApiResponse<HIPAAConfig> ComplianceHipaaPutWithHttpInfo (HIPAAConfig body = null);

        /// <summary>
        /// Update HIPAA compliance options
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of HIPAAConfig</returns>
        System.Threading.Tasks.Task<HIPAAConfig> ComplianceHipaaPutAsync (HIPAAConfig body = null);

        /// <summary>
        /// Update HIPAA compliance options
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (HIPAAConfig)</returns>
        System.Threading.Tasks.Task<ApiResponse<HIPAAConfig>> ComplianceHipaaPutAsyncWithHttpInfo (HIPAAConfig body = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ComplianceApi : IComplianceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ComplianceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ComplianceApi(Configuration configuration = null)
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
        /// Get information about HIPAA compliance 
        /// </summary>
        /// <returns>HIPAAConfig</returns>
        public HIPAAConfig ComplianceHipaaGet ()
        {
             ApiResponse<HIPAAConfig> response = ComplianceHipaaGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get information about HIPAA compliance 
        /// </summary>
        /// <returns>ApiResponse of HIPAAConfig</returns>
        public ApiResponse< HIPAAConfig > ComplianceHipaaGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/compliance/hipaa";
    
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
                throw new ApiException (statusCode, "Error calling ComplianceHipaaGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ComplianceHipaaGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<HIPAAConfig>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HIPAAConfig) Configuration.ApiClient.Deserialize(response, typeof(HIPAAConfig)));
            
        }
    
        /// <summary>
        /// Get information about HIPAA compliance 
        /// </summary>
        /// <returns>Task of HIPAAConfig</returns>
        public async System.Threading.Tasks.Task<HIPAAConfig> ComplianceHipaaGetAsync ()
        {
             ApiResponse<HIPAAConfig> response = await ComplianceHipaaGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get information about HIPAA compliance 
        /// </summary>
        /// <returns>Task of ApiResponse (HIPAAConfig)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HIPAAConfig>> ComplianceHipaaGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/compliance/hipaa";
    
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
                throw new ApiException (statusCode, "Error calling ComplianceHipaaGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ComplianceHipaaGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<HIPAAConfig>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HIPAAConfig) Configuration.ApiClient.Deserialize(response, typeof(HIPAAConfig)));
            
        }
        
        /// <summary>
        /// Update HIPAA compliance options 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>HIPAAConfig</returns>
        public HIPAAConfig ComplianceHipaaPut (HIPAAConfig body = null)
        {
             ApiResponse<HIPAAConfig> response = ComplianceHipaaPutWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Update HIPAA compliance options 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of HIPAAConfig</returns>
        public ApiResponse< HIPAAConfig > ComplianceHipaaPutWithHttpInfo (HIPAAConfig body = null)
        {
            
    
            var path_ = "/api/v1/compliance/hipaa";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ComplianceHipaaPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ComplianceHipaaPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<HIPAAConfig>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HIPAAConfig) Configuration.ApiClient.Deserialize(response, typeof(HIPAAConfig)));
            
        }
    
        /// <summary>
        /// Update HIPAA compliance options 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of HIPAAConfig</returns>
        public async System.Threading.Tasks.Task<HIPAAConfig> ComplianceHipaaPutAsync (HIPAAConfig body = null)
        {
             ApiResponse<HIPAAConfig> response = await ComplianceHipaaPutAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Update HIPAA compliance options 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (HIPAAConfig)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HIPAAConfig>> ComplianceHipaaPutAsyncWithHttpInfo (HIPAAConfig body = null)
        {
            
    
            var path_ = "/api/v1/compliance/hipaa";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ComplianceHipaaPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ComplianceHipaaPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<HIPAAConfig>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HIPAAConfig) Configuration.ApiClient.Deserialize(response, typeof(HIPAAConfig)));
            
        }
        
    }
    
}
