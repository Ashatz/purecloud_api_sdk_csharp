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
    public interface IUsersApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the list of available users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="role">Role (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="username">Username (optional)</param>
        /// <param name="skill">Skill (optional)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>UsersEntityListing</returns>
        UsersEntityListing UsersGet (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null);

        /// <summary>
        /// Get the list of available users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="role">Role (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="username">Username (optional)</param>
        /// <param name="skill">Skill (optional)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of UsersEntityListing</returns>
        ApiResponse<UsersEntityListing> UsersGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null);
        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>User</returns>
        User UsersMeGet (List<string> expand = null);

        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> UsersMeGetWithHttpInfo (List<string> expand = null);
        /// <summary>
        /// Create a configuration service user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User (optional)</param>
        /// <returns>User</returns>
        User UsersPost (User body = null);

        /// <summary>
        /// Create a configuration service user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User (optional)</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> UsersPostWithHttpInfo (User body = null);
        /// <summary>
        /// Get a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>CallForwarding</returns>
        CallForwarding UsersUseridCallforwardingGet (string userId);

        /// <summary>
        /// Get a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of CallForwarding</returns>
        ApiResponse<CallForwarding> UsersUseridCallforwardingGetWithHttpInfo (string userId);
        /// <summary>
        /// Patch a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>CallForwarding</returns>
        CallForwarding UsersUseridCallforwardingPatch (string userId, CallForwarding body = null);

        /// <summary>
        /// Patch a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CallForwarding</returns>
        ApiResponse<CallForwarding> UsersUseridCallforwardingPatchWithHttpInfo (string userId, CallForwarding body = null);
        /// <summary>
        /// Update a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>CallForwarding</returns>
        CallForwarding UsersUseridCallforwardingPut (string userId, CallForwarding body = null);

        /// <summary>
        /// Update a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CallForwarding</returns>
        ApiResponse<CallForwarding> UsersUseridCallforwardingPutWithHttpInfo (string userId, CallForwarding body = null);
        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Geolocation</returns>
        Geolocation UsersUseridGeolocationsClientidGet (string userId, string clientId);

        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>ApiResponse of Geolocation</returns>
        ApiResponse<Geolocation> UsersUseridGeolocationsClientidGetWithHttpInfo (string userId, string clientId);
        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Geolocation</returns>
        Geolocation UsersUseridGeolocationsClientidPatch (string userId, string clientId, Geolocation body = null);

        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Geolocation</returns>
        ApiResponse<Geolocation> UsersUseridGeolocationsClientidPatchWithHttpInfo (string userId, string clientId, Geolocation body = null);
        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>User</returns>
        User UsersUseridGet (string userId, List<string> expand = null);

        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> UsersUseridGetWithHttpInfo (string userId, List<string> expand = null);
        /// <summary>
        /// Get a OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>OutOfOffice</returns>
        OutOfOffice UsersUseridOutofofficeGet (string userId);

        /// <summary>
        /// Get a OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of OutOfOffice</returns>
        ApiResponse<OutOfOffice> UsersUseridOutofofficeGetWithHttpInfo (string userId);
        /// <summary>
        /// Update an OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>OutOfOffice</returns>
        OutOfOffice UsersUseridOutofofficePut (string userId, OutOfOffice body);

        /// <summary>
        /// Update an OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>ApiResponse of OutOfOffice</returns>
        ApiResponse<OutOfOffice> UsersUseridOutofofficePutWithHttpInfo (string userId, OutOfOffice body);
        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>PrimaryUserPresenceSource</returns>
        PrimaryUserPresenceSource UsersUseridPrimarypresencesourceGet (string userId);

        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of PrimaryUserPresenceSource</returns>
        ApiResponse<PrimaryUserPresenceSource> UsersUseridPrimarypresencesourceGetWithHttpInfo (string userId);
        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>PrimaryUserPresenceSource</returns>
        PrimaryUserPresenceSource UsersUseridPrimarypresencesourcePut (string userId, PrimaryUserPresenceSource body = null);

        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PrimaryUserPresenceSource</returns>
        ApiResponse<PrimaryUserPresenceSource> UsersUseridPrimarypresencesourcePutWithHttpInfo (string userId, PrimaryUserPresenceSource body = null);
        /// <summary>
        /// Set user station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">stationUri</param>
        /// <returns>User</returns>
        User UsersUseridPut (string userId, User body);

        /// <summary>
        /// Set user station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">stationUri</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> UsersUseridPutWithHttpInfo (string userId, User body);
        /// <summary>
        /// Get queues for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>UserQueueEntityListing</returns>
        UserQueueEntityListing UsersUseridQueuesGet (string userId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get queues for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of UserQueueEntityListing</returns>
        ApiResponse<UserQueueEntityListing> UsersUseridQueuesGetWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Join or unjoin a set of queues for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues (optional)</param>
        /// <returns>UserQueue</returns>
        UserQueue UsersUseridQueuesPatch (string userId, List<UserQueue> body = null);

        /// <summary>
        /// Join or unjoin a set of queues for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues (optional)</param>
        /// <returns>ApiResponse of UserQueue</returns>
        ApiResponse<UserQueue> UsersUseridQueuesPatchWithHttpInfo (string userId, List<UserQueue> body = null);
        /// <summary>
        /// Join or unjoin a queue for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>UserQueue</returns>
        UserQueue UsersUseridQueuesQueueidPatch (string queueId, string userId, UserQueue body = null);

        /// <summary>
        /// Join or unjoin a queue for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>ApiResponse of UserQueue</returns>
        ApiResponse<UserQueue> UsersUseridQueuesQueueidPatchWithHttpInfo (string queueId, string userId, UserQueue body = null);
        /// <summary>
        /// List roles for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>List&lt;DomainOrganizationRole&gt;</returns>
        List<DomainOrganizationRole> UsersUseridRolesGet (string userId);

        /// <summary>
        /// List roles for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of List&lt;DomainOrganizationRole&gt;</returns>
        ApiResponse<List<DomainOrganizationRole>> UsersUseridRolesGetWithHttpInfo (string userId);
        /// <summary>
        /// Fetch the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>RoutingStatus</returns>
        RoutingStatus UsersUseridRoutingstatusGet (string userId);

        /// <summary>
        /// Fetch the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of RoutingStatus</returns>
        ApiResponse<RoutingStatus> UsersUseridRoutingstatusGetWithHttpInfo (string userId);
        /// <summary>
        /// Update the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status (optional)</param>
        /// <returns>RoutingStatus</returns>
        RoutingStatus UsersUseridRoutingstatusPut (string userId, RoutingStatus body = null);

        /// <summary>
        /// Update the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status (optional)</param>
        /// <returns>ApiResponse of RoutingStatus</returns>
        ApiResponse<RoutingStatus> UsersUseridRoutingstatusPutWithHttpInfo (string userId, RoutingStatus body = null);
        /// <summary>
        /// List skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>UserSkillEntityListing</returns>
        UserSkillEntityListing UsersUseridSkillsGet (string userId);

        /// <summary>
        /// List skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserSkillEntityListing</returns>
        ApiResponse<UserSkillEntityListing> UsersUseridSkillsGetWithHttpInfo (string userId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get the list of available users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="role">Role (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="username">Username (optional)</param>
        /// <param name="skill">Skill (optional)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of UsersEntityListing</returns>
        System.Threading.Tasks.Task<UsersEntityListing> UsersGetAsync (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null);

        /// <summary>
        /// Get the list of available users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="role">Role (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="username">Username (optional)</param>
        /// <param name="skill">Skill (optional)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (UsersEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsersEntityListing>> UsersGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null);
        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> UsersMeGetAsync (List<string> expand = null);

        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> UsersMeGetAsyncWithHttpInfo (List<string> expand = null);
        /// <summary>
        /// Create a configuration service user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User (optional)</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> UsersPostAsync (User body = null);

        /// <summary>
        /// Create a configuration service user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User (optional)</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> UsersPostAsyncWithHttpInfo (User body = null);
        /// <summary>
        /// Get a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of CallForwarding</returns>
        System.Threading.Tasks.Task<CallForwarding> UsersUseridCallforwardingGetAsync (string userId);

        /// <summary>
        /// Get a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallForwarding>> UsersUseridCallforwardingGetAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Patch a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CallForwarding</returns>
        System.Threading.Tasks.Task<CallForwarding> UsersUseridCallforwardingPatchAsync (string userId, CallForwarding body = null);

        /// <summary>
        /// Patch a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallForwarding>> UsersUseridCallforwardingPatchAsyncWithHttpInfo (string userId, CallForwarding body = null);
        /// <summary>
        /// Update a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CallForwarding</returns>
        System.Threading.Tasks.Task<CallForwarding> UsersUseridCallforwardingPutAsync (string userId, CallForwarding body = null);

        /// <summary>
        /// Update a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallForwarding>> UsersUseridCallforwardingPutAsyncWithHttpInfo (string userId, CallForwarding body = null);
        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of Geolocation</returns>
        System.Threading.Tasks.Task<Geolocation> UsersUseridGeolocationsClientidGetAsync (string userId, string clientId);

        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Geolocation>> UsersUseridGeolocationsClientidGetAsyncWithHttpInfo (string userId, string clientId);
        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Geolocation</returns>
        System.Threading.Tasks.Task<Geolocation> UsersUseridGeolocationsClientidPatchAsync (string userId, string clientId, Geolocation body = null);

        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Geolocation>> UsersUseridGeolocationsClientidPatchAsyncWithHttpInfo (string userId, string clientId, Geolocation body = null);
        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> UsersUseridGetAsync (string userId, List<string> expand = null);

        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> UsersUseridGetAsyncWithHttpInfo (string userId, List<string> expand = null);
        /// <summary>
        /// Get a OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of OutOfOffice</returns>
        System.Threading.Tasks.Task<OutOfOffice> UsersUseridOutofofficeGetAsync (string userId);

        /// <summary>
        /// Get a OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (OutOfOffice)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutOfOffice>> UsersUseridOutofofficeGetAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Update an OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of OutOfOffice</returns>
        System.Threading.Tasks.Task<OutOfOffice> UsersUseridOutofofficePutAsync (string userId, OutOfOffice body);

        /// <summary>
        /// Update an OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of ApiResponse (OutOfOffice)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutOfOffice>> UsersUseridOutofofficePutAsyncWithHttpInfo (string userId, OutOfOffice body);
        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of PrimaryUserPresenceSource</returns>
        System.Threading.Tasks.Task<PrimaryUserPresenceSource> UsersUseridPrimarypresencesourceGetAsync (string userId);

        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (PrimaryUserPresenceSource)</returns>
        System.Threading.Tasks.Task<ApiResponse<PrimaryUserPresenceSource>> UsersUseridPrimarypresencesourceGetAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PrimaryUserPresenceSource</returns>
        System.Threading.Tasks.Task<PrimaryUserPresenceSource> UsersUseridPrimarypresencesourcePutAsync (string userId, PrimaryUserPresenceSource body = null);

        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PrimaryUserPresenceSource)</returns>
        System.Threading.Tasks.Task<ApiResponse<PrimaryUserPresenceSource>> UsersUseridPrimarypresencesourcePutAsyncWithHttpInfo (string userId, PrimaryUserPresenceSource body = null);
        /// <summary>
        /// Set user station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">stationUri</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> UsersUseridPutAsync (string userId, User body);

        /// <summary>
        /// Set user station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">stationUri</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> UsersUseridPutAsyncWithHttpInfo (string userId, User body);
        /// <summary>
        /// Get queues for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of UserQueueEntityListing</returns>
        System.Threading.Tasks.Task<UserQueueEntityListing> UsersUseridQueuesGetAsync (string userId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get queues for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (UserQueueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserQueueEntityListing>> UsersUseridQueuesGetAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Join or unjoin a set of queues for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues (optional)</param>
        /// <returns>Task of UserQueue</returns>
        System.Threading.Tasks.Task<UserQueue> UsersUseridQueuesPatchAsync (string userId, List<UserQueue> body = null);

        /// <summary>
        /// Join or unjoin a set of queues for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues (optional)</param>
        /// <returns>Task of ApiResponse (UserQueue)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserQueue>> UsersUseridQueuesPatchAsyncWithHttpInfo (string userId, List<UserQueue> body = null);
        /// <summary>
        /// Join or unjoin a queue for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>Task of UserQueue</returns>
        System.Threading.Tasks.Task<UserQueue> UsersUseridQueuesQueueidPatchAsync (string queueId, string userId, UserQueue body = null);

        /// <summary>
        /// Join or unjoin a queue for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>Task of ApiResponse (UserQueue)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserQueue>> UsersUseridQueuesQueueidPatchAsyncWithHttpInfo (string queueId, string userId, UserQueue body = null);
        /// <summary>
        /// List roles for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of List&lt;DomainOrganizationRole&gt;</returns>
        System.Threading.Tasks.Task<List<DomainOrganizationRole>> UsersUseridRolesGetAsync (string userId);

        /// <summary>
        /// List roles for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (List&lt;DomainOrganizationRole&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<DomainOrganizationRole>>> UsersUseridRolesGetAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Fetch the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of RoutingStatus</returns>
        System.Threading.Tasks.Task<RoutingStatus> UsersUseridRoutingstatusGetAsync (string userId);

        /// <summary>
        /// Fetch the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (RoutingStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoutingStatus>> UsersUseridRoutingstatusGetAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Update the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status (optional)</param>
        /// <returns>Task of RoutingStatus</returns>
        System.Threading.Tasks.Task<RoutingStatus> UsersUseridRoutingstatusPutAsync (string userId, RoutingStatus body = null);

        /// <summary>
        /// Update the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status (optional)</param>
        /// <returns>Task of ApiResponse (RoutingStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoutingStatus>> UsersUseridRoutingstatusPutAsyncWithHttpInfo (string userId, RoutingStatus body = null);
        /// <summary>
        /// List skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserSkillEntityListing</returns>
        System.Threading.Tasks.Task<UserSkillEntityListing> UsersUseridSkillsGetAsync (string userId);

        /// <summary>
        /// List skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserSkillEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserSkillEntityListing>> UsersUseridSkillsGetAsyncWithHttpInfo (string userId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Configuration configuration = null)
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
        /// Get the list of available users. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="role">Role (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="username">Username (optional)</param>
        /// <param name="skill">Skill (optional)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>UsersEntityListing</returns>
        public UsersEntityListing UsersGet (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null)
        {
             ApiResponse<UsersEntityListing> localVarResponse = UsersGetWithHttpInfo(pageSize, pageNumber, id, sortBy, role, name, username, skill, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of available users. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="role">Role (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="username">Username (optional)</param>
        /// <param name="skill">Skill (optional)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of UsersEntityListing</returns>
        public ApiResponse< UsersEntityListing > UsersGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null)
        {

            var localVarPath = "/api/v1/users";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (role != null) localVarQueryParams.Add("role", Configuration.ApiClient.ParameterToString(role)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (username != null) localVarQueryParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // query parameter
            if (skill != null) localVarQueryParams.Add("skill", Configuration.ApiClient.ParameterToString(skill)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsersEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersEntityListing)));
            
        }

        /// <summary>
        /// Get the list of available users. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="role">Role (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="username">Username (optional)</param>
        /// <param name="skill">Skill (optional)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of UsersEntityListing</returns>
        public async System.Threading.Tasks.Task<UsersEntityListing> UsersGetAsync (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null)
        {
             ApiResponse<UsersEntityListing> localVarResponse = await UsersGetAsyncWithHttpInfo(pageSize, pageNumber, id, sortBy, role, name, username, skill, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of available users. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="role">Role (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="username">Username (optional)</param>
        /// <param name="skill">Skill (optional)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (UsersEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsersEntityListing>> UsersGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null)
        {

            var localVarPath = "/api/v1/users";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (role != null) localVarQueryParams.Add("role", Configuration.ApiClient.ParameterToString(role)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (username != null) localVarQueryParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // query parameter
            if (skill != null) localVarQueryParams.Add("skill", Configuration.ApiClient.ParameterToString(skill)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsersEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsersEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsersEntityListing)));
            
        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>User</returns>
        public User UsersMeGet (List<string> expand = null)
        {
             ApiResponse<User> localVarResponse = UsersMeGetWithHttpInfo(expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > UsersMeGetWithHttpInfo (List<string> expand = null)
        {

            var localVarPath = "/api/v1/users/me";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersMeGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersMeGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> UsersMeGetAsync (List<string> expand = null)
        {
             ApiResponse<User> localVarResponse = await UsersMeGetAsyncWithHttpInfo(expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> UsersMeGetAsyncWithHttpInfo (List<string> expand = null)
        {

            var localVarPath = "/api/v1/users/me";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersMeGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersMeGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Create a configuration service user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User (optional)</param>
        /// <returns>User</returns>
        public User UsersPost (User body = null)
        {
             ApiResponse<User> localVarResponse = UsersPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a configuration service user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User (optional)</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > UsersPostWithHttpInfo (User body = null)
        {

            var localVarPath = "/api/v1/users";
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
                throw new ApiException (localVarStatusCode, "Error calling UsersPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Create a configuration service user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User (optional)</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> UsersPostAsync (User body = null)
        {
             ApiResponse<User> localVarResponse = await UsersPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a configuration service user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">User (optional)</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> UsersPostAsyncWithHttpInfo (User body = null)
        {

            var localVarPath = "/api/v1/users";
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
                throw new ApiException (localVarStatusCode, "Error calling UsersPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Get a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>CallForwarding</returns>
        public CallForwarding UsersUseridCallforwardingGet (string userId)
        {
             ApiResponse<CallForwarding> localVarResponse = UsersUseridCallforwardingGetWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of CallForwarding</returns>
        public ApiResponse< CallForwarding > UsersUseridCallforwardingGetWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridCallforwardingGet");

            var localVarPath = "/api/v1/users/{userId}/callforwarding";
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridCallforwardingGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridCallforwardingGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallForwarding>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallForwarding) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallForwarding)));
            
        }

        /// <summary>
        /// Get a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of CallForwarding</returns>
        public async System.Threading.Tasks.Task<CallForwarding> UsersUseridCallforwardingGetAsync (string userId)
        {
             ApiResponse<CallForwarding> localVarResponse = await UsersUseridCallforwardingGetAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallForwarding>> UsersUseridCallforwardingGetAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridCallforwardingGet");

            var localVarPath = "/api/v1/users/{userId}/callforwarding";
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridCallforwardingGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridCallforwardingGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallForwarding>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallForwarding) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallForwarding)));
            
        }

        /// <summary>
        /// Patch a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>CallForwarding</returns>
        public CallForwarding UsersUseridCallforwardingPatch (string userId, CallForwarding body = null)
        {
             ApiResponse<CallForwarding> localVarResponse = UsersUseridCallforwardingPatchWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CallForwarding</returns>
        public ApiResponse< CallForwarding > UsersUseridCallforwardingPatchWithHttpInfo (string userId, CallForwarding body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridCallforwardingPatch");

            var localVarPath = "/api/v1/users/{userId}/callforwarding";
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridCallforwardingPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridCallforwardingPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallForwarding>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallForwarding) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallForwarding)));
            
        }

        /// <summary>
        /// Patch a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CallForwarding</returns>
        public async System.Threading.Tasks.Task<CallForwarding> UsersUseridCallforwardingPatchAsync (string userId, CallForwarding body = null)
        {
             ApiResponse<CallForwarding> localVarResponse = await UsersUseridCallforwardingPatchAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallForwarding>> UsersUseridCallforwardingPatchAsyncWithHttpInfo (string userId, CallForwarding body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridCallforwardingPatch");

            var localVarPath = "/api/v1/users/{userId}/callforwarding";
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridCallforwardingPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridCallforwardingPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallForwarding>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallForwarding) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallForwarding)));
            
        }

        /// <summary>
        /// Update a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>CallForwarding</returns>
        public CallForwarding UsersUseridCallforwardingPut (string userId, CallForwarding body = null)
        {
             ApiResponse<CallForwarding> localVarResponse = UsersUseridCallforwardingPutWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CallForwarding</returns>
        public ApiResponse< CallForwarding > UsersUseridCallforwardingPutWithHttpInfo (string userId, CallForwarding body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridCallforwardingPut");

            var localVarPath = "/api/v1/users/{userId}/callforwarding";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridCallforwardingPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridCallforwardingPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallForwarding>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallForwarding) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallForwarding)));
            
        }

        /// <summary>
        /// Update a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CallForwarding</returns>
        public async System.Threading.Tasks.Task<CallForwarding> UsersUseridCallforwardingPutAsync (string userId, CallForwarding body = null)
        {
             ApiResponse<CallForwarding> localVarResponse = await UsersUseridCallforwardingPutAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a user&#39;s CallForwarding 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallForwarding>> UsersUseridCallforwardingPutAsyncWithHttpInfo (string userId, CallForwarding body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridCallforwardingPut");

            var localVarPath = "/api/v1/users/{userId}/callforwarding";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridCallforwardingPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridCallforwardingPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallForwarding>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallForwarding) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallForwarding)));
            
        }

        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Geolocation</returns>
        public Geolocation UsersUseridGeolocationsClientidGet (string userId, string clientId)
        {
             ApiResponse<Geolocation> localVarResponse = UsersUseridGeolocationsClientidGetWithHttpInfo(userId, clientId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>ApiResponse of Geolocation</returns>
        public ApiResponse< Geolocation > UsersUseridGeolocationsClientidGetWithHttpInfo (string userId, string clientId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridGeolocationsClientidGet");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsersApi->UsersUseridGeolocationsClientidGet");

            var localVarPath = "/api/v1/users/{userId}/geolocations/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGeolocationsClientidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGeolocationsClientidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Geolocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Geolocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Geolocation)));
            
        }

        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of Geolocation</returns>
        public async System.Threading.Tasks.Task<Geolocation> UsersUseridGeolocationsClientidGetAsync (string userId, string clientId)
        {
             ApiResponse<Geolocation> localVarResponse = await UsersUseridGeolocationsClientidGetAsyncWithHttpInfo(userId, clientId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Geolocation>> UsersUseridGeolocationsClientidGetAsyncWithHttpInfo (string userId, string clientId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridGeolocationsClientidGet");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsersApi->UsersUseridGeolocationsClientidGet");

            var localVarPath = "/api/v1/users/{userId}/geolocations/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGeolocationsClientidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGeolocationsClientidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Geolocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Geolocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Geolocation)));
            
        }

        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Geolocation</returns>
        public Geolocation UsersUseridGeolocationsClientidPatch (string userId, string clientId, Geolocation body = null)
        {
             ApiResponse<Geolocation> localVarResponse = UsersUseridGeolocationsClientidPatchWithHttpInfo(userId, clientId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Geolocation</returns>
        public ApiResponse< Geolocation > UsersUseridGeolocationsClientidPatchWithHttpInfo (string userId, string clientId, Geolocation body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridGeolocationsClientidPatch");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsersApi->UsersUseridGeolocationsClientidPatch");

            var localVarPath = "/api/v1/users/{userId}/geolocations/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGeolocationsClientidPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGeolocationsClientidPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Geolocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Geolocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Geolocation)));
            
        }

        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Geolocation</returns>
        public async System.Threading.Tasks.Task<Geolocation> UsersUseridGeolocationsClientidPatchAsync (string userId, string clientId, Geolocation body = null)
        {
             ApiResponse<Geolocation> localVarResponse = await UsersUseridGeolocationsClientidPatchAsyncWithHttpInfo(userId, clientId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Geolocation>> UsersUseridGeolocationsClientidPatchAsyncWithHttpInfo (string userId, string clientId, Geolocation body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridGeolocationsClientidPatch");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsersApi->UsersUseridGeolocationsClientidPatch");

            var localVarPath = "/api/v1/users/{userId}/geolocations/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGeolocationsClientidPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGeolocationsClientidPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Geolocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Geolocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Geolocation)));
            
        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>User</returns>
        public User UsersUseridGet (string userId, List<string> expand = null)
        {
             ApiResponse<User> localVarResponse = UsersUseridGetWithHttpInfo(userId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > UsersUseridGetWithHttpInfo (string userId, List<string> expand = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridGet");

            var localVarPath = "/api/v1/users/{userId}";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> UsersUseridGetAsync (string userId, List<string> expand = null)
        {
             ApiResponse<User> localVarResponse = await UsersUseridGetAsyncWithHttpInfo(userId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> UsersUseridGetAsyncWithHttpInfo (string userId, List<string> expand = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridGet");

            var localVarPath = "/api/v1/users/{userId}";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Get a OutOfOffice 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>OutOfOffice</returns>
        public OutOfOffice UsersUseridOutofofficeGet (string userId)
        {
             ApiResponse<OutOfOffice> localVarResponse = UsersUseridOutofofficeGetWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a OutOfOffice 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of OutOfOffice</returns>
        public ApiResponse< OutOfOffice > UsersUseridOutofofficeGetWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridOutofofficeGet");

            var localVarPath = "/api/v1/users/{userId}/outofoffice";
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridOutofofficeGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridOutofofficeGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutOfOffice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutOfOffice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutOfOffice)));
            
        }

        /// <summary>
        /// Get a OutOfOffice 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of OutOfOffice</returns>
        public async System.Threading.Tasks.Task<OutOfOffice> UsersUseridOutofofficeGetAsync (string userId)
        {
             ApiResponse<OutOfOffice> localVarResponse = await UsersUseridOutofofficeGetAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a OutOfOffice 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (OutOfOffice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutOfOffice>> UsersUseridOutofofficeGetAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridOutofofficeGet");

            var localVarPath = "/api/v1/users/{userId}/outofoffice";
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridOutofofficeGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridOutofofficeGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutOfOffice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutOfOffice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutOfOffice)));
            
        }

        /// <summary>
        /// Update an OutOfOffice 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>OutOfOffice</returns>
        public OutOfOffice UsersUseridOutofofficePut (string userId, OutOfOffice body)
        {
             ApiResponse<OutOfOffice> localVarResponse = UsersUseridOutofofficePutWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an OutOfOffice 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>ApiResponse of OutOfOffice</returns>
        public ApiResponse< OutOfOffice > UsersUseridOutofofficePutWithHttpInfo (string userId, OutOfOffice body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridOutofofficePut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->UsersUseridOutofofficePut");

            var localVarPath = "/api/v1/users/{userId}/outofoffice";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridOutofofficePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridOutofofficePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutOfOffice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutOfOffice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutOfOffice)));
            
        }

        /// <summary>
        /// Update an OutOfOffice 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of OutOfOffice</returns>
        public async System.Threading.Tasks.Task<OutOfOffice> UsersUseridOutofofficePutAsync (string userId, OutOfOffice body)
        {
             ApiResponse<OutOfOffice> localVarResponse = await UsersUseridOutofofficePutAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an OutOfOffice 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of ApiResponse (OutOfOffice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutOfOffice>> UsersUseridOutofofficePutAsyncWithHttpInfo (string userId, OutOfOffice body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridOutofofficePut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->UsersUseridOutofofficePut");

            var localVarPath = "/api/v1/users/{userId}/outofoffice";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridOutofofficePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridOutofofficePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutOfOffice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutOfOffice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutOfOffice)));
            
        }

        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>PrimaryUserPresenceSource</returns>
        public PrimaryUserPresenceSource UsersUseridPrimarypresencesourceGet (string userId)
        {
             ApiResponse<PrimaryUserPresenceSource> localVarResponse = UsersUseridPrimarypresencesourceGetWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of PrimaryUserPresenceSource</returns>
        public ApiResponse< PrimaryUserPresenceSource > UsersUseridPrimarypresencesourceGetWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridPrimarypresencesourceGet");

            var localVarPath = "/api/v1/users/{userId}/primarypresencesource";
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresencesourceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresencesourceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PrimaryUserPresenceSource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PrimaryUserPresenceSource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PrimaryUserPresenceSource)));
            
        }

        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of PrimaryUserPresenceSource</returns>
        public async System.Threading.Tasks.Task<PrimaryUserPresenceSource> UsersUseridPrimarypresencesourceGetAsync (string userId)
        {
             ApiResponse<PrimaryUserPresenceSource> localVarResponse = await UsersUseridPrimarypresencesourceGetAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (PrimaryUserPresenceSource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PrimaryUserPresenceSource>> UsersUseridPrimarypresencesourceGetAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridPrimarypresencesourceGet");

            var localVarPath = "/api/v1/users/{userId}/primarypresencesource";
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresencesourceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresencesourceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PrimaryUserPresenceSource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PrimaryUserPresenceSource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PrimaryUserPresenceSource)));
            
        }

        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>PrimaryUserPresenceSource</returns>
        public PrimaryUserPresenceSource UsersUseridPrimarypresencesourcePut (string userId, PrimaryUserPresenceSource body = null)
        {
             ApiResponse<PrimaryUserPresenceSource> localVarResponse = UsersUseridPrimarypresencesourcePutWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PrimaryUserPresenceSource</returns>
        public ApiResponse< PrimaryUserPresenceSource > UsersUseridPrimarypresencesourcePutWithHttpInfo (string userId, PrimaryUserPresenceSource body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridPrimarypresencesourcePut");

            var localVarPath = "/api/v1/users/{userId}/primarypresencesource";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresencesourcePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresencesourcePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PrimaryUserPresenceSource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PrimaryUserPresenceSource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PrimaryUserPresenceSource)));
            
        }

        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PrimaryUserPresenceSource</returns>
        public async System.Threading.Tasks.Task<PrimaryUserPresenceSource> UsersUseridPrimarypresencesourcePutAsync (string userId, PrimaryUserPresenceSource body = null)
        {
             ApiResponse<PrimaryUserPresenceSource> localVarResponse = await UsersUseridPrimarypresencesourcePutAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PrimaryUserPresenceSource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PrimaryUserPresenceSource>> UsersUseridPrimarypresencesourcePutAsyncWithHttpInfo (string userId, PrimaryUserPresenceSource body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridPrimarypresencesourcePut");

            var localVarPath = "/api/v1/users/{userId}/primarypresencesource";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresencesourcePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPrimarypresencesourcePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PrimaryUserPresenceSource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PrimaryUserPresenceSource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PrimaryUserPresenceSource)));
            
        }

        /// <summary>
        /// Set user station 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">stationUri</param>
        /// <returns>User</returns>
        public User UsersUseridPut (string userId, User body)
        {
             ApiResponse<User> localVarResponse = UsersUseridPutWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Set user station 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">stationUri</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > UsersUseridPutWithHttpInfo (string userId, User body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridPut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->UsersUseridPut");

            var localVarPath = "/api/v1/users/{userId}";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Set user station 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">stationUri</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> UsersUseridPutAsync (string userId, User body)
        {
             ApiResponse<User> localVarResponse = await UsersUseridPutAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Set user station 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">stationUri</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> UsersUseridPutAsyncWithHttpInfo (string userId, User body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridPut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->UsersUseridPut");

            var localVarPath = "/api/v1/users/{userId}";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Get queues for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>UserQueueEntityListing</returns>
        public UserQueueEntityListing UsersUseridQueuesGet (string userId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<UserQueueEntityListing> localVarResponse = UsersUseridQueuesGetWithHttpInfo(userId, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get queues for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of UserQueueEntityListing</returns>
        public ApiResponse< UserQueueEntityListing > UsersUseridQueuesGetWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridQueuesGet");

            var localVarPath = "/api/v1/users/{userId}/queues";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridQueuesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridQueuesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserQueueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserQueueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserQueueEntityListing)));
            
        }

        /// <summary>
        /// Get queues for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of UserQueueEntityListing</returns>
        public async System.Threading.Tasks.Task<UserQueueEntityListing> UsersUseridQueuesGetAsync (string userId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<UserQueueEntityListing> localVarResponse = await UsersUseridQueuesGetAsyncWithHttpInfo(userId, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get queues for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (UserQueueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserQueueEntityListing>> UsersUseridQueuesGetAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridQueuesGet");

            var localVarPath = "/api/v1/users/{userId}/queues";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridQueuesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridQueuesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserQueueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserQueueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserQueueEntityListing)));
            
        }

        /// <summary>
        /// Join or unjoin a set of queues for a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues (optional)</param>
        /// <returns>UserQueue</returns>
        public UserQueue UsersUseridQueuesPatch (string userId, List<UserQueue> body = null)
        {
             ApiResponse<UserQueue> localVarResponse = UsersUseridQueuesPatchWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Join or unjoin a set of queues for a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues (optional)</param>
        /// <returns>ApiResponse of UserQueue</returns>
        public ApiResponse< UserQueue > UsersUseridQueuesPatchWithHttpInfo (string userId, List<UserQueue> body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridQueuesPatch");

            var localVarPath = "/api/v1/users/{userId}/queues";
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridQueuesPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridQueuesPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserQueue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserQueue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserQueue)));
            
        }

        /// <summary>
        /// Join or unjoin a set of queues for a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues (optional)</param>
        /// <returns>Task of UserQueue</returns>
        public async System.Threading.Tasks.Task<UserQueue> UsersUseridQueuesPatchAsync (string userId, List<UserQueue> body = null)
        {
             ApiResponse<UserQueue> localVarResponse = await UsersUseridQueuesPatchAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Join or unjoin a set of queues for a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues (optional)</param>
        /// <returns>Task of ApiResponse (UserQueue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserQueue>> UsersUseridQueuesPatchAsyncWithHttpInfo (string userId, List<UserQueue> body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridQueuesPatch");

            var localVarPath = "/api/v1/users/{userId}/queues";
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridQueuesPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridQueuesPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserQueue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserQueue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserQueue)));
            
        }

        /// <summary>
        /// Join or unjoin a queue for a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>UserQueue</returns>
        public UserQueue UsersUseridQueuesQueueidPatch (string queueId, string userId, UserQueue body = null)
        {
             ApiResponse<UserQueue> localVarResponse = UsersUseridQueuesQueueidPatchWithHttpInfo(queueId, userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Join or unjoin a queue for a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>ApiResponse of UserQueue</returns>
        public ApiResponse< UserQueue > UsersUseridQueuesQueueidPatchWithHttpInfo (string queueId, string userId, UserQueue body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling UsersApi->UsersUseridQueuesQueueidPatch");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridQueuesQueueidPatch");

            var localVarPath = "/api/v1/users/{userId}/queues/{queueId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridQueuesQueueidPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridQueuesQueueidPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserQueue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserQueue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserQueue)));
            
        }

        /// <summary>
        /// Join or unjoin a queue for a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>Task of UserQueue</returns>
        public async System.Threading.Tasks.Task<UserQueue> UsersUseridQueuesQueueidPatchAsync (string queueId, string userId, UserQueue body = null)
        {
             ApiResponse<UserQueue> localVarResponse = await UsersUseridQueuesQueueidPatchAsyncWithHttpInfo(queueId, userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Join or unjoin a queue for a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>Task of ApiResponse (UserQueue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserQueue>> UsersUseridQueuesQueueidPatchAsyncWithHttpInfo (string queueId, string userId, UserQueue body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling UsersApi->UsersUseridQueuesQueueidPatch");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridQueuesQueueidPatch");

            var localVarPath = "/api/v1/users/{userId}/queues/{queueId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridQueuesQueueidPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridQueuesQueueidPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserQueue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserQueue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserQueue)));
            
        }

        /// <summary>
        /// List roles for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>List&lt;DomainOrganizationRole&gt;</returns>
        public List<DomainOrganizationRole> UsersUseridRolesGet (string userId)
        {
             ApiResponse<List<DomainOrganizationRole>> localVarResponse = UsersUseridRolesGetWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List roles for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of List&lt;DomainOrganizationRole&gt;</returns>
        public ApiResponse< List<DomainOrganizationRole> > UsersUseridRolesGetWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridRolesGet");

            var localVarPath = "/api/v1/users/{userId}/roles";
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridRolesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridRolesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<DomainOrganizationRole>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DomainOrganizationRole>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DomainOrganizationRole>)));
            
        }

        /// <summary>
        /// List roles for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of List&lt;DomainOrganizationRole&gt;</returns>
        public async System.Threading.Tasks.Task<List<DomainOrganizationRole>> UsersUseridRolesGetAsync (string userId)
        {
             ApiResponse<List<DomainOrganizationRole>> localVarResponse = await UsersUseridRolesGetAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List roles for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (List&lt;DomainOrganizationRole&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<DomainOrganizationRole>>> UsersUseridRolesGetAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridRolesGet");

            var localVarPath = "/api/v1/users/{userId}/roles";
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridRolesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridRolesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<DomainOrganizationRole>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DomainOrganizationRole>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DomainOrganizationRole>)));
            
        }

        /// <summary>
        /// Fetch the routing status of a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>RoutingStatus</returns>
        public RoutingStatus UsersUseridRoutingstatusGet (string userId)
        {
             ApiResponse<RoutingStatus> localVarResponse = UsersUseridRoutingstatusGetWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch the routing status of a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of RoutingStatus</returns>
        public ApiResponse< RoutingStatus > UsersUseridRoutingstatusGetWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridRoutingstatusGet");

            var localVarPath = "/api/v1/users/{userId}/routingstatus";
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridRoutingstatusGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridRoutingstatusGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingStatus)));
            
        }

        /// <summary>
        /// Fetch the routing status of a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of RoutingStatus</returns>
        public async System.Threading.Tasks.Task<RoutingStatus> UsersUseridRoutingstatusGetAsync (string userId)
        {
             ApiResponse<RoutingStatus> localVarResponse = await UsersUseridRoutingstatusGetAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch the routing status of a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (RoutingStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoutingStatus>> UsersUseridRoutingstatusGetAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridRoutingstatusGet");

            var localVarPath = "/api/v1/users/{userId}/routingstatus";
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridRoutingstatusGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridRoutingstatusGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingStatus)));
            
        }

        /// <summary>
        /// Update the routing status of a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status (optional)</param>
        /// <returns>RoutingStatus</returns>
        public RoutingStatus UsersUseridRoutingstatusPut (string userId, RoutingStatus body = null)
        {
             ApiResponse<RoutingStatus> localVarResponse = UsersUseridRoutingstatusPutWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the routing status of a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status (optional)</param>
        /// <returns>ApiResponse of RoutingStatus</returns>
        public ApiResponse< RoutingStatus > UsersUseridRoutingstatusPutWithHttpInfo (string userId, RoutingStatus body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridRoutingstatusPut");

            var localVarPath = "/api/v1/users/{userId}/routingstatus";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridRoutingstatusPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridRoutingstatusPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingStatus)));
            
        }

        /// <summary>
        /// Update the routing status of a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status (optional)</param>
        /// <returns>Task of RoutingStatus</returns>
        public async System.Threading.Tasks.Task<RoutingStatus> UsersUseridRoutingstatusPutAsync (string userId, RoutingStatus body = null)
        {
             ApiResponse<RoutingStatus> localVarResponse = await UsersUseridRoutingstatusPutAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the routing status of a user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status (optional)</param>
        /// <returns>Task of ApiResponse (RoutingStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoutingStatus>> UsersUseridRoutingstatusPutAsyncWithHttpInfo (string userId, RoutingStatus body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridRoutingstatusPut");

            var localVarPath = "/api/v1/users/{userId}/routingstatus";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridRoutingstatusPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridRoutingstatusPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingStatus)));
            
        }

        /// <summary>
        /// List skills for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>UserSkillEntityListing</returns>
        public UserSkillEntityListing UsersUseridSkillsGet (string userId)
        {
             ApiResponse<UserSkillEntityListing> localVarResponse = UsersUseridSkillsGetWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List skills for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserSkillEntityListing</returns>
        public ApiResponse< UserSkillEntityListing > UsersUseridSkillsGetWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridSkillsGet");

            var localVarPath = "/api/v1/users/{userId}/skills";
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridSkillsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridSkillsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserSkillEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserSkillEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserSkillEntityListing)));
            
        }

        /// <summary>
        /// List skills for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserSkillEntityListing</returns>
        public async System.Threading.Tasks.Task<UserSkillEntityListing> UsersUseridSkillsGetAsync (string userId)
        {
             ApiResponse<UserSkillEntityListing> localVarResponse = await UsersUseridSkillsGetAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List skills for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserSkillEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserSkillEntityListing>> UsersUseridSkillsGetAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UsersUseridSkillsGet");

            var localVarPath = "/api/v1/users/{userId}/skills";
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
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridSkillsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UsersUseridSkillsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserSkillEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserSkillEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserSkillEntityListing)));
            
        }

    }
}
