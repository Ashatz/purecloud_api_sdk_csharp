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
    public interface IAuthorizationApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve a list of all licenses defined in the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainLicenseEntityListing</returns>
        DomainLicenseEntityListing AuthorizationLicensesGet (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Retrieve a list of all licenses defined in the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainLicenseEntityListing</returns>
        ApiResponse<DomainLicenseEntityListing> AuthorizationLicensesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);
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
        PermissionCollectionEntityListing AuthorizationPermissionsGet (int? pageSize = null, int? pageNumber = null);

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
        ApiResponse<PermissionCollectionEntityListing> AuthorizationPermissionsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OrganizationProductEntityListing</returns>
        OrganizationProductEntityListing AuthorizationProductsGet ();

        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OrganizationProductEntityListing</returns>
        ApiResponse<OrganizationProductEntityListing> AuthorizationProductsGetWithHttpInfo ();
        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force&#x3D;true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force&#x3D;true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        OrganizationRoleEntityListing AuthorizationRolesDefaultPost (bool? force = null);

        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force&#x3D;true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force&#x3D;true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        ApiResponse<OrganizationRoleEntityListing> AuthorizationRolesDefaultPostWithHttpInfo (bool? force = null);
        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        OrganizationRoleEntityListing AuthorizationRolesDefaultPut (List<DomainOrganizationRole> body = null);

        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        ApiResponse<OrganizationRoleEntityListing> AuthorizationRolesDefaultPutWithHttpInfo (List<DomainOrganizationRole> body = null);
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
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        OrganizationRoleEntityListing AuthorizationRolesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null);

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
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        ApiResponse<OrganizationRoleEntityListing> AuthorizationRolesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null);
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
        DomainOrgRoleDifference AuthorizationRolesLeftroleidComparedefaultRightroleidGet (string leftRoleId, string rightRoleId);

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
        ApiResponse<DomainOrgRoleDifference> AuthorizationRolesLeftroleidComparedefaultRightroleidGetWithHttpInfo (string leftRoleId, string rightRoleId);
        /// <summary>
        ///  Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DomainOrgRoleDifference</returns>
        DomainOrgRoleDifference AuthorizationRolesLeftroleidComparedefaultRightroleidPost (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null);

        /// <summary>
        ///  Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DomainOrgRoleDifference</returns>
        ApiResponse<DomainOrgRoleDifference> AuthorizationRolesLeftroleidComparedefaultRightroleidPostWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null);
        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole AuthorizationRolesPost (DomainOrganizationRole body = null);

        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> AuthorizationRolesPostWithHttpInfo (DomainOrganizationRole body = null);
        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns></returns>
        void AuthorizationRolesRoleidDelete (string roleId);

        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AuthorizationRolesRoleidDeleteWithHttpInfo (string roleId);
        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole AuthorizationRolesRoleidGet (string roleId);

        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> AuthorizationRolesRoleidGetWithHttpInfo (string roleId);
        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole AuthorizationRolesRoleidPatch (string roleId, DomainOrganizationRole body = null);

        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> AuthorizationRolesRoleidPatchWithHttpInfo (string roleId, DomainOrganizationRole body = null);
        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole AuthorizationRolesRoleidPut (string roleId, DomainOrganizationRole body = null);

        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> AuthorizationRolesRoleidPutWithHttpInfo (string roleId, DomainOrganizationRole body = null);
        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> AuthorizationRolesRoleidUsersAddPut (string roleId, List<string> body = null);

        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> AuthorizationRolesRoleidUsersAddPutWithHttpInfo (string roleId, List<string> body = null);
        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> AuthorizationRolesRoleidUsersRemovePut (string roleId, List<string> body = null);

        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> AuthorizationRolesRoleidUsersRemovePutWithHttpInfo (string roleId, List<string> body = null);
        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns></returns>
        void AuthorizationUsersUseridRolesDelete (string userId);

        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AuthorizationUsersUseridRolesDeleteWithHttpInfo (string userId);
        /// <summary>
        /// Get the list of roles for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>UserAuthorization</returns>
        UserAuthorization AuthorizationUsersUseridRolesGet (string userId);

        /// <summary>
        /// Get the list of roles for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserAuthorization</returns>
        ApiResponse<UserAuthorization> AuthorizationUsersUseridRolesGetWithHttpInfo (string userId);
        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> AuthorizationUsersUseridRolesPut (string userId, List<string> body = null);

        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> AuthorizationUsersUseridRolesPutWithHttpInfo (string userId, List<string> body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve a list of all licenses defined in the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainLicenseEntityListing</returns>
        System.Threading.Tasks.Task<DomainLicenseEntityListing> AuthorizationLicensesGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Retrieve a list of all licenses defined in the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainLicenseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLicenseEntityListing>> AuthorizationLicensesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
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
        System.Threading.Tasks.Task<PermissionCollectionEntityListing> AuthorizationPermissionsGetAsync (int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<ApiResponse<PermissionCollectionEntityListing>> AuthorizationPermissionsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OrganizationProductEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationProductEntityListing> AuthorizationProductsGetAsync ();

        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OrganizationProductEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationProductEntityListing>> AuthorizationProductsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force&#x3D;true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force&#x3D;true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationRoleEntityListing> AuthorizationRolesDefaultPostAsync (bool? force = null);

        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force&#x3D;true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force&#x3D;true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> AuthorizationRolesDefaultPostAsyncWithHttpInfo (bool? force = null);
        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationRoleEntityListing> AuthorizationRolesDefaultPutAsync (List<DomainOrganizationRole> body = null);

        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> AuthorizationRolesDefaultPutAsyncWithHttpInfo (List<DomainOrganizationRole> body = null);
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
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationRoleEntityListing> AuthorizationRolesGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null);

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
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> AuthorizationRolesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null);
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
        System.Threading.Tasks.Task<DomainOrgRoleDifference> AuthorizationRolesLeftroleidComparedefaultRightroleidGetAsync (string leftRoleId, string rightRoleId);

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
        System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> AuthorizationRolesLeftroleidComparedefaultRightroleidGetAsyncWithHttpInfo (string leftRoleId, string rightRoleId);
        /// <summary>
        ///  Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DomainOrgRoleDifference</returns>
        System.Threading.Tasks.Task<DomainOrgRoleDifference> AuthorizationRolesLeftroleidComparedefaultRightroleidPostAsync (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null);

        /// <summary>
        ///  Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DomainOrgRoleDifference)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> AuthorizationRolesLeftroleidComparedefaultRightroleidPostAsyncWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null);
        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> AuthorizationRolesPostAsync (DomainOrganizationRole body = null);

        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> AuthorizationRolesPostAsyncWithHttpInfo (DomainOrganizationRole body = null);
        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AuthorizationRolesRoleidDeleteAsync (string roleId);

        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AuthorizationRolesRoleidDeleteAsyncWithHttpInfo (string roleId);
        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> AuthorizationRolesRoleidGetAsync (string roleId);

        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> AuthorizationRolesRoleidGetAsyncWithHttpInfo (string roleId);
        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> AuthorizationRolesRoleidPatchAsync (string roleId, DomainOrganizationRole body = null);

        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> AuthorizationRolesRoleidPatchAsyncWithHttpInfo (string roleId, DomainOrganizationRole body = null);
        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> AuthorizationRolesRoleidPutAsync (string roleId, DomainOrganizationRole body = null);

        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> AuthorizationRolesRoleidPutAsyncWithHttpInfo (string roleId, DomainOrganizationRole body = null);
        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> AuthorizationRolesRoleidUsersAddPutAsync (string roleId, List<string> body = null);

        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> AuthorizationRolesRoleidUsersAddPutAsyncWithHttpInfo (string roleId, List<string> body = null);
        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> AuthorizationRolesRoleidUsersRemovePutAsync (string roleId, List<string> body = null);

        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> AuthorizationRolesRoleidUsersRemovePutAsyncWithHttpInfo (string roleId, List<string> body = null);
        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AuthorizationUsersUseridRolesDeleteAsync (string userId);

        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AuthorizationUsersUseridRolesDeleteAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Get the list of roles for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserAuthorization</returns>
        System.Threading.Tasks.Task<UserAuthorization> AuthorizationUsersUseridRolesGetAsync (string userId);

        /// <summary>
        /// Get the list of roles for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> AuthorizationUsersUseridRolesGetAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> AuthorizationUsersUseridRolesPutAsync (string userId, List<string> body = null);

        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> AuthorizationUsersUseridRolesPutAsyncWithHttpInfo (string userId, List<string> body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthorizationApi : IAuthorizationApi
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
        /// Retrieve a list of all licenses defined in the system 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainLicenseEntityListing</returns>
        public DomainLicenseEntityListing AuthorizationLicensesGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainLicenseEntityListing> localVarResponse = AuthorizationLicensesGetWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of all licenses defined in the system 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainLicenseEntityListing</returns>
        public ApiResponse< DomainLicenseEntityListing > AuthorizationLicensesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/authorization/licenses";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationLicensesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationLicensesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainLicenseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLicenseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainLicenseEntityListing)));
            
        }

        /// <summary>
        /// Retrieve a list of all licenses defined in the system 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainLicenseEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainLicenseEntityListing> AuthorizationLicensesGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainLicenseEntityListing> localVarResponse = await AuthorizationLicensesGetAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of all licenses defined in the system 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainLicenseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLicenseEntityListing>> AuthorizationLicensesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/authorization/licenses";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationLicensesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationLicensesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainLicenseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLicenseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainLicenseEntityListing)));
            
        }

        /// <summary>
        /// Get all permissions. Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>PermissionCollectionEntityListing</returns>
        public PermissionCollectionEntityListing AuthorizationPermissionsGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PermissionCollectionEntityListing> localVarResponse = AuthorizationPermissionsGetWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all permissions. Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of PermissionCollectionEntityListing</returns>
        public ApiResponse< PermissionCollectionEntityListing > AuthorizationPermissionsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/authorization/permissions";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationPermissionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationPermissionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<PermissionCollectionEntityListing> AuthorizationPermissionsGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PermissionCollectionEntityListing> localVarResponse = await AuthorizationPermissionsGetAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all permissions. Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (PermissionCollectionEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PermissionCollectionEntityListing>> AuthorizationPermissionsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/authorization/permissions";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationPermissionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationPermissionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PermissionCollectionEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PermissionCollectionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PermissionCollectionEntityListing)));
            
        }

        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OrganizationProductEntityListing</returns>
        public OrganizationProductEntityListing AuthorizationProductsGet ()
        {
             ApiResponse<OrganizationProductEntityListing> localVarResponse = AuthorizationProductsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OrganizationProductEntityListing</returns>
        public ApiResponse< OrganizationProductEntityListing > AuthorizationProductsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/authorization/products";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationProductsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationProductsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationProductEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationProductEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationProductEntityListing)));
            
        }

        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OrganizationProductEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationProductEntityListing> AuthorizationProductsGetAsync ()
        {
             ApiResponse<OrganizationProductEntityListing> localVarResponse = await AuthorizationProductsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OrganizationProductEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationProductEntityListing>> AuthorizationProductsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/authorization/products";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationProductsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationProductsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationProductEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationProductEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationProductEntityListing)));
            
        }

        /// <summary>
        /// Restores all default roles This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force&#x3D;true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force&#x3D;true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        public OrganizationRoleEntityListing AuthorizationRolesDefaultPost (bool? force = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = AuthorizationRolesDefaultPostWithHttpInfo(force);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Restores all default roles This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force&#x3D;true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force&#x3D;true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        public ApiResponse< OrganizationRoleEntityListing > AuthorizationRolesDefaultPostWithHttpInfo (bool? force = null)
        {

            var localVarPath = "/api/v1/authorization/roles/default";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesDefaultPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesDefaultPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<OrganizationRoleEntityListing> AuthorizationRolesDefaultPostAsync (bool? force = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = await AuthorizationRolesDefaultPostAsyncWithHttpInfo(force);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Restores all default roles This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force&#x3D;true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force&#x3D;true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="force">Restore default roles (optional, default to false)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> AuthorizationRolesDefaultPostAsyncWithHttpInfo (bool? force = null)
        {

            var localVarPath = "/api/v1/authorization/roles/default";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesDefaultPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesDefaultPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)));
            
        }

        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        public OrganizationRoleEntityListing AuthorizationRolesDefaultPut (List<DomainOrganizationRole> body = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = AuthorizationRolesDefaultPutWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        public ApiResponse< OrganizationRoleEntityListing > AuthorizationRolesDefaultPutWithHttpInfo (List<DomainOrganizationRole> body = null)
        {

            var localVarPath = "/api/v1/authorization/roles/default";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesDefaultPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesDefaultPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)));
            
        }

        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationRoleEntityListing> AuthorizationRolesDefaultPutAsync (List<DomainOrganizationRole> body = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = await AuthorizationRolesDefaultPutAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> AuthorizationRolesDefaultPutAsyncWithHttpInfo (List<DomainOrganizationRole> body = null)
        {

            var localVarPath = "/api/v1/authorization/roles/default";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesDefaultPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesDefaultPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        public OrganizationRoleEntityListing AuthorizationRolesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = AuthorizationRolesGetWithHttpInfo(pageSize, pageNumber, sortBy, expand, permission, userCount);
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
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        public ApiResponse< OrganizationRoleEntityListing > AuthorizationRolesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null)
        {

            var localVarPath = "/api/v1/authorization/roles";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationRoleEntityListing> AuthorizationRolesGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null)
        {
             ApiResponse<OrganizationRoleEntityListing> localVarResponse = await AuthorizationRolesGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, permission, userCount);
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
        /// <param name="permission"> (optional)</param>
        /// <param name="userCount"> (optional, default to true)</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> AuthorizationRolesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null)
        {

            var localVarPath = "/api/v1/authorization/roles";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationRoleEntityListing)));
            
        }

        /// <summary>
        /// Get an org role to default role comparison comparison Compares any organization role to a default role id and show differences
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>DomainOrgRoleDifference</returns>
        public DomainOrgRoleDifference AuthorizationRolesLeftroleidComparedefaultRightroleidGet (string leftRoleId, string rightRoleId)
        {
             ApiResponse<DomainOrgRoleDifference> localVarResponse = AuthorizationRolesLeftroleidComparedefaultRightroleidGetWithHttpInfo(leftRoleId, rightRoleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an org role to default role comparison comparison Compares any organization role to a default role id and show differences
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>ApiResponse of DomainOrgRoleDifference</returns>
        public ApiResponse< DomainOrgRoleDifference > AuthorizationRolesLeftroleidComparedefaultRightroleidGetWithHttpInfo (string leftRoleId, string rightRoleId)
        {
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null)
                throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling AuthorizationApi->AuthorizationRolesLeftroleidComparedefaultRightroleidGet");
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null)
                throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling AuthorizationApi->AuthorizationRolesLeftroleidComparedefaultRightroleidGet");

            var localVarPath = "/api/v1/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesLeftroleidComparedefaultRightroleidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesLeftroleidComparedefaultRightroleidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<DomainOrgRoleDifference> AuthorizationRolesLeftroleidComparedefaultRightroleidGetAsync (string leftRoleId, string rightRoleId)
        {
             ApiResponse<DomainOrgRoleDifference> localVarResponse = await AuthorizationRolesLeftroleidComparedefaultRightroleidGetAsyncWithHttpInfo(leftRoleId, rightRoleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an org role to default role comparison comparison Compares any organization role to a default role id and show differences
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>Task of ApiResponse (DomainOrgRoleDifference)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> AuthorizationRolesLeftroleidComparedefaultRightroleidGetAsyncWithHttpInfo (string leftRoleId, string rightRoleId)
        {
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null)
                throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling AuthorizationApi->AuthorizationRolesLeftroleidComparedefaultRightroleidGet");
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null)
                throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling AuthorizationApi->AuthorizationRolesLeftroleidComparedefaultRightroleidGet");

            var localVarPath = "/api/v1/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesLeftroleidComparedefaultRightroleidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesLeftroleidComparedefaultRightroleidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrgRoleDifference) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrgRoleDifference)));
            
        }

        /// <summary>
        ///  Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DomainOrgRoleDifference</returns>
        public DomainOrgRoleDifference AuthorizationRolesLeftroleidComparedefaultRightroleidPost (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrgRoleDifference> localVarResponse = AuthorizationRolesLeftroleidComparedefaultRightroleidPostWithHttpInfo(leftRoleId, rightRoleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DomainOrgRoleDifference</returns>
        public ApiResponse< DomainOrgRoleDifference > AuthorizationRolesLeftroleidComparedefaultRightroleidPostWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null)
        {
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null)
                throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling AuthorizationApi->AuthorizationRolesLeftroleidComparedefaultRightroleidPost");
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null)
                throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling AuthorizationApi->AuthorizationRolesLeftroleidComparedefaultRightroleidPost");

            var localVarPath = "/api/v1/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesLeftroleidComparedefaultRightroleidPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesLeftroleidComparedefaultRightroleidPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrgRoleDifference) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrgRoleDifference)));
            
        }

        /// <summary>
        ///  Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DomainOrgRoleDifference</returns>
        public async System.Threading.Tasks.Task<DomainOrgRoleDifference> AuthorizationRolesLeftroleidComparedefaultRightroleidPostAsync (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrgRoleDifference> localVarResponse = await AuthorizationRolesLeftroleidComparedefaultRightroleidPostAsyncWithHttpInfo(leftRoleId, rightRoleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DomainOrgRoleDifference)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> AuthorizationRolesLeftroleidComparedefaultRightroleidPostAsyncWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null)
        {
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null)
                throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling AuthorizationApi->AuthorizationRolesLeftroleidComparedefaultRightroleidPost");
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null)
                throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling AuthorizationApi->AuthorizationRolesLeftroleidComparedefaultRightroleidPost");

            var localVarPath = "/api/v1/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesLeftroleidComparedefaultRightroleidPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesLeftroleidComparedefaultRightroleidPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrgRoleDifference) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrgRoleDifference)));
            
        }

        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole AuthorizationRolesPost (DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = AuthorizationRolesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > AuthorizationRolesPostWithHttpInfo (DomainOrganizationRole body = null)
        {

            var localVarPath = "/api/v1/authorization/roles";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        public async System.Threading.Tasks.Task<DomainOrganizationRole> AuthorizationRolesPostAsync (DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = await AuthorizationRolesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> AuthorizationRolesPostAsyncWithHttpInfo (DomainOrganizationRole body = null)
        {

            var localVarPath = "/api/v1/authorization/roles";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        /// <summary>
        /// Delete an organization role. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns></returns>
        public void AuthorizationRolesRoleidDelete (string roleId)
        {
             AuthorizationRolesRoleidDeleteWithHttpInfo(roleId);
        }

        /// <summary>
        /// Delete an organization role. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AuthorizationRolesRoleidDeleteWithHttpInfo (string roleId)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->AuthorizationRolesRoleidDelete");

            var localVarPath = "/api/v1/authorization/roles/{roleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        public async System.Threading.Tasks.Task AuthorizationRolesRoleidDeleteAsync (string roleId)
        {
             await AuthorizationRolesRoleidDeleteAsyncWithHttpInfo(roleId);

        }

        /// <summary>
        /// Delete an organization role. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AuthorizationRolesRoleidDeleteAsyncWithHttpInfo (string roleId)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->AuthorizationRolesRoleidDelete");

            var localVarPath = "/api/v1/authorization/roles/{roleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a single organization role. Get the organization role specified by its ID.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole AuthorizationRolesRoleidGet (string roleId)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = AuthorizationRolesRoleidGetWithHttpInfo(roleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single organization role. Get the organization role specified by its ID.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > AuthorizationRolesRoleidGetWithHttpInfo (string roleId)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->AuthorizationRolesRoleidGet");

            var localVarPath = "/api/v1/authorization/roles/{roleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<DomainOrganizationRole> AuthorizationRolesRoleidGetAsync (string roleId)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = await AuthorizationRolesRoleidGetAsyncWithHttpInfo(roleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a single organization role. Get the organization role specified by its ID.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> AuthorizationRolesRoleidGetAsyncWithHttpInfo (string roleId)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->AuthorizationRolesRoleidGet");

            var localVarPath = "/api/v1/authorization/roles/{roleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole AuthorizationRolesRoleidPatch (string roleId, DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = AuthorizationRolesRoleidPatchWithHttpInfo(roleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > AuthorizationRolesRoleidPatchWithHttpInfo (string roleId, DomainOrganizationRole body = null)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->AuthorizationRolesRoleidPatch");

            var localVarPath = "/api/v1/authorization/roles/{roleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        public async System.Threading.Tasks.Task<DomainOrganizationRole> AuthorizationRolesRoleidPatchAsync (string roleId, DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = await AuthorizationRolesRoleidPatchAsyncWithHttpInfo(roleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> AuthorizationRolesRoleidPatchAsyncWithHttpInfo (string roleId, DomainOrganizationRole body = null)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->AuthorizationRolesRoleidPatch");

            var localVarPath = "/api/v1/authorization/roles/{roleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole AuthorizationRolesRoleidPut (string roleId, DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = AuthorizationRolesRoleidPutWithHttpInfo(roleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > AuthorizationRolesRoleidPutWithHttpInfo (string roleId, DomainOrganizationRole body = null)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->AuthorizationRolesRoleidPut");

            var localVarPath = "/api/v1/authorization/roles/{roleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        public async System.Threading.Tasks.Task<DomainOrganizationRole> AuthorizationRolesRoleidPutAsync (string roleId, DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrganizationRole> localVarResponse = await AuthorizationRolesRoleidPutAsyncWithHttpInfo(roleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> AuthorizationRolesRoleidPutAsyncWithHttpInfo (string roleId, DomainOrganizationRole body = null)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->AuthorizationRolesRoleidPut");

            var localVarPath = "/api/v1/authorization/roles/{roleId}";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainOrganizationRole)));
            
        }

        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> AuthorizationRolesRoleidUsersAddPut (string roleId, List<string> body = null)
        {
             ApiResponse<List<string>> localVarResponse = AuthorizationRolesRoleidUsersAddPutWithHttpInfo(roleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > AuthorizationRolesRoleidUsersAddPutWithHttpInfo (string roleId, List<string> body = null)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->AuthorizationRolesRoleidUsersAddPut");

            var localVarPath = "/api/v1/authorization/roles/{roleId}/users/add";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidUsersAddPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidUsersAddPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> AuthorizationRolesRoleidUsersAddPutAsync (string roleId, List<string> body = null)
        {
             ApiResponse<List<string>> localVarResponse = await AuthorizationRolesRoleidUsersAddPutAsyncWithHttpInfo(roleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> AuthorizationRolesRoleidUsersAddPutAsyncWithHttpInfo (string roleId, List<string> body = null)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->AuthorizationRolesRoleidUsersAddPut");

            var localVarPath = "/api/v1/authorization/roles/{roleId}/users/add";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidUsersAddPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidUsersAddPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> AuthorizationRolesRoleidUsersRemovePut (string roleId, List<string> body = null)
        {
             ApiResponse<List<string>> localVarResponse = AuthorizationRolesRoleidUsersRemovePutWithHttpInfo(roleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > AuthorizationRolesRoleidUsersRemovePutWithHttpInfo (string roleId, List<string> body = null)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->AuthorizationRolesRoleidUsersRemovePut");

            var localVarPath = "/api/v1/authorization/roles/{roleId}/users/remove";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidUsersRemovePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidUsersRemovePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> AuthorizationRolesRoleidUsersRemovePutAsync (string roleId, List<string> body = null)
        {
             ApiResponse<List<string>> localVarResponse = await AuthorizationRolesRoleidUsersRemovePutAsyncWithHttpInfo(roleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> AuthorizationRolesRoleidUsersRemovePutAsyncWithHttpInfo (string roleId, List<string> body = null)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling AuthorizationApi->AuthorizationRolesRoleidUsersRemovePut");

            var localVarPath = "/api/v1/authorization/roles/{roleId}/users/remove";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidUsersRemovePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationRolesRoleidUsersRemovePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Removes all the roles from the user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns></returns>
        public void AuthorizationUsersUseridRolesDelete (string userId)
        {
             AuthorizationUsersUseridRolesDeleteWithHttpInfo(userId);
        }

        /// <summary>
        /// Removes all the roles from the user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AuthorizationUsersUseridRolesDeleteWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->AuthorizationUsersUseridRolesDelete");

            var localVarPath = "/api/v1/authorization/users/{userId}/roles";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationUsersUseridRolesDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationUsersUseridRolesDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        public async System.Threading.Tasks.Task AuthorizationUsersUseridRolesDeleteAsync (string userId)
        {
             await AuthorizationUsersUseridRolesDeleteAsyncWithHttpInfo(userId);

        }

        /// <summary>
        /// Removes all the roles from the user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AuthorizationUsersUseridRolesDeleteAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->AuthorizationUsersUseridRolesDelete");

            var localVarPath = "/api/v1/authorization/users/{userId}/roles";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationUsersUseridRolesDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationUsersUseridRolesDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get the list of roles for a user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>UserAuthorization</returns>
        public UserAuthorization AuthorizationUsersUseridRolesGet (string userId)
        {
             ApiResponse<UserAuthorization> localVarResponse = AuthorizationUsersUseridRolesGetWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of roles for a user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserAuthorization</returns>
        public ApiResponse< UserAuthorization > AuthorizationUsersUseridRolesGetWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->AuthorizationUsersUseridRolesGet");

            var localVarPath = "/api/v1/authorization/users/{userId}/roles";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationUsersUseridRolesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationUsersUseridRolesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthorization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAuthorization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)));
            
        }

        /// <summary>
        /// Get the list of roles for a user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserAuthorization</returns>
        public async System.Threading.Tasks.Task<UserAuthorization> AuthorizationUsersUseridRolesGetAsync (string userId)
        {
             ApiResponse<UserAuthorization> localVarResponse = await AuthorizationUsersUseridRolesGetAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of roles for a user. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> AuthorizationUsersUseridRolesGetAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->AuthorizationUsersUseridRolesGet");

            var localVarPath = "/api/v1/authorization/users/{userId}/roles";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationUsersUseridRolesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationUsersUseridRolesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthorization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAuthorization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthorization)));
            
        }

        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> AuthorizationUsersUseridRolesPut (string userId, List<string> body = null)
        {
             ApiResponse<List<string>> localVarResponse = AuthorizationUsersUseridRolesPutWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > AuthorizationUsersUseridRolesPutWithHttpInfo (string userId, List<string> body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->AuthorizationUsersUseridRolesPut");

            var localVarPath = "/api/v1/authorization/users/{userId}/roles";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationUsersUseridRolesPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationUsersUseridRolesPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> AuthorizationUsersUseridRolesPutAsync (string userId, List<string> body = null)
        {
             ApiResponse<List<string>> localVarResponse = await AuthorizationUsersUseridRolesPutAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> AuthorizationUsersUseridRolesPutAsyncWithHttpInfo (string userId, List<string> body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AuthorizationApi->AuthorizationUsersUseridRolesPut");

            var localVarPath = "/api/v1/authorization/users/{userId}/roles";
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
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationUsersUseridRolesPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthorizationUsersUseridRolesPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

    }
}
