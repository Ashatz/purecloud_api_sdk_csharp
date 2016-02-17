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
    public class DomainOrgRoleDifferenceTests
    {
        private DomainOrgRoleDifference instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainOrgRoleDifference();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DomainOrgRoleDifference
        /// </summary>
        [Test]
        public void DomainOrgRoleDifferenceInstanceTest()
        {
            Assert.IsInstanceOf<DomainOrgRoleDifference> (instance, "instance is a DomainOrgRoleDifference");
        }

        
        /// <summary>
        /// Test the property 'RemovedPermissionPolicies' 
        /// </summary>
        [Test]
        public void RemovedPermissionPoliciesTest()
        {
            // TODO: unit test for the property 'RemovedPermissionPolicies' 
        }
        
        /// <summary>
        /// Test the property 'AddedPermissionPolicies' 
        /// </summary>
        [Test]
        public void AddedPermissionPoliciesTest()
        {
            // TODO: unit test for the property 'AddedPermissionPolicies' 
        }
        
        /// <summary>
        /// Test the property 'SamePermissionPolicies' 
        /// </summary>
        [Test]
        public void SamePermissionPoliciesTest()
        {
            // TODO: unit test for the property 'SamePermissionPolicies' 
        }
        
        /// <summary>
        /// Test the property 'UserOrgRole' 
        /// </summary>
        [Test]
        public void UserOrgRoleTest()
        {
            // TODO: unit test for the property 'UserOrgRole' 
        }
        
        /// <summary>
        /// Test the property 'RoleFromDefault' 
        /// </summary>
        [Test]
        public void RoleFromDefaultTest()
        {
            // TODO: unit test for the property 'RoleFromDefault' 
        }
        

    }

}
