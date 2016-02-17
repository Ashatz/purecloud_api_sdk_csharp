using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Model;

namespace ININ.PureCloudApi.Test
{
    [TestFixture]
    public class AuthorizationApiTests
    {
        private AuthorizationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new AuthorizationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuthorizationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<AuthorizationApi> (instance, "instance is a AuthorizationApi");
        }

        
        /// <summary>
        /// Test GetLicenses
        /// </summary>
        [Test]
        public void GetLicensesTest()
        {
            // TODO: add unit test for the method 'GetLicenses'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetLicenses(pageSize, pageNumber);
            Assert.IsInstanceOf<DomainLicenseEntityListing> (response, "response is DomainLicenseEntityListing"); 
        }
        
        /// <summary>
        /// Test GetPermissions
        /// </summary>
        [Test]
        public void GetPermissionsTest()
        {
            // TODO: add unit test for the method 'GetPermissions'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetPermissions(pageSize, pageNumber);
            Assert.IsInstanceOf<PermissionCollectionEntityListing> (response, "response is PermissionCollectionEntityListing"); 
        }
        
        /// <summary>
        /// Test GetProducts
        /// </summary>
        [Test]
        public void GetProductsTest()
        {
            // TODO: add unit test for the method 'GetProducts'
            
            var response = instance.GetProducts();
            Assert.IsInstanceOf<OrganizationProductEntityListing> (response, "response is OrganizationProductEntityListing"); 
        }
        
        /// <summary>
        /// Test GetRoles
        /// </summary>
        [Test]
        public void GetRolesTest()
        {
            // TODO: add unit test for the method 'GetRoles'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            List<string> permission = null; // TODO: replace null with proper value
            bool? userCount = null; // TODO: replace null with proper value
            
            var response = instance.GetRoles(pageSize, pageNumber, sortBy, expand, permission, userCount);
            Assert.IsInstanceOf<OrganizationRoleEntityListing> (response, "response is OrganizationRoleEntityListing"); 
        }
        
        /// <summary>
        /// Test PostRoles
        /// </summary>
        [Test]
        public void PostRolesTest()
        {
            // TODO: add unit test for the method 'PostRoles'
            DomainOrganizationRole body = null; // TODO: replace null with proper value
            
            var response = instance.PostRoles(body);
            Assert.IsInstanceOf<DomainOrganizationRole> (response, "response is DomainOrganizationRole"); 
        }
        
        /// <summary>
        /// Test PutRolesDefault
        /// </summary>
        [Test]
        public void PutRolesDefaultTest()
        {
            // TODO: add unit test for the method 'PutRolesDefault'
            List<DomainOrganizationRole> body = null; // TODO: replace null with proper value
            
            var response = instance.PutRolesDefault(body);
            Assert.IsInstanceOf<OrganizationRoleEntityListing> (response, "response is OrganizationRoleEntityListing"); 
        }
        
        /// <summary>
        /// Test PostRolesDefault
        /// </summary>
        [Test]
        public void PostRolesDefaultTest()
        {
            // TODO: add unit test for the method 'PostRolesDefault'
            bool? force = null; // TODO: replace null with proper value
            
            var response = instance.PostRolesDefault(force);
            Assert.IsInstanceOf<OrganizationRoleEntityListing> (response, "response is OrganizationRoleEntityListing"); 
        }
        
        /// <summary>
        /// Test GetRoleComparedefault
        /// </summary>
        [Test]
        public void GetRoleComparedefaultTest()
        {
            // TODO: add unit test for the method 'GetRoleComparedefault'
            string leftRoleId = null; // TODO: replace null with proper value
            string rightRoleId = null; // TODO: replace null with proper value
            
            var response = instance.GetRoleComparedefault(leftRoleId, rightRoleId);
            Assert.IsInstanceOf<DomainOrgRoleDifference> (response, "response is DomainOrgRoleDifference"); 
        }
        
        /// <summary>
        /// Test PostRoleComparedefault
        /// </summary>
        [Test]
        public void PostRoleComparedefaultTest()
        {
            // TODO: add unit test for the method 'PostRoleComparedefault'
            string leftRoleId = null; // TODO: replace null with proper value
            string rightRoleId = null; // TODO: replace null with proper value
            DomainOrganizationRole body = null; // TODO: replace null with proper value
            
            var response = instance.PostRoleComparedefault(leftRoleId, rightRoleId, body);
            Assert.IsInstanceOf<DomainOrgRoleDifference> (response, "response is DomainOrgRoleDifference"); 
        }
        
        /// <summary>
        /// Test GetRole
        /// </summary>
        [Test]
        public void GetRoleTest()
        {
            // TODO: add unit test for the method 'GetRole'
            string roleId = null; // TODO: replace null with proper value
            
            var response = instance.GetRole(roleId);
            Assert.IsInstanceOf<DomainOrganizationRole> (response, "response is DomainOrganizationRole"); 
        }
        
        /// <summary>
        /// Test PutRole
        /// </summary>
        [Test]
        public void PutRoleTest()
        {
            // TODO: add unit test for the method 'PutRole'
            string roleId = null; // TODO: replace null with proper value
            DomainOrganizationRole body = null; // TODO: replace null with proper value
            
            var response = instance.PutRole(roleId, body);
            Assert.IsInstanceOf<DomainOrganizationRole> (response, "response is DomainOrganizationRole"); 
        }
        
        /// <summary>
        /// Test DeleteRole
        /// </summary>
        [Test]
        public void DeleteRoleTest()
        {
            // TODO: add unit test for the method 'DeleteRole'
            string roleId = null; // TODO: replace null with proper value
            
            instance.DeleteRole(roleId);
             
        }
        
        /// <summary>
        /// Test PatchRole
        /// </summary>
        [Test]
        public void PatchRoleTest()
        {
            // TODO: add unit test for the method 'PatchRole'
            string roleId = null; // TODO: replace null with proper value
            DomainOrganizationRole body = null; // TODO: replace null with proper value
            
            var response = instance.PatchRole(roleId, body);
            Assert.IsInstanceOf<DomainOrganizationRole> (response, "response is DomainOrganizationRole"); 
        }
        
        /// <summary>
        /// Test PutRoleUsersAdd
        /// </summary>
        [Test]
        public void PutRoleUsersAddTest()
        {
            // TODO: add unit test for the method 'PutRoleUsersAdd'
            string roleId = null; // TODO: replace null with proper value
            List<string> body = null; // TODO: replace null with proper value
            
            var response = instance.PutRoleUsersAdd(roleId, body);
            Assert.IsInstanceOf<List<string>> (response, "response is List<string>"); 
        }
        
        /// <summary>
        /// Test PutRoleUsersRemove
        /// </summary>
        [Test]
        public void PutRoleUsersRemoveTest()
        {
            // TODO: add unit test for the method 'PutRoleUsersRemove'
            string roleId = null; // TODO: replace null with proper value
            List<string> body = null; // TODO: replace null with proper value
            
            var response = instance.PutRoleUsersRemove(roleId, body);
            Assert.IsInstanceOf<List<string>> (response, "response is List<string>"); 
        }
        
        /// <summary>
        /// Test GetUserRoles
        /// </summary>
        [Test]
        public void GetUserRolesTest()
        {
            // TODO: add unit test for the method 'GetUserRoles'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetUserRoles(userId);
            Assert.IsInstanceOf<UserAuthorization> (response, "response is UserAuthorization"); 
        }
        
        /// <summary>
        /// Test PutUserRoles
        /// </summary>
        [Test]
        public void PutUserRolesTest()
        {
            // TODO: add unit test for the method 'PutUserRoles'
            string userId = null; // TODO: replace null with proper value
            List<string> body = null; // TODO: replace null with proper value
            
            var response = instance.PutUserRoles(userId, body);
            Assert.IsInstanceOf<List<string>> (response, "response is List<string>"); 
        }
        
        /// <summary>
        /// Test DeleteUserRoles
        /// </summary>
        [Test]
        public void DeleteUserRolesTest()
        {
            // TODO: add unit test for the method 'DeleteUserRoles'
            string userId = null; // TODO: replace null with proper value
            
            instance.DeleteUserRoles(userId);
             
        }
        
    }

}
