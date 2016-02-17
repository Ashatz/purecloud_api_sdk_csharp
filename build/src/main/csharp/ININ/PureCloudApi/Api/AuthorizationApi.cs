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
    public interface IAuthorizationApi
    {
        
        /// <summary>
        /// Retrieve a list of all licenses defined in the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>DomainLicenseEntityListing</returns>
        DomainLicenseEntityListing GetLicenses (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Retrieve a list of all licenses defined in the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of DomainLicenseEntityListing</returns>
        ApiResponse<DomainLicenseEntityListing> GetLicensesWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Retrieve a list of all licenses defined in the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainLicenseEntityListing</returns>
        System.Threading.Tasks.Task<DomainLicenseEntityListing> GetLicensesAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Retrieve a list of all licenses defined in the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainLicenseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLicenseEntityListing>> GetLicensesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>PermissionCollectionEntityListing</returns>
        PermissionCollectionEntityListing GetPermissions (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of PermissionCollectionEntityListing</returns>
        ApiResponse<PermissionCollectionEntityListing> GetPermissionsWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of PermissionCollectionEntityListing</returns>
        System.Threading.Tasks.Task<PermissionCollectionEntityListing> GetPermissionsAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all permissions.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permission defined in the system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (PermissionCollectionEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PermissionCollectionEntityListing>> GetPermissionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <returns>OrganizationProductEntityListing</returns>
        OrganizationProductEntityListing GetProducts ();
  
        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <returns>ApiResponse of OrganizationProductEntityListing</returns>
        ApiResponse<OrganizationProductEntityListing> GetProductsWithHttpInfo ();

        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <returns>Task of OrganizationProductEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationProductEntityListing> GetProductsAsync ();

        /// <summary>
        /// Get the list of enabled products
        /// </summary>
        /// <remarks>
        /// Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </remarks>
        /// <returns>Task of ApiResponse (OrganizationProductEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationProductEntityListing>> GetProductsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Retrieve a list of all roles defined for the organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="permission"></param>
        /// <param name="userCount"></param>
        /// <returns>OrganizationRoleEntityListing</returns>
        OrganizationRoleEntityListing GetRoles (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null);
  
        /// <summary>
        /// Retrieve a list of all roles defined for the organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="permission"></param>
        /// <param name="userCount"></param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        ApiResponse<OrganizationRoleEntityListing> GetRolesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null);

        /// <summary>
        /// Retrieve a list of all roles defined for the organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="permission"></param>
        /// <param name="userCount"></param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationRoleEntityListing> GetRolesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null);

        /// <summary>
        /// Retrieve a list of all roles defined for the organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="permission"></param>
        /// <param name="userCount"></param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> GetRolesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null);
        
        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole CreateRoles (DomainOrganizationRole body = null);
  
        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> CreateRolesWithHttpInfo (DomainOrganizationRole body = null);

        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> CreateRolesAsync (DomainOrganizationRole body = null);

        /// <summary>
        /// Create an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> CreateRolesAsyncWithHttpInfo (DomainOrganizationRole body = null);
        
        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>OrganizationRoleEntityListing</returns>
        OrganizationRoleEntityListing UpdateRolesDefault (List<DomainOrganizationRole> body = null);
  
        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        ApiResponse<OrganizationRoleEntityListing> UpdateRolesDefaultWithHttpInfo (List<DomainOrganizationRole> body = null);

        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationRoleEntityListing> UpdateRolesDefaultAsync (List<DomainOrganizationRole> body = null);

        /// <summary>
        /// Restore specified default roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> UpdateRolesDefaultAsyncWithHttpInfo (List<DomainOrganizationRole> body = null);
        
        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <param name="force">Restore default roles</param>
        /// <returns>OrganizationRoleEntityListing</returns>
        OrganizationRoleEntityListing CreateRolesDefault (bool? force = null);
  
        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <param name="force">Restore default roles</param>
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        ApiResponse<OrganizationRoleEntityListing> CreateRolesDefaultWithHttpInfo (bool? force = null);

        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <param name="force">Restore default roles</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        System.Threading.Tasks.Task<OrganizationRoleEntityListing> CreateRolesDefaultAsync (bool? force = null);

        /// <summary>
        /// Restores all default roles
        /// </summary>
        /// <remarks>
        /// This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </remarks>
        /// <param name="force">Restore default roles</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> CreateRolesDefaultAsyncWithHttpInfo (bool? force = null);
        
        /// <summary>
        /// Get an org role to default role comparison comparison
        /// </summary>
        /// <remarks>
        /// Compares any organization role to a default role id and show differences
        /// </remarks>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>DomainOrgRoleDifference</returns>
        DomainOrgRoleDifference GetRolesLeftRoleComparedefaultByRightRoleId (string leftRoleId, string rightRoleId);
  
        /// <summary>
        /// Get an org role to default role comparison comparison
        /// </summary>
        /// <remarks>
        /// Compares any organization role to a default role id and show differences
        /// </remarks>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>ApiResponse of DomainOrgRoleDifference</returns>
        ApiResponse<DomainOrgRoleDifference> GetRolesLeftRoleComparedefaultByRightRoleIdWithHttpInfo (string leftRoleId, string rightRoleId);

        /// <summary>
        /// Get an org role to default role comparison comparison
        /// </summary>
        /// <remarks>
        /// Compares any organization role to a default role id and show differences
        /// </remarks>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>Task of DomainOrgRoleDifference</returns>
        System.Threading.Tasks.Task<DomainOrgRoleDifference> GetRolesLeftRoleComparedefaultByRightRoleIdAsync (string leftRoleId, string rightRoleId);

        /// <summary>
        /// Get an org role to default role comparison comparison
        /// </summary>
        /// <remarks>
        /// Compares any organization role to a default role id and show differences
        /// </remarks>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>Task of ApiResponse (DomainOrgRoleDifference)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> GetRolesLeftRoleComparedefaultByRightRoleIdAsyncWithHttpInfo (string leftRoleId, string rightRoleId);
        
        /// <summary>
        /// Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body"></param>
        /// <returns>DomainOrgRoleDifference</returns>
        DomainOrgRoleDifference CreateRolesLeftRoleComparedefaultByRightRoleId (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null);
  
        /// <summary>
        /// Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainOrgRoleDifference</returns>
        ApiResponse<DomainOrgRoleDifference> CreateRolesLeftRoleComparedefaultByRightRoleIdWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null);

        /// <summary>
        /// Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainOrgRoleDifference</returns>
        System.Threading.Tasks.Task<DomainOrgRoleDifference> CreateRolesLeftRoleComparedefaultByRightRoleIdAsync (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null);

        /// <summary>
        /// Get an unsaved org role to default role comparison
        /// </summary>
        /// <remarks>
        /// Allows users to compare their existing roles in an unsaved state to its default role
        /// </remarks>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainOrgRoleDifference)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> CreateRolesLeftRoleComparedefaultByRightRoleIdAsyncWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null);
        
        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole GetRole (string roleId);
  
        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> GetRoleWithHttpInfo (string roleId);

        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> GetRoleAsync (string roleId);

        /// <summary>
        /// Get a single organization role.
        /// </summary>
        /// <remarks>
        /// Get the organization role specified by its ID.
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> GetRoleAsyncWithHttpInfo (string roleId);
        
        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole UpdateRole (string roleId, DomainOrganizationRole body = null);
  
        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> UpdateRoleWithHttpInfo (string roleId, DomainOrganizationRole body = null);

        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> UpdateRoleAsync (string roleId, DomainOrganizationRole body = null);

        /// <summary>
        /// Update an organization role.
        /// </summary>
        /// <remarks>
        /// Update
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> UpdateRoleAsyncWithHttpInfo (string roleId, DomainOrganizationRole body = null);
        
        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <returns></returns>
        void DeleteRole (string roleId);
  
        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteRoleWithHttpInfo (string roleId);

        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteRoleAsync (string roleId);

        /// <summary>
        /// Delete an organization role.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRoleAsyncWithHttpInfo (string roleId);
        
        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>DomainOrganizationRole</returns>
        DomainOrganizationRole PatchRole (string roleId, DomainOrganizationRole body = null);
  
        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        ApiResponse<DomainOrganizationRole> PatchRoleWithHttpInfo (string roleId, DomainOrganizationRole body = null);

        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainOrganizationRole</returns>
        System.Threading.Tasks.Task<DomainOrganizationRole> PatchRoleAsync (string roleId, DomainOrganizationRole body = null);

        /// <summary>
        /// Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <remarks>
        /// Patch Organization Role for needsUpdate Field
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> PatchRoleAsyncWithHttpInfo (string roleId, DomainOrganizationRole body = null);
        
        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> UpdateRoleUsersAdd (string roleId, List<string> body = null);
  
        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> UpdateRoleUsersAddWithHttpInfo (string roleId, List<string> body = null);

        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> UpdateRoleUsersAddAsync (string roleId, List<string> body = null);

        /// <summary>
        /// Sets the users for the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> UpdateRoleUsersAddAsyncWithHttpInfo (string roleId, List<string> body = null);
        
        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> UpdateRoleUsersRemove (string roleId, List<string> body = null);
  
        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> UpdateRoleUsersRemoveWithHttpInfo (string roleId, List<string> body = null);

        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> UpdateRoleUsersRemoveAsync (string roleId, List<string> body = null);

        /// <summary>
        /// Removes the users from the role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> UpdateRoleUsersRemoveAsyncWithHttpInfo (string roleId, List<string> body = null);
        
        /// <summary>
        /// Get the list of roles for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>UserAuthorization</returns>
        UserAuthorization GetUserRoles (string userId);
  
        /// <summary>
        /// Get the list of roles for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserAuthorization</returns>
        ApiResponse<UserAuthorization> GetUserRolesWithHttpInfo (string userId);

        /// <summary>
        /// Get the list of roles for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserAuthorization</returns>
        System.Threading.Tasks.Task<UserAuthorization> GetUserRolesAsync (string userId);

        /// <summary>
        /// Get the list of roles for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> GetUserRolesAsyncWithHttpInfo (string userId);
        
        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> UpdateUserRoles (string userId, List<string> body = null);
  
        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> UpdateUserRolesWithHttpInfo (string userId, List<string> body = null);

        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> UpdateUserRolesAsync (string userId, List<string> body = null);

        /// <summary>
        /// Sets the user&#39;s roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> UpdateUserRolesAsyncWithHttpInfo (string userId, List<string> body = null);
        
        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns></returns>
        void DeleteUserRoles (string userId);
  
        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteUserRolesWithHttpInfo (string userId);

        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteUserRolesAsync (string userId);

        /// <summary>
        /// Removes all the roles from the user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserRolesAsyncWithHttpInfo (string userId);
        
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
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>DomainLicenseEntityListing</returns>
        public DomainLicenseEntityListing GetLicenses (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainLicenseEntityListing> response = GetLicensesWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Retrieve a list of all licenses defined in the system 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainLicenseEntityListing</returns>
        public ApiResponse< DomainLicenseEntityListing > GetLicensesWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/authorization/licenses";
    
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
                throw new ApiException (statusCode, "Error calling GetLicenses: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetLicenses: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainLicenseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLicenseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainLicenseEntityListing)));
            
        }
    
        /// <summary>
        /// Retrieve a list of all licenses defined in the system 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainLicenseEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainLicenseEntityListing> GetLicensesAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainLicenseEntityListing> response = await GetLicensesAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Retrieve a list of all licenses defined in the system 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainLicenseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLicenseEntityListing>> GetLicensesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/authorization/licenses";
    
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
                throw new ApiException (statusCode, "Error calling GetLicenses: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetLicenses: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainLicenseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLicenseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainLicenseEntityListing)));
            
        }
        
        /// <summary>
        /// Get all permissions. Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>PermissionCollectionEntityListing</returns>
        public PermissionCollectionEntityListing GetPermissions (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PermissionCollectionEntityListing> response = GetPermissionsWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get all permissions. Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of PermissionCollectionEntityListing</returns>
        public ApiResponse< PermissionCollectionEntityListing > GetPermissionsWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/authorization/permissions";
    
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
                throw new ApiException (statusCode, "Error calling GetPermissions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPermissions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PermissionCollectionEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PermissionCollectionEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PermissionCollectionEntityListing)));
            
        }
    
        /// <summary>
        /// Get all permissions. Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of PermissionCollectionEntityListing</returns>
        public async System.Threading.Tasks.Task<PermissionCollectionEntityListing> GetPermissionsAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PermissionCollectionEntityListing> response = await GetPermissionsAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get all permissions. Retrieve a list of all permission defined in the system.
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (PermissionCollectionEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PermissionCollectionEntityListing>> GetPermissionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/authorization/permissions";
    
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
                throw new ApiException (statusCode, "Error calling GetPermissions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPermissions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PermissionCollectionEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PermissionCollectionEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PermissionCollectionEntityListing)));
            
        }
        
        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <returns>OrganizationProductEntityListing</returns>
        public OrganizationProductEntityListing GetProducts ()
        {
             ApiResponse<OrganizationProductEntityListing> response = GetProductsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <returns>ApiResponse of OrganizationProductEntityListing</returns>
        public ApiResponse< OrganizationProductEntityListing > GetProductsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/authorization/products";
    
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
                throw new ApiException (statusCode, "Error calling GetProducts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProducts: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrganizationProductEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationProductEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OrganizationProductEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <returns>Task of OrganizationProductEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationProductEntityListing> GetProductsAsync ()
        {
             ApiResponse<OrganizationProductEntityListing> response = await GetProductsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get the list of enabled products Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.
        /// </summary>
        /// <returns>Task of ApiResponse (OrganizationProductEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationProductEntityListing>> GetProductsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/authorization/products";
    
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
                throw new ApiException (statusCode, "Error calling GetProducts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProducts: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrganizationProductEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationProductEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OrganizationProductEntityListing)));
            
        }
        
        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="permission"></param> 
        /// <param name="userCount"></param> 
        /// <returns>OrganizationRoleEntityListing</returns>
        public OrganizationRoleEntityListing GetRoles (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null)
        {
             ApiResponse<OrganizationRoleEntityListing> response = GetRolesWithHttpInfo(pageSize, pageNumber, sortBy, expand, permission, userCount);
             return response.Data;
        }

        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="permission"></param> 
        /// <param name="userCount"></param> 
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        public ApiResponse< OrganizationRoleEntityListing > GetRolesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null)
        {
            
    
            var path_ = "/api/v1/authorization/roles";
    
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
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (permission != null) queryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            if (userCount != null) queryParams.Add("userCount", Configuration.ApiClient.ParameterToString(userCount)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetRoles: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrganizationRoleEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OrganizationRoleEntityListing)));
            
        }
    
        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="permission"></param>
        /// <param name="userCount"></param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationRoleEntityListing> GetRolesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null)
        {
             ApiResponse<OrganizationRoleEntityListing> response = await GetRolesAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, permission, userCount);
             return response.Data;

        }

        /// <summary>
        /// Retrieve a list of all roles defined for the organization 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="permission"></param>
        /// <param name="userCount"></param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> GetRolesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null)
        {
            
    
            var path_ = "/api/v1/authorization/roles";
    
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
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (permission != null) queryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            if (userCount != null) queryParams.Add("userCount", Configuration.ApiClient.ParameterToString(userCount)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetRoles: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRoles: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OrganizationRoleEntityListing)));
            
        }
        
        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole CreateRoles (DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrganizationRole> response = CreateRolesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > CreateRolesWithHttpInfo (DomainOrganizationRole body = null)
        {
            
    
            var path_ = "/api/v1/authorization/roles";
    
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
                throw new ApiException (statusCode, "Error calling CreateRoles: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainOrganizationRole>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(response, typeof(DomainOrganizationRole)));
            
        }
    
        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of DomainOrganizationRole</returns>
        public async System.Threading.Tasks.Task<DomainOrganizationRole> CreateRolesAsync (DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrganizationRole> response = await CreateRolesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an organization role. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> CreateRolesAsyncWithHttpInfo (DomainOrganizationRole body = null)
        {
            
    
            var path_ = "/api/v1/authorization/roles";
    
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
                throw new ApiException (statusCode, "Error calling CreateRoles: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRoles: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(response, typeof(DomainOrganizationRole)));
            
        }
        
        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>OrganizationRoleEntityListing</returns>
        public OrganizationRoleEntityListing UpdateRolesDefault (List<DomainOrganizationRole> body = null)
        {
             ApiResponse<OrganizationRoleEntityListing> response = UpdateRolesDefaultWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        public ApiResponse< OrganizationRoleEntityListing > UpdateRolesDefaultWithHttpInfo (List<DomainOrganizationRole> body = null)
        {
            
    
            var path_ = "/api/v1/authorization/roles/default";
    
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
                throw new ApiException (statusCode, "Error calling UpdateRolesDefault: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRolesDefault: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrganizationRoleEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OrganizationRoleEntityListing)));
            
        }
    
        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationRoleEntityListing> UpdateRolesDefaultAsync (List<DomainOrganizationRole> body = null)
        {
             ApiResponse<OrganizationRoleEntityListing> response = await UpdateRolesDefaultAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Restore specified default roles 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> UpdateRolesDefaultAsyncWithHttpInfo (List<DomainOrganizationRole> body = null)
        {
            
    
            var path_ = "/api/v1/authorization/roles/default";
    
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
                throw new ApiException (statusCode, "Error calling UpdateRolesDefault: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRolesDefault: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OrganizationRoleEntityListing)));
            
        }
        
        /// <summary>
        /// Restores all default roles This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <param name="force">Restore default roles</param> 
        /// <returns>OrganizationRoleEntityListing</returns>
        public OrganizationRoleEntityListing CreateRolesDefault (bool? force = null)
        {
             ApiResponse<OrganizationRoleEntityListing> response = CreateRolesDefaultWithHttpInfo(force);
             return response.Data;
        }

        /// <summary>
        /// Restores all default roles This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <param name="force">Restore default roles</param> 
        /// <returns>ApiResponse of OrganizationRoleEntityListing</returns>
        public ApiResponse< OrganizationRoleEntityListing > CreateRolesDefaultWithHttpInfo (bool? force = null)
        {
            
    
            var path_ = "/api/v1/authorization/roles/default";
    
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
            
            if (force != null) queryParams.Add("force", Configuration.ApiClient.ParameterToString(force)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CreateRolesDefault: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRolesDefault: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrganizationRoleEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OrganizationRoleEntityListing)));
            
        }
    
        /// <summary>
        /// Restores all default roles This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <param name="force">Restore default roles</param>
        /// <returns>Task of OrganizationRoleEntityListing</returns>
        public async System.Threading.Tasks.Task<OrganizationRoleEntityListing> CreateRolesDefaultAsync (bool? force = null)
        {
             ApiResponse<OrganizationRoleEntityListing> response = await CreateRolesDefaultAsyncWithHttpInfo(force);
             return response.Data;

        }

        /// <summary>
        /// Restores all default roles This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.
        /// </summary>
        /// <param name="force">Restore default roles</param>
        /// <returns>Task of ApiResponse (OrganizationRoleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationRoleEntityListing>> CreateRolesDefaultAsyncWithHttpInfo (bool? force = null)
        {
            
    
            var path_ = "/api/v1/authorization/roles/default";
    
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
            
            if (force != null) queryParams.Add("force", Configuration.ApiClient.ParameterToString(force)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CreateRolesDefault: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRolesDefault: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrganizationRoleEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationRoleEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OrganizationRoleEntityListing)));
            
        }
        
        /// <summary>
        /// Get an org role to default role comparison comparison Compares any organization role to a default role id and show differences
        /// </summary>
        /// <param name="leftRoleId">Left Role ID</param> 
        /// <param name="rightRoleId">Right Role id</param> 
        /// <returns>DomainOrgRoleDifference</returns>
        public DomainOrgRoleDifference GetRolesLeftRoleComparedefaultByRightRoleId (string leftRoleId, string rightRoleId)
        {
             ApiResponse<DomainOrgRoleDifference> response = GetRolesLeftRoleComparedefaultByRightRoleIdWithHttpInfo(leftRoleId, rightRoleId);
             return response.Data;
        }

        /// <summary>
        /// Get an org role to default role comparison comparison Compares any organization role to a default role id and show differences
        /// </summary>
        /// <param name="leftRoleId">Left Role ID</param> 
        /// <param name="rightRoleId">Right Role id</param> 
        /// <returns>ApiResponse of DomainOrgRoleDifference</returns>
        public ApiResponse< DomainOrgRoleDifference > GetRolesLeftRoleComparedefaultByRightRoleIdWithHttpInfo (string leftRoleId, string rightRoleId)
        {
            
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null) throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling GetRolesLeftRoleComparedefaultByRightRoleId");
            
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null) throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling GetRolesLeftRoleComparedefaultByRightRoleId");
            
    
            var path_ = "/api/v1/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
    
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
            if (leftRoleId != null) pathParams.Add("leftRoleId", Configuration.ApiClient.ParameterToString(leftRoleId)); // path parameter
            if (rightRoleId != null) pathParams.Add("rightRoleId", Configuration.ApiClient.ParameterToString(rightRoleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetRolesLeftRoleComparedefaultByRightRoleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRolesLeftRoleComparedefaultByRightRoleId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainOrgRoleDifference>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrgRoleDifference) Configuration.ApiClient.Deserialize(response, typeof(DomainOrgRoleDifference)));
            
        }
    
        /// <summary>
        /// Get an org role to default role comparison comparison Compares any organization role to a default role id and show differences
        /// </summary>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>Task of DomainOrgRoleDifference</returns>
        public async System.Threading.Tasks.Task<DomainOrgRoleDifference> GetRolesLeftRoleComparedefaultByRightRoleIdAsync (string leftRoleId, string rightRoleId)
        {
             ApiResponse<DomainOrgRoleDifference> response = await GetRolesLeftRoleComparedefaultByRightRoleIdAsyncWithHttpInfo(leftRoleId, rightRoleId);
             return response.Data;

        }

        /// <summary>
        /// Get an org role to default role comparison comparison Compares any organization role to a default role id and show differences
        /// </summary>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <returns>Task of ApiResponse (DomainOrgRoleDifference)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> GetRolesLeftRoleComparedefaultByRightRoleIdAsyncWithHttpInfo (string leftRoleId, string rightRoleId)
        {
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null) throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling GetRolesLeftRoleComparedefaultByRightRoleId");
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null) throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling GetRolesLeftRoleComparedefaultByRightRoleId");
            
    
            var path_ = "/api/v1/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
    
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
            if (leftRoleId != null) pathParams.Add("leftRoleId", Configuration.ApiClient.ParameterToString(leftRoleId)); // path parameter
            if (rightRoleId != null) pathParams.Add("rightRoleId", Configuration.ApiClient.ParameterToString(rightRoleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetRolesLeftRoleComparedefaultByRightRoleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRolesLeftRoleComparedefaultByRightRoleId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrgRoleDifference) Configuration.ApiClient.Deserialize(response, typeof(DomainOrgRoleDifference)));
            
        }
        
        /// <summary>
        /// Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <param name="leftRoleId">Left Role ID</param> 
        /// <param name="rightRoleId">Right Role id</param> 
        /// <param name="body"></param> 
        /// <returns>DomainOrgRoleDifference</returns>
        public DomainOrgRoleDifference CreateRolesLeftRoleComparedefaultByRightRoleId (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrgRoleDifference> response = CreateRolesLeftRoleComparedefaultByRightRoleIdWithHttpInfo(leftRoleId, rightRoleId, body);
             return response.Data;
        }

        /// <summary>
        /// Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <param name="leftRoleId">Left Role ID</param> 
        /// <param name="rightRoleId">Right Role id</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainOrgRoleDifference</returns>
        public ApiResponse< DomainOrgRoleDifference > CreateRolesLeftRoleComparedefaultByRightRoleIdWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null)
        {
            
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null) throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling CreateRolesLeftRoleComparedefaultByRightRoleId");
            
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null) throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling CreateRolesLeftRoleComparedefaultByRightRoleId");
            
    
            var path_ = "/api/v1/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
    
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
            if (leftRoleId != null) pathParams.Add("leftRoleId", Configuration.ApiClient.ParameterToString(leftRoleId)); // path parameter
            if (rightRoleId != null) pathParams.Add("rightRoleId", Configuration.ApiClient.ParameterToString(rightRoleId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CreateRolesLeftRoleComparedefaultByRightRoleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRolesLeftRoleComparedefaultByRightRoleId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainOrgRoleDifference>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrgRoleDifference) Configuration.ApiClient.Deserialize(response, typeof(DomainOrgRoleDifference)));
            
        }
    
        /// <summary>
        /// Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainOrgRoleDifference</returns>
        public async System.Threading.Tasks.Task<DomainOrgRoleDifference> CreateRolesLeftRoleComparedefaultByRightRoleIdAsync (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrgRoleDifference> response = await CreateRolesLeftRoleComparedefaultByRightRoleIdAsyncWithHttpInfo(leftRoleId, rightRoleId, body);
             return response.Data;

        }

        /// <summary>
        /// Get an unsaved org role to default role comparison Allows users to compare their existing roles in an unsaved state to its default role
        /// </summary>
        /// <param name="leftRoleId">Left Role ID</param>
        /// <param name="rightRoleId">Right Role id</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainOrgRoleDifference)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrgRoleDifference>> CreateRolesLeftRoleComparedefaultByRightRoleIdAsyncWithHttpInfo (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null)
        {
            // verify the required parameter 'leftRoleId' is set
            if (leftRoleId == null) throw new ApiException(400, "Missing required parameter 'leftRoleId' when calling CreateRolesLeftRoleComparedefaultByRightRoleId");
            // verify the required parameter 'rightRoleId' is set
            if (rightRoleId == null) throw new ApiException(400, "Missing required parameter 'rightRoleId' when calling CreateRolesLeftRoleComparedefaultByRightRoleId");
            
    
            var path_ = "/api/v1/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId}";
    
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
            if (leftRoleId != null) pathParams.Add("leftRoleId", Configuration.ApiClient.ParameterToString(leftRoleId)); // path parameter
            if (rightRoleId != null) pathParams.Add("rightRoleId", Configuration.ApiClient.ParameterToString(rightRoleId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CreateRolesLeftRoleComparedefaultByRightRoleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRolesLeftRoleComparedefaultByRightRoleId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainOrgRoleDifference>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrgRoleDifference) Configuration.ApiClient.Deserialize(response, typeof(DomainOrgRoleDifference)));
            
        }
        
        /// <summary>
        /// Get a single organization role. Get the organization role specified by its ID.
        /// </summary>
        /// <param name="roleId">Role ID</param> 
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole GetRole (string roleId)
        {
             ApiResponse<DomainOrganizationRole> response = GetRoleWithHttpInfo(roleId);
             return response.Data;
        }

        /// <summary>
        /// Get a single organization role. Get the organization role specified by its ID.
        /// </summary>
        /// <param name="roleId">Role ID</param> 
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > GetRoleWithHttpInfo (string roleId)
        {
            
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling GetRole");
            
    
            var path_ = "/api/v1/authorization/roles/{roleId}";
    
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
            if (roleId != null) pathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetRole: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRole: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainOrganizationRole>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(response, typeof(DomainOrganizationRole)));
            
        }
    
        /// <summary>
        /// Get a single organization role. Get the organization role specified by its ID.
        /// </summary>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of DomainOrganizationRole</returns>
        public async System.Threading.Tasks.Task<DomainOrganizationRole> GetRoleAsync (string roleId)
        {
             ApiResponse<DomainOrganizationRole> response = await GetRoleAsyncWithHttpInfo(roleId);
             return response.Data;

        }

        /// <summary>
        /// Get a single organization role. Get the organization role specified by its ID.
        /// </summary>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> GetRoleAsyncWithHttpInfo (string roleId)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling GetRole");
            
    
            var path_ = "/api/v1/authorization/roles/{roleId}";
    
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
            if (roleId != null) pathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetRole: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRole: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(response, typeof(DomainOrganizationRole)));
            
        }
        
        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <param name="roleId">Role ID</param> 
        /// <param name="body"></param> 
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole UpdateRole (string roleId, DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrganizationRole> response = UpdateRoleWithHttpInfo(roleId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <param name="roleId">Role ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > UpdateRoleWithHttpInfo (string roleId, DomainOrganizationRole body = null)
        {
            
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling UpdateRole");
            
    
            var path_ = "/api/v1/authorization/roles/{roleId}";
    
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
            if (roleId != null) pathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateRole: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRole: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainOrganizationRole>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(response, typeof(DomainOrganizationRole)));
            
        }
    
        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainOrganizationRole</returns>
        public async System.Threading.Tasks.Task<DomainOrganizationRole> UpdateRoleAsync (string roleId, DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrganizationRole> response = await UpdateRoleAsyncWithHttpInfo(roleId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an organization role. Update
        /// </summary>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> UpdateRoleAsyncWithHttpInfo (string roleId, DomainOrganizationRole body = null)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling UpdateRole");
            
    
            var path_ = "/api/v1/authorization/roles/{roleId}";
    
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
            if (roleId != null) pathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateRole: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRole: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(response, typeof(DomainOrganizationRole)));
            
        }
        
        /// <summary>
        /// Delete an organization role. 
        /// </summary>
        /// <param name="roleId">Role ID</param> 
        /// <returns></returns>
        public void DeleteRole (string roleId)
        {
             DeleteRoleWithHttpInfo(roleId);
        }

        /// <summary>
        /// Delete an organization role. 
        /// </summary>
        /// <param name="roleId">Role ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteRoleWithHttpInfo (string roleId)
        {
            
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling DeleteRole");
            
    
            var path_ = "/api/v1/authorization/roles/{roleId}";
    
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
            if (roleId != null) pathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteRole: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRole: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an organization role. 
        /// </summary>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteRoleAsync (string roleId)
        {
             await DeleteRoleAsyncWithHttpInfo(roleId);

        }

        /// <summary>
        /// Delete an organization role. 
        /// </summary>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRoleAsyncWithHttpInfo (string roleId)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling DeleteRole");
            
    
            var path_ = "/api/v1/authorization/roles/{roleId}";
    
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
            if (roleId != null) pathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteRole: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRole: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <param name="roleId">Role ID</param> 
        /// <param name="body"></param> 
        /// <returns>DomainOrganizationRole</returns>
        public DomainOrganizationRole PatchRole (string roleId, DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrganizationRole> response = PatchRoleWithHttpInfo(roleId, body);
             return response.Data;
        }

        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <param name="roleId">Role ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainOrganizationRole</returns>
        public ApiResponse< DomainOrganizationRole > PatchRoleWithHttpInfo (string roleId, DomainOrganizationRole body = null)
        {
            
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling PatchRole");
            
    
            var path_ = "/api/v1/authorization/roles/{roleId}";
    
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
            if (roleId != null) pathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchRole: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchRole: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainOrganizationRole>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(response, typeof(DomainOrganizationRole)));
            
        }
    
        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainOrganizationRole</returns>
        public async System.Threading.Tasks.Task<DomainOrganizationRole> PatchRoleAsync (string roleId, DomainOrganizationRole body = null)
        {
             ApiResponse<DomainOrganizationRole> response = await PatchRoleAsyncWithHttpInfo(roleId, body);
             return response.Data;

        }

        /// <summary>
        /// Patch Organization Role for needsUpdate Field Patch Organization Role for needsUpdate Field
        /// </summary>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainOrganizationRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainOrganizationRole>> PatchRoleAsyncWithHttpInfo (string roleId, DomainOrganizationRole body = null)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling PatchRole");
            
    
            var path_ = "/api/v1/authorization/roles/{roleId}";
    
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
            if (roleId != null) pathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchRole: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchRole: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainOrganizationRole>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainOrganizationRole) Configuration.ApiClient.Deserialize(response, typeof(DomainOrganizationRole)));
            
        }
        
        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <param name="roleId">Role ID</param> 
        /// <param name="body"></param> 
        /// <returns>List&lt;string&gt;</returns>
        public List<string> UpdateRoleUsersAdd (string roleId, List<string> body = null)
        {
             ApiResponse<List<string>> response = UpdateRoleUsersAddWithHttpInfo(roleId, body);
             return response.Data;
        }

        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <param name="roleId">Role ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > UpdateRoleUsersAddWithHttpInfo (string roleId, List<string> body = null)
        {
            
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling UpdateRoleUsersAdd");
            
    
            var path_ = "/api/v1/authorization/roles/{roleId}/users/add";
    
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
            if (roleId != null) pathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateRoleUsersAdd: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRoleUsersAdd: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
    
        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> UpdateRoleUsersAddAsync (string roleId, List<string> body = null)
        {
             ApiResponse<List<string>> response = await UpdateRoleUsersAddAsyncWithHttpInfo(roleId, body);
             return response.Data;

        }

        /// <summary>
        /// Sets the users for the role 
        /// </summary>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> UpdateRoleUsersAddAsyncWithHttpInfo (string roleId, List<string> body = null)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling UpdateRoleUsersAdd");
            
    
            var path_ = "/api/v1/authorization/roles/{roleId}/users/add";
    
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
            if (roleId != null) pathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateRoleUsersAdd: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRoleUsersAdd: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
        
        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <param name="roleId">Role ID</param> 
        /// <param name="body"></param> 
        /// <returns>List&lt;string&gt;</returns>
        public List<string> UpdateRoleUsersRemove (string roleId, List<string> body = null)
        {
             ApiResponse<List<string>> response = UpdateRoleUsersRemoveWithHttpInfo(roleId, body);
             return response.Data;
        }

        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <param name="roleId">Role ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > UpdateRoleUsersRemoveWithHttpInfo (string roleId, List<string> body = null)
        {
            
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling UpdateRoleUsersRemove");
            
    
            var path_ = "/api/v1/authorization/roles/{roleId}/users/remove";
    
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
            if (roleId != null) pathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateRoleUsersRemove: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRoleUsersRemove: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
    
        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> UpdateRoleUsersRemoveAsync (string roleId, List<string> body = null)
        {
             ApiResponse<List<string>> response = await UpdateRoleUsersRemoveAsyncWithHttpInfo(roleId, body);
             return response.Data;

        }

        /// <summary>
        /// Removes the users from the role 
        /// </summary>
        /// <param name="roleId">Role ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> UpdateRoleUsersRemoveAsyncWithHttpInfo (string roleId, List<string> body = null)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling UpdateRoleUsersRemove");
            
    
            var path_ = "/api/v1/authorization/roles/{roleId}/users/remove";
    
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
            if (roleId != null) pathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateRoleUsersRemove: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRoleUsersRemove: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
        
        /// <summary>
        /// Get the list of roles for a user. 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>UserAuthorization</returns>
        public UserAuthorization GetUserRoles (string userId)
        {
             ApiResponse<UserAuthorization> response = GetUserRolesWithHttpInfo(userId);
             return response.Data;
        }

        /// <summary>
        /// Get the list of roles for a user. 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>ApiResponse of UserAuthorization</returns>
        public ApiResponse< UserAuthorization > GetUserRolesWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserRoles");
            
    
            var path_ = "/api/v1/authorization/users/{userId}/roles";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetUserRoles: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserAuthorization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAuthorization) Configuration.ApiClient.Deserialize(response, typeof(UserAuthorization)));
            
        }
    
        /// <summary>
        /// Get the list of roles for a user. 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserAuthorization</returns>
        public async System.Threading.Tasks.Task<UserAuthorization> GetUserRolesAsync (string userId)
        {
             ApiResponse<UserAuthorization> response = await GetUserRolesAsyncWithHttpInfo(userId);
             return response.Data;

        }

        /// <summary>
        /// Get the list of roles for a user. 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserAuthorization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserAuthorization>> GetUserRolesAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserRoles");
            
    
            var path_ = "/api/v1/authorization/users/{userId}/roles";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetUserRoles: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserRoles: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserAuthorization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAuthorization) Configuration.ApiClient.Deserialize(response, typeof(UserAuthorization)));
            
        }
        
        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body"></param> 
        /// <returns>List&lt;string&gt;</returns>
        public List<string> UpdateUserRoles (string userId, List<string> body = null)
        {
             ApiResponse<List<string>> response = UpdateUserRolesWithHttpInfo(userId, body);
             return response.Data;
        }

        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > UpdateUserRolesWithHttpInfo (string userId, List<string> body = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateUserRoles");
            
    
            var path_ = "/api/v1/authorization/users/{userId}/roles";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateUserRoles: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateUserRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
    
        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> UpdateUserRolesAsync (string userId, List<string> body = null)
        {
             ApiResponse<List<string>> response = await UpdateUserRolesAsyncWithHttpInfo(userId, body);
             return response.Data;

        }

        /// <summary>
        /// Sets the user&#39;s roles 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> UpdateUserRolesAsyncWithHttpInfo (string userId, List<string> body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateUserRoles");
            
    
            var path_ = "/api/v1/authorization/users/{userId}/roles";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateUserRoles: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateUserRoles: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
        
        /// <summary>
        /// Removes all the roles from the user. 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns></returns>
        public void DeleteUserRoles (string userId)
        {
             DeleteUserRolesWithHttpInfo(userId);
        }

        /// <summary>
        /// Removes all the roles from the user. 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteUserRolesWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling DeleteUserRoles");
            
    
            var path_ = "/api/v1/authorization/users/{userId}/roles";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteUserRoles: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteUserRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Removes all the roles from the user. 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteUserRolesAsync (string userId)
        {
             await DeleteUserRolesAsyncWithHttpInfo(userId);

        }

        /// <summary>
        /// Removes all the roles from the user. 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserRolesAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling DeleteUserRoles");
            
    
            var path_ = "/api/v1/authorization/users/{userId}/roles";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteUserRoles: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteUserRoles: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
