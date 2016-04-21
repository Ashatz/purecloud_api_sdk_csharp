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
    public interface IPresenceApi
    {
        #region Synchronous Operations
        /// <summary>
<<<<<<< HEAD
        /// Get an Organization&#39;s list of Presences
=======
        /// Delete an OrganizationPresence
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>OrganizationPresenceEntityListing</returns>
        OrganizationPresenceEntityListing PresencedefinitionsGet (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get an Organization&#39;s list of Presences
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence DeletePresenceId (string presenceId);

        /// <summary>
        /// Delete an OrganizationPresence
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of OrganizationPresenceEntityListing</returns>
        ApiResponse<OrganizationPresenceEntityListing> PresencedefinitionsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null);
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> DeletePresenceIdWithHttpInfo (string presenceId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PresencedefinitionsPost (OrganizationPresence body);
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence GetPresenceId (string presenceId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PresencedefinitionsPostWithHttpInfo (OrganizationPresence body);
        /// <summary>
        /// Delete an OrganizationPresence
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> GetPresenceIdWithHttpInfo (string presenceId);
        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>OrganizationPresenceEntityListing</returns>
        OrganizationPresenceEntityListing GetPresencedefinitions (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of OrganizationPresenceEntityListing</returns>
        ApiResponse<OrganizationPresenceEntityListing> GetPresencedefinitionsWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Get a user&#39;s Presence
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PresencedefinitionsPresenceidDelete (string presenceId);

        /// <summary>
        /// Delete an OrganizationPresence
=======
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <returns>UserPresence</returns>
        UserPresence GetUserIdPresencesSource (string userId, string source);

        /// <summary>
        /// Get a user&#39;s Presence
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PresencedefinitionsPresenceidDeleteWithHttpInfo (string presenceId);
=======
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> GetUserIdPresencesSourceWithHttpInfo (string userId, string source);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Patch a user&#39;s Presence
        /// </summary>
        /// <remarks>
        /// The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PresencedefinitionsPresenceidGet (string presenceId);
=======
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <param name="body"> (optional)</param>
        /// <returns>UserPresence</returns>
        UserPresence PatchUserIdPresencesSource (string userId, string source, UserPresence body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Patch a user&#39;s Presence
        /// </summary>
        /// <remarks>
        /// The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PresencedefinitionsPresenceidGetWithHttpInfo (string presenceId);
=======
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> PatchUserIdPresencesSourceWithHttpInfo (string userId, string source, UserPresence body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PresencedefinitionsPresenceidPut (string presenceId, OrganizationPresence body);
=======
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PostPresencedefinitions (OrganizationPresence body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PresencedefinitionsPresenceidPutWithHttpInfo (string presenceId, OrganizationPresence body);
=======
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PostPresencedefinitionsWithHttpInfo (OrganizationPresence body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get an User&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>UserPresenceEntityListing</returns>
        UserPresenceEntityListing UsersUseridPresencesGet (string userId, int? pageNumber = null, int? pageSize = null);
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>OrganizationPresence</returns>
        OrganizationPresence PutPresenceId (string presenceId, OrganizationPresence body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get an User&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of UserPresenceEntityListing</returns>
        ApiResponse<UserPresenceEntityListing> UsersUseridPresencesGetWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null);
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        ApiResponse<OrganizationPresence> PutPresenceIdWithHttpInfo (string presenceId, OrganizationPresence body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>UserPresence</returns>
        UserPresence UsersUseridPresencesSourceGet (string userId, string source);
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> DeletePresenceIdAsync (string presenceId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> UsersUseridPresencesSourceGetWithHttpInfo (string userId, string source);
        /// <summary>
        /// Patch a UserPresence
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> DeletePresenceIdAsyncWithHttpInfo (string presenceId);
        /// <summary>
        /// Get an OrganizationPresence
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>UserPresence</returns>
        UserPresence UsersUseridPresencesSourcePatch (string userId, string source, UserPresence body);

        /// <summary>
        /// Patch a UserPresence
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> GetPresenceIdAsync (string presenceId);

        /// <summary>
        /// Get an OrganizationPresence
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> UsersUseridPresencesSourcePatchWithHttpInfo (string userId, string source, UserPresence body);
        /// <summary>
        /// Update a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>UserPresence</returns>
        UserPresence UsersUseridPresencesSourcePut (string userId, string source, UserPresence body);

        /// <summary>
        /// Update a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> UsersUseridPresencesSourcePutWithHttpInfo (string userId, string source, UserPresence body);
        /// <summary>
        /// Get a user&#39;s Primary UserPresence
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> GetPresenceIdAsyncWithHttpInfo (string presenceId);
        /// <summary>
        /// Get an Organization&#39;s list of Presences
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <returns>UserPresence</returns>
        UserPresence UsersUseridPrimarypresenceGet (string userId);

        /// <summary>
        /// Get a user&#39;s Primary UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserPresence</returns>
        ApiResponse<UserPresence> UsersUseridPrimarypresenceGetWithHttpInfo (string userId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of OrganizationPresenceEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationPresenceEntityListing> PresencedefinitionsGetAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
=======
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of OrganizationPresenceEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationPresenceEntityListing> GetPresencedefinitionsAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// Get an Organization&#39;s list of Presences
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (OrganizationPresenceEntityListing)</returns>
<<<<<<< HEAD
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresenceEntityListing>> PresencedefinitionsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPostAsync (OrganizationPresence body);

        /// <summary>
        /// Create an OrganizationPresence
=======
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresenceEntityListing>> GetPresencedefinitionsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Get a user&#39;s Presence
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPostAsyncWithHttpInfo (OrganizationPresence body);
        /// <summary>
        /// Delete an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidDeleteAsync (string presenceId);

        /// <summary>
        /// Delete an OrganizationPresence
=======
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> GetUserIdPresencesSourceAsync (string userId, string source);

        /// <summary>
        /// Get a user&#39;s Presence
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidDeleteAsyncWithHttpInfo (string presenceId);
        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidGetAsync (string presenceId);

        /// <summary>
        /// Get an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidGetAsyncWithHttpInfo (string presenceId);
        /// <summary>
        /// Update an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidPutAsync (string presenceId, OrganizationPresence body);

        /// <summary>
        /// Update an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidPutAsyncWithHttpInfo (string presenceId, OrganizationPresence body);
        /// <summary>
        /// Get an User&#39;s list of Presences
=======
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> GetUserIdPresencesSourceAsyncWithHttpInfo (string userId, string source);
        /// <summary>
        /// Patch a user&#39;s Presence
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of UserPresenceEntityListing</returns>
        System.Threading.Tasks.Task<UserPresenceEntityListing> UsersUseridPresencesGetAsync (string userId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get an User&#39;s list of Presences
=======
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> PatchUserIdPresencesSourceAsync (string userId, string source, UserPresence body = null);

        /// <summary>
        /// Patch a user&#39;s Presence
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (UserPresenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresenceEntityListing>> UsersUseridPresencesGetAsyncWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null);
        /// <summary>
        /// Get a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> UsersUseridPresencesSourceGetAsync (string userId, string source);

        /// <summary>
        /// Get a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourceGetAsyncWithHttpInfo (string userId, string source);
=======
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> PatchUserIdPresencesSourceAsyncWithHttpInfo (string userId, string source, UserPresence body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Create an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> UsersUseridPresencesSourcePatchAsync (string userId, string source, UserPresence body);

        /// <summary>
        /// Patch a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourcePatchAsyncWithHttpInfo (string userId, string source, UserPresence body);
        /// <summary>
        /// Update a UserPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> UsersUseridPresencesSourcePutAsync (string userId, string source, UserPresence body);

        /// <summary>
        /// Update a UserPresence
=======
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PostPresencedefinitionsAsync (OrganizationPresence body);

        /// <summary>
        /// Create an OrganizationPresence
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourcePutAsyncWithHttpInfo (string userId, string source, UserPresence body);
=======
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PostPresencedefinitionsAsyncWithHttpInfo (OrganizationPresence body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Update an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserPresence</returns>
        System.Threading.Tasks.Task<UserPresence> UsersUseridPrimarypresenceGetAsync (string userId);
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of OrganizationPresence</returns>
        System.Threading.Tasks.Task<OrganizationPresence> PutPresenceIdAsync (string presenceId, OrganizationPresence body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Update an OrganizationPresence
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPrimarypresenceGetAsyncWithHttpInfo (string userId);
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PutPresenceIdAsyncWithHttpInfo (string presenceId, OrganizationPresence body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PresenceApi : IPresenceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PresenceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PresenceApi(Configuration configuration = null)
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
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>OrganizationPresenceEntityListing</returns>
        public OrganizationPresenceEntityListing PresencedefinitionsGet (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<OrganizationPresenceEntityListing> localVarResponse = PresencedefinitionsGetWithHttpInfo(pageNumber, pageSize);
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence DeletePresenceId (string presenceId)
        {
             ApiResponse<OrganizationPresence> localVarResponse = DeletePresenceIdWithHttpInfo(presenceId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of OrganizationPresenceEntityListing</returns>
        public ApiResponse< OrganizationPresenceEntityListing > PresencedefinitionsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {

            var localVarPath = "/api/v1/presencedefinitions";
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > DeletePresenceIdWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->DeletePresenceId");

            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
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
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
=======
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresenceEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeletePresenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePresenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of OrganizationPresenceEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationPresenceEntityListing> PresencedefinitionsGetAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<OrganizationPresenceEntityListing> localVarResponse = await PresencedefinitionsGetAsyncWithHttpInfo(pageNumber, pageSize);
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> DeletePresenceIdAsync (string presenceId)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await DeletePresenceIdAsyncWithHttpInfo(presenceId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (OrganizationPresenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresenceEntityListing>> PresencedefinitionsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {

            var localVarPath = "/api/v1/presencedefinitions";
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> DeletePresenceIdAsyncWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->DeletePresenceId");

            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
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
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
=======
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresenceEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeletePresenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePresenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">The OrganizationPresence to create</param>
=======
        /// <param name="presenceId">Organization Presence ID</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence GetPresenceId (string presenceId)
        {
<<<<<<< HEAD
             ApiResponse<OrganizationPresence> localVarResponse = PresencedefinitionsPostWithHttpInfo(body);
=======
             ApiResponse<OrganizationPresence> localVarResponse = GetPresenceIdWithHttpInfo(presenceId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">The OrganizationPresence to create</param>
=======
        /// <param name="presenceId">Organization Presence ID</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > GetPresenceIdWithHttpInfo (string presenceId)
        {
<<<<<<< HEAD
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PresencedefinitionsPost");

            var localVarPath = "/api/v1/presencedefinitions";
=======
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->GetPresenceId");

            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
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
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
<<<<<<< HEAD

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }

        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPostAsync (OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await PresencedefinitionsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPostAsyncWithHttpInfo (OrganizationPresence body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PresencedefinitionsPost");

            var localVarPath = "/api/v1/presencedefinitions";
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
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PresencedefinitionsPresenceidDelete (string presenceId)
        {
             ApiResponse<OrganizationPresence> localVarResponse = PresencedefinitionsPresenceidDeleteWithHttpInfo(presenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PresencedefinitionsPresenceidDeleteWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PresencedefinitionsPresenceidDelete");

            var localVarPath = "/api/v1/presencedefinitions/{presenceId}";
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
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
<<<<<<< HEAD
        public async System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidDeleteAsync (string presenceId)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await PresencedefinitionsPresenceidDeleteAsyncWithHttpInfo(presenceId);
=======
        public async System.Threading.Tasks.Task<OrganizationPresence> GetPresenceIdAsync (string presenceId)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await GetPresenceIdAsyncWithHttpInfo(presenceId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
<<<<<<< HEAD
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidDeleteAsyncWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PresencedefinitionsPresenceidDelete");

            var localVarPath = "/api/v1/presencedefinitions/{presenceId}";
=======
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> GetPresenceIdAsyncWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->GetPresenceId");

            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
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
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter

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
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }

        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PresencedefinitionsPresenceidGet (string presenceId)
        {
             ApiResponse<OrganizationPresence> localVarResponse = PresencedefinitionsPresenceidGetWithHttpInfo(presenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PresencedefinitionsPresenceidGetWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PresencedefinitionsPresenceidGet");

            var localVarPath = "/api/v1/presencedefinitions/{presenceId}";
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
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidGetAsync (string presenceId)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await PresencedefinitionsPresenceidGetAsyncWithHttpInfo(presenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidGetAsyncWithHttpInfo (string presenceId)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PresencedefinitionsPresenceidGet");

            var localVarPath = "/api/v1/presencedefinitions/{presenceId}";
=======
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>OrganizationPresenceEntityListing</returns>
        public OrganizationPresenceEntityListing GetPresencedefinitions (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<OrganizationPresenceEntityListing> localVarResponse = GetPresencedefinitionsWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of OrganizationPresenceEntityListing</returns>
        public ApiResponse< OrganizationPresenceEntityListing > GetPresencedefinitionsWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {

            var localVarPath = "/api/v2/presencedefinitions";
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
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
=======
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
<<<<<<< HEAD
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PresencedefinitionsPresenceidPut (string presenceId, OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = PresencedefinitionsPresenceidPutWithHttpInfo(presenceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PresencedefinitionsPresenceidPutWithHttpInfo (string presenceId, OrganizationPresence body)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PresencedefinitionsPresenceidPut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PresencedefinitionsPresenceidPut");

            var localVarPath = "/api/v1/presencedefinitions/{presenceId}";
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
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
=======
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinitions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresenceEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> PresencedefinitionsPresenceidPutAsync (string presenceId, OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await PresencedefinitionsPresenceidPutAsyncWithHttpInfo(presenceId, body);
=======
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of OrganizationPresenceEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationPresenceEntityListing> GetPresencedefinitionsAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<OrganizationPresenceEntityListing> localVarResponse = await GetPresencedefinitionsAsyncWithHttpInfo(pageNumber, pageSize);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Update an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PresencedefinitionsPresenceidPutAsyncWithHttpInfo (string presenceId, OrganizationPresence body)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PresencedefinitionsPresenceidPut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PresencedefinitionsPresenceidPut");

            var localVarPath = "/api/v1/presencedefinitions/{presenceId}";
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
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresencedefinitionsPresenceidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
            
        }

        /// <summary>
        /// Get an User&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>UserPresenceEntityListing</returns>
        public UserPresenceEntityListing UsersUseridPresencesGet (string userId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<UserPresenceEntityListing> localVarResponse = UsersUseridPresencesGetWithHttpInfo(userId, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an User&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of UserPresenceEntityListing</returns>
        public ApiResponse< UserPresenceEntityListing > UsersUseridPresencesGetWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesGet");

            var localVarPath = "/api/v1/users/{userId}/presences";
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
=======
        /// Get an Organization&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (OrganizationPresenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresenceEntityListing>> GetPresencedefinitionsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {

            var localVarPath = "/api/v2/presencedefinitions";
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
<<<<<<< HEAD

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresenceEntityListing)));
            
        }

        /// <summary>
        /// Get an User&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of UserPresenceEntityListing</returns>
        public async System.Threading.Tasks.Task<UserPresenceEntityListing> UsersUseridPresencesGetAsync (string userId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<UserPresenceEntityListing> localVarResponse = await UsersUseridPresencesGetAsyncWithHttpInfo(userId, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an User&#39;s list of Presences 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (UserPresenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresenceEntityListing>> UsersUseridPresencesGetAsyncWithHttpInfo (string userId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesGet");

            var localVarPath = "/api/v1/users/{userId}/presences";
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
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresenceEntityListing)));
=======

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinitions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPresencedefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresenceEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get a user&#39;s Presence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
=======
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <returns>UserPresence</returns>
        public UserPresence GetUserIdPresencesSource (string userId, string source)
        {
<<<<<<< HEAD
             ApiResponse<UserPresence> localVarResponse = UsersUseridPresencesSourceGetWithHttpInfo(userId, source);
=======
             ApiResponse<UserPresence> localVarResponse = GetUserIdPresencesSourceWithHttpInfo(userId, source);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user&#39;s Presence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
=======
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > GetUserIdPresencesSourceWithHttpInfo (string userId, string source)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesSourceGet");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->UsersUseridPresencesSourceGet");

            var localVarPath = "/api/v1/users/{userId}/presences/{source}";
=======
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->GetUserIdPresencesSource");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->GetUserIdPresencesSource");

            var localVarPath = "/api/v2/users/{userId}/presences/{source}";
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
            if (source != null) localVarPathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdPresencesSource: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdPresencesSource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }

        /// <summary>
        /// Get a user&#39;s Presence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
=======
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> GetUserIdPresencesSourceAsync (string userId, string source)
        {
<<<<<<< HEAD
             ApiResponse<UserPresence> localVarResponse = await UsersUseridPresencesSourceGetAsyncWithHttpInfo(userId, source);
=======
             ApiResponse<UserPresence> localVarResponse = await GetUserIdPresencesSourceAsyncWithHttpInfo(userId, source);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user&#39;s Presence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
=======
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> GetUserIdPresencesSourceAsyncWithHttpInfo (string userId, string source)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesSourceGet");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->UsersUseridPresencesSourceGet");

            var localVarPath = "/api/v1/users/{userId}/presences/{source}";
=======
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->GetUserIdPresencesSource");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->GetUserIdPresencesSource");

            var localVarPath = "/api/v2/users/{userId}/presences/{source}";
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
            if (source != null) localVarPathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdPresencesSource: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdPresencesSource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Patch a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>UserPresence</returns>
        public UserPresence UsersUseridPresencesSourcePatch (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> localVarResponse = UsersUseridPresencesSourcePatchWithHttpInfo(userId, source, body);
=======
        /// Patch a user&#39;s Presence The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <param name="body"> (optional)</param>
        /// <returns>UserPresence</returns>
        public UserPresence PatchUserIdPresencesSource (string userId, string source, UserPresence body = null)
        {
             ApiResponse<UserPresence> localVarResponse = PatchUserIdPresencesSourceWithHttpInfo(userId, source, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Patch a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > UsersUseridPresencesSourcePatchWithHttpInfo (string userId, string source, UserPresence body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesSourcePatch");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->UsersUseridPresencesSourcePatch");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->UsersUseridPresencesSourcePatch");

            var localVarPath = "/api/v1/users/{userId}/presences/{source}";
=======
        /// Patch a user&#39;s Presence The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > PatchUserIdPresencesSourceWithHttpInfo (string userId, string source, UserPresence body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->PatchUserIdPresencesSource");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->PatchUserIdPresencesSource");

            var localVarPath = "/api/v2/users/{userId}/presences/{source}";
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
            if (source != null) localVarPathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PatchUserIdPresencesSource: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserIdPresencesSource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Patch a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> UsersUseridPresencesSourcePatchAsync (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> localVarResponse = await UsersUseridPresencesSourcePatchAsyncWithHttpInfo(userId, source, body);
=======
        /// Patch a user&#39;s Presence The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> PatchUserIdPresencesSourceAsync (string userId, string source, UserPresence body = null)
        {
             ApiResponse<UserPresence> localVarResponse = await PatchUserIdPresencesSourceAsyncWithHttpInfo(userId, source, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Patch a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The patched UserPresence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourcePatchAsyncWithHttpInfo (string userId, string source, UserPresence body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesSourcePatch");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->UsersUseridPresencesSourcePatch");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->UsersUseridPresencesSourcePatch");

            var localVarPath = "/api/v1/users/{userId}/presences/{source}";
=======
        /// Patch a user&#39;s Presence The presence object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the &#39;source&#39; defined in the path as the user&#39;s primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="source">source</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> PatchUserIdPresencesSourceAsyncWithHttpInfo (string userId, string source, UserPresence body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->PatchUserIdPresencesSource");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->PatchUserIdPresencesSource");

            var localVarPath = "/api/v2/users/{userId}/presences/{source}";
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
            if (source != null) localVarPathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PatchUserIdPresencesSource: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserIdPresencesSource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>UserPresence</returns>
        public UserPresence UsersUseridPresencesSourcePut (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> localVarResponse = UsersUseridPresencesSourcePutWithHttpInfo(userId, source, body);
=======
        /// Create an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PostPresencedefinitions (OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = PostPresencedefinitionsWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Update a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > UsersUseridPresencesSourcePutWithHttpInfo (string userId, string source, UserPresence body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesSourcePut");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->UsersUseridPresencesSourcePut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->UsersUseridPresencesSourcePut");

            var localVarPath = "/api/v1/users/{userId}/presences/{source}";
=======
        /// Create an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PostPresencedefinitionsWithHttpInfo (OrganizationPresence body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PostPresencedefinitions");

            var localVarPath = "/api/v2/presencedefinitions";
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
            if (source != null) localVarPathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
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
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostPresencedefinitions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostPresencedefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> UsersUseridPresencesSourcePutAsync (string userId, string source, UserPresence body)
        {
             ApiResponse<UserPresence> localVarResponse = await UsersUseridPresencesSourcePutAsyncWithHttpInfo(userId, source, body);
=======
        /// Create an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> PostPresencedefinitionsAsync (OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await PostPresencedefinitionsAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Update a UserPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="source">Source</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPresencesSourcePutAsyncWithHttpInfo (string userId, string source, UserPresence body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPresencesSourcePut");
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PresenceApi->UsersUseridPresencesSourcePut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->UsersUseridPresencesSourcePut");

            var localVarPath = "/api/v1/users/{userId}/presences/{source}";
=======
        /// Create an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The OrganizationPresence to create</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PostPresencedefinitionsAsyncWithHttpInfo (OrganizationPresence body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PostPresencedefinitions");

            var localVarPath = "/api/v2/presencedefinitions";
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
            if (source != null) localVarPathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
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
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPresencesSourcePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostPresencedefinitions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostPresencedefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <returns>UserPresence</returns>
        public UserPresence UsersUseridPrimarypresenceGet (string userId)
        {
             ApiResponse<UserPresence> localVarResponse = UsersUseridPrimarypresenceGetWithHttpInfo(userId);
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>OrganizationPresence</returns>
        public OrganizationPresence PutPresenceId (string presenceId, OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = PutPresenceIdWithHttpInfo(presenceId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserPresence</returns>
        public ApiResponse< UserPresence > UsersUseridPrimarypresenceGetWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPrimarypresenceGet");

            var localVarPath = "/api/v1/users/{userId}/primarypresence";
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>ApiResponse of OrganizationPresence</returns>
        public ApiResponse< OrganizationPresence > PutPresenceIdWithHttpInfo (string presenceId, OrganizationPresence body)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PutPresenceId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PutPresenceId");

            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
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
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresenceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresenceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserPresence</returns>
        public async System.Threading.Tasks.Task<UserPresence> UsersUseridPrimarypresenceGetAsync (string userId)
        {
             ApiResponse<UserPresence> localVarResponse = await UsersUseridPrimarypresenceGetAsyncWithHttpInfo(userId);
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of OrganizationPresence</returns>
        public async System.Threading.Tasks.Task<OrganizationPresence> PutPresenceIdAsync (string presenceId, OrganizationPresence body)
        {
             ApiResponse<OrganizationPresence> localVarResponse = await PutPresenceIdAsyncWithHttpInfo(presenceId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an OrganizationPresence 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserPresence>> UsersUseridPrimarypresenceGetAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling PresenceApi->UsersUseridPrimarypresenceGet");

            var localVarPath = "/api/v1/users/{userId}/primarypresence";
=======
        /// <param name="presenceId">Organization Presence ID</param>
        /// <param name="body">The OrganizationPresence to update</param>
        /// <returns>Task of ApiResponse (OrganizationPresence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationPresence>> PutPresenceIdAsyncWithHttpInfo (string presenceId, OrganizationPresence body)
        {
            // verify the required parameter 'presenceId' is set
            if (presenceId == null)
                throw new ApiException(400, "Missing required parameter 'presenceId' when calling PresenceApi->PutPresenceId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PresenceApi->PutPresenceId");

            var localVarPath = "/api/v2/presencedefinitions/{presenceId}";
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
            if (presenceId != null) localVarPathParams.Add("presenceId", Configuration.ApiClient.ParameterToString(presenceId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresenceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresenceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserPresence)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPresenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationPresence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationPresence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationPresence)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

    }
}
