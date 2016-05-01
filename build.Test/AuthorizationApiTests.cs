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
    /// <summary>
    ///  Class for testing AuthorizationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
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
        /// Test DeleteRolesRoleId
        /// </summary>
        [Test]
        public void DeleteRolesRoleIdTest()
        {
            // TODO: add unit test for the method 'DeleteRolesRoleId'
            string roleId = null; // TODO: replace null with proper value
            instance.DeleteRolesRoleId(roleId);
            
        }
        
        /// <summary>
        /// Test DeleteUserIdRoles
        /// </summary>
        [Test]
        public void DeleteUserIdRolesTest()
        {
            // TODO: add unit test for the method 'DeleteUserIdRoles'
            string userId = null; // TODO: replace null with proper value
            instance.DeleteUserIdRoles(userId);
            
        }
        
        /// <summary>
        /// Test GetObjectsObjectId
        /// </summary>
        [Test]
        public void GetObjectsObjectIdTest()
        {
            // TODO: add unit test for the method 'GetObjectsObjectId'
            string objectId = null; // TODO: replace null with proper value
            var response = instance.GetObjectsObjectId(objectId);
            Assert.IsInstanceOf<AuthzObject> (response, "response is AuthzObject");
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
            string nextPage = null; // TODO: replace null with proper value
            string previousPage = null; // TODO: replace null with proper value
            List<string> permission = null; // TODO: replace null with proper value
            bool? userCount = null; // TODO: replace null with proper value
            var response = instance.GetRoles(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, permission, userCount);
            Assert.IsInstanceOf<OrganizationRoleEntityListing> (response, "response is OrganizationRoleEntityListing");
        }
        
        /// <summary>
        /// Test GetRolesLeftroleIdComparedefaultRightroleId
        /// </summary>
        [Test]
        public void GetRolesLeftroleIdComparedefaultRightroleIdTest()
        {
            // TODO: add unit test for the method 'GetRolesLeftroleIdComparedefaultRightroleId'
            string leftRoleId = null; // TODO: replace null with proper value
            string rightRoleId = null; // TODO: replace null with proper value
            var response = instance.GetRolesLeftroleIdComparedefaultRightroleId(leftRoleId, rightRoleId);
            Assert.IsInstanceOf<DomainOrgRoleDifference> (response, "response is DomainOrgRoleDifference");
        }
        
        /// <summary>
        /// Test GetRolesRoleId
        /// </summary>
        [Test]
        public void GetRolesRoleIdTest()
        {
            // TODO: add unit test for the method 'GetRolesRoleId'
            string roleId = null; // TODO: replace null with proper value
            var response = instance.GetRolesRoleId(roleId);
            Assert.IsInstanceOf<DomainOrganizationRole> (response, "response is DomainOrganizationRole");
        }
        
        /// <summary>
        /// Test GetUserIdRoles
        /// </summary>
        [Test]
        public void GetUserIdRolesTest()
        {
            // TODO: add unit test for the method 'GetUserIdRoles'
            string userId = null; // TODO: replace null with proper value
            var response = instance.GetUserIdRoles(userId);
            Assert.IsInstanceOf<UserAuthorization> (response, "response is UserAuthorization");
        }
        
        /// <summary>
        /// Test PatchRolesRoleId
        /// </summary>
        [Test]
        public void PatchRolesRoleIdTest()
        {
            // TODO: add unit test for the method 'PatchRolesRoleId'
            string roleId = null; // TODO: replace null with proper value
            DomainOrganizationRole body = null; // TODO: replace null with proper value
            var response = instance.PatchRolesRoleId(roleId, body);
            Assert.IsInstanceOf<DomainOrganizationRole> (response, "response is DomainOrganizationRole");
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
        /// Test PostRolesLeftroleIdComparedefaultRightroleId
        /// </summary>
        [Test]
        public void PostRolesLeftroleIdComparedefaultRightroleIdTest()
        {
            // TODO: add unit test for the method 'PostRolesLeftroleIdComparedefaultRightroleId'
            string leftRoleId = null; // TODO: replace null with proper value
            string rightRoleId = null; // TODO: replace null with proper value
            DomainOrganizationRole body = null; // TODO: replace null with proper value
            var response = instance.PostRolesLeftroleIdComparedefaultRightroleId(leftRoleId, rightRoleId, body);
            Assert.IsInstanceOf<DomainOrgRoleDifference> (response, "response is DomainOrgRoleDifference");
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
        /// Test PutRolesRoleId
        /// </summary>
        [Test]
        public void PutRolesRoleIdTest()
        {
            // TODO: add unit test for the method 'PutRolesRoleId'
            string roleId = null; // TODO: replace null with proper value
            DomainOrganizationRole body = null; // TODO: replace null with proper value
            var response = instance.PutRolesRoleId(roleId, body);
            Assert.IsInstanceOf<DomainOrganizationRole> (response, "response is DomainOrganizationRole");
        }
        
        /// <summary>
        /// Test PutRolesRoleIdUsersAdd
        /// </summary>
        [Test]
        public void PutRolesRoleIdUsersAddTest()
        {
            // TODO: add unit test for the method 'PutRolesRoleIdUsersAdd'
            string roleId = null; // TODO: replace null with proper value
            List<string> body = null; // TODO: replace null with proper value
            var response = instance.PutRolesRoleIdUsersAdd(roleId, body);
            Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test PutRolesRoleIdUsersRemove
        /// </summary>
        [Test]
        public void PutRolesRoleIdUsersRemoveTest()
        {
            // TODO: add unit test for the method 'PutRolesRoleIdUsersRemove'
            string roleId = null; // TODO: replace null with proper value
            List<string> body = null; // TODO: replace null with proper value
            var response = instance.PutRolesRoleIdUsersRemove(roleId, body);
            Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test PutUserIdRoles
        /// </summary>
        [Test]
        public void PutUserIdRolesTest()
        {
            // TODO: add unit test for the method 'PutUserIdRoles'
            string userId = null; // TODO: replace null with proper value
            List<string> body = null; // TODO: replace null with proper value
            var response = instance.PutUserIdRoles(userId, body);
            Assert.IsInstanceOf<UserAuthorization> (response, "response is UserAuthorization");
        }
        
    }

}
