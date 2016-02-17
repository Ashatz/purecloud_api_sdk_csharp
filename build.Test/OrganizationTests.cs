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
    public class OrganizationTests
    {
        private Organization instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Organization();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Organization
        /// </summary>
        [Test]
        public void OrganizationInstanceTest()
        {
            Assert.IsInstanceOf<Organization> (instance, "instance is a Organization");
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
        /// Test the property 'ThirdPartyOrgId' 
        /// </summary>
        [Test]
        public void ThirdPartyOrgIdTest()
        {
            // TODO: unit test for the property 'ThirdPartyOrgId' 
        }
        
        /// <summary>
        /// Test the property 'ThirdPartyOrgName' 
        /// </summary>
        [Test]
        public void ThirdPartyOrgNameTest()
        {
            // TODO: unit test for the property 'ThirdPartyOrgName' 
        }
        
        /// <summary>
        /// Test the property 'ThirdPartyURI' 
        /// </summary>
        [Test]
        public void ThirdPartyURITest()
        {
            // TODO: unit test for the property 'ThirdPartyURI' 
        }
        
        /// <summary>
        /// Test the property 'AdminUsername' 
        /// </summary>
        [Test]
        public void AdminUsernameTest()
        {
            // TODO: unit test for the property 'AdminUsername' 
        }
        
        /// <summary>
        /// Test the property 'AdminPassword' 
        /// </summary>
        [Test]
        public void AdminPasswordTest()
        {
            // TODO: unit test for the property 'AdminPassword' 
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
        /// Test the property 'Version' 
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO: unit test for the property 'Version' 
        }
        
        /// <summary>
        /// Test the property 'State' 
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO: unit test for the property 'State' 
        }
        
        /// <summary>
        /// Test the property 'DefaultSiteId' 
        /// </summary>
        [Test]
        public void DefaultSiteIdTest()
        {
            // TODO: unit test for the property 'DefaultSiteId' 
        }
        
        /// <summary>
        /// Test the property 'Deletable' 
        /// </summary>
        [Test]
        public void DeletableTest()
        {
            // TODO: unit test for the property 'Deletable' 
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
