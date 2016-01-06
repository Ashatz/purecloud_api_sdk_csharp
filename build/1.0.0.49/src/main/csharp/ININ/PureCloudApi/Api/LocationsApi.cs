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
    public interface ILocationsApi
    {
        
        /// <summary>
        /// Get the list of locations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="state">Location state</param>
        /// <param name="name">Location name</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>LocationEntityListing</returns>
        LocationEntityListing LocationsGet (string state = null, string name = null, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get the list of locations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="state">Location state</param>
        /// <param name="name">Location name</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of LocationEntityListing</returns>
        ApiResponse<LocationEntityListing> LocationsGetWithHttpInfo (string state = null, string name = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of locations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="state">Location state</param>
        /// <param name="name">Location name</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of LocationEntityListing</returns>
        System.Threading.Tasks.Task<LocationEntityListing> LocationsGetAsync (string state = null, string name = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of locations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="state">Location state</param>
        /// <param name="name">Location name</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (LocationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocationEntityListing>> LocationsGetAsyncWithHttpInfo (string state = null, string name = null, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get Location by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="locationId">Location ID</param>
        /// <returns>Location</returns>
        Location LocationsLocationidGet (string locationId);
  
        /// <summary>
        /// Get Location by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="locationId">Location ID</param>
        /// <returns>ApiResponse of Location</returns>
        ApiResponse<Location> LocationsLocationidGetWithHttpInfo (string locationId);

        /// <summary>
        /// Get Location by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="locationId">Location ID</param>
        /// <returns>Task of Location</returns>
        System.Threading.Tasks.Task<Location> LocationsLocationidGetAsync (string locationId);

        /// <summary>
        /// Get Location by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="locationId">Location ID</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        System.Threading.Tasks.Task<ApiResponse<Location>> LocationsLocationidGetAsyncWithHttpInfo (string locationId);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LocationsApi : ILocationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocationsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LocationsApi(Configuration configuration = null)
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
        /// Get the list of locations. 
        /// </summary>
        /// <param name="state">Location state</param> 
        /// <param name="name">Location name</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>LocationEntityListing</returns>
        public LocationEntityListing LocationsGet (string state = null, string name = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<LocationEntityListing> response = LocationsGetWithHttpInfo(state, name, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get the list of locations. 
        /// </summary>
        /// <param name="state">Location state</param> 
        /// <param name="name">Location name</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of LocationEntityListing</returns>
        public ApiResponse< LocationEntityListing > LocationsGetWithHttpInfo (string state = null, string name = null, int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/locations";
    
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
            
            if (state != null) queryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (statusCode, "Error calling LocationsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LocationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LocationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LocationEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of locations. 
        /// </summary>
        /// <param name="state">Location state</param>
        /// <param name="name">Location name</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of LocationEntityListing</returns>
        public async System.Threading.Tasks.Task<LocationEntityListing> LocationsGetAsync (string state = null, string name = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<LocationEntityListing> response = await LocationsGetAsyncWithHttpInfo(state, name, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get the list of locations. 
        /// </summary>
        /// <param name="state">Location state</param>
        /// <param name="name">Location name</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (LocationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocationEntityListing>> LocationsGetAsyncWithHttpInfo (string state = null, string name = null, int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/locations";
    
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
            
            if (state != null) queryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (statusCode, "Error calling LocationsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LocationsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LocationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LocationEntityListing)));
            
        }
        
        /// <summary>
        /// Get Location by ID. 
        /// </summary>
        /// <param name="locationId">Location ID</param> 
        /// <returns>Location</returns>
        public Location LocationsLocationidGet (string locationId)
        {
             ApiResponse<Location> response = LocationsLocationidGetWithHttpInfo(locationId);
             return response.Data;
        }

        /// <summary>
        /// Get Location by ID. 
        /// </summary>
        /// <param name="locationId">Location ID</param> 
        /// <returns>ApiResponse of Location</returns>
        public ApiResponse< Location > LocationsLocationidGetWithHttpInfo (string locationId)
        {
            
            // verify the required parameter 'locationId' is set
            if (locationId == null) throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationsLocationidGet");
            
    
            var path_ = "/api/v1/locations/{locationId}";
    
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
            if (locationId != null) pathParams.Add("locationId", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling LocationsLocationidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LocationsLocationidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Location>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Location) Configuration.ApiClient.Deserialize(response, typeof(Location)));
            
        }
    
        /// <summary>
        /// Get Location by ID. 
        /// </summary>
        /// <param name="locationId">Location ID</param>
        /// <returns>Task of Location</returns>
        public async System.Threading.Tasks.Task<Location> LocationsLocationidGetAsync (string locationId)
        {
             ApiResponse<Location> response = await LocationsLocationidGetAsyncWithHttpInfo(locationId);
             return response.Data;

        }

        /// <summary>
        /// Get Location by ID. 
        /// </summary>
        /// <param name="locationId">Location ID</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Location>> LocationsLocationidGetAsyncWithHttpInfo (string locationId)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null) throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationsLocationidGet");
            
    
            var path_ = "/api/v1/locations/{locationId}";
    
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
            if (locationId != null) pathParams.Add("locationId", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling LocationsLocationidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LocationsLocationidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Location>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Location) Configuration.ApiClient.Deserialize(response, typeof(Location)));
            
        }
        
    }
    
}
