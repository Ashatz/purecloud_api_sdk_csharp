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
    public interface IGreetingsApi
    {
        
        /// <summary>
        /// Gets an Organization&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing Get (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Gets an Organization&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> GetWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets an Organization&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> GetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets an Organization&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> GetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Create a Greeting for an Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The Greeting to create</param>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList Create (Greeting body);
  
        /// <summary>
        /// Create a Greeting for an Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The Greeting to create</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> CreateWithHttpInfo (Greeting body);

        /// <summary>
        /// Create a Greeting for an Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> CreateAsync (Greeting body);

        /// <summary>
        /// Create a Greeting for an Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> CreateAsyncWithHttpInfo (Greeting body);
        
        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList GetDefaults ();
  
        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> GetDefaultsWithHttpInfo ();

        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> GetDefaultsAsync ();

        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GetDefaultsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList UpdateDefaults (DefaultGreetingList body);
  
        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> UpdateDefaultsWithHttpInfo (DefaultGreetingList body);

        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> UpdateDefaultsAsync (DefaultGreetingList body);

        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> UpdateDefaultsAsyncWithHttpInfo (DefaultGreetingList body);
        
        /// <summary>
        /// Get a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Greeting</returns>
        Greeting GetGreeting (string greetingId);
  
        /// <summary>
        /// Get a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>ApiResponse of Greeting</returns>
        ApiResponse<Greeting> GetGreetingWithHttpInfo (string greetingId);

        /// <summary>
        /// Get a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of Greeting</returns>
        System.Threading.Tasks.Task<Greeting> GetGreetingAsync (string greetingId);

        /// <summary>
        /// Get a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Greeting>> GetGreetingAsyncWithHttpInfo (string greetingId);
        
        /// <summary>
        /// Updates the Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Greeting</returns>
        Greeting UpdateGreeting (string greetingId, Greeting body);
  
        /// <summary>
        /// Updates the Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>ApiResponse of Greeting</returns>
        ApiResponse<Greeting> UpdateGreetingWithHttpInfo (string greetingId, Greeting body);

        /// <summary>
        /// Updates the Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Task of Greeting</returns>
        System.Threading.Tasks.Task<Greeting> UpdateGreetingAsync (string greetingId, Greeting body);

        /// <summary>
        /// Updates the Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Greeting>> UpdateGreetingAsyncWithHttpInfo (string greetingId, Greeting body);
        
        /// <summary>
        /// Deletes a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Greeting</returns>
        Greeting DeleteGreeting (string greetingId);
  
        /// <summary>
        /// Deletes a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>ApiResponse of Greeting</returns>
        ApiResponse<Greeting> DeleteGreetingWithHttpInfo (string greetingId);

        /// <summary>
        /// Deletes a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of Greeting</returns>
        System.Threading.Tasks.Task<Greeting> DeleteGreetingAsync (string greetingId);

        /// <summary>
        /// Deletes a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Greeting>> DeleteGreetingAsyncWithHttpInfo (string greetingId);
        
        /// <summary>
        /// Get media playback URI for this greeting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.)</param>
        /// <returns>GreetingMediaInfo</returns>
        GreetingMediaInfo GetGreetingMedia (string greetingId, string formatId = null);
  
        /// <summary>
        /// Get media playback URI for this greeting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.)</param>
        /// <returns>ApiResponse of GreetingMediaInfo</returns>
        ApiResponse<GreetingMediaInfo> GetGreetingMediaWithHttpInfo (string greetingId, string formatId = null);

        /// <summary>
        /// Get media playback URI for this greeting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.)</param>
        /// <returns>Task of GreetingMediaInfo</returns>
        System.Threading.Tasks.Task<GreetingMediaInfo> GetGreetingMediaAsync (string greetingId, string formatId = null);

        /// <summary>
        /// Get media playback URI for this greeting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.)</param>
        /// <returns>Task of ApiResponse (GreetingMediaInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<GreetingMediaInfo>> GetGreetingMediaAsyncWithHttpInfo (string greetingId, string formatId = null);
        
        /// <summary>
        /// Get a list of the User&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing GetUserGreetings (string userId, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get a list of the User&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> GetUserGreetingsWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of the User&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> GetUserGreetingsAsync (string userId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of the User&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> GetUserGreetingsAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Creates a Greeting for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Greeting</returns>
        Greeting CreateUserGreetings (string userId, Greeting body);
  
        /// <summary>
        /// Creates a Greeting for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>ApiResponse of Greeting</returns>
        ApiResponse<Greeting> CreateUserGreetingsWithHttpInfo (string userId, Greeting body);

        /// <summary>
        /// Creates a Greeting for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of Greeting</returns>
        System.Threading.Tasks.Task<Greeting> CreateUserGreetingsAsync (string userId, Greeting body);

        /// <summary>
        /// Creates a Greeting for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Greeting>> CreateUserGreetingsAsyncWithHttpInfo (string userId, Greeting body);
        
        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList GetUserGreetingsDefaults (string userId);
  
        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> GetUserGreetingsDefaultsWithHttpInfo (string userId);

        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> GetUserGreetingsDefaultsAsync (string userId);

        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GetUserGreetingsDefaultsAsyncWithHttpInfo (string userId);
        
        /// <summary>
        /// Updates the DefaultGreetingList of the specified User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList UpdateUserGreetingsDefaults (string userId, DefaultGreetingList body);
  
        /// <summary>
        /// Updates the DefaultGreetingList of the specified User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> UpdateUserGreetingsDefaultsWithHttpInfo (string userId, DefaultGreetingList body);

        /// <summary>
        /// Updates the DefaultGreetingList of the specified User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> UpdateUserGreetingsDefaultsAsync (string userId, DefaultGreetingList body);

        /// <summary>
        /// Updates the DefaultGreetingList of the specified User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> UpdateUserGreetingsDefaultsAsyncWithHttpInfo (string userId, DefaultGreetingList body);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GreetingsApi : IGreetingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GreetingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GreetingsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GreetingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GreetingsApi(Configuration configuration = null)
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
        /// Gets an Organization&#39;s Greetings 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing Get (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> response = GetWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Gets an Organization&#39;s Greetings 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > GetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/greetings";
    
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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
    
        /// <summary>
        /// Gets an Organization&#39;s Greetings 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> GetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> response = await GetAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Gets an Organization&#39;s Greetings 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> GetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/greetings";
    
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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
        
        /// <summary>
        /// Create a Greeting for an Organization 
        /// </summary>
        /// <param name="body">The Greeting to create</param> 
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList Create (Greeting body)
        {
             ApiResponse<DefaultGreetingList> response = CreateWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a Greeting for an Organization 
        /// </summary>
        /// <param name="body">The Greeting to create</param> 
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > CreateWithHttpInfo (Greeting body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Create");
            
    
            var path_ = "/api/v1/greetings";
    
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
    
            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
    
        /// <summary>
        /// Create a Greeting for an Organization 
        /// </summary>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> CreateAsync (Greeting body)
        {
             ApiResponse<DefaultGreetingList> response = await CreateAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a Greeting for an Organization 
        /// </summary>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> CreateAsyncWithHttpInfo (Greeting body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Create");
            
    
            var path_ = "/api/v1/greetings";
    
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

            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
        
        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList GetDefaults ()
        {
             ApiResponse<DefaultGreetingList> response = GetDefaultsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > GetDefaultsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/greetings/defaults";
    
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
                throw new ApiException (statusCode, "Error calling GetDefaults: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDefaults: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
    
        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> GetDefaultsAsync ()
        {
             ApiResponse<DefaultGreetingList> response = await GetDefaultsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GetDefaultsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/greetings/defaults";
    
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
                throw new ApiException (statusCode, "Error calling GetDefaults: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDefaults: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
        
        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <param name="body">The updated defaultGreetingList</param> 
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList UpdateDefaults (DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> response = UpdateDefaultsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <param name="body">The updated defaultGreetingList</param> 
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > UpdateDefaultsWithHttpInfo (DefaultGreetingList body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateDefaults");
            
    
            var path_ = "/api/v1/greetings/defaults";
    
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
                throw new ApiException (statusCode, "Error calling UpdateDefaults: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateDefaults: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
    
        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> UpdateDefaultsAsync (DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> response = await UpdateDefaultsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> UpdateDefaultsAsyncWithHttpInfo (DefaultGreetingList body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateDefaults");
            
    
            var path_ = "/api/v1/greetings/defaults";
    
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
                throw new ApiException (statusCode, "Error calling UpdateDefaults: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateDefaults: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
        
        /// <summary>
        /// Get a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param> 
        /// <returns>Greeting</returns>
        public Greeting GetGreeting (string greetingId)
        {
             ApiResponse<Greeting> response = GetGreetingWithHttpInfo(greetingId);
             return response.Data;
        }

        /// <summary>
        /// Get a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param> 
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > GetGreetingWithHttpInfo (string greetingId)
        {
            
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling GetGreeting");
            
    
            var path_ = "/api/v1/greetings/{greetingId}";
    
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
            if (greetingId != null) pathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetGreeting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetGreeting: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Greeting>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(response, typeof(Greeting)));
            
        }
    
        /// <summary>
        /// Get a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of Greeting</returns>
        public async System.Threading.Tasks.Task<Greeting> GetGreetingAsync (string greetingId)
        {
             ApiResponse<Greeting> response = await GetGreetingAsyncWithHttpInfo(greetingId);
             return response.Data;

        }

        /// <summary>
        /// Get a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> GetGreetingAsyncWithHttpInfo (string greetingId)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling GetGreeting");
            
    
            var path_ = "/api/v1/greetings/{greetingId}";
    
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
            if (greetingId != null) pathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetGreeting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetGreeting: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Greeting>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(response, typeof(Greeting)));
            
        }
        
        /// <summary>
        /// Updates the Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param> 
        /// <param name="body">The updated Greeting</param> 
        /// <returns>Greeting</returns>
        public Greeting UpdateGreeting (string greetingId, Greeting body)
        {
             ApiResponse<Greeting> response = UpdateGreetingWithHttpInfo(greetingId, body);
             return response.Data;
        }

        /// <summary>
        /// Updates the Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param> 
        /// <param name="body">The updated Greeting</param> 
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > UpdateGreetingWithHttpInfo (string greetingId, Greeting body)
        {
            
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling UpdateGreeting");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateGreeting");
            
    
            var path_ = "/api/v1/greetings/{greetingId}";
    
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
            if (greetingId != null) pathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateGreeting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateGreeting: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Greeting>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(response, typeof(Greeting)));
            
        }
    
        /// <summary>
        /// Updates the Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Task of Greeting</returns>
        public async System.Threading.Tasks.Task<Greeting> UpdateGreetingAsync (string greetingId, Greeting body)
        {
             ApiResponse<Greeting> response = await UpdateGreetingAsyncWithHttpInfo(greetingId, body);
             return response.Data;

        }

        /// <summary>
        /// Updates the Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> UpdateGreetingAsyncWithHttpInfo (string greetingId, Greeting body)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling UpdateGreeting");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateGreeting");
            
    
            var path_ = "/api/v1/greetings/{greetingId}";
    
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
            if (greetingId != null) pathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateGreeting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateGreeting: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Greeting>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(response, typeof(Greeting)));
            
        }
        
        /// <summary>
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param> 
        /// <returns>Greeting</returns>
        public Greeting DeleteGreeting (string greetingId)
        {
             ApiResponse<Greeting> response = DeleteGreetingWithHttpInfo(greetingId);
             return response.Data;
        }

        /// <summary>
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param> 
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > DeleteGreetingWithHttpInfo (string greetingId)
        {
            
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling DeleteGreeting");
            
    
            var path_ = "/api/v1/greetings/{greetingId}";
    
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
            if (greetingId != null) pathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteGreeting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteGreeting: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Greeting>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(response, typeof(Greeting)));
            
        }
    
        /// <summary>
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of Greeting</returns>
        public async System.Threading.Tasks.Task<Greeting> DeleteGreetingAsync (string greetingId)
        {
             ApiResponse<Greeting> response = await DeleteGreetingAsyncWithHttpInfo(greetingId);
             return response.Data;

        }

        /// <summary>
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> DeleteGreetingAsyncWithHttpInfo (string greetingId)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling DeleteGreeting");
            
    
            var path_ = "/api/v1/greetings/{greetingId}";
    
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
            if (greetingId != null) pathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteGreeting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteGreeting: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Greeting>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(response, typeof(Greeting)));
            
        }
        
        /// <summary>
        /// Get media playback URI for this greeting 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param> 
        /// <param name="formatId">The desired format (WAV, etc.)</param> 
        /// <returns>GreetingMediaInfo</returns>
        public GreetingMediaInfo GetGreetingMedia (string greetingId, string formatId = null)
        {
             ApiResponse<GreetingMediaInfo> response = GetGreetingMediaWithHttpInfo(greetingId, formatId);
             return response.Data;
        }

        /// <summary>
        /// Get media playback URI for this greeting 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param> 
        /// <param name="formatId">The desired format (WAV, etc.)</param> 
        /// <returns>ApiResponse of GreetingMediaInfo</returns>
        public ApiResponse< GreetingMediaInfo > GetGreetingMediaWithHttpInfo (string greetingId, string formatId = null)
        {
            
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling GetGreetingMedia");
            
    
            var path_ = "/api/v1/greetings/{greetingId}/media";
    
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
            if (greetingId != null) pathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
            
            if (formatId != null) queryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetGreetingMedia: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetGreetingMedia: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<GreetingMediaInfo>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GreetingMediaInfo) Configuration.ApiClient.Deserialize(response, typeof(GreetingMediaInfo)));
            
        }
    
        /// <summary>
        /// Get media playback URI for this greeting 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.)</param>
        /// <returns>Task of GreetingMediaInfo</returns>
        public async System.Threading.Tasks.Task<GreetingMediaInfo> GetGreetingMediaAsync (string greetingId, string formatId = null)
        {
             ApiResponse<GreetingMediaInfo> response = await GetGreetingMediaAsyncWithHttpInfo(greetingId, formatId);
             return response.Data;

        }

        /// <summary>
        /// Get media playback URI for this greeting 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.)</param>
        /// <returns>Task of ApiResponse (GreetingMediaInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GreetingMediaInfo>> GetGreetingMediaAsyncWithHttpInfo (string greetingId, string formatId = null)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling GetGreetingMedia");
            
    
            var path_ = "/api/v1/greetings/{greetingId}/media";
    
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
            if (greetingId != null) pathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
            
            if (formatId != null) queryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetGreetingMedia: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetGreetingMedia: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<GreetingMediaInfo>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GreetingMediaInfo) Configuration.ApiClient.Deserialize(response, typeof(GreetingMediaInfo)));
            
        }
        
        /// <summary>
        /// Get a list of the User&#39;s Greetings 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing GetUserGreetings (string userId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> response = GetUserGreetingsWithHttpInfo(userId, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a list of the User&#39;s Greetings 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > GetUserGreetingsWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserGreetings");
            
    
            var path_ = "/api/v1/users/{userId}/greetings";
    
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
                throw new ApiException (statusCode, "Error calling GetUserGreetings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserGreetings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of the User&#39;s Greetings 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> GetUserGreetingsAsync (string userId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> response = await GetUserGreetingsAsyncWithHttpInfo(userId, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a list of the User&#39;s Greetings 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> GetUserGreetingsAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserGreetings");
            
    
            var path_ = "/api/v1/users/{userId}/greetings";
    
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
                throw new ApiException (statusCode, "Error calling GetUserGreetings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserGreetings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
        
        /// <summary>
        /// Creates a Greeting for a User 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">The Greeting to create</param> 
        /// <returns>Greeting</returns>
        public Greeting CreateUserGreetings (string userId, Greeting body)
        {
             ApiResponse<Greeting> response = CreateUserGreetingsWithHttpInfo(userId, body);
             return response.Data;
        }

        /// <summary>
        /// Creates a Greeting for a User 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">The Greeting to create</param> 
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > CreateUserGreetingsWithHttpInfo (string userId, Greeting body)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling CreateUserGreetings");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateUserGreetings");
            
    
            var path_ = "/api/v1/users/{userId}/greetings";
    
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
                throw new ApiException (statusCode, "Error calling CreateUserGreetings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateUserGreetings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Greeting>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(response, typeof(Greeting)));
            
        }
    
        /// <summary>
        /// Creates a Greeting for a User 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of Greeting</returns>
        public async System.Threading.Tasks.Task<Greeting> CreateUserGreetingsAsync (string userId, Greeting body)
        {
             ApiResponse<Greeting> response = await CreateUserGreetingsAsyncWithHttpInfo(userId, body);
             return response.Data;

        }

        /// <summary>
        /// Creates a Greeting for a User 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> CreateUserGreetingsAsyncWithHttpInfo (string userId, Greeting body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling CreateUserGreetings");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateUserGreetings");
            
    
            var path_ = "/api/v1/users/{userId}/greetings";
    
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
                throw new ApiException (statusCode, "Error calling CreateUserGreetings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateUserGreetings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Greeting>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(response, typeof(Greeting)));
            
        }
        
        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList GetUserGreetingsDefaults (string userId)
        {
             ApiResponse<DefaultGreetingList> response = GetUserGreetingsDefaultsWithHttpInfo(userId);
             return response.Data;
        }

        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > GetUserGreetingsDefaultsWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserGreetingsDefaults");
            
    
            var path_ = "/api/v1/users/{userId}/greetings/defaults";
    
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
                throw new ApiException (statusCode, "Error calling GetUserGreetingsDefaults: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserGreetingsDefaults: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
    
        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> GetUserGreetingsDefaultsAsync (string userId)
        {
             ApiResponse<DefaultGreetingList> response = await GetUserGreetingsDefaultsAsyncWithHttpInfo(userId);
             return response.Data;

        }

        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GetUserGreetingsDefaultsAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserGreetingsDefaults");
            
    
            var path_ = "/api/v1/users/{userId}/greetings/defaults";
    
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
                throw new ApiException (statusCode, "Error calling GetUserGreetingsDefaults: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserGreetingsDefaults: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
        
        /// <summary>
        /// Updates the DefaultGreetingList of the specified User 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">The updated defaultGreetingList</param> 
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList UpdateUserGreetingsDefaults (string userId, DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> response = UpdateUserGreetingsDefaultsWithHttpInfo(userId, body);
             return response.Data;
        }

        /// <summary>
        /// Updates the DefaultGreetingList of the specified User 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">The updated defaultGreetingList</param> 
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > UpdateUserGreetingsDefaultsWithHttpInfo (string userId, DefaultGreetingList body)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateUserGreetingsDefaults");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateUserGreetingsDefaults");
            
    
            var path_ = "/api/v1/users/{userId}/greetings/defaults";
    
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
                throw new ApiException (statusCode, "Error calling UpdateUserGreetingsDefaults: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateUserGreetingsDefaults: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
    
        /// <summary>
        /// Updates the DefaultGreetingList of the specified User 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> UpdateUserGreetingsDefaultsAsync (string userId, DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> response = await UpdateUserGreetingsDefaultsAsyncWithHttpInfo(userId, body);
             return response.Data;

        }

        /// <summary>
        /// Updates the DefaultGreetingList of the specified User 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> UpdateUserGreetingsDefaultsAsyncWithHttpInfo (string userId, DefaultGreetingList body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateUserGreetingsDefaults");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateUserGreetingsDefaults");
            
    
            var path_ = "/api/v1/users/{userId}/greetings/defaults";
    
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
                throw new ApiException (statusCode, "Error calling UpdateUserGreetingsDefaults: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateUserGreetingsDefaults: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
        
    }
    
}
