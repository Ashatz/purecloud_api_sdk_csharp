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
        List<License> GetLicenses (List<string> permission = null);
  
        /// <summary>
        /// Get Licenses required for a set of permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="permission">Permission</param>
        /// <returns>ApiResponse of List&lt;License&gt;</returns>
        ApiResponse<List<License>> GetLicensesWithHttpInfo (List<string> permission = null);

        /// <summary>
        /// Get Licenses required for a set of permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="permission">Permission</param>
        /// <returns>Task of List&lt;License&gt;</returns>
        System.Threading.Tasks.Task<List<License>> GetLicensesAsync (List<string> permission = null);

        /// <summary>
        /// Get Licenses required for a set of permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="permission">Permission</param>
        /// <returns>Task of ApiResponse (List&lt;License&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<License>>> GetLicensesAsyncWithHttpInfo (List<string> permission = null);
        
        /// <summary>
        /// Get org license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>OrgLicenseAssignment</returns>
        OrgLicenseAssignment GetOrgassignments ();
  
        /// <summary>
        /// Get org license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of OrgLicenseAssignment</returns>
        ApiResponse<OrgLicenseAssignment> GetOrgassignmentsWithHttpInfo ();

        /// <summary>
        /// Get org license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of OrgLicenseAssignment</returns>
        System.Threading.Tasks.Task<OrgLicenseAssignment> GetOrgassignmentsAsync ();

        /// <summary>
        /// Get org license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (OrgLicenseAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrgLicenseAssignment>> GetOrgassignmentsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get org license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>OrgLicenseAssignment</returns>
        OrgLicenseAssignment GetOrgassignmentsId (string id);
  
        /// <summary>
        /// Get org license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of OrgLicenseAssignment</returns>
        ApiResponse<OrgLicenseAssignment> GetOrgassignmentsIdWithHttpInfo (string id);

        /// <summary>
        /// Get org license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of OrgLicenseAssignment</returns>
        System.Threading.Tasks.Task<OrgLicenseAssignment> GetOrgassignmentsIdAsync (string id);

        /// <summary>
        /// Get org license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (OrgLicenseAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrgLicenseAssignment>> GetOrgassignmentsIdAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>List&lt;LicensesByPermission&gt;</returns>
        List<LicensesByPermission> GetPermissions (List<string> id = null);
  
        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of List&lt;LicensesByPermission&gt;</returns>
        ApiResponse<List<LicensesByPermission>> GetPermissionsWithHttpInfo (List<string> id = null);

        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of List&lt;LicensesByPermission&gt;</returns>
        System.Threading.Tasks.Task<List<LicensesByPermission>> GetPermissionsAsync (List<string> id = null);

        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (List&lt;LicensesByPermission&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LicensesByPermission>>> GetPermissionsAsyncWithHttpInfo (List<string> id = null);
        
        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="body">The permissions details</param>
        /// <returns>List&lt;LicensesByPermission&gt;</returns>
        List<LicensesByPermission> PostPermissions (List<string> id = null, Permissions body = null);
  
        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="body">The permissions details</param>
        /// <returns>ApiResponse of List&lt;LicensesByPermission&gt;</returns>
        ApiResponse<List<LicensesByPermission>> PostPermissionsWithHttpInfo (List<string> id = null, Permissions body = null);

        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="body">The permissions details</param>
        /// <returns>Task of List&lt;LicensesByPermission&gt;</returns>
        System.Threading.Tasks.Task<List<LicensesByPermission>> PostPermissionsAsync (List<string> id = null, Permissions body = null);

        /// <summary>
        /// Get Licenses required per permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="body">The permissions details</param>
        /// <returns>Task of ApiResponse (List&lt;LicensesByPermission&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LicensesByPermission>>> PostPermissionsAsyncWithHttpInfo (List<string> id = null, Permissions body = null);
        
        /// <summary>
        /// Get user license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>UserLicenseAssignment</returns>
        UserLicenseAssignment GetUserassignments ();
  
        /// <summary>
        /// Get user license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of UserLicenseAssignment</returns>
        ApiResponse<UserLicenseAssignment> GetUserassignmentsWithHttpInfo ();

        /// <summary>
        /// Get user license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of UserLicenseAssignment</returns>
        System.Threading.Tasks.Task<UserLicenseAssignment> GetUserassignmentsAsync ();

        /// <summary>
        /// Get user license assignments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (UserLicenseAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserLicenseAssignment>> GetUserassignmentsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get user license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>UserLicenseAssignment</returns>
        UserLicenseAssignment GetUserassignmentsId (string id);
  
        /// <summary>
        /// Get user license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of UserLicenseAssignment</returns>
        ApiResponse<UserLicenseAssignment> GetUserassignmentsIdWithHttpInfo (string id);

        /// <summary>
        /// Get user license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of UserLicenseAssignment</returns>
        System.Threading.Tasks.Task<UserLicenseAssignment> GetUserassignmentsIdAsync (string id);

        /// <summary>
        /// Get user license assignment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (UserLicenseAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserLicenseAssignment>> GetUserassignmentsIdAsyncWithHttpInfo (string id);
        
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
        public List<License> GetLicenses (List<string> permission = null)
        {
             ApiResponse<List<License>> response = GetLicensesWithHttpInfo(permission);
             return response.Data;
        }

        /// <summary>
        /// Get Licenses required for a set of permissions. 
        /// </summary>
        /// <param name="permission">Permission</param> 
        /// <returns>ApiResponse of List&lt;License&gt;</returns>
        public ApiResponse< List<License> > GetLicensesWithHttpInfo (List<string> permission = null)
        {
            
    
            var path_ = "/api/v1/licensing/licenses";
    
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
            
            if (permission != null) queryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetLicenses: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetLicenses: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<License>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<License>) Configuration.ApiClient.Deserialize(response, typeof(List<License>)));
            
        }
    
        /// <summary>
        /// Get Licenses required for a set of permissions. 
        /// </summary>
        /// <param name="permission">Permission</param>
        /// <returns>Task of List&lt;License&gt;</returns>
        public async System.Threading.Tasks.Task<List<License>> GetLicensesAsync (List<string> permission = null)
        {
             ApiResponse<List<License>> response = await GetLicensesAsyncWithHttpInfo(permission);
             return response.Data;

        }

        /// <summary>
        /// Get Licenses required for a set of permissions. 
        /// </summary>
        /// <param name="permission">Permission</param>
        /// <returns>Task of ApiResponse (List&lt;License&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<License>>> GetLicensesAsyncWithHttpInfo (List<string> permission = null)
        {
            
    
            var path_ = "/api/v1/licensing/licenses";
    
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
            
            if (permission != null) queryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetLicenses: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetLicenses: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<License>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<License>) Configuration.ApiClient.Deserialize(response, typeof(List<License>)));
            
        }
        
        /// <summary>
        /// Get org license assignments. 
        /// </summary>
        /// <returns>OrgLicenseAssignment</returns>
        public OrgLicenseAssignment GetOrgassignments ()
        {
             ApiResponse<OrgLicenseAssignment> response = GetOrgassignmentsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get org license assignments. 
        /// </summary>
        /// <returns>ApiResponse of OrgLicenseAssignment</returns>
        public ApiResponse< OrgLicenseAssignment > GetOrgassignmentsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/licensing/orgassignments";
    
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
                throw new ApiException (statusCode, "Error calling GetOrgassignments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrgassignments: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrgLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(OrgLicenseAssignment)));
            
        }
    
        /// <summary>
        /// Get org license assignments. 
        /// </summary>
        /// <returns>Task of OrgLicenseAssignment</returns>
        public async System.Threading.Tasks.Task<OrgLicenseAssignment> GetOrgassignmentsAsync ()
        {
             ApiResponse<OrgLicenseAssignment> response = await GetOrgassignmentsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get org license assignments. 
        /// </summary>
        /// <returns>Task of ApiResponse (OrgLicenseAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrgLicenseAssignment>> GetOrgassignmentsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/licensing/orgassignments";
    
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
                throw new ApiException (statusCode, "Error calling GetOrgassignments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrgassignments: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrgLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(OrgLicenseAssignment)));
            
        }
        
        /// <summary>
        /// Get org license assignment. 
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>OrgLicenseAssignment</returns>
        public OrgLicenseAssignment GetOrgassignmentsId (string id)
        {
             ApiResponse<OrgLicenseAssignment> response = GetOrgassignmentsIdWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Get org license assignment. 
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>ApiResponse of OrgLicenseAssignment</returns>
        public ApiResponse< OrgLicenseAssignment > GetOrgassignmentsIdWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LicensingApi->GetOrgassignmentsId");
            
    
            var path_ = "/api/v1/licensing/orgassignments/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetOrgassignmentsId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrgassignmentsId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrgLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(OrgLicenseAssignment)));
            
        }
    
        /// <summary>
        /// Get org license assignment. 
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of OrgLicenseAssignment</returns>
        public async System.Threading.Tasks.Task<OrgLicenseAssignment> GetOrgassignmentsIdAsync (string id)
        {
             ApiResponse<OrgLicenseAssignment> response = await GetOrgassignmentsIdAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Get org license assignment. 
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (OrgLicenseAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrgLicenseAssignment>> GetOrgassignmentsIdAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetOrgassignmentsId");
            
    
            var path_ = "/api/v1/licensing/orgassignments/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetOrgassignmentsId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrgassignmentsId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrgLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(OrgLicenseAssignment)));
            
        }
        
        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>List&lt;LicensesByPermission&gt;</returns>
        public List<LicensesByPermission> GetPermissions (List<string> id = null)
        {
             ApiResponse<List<LicensesByPermission>> response = GetPermissionsWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>ApiResponse of List&lt;LicensesByPermission&gt;</returns>
        public ApiResponse< List<LicensesByPermission> > GetPermissionsWithHttpInfo (List<string> id = null)
        {
            
    
            var path_ = "/api/v1/licensing/permissions";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetPermissions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPermissions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<LicensesByPermission>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LicensesByPermission>) Configuration.ApiClient.Deserialize(response, typeof(List<LicensesByPermission>)));
            
        }
    
        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of List&lt;LicensesByPermission&gt;</returns>
        public async System.Threading.Tasks.Task<List<LicensesByPermission>> GetPermissionsAsync (List<string> id = null)
        {
             ApiResponse<List<LicensesByPermission>> response = await GetPermissionsAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (List&lt;LicensesByPermission&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LicensesByPermission>>> GetPermissionsAsyncWithHttpInfo (List<string> id = null)
        {
            
    
            var path_ = "/api/v1/licensing/permissions";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetPermissions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPermissions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<LicensesByPermission>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LicensesByPermission>) Configuration.ApiClient.Deserialize(response, typeof(List<LicensesByPermission>)));
            
        }
        
        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="body">The permissions details</param> 
        /// <returns>List&lt;LicensesByPermission&gt;</returns>
        public List<LicensesByPermission> PostPermissions (List<string> id = null, Permissions body = null)
        {
             ApiResponse<List<LicensesByPermission>> response = PostPermissionsWithHttpInfo(id, body);
             return response.Data;
        }

        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="body">The permissions details</param> 
        /// <returns>ApiResponse of List&lt;LicensesByPermission&gt;</returns>
        public ApiResponse< List<LicensesByPermission> > PostPermissionsWithHttpInfo (List<string> id = null, Permissions body = null)
        {
            
    
            var path_ = "/api/v1/licensing/permissions";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
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
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostPermissions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostPermissions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<LicensesByPermission>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LicensesByPermission>) Configuration.ApiClient.Deserialize(response, typeof(List<LicensesByPermission>)));
            
        }
    
        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="body">The permissions details</param>
        /// <returns>Task of List&lt;LicensesByPermission&gt;</returns>
        public async System.Threading.Tasks.Task<List<LicensesByPermission>> PostPermissionsAsync (List<string> id = null, Permissions body = null)
        {
             ApiResponse<List<LicensesByPermission>> response = await PostPermissionsAsyncWithHttpInfo(id, body);
             return response.Data;

        }

        /// <summary>
        /// Get Licenses required per permission. 
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="body">The permissions details</param>
        /// <returns>Task of ApiResponse (List&lt;LicensesByPermission&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LicensesByPermission>>> PostPermissionsAsyncWithHttpInfo (List<string> id = null, Permissions body = null)
        {
            
    
            var path_ = "/api/v1/licensing/permissions";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostPermissions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostPermissions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<LicensesByPermission>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LicensesByPermission>) Configuration.ApiClient.Deserialize(response, typeof(List<LicensesByPermission>)));
            
        }
        
        /// <summary>
        /// Get user license assignments. 
        /// </summary>
        /// <returns>UserLicenseAssignment</returns>
        public UserLicenseAssignment GetUserassignments ()
        {
             ApiResponse<UserLicenseAssignment> response = GetUserassignmentsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get user license assignments. 
        /// </summary>
        /// <returns>ApiResponse of UserLicenseAssignment</returns>
        public ApiResponse< UserLicenseAssignment > GetUserassignmentsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/licensing/userassignments";
    
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
                throw new ApiException (statusCode, "Error calling GetUserassignments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserassignments: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(UserLicenseAssignment)));
            
        }
    
        /// <summary>
        /// Get user license assignments. 
        /// </summary>
        /// <returns>Task of UserLicenseAssignment</returns>
        public async System.Threading.Tasks.Task<UserLicenseAssignment> GetUserassignmentsAsync ()
        {
             ApiResponse<UserLicenseAssignment> response = await GetUserassignmentsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get user license assignments. 
        /// </summary>
        /// <returns>Task of ApiResponse (UserLicenseAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserLicenseAssignment>> GetUserassignmentsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/licensing/userassignments";
    
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
                throw new ApiException (statusCode, "Error calling GetUserassignments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserassignments: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(UserLicenseAssignment)));
            
        }
        
        /// <summary>
        /// Get user license assignment. 
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>UserLicenseAssignment</returns>
        public UserLicenseAssignment GetUserassignmentsId (string id)
        {
             ApiResponse<UserLicenseAssignment> response = GetUserassignmentsIdWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Get user license assignment. 
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>ApiResponse of UserLicenseAssignment</returns>
        public ApiResponse< UserLicenseAssignment > GetUserassignmentsIdWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LicensingApi->GetUserassignmentsId");
            
    
            var path_ = "/api/v1/licensing/userassignments/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetUserassignmentsId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserassignmentsId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(UserLicenseAssignment)));
            
        }
    
        /// <summary>
        /// Get user license assignment. 
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of UserLicenseAssignment</returns>
        public async System.Threading.Tasks.Task<UserLicenseAssignment> GetUserassignmentsIdAsync (string id)
        {
             ApiResponse<UserLicenseAssignment> response = await GetUserassignmentsIdAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Get user license assignment. 
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (UserLicenseAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserLicenseAssignment>> GetUserassignmentsIdAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserassignmentsId");
            
    
            var path_ = "/api/v1/licensing/userassignments/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetUserassignmentsId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserassignmentsId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserLicenseAssignment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserLicenseAssignment) Configuration.ApiClient.Deserialize(response, typeof(UserLicenseAssignment)));
            
        }
        
    }
    
}
