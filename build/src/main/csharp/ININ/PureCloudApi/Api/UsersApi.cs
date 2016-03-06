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
    public interface IUsersApi
    {
        
        /// <summary>
        /// Get the list of available users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="id">id</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="role">Role</param>
        /// <param name="name">Name</param>
        /// <param name="username">Username</param>
        /// <param name="skill">Skill</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>UsersEntityListing</returns>
        UsersEntityListing Get (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null);
  
        /// <summary>
        /// Get the list of available users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="id">id</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="role">Role</param>
        /// <param name="name">Name</param>
        /// <param name="username">Username</param>
        /// <param name="skill">Skill</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>ApiResponse of UsersEntityListing</returns>
        ApiResponse<UsersEntityListing> GetWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null);

        /// <summary>
        /// Get the list of available users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="id">id</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="role">Role</param>
        /// <param name="name">Name</param>
        /// <param name="username">Username</param>
        /// <param name="skill">Skill</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of UsersEntityListing</returns>
        System.Threading.Tasks.Task<UsersEntityListing> GetAsync (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null);

        /// <summary>
        /// Get the list of available users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="id">id</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="role">Role</param>
        /// <param name="name">Name</param>
        /// <param name="username">Username</param>
        /// <param name="skill">Skill</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse (UsersEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsersEntityListing>> GetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null);
        
        /// <summary>
        /// Create a configuration service user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">User</param>
        /// <returns>User</returns>
        User Post (User body = null);
  
        /// <summary>
        /// Create a configuration service user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">User</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> PostWithHttpInfo (User body = null);

        /// <summary>
        /// Create a configuration service user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">User</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> PostAsync (User body = null);

        /// <summary>
        /// Create a configuration service user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">User</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> PostAsyncWithHttpInfo (User body = null);
        
        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>User</returns>
        User GetMe (List<string> expand = null);
  
        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> GetMeWithHttpInfo (List<string> expand = null);

        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> GetMeAsync (List<string> expand = null);

        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> GetMeAsyncWithHttpInfo (List<string> expand = null);
        
        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>User</returns>
        User GetUserId (string userId, List<string> expand = null);
  
        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> GetUserIdWithHttpInfo (string userId, List<string> expand = null);

        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> GetUserIdAsync (string userId, List<string> expand = null);

        /// <summary>
        /// Get user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> GetUserIdAsyncWithHttpInfo (string userId, List<string> expand = null);
        
        /// <summary>
        /// Set user station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">stationUri</param>
        /// <returns>User</returns>
        User PutUserId (string userId, User body);
  
        /// <summary>
        /// Set user station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">stationUri</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> PutUserIdWithHttpInfo (string userId, User body);

        /// <summary>
        /// Set user station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">stationUri</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> PutUserIdAsync (string userId, User body);

        /// <summary>
        /// Set user station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">stationUri</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> PutUserIdAsyncWithHttpInfo (string userId, User body);
        
        /// <summary>
        /// Get a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>CallForwarding</returns>
        CallForwarding GetUserIdCallforwarding (string userId);
  
        /// <summary>
        /// Get a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of CallForwarding</returns>
        ApiResponse<CallForwarding> GetUserIdCallforwardingWithHttpInfo (string userId);

        /// <summary>
        /// Get a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of CallForwarding</returns>
        System.Threading.Tasks.Task<CallForwarding> GetUserIdCallforwardingAsync (string userId);

        /// <summary>
        /// Get a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallForwarding>> GetUserIdCallforwardingAsyncWithHttpInfo (string userId);
        
        /// <summary>
        /// Update a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>CallForwarding</returns>
        CallForwarding PutUserIdCallforwarding (string userId, CallForwarding body = null);
  
        /// <summary>
        /// Update a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of CallForwarding</returns>
        ApiResponse<CallForwarding> PutUserIdCallforwardingWithHttpInfo (string userId, CallForwarding body = null);

        /// <summary>
        /// Update a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of CallForwarding</returns>
        System.Threading.Tasks.Task<CallForwarding> PutUserIdCallforwardingAsync (string userId, CallForwarding body = null);

        /// <summary>
        /// Update a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallForwarding>> PutUserIdCallforwardingAsyncWithHttpInfo (string userId, CallForwarding body = null);
        
        /// <summary>
        /// Patch a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>CallForwarding</returns>
        CallForwarding PatchUserIdCallforwarding (string userId, CallForwarding body = null);
  
        /// <summary>
        /// Patch a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of CallForwarding</returns>
        ApiResponse<CallForwarding> PatchUserIdCallforwardingWithHttpInfo (string userId, CallForwarding body = null);

        /// <summary>
        /// Patch a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of CallForwarding</returns>
        System.Threading.Tasks.Task<CallForwarding> PatchUserIdCallforwardingAsync (string userId, CallForwarding body = null);

        /// <summary>
        /// Patch a user&#39;s CallForwarding
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallForwarding>> PatchUserIdCallforwardingAsyncWithHttpInfo (string userId, CallForwarding body = null);
        
        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Geolocation</returns>
        Geolocation GetUserIdGeolocationsClientId (string userId, string clientId);
  
        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>ApiResponse of Geolocation</returns>
        ApiResponse<Geolocation> GetUserIdGeolocationsClientIdWithHttpInfo (string userId, string clientId);

        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of Geolocation</returns>
        System.Threading.Tasks.Task<Geolocation> GetUserIdGeolocationsClientIdAsync (string userId, string clientId);

        /// <summary>
        /// Get a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Geolocation>> GetUserIdGeolocationsClientIdAsyncWithHttpInfo (string userId, string clientId);
        
        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"></param>
        /// <returns>Geolocation</returns>
        Geolocation PatchUserIdGeolocationsClientId (string userId, string clientId, Geolocation body = null);
  
        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Geolocation</returns>
        ApiResponse<Geolocation> PatchUserIdGeolocationsClientIdWithHttpInfo (string userId, string clientId, Geolocation body = null);

        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"></param>
        /// <returns>Task of Geolocation</returns>
        System.Threading.Tasks.Task<Geolocation> PatchUserIdGeolocationsClientIdAsync (string userId, string clientId, Geolocation body = null);

        /// <summary>
        /// Patch a user&#39;s Geolocation
        /// </summary>
        /// <remarks>
        /// The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </remarks>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Geolocation>> PatchUserIdGeolocationsClientIdAsyncWithHttpInfo (string userId, string clientId, Geolocation body = null);
        
        /// <summary>
        /// Get a OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>OutOfOffice</returns>
        OutOfOffice GetUserIdOutofoffice (string userId);
  
        /// <summary>
        /// Get a OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of OutOfOffice</returns>
        ApiResponse<OutOfOffice> GetUserIdOutofofficeWithHttpInfo (string userId);

        /// <summary>
        /// Get a OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of OutOfOffice</returns>
        System.Threading.Tasks.Task<OutOfOffice> GetUserIdOutofofficeAsync (string userId);

        /// <summary>
        /// Get a OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (OutOfOffice)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutOfOffice>> GetUserIdOutofofficeAsyncWithHttpInfo (string userId);
        
        /// <summary>
        /// Update an OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>OutOfOffice</returns>
        OutOfOffice PutUserIdOutofoffice (string userId, OutOfOffice body);
  
        /// <summary>
        /// Update an OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>ApiResponse of OutOfOffice</returns>
        ApiResponse<OutOfOffice> PutUserIdOutofofficeWithHttpInfo (string userId, OutOfOffice body);

        /// <summary>
        /// Update an OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of OutOfOffice</returns>
        System.Threading.Tasks.Task<OutOfOffice> PutUserIdOutofofficeAsync (string userId, OutOfOffice body);

        /// <summary>
        /// Update an OutOfOffice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of ApiResponse (OutOfOffice)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutOfOffice>> PutUserIdOutofofficeAsyncWithHttpInfo (string userId, OutOfOffice body);
        
        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>PrimaryUserPresenceSource</returns>
        PrimaryUserPresenceSource GetUserIdPrimarypresencesource (string userId);
  
        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of PrimaryUserPresenceSource</returns>
        ApiResponse<PrimaryUserPresenceSource> GetUserIdPrimarypresencesourceWithHttpInfo (string userId);

        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of PrimaryUserPresenceSource</returns>
        System.Threading.Tasks.Task<PrimaryUserPresenceSource> GetUserIdPrimarypresencesourceAsync (string userId);

        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (PrimaryUserPresenceSource)</returns>
        System.Threading.Tasks.Task<ApiResponse<PrimaryUserPresenceSource>> GetUserIdPrimarypresencesourceAsyncWithHttpInfo (string userId);
        
        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>PrimaryUserPresenceSource</returns>
        PrimaryUserPresenceSource PutUserIdPrimarypresencesource (string userId, PrimaryUserPresenceSource body = null);
  
        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PrimaryUserPresenceSource</returns>
        ApiResponse<PrimaryUserPresenceSource> PutUserIdPrimarypresencesourceWithHttpInfo (string userId, PrimaryUserPresenceSource body = null);

        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of PrimaryUserPresenceSource</returns>
        System.Threading.Tasks.Task<PrimaryUserPresenceSource> PutUserIdPrimarypresencesourceAsync (string userId, PrimaryUserPresenceSource body = null);

        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PrimaryUserPresenceSource)</returns>
        System.Threading.Tasks.Task<ApiResponse<PrimaryUserPresenceSource>> PutUserIdPrimarypresencesourceAsyncWithHttpInfo (string userId, PrimaryUserPresenceSource body = null);
        
        /// <summary>
        /// Get queues for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>UserQueueEntityListing</returns>
        UserQueueEntityListing GetUserIdQueues (string userId, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get queues for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of UserQueueEntityListing</returns>
        ApiResponse<UserQueueEntityListing> GetUserIdQueuesWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get queues for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of UserQueueEntityListing</returns>
        System.Threading.Tasks.Task<UserQueueEntityListing> GetUserIdQueuesAsync (string userId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get queues for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (UserQueueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserQueueEntityListing>> GetUserIdQueuesAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Join or unjoin a set of queues for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues</param>
        /// <returns>UserQueue</returns>
        UserQueue PatchUserIdQueues (string userId, List<UserQueue> body = null);
  
        /// <summary>
        /// Join or unjoin a set of queues for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues</param>
        /// <returns>ApiResponse of UserQueue</returns>
        ApiResponse<UserQueue> PatchUserIdQueuesWithHttpInfo (string userId, List<UserQueue> body = null);

        /// <summary>
        /// Join or unjoin a set of queues for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues</param>
        /// <returns>Task of UserQueue</returns>
        System.Threading.Tasks.Task<UserQueue> PatchUserIdQueuesAsync (string userId, List<UserQueue> body = null);

        /// <summary>
        /// Join or unjoin a set of queues for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues</param>
        /// <returns>Task of ApiResponse (UserQueue)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserQueue>> PatchUserIdQueuesAsyncWithHttpInfo (string userId, List<UserQueue> body = null);
        
        /// <summary>
        /// Join or unjoin a queue for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>UserQueue</returns>
        UserQueue PatchUserIdQueuesQueueId (string queueId, string userId, UserQueue body = null);
  
        /// <summary>
        /// Join or unjoin a queue for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>ApiResponse of UserQueue</returns>
        ApiResponse<UserQueue> PatchUserIdQueuesQueueIdWithHttpInfo (string queueId, string userId, UserQueue body = null);

        /// <summary>
        /// Join or unjoin a queue for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of UserQueue</returns>
        System.Threading.Tasks.Task<UserQueue> PatchUserIdQueuesQueueIdAsync (string queueId, string userId, UserQueue body = null);

        /// <summary>
        /// Join or unjoin a queue for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of ApiResponse (UserQueue)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserQueue>> PatchUserIdQueuesQueueIdAsyncWithHttpInfo (string queueId, string userId, UserQueue body = null);
        
        /// <summary>
        /// List roles for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>List&lt;DomainOrganizationRole&gt;</returns>
        List<DomainOrganizationRole> GetUserIdRoles (string userId);
  
        /// <summary>
        /// List roles for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of List&lt;DomainOrganizationRole&gt;</returns>
        ApiResponse<List<DomainOrganizationRole>> GetUserIdRolesWithHttpInfo (string userId);

        /// <summary>
        /// List roles for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of List&lt;DomainOrganizationRole&gt;</returns>
        System.Threading.Tasks.Task<List<DomainOrganizationRole>> GetUserIdRolesAsync (string userId);

        /// <summary>
        /// List roles for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (List&lt;DomainOrganizationRole&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<DomainOrganizationRole>>> GetUserIdRolesAsyncWithHttpInfo (string userId);
        
        /// <summary>
        /// Fetch the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>RoutingStatus</returns>
        RoutingStatus GetUserIdRoutingstatus (string userId);
  
        /// <summary>
        /// Fetch the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of RoutingStatus</returns>
        ApiResponse<RoutingStatus> GetUserIdRoutingstatusWithHttpInfo (string userId);

        /// <summary>
        /// Fetch the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of RoutingStatus</returns>
        System.Threading.Tasks.Task<RoutingStatus> GetUserIdRoutingstatusAsync (string userId);

        /// <summary>
        /// Fetch the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (RoutingStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoutingStatus>> GetUserIdRoutingstatusAsyncWithHttpInfo (string userId);
        
        /// <summary>
        /// Update the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status</param>
        /// <returns>RoutingStatus</returns>
        RoutingStatus PutUserIdRoutingstatus (string userId, RoutingStatus body = null);
  
        /// <summary>
        /// Update the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status</param>
        /// <returns>ApiResponse of RoutingStatus</returns>
        ApiResponse<RoutingStatus> PutUserIdRoutingstatusWithHttpInfo (string userId, RoutingStatus body = null);

        /// <summary>
        /// Update the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status</param>
        /// <returns>Task of RoutingStatus</returns>
        System.Threading.Tasks.Task<RoutingStatus> PutUserIdRoutingstatusAsync (string userId, RoutingStatus body = null);

        /// <summary>
        /// Update the routing status of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status</param>
        /// <returns>Task of ApiResponse (RoutingStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoutingStatus>> PutUserIdRoutingstatusAsyncWithHttpInfo (string userId, RoutingStatus body = null);
        
        /// <summary>
        /// List skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>UserSkillEntityListing</returns>
        UserSkillEntityListing GetUserIdSkills (string userId);
  
        /// <summary>
        /// List skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserSkillEntityListing</returns>
        ApiResponse<UserSkillEntityListing> GetUserIdSkillsWithHttpInfo (string userId);

        /// <summary>
        /// List skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserSkillEntityListing</returns>
        System.Threading.Tasks.Task<UserSkillEntityListing> GetUserIdSkillsAsync (string userId);

        /// <summary>
        /// List skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserSkillEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserSkillEntityListing>> GetUserIdSkillsAsyncWithHttpInfo (string userId);
        
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
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="id">id</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="role">Role</param> 
        /// <param name="name">Name</param> 
        /// <param name="username">Username</param> 
        /// <param name="skill">Skill</param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>UsersEntityListing</returns>
        public UsersEntityListing Get (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null)
        {
             ApiResponse<UsersEntityListing> response = GetWithHttpInfo(pageSize, pageNumber, id, sortBy, role, name, username, skill, expand);
             return response.Data;
        }

        /// <summary>
        /// Get the list of available users. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="id">id</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="role">Role</param> 
        /// <param name="name">Name</param> 
        /// <param name="username">Username</param> 
        /// <param name="skill">Skill</param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>ApiResponse of UsersEntityListing</returns>
        public ApiResponse< UsersEntityListing > GetWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null)
        {
            
    
            var path_ = "/api/v1/users";
    
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
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (role != null) queryParams.Add("role", Configuration.ApiClient.ParameterToString(role)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (username != null) queryParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // query parameter
            if (skill != null) queryParams.Add("skill", Configuration.ApiClient.ParameterToString(skill)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UsersEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsersEntityListing) Configuration.ApiClient.Deserialize(response, typeof(UsersEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of available users. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="id">id</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="role">Role</param>
        /// <param name="name">Name</param>
        /// <param name="username">Username</param>
        /// <param name="skill">Skill</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of UsersEntityListing</returns>
        public async System.Threading.Tasks.Task<UsersEntityListing> GetAsync (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null)
        {
             ApiResponse<UsersEntityListing> response = await GetAsyncWithHttpInfo(pageSize, pageNumber, id, sortBy, role, name, username, skill, expand);
             return response.Data;

        }

        /// <summary>
        /// Get the list of available users. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="id">id</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="role">Role</param>
        /// <param name="name">Name</param>
        /// <param name="username">Username</param>
        /// <param name="skill">Skill</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse (UsersEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsersEntityListing>> GetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null)
        {
            
    
            var path_ = "/api/v1/users";
    
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
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (role != null) queryParams.Add("role", Configuration.ApiClient.ParameterToString(role)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (username != null) queryParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // query parameter
            if (skill != null) queryParams.Add("skill", Configuration.ApiClient.ParameterToString(skill)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UsersEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsersEntityListing) Configuration.ApiClient.Deserialize(response, typeof(UsersEntityListing)));
            
        }
        
        /// <summary>
        /// Create a configuration service user. 
        /// </summary>
        /// <param name="body">User</param> 
        /// <returns>User</returns>
        public User Post (User body = null)
        {
             ApiResponse<User> response = PostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a configuration service user. 
        /// </summary>
        /// <param name="body">User</param> 
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > PostWithHttpInfo (User body = null)
        {
            
    
            var path_ = "/api/v1/users";
    
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
                throw new ApiException (statusCode, "Error calling Post: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Post: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(response, typeof(User)));
            
        }
    
        /// <summary>
        /// Create a configuration service user. 
        /// </summary>
        /// <param name="body">User</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> PostAsync (User body = null)
        {
             ApiResponse<User> response = await PostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a configuration service user. 
        /// </summary>
        /// <param name="body">User</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> PostAsyncWithHttpInfo (User body = null)
        {
            
    
            var path_ = "/api/v1/users";
    
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
                throw new ApiException (statusCode, "Error calling Post: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Post: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(response, typeof(User)));
            
        }
        
        /// <summary>
        /// Get user. 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>User</returns>
        public User GetMe (List<string> expand = null)
        {
             ApiResponse<User> response = GetMeWithHttpInfo(expand);
             return response.Data;
        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > GetMeWithHttpInfo (List<string> expand = null)
        {
            
    
            var path_ = "/api/v1/users/me";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetMe: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMe: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(response, typeof(User)));
            
        }
    
        /// <summary>
        /// Get user. 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> GetMeAsync (List<string> expand = null)
        {
             ApiResponse<User> response = await GetMeAsyncWithHttpInfo(expand);
             return response.Data;

        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> GetMeAsyncWithHttpInfo (List<string> expand = null)
        {
            
    
            var path_ = "/api/v1/users/me";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetMe: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMe: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(response, typeof(User)));
            
        }
        
        /// <summary>
        /// Get user. 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>User</returns>
        public User GetUserId (string userId, List<string> expand = null)
        {
             ApiResponse<User> response = GetUserIdWithHttpInfo(userId, expand);
             return response.Data;
        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="expand">Which fields, if any, to expand</param> 
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > GetUserIdWithHttpInfo (string userId, List<string> expand = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserId");
            
    
            var path_ = "/api/v1/users/{userId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetUserId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(response, typeof(User)));
            
        }
    
        /// <summary>
        /// Get user. 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> GetUserIdAsync (string userId, List<string> expand = null)
        {
             ApiResponse<User> response = await GetUserIdAsyncWithHttpInfo(userId, expand);
             return response.Data;

        }

        /// <summary>
        /// Get user. 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="expand">Which fields, if any, to expand</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> GetUserIdAsyncWithHttpInfo (string userId, List<string> expand = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserId");
            
    
            var path_ = "/api/v1/users/{userId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetUserId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(response, typeof(User)));
            
        }
        
        /// <summary>
        /// Set user station 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">stationUri</param> 
        /// <returns>User</returns>
        public User PutUserId (string userId, User body)
        {
             ApiResponse<User> response = PutUserIdWithHttpInfo(userId, body);
             return response.Data;
        }

        /// <summary>
        /// Set user station 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">stationUri</param> 
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > PutUserIdWithHttpInfo (string userId, User body)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserId");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PutUserId");
            
    
            var path_ = "/api/v1/users/{userId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutUserId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutUserId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(response, typeof(User)));
            
        }
    
        /// <summary>
        /// Set user station 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">stationUri</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> PutUserIdAsync (string userId, User body)
        {
             ApiResponse<User> response = await PutUserIdAsyncWithHttpInfo(userId, body);
             return response.Data;

        }

        /// <summary>
        /// Set user station 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">stationUri</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> PutUserIdAsyncWithHttpInfo (string userId, User body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling PutUserId");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PutUserId");
            
    
            var path_ = "/api/v1/users/{userId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutUserId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutUserId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<User>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(response, typeof(User)));
            
        }
        
        /// <summary>
        /// Get a user&#39;s CallForwarding 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>CallForwarding</returns>
        public CallForwarding GetUserIdCallforwarding (string userId)
        {
             ApiResponse<CallForwarding> response = GetUserIdCallforwardingWithHttpInfo(userId);
             return response.Data;
        }

        /// <summary>
        /// Get a user&#39;s CallForwarding 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>ApiResponse of CallForwarding</returns>
        public ApiResponse< CallForwarding > GetUserIdCallforwardingWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserIdCallforwarding");
            
    
            var path_ = "/api/v1/users/{userId}/callforwarding";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetUserIdCallforwarding: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdCallforwarding: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CallForwarding>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallForwarding) Configuration.ApiClient.Deserialize(response, typeof(CallForwarding)));
            
        }
    
        /// <summary>
        /// Get a user&#39;s CallForwarding 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of CallForwarding</returns>
        public async System.Threading.Tasks.Task<CallForwarding> GetUserIdCallforwardingAsync (string userId)
        {
             ApiResponse<CallForwarding> response = await GetUserIdCallforwardingAsyncWithHttpInfo(userId);
             return response.Data;

        }

        /// <summary>
        /// Get a user&#39;s CallForwarding 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallForwarding>> GetUserIdCallforwardingAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserIdCallforwarding");
            
    
            var path_ = "/api/v1/users/{userId}/callforwarding";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetUserIdCallforwarding: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdCallforwarding: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CallForwarding>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallForwarding) Configuration.ApiClient.Deserialize(response, typeof(CallForwarding)));
            
        }
        
        /// <summary>
        /// Update a user&#39;s CallForwarding 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body"></param> 
        /// <returns>CallForwarding</returns>
        public CallForwarding PutUserIdCallforwarding (string userId, CallForwarding body = null)
        {
             ApiResponse<CallForwarding> response = PutUserIdCallforwardingWithHttpInfo(userId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a user&#39;s CallForwarding 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of CallForwarding</returns>
        public ApiResponse< CallForwarding > PutUserIdCallforwardingWithHttpInfo (string userId, CallForwarding body = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserIdCallforwarding");
            
    
            var path_ = "/api/v1/users/{userId}/callforwarding";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutUserIdCallforwarding: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutUserIdCallforwarding: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CallForwarding>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallForwarding) Configuration.ApiClient.Deserialize(response, typeof(CallForwarding)));
            
        }
    
        /// <summary>
        /// Update a user&#39;s CallForwarding 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of CallForwarding</returns>
        public async System.Threading.Tasks.Task<CallForwarding> PutUserIdCallforwardingAsync (string userId, CallForwarding body = null)
        {
             ApiResponse<CallForwarding> response = await PutUserIdCallforwardingAsyncWithHttpInfo(userId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a user&#39;s CallForwarding 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallForwarding>> PutUserIdCallforwardingAsyncWithHttpInfo (string userId, CallForwarding body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling PutUserIdCallforwarding");
            
    
            var path_ = "/api/v1/users/{userId}/callforwarding";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutUserIdCallforwarding: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutUserIdCallforwarding: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CallForwarding>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallForwarding) Configuration.ApiClient.Deserialize(response, typeof(CallForwarding)));
            
        }
        
        /// <summary>
        /// Patch a user&#39;s CallForwarding 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body"></param> 
        /// <returns>CallForwarding</returns>
        public CallForwarding PatchUserIdCallforwarding (string userId, CallForwarding body = null)
        {
             ApiResponse<CallForwarding> response = PatchUserIdCallforwardingWithHttpInfo(userId, body);
             return response.Data;
        }

        /// <summary>
        /// Patch a user&#39;s CallForwarding 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of CallForwarding</returns>
        public ApiResponse< CallForwarding > PatchUserIdCallforwardingWithHttpInfo (string userId, CallForwarding body = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PatchUserIdCallforwarding");
            
    
            var path_ = "/api/v1/users/{userId}/callforwarding";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchUserIdCallforwarding: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchUserIdCallforwarding: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CallForwarding>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallForwarding) Configuration.ApiClient.Deserialize(response, typeof(CallForwarding)));
            
        }
    
        /// <summary>
        /// Patch a user&#39;s CallForwarding 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of CallForwarding</returns>
        public async System.Threading.Tasks.Task<CallForwarding> PatchUserIdCallforwardingAsync (string userId, CallForwarding body = null)
        {
             ApiResponse<CallForwarding> response = await PatchUserIdCallforwardingAsyncWithHttpInfo(userId, body);
             return response.Data;

        }

        /// <summary>
        /// Patch a user&#39;s CallForwarding 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (CallForwarding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallForwarding>> PatchUserIdCallforwardingAsyncWithHttpInfo (string userId, CallForwarding body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling PatchUserIdCallforwarding");
            
    
            var path_ = "/api/v1/users/{userId}/callforwarding";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchUserIdCallforwarding: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchUserIdCallforwarding: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CallForwarding>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallForwarding) Configuration.ApiClient.Deserialize(response, typeof(CallForwarding)));
            
        }
        
        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <param name="userId">user Id</param> 
        /// <param name="clientId">client Id</param> 
        /// <returns>Geolocation</returns>
        public Geolocation GetUserIdGeolocationsClientId (string userId, string clientId)
        {
             ApiResponse<Geolocation> response = GetUserIdGeolocationsClientIdWithHttpInfo(userId, clientId);
             return response.Data;
        }

        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <param name="userId">user Id</param> 
        /// <param name="clientId">client Id</param> 
        /// <returns>ApiResponse of Geolocation</returns>
        public ApiResponse< Geolocation > GetUserIdGeolocationsClientIdWithHttpInfo (string userId, string clientId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserIdGeolocationsClientId");
            
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsersApi->GetUserIdGeolocationsClientId");
            
    
            var path_ = "/api/v1/users/{userId}/geolocations/{clientId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetUserIdGeolocationsClientId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdGeolocationsClientId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Geolocation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Geolocation) Configuration.ApiClient.Deserialize(response, typeof(Geolocation)));
            
        }
    
        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of Geolocation</returns>
        public async System.Threading.Tasks.Task<Geolocation> GetUserIdGeolocationsClientIdAsync (string userId, string clientId)
        {
             ApiResponse<Geolocation> response = await GetUserIdGeolocationsClientIdAsyncWithHttpInfo(userId, clientId);
             return response.Data;

        }

        /// <summary>
        /// Get a user&#39;s Geolocation 
        /// </summary>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Geolocation>> GetUserIdGeolocationsClientIdAsyncWithHttpInfo (string userId, string clientId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserIdGeolocationsClientId");
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling GetUserIdGeolocationsClientId");
            
    
            var path_ = "/api/v1/users/{userId}/geolocations/{clientId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetUserIdGeolocationsClientId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdGeolocationsClientId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Geolocation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Geolocation) Configuration.ApiClient.Deserialize(response, typeof(Geolocation)));
            
        }
        
        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <param name="userId">user Id</param> 
        /// <param name="clientId">client Id</param> 
        /// <param name="body"></param> 
        /// <returns>Geolocation</returns>
        public Geolocation PatchUserIdGeolocationsClientId (string userId, string clientId, Geolocation body = null)
        {
             ApiResponse<Geolocation> response = PatchUserIdGeolocationsClientIdWithHttpInfo(userId, clientId, body);
             return response.Data;
        }

        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <param name="userId">user Id</param> 
        /// <param name="clientId">client Id</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Geolocation</returns>
        public ApiResponse< Geolocation > PatchUserIdGeolocationsClientIdWithHttpInfo (string userId, string clientId, Geolocation body = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PatchUserIdGeolocationsClientId");
            
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling UsersApi->PatchUserIdGeolocationsClientId");
            
    
            var path_ = "/api/v1/users/{userId}/geolocations/{clientId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
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
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchUserIdGeolocationsClientId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchUserIdGeolocationsClientId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Geolocation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Geolocation) Configuration.ApiClient.Deserialize(response, typeof(Geolocation)));
            
        }
    
        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"></param>
        /// <returns>Task of Geolocation</returns>
        public async System.Threading.Tasks.Task<Geolocation> PatchUserIdGeolocationsClientIdAsync (string userId, string clientId, Geolocation body = null)
        {
             ApiResponse<Geolocation> response = await PatchUserIdGeolocationsClientIdAsyncWithHttpInfo(userId, clientId, body);
             return response.Data;

        }

        /// <summary>
        /// Patch a user&#39;s Geolocation The geolocation object can be patched one of three ways. Option 1: Set the &#39;primary&#39; property to true. This will set the client as the user&#39;s primary geolocation source.  Option 2: Provide the &#39;latitude&#39; and &#39;longitude&#39; values.  This will enqueue an asynchronous update of the &#39;city&#39;, &#39;region&#39;, and &#39;country&#39;, generating a notification. A subsequent GET operation will include the new values for &#39;city&#39;, &#39;region&#39; and &#39;country&#39;.  Option 3:  Provide the &#39;city&#39;, &#39;region&#39;, &#39;country&#39; values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.
        /// </summary>
        /// <param name="userId">user Id</param>
        /// <param name="clientId">client Id</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Geolocation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Geolocation>> PatchUserIdGeolocationsClientIdAsyncWithHttpInfo (string userId, string clientId, Geolocation body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling PatchUserIdGeolocationsClientId");
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling PatchUserIdGeolocationsClientId");
            
    
            var path_ = "/api/v1/users/{userId}/geolocations/{clientId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (clientId != null) pathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchUserIdGeolocationsClientId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchUserIdGeolocationsClientId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Geolocation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Geolocation) Configuration.ApiClient.Deserialize(response, typeof(Geolocation)));
            
        }
        
        /// <summary>
        /// Get a OutOfOffice 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>OutOfOffice</returns>
        public OutOfOffice GetUserIdOutofoffice (string userId)
        {
             ApiResponse<OutOfOffice> response = GetUserIdOutofofficeWithHttpInfo(userId);
             return response.Data;
        }

        /// <summary>
        /// Get a OutOfOffice 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>ApiResponse of OutOfOffice</returns>
        public ApiResponse< OutOfOffice > GetUserIdOutofofficeWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserIdOutofoffice");
            
    
            var path_ = "/api/v1/users/{userId}/outofoffice";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetUserIdOutofoffice: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdOutofoffice: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OutOfOffice>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutOfOffice) Configuration.ApiClient.Deserialize(response, typeof(OutOfOffice)));
            
        }
    
        /// <summary>
        /// Get a OutOfOffice 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of OutOfOffice</returns>
        public async System.Threading.Tasks.Task<OutOfOffice> GetUserIdOutofofficeAsync (string userId)
        {
             ApiResponse<OutOfOffice> response = await GetUserIdOutofofficeAsyncWithHttpInfo(userId);
             return response.Data;

        }

        /// <summary>
        /// Get a OutOfOffice 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (OutOfOffice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutOfOffice>> GetUserIdOutofofficeAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserIdOutofoffice");
            
    
            var path_ = "/api/v1/users/{userId}/outofoffice";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetUserIdOutofoffice: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdOutofoffice: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OutOfOffice>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutOfOffice) Configuration.ApiClient.Deserialize(response, typeof(OutOfOffice)));
            
        }
        
        /// <summary>
        /// Update an OutOfOffice 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">The updated UserPresence</param> 
        /// <returns>OutOfOffice</returns>
        public OutOfOffice PutUserIdOutofoffice (string userId, OutOfOffice body)
        {
             ApiResponse<OutOfOffice> response = PutUserIdOutofofficeWithHttpInfo(userId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an OutOfOffice 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">The updated UserPresence</param> 
        /// <returns>ApiResponse of OutOfOffice</returns>
        public ApiResponse< OutOfOffice > PutUserIdOutofofficeWithHttpInfo (string userId, OutOfOffice body)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserIdOutofoffice");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UsersApi->PutUserIdOutofoffice");
            
    
            var path_ = "/api/v1/users/{userId}/outofoffice";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutUserIdOutofoffice: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutUserIdOutofoffice: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OutOfOffice>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutOfOffice) Configuration.ApiClient.Deserialize(response, typeof(OutOfOffice)));
            
        }
    
        /// <summary>
        /// Update an OutOfOffice 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of OutOfOffice</returns>
        public async System.Threading.Tasks.Task<OutOfOffice> PutUserIdOutofofficeAsync (string userId, OutOfOffice body)
        {
             ApiResponse<OutOfOffice> response = await PutUserIdOutofofficeAsyncWithHttpInfo(userId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an OutOfOffice 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">The updated UserPresence</param>
        /// <returns>Task of ApiResponse (OutOfOffice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutOfOffice>> PutUserIdOutofofficeAsyncWithHttpInfo (string userId, OutOfOffice body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling PutUserIdOutofoffice");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PutUserIdOutofoffice");
            
    
            var path_ = "/api/v1/users/{userId}/outofoffice";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutUserIdOutofoffice: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutUserIdOutofoffice: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OutOfOffice>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutOfOffice) Configuration.ApiClient.Deserialize(response, typeof(OutOfOffice)));
            
        }
        
        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>PrimaryUserPresenceSource</returns>
        public PrimaryUserPresenceSource GetUserIdPrimarypresencesource (string userId)
        {
             ApiResponse<PrimaryUserPresenceSource> response = GetUserIdPrimarypresencesourceWithHttpInfo(userId);
             return response.Data;
        }

        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>ApiResponse of PrimaryUserPresenceSource</returns>
        public ApiResponse< PrimaryUserPresenceSource > GetUserIdPrimarypresencesourceWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserIdPrimarypresencesource");
            
    
            var path_ = "/api/v1/users/{userId}/primarypresencesource";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetUserIdPrimarypresencesource: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdPrimarypresencesource: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PrimaryUserPresenceSource>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PrimaryUserPresenceSource) Configuration.ApiClient.Deserialize(response, typeof(PrimaryUserPresenceSource)));
            
        }
    
        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of PrimaryUserPresenceSource</returns>
        public async System.Threading.Tasks.Task<PrimaryUserPresenceSource> GetUserIdPrimarypresencesourceAsync (string userId)
        {
             ApiResponse<PrimaryUserPresenceSource> response = await GetUserIdPrimarypresencesourceAsyncWithHttpInfo(userId);
             return response.Data;

        }

        /// <summary>
        /// Get a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (PrimaryUserPresenceSource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PrimaryUserPresenceSource>> GetUserIdPrimarypresencesourceAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserIdPrimarypresencesource");
            
    
            var path_ = "/api/v1/users/{userId}/primarypresencesource";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetUserIdPrimarypresencesource: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdPrimarypresencesource: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PrimaryUserPresenceSource>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PrimaryUserPresenceSource) Configuration.ApiClient.Deserialize(response, typeof(PrimaryUserPresenceSource)));
            
        }
        
        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body"></param> 
        /// <returns>PrimaryUserPresenceSource</returns>
        public PrimaryUserPresenceSource PutUserIdPrimarypresencesource (string userId, PrimaryUserPresenceSource body = null)
        {
             ApiResponse<PrimaryUserPresenceSource> response = PutUserIdPrimarypresencesourceWithHttpInfo(userId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PrimaryUserPresenceSource</returns>
        public ApiResponse< PrimaryUserPresenceSource > PutUserIdPrimarypresencesourceWithHttpInfo (string userId, PrimaryUserPresenceSource body = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserIdPrimarypresencesource");
            
    
            var path_ = "/api/v1/users/{userId}/primarypresencesource";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutUserIdPrimarypresencesource: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutUserIdPrimarypresencesource: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PrimaryUserPresenceSource>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PrimaryUserPresenceSource) Configuration.ApiClient.Deserialize(response, typeof(PrimaryUserPresenceSource)));
            
        }
    
        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of PrimaryUserPresenceSource</returns>
        public async System.Threading.Tasks.Task<PrimaryUserPresenceSource> PutUserIdPrimarypresencesourceAsync (string userId, PrimaryUserPresenceSource body = null)
        {
             ApiResponse<PrimaryUserPresenceSource> response = await PutUserIdPrimarypresencesourceAsyncWithHttpInfo(userId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a user&#39;s PrimaryUserPresenceSource 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PrimaryUserPresenceSource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PrimaryUserPresenceSource>> PutUserIdPrimarypresencesourceAsyncWithHttpInfo (string userId, PrimaryUserPresenceSource body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling PutUserIdPrimarypresencesource");
            
    
            var path_ = "/api/v1/users/{userId}/primarypresencesource";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutUserIdPrimarypresencesource: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutUserIdPrimarypresencesource: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PrimaryUserPresenceSource>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PrimaryUserPresenceSource) Configuration.ApiClient.Deserialize(response, typeof(PrimaryUserPresenceSource)));
            
        }
        
        /// <summary>
        /// Get queues for user 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>UserQueueEntityListing</returns>
        public UserQueueEntityListing GetUserIdQueues (string userId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<UserQueueEntityListing> response = GetUserIdQueuesWithHttpInfo(userId, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get queues for user 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of UserQueueEntityListing</returns>
        public ApiResponse< UserQueueEntityListing > GetUserIdQueuesWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserIdQueues");
            
    
            var path_ = "/api/v1/users/{userId}/queues";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling GetUserIdQueues: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdQueues: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserQueueEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserQueueEntityListing) Configuration.ApiClient.Deserialize(response, typeof(UserQueueEntityListing)));
            
        }
    
        /// <summary>
        /// Get queues for user 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of UserQueueEntityListing</returns>
        public async System.Threading.Tasks.Task<UserQueueEntityListing> GetUserIdQueuesAsync (string userId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<UserQueueEntityListing> response = await GetUserIdQueuesAsyncWithHttpInfo(userId, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get queues for user 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (UserQueueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserQueueEntityListing>> GetUserIdQueuesAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserIdQueues");
            
    
            var path_ = "/api/v1/users/{userId}/queues";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling GetUserIdQueues: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdQueues: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserQueueEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserQueueEntityListing) Configuration.ApiClient.Deserialize(response, typeof(UserQueueEntityListing)));
            
        }
        
        /// <summary>
        /// Join or unjoin a set of queues for a user 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">User Queues</param> 
        /// <returns>UserQueue</returns>
        public UserQueue PatchUserIdQueues (string userId, List<UserQueue> body = null)
        {
             ApiResponse<UserQueue> response = PatchUserIdQueuesWithHttpInfo(userId, body);
             return response.Data;
        }

        /// <summary>
        /// Join or unjoin a set of queues for a user 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">User Queues</param> 
        /// <returns>ApiResponse of UserQueue</returns>
        public ApiResponse< UserQueue > PatchUserIdQueuesWithHttpInfo (string userId, List<UserQueue> body = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PatchUserIdQueues");
            
    
            var path_ = "/api/v1/users/{userId}/queues";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchUserIdQueues: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchUserIdQueues: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserQueue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserQueue) Configuration.ApiClient.Deserialize(response, typeof(UserQueue)));
            
        }
    
        /// <summary>
        /// Join or unjoin a set of queues for a user 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues</param>
        /// <returns>Task of UserQueue</returns>
        public async System.Threading.Tasks.Task<UserQueue> PatchUserIdQueuesAsync (string userId, List<UserQueue> body = null)
        {
             ApiResponse<UserQueue> response = await PatchUserIdQueuesAsyncWithHttpInfo(userId, body);
             return response.Data;

        }

        /// <summary>
        /// Join or unjoin a set of queues for a user 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">User Queues</param>
        /// <returns>Task of ApiResponse (UserQueue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserQueue>> PatchUserIdQueuesAsyncWithHttpInfo (string userId, List<UserQueue> body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling PatchUserIdQueues");
            
    
            var path_ = "/api/v1/users/{userId}/queues";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchUserIdQueues: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchUserIdQueues: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserQueue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserQueue) Configuration.ApiClient.Deserialize(response, typeof(UserQueue)));
            
        }
        
        /// <summary>
        /// Join or unjoin a queue for a user 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="userId">User ID</param> 
        /// <param name="body">Queue Member</param> 
        /// <returns>UserQueue</returns>
        public UserQueue PatchUserIdQueuesQueueId (string queueId, string userId, UserQueue body = null)
        {
             ApiResponse<UserQueue> response = PatchUserIdQueuesQueueIdWithHttpInfo(queueId, userId, body);
             return response.Data;
        }

        /// <summary>
        /// Join or unjoin a queue for a user 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="userId">User ID</param> 
        /// <param name="body">Queue Member</param> 
        /// <returns>ApiResponse of UserQueue</returns>
        public ApiResponse< UserQueue > PatchUserIdQueuesQueueIdWithHttpInfo (string queueId, string userId, UserQueue body = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling UsersApi->PatchUserIdQueuesQueueId");
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PatchUserIdQueuesQueueId");
            
    
            var path_ = "/api/v1/users/{userId}/queues/{queueId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchUserIdQueuesQueueId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchUserIdQueuesQueueId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserQueue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserQueue) Configuration.ApiClient.Deserialize(response, typeof(UserQueue)));
            
        }
    
        /// <summary>
        /// Join or unjoin a queue for a user 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of UserQueue</returns>
        public async System.Threading.Tasks.Task<UserQueue> PatchUserIdQueuesQueueIdAsync (string queueId, string userId, UserQueue body = null)
        {
             ApiResponse<UserQueue> response = await PatchUserIdQueuesQueueIdAsyncWithHttpInfo(queueId, userId, body);
             return response.Data;

        }

        /// <summary>
        /// Join or unjoin a queue for a user 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="userId">User ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of ApiResponse (UserQueue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserQueue>> PatchUserIdQueuesQueueIdAsyncWithHttpInfo (string queueId, string userId, UserQueue body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling PatchUserIdQueuesQueueId");
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling PatchUserIdQueuesQueueId");
            
    
            var path_ = "/api/v1/users/{userId}/queues/{queueId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchUserIdQueuesQueueId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchUserIdQueuesQueueId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserQueue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserQueue) Configuration.ApiClient.Deserialize(response, typeof(UserQueue)));
            
        }
        
        /// <summary>
        /// List roles for user 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>List&lt;DomainOrganizationRole&gt;</returns>
        public List<DomainOrganizationRole> GetUserIdRoles (string userId)
        {
             ApiResponse<List<DomainOrganizationRole>> response = GetUserIdRolesWithHttpInfo(userId);
             return response.Data;
        }

        /// <summary>
        /// List roles for user 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>ApiResponse of List&lt;DomainOrganizationRole&gt;</returns>
        public ApiResponse< List<DomainOrganizationRole> > GetUserIdRolesWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserIdRoles");
            
    
            var path_ = "/api/v1/users/{userId}/roles";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetUserIdRoles: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<DomainOrganizationRole>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DomainOrganizationRole>) Configuration.ApiClient.Deserialize(response, typeof(List<DomainOrganizationRole>)));
            
        }
    
        /// <summary>
        /// List roles for user 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of List&lt;DomainOrganizationRole&gt;</returns>
        public async System.Threading.Tasks.Task<List<DomainOrganizationRole>> GetUserIdRolesAsync (string userId)
        {
             ApiResponse<List<DomainOrganizationRole>> response = await GetUserIdRolesAsyncWithHttpInfo(userId);
             return response.Data;

        }

        /// <summary>
        /// List roles for user 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (List&lt;DomainOrganizationRole&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<DomainOrganizationRole>>> GetUserIdRolesAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserIdRoles");
            
    
            var path_ = "/api/v1/users/{userId}/roles";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetUserIdRoles: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdRoles: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<DomainOrganizationRole>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DomainOrganizationRole>) Configuration.ApiClient.Deserialize(response, typeof(List<DomainOrganizationRole>)));
            
        }
        
        /// <summary>
        /// Fetch the routing status of a user 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>RoutingStatus</returns>
        public RoutingStatus GetUserIdRoutingstatus (string userId)
        {
             ApiResponse<RoutingStatus> response = GetUserIdRoutingstatusWithHttpInfo(userId);
             return response.Data;
        }

        /// <summary>
        /// Fetch the routing status of a user 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>ApiResponse of RoutingStatus</returns>
        public ApiResponse< RoutingStatus > GetUserIdRoutingstatusWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserIdRoutingstatus");
            
    
            var path_ = "/api/v1/users/{userId}/routingstatus";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetUserIdRoutingstatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdRoutingstatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<RoutingStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingStatus) Configuration.ApiClient.Deserialize(response, typeof(RoutingStatus)));
            
        }
    
        /// <summary>
        /// Fetch the routing status of a user 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of RoutingStatus</returns>
        public async System.Threading.Tasks.Task<RoutingStatus> GetUserIdRoutingstatusAsync (string userId)
        {
             ApiResponse<RoutingStatus> response = await GetUserIdRoutingstatusAsyncWithHttpInfo(userId);
             return response.Data;

        }

        /// <summary>
        /// Fetch the routing status of a user 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (RoutingStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoutingStatus>> GetUserIdRoutingstatusAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserIdRoutingstatus");
            
    
            var path_ = "/api/v1/users/{userId}/routingstatus";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetUserIdRoutingstatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdRoutingstatus: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RoutingStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingStatus) Configuration.ApiClient.Deserialize(response, typeof(RoutingStatus)));
            
        }
        
        /// <summary>
        /// Update the routing status of a user 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">Routing Status</param> 
        /// <returns>RoutingStatus</returns>
        public RoutingStatus PutUserIdRoutingstatus (string userId, RoutingStatus body = null)
        {
             ApiResponse<RoutingStatus> response = PutUserIdRoutingstatusWithHttpInfo(userId, body);
             return response.Data;
        }

        /// <summary>
        /// Update the routing status of a user 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">Routing Status</param> 
        /// <returns>ApiResponse of RoutingStatus</returns>
        public ApiResponse< RoutingStatus > PutUserIdRoutingstatusWithHttpInfo (string userId, RoutingStatus body = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->PutUserIdRoutingstatus");
            
    
            var path_ = "/api/v1/users/{userId}/routingstatus";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutUserIdRoutingstatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutUserIdRoutingstatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<RoutingStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingStatus) Configuration.ApiClient.Deserialize(response, typeof(RoutingStatus)));
            
        }
    
        /// <summary>
        /// Update the routing status of a user 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status</param>
        /// <returns>Task of RoutingStatus</returns>
        public async System.Threading.Tasks.Task<RoutingStatus> PutUserIdRoutingstatusAsync (string userId, RoutingStatus body = null)
        {
             ApiResponse<RoutingStatus> response = await PutUserIdRoutingstatusAsyncWithHttpInfo(userId, body);
             return response.Data;

        }

        /// <summary>
        /// Update the routing status of a user 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">Routing Status</param>
        /// <returns>Task of ApiResponse (RoutingStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoutingStatus>> PutUserIdRoutingstatusAsyncWithHttpInfo (string userId, RoutingStatus body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling PutUserIdRoutingstatus");
            
    
            var path_ = "/api/v1/users/{userId}/routingstatus";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutUserIdRoutingstatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutUserIdRoutingstatus: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RoutingStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingStatus) Configuration.ApiClient.Deserialize(response, typeof(RoutingStatus)));
            
        }
        
        /// <summary>
        /// List skills for user 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>UserSkillEntityListing</returns>
        public UserSkillEntityListing GetUserIdSkills (string userId)
        {
             ApiResponse<UserSkillEntityListing> response = GetUserIdSkillsWithHttpInfo(userId);
             return response.Data;
        }

        /// <summary>
        /// List skills for user 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>ApiResponse of UserSkillEntityListing</returns>
        public ApiResponse< UserSkillEntityListing > GetUserIdSkillsWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserIdSkills");
            
    
            var path_ = "/api/v1/users/{userId}/skills";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetUserIdSkills: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdSkills: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserSkillEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserSkillEntityListing) Configuration.ApiClient.Deserialize(response, typeof(UserSkillEntityListing)));
            
        }
    
        /// <summary>
        /// List skills for user 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserSkillEntityListing</returns>
        public async System.Threading.Tasks.Task<UserSkillEntityListing> GetUserIdSkillsAsync (string userId)
        {
             ApiResponse<UserSkillEntityListing> response = await GetUserIdSkillsAsyncWithHttpInfo(userId);
             return response.Data;

        }

        /// <summary>
        /// List skills for user 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserSkillEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserSkillEntityListing>> GetUserIdSkillsAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserIdSkills");
            
    
            var path_ = "/api/v1/users/{userId}/skills";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetUserIdSkills: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserIdSkills: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserSkillEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserSkillEntityListing) Configuration.ApiClient.Deserialize(response, typeof(UserSkillEntityListing)));
            
        }
        
    }
    
}
