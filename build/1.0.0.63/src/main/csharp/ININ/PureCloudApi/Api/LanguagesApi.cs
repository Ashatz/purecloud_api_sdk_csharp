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
    public interface ILanguagesApi
    {
        
        /// <summary>
        /// Get the list of supported languages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>LanguageEntityListing</returns>
        LanguageEntityListing LanguagesGet (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get the list of supported languages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of LanguageEntityListing</returns>
        ApiResponse<LanguageEntityListing> LanguagesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of supported languages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of LanguageEntityListing</returns>
        System.Threading.Tasks.Task<LanguageEntityListing> LanguagesGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of supported languages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (LanguageEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LanguageEntityListing>> LanguagesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="languageId">Language ID</param>
        /// <returns>Language</returns>
        Language LanguagesLanguageidGet (string languageId);
  
        /// <summary>
        /// Get language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="languageId">Language ID</param>
        /// <returns>ApiResponse of Language</returns>
        ApiResponse<Language> LanguagesLanguageidGetWithHttpInfo (string languageId);

        /// <summary>
        /// Get language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of Language</returns>
        System.Threading.Tasks.Task<Language> LanguagesLanguageidGetAsync (string languageId);

        /// <summary>
        /// Get language
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of ApiResponse (Language)</returns>
        System.Threading.Tasks.Task<ApiResponse<Language>> LanguagesLanguageidGetAsyncWithHttpInfo (string languageId);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LanguagesApi : ILanguagesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LanguagesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LanguagesApi(Configuration configuration = null)
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
        /// Get the list of supported languages. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>LanguageEntityListing</returns>
        public LanguageEntityListing LanguagesGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<LanguageEntityListing> response = LanguagesGetWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get the list of supported languages. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of LanguageEntityListing</returns>
        public ApiResponse< LanguageEntityListing > LanguagesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/languages";
    
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
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling LanguagesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LanguagesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LanguageEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LanguageEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LanguageEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of supported languages. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of LanguageEntityListing</returns>
        public async System.Threading.Tasks.Task<LanguageEntityListing> LanguagesGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<LanguageEntityListing> response = await LanguagesGetAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get the list of supported languages. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (LanguageEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LanguageEntityListing>> LanguagesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/languages";
    
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
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling LanguagesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LanguagesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LanguageEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LanguageEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LanguageEntityListing)));
            
        }
        
        /// <summary>
        /// Get language 
        /// </summary>
        /// <param name="languageId">Language ID</param> 
        /// <returns>Language</returns>
        public Language LanguagesLanguageidGet (string languageId)
        {
             ApiResponse<Language> response = LanguagesLanguageidGetWithHttpInfo(languageId);
             return response.Data;
        }

        /// <summary>
        /// Get language 
        /// </summary>
        /// <param name="languageId">Language ID</param> 
        /// <returns>ApiResponse of Language</returns>
        public ApiResponse< Language > LanguagesLanguageidGetWithHttpInfo (string languageId)
        {
            
            // verify the required parameter 'languageId' is set
            if (languageId == null) throw new ApiException(400, "Missing required parameter 'languageId' when calling LanguagesLanguageidGet");
            
    
            var path_ = "/api/v1/languages/{languageId}";
    
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
            if (languageId != null) pathParams.Add("languageId", Configuration.ApiClient.ParameterToString(languageId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling LanguagesLanguageidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LanguagesLanguageidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Language>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Language) Configuration.ApiClient.Deserialize(response, typeof(Language)));
            
        }
    
        /// <summary>
        /// Get language 
        /// </summary>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of Language</returns>
        public async System.Threading.Tasks.Task<Language> LanguagesLanguageidGetAsync (string languageId)
        {
             ApiResponse<Language> response = await LanguagesLanguageidGetAsyncWithHttpInfo(languageId);
             return response.Data;

        }

        /// <summary>
        /// Get language 
        /// </summary>
        /// <param name="languageId">Language ID</param>
        /// <returns>Task of ApiResponse (Language)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Language>> LanguagesLanguageidGetAsyncWithHttpInfo (string languageId)
        {
            // verify the required parameter 'languageId' is set
            if (languageId == null) throw new ApiException(400, "Missing required parameter 'languageId' when calling LanguagesLanguageidGet");
            
    
            var path_ = "/api/v1/languages/{languageId}";
    
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
            if (languageId != null) pathParams.Add("languageId", Configuration.ApiClient.ParameterToString(languageId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling LanguagesLanguageidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LanguagesLanguageidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Language>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Language) Configuration.ApiClient.Deserialize(response, typeof(Language)));
            
        }
        
    }
    
}
