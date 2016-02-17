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
    public class ResourcePermissionPolicyTests
    {
        private ResourcePermissionPolicy instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ResourcePermissionPolicy();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ResourcePermissionPolicy
        /// </summary>
        [Test]
        public void ResourcePermissionPolicyInstanceTest()
        {
            Assert.IsInstanceOf<ResourcePermissionPolicy> (instance, "instance is a ResourcePermissionPolicy");
        }

        
        /// <summary>
        /// Test the property 'OrgId' 
        /// </summary>
        [Test]
        public void OrgIdTest()
        {
            // TODO: unit test for the property 'OrgId' 
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
        /// Test the property 'Domain' 
        /// </summary>
        [Test]
        public void DomainTest()
        {
            // TODO: unit test for the property 'Domain' 
        }
        
        /// <summary>
        /// Test the property 'EntityName' 
        /// </summary>
        [Test]
        public void EntityNameTest()
        {
            // TODO: unit test for the property 'EntityName' 
        }
        
        /// <summary>
        /// Test the property 'PolicyName' 
        /// </summary>
        [Test]
        public void PolicyNameTest()
        {
            // TODO: unit test for the property 'PolicyName' 
        }
        
        /// <summary>
        /// Test the property 'PolicyDescription' 
        /// </summary>
        [Test]
        public void PolicyDescriptionTest()
        {
            // TODO: unit test for the property 'PolicyDescription' 
        }
        
        /// <summary>
        /// Test the property 'ActionSetKey' 
        /// </summary>
        [Test]
        public void ActionSetKeyTest()
        {
            // TODO: unit test for the property 'ActionSetKey' 
        }
        
        /// <summary>
        /// Test the property 'ResourceConditionNode' 
        /// </summary>
        [Test]
        public void ResourceConditionNodeTest()
        {
            // TODO: unit test for the property 'ResourceConditionNode' 
        }
        
        /// <summary>
        /// Test the property 'NamedResources' 
        /// </summary>
        [Test]
        public void NamedResourcesTest()
        {
            // TODO: unit test for the property 'NamedResources' 
        }
        
        /// <summary>
        /// Test the property 'ResourceCondition' 
        /// </summary>
        [Test]
        public void ResourceConditionTest()
        {
            // TODO: unit test for the property 'ResourceCondition' 
        }
        
        /// <summary>
        /// Test the property 'ActionSet' 
        /// </summary>
        [Test]
        public void ActionSetTest()
        {
            // TODO: unit test for the property 'ActionSet' 
        }
        

    }

}
