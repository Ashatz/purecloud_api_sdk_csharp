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
    public class CustomerAccountTests
    {
        private CustomerAccount instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CustomerAccount();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CustomerAccount
        /// </summary>
        [Test]
        public void CustomerAccountInstanceTest()
        {
            Assert.IsInstanceOf<CustomerAccount> (instance, "instance is a CustomerAccount");
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
        /// Test the property 'IsFrozen' 
        /// </summary>
        [Test]
        public void IsFrozenTest()
        {
            // TODO: unit test for the property 'IsFrozen' 
        }
        
        /// <summary>
        /// Test the property 'OrgLegalName' 
        /// </summary>
        [Test]
        public void OrgLegalNameTest()
        {
            // TODO: unit test for the property 'OrgLegalName' 
        }
        
        /// <summary>
        /// Test the property 'OrgPhone' 
        /// </summary>
        [Test]
        public void OrgPhoneTest()
        {
            // TODO: unit test for the property 'OrgPhone' 
        }
        
        /// <summary>
        /// Test the property 'IsTaxExempt' 
        /// </summary>
        [Test]
        public void IsTaxExemptTest()
        {
            // TODO: unit test for the property 'IsTaxExempt' 
        }
        
        /// <summary>
        /// Test the property 'BillingAddress' 
        /// </summary>
        [Test]
        public void BillingAddressTest()
        {
            // TODO: unit test for the property 'BillingAddress' 
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
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}
