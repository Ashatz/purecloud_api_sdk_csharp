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
    public interface IFaxApi
    {
        
        /// <summary>
        /// Get a list of fax documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>FaxDocumentEntityListing</returns>
        FaxDocumentEntityListing FaxDocumentsGet (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get a list of fax documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of FaxDocumentEntityListing</returns>
        ApiResponse<FaxDocumentEntityListing> FaxDocumentsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of fax documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of FaxDocumentEntityListing</returns>
        System.Threading.Tasks.Task<FaxDocumentEntityListing> FaxDocumentsGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of fax documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (FaxDocumentEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxDocumentEntityListing>> FaxDocumentsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>FaxDocument</returns>
        FaxDocument FaxDocumentsDocumentidGet (string documentId);
  
        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>ApiResponse of FaxDocument</returns>
        ApiResponse<FaxDocument> FaxDocumentsDocumentidGetWithHttpInfo (string documentId);

        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of FaxDocument</returns>
        System.Threading.Tasks.Task<FaxDocument> FaxDocumentsDocumentidGetAsync (string documentId);

        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse (FaxDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxDocument>> FaxDocumentsDocumentidGetAsyncWithHttpInfo (string documentId);
        
        /// <summary>
        /// Update a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <returns>FaxDocument</returns>
        FaxDocument FaxDocumentsDocumentidPut (string documentId, FaxDocument body = null);
  
        /// <summary>
        /// Update a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <returns>ApiResponse of FaxDocument</returns>
        ApiResponse<FaxDocument> FaxDocumentsDocumentidPutWithHttpInfo (string documentId, FaxDocument body = null);

        /// <summary>
        /// Update a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <returns>Task of FaxDocument</returns>
        System.Threading.Tasks.Task<FaxDocument> FaxDocumentsDocumentidPutAsync (string documentId, FaxDocument body = null);

        /// <summary>
        /// Update a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <returns>Task of ApiResponse (FaxDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxDocument>> FaxDocumentsDocumentidPutAsyncWithHttpInfo (string documentId, FaxDocument body = null);
        
        /// <summary>
        /// Delete a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns></returns>
        void FaxDocumentsDocumentidDelete (string documentId);
  
        /// <summary>
        /// Delete a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> FaxDocumentsDocumentidDeleteWithHttpInfo (string documentId);

        /// <summary>
        /// Delete a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task FaxDocumentsDocumentidDeleteAsync (string documentId);

        /// <summary>
        /// Delete a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> FaxDocumentsDocumentidDeleteAsyncWithHttpInfo (string documentId);
        
        /// <summary>
        /// Download a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>DownloadResponse</returns>
        DownloadResponse FaxDocumentsDocumentidContentGet (string documentId);
  
        /// <summary>
        /// Download a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>ApiResponse of DownloadResponse</returns>
        ApiResponse<DownloadResponse> FaxDocumentsDocumentidContentGetWithHttpInfo (string documentId);

        /// <summary>
        /// Download a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of DownloadResponse</returns>
        System.Threading.Tasks.Task<DownloadResponse> FaxDocumentsDocumentidContentGetAsync (string documentId);

        /// <summary>
        /// Download a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> FaxDocumentsDocumentidContentGetAsyncWithHttpInfo (string documentId);
        
        /// <summary>
        /// Get fax summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>FaxSummary</returns>
        FaxSummary FaxSummaryGet ();
  
        /// <summary>
        /// Get fax summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of FaxSummary</returns>
        ApiResponse<FaxSummary> FaxSummaryGetWithHttpInfo ();

        /// <summary>
        /// Get fax summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of FaxSummary</returns>
        System.Threading.Tasks.Task<FaxSummary> FaxSummaryGetAsync ();

        /// <summary>
        /// Get fax summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (FaxSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxSummary>> FaxSummaryGetAsyncWithHttpInfo ();
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FaxApi : IFaxApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaxApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FaxApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FaxApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FaxApi(Configuration configuration = null)
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
        /// Get a list of fax documents. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>FaxDocumentEntityListing</returns>
        public FaxDocumentEntityListing FaxDocumentsGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<FaxDocumentEntityListing> response = FaxDocumentsGetWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a list of fax documents. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of FaxDocumentEntityListing</returns>
        public ApiResponse< FaxDocumentEntityListing > FaxDocumentsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/fax/documents";
    
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
                throw new ApiException (statusCode, "Error calling FaxDocumentsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FaxDocumentsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FaxDocumentEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocumentEntityListing) Configuration.ApiClient.Deserialize(response, typeof(FaxDocumentEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of fax documents. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of FaxDocumentEntityListing</returns>
        public async System.Threading.Tasks.Task<FaxDocumentEntityListing> FaxDocumentsGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<FaxDocumentEntityListing> response = await FaxDocumentsGetAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a list of fax documents. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (FaxDocumentEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxDocumentEntityListing>> FaxDocumentsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/fax/documents";
    
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
                throw new ApiException (statusCode, "Error calling FaxDocumentsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FaxDocumentsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FaxDocumentEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocumentEntityListing) Configuration.ApiClient.Deserialize(response, typeof(FaxDocumentEntityListing)));
            
        }
        
        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <returns>FaxDocument</returns>
        public FaxDocument FaxDocumentsDocumentidGet (string documentId)
        {
             ApiResponse<FaxDocument> response = FaxDocumentsDocumentidGetWithHttpInfo(documentId);
             return response.Data;
        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <returns>ApiResponse of FaxDocument</returns>
        public ApiResponse< FaxDocument > FaxDocumentsDocumentidGetWithHttpInfo (string documentId)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxDocumentsDocumentidGet");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FaxDocument>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocument) Configuration.ApiClient.Deserialize(response, typeof(FaxDocument)));
            
        }
    
        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of FaxDocument</returns>
        public async System.Threading.Tasks.Task<FaxDocument> FaxDocumentsDocumentidGetAsync (string documentId)
        {
             ApiResponse<FaxDocument> response = await FaxDocumentsDocumentidGetAsyncWithHttpInfo(documentId);
             return response.Data;

        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse (FaxDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxDocument>> FaxDocumentsDocumentidGetAsyncWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxDocumentsDocumentidGet");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FaxDocument>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocument) Configuration.ApiClient.Deserialize(response, typeof(FaxDocument)));
            
        }
        
        /// <summary>
        /// Update a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="body">Document</param> 
        /// <returns>FaxDocument</returns>
        public FaxDocument FaxDocumentsDocumentidPut (string documentId, FaxDocument body = null)
        {
             ApiResponse<FaxDocument> response = FaxDocumentsDocumentidPutWithHttpInfo(documentId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="body">Document</param> 
        /// <returns>ApiResponse of FaxDocument</returns>
        public ApiResponse< FaxDocument > FaxDocumentsDocumentidPutWithHttpInfo (string documentId, FaxDocument body = null)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxDocumentsDocumentidPut");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FaxDocument>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocument) Configuration.ApiClient.Deserialize(response, typeof(FaxDocument)));
            
        }
    
        /// <summary>
        /// Update a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <returns>Task of FaxDocument</returns>
        public async System.Threading.Tasks.Task<FaxDocument> FaxDocumentsDocumentidPutAsync (string documentId, FaxDocument body = null)
        {
             ApiResponse<FaxDocument> response = await FaxDocumentsDocumentidPutAsyncWithHttpInfo(documentId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <returns>Task of ApiResponse (FaxDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxDocument>> FaxDocumentsDocumentidPutAsyncWithHttpInfo (string documentId, FaxDocument body = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxDocumentsDocumentidPut");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FaxDocument>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocument) Configuration.ApiClient.Deserialize(response, typeof(FaxDocument)));
            
        }
        
        /// <summary>
        /// Delete a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <returns></returns>
        public void FaxDocumentsDocumentidDelete (string documentId)
        {
             FaxDocumentsDocumentidDeleteWithHttpInfo(documentId);
        }

        /// <summary>
        /// Delete a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> FaxDocumentsDocumentidDeleteWithHttpInfo (string documentId)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxDocumentsDocumentidDelete");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task FaxDocumentsDocumentidDeleteAsync (string documentId)
        {
             await FaxDocumentsDocumentidDeleteAsyncWithHttpInfo(documentId);

        }

        /// <summary>
        /// Delete a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> FaxDocumentsDocumentidDeleteAsyncWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxDocumentsDocumentidDelete");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Download a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <returns>DownloadResponse</returns>
        public DownloadResponse FaxDocumentsDocumentidContentGet (string documentId)
        {
             ApiResponse<DownloadResponse> response = FaxDocumentsDocumentidContentGetWithHttpInfo(documentId);
             return response.Data;
        }

        /// <summary>
        /// Download a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <returns>ApiResponse of DownloadResponse</returns>
        public ApiResponse< DownloadResponse > FaxDocumentsDocumentidContentGetWithHttpInfo (string documentId)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxDocumentsDocumentidContentGet");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}/content";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidContentGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidContentGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DownloadResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(response, typeof(DownloadResponse)));
            
        }
    
        /// <summary>
        /// Download a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of DownloadResponse</returns>
        public async System.Threading.Tasks.Task<DownloadResponse> FaxDocumentsDocumentidContentGetAsync (string documentId)
        {
             ApiResponse<DownloadResponse> response = await FaxDocumentsDocumentidContentGetAsyncWithHttpInfo(documentId);
             return response.Data;

        }

        /// <summary>
        /// Download a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> FaxDocumentsDocumentidContentGetAsyncWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxDocumentsDocumentidContentGet");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}/content";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidContentGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FaxDocumentsDocumentidContentGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DownloadResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(response, typeof(DownloadResponse)));
            
        }
        
        /// <summary>
        /// Get fax summary 
        /// </summary>
        /// <returns>FaxSummary</returns>
        public FaxSummary FaxSummaryGet ()
        {
             ApiResponse<FaxSummary> response = FaxSummaryGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get fax summary 
        /// </summary>
        /// <returns>ApiResponse of FaxSummary</returns>
        public ApiResponse< FaxSummary > FaxSummaryGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/fax/summary";
    
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
                throw new ApiException (statusCode, "Error calling FaxSummaryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FaxSummaryGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FaxSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSummary) Configuration.ApiClient.Deserialize(response, typeof(FaxSummary)));
            
        }
    
        /// <summary>
        /// Get fax summary 
        /// </summary>
        /// <returns>Task of FaxSummary</returns>
        public async System.Threading.Tasks.Task<FaxSummary> FaxSummaryGetAsync ()
        {
             ApiResponse<FaxSummary> response = await FaxSummaryGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get fax summary 
        /// </summary>
        /// <returns>Task of ApiResponse (FaxSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxSummary>> FaxSummaryGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/fax/summary";
    
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
                throw new ApiException (statusCode, "Error calling FaxSummaryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FaxSummaryGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FaxSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSummary) Configuration.ApiClient.Deserialize(response, typeof(FaxSummary)));
            
        }
        
    }
    
}
