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
    public interface IGeolocationApi
    {
        
        /// <summary>
        /// Get a organization&#39;s GeolocationSettings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>GeolocationSettings</returns>
        GeolocationSettings GetSettings ();
  
        /// <summary>
        /// Get a organization&#39;s GeolocationSettings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of GeolocationSettings</returns>
        ApiResponse<GeolocationSettings> GetSettingsWithHttpInfo ();

        /// <summary>
        /// Get a organization&#39;s GeolocationSettings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of GeolocationSettings</returns>
        System.Threading.Tasks.Task<GeolocationSettings> GetSettingsAsync ();

        /// <summary>
        /// Get a organization&#39;s GeolocationSettings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (GeolocationSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<GeolocationSettings>> GetSettingsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Patch a organization&#39;s GeolocationSettings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>GeolocationSettings</returns>
        GeolocationSettings PatchSettings (GeolocationSettings body = null);
  
        /// <summary>
        /// Patch a organization&#39;s GeolocationSettings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of GeolocationSettings</returns>
        ApiResponse<GeolocationSettings> PatchSettingsWithHttpInfo (GeolocationSettings body = null);

        /// <summary>
        /// Patch a organization&#39;s GeolocationSettings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of GeolocationSettings</returns>
        System.Threading.Tasks.Task<GeolocationSettings> PatchSettingsAsync (GeolocationSettings body = null);

        /// <summary>
        /// Patch a organization&#39;s GeolocationSettings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (GeolocationSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<GeolocationSettings>> PatchSettingsAsyncWithHttpInfo (GeolocationSettings body = null);
        
        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Geolocation</returns>
        Geolocation GetUserIdGeolocationsClientId (string userId, string clientId);
  
        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>ApiResponse of Geolocation</returns>
        ApiResponse<Geolocation> GetUserIdGeolocationsClientIdWithHttpInfo (string userId, string clientId);

        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of Geolocation</returns>
        System.Threading.Tasks.Task<Geolocation> GetUserIdGeolocationsClientIdAsync (string userId, string clientId);

        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Geolocation>> GetUserIdGeolocationsClientIdAsyncWithHttpInfo (string userId, string clientId);
        
        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"></param>
        /// <returns>Geolocation</returns>
        Geolocation PatchUserIdGeolocationsClientId (string userId, string clientId, Geolocation body = null);
  
        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Geolocation</returns>
        ApiResponse<Geolocation> PatchUserIdGeolocationsClientIdWithHttpInfo (string userId, string clientId, Geolocation body = null);

        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"></param>
        /// <returns>Task of Geolocation</returns>
        System.Threading.Tasks.Task<Geolocation> PatchUserIdGeolocationsClientIdAsync (string userId, string clientId, Geolocation body = null);

        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Geolocation>> PatchUserIdGeolocationsClientIdAsyncWithHttpInfo (string userId, string clientId, Geolocation body = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GeolocationApi : IGeolocationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeolocationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GeolocationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GeolocationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GeolocationApi(Configuration configuration = null)
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
        /// Get a organization&#39;s GeolocationSettings 
        /// </summary>
        /// <returns>GeolocationSettings</returns>
        public GeolocationSettings GetSettings ()
        {
             ApiResponse<GeolocationSettings> response = GetSettingsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get a organization&#39;s GeolocationSettings 
        /// </summary>
        /// <returns>ApiResponse of GeolocationSettings</returns>
        public ApiResponse< GeolocationSettings > GetSettingsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/geolocations/settings";
    
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
                throw new ApiException (statusCode, "Error calling GetSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<GeolocationSettings>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GeolocationSettings) Configuration.ApiClient.Deserialize(response, typeof(GeolocationSettings)));
            
        }
    
        /// <summary>
        /// Get a organization&#39;s GeolocationSettings 
        /// </summary>
        /// <returns>Task of GeolocationSettings</returns>
        public async System.Threading.Tasks.Task<GeolocationSettings> GetSettingsAsync ()
        {
             ApiResponse<GeolocationSettings> response = await GetSettingsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get a organization&#39;s GeolocationSettings 
        /// </summary>
        /// <returns>Task of ApiResponse (GeolocationSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GeolocationSettings>> GetSettingsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/geolocations/settings";
    
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
                throw new ApiException (statusCode, "Error calling GetSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<GeolocationSettings>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GeolocationSettings) Configuration.ApiClient.Deserialize(response, typeof(GeolocationSettings)));
            
        }
        
        /// <summary>
        /// Patch a organization&#39;s GeolocationSettings 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>GeolocationSettings</returns>
        public GeolocationSettings PatchSettings (GeolocationSettings body = null)
        {
             ApiResponse<GeolocationSettings> response = PatchSettingsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Patch a organization&#39;s GeolocationSettings 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of GeolocationSettings</returns>
        public ApiResponse< GeolocationSettings > PatchSettingsWithHttpInfo (GeolocationSettings body = null)
        {
            
    
            var path_ = "/api/v1/geolocations/settings";
    
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
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<GeolocationSettings>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GeolocationSettings) Configuration.ApiClient.Deserialize(response, typeof(GeolocationSettings)));
            
        }
    
        /// <summary>
        /// Patch a organization&#39;s GeolocationSettings 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of GeolocationSettings</returns>
        public async System.Threading.Tasks.Task<GeolocationSettings> PatchSettingsAsync (GeolocationSettings body = null)
        {
             ApiResponse<GeolocationSettings> response = await PatchSettingsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Patch a organization&#39;s GeolocationSettings 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (GeolocationSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GeolocationSettings>> PatchSettingsAsyncWithHttpInfo (GeolocationSettings body = null)
        {
            
    
            var path_ = "/api/v1/geolocations/settings";
    
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
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchSettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<GeolocationSettings>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GeolocationSettings) Configuration.ApiClient.Deserialize(response, typeof(GeolocationSettings)));
            
        }
        
        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <param name="userId">user Id</param> 
        /// <param name="clientId">client Id</param> 
        /// <returns>Geolocation</returns>
        public Geolocation GetUserIdGeolocationsClientId (string userId, string clientId)
        {
             ApiResponse<Geolocation> response = GetUserIdGeolocationsClientIdWithHttpInfo(userId, clientId);
             return response.Data;
        }

        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <param name="userId">user Id</param> 
        /// <param name="clientId">client Id</param> 
        /// <returns>ApiResponse of Geolocation</returns>
        public ApiResponse< Geolocation > GetUserIdGeolocationsClientIdWithHttpInfo (string userId, string clientId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GeolocationApi->GetUserIdGeolocationsClientId");
            
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling GeolocationApi->GetUserIdGeolocationsClientId");
            
    
            var path_ = "/api/v1/users/{userId}/geolocations/{clientId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetUserIdGeolocationsClientId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdGeolocationsClientId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Geolocation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Geolocation) Configuration.ApiClient.Deserialize(response, typeof(Geolocation)));
            
        }
    
        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of Geolocation</returns>
        public async System.Threading.Tasks.Task<Geolocation> GetUserIdGeolocationsClientIdAsync (string userId, string clientId)
        {
             ApiResponse<Geolocation> response = await GetUserIdGeolocationsClientIdAsyncWithHttpInfo(userId, clientId);
             return response.Data;

        }

        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Geolocation>> GetUserIdGeolocationsClientIdAsyncWithHttpInfo (string userId, string clientId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserIdGeolocationsClientId");
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling GetUserIdGeolocationsClientId");
            
    
            var path_ = "/api/v1/users/{userId}/geolocations/{clientId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetUserIdGeolocationsClientId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdGeolocationsClientId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Geolocation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Geolocation) Configuration.ApiClient.Deserialize(response, typeof(Geolocation)));
            
        }
        
        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <param name="userId">user Id</param> 
        /// <param name="clientId">client Id</param> 
        /// <param name="body"></param> 
        /// <returns>Geolocation</returns>
        public Geolocation PatchUserIdGeolocationsClientId (string userId, string clientId, Geolocation body = null)
        {
             ApiResponse<Geolocation> response = PatchUserIdGeolocationsClientIdWithHttpInfo(userId, clientId, body);
             return response.Data;
        }

        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <param name="userId">user Id</param> 
        /// <param name="clientId">client Id</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Geolocation</returns>
        public ApiResponse< Geolocation > PatchUserIdGeolocationsClientIdWithHttpInfo (string userId, string clientId, Geolocation body = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GeolocationApi->PatchUserIdGeolocationsClientId");
            
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling GeolocationApi->PatchUserIdGeolocationsClientId");
            
    
            var path_ = "/api/v1/users/{userId}/geolocations/{clientId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
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
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchUserIdGeolocationsClientId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchUserIdGeolocationsClientId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Geolocation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Geolocation) Configuration.ApiClient.Deserialize(response, typeof(Geolocation)));
            
        }
    
        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"></param>
        /// <returns>Task of Geolocation</returns>
        public async System.Threading.Tasks.Task<Geolocation> PatchUserIdGeolocationsClientIdAsync (string userId, string clientId, Geolocation body = null)
        {
             ApiResponse<Geolocation> response = await PatchUserIdGeolocationsClientIdAsyncWithHttpInfo(userId, clientId, body);
             return response.Data;

        }

        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Geolocation>> PatchUserIdGeolocationsClientIdAsyncWithHttpInfo (string userId, string clientId, Geolocation body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling PatchUserIdGeolocationsClientId");
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling PatchUserIdGeolocationsClientId");
            
    
            var path_ = "/api/v1/users/{userId}/geolocations/{clientId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchUserIdGeolocationsClientId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchUserIdGeolocationsClientId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Geolocation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Geolocation) Configuration.ApiClient.Deserialize(response, typeof(Geolocation)));
            
        }
        
    }
    
}
