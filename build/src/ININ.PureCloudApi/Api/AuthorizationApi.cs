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
    public interface IAuthorizationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns></returns>
        void DeleteRole (string roleId);

        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteRoleWithHttpInfo (string roleId);
        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns></returns>
        void DeleteUserRoles (string userId);

        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteUserRolesWithHttpInfo (string userId);
        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>PermissionCollectionEntityListing</returns>
        PermissionCollectionEntityListing GetPermissions (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of PermissionCollectionEntityListing</returns>
        ApiResponse<PermissionCollectionEntityListing> GetPermissionsWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OrganizationProductEntityListing</returns>
        OrganizationProductEntityListing GetProducts ();

        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OrganizationProductEntityListing</returns>
        ApiResponse<OrganizationProductEntityListing> GetProductsWithHttpInfo ();
        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole GetRole (string roleId);

        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> GetRoleWithHttpInfo (string roleId);
        /// <summary>
        /// Get an org role to default role comparison comparison
        /// </summary>
        /// <remarks>
        /// Compares any organization role to a default role id and show differences
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>DomainOrgRoleDifference</returns>
        DomainOrgRoleDifference GetRoleComparedefaultRightRoleId (string leftRoleId, string rightRoleId);

        /// <summary>
        /// Get an org role to default role comparison comparison
        /// </summary>
        /// <remarks>
        /// Compares any organization role to a default role id and show differences
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>ApiResponse of DomainOrgRoleDifference</returns>
        ApiResponse<DomainOrgRoleDifference> GetRoleComparedefaultRightRoleIdWithHttpInfo (string leftRoleId, string rightRoleId);
        /// <summary>
        /// Retrieve a list of all roles defined for the organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        OrganizationRoleEntityListing GetRoles (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, bool? userCount = null);

        /// <summary>
        /// Retrieve a list of all roles defined for the organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        ApiResponse<OrganizationRoleEntityListing> GetRolesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, bool? userCount = null);
        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>UserAuthorization</returns>
        UserAuthorization GetUserRoles (string userId);

        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserAuthorization</returns>
        ApiResponse<UserAuthorization> GetUserRolesWithHttpInfo (string userId);
        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole PatchRole (string roleId, DomainOrganizationRole body);

        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> PatchRoleWithHttpInfo (string roleId, DomainOrganizationRole body);
        /// <summary>
        /// Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrgRoleDifference</returns>
        DomainOrgRoleDifference PostRoleComparedefaultRightRoleId (string leftRoleId, string rightRoleId, DomainOrganizationRole body);

        /// <summary>
        /// Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrgRoleDifference</returns>
        ApiResponse<DomainOrgRoleDifference> PostRoleComparedefaultRightRoleIdWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body);
        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole PostRoles (DomainOrganizationRole body);

        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> PostRolesWithHttpInfo (DomainOrganizationRole body);
        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force&#x3D;true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force&#x3D;true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        OrganizationRoleEntityListing PostRolesDefault (bool? force = null);

        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force&#x3D;true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force&#x3D;true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        ApiResponse<OrganizationRoleEntityListing> PostRolesDefaultWithHttpInfo (bool? force = null);
        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole PutRole (string roleId, DomainOrganizationRole body);

        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> PutRoleWithHttpInfo (string roleId, DomainOrganizationRole body);
        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> PutRoleUsersAdd (string roleId, List<string> body);

        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> PutRoleUsersAddWithHttpInfo (string roleId, List<string> body);
        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> PutRoleUsersRemove (string roleId, List<string> body);

        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> PutRoleUsersRemoveWithHttpInfo (string roleId, List<string> body);
        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        OrganizationRoleEntityListing PutRolesDefault (List<DomainOrganizationRole> body);

        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        ApiResponse<OrganizationRoleEntityListing> PutRolesDefaultWithHttpInfo (List<DomainOrganizationRole> body);
        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>UserAuthorization</returns>
        UserAuthorization PutUserRoles (string userId, List<string> body);

        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>ApiResponse of UserAuthorization</returns>
        ApiResponse<UserAuthorization> PutUserRolesWithHttpInfo (string userId, List<string> body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteRoleAsync (string roleId);

        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRoleAsyncWithHttpInfo (string roleId);
        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteUserRolesAsync (string userId);

        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserRolesAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of PermissionCollectionEntityListing</returns>
        System.Threading.Tasks.Task<PermissionCollectionEntityListing> GetPermissionsAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (PermissionCollectionEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PermissionCollectionEntityListing>> GetPermissionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OrganizationProductEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationProductEntityListing> GetProductsAsync ();

        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OrganizationProductEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationProductEntityListing>> GetProductsAsyncWithHttpInfo ();
        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> GetRoleAsync (string roleId);

        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> GetRoleAsyncWithHttpInfo (string roleId);
        /// <summary>
        /// Get an org role to default role comparison comparison
        /// </summary>
        /// <remarks>
        /// Compares any organization role to a default role id and show differences
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>Task of DomainOrgRoleDifference</returns>
        System.Threading.Tasks.Task<DomainOrgRoleDifference> GetRoleComparedefaultRightRoleIdAsync (string leftRoleId, string rightRoleId);

        /// <summary>
        /// Get an org role to default role comparison comparison
        /// </summary>
        /// <remarks>
        /// Compares any organization role to a default role id and show differences
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>Task of ApiResponse (DomainOrgRoleDifference)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> GetRoleComparedefaultRightRoleIdAsyncWithHttpInfo (string leftRoleId, string rightRoleId);
        /// <summary>
        /// Retrieve a list of all roles defined for the organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationRoleEntityListing> GetRolesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, bool? userCount = null);

        /// <summary>
        /// Retrieve a list of all roles defined for the organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> GetRolesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, bool? userCount = null);
        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserAuthorization</returns>
        System.Threading.Tasks.Task<UserAuthorization> GetUserRolesAsync (string userId);

        /// <summary>
        /// Returns a listing of roles and permissions for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> GetUserRolesAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> PatchRoleAsync (string roleId, DomainOrganizationRole body);

        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> PatchRoleAsyncWithHttpInfo (string roleId, DomainOrganizationRole body);
        /// <summary>
        /// Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrgRoleDifference</returns>
        System.Threading.Tasks.Task<DomainOrgRoleDifference> PostRoleComparedefaultRightRoleIdAsync (string leftRoleId, string rightRoleId, DomainOrganizationRole body);

        /// <summary>
        /// Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrgRoleDifference)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> PostRoleComparedefaultRightRoleIdAsyncWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body);
        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> PostRolesAsync (DomainOrganizationRole body);

        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> PostRolesAsyncWithHttpInfo (DomainOrganizationRole body);
        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force&#x3D;true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force&#x3D;true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationRoleEntityListing> PostRolesDefaultAsync (bool? force = null);

        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force&#x3D;true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force&#x3D;true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> PostRolesDefaultAsyncWithHttpInfo (bool? force = null);
        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> PutRoleAsync (string roleId, DomainOrganizationRole body);

        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> PutRoleAsyncWithHttpInfo (string roleId, DomainOrganizationRole body);
        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> PutRoleUsersAddAsync (string roleId, List<string> body);

        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> PutRoleUsersAddAsyncWithHttpInfo (string roleId, List<string> body);
        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> PutRoleUsersRemoveAsync (string roleId, List<string> body);

        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> PutRoleUsersRemoveAsyncWithHttpInfo (string roleId, List<string> body);
        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationRoleEntityListing> PutRolesDefaultAsync (List<DomainOrganizationRole> body);

        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> PutRolesDefaultAsyncWithHttpInfo (List<DomainOrganizationRole> body);
        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>Task of UserAuthorization</returns>
        System.Threading.Tasks.Task<UserAuthorization> PutUserRolesAsync (string userId, List<string> body);

        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> PutUserRolesAsyncWithHttpInfo (string userId, List<string> body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthorizationApi : IAuthorizationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthorizationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthorizationApi(Configuration configuration = null)
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        /// Delete an organization role. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns></returns>
        public void DeleteRole (string roleId)
        {
             DeleteRoleWithHttpInfo(roleId);
        }

        /// <summary>
        /// Delete an organization role. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteRoleWithHttpInfo (string roleId)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->DeleteRole");

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
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
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRole: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete an organization role. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteRoleAsync (string roleId)
        {
             await DeleteRoleAsyncWithHttpInfo(roleId);

        }

        /// <summary>
        /// Delete an organization role. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRoleAsyncWithHttpInfo (string roleId)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->DeleteRole");

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
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
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRole: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Removes all the roles from the user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns></returns>
        public void DeleteUserRoles (string userId)
        {
             DeleteUserRolesWithHttpInfo(userId);
        }

        /// <summary>
        /// Removes all the roles from the user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteUserRolesWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->DeleteUserRoles");

            var localVarPath = "/api/v2/users/{userId}/roles";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserRoles: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Removes all the roles from the user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteUserRolesAsync (string userId)
        {
             await DeleteUserRolesAsyncWithHttpInfo(userId);

        }

        /// <summary>
        /// Removes all the roles from the user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserRolesAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->DeleteUserRoles");

            var localVarPath = "/api/v2/users/{userId}/roles";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserRoles: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get all permissions. Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>PermissionCollectionEntityListing</returns>
        public PermissionCollectionEntityListing GetPermissions (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PermissionCollectionEntityListing> localVarResponse = GetPermissionsWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all permissions. Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of PermissionCollectionEntityListing</returns>
        public ApiResponse< PermissionCollectionEntityListing > GetPermissionsWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/authorization/permissions";
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
                throw new ApiException (localVarStatusCode, "Error calling GetPermissions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPermissions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PermissionCollectionEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PermissionCollectionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PermissionCollectionEntityListing)));
            
        }

        /// <summary>
        /// Get all permissions. Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of PermissionCollectionEntityListing</returns>
        public async System.Threading.Tasks.Task<PermissionCollectionEntityListing> GetPermissionsAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PermissionCollectionEntityListing> localVarResponse = await GetPermissionsAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all permissions. Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (PermissionCollectionEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PermissionCollectionEntityListing>> GetPermissionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/authorization/permissions";
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
                throw new ApiException (localVarStatusCode, "Error calling GetPermissions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPermissions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PermissionCollectionEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PermissionCollectionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PermissionCollectionEntityListing)));
            
        }

        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OrganizationProductEntityListing</returns>
        public OrganizationProductEntityListing GetProducts ()
        {
             ApiResponse<OrganizationProductEntityListing> localVarResponse = GetProductsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OrganizationProductEntityListing</returns>
        public ApiResponse< OrganizationProductEntityListing > GetProductsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/authorization/products";
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
                throw new ApiException (localVarStatusCode, "Error calling GetProducts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProducts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationProductEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationProductEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationProductEntityListing)));
            
        }

        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OrganizationProductEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationProductEntityListing> GetProductsAsync ()
        {
             ApiResponse<OrganizationProductEntityListing> localVarResponse = await GetProductsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OrganizationProductEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationProductEntityListing>> GetProductsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/authorization/products";
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
                throw new ApiException (localVarStatusCode, "Error calling GetProducts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProducts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationProductEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationProductEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationProductEntityListing)));
            
        }

        /// <summary>
        /// Get a single organization role. Get the organization role specified by its ID.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole GetRole (string roleId)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = GetRoleWithHttpInfo(roleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single organization role. Get the organization role specified by its ID.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > GetRoleWithHttpInfo (string roleId)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->GetRole");

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
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
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetRole: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        /// <summary>
        /// Get a single organization role. Get the organization role specified by its ID.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        public async System.Threading.Tasks.Task<DomainOrganizationRole> GetRoleAsync (string roleId)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = await GetRoleAsyncWithHttpInfo(roleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a single organization role. Get the organization role specified by its ID.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> GetRoleAsyncWithHttpInfo (string roleId)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->GetRole");

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
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
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetRole: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        /// <summary>
        /// Get an org role to default role comparison comparison Compares any organization role to a default role id and show differences
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>DomainOrgRoleDifference</returns>
        public DomainOrgRoleDifference GetRoleComparedefaultRightRoleId (string leftRoleId, string rightRoleId)
        {
             ApiResponse<DomainOrgRoleDifference> localVarResponse = GetRoleComparedefaultRightRoleIdWithHttpInfo(leftRoleId, rightRoleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an org role to default role comparison comparison Compares any organization role to a default role id and show differences
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>ApiResponse of DomainOrgRoleDifference</returns>
        public ApiResponse< DomainOrgRoleDifference > GetRoleComparedefaultRightRoleIdWithHttpInfo (string leftRoleId, string rightRoleId)
        {
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null)
                throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling AuthorizationApi->GetRoleComparedefaultRightRoleId");
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null)
                throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling AuthorizationApi->GetRoleComparedefaultRightRoleId");

            var localVarPath = "/api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
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
            if (leftRoleId != null) localVarPathParams.Add("leftRoleId", Configuration.ApiClient.ParameterToString(leftRoleId)); // path parameter
            if (rightRoleId != null) localVarPathParams.Add("rightRoleId", Configuration.ApiClient.ParameterToString(rightRoleId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetRoleComparedefaultRightRoleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRoleComparedefaultRightRoleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrgRoleDifference) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrgRoleDifference)));
            
        }

        /// <summary>
        /// Get an org role to default role comparison comparison Compares any organization role to a default role id and show differences
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>Task of DomainOrgRoleDifference</returns>
        public async System.Threading.Tasks.Task<DomainOrgRoleDifference> GetRoleComparedefaultRightRoleIdAsync (string leftRoleId, string rightRoleId)
        {
             ApiResponse<DomainOrgRoleDifference> localVarResponse = await GetRoleComparedefaultRightRoleIdAsyncWithHttpInfo(leftRoleId, rightRoleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an org role to default role comparison comparison Compares any organization role to a default role id and show differences
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>Task of ApiResponse (DomainOrgRoleDifference)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> GetRoleComparedefaultRightRoleIdAsyncWithHttpInfo (string leftRoleId, string rightRoleId)
        {
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null)
                throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling AuthorizationApi->GetRoleComparedefaultRightRoleId");
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null)
                throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling AuthorizationApi->GetRoleComparedefaultRightRoleId");

            var localVarPath = "/api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
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
            if (leftRoleId != null) localVarPathParams.Add("leftRoleId", Configuration.ApiClient.ParameterToString(leftRoleId)); // path parameter
            if (rightRoleId != null) localVarPathParams.Add("rightRoleId", Configuration.ApiClient.ParameterToString(rightRoleId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetRoleComparedefaultRightRoleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRoleComparedefaultRightRoleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrgRoleDifference) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrgRoleDifference)));
            
        }

        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        public OrganizationRoleEntityListing GetRoles (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, bool? userCount = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = GetRolesWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, permission, userCount);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        public ApiResponse< OrganizationRoleEntityListing > GetRolesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, bool? userCount = null)
        {

            var localVarPath = "/api/v2/authorization/roles";
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
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (permission != null) localVarQueryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            if (userCount != null) localVarQueryParams.Add("userCount", Configuration.ApiClient.ParameterToString(userCount)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetRoles: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)));
            
        }

        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationRoleEntityListing> GetRolesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, bool? userCount = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = await GetRolesAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, permission, userCount);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> GetRolesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, bool? userCount = null)
        {

            var localVarPath = "/api/v2/authorization/roles";
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
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (permission != null) localVarQueryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            if (userCount != null) localVarQueryParams.Add("userCount", Configuration.ApiClient.ParameterToString(userCount)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetRoles: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)));
            
        }

        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>UserAuthorization</returns>
        public UserAuthorization GetUserRoles (string userId)
        {
             ApiResponse<UserAuthorization> localVarResponse = GetUserRolesWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserAuthorization</returns>
        public ApiResponse< UserAuthorization > GetUserRolesWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->GetUserRoles");

            var localVarPath = "/api/v2/users/{userId}/roles";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoles: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthorization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAuthorization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)));
            
        }

        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserAuthorization</returns>
        public async System.Threading.Tasks.Task<UserAuthorization> GetUserRolesAsync (string userId)
        {
             ApiResponse<UserAuthorization> localVarResponse = await GetUserRolesAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a listing of roles and permissions for a user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> GetUserRolesAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->GetUserRoles");

            var localVarPath = "/api/v2/users/{userId}/roles";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoles: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthorization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAuthorization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)));
            
        }

        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole PatchRole (string roleId, DomainOrganizationRole body)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = PatchRoleWithHttpInfo(roleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > PatchRoleWithHttpInfo (string roleId, DomainOrganizationRole body)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PatchRole");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PatchRole");

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
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
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PatchRole: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        public async System.Threading.Tasks.Task<DomainOrganizationRole> PatchRoleAsync (string roleId, DomainOrganizationRole body)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = await PatchRoleAsyncWithHttpInfo(roleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> PatchRoleAsyncWithHttpInfo (string roleId, DomainOrganizationRole body)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PatchRole");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PatchRole");

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
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
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PatchRole: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        /// <summary>
        /// Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrgRoleDifference</returns>
        public DomainOrgRoleDifference PostRoleComparedefaultRightRoleId (string leftRoleId, string rightRoleId, DomainOrganizationRole body)
        {
             ApiResponse<DomainOrgRoleDifference> localVarResponse = PostRoleComparedefaultRightRoleIdWithHttpInfo(leftRoleId, rightRoleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrgRoleDifference</returns>
        public ApiResponse< DomainOrgRoleDifference > PostRoleComparedefaultRightRoleIdWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body)
        {
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null)
                throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling AuthorizationApi->PostRoleComparedefaultRightRoleId");
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null)
                throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling AuthorizationApi->PostRoleComparedefaultRightRoleId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostRoleComparedefaultRightRoleId");

            var localVarPath = "/api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
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
            if (leftRoleId != null) localVarPathParams.Add("leftRoleId", Configuration.ApiClient.ParameterToString(leftRoleId)); // path parameter
            if (rightRoleId != null) localVarPathParams.Add("rightRoleId", Configuration.ApiClient.ParameterToString(rightRoleId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostRoleComparedefaultRightRoleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRoleComparedefaultRightRoleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrgRoleDifference) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrgRoleDifference)));
            
        }

        /// <summary>
        /// Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrgRoleDifference</returns>
        public async System.Threading.Tasks.Task<DomainOrgRoleDifference> PostRoleComparedefaultRightRoleIdAsync (string leftRoleId, string rightRoleId, DomainOrganizationRole body)
        {
             ApiResponse<DomainOrgRoleDifference> localVarResponse = await PostRoleComparedefaultRightRoleIdAsyncWithHttpInfo(leftRoleId, rightRoleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrgRoleDifference)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> PostRoleComparedefaultRightRoleIdAsyncWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body)
        {
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null)
                throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling AuthorizationApi->PostRoleComparedefaultRightRoleId");
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null)
                throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling AuthorizationApi->PostRoleComparedefaultRightRoleId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostRoleComparedefaultRightRoleId");

            var localVarPath = "/api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
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
            if (leftRoleId != null) localVarPathParams.Add("leftRoleId", Configuration.ApiClient.ParameterToString(leftRoleId)); // path parameter
            if (rightRoleId != null) localVarPathParams.Add("rightRoleId", Configuration.ApiClient.ParameterToString(rightRoleId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostRoleComparedefaultRightRoleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRoleComparedefaultRightRoleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrgRoleDifference) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrgRoleDifference)));
            
        }

        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole PostRoles (DomainOrganizationRole body)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = PostRolesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > PostRolesWithHttpInfo (DomainOrganizationRole body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostRoles");

            var localVarPath = "/api/v2/authorization/roles";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostRoles: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        public async System.Threading.Tasks.Task<DomainOrganizationRole> PostRolesAsync (DomainOrganizationRole body)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = await PostRolesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> PostRolesAsyncWithHttpInfo (DomainOrganizationRole body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PostRoles");

            var localVarPath = "/api/v2/authorization/roles";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostRoles: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        /// <summary>
        /// Restores all default roles This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force&#x3D;true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force&#x3D;true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        public OrganizationRoleEntityListing PostRolesDefault (bool? force = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = PostRolesDefaultWithHttpInfo(force);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Restores all default roles This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force&#x3D;true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force&#x3D;true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        public ApiResponse< OrganizationRoleEntityListing > PostRolesDefaultWithHttpInfo (bool? force = null)
        {

            var localVarPath = "/api/v2/authorization/roles/default";
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
            if (force != null) localVarQueryParams.Add("force", Configuration.ApiClient.ParameterToString(force)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PostRolesDefault: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRolesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)));
            
        }

        /// <summary>
        /// Restores all default roles This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force&#x3D;true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force&#x3D;true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationRoleEntityListing> PostRolesDefaultAsync (bool? force = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = await PostRolesDefaultAsyncWithHttpInfo(force);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Restores all default roles This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force&#x3D;true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force&#x3D;true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> PostRolesDefaultAsyncWithHttpInfo (bool? force = null)
        {

            var localVarPath = "/api/v2/authorization/roles/default";
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
            if (force != null) localVarQueryParams.Add("force", Configuration.ApiClient.ParameterToString(force)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PostRolesDefault: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRolesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)));
            
        }

        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole PutRole (string roleId, DomainOrganizationRole body)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = PutRoleWithHttpInfo(roleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > PutRoleWithHttpInfo (string roleId, DomainOrganizationRole body)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PutRole");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutRole");

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
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
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutRole: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        public async System.Threading.Tasks.Task<DomainOrganizationRole> PutRoleAsync (string roleId, DomainOrganizationRole body)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = await PutRoleAsyncWithHttpInfo(roleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">Organization role</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> PutRoleAsyncWithHttpInfo (string roleId, DomainOrganizationRole body)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PutRole");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutRole");

            var localVarPath = "/api/v2/authorization/roles/{roleId}";
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
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutRole: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRole: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> PutRoleUsersAdd (string roleId, List<string> body)
        {
             ApiResponse<List<string>> localVarResponse = PutRoleUsersAddWithHttpInfo(roleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > PutRoleUsersAddWithHttpInfo (string roleId, List<string> body)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PutRoleUsersAdd");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutRoleUsersAdd");

            var localVarPath = "/api/v2/authorization/roles/{roleId}/users/add";
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
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutRoleUsersAdd: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRoleUsersAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> PutRoleUsersAddAsync (string roleId, List<string> body)
        {
             ApiResponse<List<string>> localVarResponse = await PutRoleUsersAddAsyncWithHttpInfo(roleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> PutRoleUsersAddAsyncWithHttpInfo (string roleId, List<string> body)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PutRoleUsersAdd");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutRoleUsersAdd");

            var localVarPath = "/api/v2/authorization/roles/{roleId}/users/add";
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
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutRoleUsersAdd: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRoleUsersAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> PutRoleUsersRemove (string roleId, List<string> body)
        {
             ApiResponse<List<string>> localVarResponse = PutRoleUsersRemoveWithHttpInfo(roleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > PutRoleUsersRemoveWithHttpInfo (string roleId, List<string> body)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PutRoleUsersRemove");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutRoleUsersRemove");

            var localVarPath = "/api/v2/authorization/roles/{roleId}/users/remove";
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
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutRoleUsersRemove: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRoleUsersRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> PutRoleUsersRemoveAsync (string roleId, List<string> body)
        {
             ApiResponse<List<string>> localVarResponse = await PutRoleUsersRemoveAsyncWithHttpInfo(roleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body">List of user IDs</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> PutRoleUsersRemoveAsyncWithHttpInfo (string roleId, List<string> body)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->PutRoleUsersRemove");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutRoleUsersRemove");

            var localVarPath = "/api/v2/authorization/roles/{roleId}/users/remove";
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
            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutRoleUsersRemove: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRoleUsersRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        public OrganizationRoleEntityListing PutRolesDefault (List<DomainOrganizationRole> body)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = PutRolesDefaultWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        public ApiResponse< OrganizationRoleEntityListing > PutRolesDefaultWithHttpInfo (List<DomainOrganizationRole> body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutRolesDefault");

            var localVarPath = "/api/v2/authorization/roles/default";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutRolesDefault: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRolesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)));
            
        }

        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationRoleEntityListing> PutRolesDefaultAsync (List<DomainOrganizationRole> body)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = await PutRolesDefaultAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization roles list</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> PutRolesDefaultAsyncWithHttpInfo (List<DomainOrganizationRole> body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutRolesDefault");

            var localVarPath = "/api/v2/authorization/roles/default";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutRolesDefault: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRolesDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)));
            
        }

        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>UserAuthorization</returns>
        public UserAuthorization PutUserRoles (string userId, List<string> body)
        {
             ApiResponse<UserAuthorization> localVarResponse = PutUserRolesWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>ApiResponse of UserAuthorization</returns>
        public ApiResponse< UserAuthorization > PutUserRolesWithHttpInfo (string userId, List<string> body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->PutUserRoles");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutUserRoles");

            var localVarPath = "/api/v2/users/{userId}/roles";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoles: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthorization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAuthorization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)));
            
        }

        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>Task of UserAuthorization</returns>
        public async System.Threading.Tasks.Task<UserAuthorization> PutUserRolesAsync (string userId, List<string> body)
        {
             ApiResponse<UserAuthorization> localVarResponse = await PutUserRolesAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">List of roles</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> PutUserRolesAsyncWithHttpInfo (string userId, List<string> body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->PutUserRoles");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthorizationApi->PutUserRoles");

            var localVarPath = "/api/v2/users/{userId}/roles";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoles: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserRoles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthorization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAuthorization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)));
            
        }

    }
}
