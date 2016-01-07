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
    public interface IDirectoryProxyApi
    {
        
        /// <summary>
        /// Autocomplete proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns></returns>
        void DirectoryApiV2AutocompleteGet (List<string> expand = null);
  
        /// <summary>
        /// Autocomplete proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DirectoryApiV2AutocompleteGetWithHttpInfo (List<string> expand = null);

        /// <summary>
        /// Autocomplete proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DirectoryApiV2AutocompleteGetAsync (List<string> expand = null);

        /// <summary>
        /// Autocomplete proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2AutocompleteGetAsyncWithHttpInfo (List<string> expand = null);
        
        /// <summary>
        /// Bulk get people
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ids">comma separated list of user ids</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns></returns>
        void DirectoryApiV2PeopleBulkIdsGet (string ids, List<string> expand = null);
  
        /// <summary>
        /// Bulk get people
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ids">comma separated list of user ids</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DirectoryApiV2PeopleBulkIdsGetWithHttpInfo (string ids, List<string> expand = null);

        /// <summary>
        /// Bulk get people
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ids">comma separated list of user ids</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DirectoryApiV2PeopleBulkIdsGetAsync (string ids, List<string> expand = null);

        /// <summary>
        /// Bulk get people
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ids">comma separated list of user ids</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2PeopleBulkIdsGetAsyncWithHttpInfo (string ids, List<string> expand = null);
        
        /// <summary>
        /// Get Person
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns></returns>
        void DirectoryApiV2PeopleIdGet (string id, List<string> expand = null);
  
        /// <summary>
        /// Get Person
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DirectoryApiV2PeopleIdGetWithHttpInfo (string id, List<string> expand = null);

        /// <summary>
        /// Get Person
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DirectoryApiV2PeopleIdGetAsync (string id, List<string> expand = null);

        /// <summary>
        /// Get Person
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2PeopleIdGetAsyncWithHttpInfo (string id, List<string> expand = null);
        
        /// <summary>
        /// Get Person Adjacents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns></returns>
        void DirectoryApiV2PeopleIdAdjacentsGet (string id, List<string> expand = null);
  
        /// <summary>
        /// Get Person Adjacents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DirectoryApiV2PeopleIdAdjacentsGetWithHttpInfo (string id, List<string> expand = null);

        /// <summary>
        /// Get Person Adjacents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DirectoryApiV2PeopleIdAdjacentsGetAsync (string id, List<string> expand = null);

        /// <summary>
        /// Get Person Adjacents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2PeopleIdAdjacentsGetAsyncWithHttpInfo (string id, List<string> expand = null);
        
        /// <summary>
        /// Get Person Direct Reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns></returns>
        void DirectoryApiV2PeopleIdDirectreportsGet (string id, List<string> expand = null);
  
        /// <summary>
        /// Get Person Direct Reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DirectoryApiV2PeopleIdDirectreportsGetWithHttpInfo (string id, List<string> expand = null);

        /// <summary>
        /// Get Person Direct Reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DirectoryApiV2PeopleIdDirectreportsGetAsync (string id, List<string> expand = null);

        /// <summary>
        /// Get Person Direct Reports
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2PeopleIdDirectreportsGetAsyncWithHttpInfo (string id, List<string> expand = null);
        
        /// <summary>
        /// Get Person Favorites
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns></returns>
        void DirectoryApiV2PeopleIdFavoritesGet (string id, List<string> expand = null);
  
        /// <summary>
        /// Get Person Favorites
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DirectoryApiV2PeopleIdFavoritesGetWithHttpInfo (string id, List<string> expand = null);

        /// <summary>
        /// Get Person Favorites
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DirectoryApiV2PeopleIdFavoritesGetAsync (string id, List<string> expand = null);

        /// <summary>
        /// Get Person Favorites
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2PeopleIdFavoritesGetAsyncWithHttpInfo (string id, List<string> expand = null);
        
        /// <summary>
        /// Get Person Recents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns></returns>
        void DirectoryApiV2PeopleIdRecentsGet (string id, List<string> expand = null);
  
        /// <summary>
        /// Get Person Recents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DirectoryApiV2PeopleIdRecentsGetWithHttpInfo (string id, List<string> expand = null);

        /// <summary>
        /// Get Person Recents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DirectoryApiV2PeopleIdRecentsGetAsync (string id, List<string> expand = null);

        /// <summary>
        /// Get Person Recents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2PeopleIdRecentsGetAsyncWithHttpInfo (string id, List<string> expand = null);
        
        /// <summary>
        /// Get Superiors
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns></returns>
        void DirectoryApiV2PeopleIdSuperiorsGet (string id, List<string> expand = null);
  
        /// <summary>
        /// Get Superiors
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DirectoryApiV2PeopleIdSuperiorsGetWithHttpInfo (string id, List<string> expand = null);

        /// <summary>
        /// Get Superiors
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DirectoryApiV2PeopleIdSuperiorsGetAsync (string id, List<string> expand = null);

        /// <summary>
        /// Get Superiors
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2PeopleIdSuperiorsGetAsyncWithHttpInfo (string id, List<string> expand = null);
        
        /// <summary>
        /// Search proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns></returns>
        void DirectoryApiV2SearchGet (List<string> expand = null);
  
        /// <summary>
        /// Search proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DirectoryApiV2SearchGetWithHttpInfo (List<string> expand = null);

        /// <summary>
        /// Search proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DirectoryApiV2SearchGetAsync (List<string> expand = null);

        /// <summary>
        /// Search proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2SearchGetAsyncWithHttpInfo (List<string> expand = null);
        
        /// <summary>
        /// Search proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns></returns>
        void DirectoryApiV2SearchDirectoryGet (List<string> expand = null);
  
        /// <summary>
        /// Search proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DirectoryApiV2SearchDirectoryGetWithHttpInfo (List<string> expand = null);

        /// <summary>
        /// Search proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DirectoryApiV2SearchDirectoryGetAsync (List<string> expand = null);

        /// <summary>
        /// Search proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2SearchDirectoryGetAsyncWithHttpInfo (List<string> expand = null);
        
        /// <summary>
        /// Search proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns></returns>
        void DirectoryApiV2SearchPeopleGet (List<string> expand = null);
  
        /// <summary>
        /// Search proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DirectoryApiV2SearchPeopleGetWithHttpInfo (List<string> expand = null);

        /// <summary>
        /// Search proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DirectoryApiV2SearchPeopleGetAsync (List<string> expand = null);

        /// <summary>
        /// Search proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2SearchPeopleGetAsyncWithHttpInfo (List<string> expand = null);
        
        /// <summary>
        /// Suggest proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns></returns>
        void DirectoryApiV2SuggestGet (List<string> expand = null);
  
        /// <summary>
        /// Suggest proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DirectoryApiV2SuggestGetWithHttpInfo (List<string> expand = null);

        /// <summary>
        /// Suggest proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DirectoryApiV2SuggestGetAsync (List<string> expand = null);

        /// <summary>
        /// Suggest proxy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2SuggestGetAsyncWithHttpInfo (List<string> expand = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DirectoryProxyApi : IDirectoryProxyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryProxyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DirectoryProxyApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryProxyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DirectoryProxyApi(Configuration configuration = null)
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
        /// Autocomplete proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns></returns>
        public void DirectoryApiV2AutocompleteGet (List<string> expand = null)
        {
             DirectoryApiV2AutocompleteGetWithHttpInfo(expand);
        }

        /// <summary>
        /// Autocomplete proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DirectoryApiV2AutocompleteGetWithHttpInfo (List<string> expand = null)
        {
            
    
            var path_ = "/directory/api/v2/autocomplete";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2AutocompleteGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2AutocompleteGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Autocomplete proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DirectoryApiV2AutocompleteGetAsync (List<string> expand = null)
        {
             await DirectoryApiV2AutocompleteGetAsyncWithHttpInfo(expand);

        }

        /// <summary>
        /// Autocomplete proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2AutocompleteGetAsyncWithHttpInfo (List<string> expand = null)
        {
            
    
            var path_ = "/directory/api/v2/autocomplete";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2AutocompleteGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2AutocompleteGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Bulk get people 
        /// </summary>
        /// <param name="ids">comma separated list of user ids</param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns></returns>
        public void DirectoryApiV2PeopleBulkIdsGet (string ids, List<string> expand = null)
        {
             DirectoryApiV2PeopleBulkIdsGetWithHttpInfo(ids, expand);
        }

        /// <summary>
        /// Bulk get people 
        /// </summary>
        /// <param name="ids">comma separated list of user ids</param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DirectoryApiV2PeopleBulkIdsGetWithHttpInfo (string ids, List<string> expand = null)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling DirectoryApiV2PeopleBulkIdsGet");
            
    
            var path_ = "/directory/api/v2/people/bulk/{ids}";
    
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
            if (ids != null) pathParams.Add("ids", Configuration.ApiClient.ParameterToString(ids)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleBulkIdsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleBulkIdsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Bulk get people 
        /// </summary>
        /// <param name="ids">comma separated list of user ids</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DirectoryApiV2PeopleBulkIdsGetAsync (string ids, List<string> expand = null)
        {
             await DirectoryApiV2PeopleBulkIdsGetAsyncWithHttpInfo(ids, expand);

        }

        /// <summary>
        /// Bulk get people 
        /// </summary>
        /// <param name="ids">comma separated list of user ids</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2PeopleBulkIdsGetAsyncWithHttpInfo (string ids, List<string> expand = null)
        {
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling DirectoryApiV2PeopleBulkIdsGet");
            
    
            var path_ = "/directory/api/v2/people/bulk/{ids}";
    
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
            if (ids != null) pathParams.Add("ids", Configuration.ApiClient.ParameterToString(ids)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleBulkIdsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleBulkIdsGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get Person 
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns></returns>
        public void DirectoryApiV2PeopleIdGet (string id, List<string> expand = null)
        {
             DirectoryApiV2PeopleIdGetWithHttpInfo(id, expand);
        }

        /// <summary>
        /// Get Person 
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DirectoryApiV2PeopleIdGetWithHttpInfo (string id, List<string> expand = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DirectoryApiV2PeopleIdGet");
            
    
            var path_ = "/directory/api/v2/people/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Get Person 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DirectoryApiV2PeopleIdGetAsync (string id, List<string> expand = null)
        {
             await DirectoryApiV2PeopleIdGetAsyncWithHttpInfo(id, expand);

        }

        /// <summary>
        /// Get Person 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2PeopleIdGetAsyncWithHttpInfo (string id, List<string> expand = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DirectoryApiV2PeopleIdGet");
            
    
            var path_ = "/directory/api/v2/people/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get Person Adjacents 
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns></returns>
        public void DirectoryApiV2PeopleIdAdjacentsGet (string id, List<string> expand = null)
        {
             DirectoryApiV2PeopleIdAdjacentsGetWithHttpInfo(id, expand);
        }

        /// <summary>
        /// Get Person Adjacents 
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DirectoryApiV2PeopleIdAdjacentsGetWithHttpInfo (string id, List<string> expand = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DirectoryApiV2PeopleIdAdjacentsGet");
            
    
            var path_ = "/directory/api/v2/people/{id}/adjacents";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdAdjacentsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdAdjacentsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Get Person Adjacents 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DirectoryApiV2PeopleIdAdjacentsGetAsync (string id, List<string> expand = null)
        {
             await DirectoryApiV2PeopleIdAdjacentsGetAsyncWithHttpInfo(id, expand);

        }

        /// <summary>
        /// Get Person Adjacents 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2PeopleIdAdjacentsGetAsyncWithHttpInfo (string id, List<string> expand = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DirectoryApiV2PeopleIdAdjacentsGet");
            
    
            var path_ = "/directory/api/v2/people/{id}/adjacents";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdAdjacentsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdAdjacentsGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get Person Direct Reports 
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns></returns>
        public void DirectoryApiV2PeopleIdDirectreportsGet (string id, List<string> expand = null)
        {
             DirectoryApiV2PeopleIdDirectreportsGetWithHttpInfo(id, expand);
        }

        /// <summary>
        /// Get Person Direct Reports 
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DirectoryApiV2PeopleIdDirectreportsGetWithHttpInfo (string id, List<string> expand = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DirectoryApiV2PeopleIdDirectreportsGet");
            
    
            var path_ = "/directory/api/v2/people/{id}/directreports";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdDirectreportsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdDirectreportsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Get Person Direct Reports 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DirectoryApiV2PeopleIdDirectreportsGetAsync (string id, List<string> expand = null)
        {
             await DirectoryApiV2PeopleIdDirectreportsGetAsyncWithHttpInfo(id, expand);

        }

        /// <summary>
        /// Get Person Direct Reports 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2PeopleIdDirectreportsGetAsyncWithHttpInfo (string id, List<string> expand = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DirectoryApiV2PeopleIdDirectreportsGet");
            
    
            var path_ = "/directory/api/v2/people/{id}/directreports";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdDirectreportsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdDirectreportsGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get Person Favorites 
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns></returns>
        public void DirectoryApiV2PeopleIdFavoritesGet (string id, List<string> expand = null)
        {
             DirectoryApiV2PeopleIdFavoritesGetWithHttpInfo(id, expand);
        }

        /// <summary>
        /// Get Person Favorites 
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DirectoryApiV2PeopleIdFavoritesGetWithHttpInfo (string id, List<string> expand = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DirectoryApiV2PeopleIdFavoritesGet");
            
    
            var path_ = "/directory/api/v2/people/{id}/favorites";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdFavoritesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdFavoritesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Get Person Favorites 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DirectoryApiV2PeopleIdFavoritesGetAsync (string id, List<string> expand = null)
        {
             await DirectoryApiV2PeopleIdFavoritesGetAsyncWithHttpInfo(id, expand);

        }

        /// <summary>
        /// Get Person Favorites 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2PeopleIdFavoritesGetAsyncWithHttpInfo (string id, List<string> expand = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DirectoryApiV2PeopleIdFavoritesGet");
            
    
            var path_ = "/directory/api/v2/people/{id}/favorites";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdFavoritesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdFavoritesGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get Person Recents 
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns></returns>
        public void DirectoryApiV2PeopleIdRecentsGet (string id, List<string> expand = null)
        {
             DirectoryApiV2PeopleIdRecentsGetWithHttpInfo(id, expand);
        }

        /// <summary>
        /// Get Person Recents 
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DirectoryApiV2PeopleIdRecentsGetWithHttpInfo (string id, List<string> expand = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DirectoryApiV2PeopleIdRecentsGet");
            
    
            var path_ = "/directory/api/v2/people/{id}/recents";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdRecentsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdRecentsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Get Person Recents 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DirectoryApiV2PeopleIdRecentsGetAsync (string id, List<string> expand = null)
        {
             await DirectoryApiV2PeopleIdRecentsGetAsyncWithHttpInfo(id, expand);

        }

        /// <summary>
        /// Get Person Recents 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2PeopleIdRecentsGetAsyncWithHttpInfo (string id, List<string> expand = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DirectoryApiV2PeopleIdRecentsGet");
            
    
            var path_ = "/directory/api/v2/people/{id}/recents";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdRecentsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdRecentsGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get Superiors 
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns></returns>
        public void DirectoryApiV2PeopleIdSuperiorsGet (string id, List<string> expand = null)
        {
             DirectoryApiV2PeopleIdSuperiorsGetWithHttpInfo(id, expand);
        }

        /// <summary>
        /// Get Superiors 
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DirectoryApiV2PeopleIdSuperiorsGetWithHttpInfo (string id, List<string> expand = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DirectoryApiV2PeopleIdSuperiorsGet");
            
    
            var path_ = "/directory/api/v2/people/{id}/superiors";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdSuperiorsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdSuperiorsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Get Superiors 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DirectoryApiV2PeopleIdSuperiorsGetAsync (string id, List<string> expand = null)
        {
             await DirectoryApiV2PeopleIdSuperiorsGetAsyncWithHttpInfo(id, expand);

        }

        /// <summary>
        /// Get Superiors 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2PeopleIdSuperiorsGetAsyncWithHttpInfo (string id, List<string> expand = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DirectoryApiV2PeopleIdSuperiorsGet");
            
    
            var path_ = "/directory/api/v2/people/{id}/superiors";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdSuperiorsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2PeopleIdSuperiorsGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns></returns>
        public void DirectoryApiV2SearchGet (List<string> expand = null)
        {
             DirectoryApiV2SearchGetWithHttpInfo(expand);
        }

        /// <summary>
        /// Search proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DirectoryApiV2SearchGetWithHttpInfo (List<string> expand = null)
        {
            
    
            var path_ = "/directory/api/v2/search";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SearchGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SearchGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Search proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DirectoryApiV2SearchGetAsync (List<string> expand = null)
        {
             await DirectoryApiV2SearchGetAsyncWithHttpInfo(expand);

        }

        /// <summary>
        /// Search proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2SearchGetAsyncWithHttpInfo (List<string> expand = null)
        {
            
    
            var path_ = "/directory/api/v2/search";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SearchGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SearchGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns></returns>
        public void DirectoryApiV2SearchDirectoryGet (List<string> expand = null)
        {
             DirectoryApiV2SearchDirectoryGetWithHttpInfo(expand);
        }

        /// <summary>
        /// Search proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DirectoryApiV2SearchDirectoryGetWithHttpInfo (List<string> expand = null)
        {
            
    
            var path_ = "/directory/api/v2/search/directory";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SearchDirectoryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SearchDirectoryGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Search proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DirectoryApiV2SearchDirectoryGetAsync (List<string> expand = null)
        {
             await DirectoryApiV2SearchDirectoryGetAsyncWithHttpInfo(expand);

        }

        /// <summary>
        /// Search proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2SearchDirectoryGetAsyncWithHttpInfo (List<string> expand = null)
        {
            
    
            var path_ = "/directory/api/v2/search/directory";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SearchDirectoryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SearchDirectoryGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns></returns>
        public void DirectoryApiV2SearchPeopleGet (List<string> expand = null)
        {
             DirectoryApiV2SearchPeopleGetWithHttpInfo(expand);
        }

        /// <summary>
        /// Search proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DirectoryApiV2SearchPeopleGetWithHttpInfo (List<string> expand = null)
        {
            
    
            var path_ = "/directory/api/v2/search/people";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SearchPeopleGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SearchPeopleGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Search proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DirectoryApiV2SearchPeopleGetAsync (List<string> expand = null)
        {
             await DirectoryApiV2SearchPeopleGetAsyncWithHttpInfo(expand);

        }

        /// <summary>
        /// Search proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2SearchPeopleGetAsyncWithHttpInfo (List<string> expand = null)
        {
            
    
            var path_ = "/directory/api/v2/search/people";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SearchPeopleGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SearchPeopleGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Suggest proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns></returns>
        public void DirectoryApiV2SuggestGet (List<string> expand = null)
        {
             DirectoryApiV2SuggestGetWithHttpInfo(expand);
        }

        /// <summary>
        /// Suggest proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DirectoryApiV2SuggestGetWithHttpInfo (List<string> expand = null)
        {
            
    
            var path_ = "/directory/api/v2/suggest";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SuggestGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SuggestGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Suggest proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DirectoryApiV2SuggestGetAsync (List<string> expand = null)
        {
             await DirectoryApiV2SuggestGetAsyncWithHttpInfo(expand);

        }

        /// <summary>
        /// Suggest proxy 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DirectoryApiV2SuggestGetAsyncWithHttpInfo (List<string> expand = null)
        {
            
    
            var path_ = "/directory/api/v2/suggest";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SuggestGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DirectoryApiV2SuggestGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
