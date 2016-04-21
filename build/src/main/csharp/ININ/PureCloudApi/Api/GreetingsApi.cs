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
    public interface IGreetingsApi
    {
        #region Synchronous Operations
<<<<<<< HEAD
        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList GreetingsDefaultsGet ();

        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> GreetingsDefaultsGetWithHttpInfo ();
        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList GreetingsDefaultsPut (DefaultGreetingList body);

        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> GreetingsDefaultsPutWithHttpInfo (DefaultGreetingList body);
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Deletes a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing GreetingsGet (int? pageSize = null, int? pageNumber = null);
=======
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Greeting</returns>
        Greeting DeleteGreetingId (string greetingId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Deletes a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> GreetingsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Deletes a Greeting with the given GreetingId
=======
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>ApiResponse of Greeting</returns>
        ApiResponse<Greeting> DeleteGreetingIdWithHttpInfo (string greetingId);
        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Greeting</returns>
        Greeting GreetingsGreetingidDelete (string greetingId);

        /// <summary>
        /// Deletes a Greeting with the given GreetingId
=======
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList GetDefaults ();

        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>ApiResponse of Greeting</returns>
        ApiResponse<Greeting> GreetingsGreetingidDeleteWithHttpInfo (string greetingId);
=======
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> GetDefaultsWithHttpInfo ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Greeting</returns>
<<<<<<< HEAD
        Greeting GreetingsGreetingidGet (string greetingId);
=======
        Greeting GetGreetingId (string greetingId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>ApiResponse of Greeting</returns>
<<<<<<< HEAD
        ApiResponse<Greeting> GreetingsGreetingidGetWithHttpInfo (string greetingId);
=======
        ApiResponse<Greeting> GetGreetingIdWithHttpInfo (string greetingId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get media playback URI for this greeting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.) (optional, default to WAV)</param>
        /// <returns>GreetingMediaInfo</returns>
<<<<<<< HEAD
        GreetingMediaInfo GreetingsGreetingidMediaGet (string greetingId, string formatId = null);
=======
        GreetingMediaInfo GetGreetingIdMedia (string greetingId, string formatId = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get media playback URI for this greeting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.) (optional, default to WAV)</param>
        /// <returns>ApiResponse of GreetingMediaInfo</returns>
<<<<<<< HEAD
        ApiResponse<GreetingMediaInfo> GreetingsGreetingidMediaGetWithHttpInfo (string greetingId, string formatId = null);
        /// <summary>
        /// Updates the Greeting with the given GreetingId
=======
        ApiResponse<GreetingMediaInfo> GetGreetingIdMediaWithHttpInfo (string greetingId, string formatId = null);
        /// <summary>
        /// Gets an Organization&#39;s Greetings
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Greeting</returns>
        Greeting GreetingsGreetingidPut (string greetingId, Greeting body);

        /// <summary>
        /// Updates the Greeting with the given GreetingId
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing GetGreetings (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets an Organization&#39;s Greetings
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>ApiResponse of Greeting</returns>
        ApiResponse<Greeting> GreetingsGreetingidPutWithHttpInfo (string greetingId, Greeting body);
        /// <summary>
        /// Create a Greeting for an Organization
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> GetGreetingsWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get a list of the User&#39;s Greetings
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">The Greeting to create</param>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList GreetingsPost (Greeting body);

        /// <summary>
        /// Create a Greeting for an Organization
=======
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing GetUserIdGreetings (string userId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of the User&#39;s Greetings
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">The Greeting to create</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> GreetingsPostWithHttpInfo (Greeting body);
=======
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> GetUserIdGreetingsWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>DefaultGreetingList</returns>
<<<<<<< HEAD
        DefaultGreetingList UsersUseridGreetingsDefaultsGet (string userId);
=======
        DefaultGreetingList GetUserIdGreetingsDefaults (string userId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
<<<<<<< HEAD
        ApiResponse<DefaultGreetingList> UsersUseridGreetingsDefaultsGetWithHttpInfo (string userId);
        /// <summary>
        /// Updates the DefaultGreetingList of the specified User
=======
        ApiResponse<DefaultGreetingList> GetUserIdGreetingsDefaultsWithHttpInfo (string userId);
        /// <summary>
        /// Create a Greeting for an Organization
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList UsersUseridGreetingsDefaultsPut (string userId, DefaultGreetingList body);

        /// <summary>
        /// Updates the DefaultGreetingList of the specified User
=======
        /// <param name="body">The Greeting to create</param>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList PostGreetings (Greeting body);

        /// <summary>
        /// Create a Greeting for an Organization
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> UsersUseridGreetingsDefaultsPutWithHttpInfo (string userId, DefaultGreetingList body);
        /// <summary>
        /// Get a list of the User&#39;s Greetings
=======
        /// <param name="body">The Greeting to create</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> PostGreetingsWithHttpInfo (Greeting body);
        /// <summary>
        /// Creates a Greeting for a User
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing UsersUseridGreetingsGet (string userId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of the User&#39;s Greetings
=======
        /// <param name="body">The Greeting to create</param>
        /// <returns>Greeting</returns>
        Greeting PostUserIdGreetings (string userId, Greeting body);

        /// <summary>
        /// Creates a Greeting for a User
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> UsersUseridGreetingsGetWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Creates a Greeting for a User
=======
        /// <param name="body">The Greeting to create</param>
        /// <returns>ApiResponse of Greeting</returns>
        ApiResponse<Greeting> PostUserIdGreetingsWithHttpInfo (string userId, Greeting body);
        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Greeting</returns>
        Greeting UsersUseridGreetingsPost (string userId, Greeting body);

        /// <summary>
        /// Creates a Greeting for a User
=======
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList PutDefaults (DefaultGreetingList body);

        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>ApiResponse of Greeting</returns>
        ApiResponse<Greeting> UsersUseridGreetingsPostWithHttpInfo (string userId, Greeting body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
=======
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> PutDefaultsWithHttpInfo (DefaultGreetingList body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> GreetingsDefaultsGetAsync ();
=======
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Greeting</returns>
        Greeting PutGreetingId (string greetingId, Greeting body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GreetingsDefaultsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
=======
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>ApiResponse of Greeting</returns>
        ApiResponse<Greeting> PutGreetingIdWithHttpInfo (string greetingId, Greeting body);
        /// <summary>
        /// Updates the DefaultGreetingList of the specified User
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> GreetingsDefaultsPutAsync (DefaultGreetingList body);

        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
=======
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>DefaultGreetingList</returns>
        DefaultGreetingList PutUserIdGreetingsDefaults (string userId, DefaultGreetingList body);

        /// <summary>
        /// Updates the DefaultGreetingList of the specified User
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GreetingsDefaultsPutAsyncWithHttpInfo (DefaultGreetingList body);
=======
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        ApiResponse<DefaultGreetingList> PutUserIdGreetingsDefaultsWithHttpInfo (string userId, DefaultGreetingList body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Gets an Organization&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> GreetingsGetAsync (int? pageSize = null, int? pageNumber = null);
=======
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of Greeting</returns>
        System.Threading.Tasks.Task<Greeting> DeleteGreetingIdAsync (string greetingId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Gets an Organization&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> GreetingsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
=======
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Greeting>> DeleteGreetingIdAsyncWithHttpInfo (string greetingId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of Greeting</returns>
        System.Threading.Tasks.Task<Greeting> GreetingsGreetingidDeleteAsync (string greetingId);
=======
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> GetDefaultsAsync ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get an Organization&#39;s DefaultGreetingList
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Greeting>> GreetingsGreetingidDeleteAsyncWithHttpInfo (string greetingId);
=======
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GetDefaultsAsyncWithHttpInfo ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of Greeting</returns>
<<<<<<< HEAD
        System.Threading.Tasks.Task<Greeting> GreetingsGreetingidGetAsync (string greetingId);
=======
        System.Threading.Tasks.Task<Greeting> GetGreetingIdAsync (string greetingId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get a Greeting with the given GreetingId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
<<<<<<< HEAD
        System.Threading.Tasks.Task<ApiResponse<Greeting>> GreetingsGreetingidGetAsyncWithHttpInfo (string greetingId);
=======
        System.Threading.Tasks.Task<ApiResponse<Greeting>> GetGreetingIdAsyncWithHttpInfo (string greetingId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get media playback URI for this greeting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.) (optional, default to WAV)</param>
        /// <returns>Task of GreetingMediaInfo</returns>
        System.Threading.Tasks.Task<GreetingMediaInfo> GetGreetingIdMediaAsync (string greetingId, string formatId = null);

        /// <summary>
        /// Get media playback URI for this greeting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.) (optional, default to WAV)</param>
        /// <returns>Task of ApiResponse (GreetingMediaInfo)</returns>
<<<<<<< HEAD
        System.Threading.Tasks.Task<ApiResponse<GreetingMediaInfo>> GreetingsGreetingidMediaGetAsyncWithHttpInfo (string greetingId, string formatId = null);
        /// <summary>
        /// Updates the Greeting with the given GreetingId
=======
        System.Threading.Tasks.Task<ApiResponse<GreetingMediaInfo>> GetGreetingIdMediaAsyncWithHttpInfo (string greetingId, string formatId = null);
        /// <summary>
        /// Gets an Organization&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> GetGreetingsAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets an Organization&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> GetGreetingsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get a list of the User&#39;s Greetings
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Task of Greeting</returns>
        System.Threading.Tasks.Task<Greeting> GreetingsGreetingidPutAsync (string greetingId, Greeting body);

        /// <summary>
        /// Updates the Greeting with the given GreetingId
=======
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> GetUserIdGreetingsAsync (string userId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of the User&#39;s Greetings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> GetUserIdGreetingsAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> GetUserIdGreetingsDefaultsAsync (string userId);

        /// <summary>
        /// Grabs the list of Default Greetings given a User&#39;s ID
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Greeting>> GreetingsGreetingidPutAsyncWithHttpInfo (string greetingId, Greeting body);
=======
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GetUserIdGreetingsDefaultsAsyncWithHttpInfo (string userId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Create a Greeting for an Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of DefaultGreetingList</returns>
<<<<<<< HEAD
        System.Threading.Tasks.Task<DefaultGreetingList> GreetingsPostAsync (Greeting body);
=======
        System.Threading.Tasks.Task<DefaultGreetingList> PostGreetingsAsync (Greeting body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Create a Greeting for an Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
<<<<<<< HEAD
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GreetingsPostAsyncWithHttpInfo (Greeting body);
=======
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> PostGreetingsAsyncWithHttpInfo (Greeting body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Creates a Greeting for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
<<<<<<< HEAD
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> UsersUseridGreetingsDefaultsGetAsync (string userId);
=======
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of Greeting</returns>
        System.Threading.Tasks.Task<Greeting> PostUserIdGreetingsAsync (string userId, Greeting body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Creates a Greeting for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> UsersUseridGreetingsDefaultsGetAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Updates the DefaultGreetingList of the specified User
=======
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Greeting>> PostUserIdGreetingsAsyncWithHttpInfo (string userId, Greeting body);
        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> UsersUseridGreetingsDefaultsPutAsync (string userId, DefaultGreetingList body);

        /// <summary>
        /// Updates the DefaultGreetingList of the specified User
=======
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> PutDefaultsAsync (DefaultGreetingList body);

        /// <summary>
        /// Update an Organization&#39;s DefaultGreetingList
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> UsersUseridGreetingsDefaultsPutAsyncWithHttpInfo (string userId, DefaultGreetingList body);
        /// <summary>
        /// Get a list of the User&#39;s Greetings
=======
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> PutDefaultsAsyncWithHttpInfo (DefaultGreetingList body);
        /// <summary>
        /// Updates the Greeting with the given GreetingId
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> UsersUseridGreetingsGetAsync (string userId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of the User&#39;s Greetings
=======
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Task of Greeting</returns>
        System.Threading.Tasks.Task<Greeting> PutGreetingIdAsync (string greetingId, Greeting body);

        /// <summary>
        /// Updates the Greeting with the given GreetingId
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> UsersUseridGreetingsGetAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null);
=======
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Greeting>> PutGreetingIdAsyncWithHttpInfo (string greetingId, Greeting body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Creates a Greeting for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
<<<<<<< HEAD
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of Greeting</returns>
        System.Threading.Tasks.Task<Greeting> UsersUseridGreetingsPostAsync (string userId, Greeting body);
=======
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of DefaultGreetingList</returns>
        System.Threading.Tasks.Task<DefaultGreetingList> PutUserIdGreetingsDefaultsAsync (string userId, DefaultGreetingList body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Creates a Greeting for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
<<<<<<< HEAD
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Greeting>> UsersUseridGreetingsPostAsyncWithHttpInfo (string userId, Greeting body);
=======
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> PutUserIdGreetingsDefaultsAsyncWithHttpInfo (string userId, DefaultGreetingList body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GreetingsApi : IGreetingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GreetingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GreetingsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GreetingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GreetingsApi(Configuration configuration = null)
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
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList GreetingsDefaultsGet ()
        {
             ApiResponse<DefaultGreetingList> localVarResponse = GreetingsDefaultsGetWithHttpInfo();
=======
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Greeting</returns>
        public Greeting DeleteGreetingId (string greetingId)
        {
             ApiResponse<Greeting> localVarResponse = DeleteGreetingIdWithHttpInfo(greetingId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > GreetingsDefaultsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/greetings/defaults";
=======
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > DeleteGreetingIdWithHttpInfo (string greetingId)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->DeleteGreetingId");

            var localVarPath = "/api/v2/greetings/{greetingId}";
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
            if (greetingId != null) localVarPathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling GreetingsDefaultsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsDefaultsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultGreetingList)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteGreetingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteGreetingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> GreetingsDefaultsGetAsync ()
        {
             ApiResponse<DefaultGreetingList> localVarResponse = await GreetingsDefaultsGetAsyncWithHttpInfo();
=======
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of Greeting</returns>
        public async System.Threading.Tasks.Task<Greeting> DeleteGreetingIdAsync (string greetingId)
        {
             ApiResponse<Greeting> localVarResponse = await DeleteGreetingIdAsyncWithHttpInfo(greetingId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GreetingsDefaultsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/greetings/defaults";
=======
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> DeleteGreetingIdAsyncWithHttpInfo (string greetingId)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->DeleteGreetingId");

            var localVarPath = "/api/v2/greetings/{greetingId}";
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
            if (greetingId != null) localVarPathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling GreetingsDefaultsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsDefaultsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultGreetingList)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteGreetingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteGreetingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList GreetingsDefaultsPut (DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = GreetingsDefaultsPutWithHttpInfo(body);
=======
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList GetDefaults ()
        {
             ApiResponse<DefaultGreetingList> localVarResponse = GetDefaultsWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > GreetingsDefaultsPutWithHttpInfo (DefaultGreetingList body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->GreetingsDefaultsPut");

            var localVarPath = "/api/v1/greetings/defaults";
=======
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > GetDefaultsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/greetings/defaults";
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
                throw new ApiException (localVarStatusCode, "Error calling GreetingsDefaultsPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsDefaultsPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetDefaults: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDefaults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<DefaultGreetingList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultGreetingList)));
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> GreetingsDefaultsPutAsync (DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = await GreetingsDefaultsPutAsyncWithHttpInfo(body);
=======
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> GetDefaultsAsync ()
        {
             ApiResponse<DefaultGreetingList> localVarResponse = await GetDefaultsAsyncWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GreetingsDefaultsPutAsyncWithHttpInfo (DefaultGreetingList body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->GreetingsDefaultsPut");

            var localVarPath = "/api/v1/greetings/defaults";
=======
        /// Get an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GetDefaultsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/greetings/defaults";
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
                throw new ApiException (localVarStatusCode, "Error calling GreetingsDefaultsPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsDefaultsPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetDefaults: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDefaults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<DefaultGreetingList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultGreetingList)));
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Gets an Organization&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing GreetingsGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = GreetingsGetWithHttpInfo(pageSize, pageNumber);
=======
        /// Get a Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Greeting</returns>
        public Greeting GetGreetingId (string greetingId)
        {
             ApiResponse<Greeting> localVarResponse = GetGreetingIdWithHttpInfo(greetingId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Gets an Organization&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > GreetingsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/greetings";
=======
        /// Get a Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > GetGreetingIdWithHttpInfo (string greetingId)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->GetGreetingId");

            var localVarPath = "/api/v2/greetings/{greetingId}";
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
            if (greetingId != null) localVarPathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetGreetingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGreetingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Gets an Organization&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> GreetingsGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = await GreetingsGetAsyncWithHttpInfo(pageSize, pageNumber);
=======
        /// Get a Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of Greeting</returns>
        public async System.Threading.Tasks.Task<Greeting> GetGreetingIdAsync (string greetingId)
        {
             ApiResponse<Greeting> localVarResponse = await GetGreetingIdAsyncWithHttpInfo(greetingId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Gets an Organization&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> GreetingsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/greetings";
=======
        /// Get a Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> GetGreetingIdAsyncWithHttpInfo (string greetingId)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->GetGreetingId");

            var localVarPath = "/api/v2/greetings/{greetingId}";
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
            if (greetingId != null) localVarPathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetGreetingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGreetingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Greeting</returns>
        public Greeting GreetingsGreetingidDelete (string greetingId)
        {
             ApiResponse<Greeting> localVarResponse = GreetingsGreetingidDeleteWithHttpInfo(greetingId);
=======
        /// Get media playback URI for this greeting 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.) (optional, default to WAV)</param>
        /// <returns>GreetingMediaInfo</returns>
        public GreetingMediaInfo GetGreetingIdMedia (string greetingId, string formatId = null)
        {
             ApiResponse<GreetingMediaInfo> localVarResponse = GetGreetingIdMediaWithHttpInfo(greetingId, formatId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > GreetingsGreetingidDeleteWithHttpInfo (string greetingId)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->GreetingsGreetingidDelete");

            var localVarPath = "/api/v1/greetings/{greetingId}";
=======
        /// Get media playback URI for this greeting 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.) (optional, default to WAV)</param>
        /// <returns>ApiResponse of GreetingMediaInfo</returns>
        public ApiResponse< GreetingMediaInfo > GetGreetingIdMediaWithHttpInfo (string greetingId, string formatId = null)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->GetGreetingIdMedia");

            var localVarPath = "/api/v2/greetings/{greetingId}/media";
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
            if (greetingId != null) localVarPathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
<<<<<<< HEAD
=======
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetGreetingIdMedia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGreetingIdMedia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GreetingMediaInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GreetingMediaInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GreetingMediaInfo)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of Greeting</returns>
        public async System.Threading.Tasks.Task<Greeting> GreetingsGreetingidDeleteAsync (string greetingId)
        {
             ApiResponse<Greeting> localVarResponse = await GreetingsGreetingidDeleteAsyncWithHttpInfo(greetingId);
=======
        /// Get media playback URI for this greeting 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.) (optional, default to WAV)</param>
        /// <returns>Task of GreetingMediaInfo</returns>
        public async System.Threading.Tasks.Task<GreetingMediaInfo> GetGreetingIdMediaAsync (string greetingId, string formatId = null)
        {
             ApiResponse<GreetingMediaInfo> localVarResponse = await GetGreetingIdMediaAsyncWithHttpInfo(greetingId, formatId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Deletes a Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> GreetingsGreetingidDeleteAsyncWithHttpInfo (string greetingId)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->GreetingsGreetingidDelete");

            var localVarPath = "/api/v1/greetings/{greetingId}";
=======
        /// Get media playback URI for this greeting 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.) (optional, default to WAV)</param>
        /// <returns>Task of ApiResponse (GreetingMediaInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GreetingMediaInfo>> GetGreetingIdMediaAsyncWithHttpInfo (string greetingId, string formatId = null)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->GetGreetingIdMedia");

            var localVarPath = "/api/v2/greetings/{greetingId}/media";
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
            if (greetingId != null) localVarPathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
<<<<<<< HEAD
=======
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetGreetingIdMedia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGreetingIdMedia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GreetingMediaInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GreetingMediaInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GreetingMediaInfo)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Gets an Organization&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Greeting</returns>
        public Greeting GreetingsGreetingidGet (string greetingId)
        {
             ApiResponse<Greeting> localVarResponse = GreetingsGreetingidGetWithHttpInfo(greetingId);
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing GetGreetings (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = GetGreetingsWithHttpInfo(pageSize, pageNumber);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets an Organization&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > GreetingsGreetingidGetWithHttpInfo (string greetingId)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->GreetingsGreetingidGet");

            var localVarPath = "/api/v1/greetings/{greetingId}";
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > GetGreetingsWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/greetings";
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
            if (greetingId != null) localVarPathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetGreetings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGreetings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Gets an Organization&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of Greeting</returns>
        public async System.Threading.Tasks.Task<Greeting> GreetingsGreetingidGetAsync (string greetingId)
        {
             ApiResponse<Greeting> localVarResponse = await GreetingsGreetingidGetAsyncWithHttpInfo(greetingId);
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> GetGreetingsAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = await GetGreetingsAsyncWithHttpInfo(pageSize, pageNumber);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets an Organization&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="greetingId">Greeting ID</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> GreetingsGreetingidGetAsyncWithHttpInfo (string greetingId)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->GreetingsGreetingidGet");

            var localVarPath = "/api/v1/greetings/{greetingId}";
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> GetGreetingsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/greetings";
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
            if (greetingId != null) localVarPathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetGreetings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGreetings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get media playback URI for this greeting 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.) (optional, default to WAV)</param>
        /// <returns>GreetingMediaInfo</returns>
        public GreetingMediaInfo GreetingsGreetingidMediaGet (string greetingId, string formatId = null)
        {
             ApiResponse<GreetingMediaInfo> localVarResponse = GreetingsGreetingidMediaGetWithHttpInfo(greetingId, formatId);
=======
        /// Get a list of the User&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing GetUserIdGreetings (string userId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = GetUserIdGreetingsWithHttpInfo(userId, pageSize, pageNumber);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get media playback URI for this greeting 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.) (optional, default to WAV)</param>
        /// <returns>ApiResponse of GreetingMediaInfo</returns>
        public ApiResponse< GreetingMediaInfo > GreetingsGreetingidMediaGetWithHttpInfo (string greetingId, string formatId = null)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->GreetingsGreetingidMediaGet");

            var localVarPath = "/api/v1/greetings/{greetingId}/media";
=======
        /// Get a list of the User&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > GetUserIdGreetingsWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->GetUserIdGreetings");

            var localVarPath = "/api/v2/users/{userId}/greetings";
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
            if (greetingId != null) localVarPathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
=======
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidMediaGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidMediaGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GreetingMediaInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GreetingMediaInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GreetingMediaInfo)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdGreetings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdGreetings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get media playback URI for this greeting 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.) (optional, default to WAV)</param>
        /// <returns>Task of GreetingMediaInfo</returns>
        public async System.Threading.Tasks.Task<GreetingMediaInfo> GreetingsGreetingidMediaGetAsync (string greetingId, string formatId = null)
        {
             ApiResponse<GreetingMediaInfo> localVarResponse = await GreetingsGreetingidMediaGetAsyncWithHttpInfo(greetingId, formatId);
=======
        /// Get a list of the User&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> GetUserIdGreetingsAsync (string userId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = await GetUserIdGreetingsAsyncWithHttpInfo(userId, pageSize, pageNumber);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get media playback URI for this greeting 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="formatId">The desired format (WAV, etc.) (optional, default to WAV)</param>
        /// <returns>Task of ApiResponse (GreetingMediaInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GreetingMediaInfo>> GreetingsGreetingidMediaGetAsyncWithHttpInfo (string greetingId, string formatId = null)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->GreetingsGreetingidMediaGet");

            var localVarPath = "/api/v1/greetings/{greetingId}/media";
=======
        /// Get a list of the User&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> GetUserIdGreetingsAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->GetUserIdGreetings");

            var localVarPath = "/api/v2/users/{userId}/greetings";
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
            if (greetingId != null) localVarPathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
=======
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidMediaGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidMediaGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GreetingMediaInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GreetingMediaInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GreetingMediaInfo)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdGreetings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdGreetings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Updates the Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Greeting</returns>
        public Greeting GreetingsGreetingidPut (string greetingId, Greeting body)
        {
             ApiResponse<Greeting> localVarResponse = GreetingsGreetingidPutWithHttpInfo(greetingId, body);
=======
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList GetUserIdGreetingsDefaults (string userId)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = GetUserIdGreetingsDefaultsWithHttpInfo(userId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Updates the Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > GreetingsGreetingidPutWithHttpInfo (string greetingId, Greeting body)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->GreetingsGreetingidPut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->GreetingsGreetingidPut");

            var localVarPath = "/api/v1/greetings/{greetingId}";
=======
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > GetUserIdGreetingsDefaultsWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->GetUserIdGreetingsDefaults");

            var localVarPath = "/api/v2/users/{userId}/greetings/defaults";
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
            if (greetingId != null) localVarPathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdGreetingsDefaults: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdGreetingsDefaults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultGreetingList)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Updates the Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Task of Greeting</returns>
        public async System.Threading.Tasks.Task<Greeting> GreetingsGreetingidPutAsync (string greetingId, Greeting body)
        {
             ApiResponse<Greeting> localVarResponse = await GreetingsGreetingidPutAsyncWithHttpInfo(greetingId, body);
=======
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> GetUserIdGreetingsDefaultsAsync (string userId)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = await GetUserIdGreetingsDefaultsAsyncWithHttpInfo(userId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Updates the Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> GreetingsGreetingidPutAsyncWithHttpInfo (string greetingId, Greeting body)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->GreetingsGreetingidPut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->GreetingsGreetingidPut");

            var localVarPath = "/api/v1/greetings/{greetingId}";
=======
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GetUserIdGreetingsDefaultsAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->GetUserIdGreetingsDefaults");

            var localVarPath = "/api/v2/users/{userId}/greetings/defaults";
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
            if (greetingId != null) localVarPathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsGreetingidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdGreetingsDefaults: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdGreetingsDefaults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultGreetingList)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Create a Greeting for an Organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Greeting to create</param>
        /// <returns>DefaultGreetingList</returns>
<<<<<<< HEAD
        public DefaultGreetingList GreetingsPost (Greeting body)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = GreetingsPostWithHttpInfo(body);
=======
        public DefaultGreetingList PostGreetings (Greeting body)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = PostGreetingsWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Greeting for an Organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Greeting to create</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
<<<<<<< HEAD
        public ApiResponse< DefaultGreetingList > GreetingsPostWithHttpInfo (Greeting body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->GreetingsPost");

            var localVarPath = "/api/v1/greetings";
=======
        public ApiResponse< DefaultGreetingList > PostGreetingsWithHttpInfo (Greeting body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->PostGreetings");

            var localVarPath = "/api/v2/greetings";
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling GreetingsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PostGreetings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGreetings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<DefaultGreetingList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultGreetingList)));
            
        }

        /// <summary>
        /// Create a Greeting for an Organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of DefaultGreetingList</returns>
<<<<<<< HEAD
        public async System.Threading.Tasks.Task<DefaultGreetingList> GreetingsPostAsync (Greeting body)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = await GreetingsPostAsyncWithHttpInfo(body);
=======
        public async System.Threading.Tasks.Task<DefaultGreetingList> PostGreetingsAsync (Greeting body)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = await PostGreetingsAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Greeting for an Organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
<<<<<<< HEAD
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> GreetingsPostAsyncWithHttpInfo (Greeting body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->GreetingsPost");

            var localVarPath = "/api/v1/greetings";
=======
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> PostGreetingsAsyncWithHttpInfo (Greeting body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->PostGreetings");

            var localVarPath = "/api/v2/greetings";
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling GreetingsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GreetingsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PostGreetings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGreetings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<DefaultGreetingList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultGreetingList)));
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList UsersUseridGreetingsDefaultsGet (string userId)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = UsersUseridGreetingsDefaultsGetWithHttpInfo(userId);
=======
        /// Creates a Greeting for a User 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Greeting</returns>
        public Greeting PostUserIdGreetings (string userId, Greeting body)
        {
             ApiResponse<Greeting> localVarResponse = PostUserIdGreetingsWithHttpInfo(userId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > UsersUseridGreetingsDefaultsGetWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->UsersUseridGreetingsDefaultsGet");

            var localVarPath = "/api/v1/users/{userId}/greetings/defaults";
=======
        /// Creates a Greeting for a User 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > PostUserIdGreetingsWithHttpInfo (string userId, Greeting body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->PostUserIdGreetings");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->PostUserIdGreetings");

            var localVarPath = "/api/v2/users/{userId}/greetings";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
<<<<<<< HEAD
=======
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsDefaultsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsDefaultsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultGreetingList)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostUserIdGreetings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUserIdGreetings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> UsersUseridGreetingsDefaultsGetAsync (string userId)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = await UsersUseridGreetingsDefaultsGetAsyncWithHttpInfo(userId);
=======
        /// Creates a Greeting for a User 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of Greeting</returns>
        public async System.Threading.Tasks.Task<Greeting> PostUserIdGreetingsAsync (string userId, Greeting body)
        {
             ApiResponse<Greeting> localVarResponse = await PostUserIdGreetingsAsyncWithHttpInfo(userId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Grabs the list of Default Greetings given a User&#39;s ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> UsersUseridGreetingsDefaultsGetAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->UsersUseridGreetingsDefaultsGet");

            var localVarPath = "/api/v1/users/{userId}/greetings/defaults";
=======
        /// Creates a Greeting for a User 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> PostUserIdGreetingsAsyncWithHttpInfo (string userId, Greeting body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->PostUserIdGreetings");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->PostUserIdGreetings");

            var localVarPath = "/api/v2/users/{userId}/greetings";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
<<<<<<< HEAD
=======
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsDefaultsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsDefaultsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultGreetingList)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostUserIdGreetings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUserIdGreetings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Updates the DefaultGreetingList of the specified User 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList UsersUseridGreetingsDefaultsPut (string userId, DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = UsersUseridGreetingsDefaultsPutWithHttpInfo(userId, body);
=======
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList PutDefaults (DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = PutDefaultsWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Updates the DefaultGreetingList of the specified User 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > UsersUseridGreetingsDefaultsPutWithHttpInfo (string userId, DefaultGreetingList body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->UsersUseridGreetingsDefaultsPut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->UsersUseridGreetingsDefaultsPut");

            var localVarPath = "/api/v1/users/{userId}/greetings/defaults";
=======
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > PutDefaultsWithHttpInfo (DefaultGreetingList body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->PutDefaults");

            var localVarPath = "/api/v2/greetings/defaults";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsDefaultsPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsDefaultsPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PutDefaults: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutDefaults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<DefaultGreetingList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultGreetingList)));
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Updates the DefaultGreetingList of the specified User 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> UsersUseridGreetingsDefaultsPutAsync (string userId, DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = await UsersUseridGreetingsDefaultsPutAsyncWithHttpInfo(userId, body);
=======
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> PutDefaultsAsync (DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = await PutDefaultsAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Updates the DefaultGreetingList of the specified User 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> UsersUseridGreetingsDefaultsPutAsyncWithHttpInfo (string userId, DefaultGreetingList body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->UsersUseridGreetingsDefaultsPut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->UsersUseridGreetingsDefaultsPut");

            var localVarPath = "/api/v1/users/{userId}/greetings/defaults";
=======
        /// Update an Organization&#39;s DefaultGreetingList 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> PutDefaultsAsyncWithHttpInfo (DefaultGreetingList body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->PutDefaults");

            var localVarPath = "/api/v2/greetings/defaults";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsDefaultsPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsDefaultsPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PutDefaults: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutDefaults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<DefaultGreetingList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultGreetingList)));
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of the User&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing UsersUseridGreetingsGet (string userId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = UsersUseridGreetingsGetWithHttpInfo(userId, pageSize, pageNumber);
=======
        /// Updates the Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Greeting</returns>
        public Greeting PutGreetingId (string greetingId, Greeting body)
        {
             ApiResponse<Greeting> localVarResponse = PutGreetingIdWithHttpInfo(greetingId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of the User&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > UsersUseridGreetingsGetWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->UsersUseridGreetingsGet");

            var localVarPath = "/api/v1/users/{userId}/greetings";
=======
        /// Updates the Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > PutGreetingIdWithHttpInfo (string greetingId, Greeting body)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->PutGreetingId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->PutGreetingId");

            var localVarPath = "/api/v2/greetings/{greetingId}";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
=======
            if (greetingId != null) localVarPathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutGreetingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutGreetingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of the User&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> UsersUseridGreetingsGetAsync (string userId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = await UsersUseridGreetingsGetAsyncWithHttpInfo(userId, pageSize, pageNumber);
=======
        /// Updates the Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Task of Greeting</returns>
        public async System.Threading.Tasks.Task<Greeting> PutGreetingIdAsync (string greetingId, Greeting body)
        {
             ApiResponse<Greeting> localVarResponse = await PutGreetingIdAsyncWithHttpInfo(greetingId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get a list of the User&#39;s Greetings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> UsersUseridGreetingsGetAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->UsersUseridGreetingsGet");

            var localVarPath = "/api/v1/users/{userId}/greetings";
=======
        /// Updates the Greeting with the given GreetingId 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="greetingId">Greeting ID</param>
        /// <param name="body">The updated Greeting</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> PutGreetingIdAsyncWithHttpInfo (string greetingId, Greeting body)
        {
            // verify the required parameter 'greetingId' is set
            if (greetingId == null)
                throw new ApiException(400, "Missing required parameter 'greetingId' when calling GreetingsApi->PutGreetingId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->PutGreetingId");

            var localVarPath = "/api/v2/greetings/{greetingId}";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
=======
            if (greetingId != null) localVarPathParams.Add("greetingId", Configuration.ApiClient.ParameterToString(greetingId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutGreetingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutGreetingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Creates a Greeting for a User 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
<<<<<<< HEAD
        /// <param name="body">The Greeting to create</param>
        /// <returns>Greeting</returns>
        public Greeting UsersUseridGreetingsPost (string userId, Greeting body)
        {
             ApiResponse<Greeting> localVarResponse = UsersUseridGreetingsPostWithHttpInfo(userId, body);
=======
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>DefaultGreetingList</returns>
        public DefaultGreetingList PutUserIdGreetingsDefaults (string userId, DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = PutUserIdGreetingsDefaultsWithHttpInfo(userId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a Greeting for a User 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
<<<<<<< HEAD
        /// <param name="body">The Greeting to create</param>
        /// <returns>ApiResponse of Greeting</returns>
        public ApiResponse< Greeting > UsersUseridGreetingsPostWithHttpInfo (string userId, Greeting body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->UsersUseridGreetingsPost");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->UsersUseridGreetingsPost");

            var localVarPath = "/api/v1/users/{userId}/greetings";
=======
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>ApiResponse of DefaultGreetingList</returns>
        public ApiResponse< DefaultGreetingList > PutUserIdGreetingsDefaultsWithHttpInfo (string userId, DefaultGreetingList body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->PutUserIdGreetingsDefaults");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->PutUserIdGreetingsDefaults");

            var localVarPath = "/api/v2/users/{userId}/greetings/defaults";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
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
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutUserIdGreetingsDefaults: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserIdGreetingsDefaults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultGreetingList)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Creates a Greeting for a User 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
<<<<<<< HEAD
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of Greeting</returns>
        public async System.Threading.Tasks.Task<Greeting> UsersUseridGreetingsPostAsync (string userId, Greeting body)
        {
             ApiResponse<Greeting> localVarResponse = await UsersUseridGreetingsPostAsyncWithHttpInfo(userId, body);
=======
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of DefaultGreetingList</returns>
        public async System.Threading.Tasks.Task<DefaultGreetingList> PutUserIdGreetingsDefaultsAsync (string userId, DefaultGreetingList body)
        {
             ApiResponse<DefaultGreetingList> localVarResponse = await PutUserIdGreetingsDefaultsAsyncWithHttpInfo(userId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a Greeting for a User 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
<<<<<<< HEAD
        /// <param name="body">The Greeting to create</param>
        /// <returns>Task of ApiResponse (Greeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Greeting>> UsersUseridGreetingsPostAsyncWithHttpInfo (string userId, Greeting body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->UsersUseridGreetingsPost");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->UsersUseridGreetingsPost");

            var localVarPath = "/api/v1/users/{userId}/greetings";
=======
        /// <param name="body">The updated defaultGreetingList</param>
        /// <returns>Task of ApiResponse (DefaultGreetingList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultGreetingList>> PutUserIdGreetingsDefaultsAsyncWithHttpInfo (string userId, DefaultGreetingList body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GreetingsApi->PutUserIdGreetingsDefaults");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GreetingsApi->PutUserIdGreetingsDefaults");

            var localVarPath = "/api/v2/users/{userId}/greetings/defaults";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
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
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGreetingsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Greeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Greeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Greeting)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutUserIdGreetingsDefaults: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserIdGreetingsDefaults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DefaultGreetingList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultGreetingList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultGreetingList)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

    }
}
