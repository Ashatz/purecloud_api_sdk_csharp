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
    public class DomainNetworkAddressTests
    {
        private DomainNetworkAddress instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainNetworkAddress();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DomainNetworkAddress
        /// </summary>
        [Test]
        public void DomainNetworkAddressInstanceTest()
        {
            Assert.IsInstanceOf<DomainNetworkAddress> (instance, "instance is a DomainNetworkAddress");
        }

        
        /// <summary>
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        
        /// <summary>
        /// Test the property 'Address' 
        /// </summary>
        [Test]
        public void AddressTest()
        {
            // TODO: unit test for the property 'Address' 
        }
        
        /// <summary>
        /// Test the property 'Persistent' 
        /// </summary>
        [Test]
        public void PersistentTest()
        {
            // TODO: unit test for the property 'Persistent' 
        }
        
        /// <summary>
        /// Test the property 'Family' 
        /// </summary>
        [Test]
        public void FamilyTest()
        {
            // TODO: unit test for the property 'Family' 
        }
        

    }

}
