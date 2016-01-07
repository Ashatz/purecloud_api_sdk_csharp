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
    public interface ILicensingApi
    {
        
        /// <summary>
        /// Get Licenses required for a set of permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="permission">Permission</param>
        /// <returns>List&lt;License&gt;</returns>
        List<License> LicensingLicensesGet (List<string> permission = null);
  
        /// <summary>
        /// Get Licenses required for a set of permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="permission">Permission</param>
        /// <returns>ApiResponse of List&lt;License&gt;</returns>
        ApiResponse<List<License>> LicensingLicensesGetWithHttpInfo (List<string> permission = null);

        /// <summary>
        /// Get Licenses required for a set of permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="permission">Permission</param>
        /// <returns>Task of List&lt;License&gt;</returns>
        System.Threading.Tasks.Task<List<License>> LicensingLicensesGetAsync (List<string> permission = null);

        /// <summary>
        /// Get Licenses required for a set of permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="permission">Permission</param>
        /// <returns>Task of ApiResponse (List&lt;License&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<License>>> LicensingLicensesGetAsyncWithHttpInfo (List<string> permission = null);
        
        /// <summary>
        /// Get org license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>OrgLicenseAssignment</returns>
        OrgLicenseAssignment LicensingOrgassignmentsGet ();
  
        /// <summary>
        /// Get org license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of OrgLicenseAssignment</returns>
        ApiResponse<OrgLicenseAssignment> LicensingOrgassignmentsGetWithHttpInfo ();

        /// <summary>
        /// Get org license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of OrgLicenseAssignment</returns>
        System.Threading.Tasks.Task<OrgLicenseAssignment> LicensingOrgassignmentsGetAsync ();

        /// <summary>
        /// Get org license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (OrgLicenseAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrgLicenseAssignment>> LicensingOrgassignmentsGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get org license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>OrgLicenseAssignment</returns>
        OrgLicenseAssignment LicensingOrgassignmentsIdGet (string id);
  
        /// <summary>
        /// Get org license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of OrgLicenseAssignment</returns>
        ApiResponse<OrgLicenseAssignment> LicensingOrgassignmentsIdGetWithHttpInfo (string id);

        /// <summary>
        /// Get org license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of OrgLicenseAssignment</returns>
        System.Threading.Tasks.Task<OrgLicenseAssignment> LicensingOrgassignmentsIdGetAsync (string id);

        /// <summary>
        /// Get org license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (OrgLicenseAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrgLicenseAssignment>> LicensingOrgassignmentsIdGetAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>List&lt;LicensesByPermission&gt;</returns>
        List<LicensesByPermission> LicensingPermissionsGet (List<string> id = null);
  
        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of List&lt;LicensesByPermission&gt;</returns>
        ApiResponse<List<LicensesByPermission>> LicensingPermissionsGetWithHttpInfo (List<string> id = null);

        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of List&lt;LicensesByPermission&gt;</returns>
        System.Threading.Tasks.Task<List<LicensesByPermission>> LicensingPermissionsGetAsync (List<string> id = null);

        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (List&lt;LicensesByPermission&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LicensesByPermission>>> LicensingPermissionsGetAsyncWithHttpInfo (List<string> id = null);
        
        /// <summary>
        /// Get user license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>UserLicenseAssignment</returns>
        UserLicenseAssignment LicensingUserassignmentsGet ();
  
        /// <summary>
        /// Get user license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of UserLicenseAssignment</returns>
        ApiResponse<UserLicenseAssignment> LicensingUserassignmentsGetWithHttpInfo ();

        /// <summary>
        /// Get user license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of UserLicenseAssignment</returns>
        System.Threading.Tasks.Task<UserLicenseAssignment> LicensingUserassignmentsGetAsync ();

        /// <summary>
        /// Get user license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (UserLicenseAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserLicenseAssignment>> LicensingUserassignmentsGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get user license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>UserLicenseAssignment</returns>
        UserLicenseAssignment LicensingUserassignmentsIdGet (string id);
  
        /// <summary>
        /// Get user license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of UserLicenseAssignment</returns>
        ApiResponse<UserLicenseAssignment> LicensingUserassignmentsIdGetWithHttpInfo (string id);

        /// <summary>
        /// Get user license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of UserLicenseAssignment</returns>
        System.Threading.Tasks.Task<UserLicenseAssignment> LicensingUserassignmentsIdGetAsync (string id);

        /// <summary>
        /// Get user license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (UserLicenseAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserLicenseAssignment>> LicensingUserassignmentsIdGetAsyncWithHttpInfo (string id);
        
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
        /// <param name="permission">Permission</param> 
        /// <returns>List&lt;License&gt;</returns>
        public List<License> LicensingLicensesGet (List<string> permission = null)
        {
             ApiResponse<List<License>> response = LicensingLicensesGetWithHttpInfo(permission);
             return response.Data;
        }

        /// <summary>
        /// Get Licenses required for a set of permissions. 
        /// </summary>
        /// <param name="permission">Permission</param> 
        /// <returns>ApiResponse of List&lt;License&gt;</returns>
        public ApiResponse< List<License> > LicensingLicensesGetWithHttpInfo (List<string> permission = null)
        {
            
    
            var path_ = "/api/v1/licensing/licenses";
    
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
            
            if (permission != null) queryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling LicensingLicensesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LicensingLicensesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<License>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<License>) Configuration.ApiClient.Deserialize(response, typeof(List<License>)));
            
        }
    
        /// <summary>
        /// Get Licenses required for a set of permissions. 
        /// </summary>
        /// <param name="permission">Permission</param>
        /// <returns>Task of List&lt;License&gt;</returns>
        public async System.Threading.Tasks.Task<List<License>> LicensingLicensesGetAsync (List<string> permission = null)
        {
             ApiResponse<List<License>> response = await LicensingLicensesGetAsyncWithHttpInfo(permission);
             return response.Data;

        }

        /// <summary>
        /// Get Licenses required for a set of permissions. 
        /// </summary>
        /// <param name="permission">Permission</param>
        /// <returns>Task of ApiResponse (List&lt;License&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<License>>> LicensingLicensesGetAsyncWithHttpInfo (List<string> permission = null)
        {
            
    
            var path_ = "/api/v1/licensing/licenses";
    
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
            
            if (permission != null) queryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling LicensingLicensesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LicensingLicensesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<License>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<License>) Configuration.ApiClient.Deserialize(response, typeof(List<License>)));
            
        }
        
        /// <summary>
        /// Get org license assignments. 
        /// </summary>
        /// <returns>OrgLicenseAssignment</returns>
        public OrgLicenseAssignment LicensingOrgassignmentsGet ()
        {
             ApiResponse<OrgLicenseAssignment> response = LicensingOrgassignmentsGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get org license assignments. 
        /// </summary>
        /// <returns>ApiResponse of OrgLicenseAssignment</returns>
        public ApiResponse< OrgLicenseAssignment > LicensingOrgassignmentsGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/licensing/orgassignments";
    
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
                throw new ApiException (statusCode, "Error calling LicensingOrgassignmentsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LicensingOrgassignmentsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrgLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(OrgLicenseAssignment)));
            
        }
    
        /// <summary>
        /// Get org license assignments. 
        /// </summary>
        /// <returns>Task of OrgLicenseAssignment</returns>
        public async System.Threading.Tasks.Task<OrgLicenseAssignment> LicensingOrgassignmentsGetAsync ()
        {
             ApiResponse<OrgLicenseAssignment> response = await LicensingOrgassignmentsGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get org license assignments. 
        /// </summary>
        /// <returns>Task of ApiResponse (OrgLicenseAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrgLicenseAssignment>> LicensingOrgassignmentsGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/licensing/orgassignments";
    
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
                throw new ApiException (statusCode, "Error calling LicensingOrgassignmentsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LicensingOrgassignmentsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrgLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(OrgLicenseAssignment)));
            
        }
        
        /// <summary>
        /// Get org license assignment. 
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>OrgLicenseAssignment</returns>
        public OrgLicenseAssignment LicensingOrgassignmentsIdGet (string id)
        {
             ApiResponse<OrgLicenseAssignment> response = LicensingOrgassignmentsIdGetWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Get org license assignment. 
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>ApiResponse of OrgLicenseAssignment</returns>
        public ApiResponse< OrgLicenseAssignment > LicensingOrgassignmentsIdGetWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LicensingOrgassignmentsIdGet");
            
    
            var path_ = "/api/v1/licensing/orgassignments/{id}";
    
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
                throw new ApiException (statusCode, "Error calling LicensingOrgassignmentsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LicensingOrgassignmentsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrgLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(OrgLicenseAssignment)));
            
        }
    
        /// <summary>
        /// Get org license assignment. 
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of OrgLicenseAssignment</returns>
        public async System.Threading.Tasks.Task<OrgLicenseAssignment> LicensingOrgassignmentsIdGetAsync (string id)
        {
             ApiResponse<OrgLicenseAssignment> response = await LicensingOrgassignmentsIdGetAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Get org license assignment. 
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (OrgLicenseAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrgLicenseAssignment>> LicensingOrgassignmentsIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LicensingOrgassignmentsIdGet");
            
    
            var path_ = "/api/v1/licensing/orgassignments/{id}";
    
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
                throw new ApiException (statusCode, "Error calling LicensingOrgassignmentsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LicensingOrgassignmentsIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrgLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(OrgLicenseAssignment)));
            
        }
        
        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>List&lt;LicensesByPermission&gt;</returns>
        public List<LicensesByPermission> LicensingPermissionsGet (List<string> id = null)
        {
             ApiResponse<List<LicensesByPermission>> response = LicensingPermissionsGetWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>ApiResponse of List&lt;LicensesByPermission&gt;</returns>
        public ApiResponse< List<LicensesByPermission> > LicensingPermissionsGetWithHttpInfo (List<string> id = null)
        {
            
    
            var path_ = "/api/v1/licensing/permissions";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling LicensingPermissionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LicensingPermissionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<LicensesByPermission>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LicensesByPermission>) Configuration.ApiClient.Deserialize(response, typeof(List<LicensesByPermission>)));
            
        }
    
        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of List&lt;LicensesByPermission&gt;</returns>
        public async System.Threading.Tasks.Task<List<LicensesByPermission>> LicensingPermissionsGetAsync (List<string> id = null)
        {
             ApiResponse<List<LicensesByPermission>> response = await LicensingPermissionsGetAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (List&lt;LicensesByPermission&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LicensesByPermission>>> LicensingPermissionsGetAsyncWithHttpInfo (List<string> id = null)
        {
            
    
            var path_ = "/api/v1/licensing/permissions";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling LicensingPermissionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LicensingPermissionsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<LicensesByPermission>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LicensesByPermission>) Configuration.ApiClient.Deserialize(response, typeof(List<LicensesByPermission>)));
            
        }
        
        /// <summary>
        /// Get user license assignments. 
        /// </summary>
        /// <returns>UserLicenseAssignment</returns>
        public UserLicenseAssignment LicensingUserassignmentsGet ()
        {
             ApiResponse<UserLicenseAssignment> response = LicensingUserassignmentsGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get user license assignments. 
        /// </summary>
        /// <returns>ApiResponse of UserLicenseAssignment</returns>
        public ApiResponse< UserLicenseAssignment > LicensingUserassignmentsGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/licensing/userassignments";
    
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
                throw new ApiException (statusCode, "Error calling LicensingUserassignmentsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LicensingUserassignmentsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(UserLicenseAssignment)));
            
        }
    
        /// <summary>
        /// Get user license assignments. 
        /// </summary>
        /// <returns>Task of UserLicenseAssignment</returns>
        public async System.Threading.Tasks.Task<UserLicenseAssignment> LicensingUserassignmentsGetAsync ()
        {
             ApiResponse<UserLicenseAssignment> response = await LicensingUserassignmentsGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get user license assignments. 
        /// </summary>
        /// <returns>Task of ApiResponse (UserLicenseAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserLicenseAssignment>> LicensingUserassignmentsGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/licensing/userassignments";
    
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
                throw new ApiException (statusCode, "Error calling LicensingUserassignmentsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LicensingUserassignmentsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(UserLicenseAssignment)));
            
        }
        
        /// <summary>
        /// Get user license assignment. 
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>UserLicenseAssignment</returns>
        public UserLicenseAssignment LicensingUserassignmentsIdGet (string id)
        {
             ApiResponse<UserLicenseAssignment> response = LicensingUserassignmentsIdGetWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Get user license assignment. 
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>ApiResponse of UserLicenseAssignment</returns>
        public ApiResponse< UserLicenseAssignment > LicensingUserassignmentsIdGetWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LicensingUserassignmentsIdGet");
            
    
            var path_ = "/api/v1/licensing/userassignments/{id}";
    
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
                throw new ApiException (statusCode, "Error calling LicensingUserassignmentsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LicensingUserassignmentsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(UserLicenseAssignment)));
            
        }
    
        /// <summary>
        /// Get user license assignment. 
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of UserLicenseAssignment</returns>
        public async System.Threading.Tasks.Task<UserLicenseAssignment> LicensingUserassignmentsIdGetAsync (string id)
        {
             ApiResponse<UserLicenseAssignment> response = await LicensingUserassignmentsIdGetAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Get user license assignment. 
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (UserLicenseAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserLicenseAssignment>> LicensingUserassignmentsIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LicensingUserassignmentsIdGet");
            
    
            var path_ = "/api/v1/licensing/userassignments/{id}";
    
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
                throw new ApiException (statusCode, "Error calling LicensingUserassignmentsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling LicensingUserassignmentsIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(UserLicenseAssignment)));
            
        }
        
    }
    
}
