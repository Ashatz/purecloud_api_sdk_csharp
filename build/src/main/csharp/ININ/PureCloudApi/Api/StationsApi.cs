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
    public interface IStationsApi
    {
        
        /// <summary>
        /// Get the list of available stations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <returns>StationEntityListing</returns>
        StationEntityListing StationsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);
  
        /// <summary>
        /// Get the list of available stations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <returns>ApiResponse of StationEntityListing</returns>
        ApiResponse<StationEntityListing> StationsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);

        /// <summary>
        /// Get the list of available stations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <returns>Task of StationEntityListing</returns>
        System.Threading.Tasks.Task<StationEntityListing> StationsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);

        /// <summary>
        /// Get the list of available stations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <returns>Task of ApiResponse (StationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<StationEntityListing>> StationsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);
        
        /// <summary>
        /// Get station.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Station ID</param>
        /// <returns>UserStationResource</returns>
        UserStationResource StationsIdGet (string id);
  
        /// <summary>
        /// Get station.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Station ID</param>
        /// <returns>ApiResponse of UserStationResource</returns>
        ApiResponse<UserStationResource> StationsIdGetWithHttpInfo (string id);

        /// <summary>
        /// Get station.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Station ID</param>
        /// <returns>Task of UserStationResource</returns>
        System.Threading.Tasks.Task<UserStationResource> StationsIdGetAsync (string id);

        /// <summary>
        /// Get station.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Station ID</param>
        /// <returns>Task of ApiResponse (UserStationResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserStationResource>> StationsIdGetAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Unassigns the user assigned to this station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Station ID</param>
        /// <returns>string</returns>
        string StationsIdAssociateduserDelete (string id);
  
        /// <summary>
        /// Unassigns the user assigned to this station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Station ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> StationsIdAssociateduserDeleteWithHttpInfo (string id);

        /// <summary>
        /// Unassigns the user assigned to this station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Station ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> StationsIdAssociateduserDeleteAsync (string id);

        /// <summary>
        /// Unassigns the user assigned to this station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Station ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> StationsIdAssociateduserDeleteAsyncWithHttpInfo (string id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StationsApi : IStationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StationsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StationsApi(Configuration configuration = null)
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
        /// Get the list of available stations. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="name">Name</param> 
        /// <returns>StationEntityListing</returns>
        public StationEntityListing StationsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {
             ApiResponse<StationEntityListing> response = StationsGetWithHttpInfo(pageSize, pageNumber, sortBy, name);
             return response.Data;
        }

        /// <summary>
        /// Get the list of available stations. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="name">Name</param> 
        /// <returns>ApiResponse of StationEntityListing</returns>
        public ApiResponse< StationEntityListing > StationsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {
            
    
            var path_ = "/api/v1/stations";
    
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
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling StationsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling StationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<StationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(StationEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of available stations. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <returns>Task of StationEntityListing</returns>
        public async System.Threading.Tasks.Task<StationEntityListing> StationsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {
             ApiResponse<StationEntityListing> response = await StationsGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, name);
             return response.Data;

        }

        /// <summary>
        /// Get the list of available stations. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <returns>Task of ApiResponse (StationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StationEntityListing>> StationsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {
            
    
            var path_ = "/api/v1/stations";
    
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
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling StationsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling StationsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<StationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(StationEntityListing)));
            
        }
        
        /// <summary>
        /// Get station. 
        /// </summary>
        /// <param name="id">Station ID</param> 
        /// <returns>UserStationResource</returns>
        public UserStationResource StationsIdGet (string id)
        {
             ApiResponse<UserStationResource> response = StationsIdGetWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Get station. 
        /// </summary>
        /// <param name="id">Station ID</param> 
        /// <returns>ApiResponse of UserStationResource</returns>
        public ApiResponse< UserStationResource > StationsIdGetWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StationsIdGet");
            
    
            var path_ = "/api/v1/stations/{id}";
    
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
                throw new ApiException (statusCode, "Error calling StationsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling StationsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserStationResource>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserStationResource) Configuration.ApiClient.Deserialize(response, typeof(UserStationResource)));
            
        }
    
        /// <summary>
        /// Get station. 
        /// </summary>
        /// <param name="id">Station ID</param>
        /// <returns>Task of UserStationResource</returns>
        public async System.Threading.Tasks.Task<UserStationResource> StationsIdGetAsync (string id)
        {
             ApiResponse<UserStationResource> response = await StationsIdGetAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Get station. 
        /// </summary>
        /// <param name="id">Station ID</param>
        /// <returns>Task of ApiResponse (UserStationResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserStationResource>> StationsIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StationsIdGet");
            
    
            var path_ = "/api/v1/stations/{id}";
    
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
                throw new ApiException (statusCode, "Error calling StationsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling StationsIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserStationResource>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserStationResource) Configuration.ApiClient.Deserialize(response, typeof(UserStationResource)));
            
        }
        
        /// <summary>
        /// Unassigns the user assigned to this station 
        /// </summary>
        /// <param name="id">Station ID</param> 
        /// <returns>string</returns>
        public string StationsIdAssociateduserDelete (string id)
        {
             ApiResponse<string> response = StationsIdAssociateduserDeleteWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Unassigns the user assigned to this station 
        /// </summary>
        /// <param name="id">Station ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > StationsIdAssociateduserDeleteWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StationsIdAssociateduserDelete");
            
    
            var path_ = "/api/v1/stations/{id}/associateduser";
    
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
                throw new ApiException (statusCode, "Error calling StationsIdAssociateduserDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling StationsIdAssociateduserDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Unassigns the user assigned to this station 
        /// </summary>
        /// <param name="id">Station ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> StationsIdAssociateduserDeleteAsync (string id)
        {
             ApiResponse<string> response = await StationsIdAssociateduserDeleteAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Unassigns the user assigned to this station 
        /// </summary>
        /// <param name="id">Station ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> StationsIdAssociateduserDeleteAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StationsIdAssociateduserDelete");
            
    
            var path_ = "/api/v1/stations/{id}/associateduser";
    
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
                throw new ApiException (statusCode, "Error calling StationsIdAssociateduserDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling StationsIdAssociateduserDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}
