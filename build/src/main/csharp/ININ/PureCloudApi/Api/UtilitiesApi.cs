using System;
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
    public interface IUtilitiesApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ParsedCertificate</returns>
        ParsedCertificate CertificateDetailsPost (Certificate body = null);

        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ParsedCertificate</returns>
        ApiResponse<ParsedCertificate> CertificateDetailsPostWithHttpInfo (Certificate body = null);
        /// <summary>
        /// Validates a street address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ValidateAddressResponse</returns>
        ValidateAddressResponse ConfigurationAddressvalidationPost (ValidateAddressRequest body = null);

        /// <summary>
        /// Validates a street address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ValidateAddressResponse</returns>
        ApiResponse<ValidateAddressResponse> ConfigurationAddressvalidationPostWithHttpInfo (ValidateAddressRequest body = null);
        /// <summary>
        /// Get the current system date/time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ServerDate</returns>
        ServerDate DateGet ();

        /// <summary>
        /// Get the current system date/time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ServerDate</returns>
        ApiResponse<ServerDate> DateGetWithHttpInfo ();
        /// <summary>
        /// Get time zones list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>TimeZoneEntityListing</returns>
        TimeZoneEntityListing TimezonesGet (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get time zones list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        ApiResponse<TimeZoneEntityListing> TimezonesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ParsedCertificate</returns>
        System.Threading.Tasks.Task<ParsedCertificate> CertificateDetailsPostAsync (Certificate body = null);

        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ParsedCertificate)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParsedCertificate>> CertificateDetailsPostAsyncWithHttpInfo (Certificate body = null);
        /// <summary>
        /// Validates a street address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ValidateAddressResponse</returns>
        System.Threading.Tasks.Task<ValidateAddressResponse> ConfigurationAddressvalidationPostAsync (ValidateAddressRequest body = null);

        /// <summary>
        /// Validates a street address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ValidateAddressResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidateAddressResponse>> ConfigurationAddressvalidationPostAsyncWithHttpInfo (ValidateAddressRequest body = null);
        /// <summary>
        /// Get the current system date/time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ServerDate</returns>
        System.Threading.Tasks.Task<ServerDate> DateGetAsync ();

        /// <summary>
        /// Get the current system date/time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ServerDate)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerDate>> DateGetAsyncWithHttpInfo ();
        /// <summary>
        /// Get time zones list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of TimeZoneEntityListing</returns>
        System.Threading.Tasks.Task<TimeZoneEntityListing> TimezonesGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get time zones list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (TimeZoneEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeZoneEntityListing>> TimezonesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        #endregion Asynchronous Operations
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

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ParsedCertificate</returns>
        public ParsedCertificate CertificateDetailsPost (Certificate body = null)
        {
             ApiResponse<ParsedCertificate> localVarResponse = CertificateDetailsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ParsedCertificate</returns>
        public ApiResponse< ParsedCertificate > CertificateDetailsPostWithHttpInfo (Certificate body = null)
        {

            var localVarPath = "/api/v1/certificate/details";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CertificateDetailsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CertificateDetailsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParsedCertificate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParsedCertificate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParsedCertificate)));
            
        }

        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ParsedCertificate</returns>
        public async System.Threading.Tasks.Task<ParsedCertificate> CertificateDetailsPostAsync (Certificate body = null)
        {
             ApiResponse<ParsedCertificate> localVarResponse = await CertificateDetailsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the information about an X509 PEM encoded certificate or certificate chain. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ParsedCertificate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParsedCertificate>> CertificateDetailsPostAsyncWithHttpInfo (Certificate body = null)
        {

            var localVarPath = "/api/v1/certificate/details";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CertificateDetailsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CertificateDetailsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParsedCertificate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParsedCertificate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParsedCertificate)));
            
        }

        /// <summary>
        /// Validates a street address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ValidateAddressResponse</returns>
        public ValidateAddressResponse ConfigurationAddressvalidationPost (ValidateAddressRequest body = null)
        {
             ApiResponse<ValidateAddressResponse> localVarResponse = ConfigurationAddressvalidationPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validates a street address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ValidateAddressResponse</returns>
        public ApiResponse< ValidateAddressResponse > ConfigurationAddressvalidationPostWithHttpInfo (ValidateAddressRequest body = null)
        {

            var localVarPath = "/api/v1/configuration/addressvalidation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationAddressvalidationPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationAddressvalidationPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidateAddressResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidateAddressResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidateAddressResponse)));
            
        }

        /// <summary>
        /// Validates a street address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ValidateAddressResponse</returns>
        public async System.Threading.Tasks.Task<ValidateAddressResponse> ConfigurationAddressvalidationPostAsync (ValidateAddressRequest body = null)
        {
             ApiResponse<ValidateAddressResponse> localVarResponse = await ConfigurationAddressvalidationPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validates a street address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ValidateAddressResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidateAddressResponse>> ConfigurationAddressvalidationPostAsyncWithHttpInfo (ValidateAddressRequest body = null)
        {

            var localVarPath = "/api/v1/configuration/addressvalidation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationAddressvalidationPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationAddressvalidationPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidateAddressResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidateAddressResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidateAddressResponse)));
            
        }

        /// <summary>
        /// Get the current system date/time 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ServerDate</returns>
        public ServerDate DateGet ()
        {
             ApiResponse<ServerDate> localVarResponse = DateGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the current system date/time 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ServerDate</returns>
        public ApiResponse< ServerDate > DateGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/date";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ServerDate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerDate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerDate)));
            
        }

        /// <summary>
        /// Get the current system date/time 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ServerDate</returns>
        public async System.Threading.Tasks.Task<ServerDate> DateGetAsync ()
        {
             ApiResponse<ServerDate> localVarResponse = await DateGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the current system date/time 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ServerDate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerDate>> DateGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/date";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ServerDate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerDate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerDate)));
            
        }

        /// <summary>
        /// Get time zones list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>TimeZoneEntityListing</returns>
        public TimeZoneEntityListing TimezonesGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> localVarResponse = TimezonesGetWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get time zones list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        public ApiResponse< TimeZoneEntityListing > TimezonesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/timezones";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TimezonesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TimezonesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeZoneEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimeZoneEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeZoneEntityListing)));
            
        }

        /// <summary>
        /// Get time zones list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of TimeZoneEntityListing</returns>
        public async System.Threading.Tasks.Task<TimeZoneEntityListing> TimezonesGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> localVarResponse = await TimezonesGetAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get time zones list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (TimeZoneEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeZoneEntityListing>> TimezonesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/timezones";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TimezonesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TimezonesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeZoneEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimeZoneEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeZoneEntityListing)));
            
        }

    }
}
