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
    public interface ILicensingApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Licenses required for a set of permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">Permission (optional)</param>
        /// <returns>List&lt;License&gt;</returns>
        List<License> LicensingLicensesGet (List<string> permission = null);

        /// <summary>
        /// Get Licenses required for a set of permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">Permission (optional)</param>
        /// <returns>ApiResponse of List&lt;License&gt;</returns>
        ApiResponse<List<License>> LicensingLicensesGetWithHttpInfo (List<string> permission = null);
        /// <summary>
        /// Get org license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OrgLicenseAssignment</returns>
        OrgLicenseAssignment LicensingOrgassignmentsGet ();

        /// <summary>
        /// Get org license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OrgLicenseAssignment</returns>
        ApiResponse<OrgLicenseAssignment> LicensingOrgassignmentsGetWithHttpInfo ();
        /// <summary>
        /// Get org license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>OrgLicenseAssignment</returns>
        OrgLicenseAssignment LicensingOrgassignmentsIdGet (string id);

        /// <summary>
        /// Get org license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of OrgLicenseAssignment</returns>
        ApiResponse<OrgLicenseAssignment> LicensingOrgassignmentsIdGetWithHttpInfo (string id);
        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID (optional)</param>
        /// <returns>List&lt;LicensesByPermission&gt;</returns>
        List<LicensesByPermission> LicensingPermissionsGet (List<string> id = null);

        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID (optional)</param>
        /// <returns>ApiResponse of List&lt;LicensesByPermission&gt;</returns>
        ApiResponse<List<LicensesByPermission>> LicensingPermissionsGetWithHttpInfo (List<string> id = null);
        /// <summary>
        /// Get user license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserLicenseAssignment</returns>
        UserLicenseAssignment LicensingUserassignmentsGet ();

        /// <summary>
        /// Get user license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserLicenseAssignment</returns>
        ApiResponse<UserLicenseAssignment> LicensingUserassignmentsGetWithHttpInfo ();
        /// <summary>
        /// Get user license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>UserLicenseAssignment</returns>
        UserLicenseAssignment LicensingUserassignmentsIdGet (string id);

        /// <summary>
        /// Get user license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of UserLicenseAssignment</returns>
        ApiResponse<UserLicenseAssignment> LicensingUserassignmentsIdGetWithHttpInfo (string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Licenses required for a set of permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">Permission (optional)</param>
        /// <returns>Task of List&lt;License&gt;</returns>
        System.Threading.Tasks.Task<List<License>> LicensingLicensesGetAsync (List<string> permission = null);

        /// <summary>
        /// Get Licenses required for a set of permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">Permission (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;License&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<License>>> LicensingLicensesGetAsyncWithHttpInfo (List<string> permission = null);
        /// <summary>
        /// Get org license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OrgLicenseAssignment</returns>
        System.Threading.Tasks.Task<OrgLicenseAssignment> LicensingOrgassignmentsGetAsync ();

        /// <summary>
        /// Get org license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OrgLicenseAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrgLicenseAssignment>> LicensingOrgassignmentsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Get org license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of OrgLicenseAssignment</returns>
        System.Threading.Tasks.Task<OrgLicenseAssignment> LicensingOrgassignmentsIdGetAsync (string id);

        /// <summary>
        /// Get org license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (OrgLicenseAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrgLicenseAssignment>> LicensingOrgassignmentsIdGetAsyncWithHttpInfo (string id);
        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID (optional)</param>
        /// <returns>Task of List&lt;LicensesByPermission&gt;</returns>
        System.Threading.Tasks.Task<List<LicensesByPermission>> LicensingPermissionsGetAsync (List<string> id = null);

        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LicensesByPermission&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LicensesByPermission>>> LicensingPermissionsGetAsyncWithHttpInfo (List<string> id = null);
        /// <summary>
        /// Get user license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserLicenseAssignment</returns>
        System.Threading.Tasks.Task<UserLicenseAssignment> LicensingUserassignmentsGetAsync ();

        /// <summary>
        /// Get user license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserLicenseAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserLicenseAssignment>> LicensingUserassignmentsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Get user license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of UserLicenseAssignment</returns>
        System.Threading.Tasks.Task<UserLicenseAssignment> LicensingUserassignmentsIdGetAsync (string id);

        /// <summary>
        /// Get user license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (UserLicenseAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserLicenseAssignment>> LicensingUserassignmentsIdGetAsyncWithHttpInfo (string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LicensingApi : ILicensingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LicensingApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicensingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LicensingApi(Configuration configuration = null)
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
        /// Get Licenses required for a set of permissions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">Permission (optional)</param>
        /// <returns>List&lt;License&gt;</returns>
        public List<License> LicensingLicensesGet (List<string> permission = null)
        {
             ApiResponse<List<License>> localVarResponse = LicensingLicensesGetWithHttpInfo(permission);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Licenses required for a set of permissions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">Permission (optional)</param>
        /// <returns>ApiResponse of List&lt;License&gt;</returns>
        public ApiResponse< List<License> > LicensingLicensesGetWithHttpInfo (List<string> permission = null)
        {

            var localVarPath = "/api/v1/licensing/licenses";
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
            if (permission != null) localVarQueryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling LicensingLicensesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LicensingLicensesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<License>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<License>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<License>)));
            
        }

        /// <summary>
        /// Get Licenses required for a set of permissions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">Permission (optional)</param>
        /// <returns>Task of List&lt;License&gt;</returns>
        public async System.Threading.Tasks.Task<List<License>> LicensingLicensesGetAsync (List<string> permission = null)
        {
             ApiResponse<List<License>> localVarResponse = await LicensingLicensesGetAsyncWithHttpInfo(permission);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Licenses required for a set of permissions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permission">Permission (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;License&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<License>>> LicensingLicensesGetAsyncWithHttpInfo (List<string> permission = null)
        {

            var localVarPath = "/api/v1/licensing/licenses";
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
            if (permission != null) localVarQueryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling LicensingLicensesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LicensingLicensesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<License>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<License>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<License>)));
            
        }

        /// <summary>
        /// Get org license assignments. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OrgLicenseAssignment</returns>
        public OrgLicenseAssignment LicensingOrgassignmentsGet ()
        {
             ApiResponse<OrgLicenseAssignment> localVarResponse = LicensingOrgassignmentsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get org license assignments. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OrgLicenseAssignment</returns>
        public ApiResponse< OrgLicenseAssignment > LicensingOrgassignmentsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/licensing/orgassignments";
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
                throw new ApiException (localVarStatusCode, "Error calling LicensingOrgassignmentsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LicensingOrgassignmentsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrgLicenseAssignment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgLicenseAssignment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrgLicenseAssignment)));
            
        }

        /// <summary>
        /// Get org license assignments. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OrgLicenseAssignment</returns>
        public async System.Threading.Tasks.Task<OrgLicenseAssignment> LicensingOrgassignmentsGetAsync ()
        {
             ApiResponse<OrgLicenseAssignment> localVarResponse = await LicensingOrgassignmentsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get org license assignments. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OrgLicenseAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrgLicenseAssignment>> LicensingOrgassignmentsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/licensing/orgassignments";
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
                throw new ApiException (localVarStatusCode, "Error calling LicensingOrgassignmentsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LicensingOrgassignmentsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrgLicenseAssignment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgLicenseAssignment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrgLicenseAssignment)));
            
        }

        /// <summary>
        /// Get org license assignment. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>OrgLicenseAssignment</returns>
        public OrgLicenseAssignment LicensingOrgassignmentsIdGet (string id)
        {
             ApiResponse<OrgLicenseAssignment> localVarResponse = LicensingOrgassignmentsIdGetWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get org license assignment. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of OrgLicenseAssignment</returns>
        public ApiResponse< OrgLicenseAssignment > LicensingOrgassignmentsIdGetWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LicensingApi->LicensingOrgassignmentsIdGet");

            var localVarPath = "/api/v1/licensing/orgassignments/{id}";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling LicensingOrgassignmentsIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LicensingOrgassignmentsIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrgLicenseAssignment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgLicenseAssignment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrgLicenseAssignment)));
            
        }

        /// <summary>
        /// Get org license assignment. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of OrgLicenseAssignment</returns>
        public async System.Threading.Tasks.Task<OrgLicenseAssignment> LicensingOrgassignmentsIdGetAsync (string id)
        {
             ApiResponse<OrgLicenseAssignment> localVarResponse = await LicensingOrgassignmentsIdGetAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get org license assignment. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (OrgLicenseAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrgLicenseAssignment>> LicensingOrgassignmentsIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LicensingApi->LicensingOrgassignmentsIdGet");

            var localVarPath = "/api/v1/licensing/orgassignments/{id}";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling LicensingOrgassignmentsIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LicensingOrgassignmentsIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrgLicenseAssignment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgLicenseAssignment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrgLicenseAssignment)));
            
        }

        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID (optional)</param>
        /// <returns>List&lt;LicensesByPermission&gt;</returns>
        public List<LicensesByPermission> LicensingPermissionsGet (List<string> id = null)
        {
             ApiResponse<List<LicensesByPermission>> localVarResponse = LicensingPermissionsGetWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID (optional)</param>
        /// <returns>ApiResponse of List&lt;LicensesByPermission&gt;</returns>
        public ApiResponse< List<LicensesByPermission> > LicensingPermissionsGetWithHttpInfo (List<string> id = null)
        {

            var localVarPath = "/api/v1/licensing/permissions";
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling LicensingPermissionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LicensingPermissionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<LicensesByPermission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LicensesByPermission>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LicensesByPermission>)));
            
        }

        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID (optional)</param>
        /// <returns>Task of List&lt;LicensesByPermission&gt;</returns>
        public async System.Threading.Tasks.Task<List<LicensesByPermission>> LicensingPermissionsGetAsync (List<string> id = null)
        {
             ApiResponse<List<LicensesByPermission>> localVarResponse = await LicensingPermissionsGetAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LicensesByPermission&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LicensesByPermission>>> LicensingPermissionsGetAsyncWithHttpInfo (List<string> id = null)
        {

            var localVarPath = "/api/v1/licensing/permissions";
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling LicensingPermissionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LicensingPermissionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<LicensesByPermission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LicensesByPermission>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LicensesByPermission>)));
            
        }

        /// <summary>
        /// Get user license assignments. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserLicenseAssignment</returns>
        public UserLicenseAssignment LicensingUserassignmentsGet ()
        {
             ApiResponse<UserLicenseAssignment> localVarResponse = LicensingUserassignmentsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get user license assignments. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserLicenseAssignment</returns>
        public ApiResponse< UserLicenseAssignment > LicensingUserassignmentsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/licensing/userassignments";
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
                throw new ApiException (localVarStatusCode, "Error calling LicensingUserassignmentsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LicensingUserassignmentsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserLicenseAssignment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserLicenseAssignment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserLicenseAssignment)));
            
        }

        /// <summary>
        /// Get user license assignments. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserLicenseAssignment</returns>
        public async System.Threading.Tasks.Task<UserLicenseAssignment> LicensingUserassignmentsGetAsync ()
        {
             ApiResponse<UserLicenseAssignment> localVarResponse = await LicensingUserassignmentsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get user license assignments. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserLicenseAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserLicenseAssignment>> LicensingUserassignmentsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/licensing/userassignments";
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
                throw new ApiException (localVarStatusCode, "Error calling LicensingUserassignmentsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LicensingUserassignmentsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserLicenseAssignment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserLicenseAssignment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserLicenseAssignment)));
            
        }

        /// <summary>
        /// Get user license assignment. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>UserLicenseAssignment</returns>
        public UserLicenseAssignment LicensingUserassignmentsIdGet (string id)
        {
             ApiResponse<UserLicenseAssignment> localVarResponse = LicensingUserassignmentsIdGetWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get user license assignment. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of UserLicenseAssignment</returns>
        public ApiResponse< UserLicenseAssignment > LicensingUserassignmentsIdGetWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LicensingApi->LicensingUserassignmentsIdGet");

            var localVarPath = "/api/v1/licensing/userassignments/{id}";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling LicensingUserassignmentsIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LicensingUserassignmentsIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserLicenseAssignment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserLicenseAssignment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserLicenseAssignment)));
            
        }

        /// <summary>
        /// Get user license assignment. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of UserLicenseAssignment</returns>
        public async System.Threading.Tasks.Task<UserLicenseAssignment> LicensingUserassignmentsIdGetAsync (string id)
        {
             ApiResponse<UserLicenseAssignment> localVarResponse = await LicensingUserassignmentsIdGetAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get user license assignment. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (UserLicenseAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserLicenseAssignment>> LicensingUserassignmentsIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LicensingApi->LicensingUserassignmentsIdGet");

            var localVarPath = "/api/v1/licensing/userassignments/{id}";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling LicensingUserassignmentsIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LicensingUserassignmentsIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserLicenseAssignment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserLicenseAssignment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserLicenseAssignment)));
            
        }

    }
}
