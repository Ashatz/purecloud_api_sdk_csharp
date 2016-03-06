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
        LocationEntityListing Get (string state = null, string name = null, int? pageSize = null, int? pageNumber = null);
  
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
        ApiResponse<LocationEntityListing> GetWithHttpInfo (string state = null, string name = null, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<LocationEntityListing> GetAsync (string state = null, string name = null, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<ApiResponse<LocationEntityListing>> GetAsyncWithHttpInfo (string state = null, string name = null, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get Location by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="locationId">Location ID</param>
        /// <returns>Location</returns>
        Location GetLocationId (string locationId);
  
        /// <summary>
        /// Get Location by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="locationId">Location ID</param>
        /// <returns>ApiResponse of Location</returns>
        ApiResponse<Location> GetLocationIdWithHttpInfo (string locationId);

        /// <summary>
        /// Get Location by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="locationId">Location ID</param>
        /// <returns>Task of Location</returns>
        System.Threading.Tasks.Task<Location> GetLocationIdAsync (string locationId);

        /// <summary>
        /// Get Location by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="locationId">Location ID</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        System.Threading.Tasks.Task<ApiResponse<Location>> GetLocationIdAsyncWithHttpInfo (string locationId);
        
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
        public LocationEntityListing Get (string state = null, string name = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<LocationEntityListing> response = GetWithHttpInfo(state, name, pageSize, pageNumber);
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
        public ApiResponse< LocationEntityListing > GetWithHttpInfo (string state = null, string name = null, int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/locations";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<LocationEntityListing> GetAsync (string state = null, string name = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<LocationEntityListing> response = await GetAsyncWithHttpInfo(state, name, pageSize, pageNumber);
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
        public async System.Threading.Tasks.Task<ApiResponse<LocationEntityListing>> GetAsyncWithHttpInfo (string state = null, string name = null, int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/locations";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LocationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LocationEntityListing)));
            
        }
        
        /// <summary>
        /// Get Location by ID. 
        /// </summary>
        /// <param name="locationId">Location ID</param> 
        /// <returns>Location</returns>
        public Location GetLocationId (string locationId)
        {
             ApiResponse<Location> response = GetLocationIdWithHttpInfo(locationId);
             return response.Data;
        }

        /// <summary>
        /// Get Location by ID. 
        /// </summary>
        /// <param name="locationId">Location ID</param> 
        /// <returns>ApiResponse of Location</returns>
        public ApiResponse< Location > GetLocationIdWithHttpInfo (string locationId)
        {
            
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationsApi->GetLocationId");
            
    
            var path_ = "/api/v1/locations/{locationId}";
    
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
            if (locationId != null) pathParams.Add("locationId", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetLocationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetLocationId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Location>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Location) Configuration.ApiClient.Deserialize(response, typeof(Location)));
            
        }
    
        /// <summary>
        /// Get Location by ID. 
        /// </summary>
        /// <param name="locationId">Location ID</param>
        /// <returns>Task of Location</returns>
        public async System.Threading.Tasks.Task<Location> GetLocationIdAsync (string locationId)
        {
             ApiResponse<Location> response = await GetLocationIdAsyncWithHttpInfo(locationId);
             return response.Data;

        }

        /// <summary>
        /// Get Location by ID. 
        /// </summary>
        /// <param name="locationId">Location ID</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Location>> GetLocationIdAsyncWithHttpInfo (string locationId)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null) throw new ApiException(400, "Missing required parameter 'locationId' when calling GetLocationId");
            
    
            var path_ = "/api/v1/locations/{locationId}";
    
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
            if (locationId != null) pathParams.Add("locationId", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetLocationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetLocationId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Location>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Location) Configuration.ApiClient.Deserialize(response, typeof(Location)));
            
        }
        
    }
    
}
