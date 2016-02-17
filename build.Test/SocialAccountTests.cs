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
    public class SocialAccountTests
    {
        private SocialAccount instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SocialAccount();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SocialAccount
        /// </summary>
        [Test]
        public void SocialAccountInstanceTest()
        {
            Assert.IsInstanceOf<SocialAccount> (instance, "instance is a SocialAccount");
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
        /// Test the property 'DateCreated' 
        /// </summary>
        [Test]
        public void DateCreatedTest()
        {
            // TODO: unit test for the property 'DateCreated' 
        }
        
        /// <summary>
        /// Test the property 'DateModified' 
        /// </summary>
        [Test]
        public void DateModifiedTest()
        {
            // TODO: unit test for the property 'DateModified' 
        }
        
        /// <summary>
        /// Test the property 'Enabled' 
        /// </summary>
        [Test]
        public void EnabledTest()
        {
            // TODO: unit test for the property 'Enabled' 
        }
        
        /// <summary>
        /// Test the property 'Authorized' 
        /// </summary>
        [Test]
        public void AuthorizedTest()
        {
            // TODO: unit test for the property 'Authorized' 
        }
        
        /// <summary>
        /// Test the property 'SocialHub' 
        /// </summary>
        [Test]
        public void SocialHubTest()
        {
            // TODO: unit test for the property 'SocialHub' 
        }
        
        /// <summary>
        /// Test the property 'AccessToken' 
        /// </summary>
        [Test]
        public void AccessTokenTest()
        {
            // TODO: unit test for the property 'AccessToken' 
        }
        
        /// <summary>
        /// Test the property 'AccessTokenSecret' 
        /// </summary>
        [Test]
        public void AccessTokenSecretTest()
        {
            // TODO: unit test for the property 'AccessTokenSecret' 
        }
        
        /// <summary>
        /// Test the property 'TwitterId' 
        /// </summary>
        [Test]
        public void TwitterIdTest()
        {
            // TODO: unit test for the property 'TwitterId' 
        }
        
        /// <summary>
        /// Test the property 'StreamingEnabled' 
        /// </summary>
        [Test]
        public void StreamingEnabledTest()
        {
            // TODO: unit test for the property 'StreamingEnabled' 
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
