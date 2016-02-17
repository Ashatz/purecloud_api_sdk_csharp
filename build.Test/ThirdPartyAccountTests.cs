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
    public class ThirdPartyAccountTests
    {
        private ThirdPartyAccount instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ThirdPartyAccount();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ThirdPartyAccount
        /// </summary>
        [Test]
        public void ThirdPartyAccountInstanceTest()
        {
            Assert.IsInstanceOf<ThirdPartyAccount> (instance, "instance is a ThirdPartyAccount");
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
        /// Test the property 'AccountNumber' 
        /// </summary>
        [Test]
        public void AccountNumberTest()
        {
            // TODO: unit test for the property 'AccountNumber' 
        }
        
        /// <summary>
        /// Test the property 'Currency' 
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO: unit test for the property 'Currency' 
        }
        
        /// <summary>
        /// Test the property 'Invoices' 
        /// </summary>
        [Test]
        public void InvoicesTest()
        {
            // TODO: unit test for the property 'Invoices' 
        }
        
        /// <summary>
        /// Test the property 'Subscriptions' 
        /// </summary>
        [Test]
        public void SubscriptionsTest()
        {
            // TODO: unit test for the property 'Subscriptions' 
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
