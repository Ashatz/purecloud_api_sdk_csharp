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
        ParsedCertificate CertificateDetailsPost (Certificate body = null);
  
        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ParsedCertificate</returns>
        ApiResponse<ParsedCertificate> CertificateDetailsPostWithHttpInfo (Certificate body = null);

        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ParsedCertificate</returns>
        System.Threading.Tasks.Task<ParsedCertificate> CertificateDetailsPostAsync (Certificate body = null);

        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ParsedCertificate)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParsedCertificate>> CertificateDetailsPostAsyncWithHttpInfo (Certificate body = null);
        
        /// <summary>
        /// Validates a street address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ValidateAddressResponse</returns>
        ValidateAddressResponse ConfigurationAddressvalidationPost (ValidateAddressRequest body = null);
  
        /// <summary>
        /// Validates a street address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ValidateAddressResponse</returns>
        ApiResponse<ValidateAddressResponse> ConfigurationAddressvalidationPostWithHttpInfo (ValidateAddressRequest body = null);

        /// <summary>
        /// Validates a street address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ValidateAddressResponse</returns>
        System.Threading.Tasks.Task<ValidateAddressResponse> ConfigurationAddressvalidationPostAsync (ValidateAddressRequest body = null);

        /// <summary>
        /// Validates a street address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ValidateAddressResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidateAddressResponse>> ConfigurationAddressvalidationPostAsyncWithHttpInfo (ValidateAddressRequest body = null);
        
        /// <summary>
        /// Get the current system date/time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ServerDate</returns>
        ServerDate DateGet ();
  
        /// <summary>
        /// Get the current system date/time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of ServerDate</returns>
        ApiResponse<ServerDate> DateGetWithHttpInfo ();

        /// <summary>
        /// Get the current system date/time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ServerDate</returns>
        System.Threading.Tasks.Task<ServerDate> DateGetAsync ();

        /// <summary>
        /// Get the current system date/time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (ServerDate)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerDate>> DateGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Send an email with diagnostic information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Diagnostic</param>
        /// <returns>DiagnosticEmail</returns>
        DiagnosticEmail DiagnosticsPost (DiagnosticEmail body = null);
  
        /// <summary>
        /// Send an email with diagnostic information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Diagnostic</param>
        /// <returns>ApiResponse of DiagnosticEmail</returns>
        ApiResponse<DiagnosticEmail> DiagnosticsPostWithHttpInfo (DiagnosticEmail body = null);

        /// <summary>
        /// Send an email with diagnostic information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Diagnostic</param>
        /// <returns>Task of DiagnosticEmail</returns>
        System.Threading.Tasks.Task<DiagnosticEmail> DiagnosticsPostAsync (DiagnosticEmail body = null);

        /// <summary>
        /// Send an email with diagnostic information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Diagnostic</param>
        /// <returns>Task of ApiResponse (DiagnosticEmail)</returns>
        System.Threading.Tasks.Task<ApiResponse<DiagnosticEmail>> DiagnosticsPostAsyncWithHttpInfo (DiagnosticEmail body = null);
        
        /// <summary>
        /// Contact support with diagnostic information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Diagnostic</param>
        /// <returns>DiagnosticEmail</returns>
        DiagnosticEmail DiagnosticsSupportPost (DiagnosticEmail body = null);
  
        /// <summary>
        /// Contact support with diagnostic information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Diagnostic</param>
        /// <returns>ApiResponse of DiagnosticEmail</returns>
        ApiResponse<DiagnosticEmail> DiagnosticsSupportPostWithHttpInfo (DiagnosticEmail body = null);

        /// <summary>
        /// Contact support with diagnostic information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Diagnostic</param>
        /// <returns>Task of DiagnosticEmail</returns>
        System.Threading.Tasks.Task<DiagnosticEmail> DiagnosticsSupportPostAsync (DiagnosticEmail body = null);

        /// <summary>
        /// Contact support with diagnostic information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Diagnostic</param>
        /// <returns>Task of ApiResponse (DiagnosticEmail)</returns>
        System.Threading.Tasks.Task<ApiResponse<DiagnosticEmail>> DiagnosticsSupportPostAsyncWithHttpInfo (DiagnosticEmail body = null);
        
        /// <summary>
        /// Trace messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Trace List</param>
        /// <returns>string</returns>
        string DiagnosticsTracePost (TraceList body = null);
  
        /// <summary>
        /// Trace messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Trace List</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DiagnosticsTracePostWithHttpInfo (TraceList body = null);

        /// <summary>
        /// Trace messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Trace List</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DiagnosticsTracePostAsync (TraceList body = null);

        /// <summary>
        /// Trace messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Trace List</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DiagnosticsTracePostAsyncWithHttpInfo (TraceList body = null);
        
        /// <summary>
        /// Get the features that are enabled or disabled for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="feature">The features to query.</param>
        /// <returns>Dictionary&lt;string, bool?&gt;</returns>
        Dictionary<string, bool?> FeaturetogglesGet (List<string> feature);
  
        /// <summary>
        /// Get the features that are enabled or disabled for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="feature">The features to query.</param>
        /// <returns>ApiResponse of Dictionary&lt;string, bool?&gt;</returns>
        ApiResponse<Dictionary<string, bool?>> FeaturetogglesGetWithHttpInfo (List<string> feature);

        /// <summary>
        /// Get the features that are enabled or disabled for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="feature">The features to query.</param>
        /// <returns>Task of Dictionary&lt;string, bool?&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, bool?>> FeaturetogglesGetAsync (List<string> feature);

        /// <summary>
        /// Get the features that are enabled or disabled for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="feature">The features to query.</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, bool?&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, bool?>>> FeaturetogglesGetAsyncWithHttpInfo (List<string> feature);
        
        /// <summary>
        /// Get settings for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Dictionary&lt;string, InlineResponse200&gt;</returns>
        Dictionary<string, InlineResponse200> SettingsGet ();
  
        /// <summary>
        /// Get settings for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Dictionary&lt;string, InlineResponse200&gt;</returns>
        ApiResponse<Dictionary<string, InlineResponse200>> SettingsGetWithHttpInfo ();

        /// <summary>
        /// Get settings for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of Dictionary&lt;string, InlineResponse200&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, InlineResponse200>> SettingsGetAsync ();

        /// <summary>
        /// Get settings for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, InlineResponse200&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, InlineResponse200>>> SettingsGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update settings for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns></returns>
        void SettingsPut (Body5 body = null);
  
        /// <summary>
        /// Update settings for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SettingsPutWithHttpInfo (Body5 body = null);

        /// <summary>
        /// Update settings for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SettingsPutAsync (Body5 body = null);

        /// <summary>
        /// Update settings for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SettingsPutAsyncWithHttpInfo (Body5 body = null);
        
        /// <summary>
        /// Get time zones list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>TimeZoneEntityListing</returns>
        TimeZoneEntityListing TimezonesGet (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get time zones list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        ApiResponse<TimeZoneEntityListing> TimezonesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get time zones list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of TimeZoneEntityListing</returns>
        System.Threading.Tasks.Task<TimeZoneEntityListing> TimezonesGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get time zones list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (TimeZoneEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeZoneEntityListing>> TimezonesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get health.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>string</returns>
        string HealthCheckGet ();
  
        /// <summary>
        /// Get health.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> HealthCheckGetWithHttpInfo ();

        /// <summary>
        /// Get health.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> HealthCheckGetAsync ();

        /// <summary>
        /// Get health.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> HealthCheckGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Health check for one or more backend services
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        void HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesGet (bool? expand = null, string name = null);
  
        /// <summary>
        /// Health check for one or more backend services
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand"></param>
        /// <param name="name"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesGetWithHttpInfo (bool? expand = null, string name = null);

        /// <summary>
        /// Health check for one or more backend services
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand"></param>
        /// <param name="name"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesGetAsync (bool? expand = null, string name = null);

        /// <summary>
        /// Health check for one or more backend services
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand"></param>
        /// <param name="name"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesGetAsyncWithHttpInfo (bool? expand = null, string name = null);
        
        /// <summary>
        /// Health check for backend service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns></returns>
        void HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGet (string name);
  
        /// <summary>
        /// Health check for backend service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGetWithHttpInfo (string name);

        /// <summary>
        /// Health check for backend service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGetAsync (string name);

        /// <summary>
        /// Health check for backend service
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGetAsyncWithHttpInfo (string name);
        
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
        public ParsedCertificate CertificateDetailsPost (Certificate body = null)
        {
             ApiResponse<ParsedCertificate> response = CertificateDetailsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of ParsedCertificate</returns>
        public ApiResponse< ParsedCertificate > CertificateDetailsPostWithHttpInfo (Certificate body = null)
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
                throw new ApiException (statusCode, "Error calling CertificateDetailsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CertificateDetailsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ParsedCertificate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParsedCertificate) Configuration.ApiClient.Deserialize(response, typeof(ParsedCertificate)));
            
        }
    
        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ParsedCertificate</returns>
        public async System.Threading.Tasks.Task<ParsedCertificate> CertificateDetailsPostAsync (Certificate body = null)
        {
             ApiResponse<ParsedCertificate> response = await CertificateDetailsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ParsedCertificate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParsedCertificate>> CertificateDetailsPostAsyncWithHttpInfo (Certificate body = null)
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
                throw new ApiException (statusCode, "Error calling CertificateDetailsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CertificateDetailsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ParsedCertificate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParsedCertificate) Configuration.ApiClient.Deserialize(response, typeof(ParsedCertificate)));
            
        }
        
        /// <summary>
        /// Validates a street address 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ValidateAddressResponse</returns>
        public ValidateAddressResponse ConfigurationAddressvalidationPost (ValidateAddressRequest body = null)
        {
             ApiResponse<ValidateAddressResponse> response = ConfigurationAddressvalidationPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Validates a street address 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of ValidateAddressResponse</returns>
        public ApiResponse< ValidateAddressResponse > ConfigurationAddressvalidationPostWithHttpInfo (ValidateAddressRequest body = null)
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
                throw new ApiException (statusCode, "Error calling ConfigurationAddressvalidationPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConfigurationAddressvalidationPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ValidateAddressResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidateAddressResponse) Configuration.ApiClient.Deserialize(response, typeof(ValidateAddressResponse)));
            
        }
    
        /// <summary>
        /// Validates a street address 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ValidateAddressResponse</returns>
        public async System.Threading.Tasks.Task<ValidateAddressResponse> ConfigurationAddressvalidationPostAsync (ValidateAddressRequest body = null)
        {
             ApiResponse<ValidateAddressResponse> response = await ConfigurationAddressvalidationPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Validates a street address 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ValidateAddressResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidateAddressResponse>> ConfigurationAddressvalidationPostAsyncWithHttpInfo (ValidateAddressRequest body = null)
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
                throw new ApiException (statusCode, "Error calling ConfigurationAddressvalidationPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConfigurationAddressvalidationPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ValidateAddressResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidateAddressResponse) Configuration.ApiClient.Deserialize(response, typeof(ValidateAddressResponse)));
            
        }
        
        /// <summary>
        /// Get the current system date/time 
        /// </summary>
        /// <returns>ServerDate</returns>
        public ServerDate DateGet ()
        {
             ApiResponse<ServerDate> response = DateGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get the current system date/time 
        /// </summary>
        /// <returns>ApiResponse of ServerDate</returns>
        public ApiResponse< ServerDate > DateGetWithHttpInfo ()
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
                throw new ApiException (statusCode, "Error calling DateGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DateGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ServerDate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerDate) Configuration.ApiClient.Deserialize(response, typeof(ServerDate)));
            
        }
    
        /// <summary>
        /// Get the current system date/time 
        /// </summary>
        /// <returns>Task of ServerDate</returns>
        public async System.Threading.Tasks.Task<ServerDate> DateGetAsync ()
        {
             ApiResponse<ServerDate> response = await DateGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get the current system date/time 
        /// </summary>
        /// <returns>Task of ApiResponse (ServerDate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerDate>> DateGetAsyncWithHttpInfo ()
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
                throw new ApiException (statusCode, "Error calling DateGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DateGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ServerDate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerDate) Configuration.ApiClient.Deserialize(response, typeof(ServerDate)));
            
        }
        
        /// <summary>
        /// Send an email with diagnostic information. 
        /// </summary>
        /// <param name="body">Diagnostic</param> 
        /// <returns>DiagnosticEmail</returns>
        public DiagnosticEmail DiagnosticsPost (DiagnosticEmail body = null)
        {
             ApiResponse<DiagnosticEmail> response = DiagnosticsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Send an email with diagnostic information. 
        /// </summary>
        /// <param name="body">Diagnostic</param> 
        /// <returns>ApiResponse of DiagnosticEmail</returns>
        public ApiResponse< DiagnosticEmail > DiagnosticsPostWithHttpInfo (DiagnosticEmail body = null)
        {
            
    
            var path_ = "/api/v1/diagnostics";
    
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
                throw new ApiException (statusCode, "Error calling DiagnosticsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DiagnosticsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DiagnosticEmail>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DiagnosticEmail) Configuration.ApiClient.Deserialize(response, typeof(DiagnosticEmail)));
            
        }
    
        /// <summary>
        /// Send an email with diagnostic information. 
        /// </summary>
        /// <param name="body">Diagnostic</param>
        /// <returns>Task of DiagnosticEmail</returns>
        public async System.Threading.Tasks.Task<DiagnosticEmail> DiagnosticsPostAsync (DiagnosticEmail body = null)
        {
             ApiResponse<DiagnosticEmail> response = await DiagnosticsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Send an email with diagnostic information. 
        /// </summary>
        /// <param name="body">Diagnostic</param>
        /// <returns>Task of ApiResponse (DiagnosticEmail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DiagnosticEmail>> DiagnosticsPostAsyncWithHttpInfo (DiagnosticEmail body = null)
        {
            
    
            var path_ = "/api/v1/diagnostics";
    
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
                throw new ApiException (statusCode, "Error calling DiagnosticsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DiagnosticsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DiagnosticEmail>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DiagnosticEmail) Configuration.ApiClient.Deserialize(response, typeof(DiagnosticEmail)));
            
        }
        
        /// <summary>
        /// Contact support with diagnostic information. 
        /// </summary>
        /// <param name="body">Diagnostic</param> 
        /// <returns>DiagnosticEmail</returns>
        public DiagnosticEmail DiagnosticsSupportPost (DiagnosticEmail body = null)
        {
             ApiResponse<DiagnosticEmail> response = DiagnosticsSupportPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Contact support with diagnostic information. 
        /// </summary>
        /// <param name="body">Diagnostic</param> 
        /// <returns>ApiResponse of DiagnosticEmail</returns>
        public ApiResponse< DiagnosticEmail > DiagnosticsSupportPostWithHttpInfo (DiagnosticEmail body = null)
        {
            
    
            var path_ = "/api/v1/diagnostics/support";
    
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
                throw new ApiException (statusCode, "Error calling DiagnosticsSupportPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DiagnosticsSupportPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DiagnosticEmail>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DiagnosticEmail) Configuration.ApiClient.Deserialize(response, typeof(DiagnosticEmail)));
            
        }
    
        /// <summary>
        /// Contact support with diagnostic information. 
        /// </summary>
        /// <param name="body">Diagnostic</param>
        /// <returns>Task of DiagnosticEmail</returns>
        public async System.Threading.Tasks.Task<DiagnosticEmail> DiagnosticsSupportPostAsync (DiagnosticEmail body = null)
        {
             ApiResponse<DiagnosticEmail> response = await DiagnosticsSupportPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Contact support with diagnostic information. 
        /// </summary>
        /// <param name="body">Diagnostic</param>
        /// <returns>Task of ApiResponse (DiagnosticEmail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DiagnosticEmail>> DiagnosticsSupportPostAsyncWithHttpInfo (DiagnosticEmail body = null)
        {
            
    
            var path_ = "/api/v1/diagnostics/support";
    
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
                throw new ApiException (statusCode, "Error calling DiagnosticsSupportPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DiagnosticsSupportPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DiagnosticEmail>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DiagnosticEmail) Configuration.ApiClient.Deserialize(response, typeof(DiagnosticEmail)));
            
        }
        
        /// <summary>
        /// Trace messages 
        /// </summary>
        /// <param name="body">Trace List</param> 
        /// <returns>string</returns>
        public string DiagnosticsTracePost (TraceList body = null)
        {
             ApiResponse<string> response = DiagnosticsTracePostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Trace messages 
        /// </summary>
        /// <param name="body">Trace List</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DiagnosticsTracePostWithHttpInfo (TraceList body = null)
        {
            
    
            var path_ = "/api/v1/diagnostics/trace";
    
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
                throw new ApiException (statusCode, "Error calling DiagnosticsTracePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DiagnosticsTracePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Trace messages 
        /// </summary>
        /// <param name="body">Trace List</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DiagnosticsTracePostAsync (TraceList body = null)
        {
             ApiResponse<string> response = await DiagnosticsTracePostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Trace messages 
        /// </summary>
        /// <param name="body">Trace List</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DiagnosticsTracePostAsyncWithHttpInfo (TraceList body = null)
        {
            
    
            var path_ = "/api/v1/diagnostics/trace";
    
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
                throw new ApiException (statusCode, "Error calling DiagnosticsTracePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DiagnosticsTracePost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get the features that are enabled or disabled for this user 
        /// </summary>
        /// <param name="feature">The features to query.</param> 
        /// <returns>Dictionary&lt;string, bool?&gt;</returns>
        public Dictionary<string, bool?> FeaturetogglesGet (List<string> feature)
        {
             ApiResponse<Dictionary<string, bool?>> response = FeaturetogglesGetWithHttpInfo(feature);
             return response.Data;
        }

        /// <summary>
        /// Get the features that are enabled or disabled for this user 
        /// </summary>
        /// <param name="feature">The features to query.</param> 
        /// <returns>ApiResponse of Dictionary&lt;string, bool?&gt;</returns>
        public ApiResponse< Dictionary<string, bool?> > FeaturetogglesGetWithHttpInfo (List<string> feature)
        {
            
            // verify the required parameter 'feature' is set
            if (feature == null) throw new ApiException(400, "Missing required parameter 'feature' when calling FeaturetogglesGet");
            
    
            var path_ = "/api/v1/featuretoggles";
    
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
            
            if (feature != null) queryParams.Add("feature", Configuration.ApiClient.ParameterToString(feature)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FeaturetogglesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FeaturetogglesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Dictionary<string, bool?>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dictionary<string, bool?>) Configuration.ApiClient.Deserialize(response, typeof(Dictionary<string, bool?>)));
            
        }
    
        /// <summary>
        /// Get the features that are enabled or disabled for this user 
        /// </summary>
        /// <param name="feature">The features to query.</param>
        /// <returns>Task of Dictionary&lt;string, bool?&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, bool?>> FeaturetogglesGetAsync (List<string> feature)
        {
             ApiResponse<Dictionary<string, bool?>> response = await FeaturetogglesGetAsyncWithHttpInfo(feature);
             return response.Data;

        }

        /// <summary>
        /// Get the features that are enabled or disabled for this user 
        /// </summary>
        /// <param name="feature">The features to query.</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, bool?&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, bool?>>> FeaturetogglesGetAsyncWithHttpInfo (List<string> feature)
        {
            // verify the required parameter 'feature' is set
            if (feature == null) throw new ApiException(400, "Missing required parameter 'feature' when calling FeaturetogglesGet");
            
    
            var path_ = "/api/v1/featuretoggles";
    
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
            
            if (feature != null) queryParams.Add("feature", Configuration.ApiClient.ParameterToString(feature)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FeaturetogglesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FeaturetogglesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Dictionary<string, bool?>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dictionary<string, bool?>) Configuration.ApiClient.Deserialize(response, typeof(Dictionary<string, bool?>)));
            
        }
        
        /// <summary>
        /// Get settings for the current user 
        /// </summary>
        /// <returns>Dictionary&lt;string, InlineResponse200&gt;</returns>
        public Dictionary<string, InlineResponse200> SettingsGet ()
        {
             ApiResponse<Dictionary<string, InlineResponse200>> response = SettingsGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get settings for the current user 
        /// </summary>
        /// <returns>ApiResponse of Dictionary&lt;string, InlineResponse200&gt;</returns>
        public ApiResponse< Dictionary<string, InlineResponse200> > SettingsGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/settings";
    
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
                throw new ApiException (statusCode, "Error calling SettingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SettingsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Dictionary<string, InlineResponse200>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dictionary<string, InlineResponse200>) Configuration.ApiClient.Deserialize(response, typeof(Dictionary<string, InlineResponse200>)));
            
        }
    
        /// <summary>
        /// Get settings for the current user 
        /// </summary>
        /// <returns>Task of Dictionary&lt;string, InlineResponse200&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, InlineResponse200>> SettingsGetAsync ()
        {
             ApiResponse<Dictionary<string, InlineResponse200>> response = await SettingsGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get settings for the current user 
        /// </summary>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, InlineResponse200&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, InlineResponse200>>> SettingsGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/settings";
    
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
                throw new ApiException (statusCode, "Error calling SettingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SettingsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Dictionary<string, InlineResponse200>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dictionary<string, InlineResponse200>) Configuration.ApiClient.Deserialize(response, typeof(Dictionary<string, InlineResponse200>)));
            
        }
        
        /// <summary>
        /// Update settings for the current user 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>
        public void SettingsPut (Body5 body = null)
        {
             SettingsPutWithHttpInfo(body);
        }

        /// <summary>
        /// Update settings for the current user 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SettingsPutWithHttpInfo (Body5 body = null)
        {
            
    
            var path_ = "/api/v1/settings";
    
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
                throw new ApiException (statusCode, "Error calling SettingsPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SettingsPut: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Update settings for the current user 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SettingsPutAsync (Body5 body = null)
        {
             await SettingsPutAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update settings for the current user 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SettingsPutAsyncWithHttpInfo (Body5 body = null)
        {
            
    
            var path_ = "/api/v1/settings";
    
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
                throw new ApiException (statusCode, "Error calling SettingsPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SettingsPut: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get time zones list 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>TimeZoneEntityListing</returns>
        public TimeZoneEntityListing TimezonesGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> response = TimezonesGetWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get time zones list 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        public ApiResponse< TimeZoneEntityListing > TimezonesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (statusCode, "Error calling TimezonesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TimezonesGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TimeZoneEntityListing> TimezonesGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> response = await TimezonesGetAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get time zones list 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (TimeZoneEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeZoneEntityListing>> TimezonesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (statusCode, "Error calling TimezonesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TimezonesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TimeZoneEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimeZoneEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TimeZoneEntityListing)));
            
        }
        
        /// <summary>
        /// Get health. 
        /// </summary>
        /// <returns>string</returns>
        public string HealthCheckGet ()
        {
             ApiResponse<string> response = HealthCheckGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get health. 
        /// </summary>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > HealthCheckGetWithHttpInfo ()
        {
            
    
            var path_ = "/health/check";
    
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
                throw new ApiException (statusCode, "Error calling HealthCheckGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling HealthCheckGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Get health. 
        /// </summary>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> HealthCheckGetAsync ()
        {
             ApiResponse<string> response = await HealthCheckGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get health. 
        /// </summary>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> HealthCheckGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/health/check";
    
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
                throw new ApiException (statusCode, "Error calling HealthCheckGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling HealthCheckGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Health check for one or more backend services 
        /// </summary>
        /// <param name="expand"></param> 
        /// <param name="name"></param> 
        /// <returns></returns>
        public void HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesGet (bool? expand = null, string name = null)
        {
             HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesGetWithHttpInfo(expand, name);
        }

        /// <summary>
        /// Health check for one or more backend services 
        /// </summary>
        /// <param name="expand"></param> 
        /// <param name="name"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesGetWithHttpInfo (bool? expand = null, string name = null)
        {
            
    
            var path_ = "/health/check/dc5ea213-b829-40c8-ab65-b1eb2b583ff7/services";
    
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
                throw new ApiException (statusCode, "Error calling HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Health check for one or more backend services 
        /// </summary>
        /// <param name="expand"></param>
        /// <param name="name"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesGetAsync (bool? expand = null, string name = null)
        {
             await HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesGetAsyncWithHttpInfo(expand, name);

        }

        /// <summary>
        /// Health check for one or more backend services 
        /// </summary>
        /// <param name="expand"></param>
        /// <param name="name"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesGetAsyncWithHttpInfo (bool? expand = null, string name = null)
        {
            
    
            var path_ = "/health/check/dc5ea213-b829-40c8-ab65-b1eb2b583ff7/services";
    
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
                throw new ApiException (statusCode, "Error calling HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Health check for backend service 
        /// </summary>
        /// <param name="name"></param> 
        /// <returns></returns>
        public void HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGet (string name)
        {
             HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGetWithHttpInfo(name);
        }

        /// <summary>
        /// Health check for backend service 
        /// </summary>
        /// <param name="name"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGetWithHttpInfo (string name)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGet");
            
    
            var path_ = "/health/check/dc5ea213-b829-40c8-ab65-b1eb2b583ff7/services/{name}";
    
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
            if (name != null) pathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Health check for backend service 
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGetAsync (string name)
        {
             await HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGetAsyncWithHttpInfo(name);

        }

        /// <summary>
        /// Health check for backend service 
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGetAsyncWithHttpInfo (string name)
        {
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGet");
            
    
            var path_ = "/health/check/dc5ea213-b829-40c8-ab65-b1eb2b583ff7/services/{name}";
    
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
            if (name != null) pathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling HealthCheckDc5ea213B82940c8Ab65B1eb2b583ff7ServicesNameGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
