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
    public interface IFaxApi
    {
        #region Synchronous Operations
        /// <summary>
<<<<<<< HEAD
        /// Download a fax document.
=======
        /// Delete a fax document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
<<<<<<< HEAD
        /// <returns>DownloadResponse</returns>
        DownloadResponse FaxDocumentsDocumentidContentGet (string documentId);

        /// <summary>
        /// Download a fax document.
=======
        /// <returns></returns>
        void DeleteDocumentsDocumentId (string documentId);

        /// <summary>
        /// Delete a fax document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
<<<<<<< HEAD
        /// <returns>ApiResponse of DownloadResponse</returns>
        ApiResponse<DownloadResponse> FaxDocumentsDocumentidContentGetWithHttpInfo (string documentId);
=======
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteDocumentsDocumentIdWithHttpInfo (string documentId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Delete a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <returns></returns>
        void FaxDocumentsDocumentidDelete (string documentId);
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>FaxDocumentEntityListing</returns>
        FaxDocumentEntityListing GetDocuments (int? pageSize = null, int? pageNumber = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Delete a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> FaxDocumentsDocumentidDeleteWithHttpInfo (string documentId);
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of FaxDocumentEntityListing</returns>
        ApiResponse<FaxDocumentEntityListing> GetDocumentsWithHttpInfo (int? pageSize = null, int? pageNumber = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>FaxDocument</returns>
<<<<<<< HEAD
        FaxDocument FaxDocumentsDocumentidGet (string documentId);
=======
        FaxDocument GetDocumentsDocumentId (string documentId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>ApiResponse of FaxDocument</returns>
<<<<<<< HEAD
        ApiResponse<FaxDocument> FaxDocumentsDocumentidGetWithHttpInfo (string documentId);
        /// <summary>
        /// Update a fax document.
=======
        ApiResponse<FaxDocument> GetDocumentsDocumentIdWithHttpInfo (string documentId);
        /// <summary>
        /// Download a fax document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
<<<<<<< HEAD
        /// <param name="body">Document (optional)</param>
        /// <returns>FaxDocument</returns>
        FaxDocument FaxDocumentsDocumentidPut (string documentId, FaxDocument body = null);

        /// <summary>
        /// Update a fax document.
=======
        /// <returns>DownloadResponse</returns>
        DownloadResponse GetDocumentsDocumentIdContent (string documentId);

        /// <summary>
        /// Download a fax document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
<<<<<<< HEAD
        /// <param name="body">Document (optional)</param>
        /// <returns>ApiResponse of FaxDocument</returns>
        ApiResponse<FaxDocument> FaxDocumentsDocumentidPutWithHttpInfo (string documentId, FaxDocument body = null);
        /// <summary>
        /// Get a list of fax documents.
=======
        /// <returns>ApiResponse of DownloadResponse</returns>
        ApiResponse<DownloadResponse> GetDocumentsDocumentIdContentWithHttpInfo (string documentId);
        /// <summary>
        /// Get fax summary
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>FaxDocumentEntityListing</returns>
        FaxDocumentEntityListing FaxDocumentsGet (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of fax documents.
=======
        /// <returns>FaxSummary</returns>
        FaxSummary GetSummary ();

        /// <summary>
        /// Get fax summary
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of FaxDocumentEntityListing</returns>
        ApiResponse<FaxDocumentEntityListing> FaxDocumentsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);
=======
        /// <returns>ApiResponse of FaxSummary</returns>
        ApiResponse<FaxSummary> GetSummaryWithHttpInfo ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get fax summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>FaxSummary</returns>
        FaxSummary FaxSummaryGet ();
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <returns>FaxDocument</returns>
        FaxDocument PutDocumentsDocumentId (string documentId, FaxDocument body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get fax summary
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of FaxSummary</returns>
        ApiResponse<FaxSummary> FaxSummaryGetWithHttpInfo ();
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <returns>ApiResponse of FaxDocument</returns>
        ApiResponse<FaxDocument> PutDocumentsDocumentIdWithHttpInfo (string documentId, FaxDocument body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Download a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
<<<<<<< HEAD
        /// <returns>Task of DownloadResponse</returns>
        System.Threading.Tasks.Task<DownloadResponse> FaxDocumentsDocumentidContentGetAsync (string documentId);
=======
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteDocumentsDocumentIdAsync (string documentId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Download a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> FaxDocumentsDocumentidContentGetAsyncWithHttpInfo (string documentId);
=======
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDocumentsDocumentIdAsyncWithHttpInfo (string documentId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get a list of fax documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task FaxDocumentsDocumentidDeleteAsync (string documentId);
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of FaxDocumentEntityListing</returns>
        System.Threading.Tasks.Task<FaxDocumentEntityListing> GetDocumentsAsync (int? pageSize = null, int? pageNumber = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get a list of fax documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> FaxDocumentsDocumentidDeleteAsyncWithHttpInfo (string documentId);
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (FaxDocumentEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxDocumentEntityListing>> GetDocumentsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of FaxDocument</returns>
<<<<<<< HEAD
        System.Threading.Tasks.Task<FaxDocument> FaxDocumentsDocumentidGetAsync (string documentId);
=======
        System.Threading.Tasks.Task<FaxDocument> GetDocumentsDocumentIdAsync (string documentId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse (FaxDocument)</returns>
<<<<<<< HEAD
        System.Threading.Tasks.Task<ApiResponse<FaxDocument>> FaxDocumentsDocumentidGetAsyncWithHttpInfo (string documentId);
=======
        System.Threading.Tasks.Task<ApiResponse<FaxDocument>> GetDocumentsDocumentIdAsyncWithHttpInfo (string documentId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Update a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
<<<<<<< HEAD
        /// <param name="body">Document (optional)</param>
        /// <returns>Task of FaxDocument</returns>
        System.Threading.Tasks.Task<FaxDocument> FaxDocumentsDocumentidPutAsync (string documentId, FaxDocument body = null);
=======
        /// <returns>Task of DownloadResponse</returns>
        System.Threading.Tasks.Task<DownloadResponse> GetDocumentsDocumentIdContentAsync (string documentId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Update a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
<<<<<<< HEAD
        /// <param name="body">Document (optional)</param>
        /// <returns>Task of ApiResponse (FaxDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxDocument>> FaxDocumentsDocumentidPutAsyncWithHttpInfo (string documentId, FaxDocument body = null);
=======
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> GetDocumentsDocumentIdContentAsyncWithHttpInfo (string documentId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get a list of fax documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of FaxDocumentEntityListing</returns>
        System.Threading.Tasks.Task<FaxDocumentEntityListing> FaxDocumentsGetAsync (int? pageSize = null, int? pageNumber = null);
=======
        /// <returns>Task of FaxSummary</returns>
        System.Threading.Tasks.Task<FaxSummary> GetSummaryAsync ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get a list of fax documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (FaxDocumentEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxDocumentEntityListing>> FaxDocumentsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
=======
        /// <returns>Task of ApiResponse (FaxSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxSummary>> GetSummaryAsyncWithHttpInfo ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Update a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of FaxSummary</returns>
        System.Threading.Tasks.Task<FaxSummary> FaxSummaryGetAsync ();
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <returns>Task of FaxDocument</returns>
        System.Threading.Tasks.Task<FaxDocument> PutDocumentsDocumentIdAsync (string documentId, FaxDocument body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Update a fax document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (FaxSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxSummary>> FaxSummaryGetAsyncWithHttpInfo ();
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <returns>Task of ApiResponse (FaxDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxDocument>> PutDocumentsDocumentIdAsyncWithHttpInfo (string documentId, FaxDocument body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        #endregion Asynchronous Operations
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

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
<<<<<<< HEAD
        /// Download a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>DownloadResponse</returns>
        public DownloadResponse FaxDocumentsDocumentidContentGet (string documentId)
        {
             ApiResponse<DownloadResponse> localVarResponse = FaxDocumentsDocumentidContentGetWithHttpInfo(documentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Download a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>ApiResponse of DownloadResponse</returns>
        public ApiResponse< DownloadResponse > FaxDocumentsDocumentidContentGetWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->FaxDocumentsDocumentidContentGet");

            var localVarPath = "/api/v1/fax/documents/{documentId}/content";
=======
        /// Delete a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns></returns>
        public void DeleteDocumentsDocumentId (string documentId)
        {
             DeleteDocumentsDocumentIdWithHttpInfo(documentId);
        }

        /// <summary>
        /// Delete a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteDocumentsDocumentIdWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->DeleteDocumentsDocumentId");

            var localVarPath = "/api/v2/fax/documents/{documentId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidContentGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidContentGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DownloadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DownloadResponse)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Download a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of DownloadResponse</returns>
        public async System.Threading.Tasks.Task<DownloadResponse> FaxDocumentsDocumentidContentGetAsync (string documentId)
        {
             ApiResponse<DownloadResponse> localVarResponse = await FaxDocumentsDocumentidContentGetAsyncWithHttpInfo(documentId);
             return localVarResponse.Data;
=======
        /// Delete a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteDocumentsDocumentIdAsync (string documentId)
        {
             await DeleteDocumentsDocumentIdAsyncWithHttpInfo(documentId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
        /// Download a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> FaxDocumentsDocumentidContentGetAsyncWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->FaxDocumentsDocumentidContentGet");

            var localVarPath = "/api/v1/fax/documents/{documentId}/content";
=======
        /// Delete a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDocumentsDocumentIdAsyncWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->DeleteDocumentsDocumentId");

            var localVarPath = "/api/v2/fax/documents/{documentId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidContentGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidContentGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DownloadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DownloadResponse)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns></returns>
        public void FaxDocumentsDocumentidDelete (string documentId)
        {
             FaxDocumentsDocumentidDeleteWithHttpInfo(documentId);
        }

        /// <summary>
        /// Delete a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> FaxDocumentsDocumentidDeleteWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->FaxDocumentsDocumentidDelete");

            var localVarPath = "/api/v1/fax/documents/{documentId}";
=======
        /// Get a list of fax documents. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>FaxDocumentEntityListing</returns>
        public FaxDocumentEntityListing GetDocuments (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<FaxDocumentEntityListing> localVarResponse = GetDocumentsWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of fax documents. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of FaxDocumentEntityListing</returns>
        public ApiResponse< FaxDocumentEntityListing > GetDocumentsWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/fax/documents";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling GetDocuments: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxDocumentEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocumentEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocumentEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task FaxDocumentsDocumentidDeleteAsync (string documentId)
        {
             await FaxDocumentsDocumentidDeleteAsyncWithHttpInfo(documentId);
=======
        /// Get a list of fax documents. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of FaxDocumentEntityListing</returns>
        public async System.Threading.Tasks.Task<FaxDocumentEntityListing> GetDocumentsAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<FaxDocumentEntityListing> localVarResponse = await GetDocumentsAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> FaxDocumentsDocumentidDeleteAsyncWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->FaxDocumentsDocumentidDelete");

            var localVarPath = "/api/v1/fax/documents/{documentId}";
=======
        /// Get a list of fax documents. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (FaxDocumentEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxDocumentEntityListing>> GetDocumentsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/fax/documents";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling GetDocuments: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxDocumentEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocumentEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocumentEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>FaxDocument</returns>
<<<<<<< HEAD
        public FaxDocument FaxDocumentsDocumentidGet (string documentId)
        {
             ApiResponse<FaxDocument> localVarResponse = FaxDocumentsDocumentidGetWithHttpInfo(documentId);
=======
        public FaxDocument GetDocumentsDocumentId (string documentId)
        {
             ApiResponse<FaxDocument> localVarResponse = GetDocumentsDocumentIdWithHttpInfo(documentId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>ApiResponse of FaxDocument</returns>
<<<<<<< HEAD
        public ApiResponse< FaxDocument > FaxDocumentsDocumentidGetWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->FaxDocumentsDocumentidGet");

            var localVarPath = "/api/v1/fax/documents/{documentId}";
=======
        public ApiResponse< FaxDocument > GetDocumentsDocumentIdWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->GetDocumentsDocumentId");

            var localVarPath = "/api/v2/fax/documents/{documentId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<FaxDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocument)));
            
        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of FaxDocument</returns>
<<<<<<< HEAD
        public async System.Threading.Tasks.Task<FaxDocument> FaxDocumentsDocumentidGetAsync (string documentId)
        {
             ApiResponse<FaxDocument> localVarResponse = await FaxDocumentsDocumentidGetAsyncWithHttpInfo(documentId);
=======
        public async System.Threading.Tasks.Task<FaxDocument> GetDocumentsDocumentIdAsync (string documentId)
        {
             ApiResponse<FaxDocument> localVarResponse = await GetDocumentsDocumentIdAsyncWithHttpInfo(documentId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse (FaxDocument)</returns>
<<<<<<< HEAD
        public async System.Threading.Tasks.Task<ApiResponse<FaxDocument>> FaxDocumentsDocumentidGetAsyncWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->FaxDocumentsDocumentidGet");

            var localVarPath = "/api/v1/fax/documents/{documentId}";
=======
        public async System.Threading.Tasks.Task<ApiResponse<FaxDocument>> GetDocumentsDocumentIdAsyncWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->GetDocumentsDocumentId");

            var localVarPath = "/api/v2/fax/documents/{documentId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<FaxDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocument)));
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <returns>FaxDocument</returns>
        public FaxDocument FaxDocumentsDocumentidPut (string documentId, FaxDocument body = null)
        {
             ApiResponse<FaxDocument> localVarResponse = FaxDocumentsDocumentidPutWithHttpInfo(documentId, body);
=======
        /// Download a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>DownloadResponse</returns>
        public DownloadResponse GetDocumentsDocumentIdContent (string documentId)
        {
             ApiResponse<DownloadResponse> localVarResponse = GetDocumentsDocumentIdContentWithHttpInfo(documentId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Update a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <returns>ApiResponse of FaxDocument</returns>
        public ApiResponse< FaxDocument > FaxDocumentsDocumentidPutWithHttpInfo (string documentId, FaxDocument body = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->FaxDocumentsDocumentidPut");

            var localVarPath = "/api/v1/fax/documents/{documentId}";
=======
        /// Download a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>ApiResponse of DownloadResponse</returns>
        public ApiResponse< DownloadResponse > GetDocumentsDocumentIdContentWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->GetDocumentsDocumentIdContent");

            var localVarPath = "/api/v2/fax/documents/{documentId}/content";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocument)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdContent: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdContent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DownloadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DownloadResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <returns>Task of FaxDocument</returns>
        public async System.Threading.Tasks.Task<FaxDocument> FaxDocumentsDocumentidPutAsync (string documentId, FaxDocument body = null)
        {
             ApiResponse<FaxDocument> localVarResponse = await FaxDocumentsDocumentidPutAsyncWithHttpInfo(documentId, body);
=======
        /// Download a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of DownloadResponse</returns>
        public async System.Threading.Tasks.Task<DownloadResponse> GetDocumentsDocumentIdContentAsync (string documentId)
        {
             ApiResponse<DownloadResponse> localVarResponse = await GetDocumentsDocumentIdContentAsyncWithHttpInfo(documentId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Update a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <returns>Task of ApiResponse (FaxDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxDocument>> FaxDocumentsDocumentidPutAsyncWithHttpInfo (string documentId, FaxDocument body = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->FaxDocumentsDocumentidPut");

            var localVarPath = "/api/v1/fax/documents/{documentId}";
=======
        /// Download a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> GetDocumentsDocumentIdContentAsyncWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->GetDocumentsDocumentIdContent");

            var localVarPath = "/api/v2/fax/documents/{documentId}/content";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsDocumentidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocument)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdContent: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdContent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DownloadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DownloadResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of fax documents. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>FaxDocumentEntityListing</returns>
        public FaxDocumentEntityListing FaxDocumentsGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<FaxDocumentEntityListing> localVarResponse = FaxDocumentsGetWithHttpInfo(pageSize, pageNumber);
=======
        /// Get fax summary 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>FaxSummary</returns>
        public FaxSummary GetSummary ()
        {
             ApiResponse<FaxSummary> localVarResponse = GetSummaryWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of fax documents. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of FaxDocumentEntityListing</returns>
        public ApiResponse< FaxDocumentEntityListing > FaxDocumentsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/fax/documents";
=======
        /// Get fax summary 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of FaxSummary</returns>
        public ApiResponse< FaxSummary > GetSummaryWithHttpInfo ()
        {

            var localVarPath = "/api/v2/fax/summary";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxDocumentEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocumentEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocumentEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetSummary: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSummary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSummary)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of fax documents. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of FaxDocumentEntityListing</returns>
        public async System.Threading.Tasks.Task<FaxDocumentEntityListing> FaxDocumentsGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<FaxDocumentEntityListing> localVarResponse = await FaxDocumentsGetAsyncWithHttpInfo(pageSize, pageNumber);
=======
        /// Get fax summary 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of FaxSummary</returns>
        public async System.Threading.Tasks.Task<FaxSummary> GetSummaryAsync ()
        {
             ApiResponse<FaxSummary> localVarResponse = await GetSummaryAsyncWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of fax documents. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (FaxDocumentEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxDocumentEntityListing>> FaxDocumentsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/fax/documents";
=======
        /// Get fax summary 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (FaxSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxSummary>> GetSummaryAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/fax/summary";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FaxDocumentsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxDocumentEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocumentEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocumentEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetSummary: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSummary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSummary)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>FaxSummary</returns>
        public FaxSummary FaxSummaryGet ()
        {
             ApiResponse<FaxSummary> localVarResponse = FaxSummaryGetWithHttpInfo();
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <returns>FaxDocument</returns>
        public FaxDocument PutDocumentsDocumentId (string documentId, FaxDocument body = null)
        {
             ApiResponse<FaxDocument> localVarResponse = PutDocumentsDocumentIdWithHttpInfo(documentId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of FaxSummary</returns>
        public ApiResponse< FaxSummary > FaxSummaryGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/fax/summary";
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <returns>ApiResponse of FaxDocument</returns>
        public ApiResponse< FaxDocument > PutDocumentsDocumentIdWithHttpInfo (string documentId, FaxDocument body = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->PutDocumentsDocumentId");

            var localVarPath = "/api/v2/fax/documents/{documentId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling FaxSummaryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FaxSummaryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSummary)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocument)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of FaxSummary</returns>
        public async System.Threading.Tasks.Task<FaxSummary> FaxSummaryGetAsync ()
        {
             ApiResponse<FaxSummary> localVarResponse = await FaxSummaryGetAsyncWithHttpInfo();
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <returns>Task of FaxDocument</returns>
        public async System.Threading.Tasks.Task<FaxDocument> PutDocumentsDocumentIdAsync (string documentId, FaxDocument body = null)
        {
             ApiResponse<FaxDocument> localVarResponse = await PutDocumentsDocumentIdAsyncWithHttpInfo(documentId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a fax document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (FaxSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxSummary>> FaxSummaryGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/fax/summary";
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <returns>Task of ApiResponse (FaxDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxDocument>> PutDocumentsDocumentIdAsyncWithHttpInfo (string documentId, FaxDocument body = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling FaxApi->PutDocumentsDocumentId");

            var localVarPath = "/api/v2/fax/documents/{documentId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling FaxSummaryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FaxSummaryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSummary)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxDocument)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

    }
}
