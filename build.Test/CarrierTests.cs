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
    public class CarrierTests
    {
        private Carrier instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Carrier();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Carrier
        /// </summary>
        [Test]
        public void CarrierInstanceTest()
        {
            Assert.IsInstanceOf<Carrier> (instance, "instance is a Carrier");
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
        /// Test the property 'AccountManager' 
        /// </summary>
        [Test]
        public void AccountManagerTest()
        {
            // TODO: unit test for the property 'AccountManager' 
        }
        
        /// <summary>
        /// Test the property 'Support' 
        /// </summary>
        [Test]
        public void SupportTest()
        {
            // TODO: unit test for the property 'Support' 
        }
        
        /// <summary>
        /// Test the property 'NocSupport' 
        /// </summary>
        [Test]
        public void NocSupportTest()
        {
            // TODO: unit test for the property 'NocSupport' 
        }
        
        /// <summary>
        /// Test the property 'Services' 
        /// </summary>
        [Test]
        public void ServicesTest()
        {
            // TODO: unit test for the property 'Services' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        
        /// <summary>
        /// Test the property 'Address' 
        /// </summary>
        [Test]
        public void AddressTest()
        {
            // TODO: unit test for the property 'Address' 
        }
        

    }

}
