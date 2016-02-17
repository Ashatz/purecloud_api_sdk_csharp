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
    public interface IUtilitiesApi
    {
        
        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ParsedCertificate</returns>
        ParsedCertificate CreateDetails (Certificate body = null);
  
        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ParsedCertificate</returns>
        ApiResponse<ParsedCertificate> CreateDetailsWithHttpInfo (Certificate body = null);

        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ParsedCertificate</returns>
        System.Threading.Tasks.Task<ParsedCertificate> CreateDetailsAsync (Certificate body = null);

        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ParsedCertificate)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParsedCertificate>> CreateDetailsAsyncWithHttpInfo (Certificate body = null);
        
        /// <summary>
        /// Validates a street address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ValidateAddressResponse</returns>
        ValidateAddressResponse CreateAddressvalidation (ValidateAddressRequest body = null);
  
        /// <summary>
        /// Validates a street address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ValidateAddressResponse</returns>
        ApiResponse<ValidateAddressResponse> CreateAddressvalidationWithHttpInfo (ValidateAddressRequest body = null);

        /// <summary>
        /// Validates a street address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ValidateAddressResponse</returns>
        System.Threading.Tasks.Task<ValidateAddressResponse> CreateAddressvalidationAsync (ValidateAddressRequest body = null);

        /// <summary>
        /// Validates a street address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ValidateAddressResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidateAddressResponse>> CreateAddressvalidationAsyncWithHttpInfo (ValidateAddressRequest body = null);
        
        /// <summary>
        /// Get the current system date/time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ServerDate</returns>
        ServerDate Get ();
  
        /// <summary>
        /// Get the current system date/time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of ServerDate</returns>
        ApiResponse<ServerDate> GetWithHttpInfo ();

        /// <summary>
        /// Get the current system date/time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ServerDate</returns>
        System.Threading.Tasks.Task<ServerDate> GetAsync ();

        /// <summary>
        /// Get the current system date/time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (ServerDate)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerDate>> GetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get time zones list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>TimeZoneEntityListing</returns>
        TimeZoneEntityListing GetTimezones (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get time zones list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        ApiResponse<TimeZoneEntityListing> GetTimezonesWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get time zones list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of TimeZoneEntityListing</returns>
        System.Threading.Tasks.Task<TimeZoneEntityListing> GetTimezonesAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get time zones list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (TimeZoneEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeZoneEntityListing>> GetTimezonesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UtilitiesApi : IUtilitiesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UtilitiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UtilitiesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UtilitiesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UtilitiesApi(Configuration configuration = null)
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
        /// Returns the information about an X509 PEM encoded certificate or certificate chain. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ParsedCertificate</returns>
        public ParsedCertificate CreateDetails (Certificate body = null)
        {
             ApiResponse<ParsedCertificate> response = CreateDetailsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of ParsedCertificate</returns>
        public ApiResponse< ParsedCertificate > CreateDetailsWithHttpInfo (Certificate body = null)
        {
            
    
            var path_ = "/api/v1/certificate/details";
    
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
                throw new ApiException (statusCode, "Error calling CreateDetails: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateDetails: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ParsedCertificate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParsedCertificate) Configuration.ApiClient.Deserialize(response, typeof(ParsedCertificate)));
            
        }
    
        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ParsedCertificate</returns>
        public async System.Threading.Tasks.Task<ParsedCertificate> CreateDetailsAsync (Certificate body = null)
        {
             ApiResponse<ParsedCertificate> response = await CreateDetailsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ParsedCertificate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParsedCertificate>> CreateDetailsAsyncWithHttpInfo (Certificate body = null)
        {
            
    
            var path_ = "/api/v1/certificate/details";
    
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
                throw new ApiException (statusCode, "Error calling CreateDetails: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateDetails: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ParsedCertificate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParsedCertificate) Configuration.ApiClient.Deserialize(response, typeof(ParsedCertificate)));
            
        }
        
        /// <summary>
        /// Validates a street address 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ValidateAddressResponse</returns>
        public ValidateAddressResponse CreateAddressvalidation (ValidateAddressRequest body = null)
        {
             ApiResponse<ValidateAddressResponse> response = CreateAddressvalidationWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Validates a street address 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of ValidateAddressResponse</returns>
        public ApiResponse< ValidateAddressResponse > CreateAddressvalidationWithHttpInfo (ValidateAddressRequest body = null)
        {
            
    
            var path_ = "/api/v1/configuration/addressvalidation";
    
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
                throw new ApiException (statusCode, "Error calling CreateAddressvalidation: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateAddressvalidation: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ValidateAddressResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidateAddressResponse) Configuration.ApiClient.Deserialize(response, typeof(ValidateAddressResponse)));
            
        }
    
        /// <summary>
        /// Validates a street address 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ValidateAddressResponse</returns>
        public async System.Threading.Tasks.Task<ValidateAddressResponse> CreateAddressvalidationAsync (ValidateAddressRequest body = null)
        {
             ApiResponse<ValidateAddressResponse> response = await CreateAddressvalidationAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Validates a street address 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ValidateAddressResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidateAddressResponse>> CreateAddressvalidationAsyncWithHttpInfo (ValidateAddressRequest body = null)
        {
            
    
            var path_ = "/api/v1/configuration/addressvalidation";
    
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
                throw new ApiException (statusCode, "Error calling CreateAddressvalidation: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateAddressvalidation: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ValidateAddressResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidateAddressResponse) Configuration.ApiClient.Deserialize(response, typeof(ValidateAddressResponse)));
            
        }
        
        /// <summary>
        /// Get the current system date/time 
        /// </summary>
        /// <returns>ServerDate</returns>
        public ServerDate Get ()
        {
             ApiResponse<ServerDate> response = GetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get the current system date/time 
        /// </summary>
        /// <returns>ApiResponse of ServerDate</returns>
        public ApiResponse< ServerDate > GetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/date";
    
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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ServerDate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerDate) Configuration.ApiClient.Deserialize(response, typeof(ServerDate)));
            
        }
    
        /// <summary>
        /// Get the current system date/time 
        /// </summary>
        /// <returns>Task of ServerDate</returns>
        public async System.Threading.Tasks.Task<ServerDate> GetAsync ()
        {
             ApiResponse<ServerDate> response = await GetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get the current system date/time 
        /// </summary>
        /// <returns>Task of ApiResponse (ServerDate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerDate>> GetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/date";
    
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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ServerDate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerDate) Configuration.ApiClient.Deserialize(response, typeof(ServerDate)));
            
        }
        
        /// <summary>
        /// Get time zones list 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>TimeZoneEntityListing</returns>
        public TimeZoneEntityListing GetTimezones (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> response = GetTimezonesWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get time zones list 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        public ApiResponse< TimeZoneEntityListing > GetTimezonesWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/timezones";
    
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
                throw new ApiException (statusCode, "Error calling GetTimezones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTimezones: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TimeZoneEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimeZoneEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TimeZoneEntityListing)));
            
        }
    
        /// <summary>
        /// Get time zones list 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of TimeZoneEntityListing</returns>
        public async System.Threading.Tasks.Task<TimeZoneEntityListing> GetTimezonesAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> response = await GetTimezonesAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get time zones list 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (TimeZoneEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeZoneEntityListing>> GetTimezonesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/timezones";
    
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
                throw new ApiException (statusCode, "Error calling GetTimezones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTimezones: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TimeZoneEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimeZoneEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TimeZoneEntityListing)));
            
        }
        
    }
    
}
