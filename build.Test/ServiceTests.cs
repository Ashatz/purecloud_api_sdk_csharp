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
    public class ServiceTests
    {
        private Service instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Service();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Service
        /// </summary>
        [Test]
        public void ServiceInstanceTest()
        {
            Assert.IsInstanceOf<Service> (instance, "instance is a Service");
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
        /// Test the property 'Status' 
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status' 
        }
        
        /// <summary>
        /// Test the property 'Domains' 
        /// </summary>
        [Test]
        public void DomainsTest()
        {
            // TODO: unit test for the property 'Domains' 
        }
        
        /// <summary>
        /// Test the property 'ServiceTypes' 
        /// </summary>
        [Test]
        public void ServiceTypesTest()
        {
            // TODO: unit test for the property 'ServiceTypes' 
        }
        
        /// <summary>
        /// Test the property 'Gateways' 
        /// </summary>
        [Test]
        public void GatewaysTest()
        {
            // TODO: unit test for the property 'Gateways' 
        }
        
        /// <summary>
        /// Test the property 'Dns' 
        /// </summary>
        [Test]
        public void DnsTest()
        {
            // TODO: unit test for the property 'Dns' 
        }
        
        /// <summary>
        /// Test the property 'Vpn' 
        /// </summary>
        [Test]
        public void VpnTest()
        {
            // TODO: unit test for the property 'Vpn' 
        }
        
        /// <summary>
        /// Test the property 'Carrier' 
        /// </summary>
        [Test]
        public void CarrierTest()
        {
            // TODO: unit test for the property 'Carrier' 
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
