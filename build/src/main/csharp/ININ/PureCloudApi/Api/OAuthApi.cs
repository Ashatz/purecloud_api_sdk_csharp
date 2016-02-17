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
    public interface IOAuthApi
    {
        
        /// <summary>
        /// The list of identity providers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>OAuthProviderEntityListing</returns>
        OAuthProviderEntityListing Get ();
  
        /// <summary>
        /// The list of identity providers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of OAuthProviderEntityListing</returns>
        ApiResponse<OAuthProviderEntityListing> GetWithHttpInfo ();

        /// <summary>
        /// The list of identity providers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of OAuthProviderEntityListing</returns>
        System.Threading.Tasks.Task<OAuthProviderEntityListing> GetAsync ();

        /// <summary>
        /// The list of identity providers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (OAuthProviderEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthProviderEntityListing>> GetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get Okta Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Okta</returns>
        Okta GetOkta ();
  
        /// <summary>
        /// Get Okta Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Okta</returns>
        ApiResponse<Okta> GetOktaWithHttpInfo ();

        /// <summary>
        /// Get Okta Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of Okta</returns>
        System.Threading.Tasks.Task<Okta> GetOktaAsync ();

        /// <summary>
        /// Get Okta Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (Okta)</returns>
        System.Threading.Tasks.Task<ApiResponse<Okta>> GetOktaAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update/Create Okta Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns></returns>
        void UpdateOkta (Okta body = null);
  
        /// <summary>
        /// Update/Create Okta Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateOktaWithHttpInfo (Okta body = null);

        /// <summary>
        /// Update/Create Okta Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateOktaAsync (Okta body = null);

        /// <summary>
        /// Update/Create Okta Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOktaAsyncWithHttpInfo (Okta body = null);
        
        /// <summary>
        /// Delete Okta Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        void DeleteOkta ();
  
        /// <summary>
        /// Delete Okta Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOktaWithHttpInfo ();

        /// <summary>
        /// Delete Okta Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOktaAsync ();

        /// <summary>
        /// Delete Okta Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOktaAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get OneLogin Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>OneLogin</returns>
        OneLogin GetOnelogin ();
  
        /// <summary>
        /// Get OneLogin Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of OneLogin</returns>
        ApiResponse<OneLogin> GetOneloginWithHttpInfo ();

        /// <summary>
        /// Get OneLogin Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of OneLogin</returns>
        System.Threading.Tasks.Task<OneLogin> GetOneloginAsync ();

        /// <summary>
        /// Get OneLogin Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (OneLogin)</returns>
        System.Threading.Tasks.Task<ApiResponse<OneLogin>> GetOneloginAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update/Create OneLogin Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns></returns>
        void UpdateOnelogin (OneLogin body = null);
  
        /// <summary>
        /// Update/Create OneLogin Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateOneloginWithHttpInfo (OneLogin body = null);

        /// <summary>
        /// Update/Create OneLogin Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateOneloginAsync (OneLogin body = null);

        /// <summary>
        /// Update/Create OneLogin Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOneloginAsyncWithHttpInfo (OneLogin body = null);
        
        /// <summary>
        /// Delete OneLogin Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        void DeleteOnelogin ();
  
        /// <summary>
        /// Delete OneLogin Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOneloginWithHttpInfo ();

        /// <summary>
        /// Delete OneLogin Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOneloginAsync ();

        /// <summary>
        /// Delete OneLogin Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOneloginAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get PureCloud Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>PureCloud</returns>
        PureCloud GetPurecloud ();
  
        /// <summary>
        /// Get PureCloud Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of PureCloud</returns>
        ApiResponse<PureCloud> GetPurecloudWithHttpInfo ();

        /// <summary>
        /// Get PureCloud Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of PureCloud</returns>
        System.Threading.Tasks.Task<PureCloud> GetPurecloudAsync ();

        /// <summary>
        /// Get PureCloud Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (PureCloud)</returns>
        System.Threading.Tasks.Task<ApiResponse<PureCloud>> GetPurecloudAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update/Create PureCloud Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns></returns>
        void UpdatePurecloud (PureCloud body = null);
  
        /// <summary>
        /// Update/Create PureCloud Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdatePurecloudWithHttpInfo (PureCloud body = null);

        /// <summary>
        /// Update/Create PureCloud Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdatePurecloudAsync (PureCloud body = null);

        /// <summary>
        /// Update/Create PureCloud Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePurecloudAsyncWithHttpInfo (PureCloud body = null);
        
        /// <summary>
        /// Delete PureCloud Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        void DeletePurecloud ();
  
        /// <summary>
        /// Delete PureCloud Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePurecloudWithHttpInfo ();

        /// <summary>
        /// Delete PureCloud Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePurecloudAsync ();

        /// <summary>
        /// Delete PureCloud Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePurecloudAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get Salesforce Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Salesforce</returns>
        Salesforce GetSalesforce ();
  
        /// <summary>
        /// Get Salesforce Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Salesforce</returns>
        ApiResponse<Salesforce> GetSalesforceWithHttpInfo ();

        /// <summary>
        /// Get Salesforce Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of Salesforce</returns>
        System.Threading.Tasks.Task<Salesforce> GetSalesforceAsync ();

        /// <summary>
        /// Get Salesforce Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (Salesforce)</returns>
        System.Threading.Tasks.Task<ApiResponse<Salesforce>> GetSalesforceAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update/Create Salesforce Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns></returns>
        void UpdateSalesforce (Salesforce body = null);
  
        /// <summary>
        /// Update/Create Salesforce Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateSalesforceWithHttpInfo (Salesforce body = null);

        /// <summary>
        /// Update/Create Salesforce Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateSalesforceAsync (Salesforce body = null);

        /// <summary>
        /// Update/Create Salesforce Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateSalesforceAsyncWithHttpInfo (Salesforce body = null);
        
        /// <summary>
        /// Delete Salesforce Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        void DeleteSalesforce ();
  
        /// <summary>
        /// Delete Salesforce Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteSalesforceWithHttpInfo ();

        /// <summary>
        /// Delete Salesforce Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteSalesforceAsync ();

        /// <summary>
        /// Delete Salesforce Identity Provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSalesforceAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get an identity provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>OAuthProvider</returns>
        OAuthProvider GetProverId ();
  
        /// <summary>
        /// Get an identity provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of OAuthProvider</returns>
        ApiResponse<OAuthProvider> GetProverIdWithHttpInfo ();

        /// <summary>
        /// Get an identity provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of OAuthProvider</returns>
        System.Threading.Tasks.Task<OAuthProvider> GetProverIdAsync ();

        /// <summary>
        /// Get an identity provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (OAuthProvider)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthProvider>> GetProverIdAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update an identity provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns></returns>
        void UpdateProverId (OAuthProvider body = null);
  
        /// <summary>
        /// Update an identity provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateProverIdWithHttpInfo (OAuthProvider body = null);

        /// <summary>
        /// Update an identity provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateProverIdAsync (OAuthProvider body = null);

        /// <summary>
        /// Update an identity provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Provider</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateProverIdAsyncWithHttpInfo (OAuthProvider body = null);
        
        /// <summary>
        /// Delete an identity provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        void DeleteProverId ();
  
        /// <summary>
        /// Delete an identity provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteProverIdWithHttpInfo ();

        /// <summary>
        /// Delete an identity provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteProverIdAsync ();

        /// <summary>
        /// Delete an identity provider
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProverIdAsyncWithHttpInfo ();
        
        /// <summary>
        /// The list of OAuth clients
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>OAuthClientEntityListing</returns>
        OAuthClientEntityListing GetClients ();
  
        /// <summary>
        /// The list of OAuth clients
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of OAuthClientEntityListing</returns>
        ApiResponse<OAuthClientEntityListing> GetClientsWithHttpInfo ();

        /// <summary>
        /// The list of OAuth clients
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of OAuthClientEntityListing</returns>
        System.Threading.Tasks.Task<OAuthClientEntityListing> GetClientsAsync ();

        /// <summary>
        /// The list of OAuth clients
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (OAuthClientEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthClientEntityListing>> GetClientsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Create OAuth client
        /// </summary>
        /// <remarks>
        /// The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud. \nThe preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server. \nIf the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps. \nIf a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles \nvia the &#39;roleIds&#39; field.
        /// </remarks>
        /// <param name="body">Client</param>
        /// <returns>OAuthClient</returns>
        OAuthClient CreateClients (OAuthClient body = null);
  
        /// <summary>
        /// Create OAuth client
        /// </summary>
        /// <remarks>
        /// The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud. \nThe preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server. \nIf the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps. \nIf a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles \nvia the &#39;roleIds&#39; field.
        /// </remarks>
        /// <param name="body">Client</param>
        /// <returns>ApiResponse of OAuthClient</returns>
        ApiResponse<OAuthClient> CreateClientsWithHttpInfo (OAuthClient body = null);

        /// <summary>
        /// Create OAuth client
        /// </summary>
        /// <remarks>
        /// The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud. \nThe preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server. \nIf the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps. \nIf a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles \nvia the &#39;roleIds&#39; field.
        /// </remarks>
        /// <param name="body">Client</param>
        /// <returns>Task of OAuthClient</returns>
        System.Threading.Tasks.Task<OAuthClient> CreateClientsAsync (OAuthClient body = null);

        /// <summary>
        /// Create OAuth client
        /// </summary>
        /// <remarks>
        /// The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud. \nThe preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server. \nIf the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps. \nIf a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles \nvia the &#39;roleIds&#39; field.
        /// </remarks>
        /// <param name="body">Client</param>
        /// <returns>Task of ApiResponse (OAuthClient)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthClient>> CreateClientsAsyncWithHttpInfo (OAuthClient body = null);
        
        /// <summary>
        /// Get OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <returns>OAuthClient</returns>
        OAuthClient GetClient (string clientId);
  
        /// <summary>
        /// Get OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiResponse of OAuthClient</returns>
        ApiResponse<OAuthClient> GetClientWithHttpInfo (string clientId);

        /// <summary>
        /// Get OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of OAuthClient</returns>
        System.Threading.Tasks.Task<OAuthClient> GetClientAsync (string clientId);

        /// <summary>
        /// Get OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse (OAuthClient)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthClient>> GetClientAsyncWithHttpInfo (string clientId);
        
        /// <summary>
        /// Update OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Client</param>
        /// <returns>OAuthClient</returns>
        OAuthClient UpdateClient (string clientId, OAuthClient body = null);
  
        /// <summary>
        /// Update OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Client</param>
        /// <returns>ApiResponse of OAuthClient</returns>
        ApiResponse<OAuthClient> UpdateClientWithHttpInfo (string clientId, OAuthClient body = null);

        /// <summary>
        /// Update OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Client</param>
        /// <returns>Task of OAuthClient</returns>
        System.Threading.Tasks.Task<OAuthClient> UpdateClientAsync (string clientId, OAuthClient body = null);

        /// <summary>
        /// Update OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Client</param>
        /// <returns>Task of ApiResponse (OAuthClient)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthClient>> UpdateClientAsyncWithHttpInfo (string clientId, OAuthClient body = null);
        
        /// <summary>
        /// Delete OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <returns></returns>
        void DeleteClient (string clientId);
  
        /// <summary>
        /// Delete OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteClientWithHttpInfo (string clientId);

        /// <summary>
        /// Delete OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteClientAsync (string clientId);

        /// <summary>
        /// Delete OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteClientAsyncWithHttpInfo (string clientId);
        
        /// <summary>
        /// Regenerate Client Secret
        /// </summary>
        /// <remarks>
        /// This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <returns></returns>
        void CreateClientSecret (string clientId);
  
        /// <summary>
        /// Regenerate Client Secret
        /// </summary>
        /// <remarks>
        /// This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateClientSecretWithHttpInfo (string clientId);

        /// <summary>
        /// Regenerate Client Secret
        /// </summary>
        /// <remarks>
        /// This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateClientSecretAsync (string clientId);

        /// <summary>
        /// Regenerate Client Secret
        /// </summary>
        /// <remarks>
        /// This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </remarks>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateClientSecretAsyncWithHttpInfo (string clientId);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OAuthApi : IOAuthApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OAuthApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OAuthApi(Configuration configuration = null)
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
        /// The list of identity providers 
        /// </summary>
        /// <returns>OAuthProviderEntityListing</returns>
        public OAuthProviderEntityListing Get ()
        {
             ApiResponse<OAuthProviderEntityListing> response = GetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// The list of identity providers 
        /// </summary>
        /// <returns>ApiResponse of OAuthProviderEntityListing</returns>
        public ApiResponse< OAuthProviderEntityListing > GetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders";
    
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
    
            return new ApiResponse<OAuthProviderEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuthProviderEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OAuthProviderEntityListing)));
            
        }
    
        /// <summary>
        /// The list of identity providers 
        /// </summary>
        /// <returns>Task of OAuthProviderEntityListing</returns>
        public async System.Threading.Tasks.Task<OAuthProviderEntityListing> GetAsync ()
        {
             ApiResponse<OAuthProviderEntityListing> response = await GetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// The list of identity providers 
        /// </summary>
        /// <returns>Task of ApiResponse (OAuthProviderEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthProviderEntityListing>> GetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders";
    
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

            return new ApiResponse<OAuthProviderEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuthProviderEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OAuthProviderEntityListing)));
            
        }
        
        /// <summary>
        /// Get Okta Identity Provider 
        /// </summary>
        /// <returns>Okta</returns>
        public Okta GetOkta ()
        {
             ApiResponse<Okta> response = GetOktaWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get Okta Identity Provider 
        /// </summary>
        /// <returns>ApiResponse of Okta</returns>
        public ApiResponse< Okta > GetOktaWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/okta";
    
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
                throw new ApiException (statusCode, "Error calling GetOkta: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOkta: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Okta>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Okta) Configuration.ApiClient.Deserialize(response, typeof(Okta)));
            
        }
    
        /// <summary>
        /// Get Okta Identity Provider 
        /// </summary>
        /// <returns>Task of Okta</returns>
        public async System.Threading.Tasks.Task<Okta> GetOktaAsync ()
        {
             ApiResponse<Okta> response = await GetOktaAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get Okta Identity Provider 
        /// </summary>
        /// <returns>Task of ApiResponse (Okta)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Okta>> GetOktaAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/okta";
    
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
                throw new ApiException (statusCode, "Error calling GetOkta: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOkta: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Okta>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Okta) Configuration.ApiClient.Deserialize(response, typeof(Okta)));
            
        }
        
        /// <summary>
        /// Update/Create Okta Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param> 
        /// <returns></returns>
        public void UpdateOkta (Okta body = null)
        {
             UpdateOktaWithHttpInfo(body);
        }

        /// <summary>
        /// Update/Create Okta Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateOktaWithHttpInfo (Okta body = null)
        {
            
    
            var path_ = "/api/v1/identityproviders/okta";
    
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
                throw new ApiException (statusCode, "Error calling UpdateOkta: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateOkta: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Update/Create Okta Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateOktaAsync (Okta body = null)
        {
             await UpdateOktaAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update/Create Okta Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOktaAsyncWithHttpInfo (Okta body = null)
        {
            
    
            var path_ = "/api/v1/identityproviders/okta";
    
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
                throw new ApiException (statusCode, "Error calling UpdateOkta: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateOkta: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete Okta Identity Provider 
        /// </summary>
        /// <returns></returns>
        public void DeleteOkta ()
        {
             DeleteOktaWithHttpInfo();
        }

        /// <summary>
        /// Delete Okta Identity Provider 
        /// </summary>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOktaWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/okta";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteOkta: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteOkta: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete Okta Identity Provider 
        /// </summary>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOktaAsync ()
        {
             await DeleteOktaAsyncWithHttpInfo();

        }

        /// <summary>
        /// Delete Okta Identity Provider 
        /// </summary>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOktaAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/okta";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteOkta: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteOkta: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get OneLogin Identity Provider 
        /// </summary>
        /// <returns>OneLogin</returns>
        public OneLogin GetOnelogin ()
        {
             ApiResponse<OneLogin> response = GetOneloginWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get OneLogin Identity Provider 
        /// </summary>
        /// <returns>ApiResponse of OneLogin</returns>
        public ApiResponse< OneLogin > GetOneloginWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/onelogin";
    
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
                throw new ApiException (statusCode, "Error calling GetOnelogin: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOnelogin: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OneLogin>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OneLogin) Configuration.ApiClient.Deserialize(response, typeof(OneLogin)));
            
        }
    
        /// <summary>
        /// Get OneLogin Identity Provider 
        /// </summary>
        /// <returns>Task of OneLogin</returns>
        public async System.Threading.Tasks.Task<OneLogin> GetOneloginAsync ()
        {
             ApiResponse<OneLogin> response = await GetOneloginAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get OneLogin Identity Provider 
        /// </summary>
        /// <returns>Task of ApiResponse (OneLogin)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OneLogin>> GetOneloginAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/onelogin";
    
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
                throw new ApiException (statusCode, "Error calling GetOnelogin: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOnelogin: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OneLogin>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OneLogin) Configuration.ApiClient.Deserialize(response, typeof(OneLogin)));
            
        }
        
        /// <summary>
        /// Update/Create OneLogin Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param> 
        /// <returns></returns>
        public void UpdateOnelogin (OneLogin body = null)
        {
             UpdateOneloginWithHttpInfo(body);
        }

        /// <summary>
        /// Update/Create OneLogin Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateOneloginWithHttpInfo (OneLogin body = null)
        {
            
    
            var path_ = "/api/v1/identityproviders/onelogin";
    
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
                throw new ApiException (statusCode, "Error calling UpdateOnelogin: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateOnelogin: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Update/Create OneLogin Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateOneloginAsync (OneLogin body = null)
        {
             await UpdateOneloginAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update/Create OneLogin Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOneloginAsyncWithHttpInfo (OneLogin body = null)
        {
            
    
            var path_ = "/api/v1/identityproviders/onelogin";
    
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
                throw new ApiException (statusCode, "Error calling UpdateOnelogin: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateOnelogin: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete OneLogin Identity Provider 
        /// </summary>
        /// <returns></returns>
        public void DeleteOnelogin ()
        {
             DeleteOneloginWithHttpInfo();
        }

        /// <summary>
        /// Delete OneLogin Identity Provider 
        /// </summary>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOneloginWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/onelogin";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteOnelogin: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteOnelogin: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete OneLogin Identity Provider 
        /// </summary>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOneloginAsync ()
        {
             await DeleteOneloginAsyncWithHttpInfo();

        }

        /// <summary>
        /// Delete OneLogin Identity Provider 
        /// </summary>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOneloginAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/onelogin";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteOnelogin: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteOnelogin: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get PureCloud Identity Provider 
        /// </summary>
        /// <returns>PureCloud</returns>
        public PureCloud GetPurecloud ()
        {
             ApiResponse<PureCloud> response = GetPurecloudWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get PureCloud Identity Provider 
        /// </summary>
        /// <returns>ApiResponse of PureCloud</returns>
        public ApiResponse< PureCloud > GetPurecloudWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/purecloud";
    
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
                throw new ApiException (statusCode, "Error calling GetPurecloud: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPurecloud: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PureCloud>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PureCloud) Configuration.ApiClient.Deserialize(response, typeof(PureCloud)));
            
        }
    
        /// <summary>
        /// Get PureCloud Identity Provider 
        /// </summary>
        /// <returns>Task of PureCloud</returns>
        public async System.Threading.Tasks.Task<PureCloud> GetPurecloudAsync ()
        {
             ApiResponse<PureCloud> response = await GetPurecloudAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get PureCloud Identity Provider 
        /// </summary>
        /// <returns>Task of ApiResponse (PureCloud)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PureCloud>> GetPurecloudAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/purecloud";
    
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
                throw new ApiException (statusCode, "Error calling GetPurecloud: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPurecloud: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PureCloud>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PureCloud) Configuration.ApiClient.Deserialize(response, typeof(PureCloud)));
            
        }
        
        /// <summary>
        /// Update/Create PureCloud Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param> 
        /// <returns></returns>
        public void UpdatePurecloud (PureCloud body = null)
        {
             UpdatePurecloudWithHttpInfo(body);
        }

        /// <summary>
        /// Update/Create PureCloud Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdatePurecloudWithHttpInfo (PureCloud body = null)
        {
            
    
            var path_ = "/api/v1/identityproviders/purecloud";
    
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
                throw new ApiException (statusCode, "Error calling UpdatePurecloud: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdatePurecloud: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Update/Create PureCloud Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdatePurecloudAsync (PureCloud body = null)
        {
             await UpdatePurecloudAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update/Create PureCloud Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePurecloudAsyncWithHttpInfo (PureCloud body = null)
        {
            
    
            var path_ = "/api/v1/identityproviders/purecloud";
    
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
                throw new ApiException (statusCode, "Error calling UpdatePurecloud: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdatePurecloud: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete PureCloud Identity Provider 
        /// </summary>
        /// <returns></returns>
        public void DeletePurecloud ()
        {
             DeletePurecloudWithHttpInfo();
        }

        /// <summary>
        /// Delete PureCloud Identity Provider 
        /// </summary>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePurecloudWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/purecloud";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeletePurecloud: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeletePurecloud: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete PureCloud Identity Provider 
        /// </summary>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePurecloudAsync ()
        {
             await DeletePurecloudAsyncWithHttpInfo();

        }

        /// <summary>
        /// Delete PureCloud Identity Provider 
        /// </summary>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePurecloudAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/purecloud";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeletePurecloud: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeletePurecloud: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get Salesforce Identity Provider 
        /// </summary>
        /// <returns>Salesforce</returns>
        public Salesforce GetSalesforce ()
        {
             ApiResponse<Salesforce> response = GetSalesforceWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get Salesforce Identity Provider 
        /// </summary>
        /// <returns>ApiResponse of Salesforce</returns>
        public ApiResponse< Salesforce > GetSalesforceWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/salesforce";
    
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
                throw new ApiException (statusCode, "Error calling GetSalesforce: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSalesforce: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Salesforce>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Salesforce) Configuration.ApiClient.Deserialize(response, typeof(Salesforce)));
            
        }
    
        /// <summary>
        /// Get Salesforce Identity Provider 
        /// </summary>
        /// <returns>Task of Salesforce</returns>
        public async System.Threading.Tasks.Task<Salesforce> GetSalesforceAsync ()
        {
             ApiResponse<Salesforce> response = await GetSalesforceAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get Salesforce Identity Provider 
        /// </summary>
        /// <returns>Task of ApiResponse (Salesforce)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Salesforce>> GetSalesforceAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/salesforce";
    
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
                throw new ApiException (statusCode, "Error calling GetSalesforce: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSalesforce: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Salesforce>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Salesforce) Configuration.ApiClient.Deserialize(response, typeof(Salesforce)));
            
        }
        
        /// <summary>
        /// Update/Create Salesforce Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param> 
        /// <returns></returns>
        public void UpdateSalesforce (Salesforce body = null)
        {
             UpdateSalesforceWithHttpInfo(body);
        }

        /// <summary>
        /// Update/Create Salesforce Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateSalesforceWithHttpInfo (Salesforce body = null)
        {
            
    
            var path_ = "/api/v1/identityproviders/salesforce";
    
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
                throw new ApiException (statusCode, "Error calling UpdateSalesforce: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateSalesforce: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Update/Create Salesforce Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateSalesforceAsync (Salesforce body = null)
        {
             await UpdateSalesforceAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update/Create Salesforce Identity Provider 
        /// </summary>
        /// <param name="body">Provider</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateSalesforceAsyncWithHttpInfo (Salesforce body = null)
        {
            
    
            var path_ = "/api/v1/identityproviders/salesforce";
    
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
                throw new ApiException (statusCode, "Error calling UpdateSalesforce: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateSalesforce: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete Salesforce Identity Provider 
        /// </summary>
        /// <returns></returns>
        public void DeleteSalesforce ()
        {
             DeleteSalesforceWithHttpInfo();
        }

        /// <summary>
        /// Delete Salesforce Identity Provider 
        /// </summary>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteSalesforceWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/salesforce";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteSalesforce: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSalesforce: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete Salesforce Identity Provider 
        /// </summary>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteSalesforceAsync ()
        {
             await DeleteSalesforceAsyncWithHttpInfo();

        }

        /// <summary>
        /// Delete Salesforce Identity Provider 
        /// </summary>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSalesforceAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/salesforce";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteSalesforce: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSalesforce: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get an identity provider 
        /// </summary>
        /// <returns>OAuthProvider</returns>
        public OAuthProvider GetProverId ()
        {
             ApiResponse<OAuthProvider> response = GetProverIdWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get an identity provider 
        /// </summary>
        /// <returns>ApiResponse of OAuthProvider</returns>
        public ApiResponse< OAuthProvider > GetProverIdWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/{providerId}";
    
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
                throw new ApiException (statusCode, "Error calling GetProverId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProverId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OAuthProvider>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuthProvider) Configuration.ApiClient.Deserialize(response, typeof(OAuthProvider)));
            
        }
    
        /// <summary>
        /// Get an identity provider 
        /// </summary>
        /// <returns>Task of OAuthProvider</returns>
        public async System.Threading.Tasks.Task<OAuthProvider> GetProverIdAsync ()
        {
             ApiResponse<OAuthProvider> response = await GetProverIdAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get an identity provider 
        /// </summary>
        /// <returns>Task of ApiResponse (OAuthProvider)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthProvider>> GetProverIdAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/{providerId}";
    
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
                throw new ApiException (statusCode, "Error calling GetProverId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProverId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OAuthProvider>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuthProvider) Configuration.ApiClient.Deserialize(response, typeof(OAuthProvider)));
            
        }
        
        /// <summary>
        /// Update an identity provider 
        /// </summary>
        /// <param name="body">Provider</param> 
        /// <returns></returns>
        public void UpdateProverId (OAuthProvider body = null)
        {
             UpdateProverIdWithHttpInfo(body);
        }

        /// <summary>
        /// Update an identity provider 
        /// </summary>
        /// <param name="body">Provider</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateProverIdWithHttpInfo (OAuthProvider body = null)
        {
            
    
            var path_ = "/api/v1/identityproviders/{providerId}";
    
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
                throw new ApiException (statusCode, "Error calling UpdateProverId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateProverId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Update an identity provider 
        /// </summary>
        /// <param name="body">Provider</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateProverIdAsync (OAuthProvider body = null)
        {
             await UpdateProverIdAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an identity provider 
        /// </summary>
        /// <param name="body">Provider</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateProverIdAsyncWithHttpInfo (OAuthProvider body = null)
        {
            
    
            var path_ = "/api/v1/identityproviders/{providerId}";
    
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
                throw new ApiException (statusCode, "Error calling UpdateProverId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateProverId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an identity provider 
        /// </summary>
        /// <returns></returns>
        public void DeleteProverId ()
        {
             DeleteProverIdWithHttpInfo();
        }

        /// <summary>
        /// Delete an identity provider 
        /// </summary>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteProverIdWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/{providerId}";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteProverId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProverId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an identity provider 
        /// </summary>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteProverIdAsync ()
        {
             await DeleteProverIdAsyncWithHttpInfo();

        }

        /// <summary>
        /// Delete an identity provider 
        /// </summary>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProverIdAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/identityproviders/{providerId}";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteProverId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProverId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// The list of OAuth clients 
        /// </summary>
        /// <returns>OAuthClientEntityListing</returns>
        public OAuthClientEntityListing GetClients ()
        {
             ApiResponse<OAuthClientEntityListing> response = GetClientsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// The list of OAuth clients 
        /// </summary>
        /// <returns>ApiResponse of OAuthClientEntityListing</returns>
        public ApiResponse< OAuthClientEntityListing > GetClientsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/oauth/clients";
    
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
                throw new ApiException (statusCode, "Error calling GetClients: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetClients: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OAuthClientEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuthClientEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OAuthClientEntityListing)));
            
        }
    
        /// <summary>
        /// The list of OAuth clients 
        /// </summary>
        /// <returns>Task of OAuthClientEntityListing</returns>
        public async System.Threading.Tasks.Task<OAuthClientEntityListing> GetClientsAsync ()
        {
             ApiResponse<OAuthClientEntityListing> response = await GetClientsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// The list of OAuth clients 
        /// </summary>
        /// <returns>Task of ApiResponse (OAuthClientEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthClientEntityListing>> GetClientsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/oauth/clients";
    
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
                throw new ApiException (statusCode, "Error calling GetClients: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetClients: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OAuthClientEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuthClientEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OAuthClientEntityListing)));
            
        }
        
        /// <summary>
        /// Create OAuth client The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud. \nThe preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server. \nIf the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps. \nIf a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles \nvia the &#39;roleIds&#39; field.
        /// </summary>
        /// <param name="body">Client</param> 
        /// <returns>OAuthClient</returns>
        public OAuthClient CreateClients (OAuthClient body = null)
        {
             ApiResponse<OAuthClient> response = CreateClientsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create OAuth client The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud. \nThe preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server. \nIf the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps. \nIf a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles \nvia the &#39;roleIds&#39; field.
        /// </summary>
        /// <param name="body">Client</param> 
        /// <returns>ApiResponse of OAuthClient</returns>
        public ApiResponse< OAuthClient > CreateClientsWithHttpInfo (OAuthClient body = null)
        {
            
    
            var path_ = "/api/v1/oauth/clients";
    
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
                throw new ApiException (statusCode, "Error calling CreateClients: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateClients: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OAuthClient>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuthClient) Configuration.ApiClient.Deserialize(response, typeof(OAuthClient)));
            
        }
    
        /// <summary>
        /// Create OAuth client The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud. \nThe preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server. \nIf the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps. \nIf a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles \nvia the &#39;roleIds&#39; field.
        /// </summary>
        /// <param name="body">Client</param>
        /// <returns>Task of OAuthClient</returns>
        public async System.Threading.Tasks.Task<OAuthClient> CreateClientsAsync (OAuthClient body = null)
        {
             ApiResponse<OAuthClient> response = await CreateClientsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create OAuth client The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud. \nThe preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server. \nIf the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps. \nIf a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles \nvia the &#39;roleIds&#39; field.
        /// </summary>
        /// <param name="body">Client</param>
        /// <returns>Task of ApiResponse (OAuthClient)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthClient>> CreateClientsAsyncWithHttpInfo (OAuthClient body = null)
        {
            
    
            var path_ = "/api/v1/oauth/clients";
    
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
                throw new ApiException (statusCode, "Error calling CreateClients: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateClients: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OAuthClient>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuthClient) Configuration.ApiClient.Deserialize(response, typeof(OAuthClient)));
            
        }
        
        /// <summary>
        /// Get OAuth Client 
        /// </summary>
        /// <param name="clientId">Client ID</param> 
        /// <returns>OAuthClient</returns>
        public OAuthClient GetClient (string clientId)
        {
             ApiResponse<OAuthClient> response = GetClientWithHttpInfo(clientId);
             return response.Data;
        }

        /// <summary>
        /// Get OAuth Client 
        /// </summary>
        /// <param name="clientId">Client ID</param> 
        /// <returns>ApiResponse of OAuthClient</returns>
        public ApiResponse< OAuthClient > GetClientWithHttpInfo (string clientId)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling GetClient");
            
    
            var path_ = "/api/v1/oauth/clients/{clientId}";
    
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
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetClient: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OAuthClient>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuthClient) Configuration.ApiClient.Deserialize(response, typeof(OAuthClient)));
            
        }
    
        /// <summary>
        /// Get OAuth Client 
        /// </summary>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of OAuthClient</returns>
        public async System.Threading.Tasks.Task<OAuthClient> GetClientAsync (string clientId)
        {
             ApiResponse<OAuthClient> response = await GetClientAsyncWithHttpInfo(clientId);
             return response.Data;

        }

        /// <summary>
        /// Get OAuth Client 
        /// </summary>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse (OAuthClient)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthClient>> GetClientAsyncWithHttpInfo (string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling GetClient");
            
    
            var path_ = "/api/v1/oauth/clients/{clientId}";
    
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
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetClient: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetClient: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OAuthClient>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuthClient) Configuration.ApiClient.Deserialize(response, typeof(OAuthClient)));
            
        }
        
        /// <summary>
        /// Update OAuth Client 
        /// </summary>
        /// <param name="clientId">Client ID</param> 
        /// <param name="body">Client</param> 
        /// <returns>OAuthClient</returns>
        public OAuthClient UpdateClient (string clientId, OAuthClient body = null)
        {
             ApiResponse<OAuthClient> response = UpdateClientWithHttpInfo(clientId, body);
             return response.Data;
        }

        /// <summary>
        /// Update OAuth Client 
        /// </summary>
        /// <param name="clientId">Client ID</param> 
        /// <param name="body">Client</param> 
        /// <returns>ApiResponse of OAuthClient</returns>
        public ApiResponse< OAuthClient > UpdateClientWithHttpInfo (string clientId, OAuthClient body = null)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling UpdateClient");
            
    
            var path_ = "/api/v1/oauth/clients/{clientId}";
    
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
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateClient: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OAuthClient>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuthClient) Configuration.ApiClient.Deserialize(response, typeof(OAuthClient)));
            
        }
    
        /// <summary>
        /// Update OAuth Client 
        /// </summary>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Client</param>
        /// <returns>Task of OAuthClient</returns>
        public async System.Threading.Tasks.Task<OAuthClient> UpdateClientAsync (string clientId, OAuthClient body = null)
        {
             ApiResponse<OAuthClient> response = await UpdateClientAsyncWithHttpInfo(clientId, body);
             return response.Data;

        }

        /// <summary>
        /// Update OAuth Client 
        /// </summary>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Client</param>
        /// <returns>Task of ApiResponse (OAuthClient)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthClient>> UpdateClientAsyncWithHttpInfo (string clientId, OAuthClient body = null)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling UpdateClient");
            
    
            var path_ = "/api/v1/oauth/clients/{clientId}";
    
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
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateClient: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateClient: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OAuthClient>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OAuthClient) Configuration.ApiClient.Deserialize(response, typeof(OAuthClient)));
            
        }
        
        /// <summary>
        /// Delete OAuth Client 
        /// </summary>
        /// <param name="clientId">Client ID</param> 
        /// <returns></returns>
        public void DeleteClient (string clientId)
        {
             DeleteClientWithHttpInfo(clientId);
        }

        /// <summary>
        /// Delete OAuth Client 
        /// </summary>
        /// <param name="clientId">Client ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteClientWithHttpInfo (string clientId)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling DeleteClient");
            
    
            var path_ = "/api/v1/oauth/clients/{clientId}";
    
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
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteClient: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteClient: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete OAuth Client 
        /// </summary>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteClientAsync (string clientId)
        {
             await DeleteClientAsyncWithHttpInfo(clientId);

        }

        /// <summary>
        /// Delete OAuth Client 
        /// </summary>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteClientAsyncWithHttpInfo (string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling DeleteClient");
            
    
            var path_ = "/api/v1/oauth/clients/{clientId}";
    
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
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteClient: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteClient: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Regenerate Client Secret This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </summary>
        /// <param name="clientId">Client ID</param> 
        /// <returns></returns>
        public void CreateClientSecret (string clientId)
        {
             CreateClientSecretWithHttpInfo(clientId);
        }

        /// <summary>
        /// Regenerate Client Secret This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </summary>
        /// <param name="clientId">Client ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CreateClientSecretWithHttpInfo (string clientId)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling CreateClientSecret");
            
    
            var path_ = "/api/v1/oauth/clients/{clientId}/secret";
    
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
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CreateClientSecret: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateClientSecret: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Regenerate Client Secret This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </summary>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreateClientSecretAsync (string clientId)
        {
             await CreateClientSecretAsyncWithHttpInfo(clientId);

        }

        /// <summary>
        /// Regenerate Client Secret This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </summary>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateClientSecretAsyncWithHttpInfo (string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling CreateClientSecret");
            
    
            var path_ = "/api/v1/oauth/clients/{clientId}/secret";
    
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
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CreateClientSecret: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateClientSecret: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
