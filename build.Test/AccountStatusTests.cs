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
    public class AccountStatusTests
    {
        private AccountStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountStatus();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AccountStatus
        /// </summary>
        [Test]
        public void AccountStatusInstanceTest()
        {
            Assert.IsInstanceOf<AccountStatus> (instance, "instance is a AccountStatus");
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
        /// Test the property 'OrgName' 
        /// </summary>
        [Test]
        public void OrgNameTest()
        {
            // TODO: unit test for the property 'OrgName' 
        }
        
        /// <summary>
        /// Test the property 'Configured' 
        /// </summary>
        [Test]
        public void ConfiguredTest()
        {
            // TODO: unit test for the property 'Configured' 
        }
        
        /// <summary>
        /// Test the property 'AdminUIURL' 
        /// </summary>
        [Test]
        public void AdminUIURLTest()
        {
            // TODO: unit test for the property 'AdminUIURL' 
        }
        
        /// <summary>
        /// Test the property 'ThirdPartyAccountId' 
        /// </summary>
        [Test]
        public void ThirdPartyAccountIdTest()
        {
            // TODO: unit test for the property 'ThirdPartyAccountId' 
        }
        
        /// <summary>
        /// Test the property 'ThirdPartySubscriptionId' 
        /// </summary>
        [Test]
        public void ThirdPartySubscriptionIdTest()
        {
            // TODO: unit test for the property 'ThirdPartySubscriptionId' 
        }
        
        /// <summary>
        /// Test the property 'ThirdPartySubscriptionNonAcbId' 
        /// </summary>
        [Test]
        public void ThirdPartySubscriptionNonAcbIdTest()
        {
            // TODO: unit test for the property 'ThirdPartySubscriptionNonAcbId' 
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
