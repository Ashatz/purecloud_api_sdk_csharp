using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Model;
using ININ.PureCloudApi.Client;
using System.Reflection;

namespace ININ.PureCloudApi.Test
{
    [TestFixture]
    public class UserAuthorizationTests
    {
        private UserAuthorization instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserAuthorization();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UserAuthorization
        /// </summary>
        [Test]
        public void UserAuthorizationInstanceTest()
        {
            Assert.IsInstanceOf<UserAuthorization> (instance, "instance is a UserAuthorization");
        }

        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        
        /// <summary>
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        
        /// <summary>
        /// Test the property 'Licenses' 
        /// </summary>
        [Test]
        public void LicensesTest()
        {
            // TODO: unit test for the property 'Licenses' 
        }
        
        /// <summary>
        /// Test the property 'Roles' 
        /// </summary>
        [Test]
        public void RolesTest()
        {
            // TODO: unit test for the property 'Roles' 
        }
        
        /// <summary>
        /// Test the property 'Permissions' 
        /// </summary>
        [Test]
        public void PermissionsTest()
        {
            // TODO: unit test for the property 'Permissions' 
        }
        
        /// <summary>
        /// Test the property 'PermissionPolicies' 
        /// </summary>
        [Test]
        public void PermissionPoliciesTest()
        {
            // TODO: unit test for the property 'PermissionPolicies' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}