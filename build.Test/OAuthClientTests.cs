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
    public class OAuthClientTests
    {
        private OAuthClient instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OAuthClient();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of OAuthClient
        /// </summary>
        [Test]
        public void OAuthClientInstanceTest()
        {
            Assert.IsInstanceOf<OAuthClient> (instance, "instance is a OAuthClient");
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
        /// Test the property 'AccessTokenValiditySeconds' 
        /// </summary>
        [Test]
        public void AccessTokenValiditySecondsTest()
        {
            // TODO: unit test for the property 'AccessTokenValiditySeconds' 
        }
        
        /// <summary>
        /// Test the property 'AuthorizedGrantTypes' 
        /// </summary>
        [Test]
        public void AuthorizedGrantTypesTest()
        {
            // TODO: unit test for the property 'AuthorizedGrantTypes' 
        }
        
        /// <summary>
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
        }
        
        /// <summary>
        /// Test the property 'RegisteredRedirectUri' 
        /// </summary>
        [Test]
        public void RegisteredRedirectUriTest()
        {
            // TODO: unit test for the property 'RegisteredRedirectUri' 
        }
        
        /// <summary>
        /// Test the property 'Secret' 
        /// </summary>
        [Test]
        public void SecretTest()
        {
            // TODO: unit test for the property 'Secret' 
        }
        
        /// <summary>
        /// Test the property 'RoleIds' 
        /// </summary>
        [Test]
        public void RoleIdsTest()
        {
            // TODO: unit test for the property 'RoleIds' 
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
