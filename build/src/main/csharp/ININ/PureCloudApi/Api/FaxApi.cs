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
        FaxDocumentEntityListing GetDocuments (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get a list of fax documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of FaxDocumentEntityListing</returns>
        ApiResponse<FaxDocumentEntityListing> GetDocumentsWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of fax documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of FaxDocumentEntityListing</returns>
        System.Threading.Tasks.Task<FaxDocumentEntityListing> GetDocumentsAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of fax documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (FaxDocumentEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxDocumentEntityListing>> GetDocumentsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>FaxDocument</returns>
        FaxDocument GetDocument (string documentId);
  
        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>ApiResponse of FaxDocument</returns>
        ApiResponse<FaxDocument> GetDocumentWithHttpInfo (string documentId);

        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of FaxDocument</returns>
        System.Threading.Tasks.Task<FaxDocument> GetDocumentAsync (string documentId);

        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse (FaxDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxDocument>> GetDocumentAsyncWithHttpInfo (string documentId);
        
        /// <summary>
        /// Update a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <returns>FaxDocument</returns>
        FaxDocument PutDocument (string documentId, FaxDocument body = null);
  
        /// <summary>
        /// Update a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <returns>ApiResponse of FaxDocument</returns>
        ApiResponse<FaxDocument> PutDocumentWithHttpInfo (string documentId, FaxDocument body = null);

        /// <summary>
        /// Update a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <returns>Task of FaxDocument</returns>
        System.Threading.Tasks.Task<FaxDocument> PutDocumentAsync (string documentId, FaxDocument body = null);

        /// <summary>
        /// Update a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <returns>Task of ApiResponse (FaxDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxDocument>> PutDocumentAsyncWithHttpInfo (string documentId, FaxDocument body = null);
        
        /// <summary>
        /// Delete a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns></returns>
        void DeleteDocument (string documentId);
  
        /// <summary>
        /// Delete a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteDocumentWithHttpInfo (string documentId);

        /// <summary>
        /// Delete a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteDocumentAsync (string documentId);

        /// <summary>
        /// Delete a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDocumentAsyncWithHttpInfo (string documentId);
        
        /// <summary>
        /// Download a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>DownloadResponse</returns>
        DownloadResponse GetDocumentContent (string documentId);
  
        /// <summary>
        /// Download a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>ApiResponse of DownloadResponse</returns>
        ApiResponse<DownloadResponse> GetDocumentContentWithHttpInfo (string documentId);

        /// <summary>
        /// Download a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of DownloadResponse</returns>
        System.Threading.Tasks.Task<DownloadResponse> GetDocumentContentAsync (string documentId);

        /// <summary>
        /// Download a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> GetDocumentContentAsyncWithHttpInfo (string documentId);
        
        /// <summary>
        /// Get fax summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>FaxSummary</returns>
        FaxSummary GetSummary ();
  
        /// <summary>
        /// Get fax summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of FaxSummary</returns>
        ApiResponse<FaxSummary> GetSummaryWithHttpInfo ();

        /// <summary>
        /// Get fax summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of FaxSummary</returns>
        System.Threading.Tasks.Task<FaxSummary> GetSummaryAsync ();

        /// <summary>
        /// Get fax summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (FaxSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxSummary>> GetSummaryAsyncWithHttpInfo ();
        
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
        public FaxDocumentEntityListing GetDocuments (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<FaxDocumentEntityListing> response = GetDocumentsWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a list of fax documents. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of FaxDocumentEntityListing</returns>
        public ApiResponse< FaxDocumentEntityListing > GetDocumentsWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/fax/documents";
    
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
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<FaxDocumentEntityListing> GetDocumentsAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<FaxDocumentEntityListing> response = await GetDocumentsAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a list of fax documents. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (FaxDocumentEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxDocumentEntityListing>> GetDocumentsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/fax/documents";
    
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
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FaxDocumentEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocumentEntityListing) Configuration.ApiClient.Deserialize(response, typeof(FaxDocumentEntityListing)));
            
        }
        
        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <returns>FaxDocument</returns>
        public FaxDocument GetDocument (string documentId)
        {
             ApiResponse<FaxDocument> response = GetDocumentWithHttpInfo(documentId);
             return response.Data;
        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <returns>ApiResponse of FaxDocument</returns>
        public ApiResponse< FaxDocument > GetDocumentWithHttpInfo (string documentId)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->GetDocument");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetDocument: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FaxDocument>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocument) Configuration.ApiClient.Deserialize(response, typeof(FaxDocument)));
            
        }
    
        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of FaxDocument</returns>
        public async System.Threading.Tasks.Task<FaxDocument> GetDocumentAsync (string documentId)
        {
             ApiResponse<FaxDocument> response = await GetDocumentAsyncWithHttpInfo(documentId);
             return response.Data;

        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse (FaxDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxDocument>> GetDocumentAsyncWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocument");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetDocument: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocument: " + response.ErrorMessage, response.ErrorMessage);

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
        public FaxDocument PutDocument (string documentId, FaxDocument body = null)
        {
             ApiResponse<FaxDocument> response = PutDocumentWithHttpInfo(documentId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="body">Document</param> 
        /// <returns>ApiResponse of FaxDocument</returns>
        public ApiResponse< FaxDocument > PutDocumentWithHttpInfo (string documentId, FaxDocument body = null)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->PutDocument");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
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
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutDocument: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutDocument: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<FaxDocument> PutDocumentAsync (string documentId, FaxDocument body = null)
        {
             ApiResponse<FaxDocument> response = await PutDocumentAsyncWithHttpInfo(documentId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <returns>Task of ApiResponse (FaxDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxDocument>> PutDocumentAsyncWithHttpInfo (string documentId, FaxDocument body = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling PutDocument");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutDocument: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutDocument: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FaxDocument>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocument) Configuration.ApiClient.Deserialize(response, typeof(FaxDocument)));
            
        }
        
        /// <summary>
        /// Delete a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <returns></returns>
        public void DeleteDocument (string documentId)
        {
             DeleteDocumentWithHttpInfo(documentId);
        }

        /// <summary>
        /// Delete a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteDocumentWithHttpInfo (string documentId)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->DeleteDocument");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteDocument: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteDocumentAsync (string documentId)
        {
             await DeleteDocumentAsyncWithHttpInfo(documentId);

        }

        /// <summary>
        /// Delete a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDocumentAsyncWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling DeleteDocument");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteDocument: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDocument: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Download a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <returns>DownloadResponse</returns>
        public DownloadResponse GetDocumentContent (string documentId)
        {
             ApiResponse<DownloadResponse> response = GetDocumentContentWithHttpInfo(documentId);
             return response.Data;
        }

        /// <summary>
        /// Download a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <returns>ApiResponse of DownloadResponse</returns>
        public ApiResponse< DownloadResponse > GetDocumentContentWithHttpInfo (string documentId)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->GetDocumentContent");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}/content";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetDocumentContent: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocumentContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DownloadResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(response, typeof(DownloadResponse)));
            
        }
    
        /// <summary>
        /// Download a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of DownloadResponse</returns>
        public async System.Threading.Tasks.Task<DownloadResponse> GetDocumentContentAsync (string documentId)
        {
             ApiResponse<DownloadResponse> response = await GetDocumentContentAsyncWithHttpInfo(documentId);
             return response.Data;

        }

        /// <summary>
        /// Download a fax document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> GetDocumentContentAsyncWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocumentContent");
            
    
            var path_ = "/api/v1/fax/documents/{documentId}/content";
    
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
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetDocumentContent: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocumentContent: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DownloadResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(response, typeof(DownloadResponse)));
            
        }
        
        /// <summary>
        /// Get fax summary 
        /// </summary>
        /// <returns>FaxSummary</returns>
        public FaxSummary GetSummary ()
        {
             ApiResponse<FaxSummary> response = GetSummaryWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get fax summary 
        /// </summary>
        /// <returns>ApiResponse of FaxSummary</returns>
        public ApiResponse< FaxSummary > GetSummaryWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/fax/summary";
    
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
                throw new ApiException (statusCode, "Error calling GetSummary: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSummary: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FaxSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSummary) Configuration.ApiClient.Deserialize(response, typeof(FaxSummary)));
            
        }
    
        /// <summary>
        /// Get fax summary 
        /// </summary>
        /// <returns>Task of FaxSummary</returns>
        public async System.Threading.Tasks.Task<FaxSummary> GetSummaryAsync ()
        {
             ApiResponse<FaxSummary> response = await GetSummaryAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get fax summary 
        /// </summary>
        /// <returns>Task of ApiResponse (FaxSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxSummary>> GetSummaryAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/fax/summary";
    
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
                throw new ApiException (statusCode, "Error calling GetSummary: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSummary: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FaxSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSummary) Configuration.ApiClient.Deserialize(response, typeof(FaxSummary)));
            
        }
        
    }
    
}
