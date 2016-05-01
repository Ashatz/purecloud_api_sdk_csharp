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
    public interface IObjectsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns a permission-protected object, showing the permission contexts it belongs to.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectId">Object ID</param>
        /// <returns>AuthzObject</returns>
        AuthzObject GetObjectsObjectId (string objectId);

        /// <summary>
        /// Returns a permission-protected object, showing the permission contexts it belongs to.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectId">Object ID</param>
        /// <returns>ApiResponse of AuthzObject</returns>
        ApiResponse<AuthzObject> GetObjectsObjectIdWithHttpInfo (string objectId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns a permission-protected object, showing the permission contexts it belongs to.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectId">Object ID</param>
        /// <returns>Task of AuthzObject</returns>
        System.Threading.Tasks.Task<AuthzObject> GetObjectsObjectIdAsync (string objectId);

        /// <summary>
        /// Returns a permission-protected object, showing the permission contexts it belongs to.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectId">Object ID</param>
        /// <returns>Task of ApiResponse (AuthzObject)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthzObject>> GetObjectsObjectIdAsyncWithHttpInfo (string objectId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ObjectsApi : IObjectsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ObjectsApi(Configuration configuration = null)
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
        /// Returns a permission-protected object, showing the permission contexts it belongs to. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectId">Object ID</param>
        /// <returns>AuthzObject</returns>
        public AuthzObject GetObjectsObjectId (string objectId)
        {
             ApiResponse<AuthzObject> localVarResponse = GetObjectsObjectIdWithHttpInfo(objectId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a permission-protected object, showing the permission contexts it belongs to. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectId">Object ID</param>
        /// <returns>ApiResponse of AuthzObject</returns>
        public ApiResponse< AuthzObject > GetObjectsObjectIdWithHttpInfo (string objectId)
        {
            // verify the required parameter 'objectId' is set
            if (objectId == null)
                throw new ApiException(400, "Missing required parameter 'objectId' when calling ObjectsApi->GetObjectsObjectId");

            var localVarPath = "/api/v2/authorization/objects/{objectId}";
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
            if (objectId != null) localVarPathParams.Add("objectId", Configuration.ApiClient.ParameterToString(objectId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetObjectsObjectId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetObjectsObjectId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzObject>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuthzObject) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzObject)));
            
        }

        /// <summary>
        /// Returns a permission-protected object, showing the permission contexts it belongs to. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectId">Object ID</param>
        /// <returns>Task of AuthzObject</returns>
        public async System.Threading.Tasks.Task<AuthzObject> GetObjectsObjectIdAsync (string objectId)
        {
             ApiResponse<AuthzObject> localVarResponse = await GetObjectsObjectIdAsyncWithHttpInfo(objectId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a permission-protected object, showing the permission contexts it belongs to. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectId">Object ID</param>
        /// <returns>Task of ApiResponse (AuthzObject)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthzObject>> GetObjectsObjectIdAsyncWithHttpInfo (string objectId)
        {
            // verify the required parameter 'objectId' is set
            if (objectId == null)
                throw new ApiException(400, "Missing required parameter 'objectId' when calling ObjectsApi->GetObjectsObjectId");

            var localVarPath = "/api/v2/authorization/objects/{objectId}";
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
            if (objectId != null) localVarPathParams.Add("objectId", Configuration.ApiClient.ParameterToString(objectId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetObjectsObjectId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetObjectsObjectId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuthzObject>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuthzObject) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthzObject)));
            
        }

    }
}
