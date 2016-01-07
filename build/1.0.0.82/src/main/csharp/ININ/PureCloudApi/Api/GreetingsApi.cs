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
        DomainEntityListing GreetingsGet (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Gets an Organization&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> GreetingsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets an Organization&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> GreetingsGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets an Organization&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> GreetingsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Create a Greeting for an Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The Greeting to create</param>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList GreetingsPost (Greeting body);
  
        /// <summary>
        /// Create a Greeting for an Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The Greeting to create</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> GreetingsPostWithHttpInfo (Greeting body);

        /// <summary>
        /// Create a Greeting for an Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> GreetingsPostAsync (Greeting body);

        /// <summary>
        /// Create a Greeting for an Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GreetingsPostAsyncWithHttpInfo (Greeting body);
        
        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList GreetingsDefaultsGet ();
  
        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> GreetingsDefaultsGetWithHttpInfo ();

        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> GreetingsDefaultsGetAsync ();

        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GreetingsDefaultsGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList GreetingsDefaultsPut (DefaultGreetingList body);
  
        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> GreetingsDefaultsPutWithHttpInfo (DefaultGreetingList body);

        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> GreetingsDefaultsPutAsync (DefaultGreetingList body);

        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GreetingsDefaultsPutAsyncWithHttpInfo (DefaultGreetingList body);
        
        /// <summary>
        /// Get a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Greeting</returns>
        Greeting GreetingsGreetingidGet (string greetingId);
  
        /// <summary>
        /// Get a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>ApiResponse of Greeting</returns>
        ApiResponse<Greeting> GreetingsGreetingidGetWithHttpInfo (string greetingId);

        /// <summary>
        /// Get a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of Greeting</returns>
        System.Threading.Tasks.Task<Greeting> GreetingsGreetingidGetAsync (string greetingId);

        /// <summary>
        /// Get a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Greeting>> GreetingsGreetingidGetAsyncWithHttpInfo (string greetingId);
        
        /// <summary>
        /// Updates the Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Greeting</returns>
        Greeting GreetingsGreetingidPut (string greetingId, Greeting body);
  
        /// <summary>
        /// Updates the Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>ApiResponse of Greeting</returns>
        ApiResponse<Greeting> GreetingsGreetingidPutWithHttpInfo (string greetingId, Greeting body);

        /// <summary>
        /// Updates the Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Task of Greeting</returns>
        System.Threading.Tasks.Task<Greeting> GreetingsGreetingidPutAsync (string greetingId, Greeting body);

        /// <summary>
        /// Updates the Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Greeting>> GreetingsGreetingidPutAsyncWithHttpInfo (string greetingId, Greeting body);
        
        /// <summary>
        /// Deletes a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Greeting</returns>
        Greeting GreetingsGreetingidDelete (string greetingId);
  
        /// <summary>
        /// Deletes a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>ApiResponse of Greeting</returns>
        ApiResponse<Greeting> GreetingsGreetingidDeleteWithHttpInfo (string greetingId);

        /// <summary>
        /// Deletes a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of Greeting</returns>
        System.Threading.Tasks.Task<Greeting> GreetingsGreetingidDeleteAsync (string greetingId);

        /// <summary>
        /// Deletes a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Greeting>> GreetingsGreetingidDeleteAsyncWithHttpInfo (string greetingId);
        
        /// <summary>
        /// Get media playback URI for this greeting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.)</param>
        /// <returns>GreetingMediaInfo</returns>
        GreetingMediaInfo GreetingsGreetingidMediaGet (string greetingId, string formatId = null);
  
        /// <summary>
        /// Get media playback URI for this greeting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.)</param>
        /// <returns>ApiResponse of GreetingMediaInfo</returns>
        ApiResponse<GreetingMediaInfo> GreetingsGreetingidMediaGetWithHttpInfo (string greetingId, string formatId = null);

        /// <summary>
        /// Get media playback URI for this greeting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.)</param>
        /// <returns>Task of GreetingMediaInfo</returns>
        System.Threading.Tasks.Task<GreetingMediaInfo> GreetingsGreetingidMediaGetAsync (string greetingId, string formatId = null);

        /// <summary>
        /// Get media playback URI for this greeting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.)</param>
        /// <returns>Task of ApiResponse (GreetingMediaInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<GreetingMediaInfo>> GreetingsGreetingidMediaGetAsyncWithHttpInfo (string greetingId, string formatId = null);
        
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
        DomainEntityListing UsersUseridGreetingsGet (string userId, int? pageSize = null, int? pageNumber = null);
  
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
        ApiResponse<DomainEntityListing> UsersUseridGreetingsGetWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<DomainEntityListing> UsersUseridGreetingsGetAsync (string userId, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> UsersUseridGreetingsGetAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Creates a Greeting for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Greeting</returns>
        Greeting UsersUseridGreetingsPost (string userId, Greeting body);
  
        /// <summary>
        /// Creates a Greeting for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>ApiResponse of Greeting</returns>
        ApiResponse<Greeting> UsersUseridGreetingsPostWithHttpInfo (string userId, Greeting body);

        /// <summary>
        /// Creates a Greeting for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of Greeting</returns>
        System.Threading.Tasks.Task<Greeting> UsersUseridGreetingsPostAsync (string userId, Greeting body);

        /// <summary>
        /// Creates a Greeting for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Greeting>> UsersUseridGreetingsPostAsyncWithHttpInfo (string userId, Greeting body);
        
        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList UsersUseridGreetingsDefaultsGet (string userId);
  
        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> UsersUseridGreetingsDefaultsGetWithHttpInfo (string userId);

        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> UsersUseridGreetingsDefaultsGetAsync (string userId);

        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> UsersUseridGreetingsDefaultsGetAsyncWithHttpInfo (string userId);
        
        /// <summary>
        /// Updates the DefaultGreetingList of the specified User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList UsersUseridGreetingsDefaultsPut (string userId, DefaultGreetingList body);
  
        /// <summary>
        /// Updates the DefaultGreetingList of the specified User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> UsersUseridGreetingsDefaultsPutWithHttpInfo (string userId, DefaultGreetingList body);

        /// <summary>
        /// Updates the DefaultGreetingList of the specified User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> UsersUseridGreetingsDefaultsPutAsync (string userId, DefaultGreetingList body);

        /// <summary>
        /// Updates the DefaultGreetingList of the specified User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> UsersUseridGreetingsDefaultsPutAsyncWithHttpInfo (string userId, DefaultGreetingList body);
        
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
        public DomainEntityListing GreetingsGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> response = GreetingsGetWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Gets an Organization&#39;s Greetings 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > GreetingsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (statusCode, "Error calling GreetingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DomainEntityListing> GreetingsGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> response = await GreetingsGetAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Gets an Organization&#39;s Greetings 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> GreetingsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (statusCode, "Error calling GreetingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
        
        /// <summary>
        /// Create a Greeting for an Organization 
        /// </summary>
        /// <param name="body">The Greeting to create</param> 
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList GreetingsPost (Greeting body)
        {
             ApiResponse<DefaultGreetingList> response = GreetingsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a Greeting for an Organization 
        /// </summary>
        /// <param name="body">The Greeting to create</param> 
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > GreetingsPostWithHttpInfo (Greeting body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsPost");
            
    
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
                throw new ApiException (statusCode, "Error calling GreetingsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
    
        /// <summary>
        /// Create a Greeting for an Organization 
        /// </summary>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> GreetingsPostAsync (Greeting body)
        {
             ApiResponse<DefaultGreetingList> response = await GreetingsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a Greeting for an Organization 
        /// </summary>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GreetingsPostAsyncWithHttpInfo (Greeting body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsPost");
            
    
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
                throw new ApiException (statusCode, "Error calling GreetingsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
        
        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList GreetingsDefaultsGet ()
        {
             ApiResponse<DefaultGreetingList> response = GreetingsDefaultsGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > GreetingsDefaultsGetWithHttpInfo ()
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
                throw new ApiException (statusCode, "Error calling GreetingsDefaultsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsDefaultsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
    
        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> GreetingsDefaultsGetAsync ()
        {
             ApiResponse<DefaultGreetingList> response = await GreetingsDefaultsGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GreetingsDefaultsGetAsyncWithHttpInfo ()
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
                throw new ApiException (statusCode, "Error calling GreetingsDefaultsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsDefaultsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
        
        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <param name="body">The updated defaultGreetingList</param> 
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList GreetingsDefaultsPut (DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> response = GreetingsDefaultsPutWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <param name="body">The updated defaultGreetingList</param> 
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > GreetingsDefaultsPutWithHttpInfo (DefaultGreetingList body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsDefaultsPut");
            
    
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
                throw new ApiException (statusCode, "Error calling GreetingsDefaultsPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsDefaultsPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
    
        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> GreetingsDefaultsPutAsync (DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> response = await GreetingsDefaultsPutAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GreetingsDefaultsPutAsyncWithHttpInfo (DefaultGreetingList body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsDefaultsPut");
            
    
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
                throw new ApiException (statusCode, "Error calling GreetingsDefaultsPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsDefaultsPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
        
        /// <summary>
        /// Get a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param> 
        /// <returns>Greeting</returns>
        public Greeting GreetingsGreetingidGet (string greetingId)
        {
             ApiResponse<Greeting> response = GreetingsGreetingidGetWithHttpInfo(greetingId);
             return response.Data;
        }

        /// <summary>
        /// Get a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param> 
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > GreetingsGreetingidGetWithHttpInfo (string greetingId)
        {
            
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsGreetingidGet");
            
    
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
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Greeting>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(response, typeof(Greeting)));
            
        }
    
        /// <summary>
        /// Get a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of Greeting</returns>
        public async System.Threading.Tasks.Task<Greeting> GreetingsGreetingidGetAsync (string greetingId)
        {
             ApiResponse<Greeting> response = await GreetingsGreetingidGetAsyncWithHttpInfo(greetingId);
             return response.Data;

        }

        /// <summary>
        /// Get a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> GreetingsGreetingidGetAsyncWithHttpInfo (string greetingId)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsGreetingidGet");
            
    
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
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public Greeting GreetingsGreetingidPut (string greetingId, Greeting body)
        {
             ApiResponse<Greeting> response = GreetingsGreetingidPutWithHttpInfo(greetingId, body);
             return response.Data;
        }

        /// <summary>
        /// Updates the Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param> 
        /// <param name="body">The updated Greeting</param> 
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > GreetingsGreetingidPutWithHttpInfo (string greetingId, Greeting body)
        {
            
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsGreetingidPut");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsGreetingidPut");
            
    
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
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidPut: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Greeting> GreetingsGreetingidPutAsync (string greetingId, Greeting body)
        {
             ApiResponse<Greeting> response = await GreetingsGreetingidPutAsyncWithHttpInfo(greetingId, body);
             return response.Data;

        }

        /// <summary>
        /// Updates the Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> GreetingsGreetingidPutAsyncWithHttpInfo (string greetingId, Greeting body)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsGreetingidPut");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsGreetingidPut");
            
    
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
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Greeting>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(response, typeof(Greeting)));
            
        }
        
        /// <summary>
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param> 
        /// <returns>Greeting</returns>
        public Greeting GreetingsGreetingidDelete (string greetingId)
        {
             ApiResponse<Greeting> response = GreetingsGreetingidDeleteWithHttpInfo(greetingId);
             return response.Data;
        }

        /// <summary>
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param> 
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > GreetingsGreetingidDeleteWithHttpInfo (string greetingId)
        {
            
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsGreetingidDelete");
            
    
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
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Greeting>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(response, typeof(Greeting)));
            
        }
    
        /// <summary>
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of Greeting</returns>
        public async System.Threading.Tasks.Task<Greeting> GreetingsGreetingidDeleteAsync (string greetingId)
        {
             ApiResponse<Greeting> response = await GreetingsGreetingidDeleteAsyncWithHttpInfo(greetingId);
             return response.Data;

        }

        /// <summary>
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> GreetingsGreetingidDeleteAsyncWithHttpInfo (string greetingId)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsGreetingidDelete");
            
    
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
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidDelete: " + response.ErrorMessage, response.ErrorMessage);

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
        public GreetingMediaInfo GreetingsGreetingidMediaGet (string greetingId, string formatId = null)
        {
             ApiResponse<GreetingMediaInfo> response = GreetingsGreetingidMediaGetWithHttpInfo(greetingId, formatId);
             return response.Data;
        }

        /// <summary>
        /// Get media playback URI for this greeting 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param> 
        /// <param name="formatId">The desired format (WAV, etc.)</param> 
        /// <returns>ApiResponse of GreetingMediaInfo</returns>
        public ApiResponse< GreetingMediaInfo > GreetingsGreetingidMediaGetWithHttpInfo (string greetingId, string formatId = null)
        {
            
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsGreetingidMediaGet");
            
    
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
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidMediaGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidMediaGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<GreetingMediaInfo> GreetingsGreetingidMediaGetAsync (string greetingId, string formatId = null)
        {
             ApiResponse<GreetingMediaInfo> response = await GreetingsGreetingidMediaGetAsyncWithHttpInfo(greetingId, formatId);
             return response.Data;

        }

        /// <summary>
        /// Get media playback URI for this greeting 
        /// </summary>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.)</param>
        /// <returns>Task of ApiResponse (GreetingMediaInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GreetingMediaInfo>> GreetingsGreetingidMediaGetAsyncWithHttpInfo (string greetingId, string formatId = null)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null) throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsGreetingidMediaGet");
            
    
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
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidMediaGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GreetingsGreetingidMediaGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public DomainEntityListing UsersUseridGreetingsGet (string userId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> response = UsersUseridGreetingsGetWithHttpInfo(userId, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a list of the User&#39;s Greetings 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > UsersUseridGreetingsGetWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridGreetingsGet");
            
    
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
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DomainEntityListing> UsersUseridGreetingsGetAsync (string userId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> response = await UsersUseridGreetingsGetAsyncWithHttpInfo(userId, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a list of the User&#39;s Greetings 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> UsersUseridGreetingsGetAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridGreetingsGet");
            
    
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
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public Greeting UsersUseridGreetingsPost (string userId, Greeting body)
        {
             ApiResponse<Greeting> response = UsersUseridGreetingsPostWithHttpInfo(userId, body);
             return response.Data;
        }

        /// <summary>
        /// Creates a Greeting for a User 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">The Greeting to create</param> 
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > UsersUseridGreetingsPostWithHttpInfo (string userId, Greeting body)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridGreetingsPost");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UsersUseridGreetingsPost");
            
    
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
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsPost: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Greeting> UsersUseridGreetingsPostAsync (string userId, Greeting body)
        {
             ApiResponse<Greeting> response = await UsersUseridGreetingsPostAsyncWithHttpInfo(userId, body);
             return response.Data;

        }

        /// <summary>
        /// Creates a Greeting for a User 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> UsersUseridGreetingsPostAsyncWithHttpInfo (string userId, Greeting body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridGreetingsPost");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UsersUseridGreetingsPost");
            
    
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
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Greeting>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(response, typeof(Greeting)));
            
        }
        
        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList UsersUseridGreetingsDefaultsGet (string userId)
        {
             ApiResponse<DefaultGreetingList> response = UsersUseridGreetingsDefaultsGetWithHttpInfo(userId);
             return response.Data;
        }

        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > UsersUseridGreetingsDefaultsGetWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridGreetingsDefaultsGet");
            
    
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
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsDefaultsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsDefaultsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
    
        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> UsersUseridGreetingsDefaultsGetAsync (string userId)
        {
             ApiResponse<DefaultGreetingList> response = await UsersUseridGreetingsDefaultsGetAsyncWithHttpInfo(userId);
             return response.Data;

        }

        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> UsersUseridGreetingsDefaultsGetAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridGreetingsDefaultsGet");
            
    
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
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsDefaultsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsDefaultsGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public DefaultGreetingList UsersUseridGreetingsDefaultsPut (string userId, DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> response = UsersUseridGreetingsDefaultsPutWithHttpInfo(userId, body);
             return response.Data;
        }

        /// <summary>
        /// Updates the DefaultGreetingList of the specified User 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">The updated defaultGreetingList</param> 
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > UsersUseridGreetingsDefaultsPutWithHttpInfo (string userId, DefaultGreetingList body)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridGreetingsDefaultsPut");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UsersUseridGreetingsDefaultsPut");
            
    
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
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsDefaultsPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsDefaultsPut: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DefaultGreetingList> UsersUseridGreetingsDefaultsPutAsync (string userId, DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> response = await UsersUseridGreetingsDefaultsPutAsyncWithHttpInfo(userId, body);
             return response.Data;

        }

        /// <summary>
        /// Updates the DefaultGreetingList of the specified User 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> UsersUseridGreetingsDefaultsPutAsyncWithHttpInfo (string userId, DefaultGreetingList body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UsersUseridGreetingsDefaultsPut");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UsersUseridGreetingsDefaultsPut");
            
    
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
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsDefaultsPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UsersUseridGreetingsDefaultsPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(response, typeof(DefaultGreetingList)));
            
        }
        
    }
    
}
