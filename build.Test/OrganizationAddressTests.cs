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
    public class OrganizationAddressTests
    {
        private OrganizationAddress instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrganizationAddress();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of OrganizationAddress
        /// </summary>
        [Test]
        public void OrganizationAddressInstanceTest()
        {
            Assert.IsInstanceOf<OrganizationAddress> (instance, "instance is a OrganizationAddress");
        }

        
        /// <summary>
        /// Test the property 'Display' 
        /// </summary>
        [Test]
        public void DisplayTest()
        {
            // TODO: unit test for the property 'Display' 
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
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        
        /// <summary>
        /// Test the property 'MediaType' 
        /// </summary>
        [Test]
        public void MediaTypeTest()
        {
            // TODO: unit test for the property 'MediaType' 
        }
        

    }

}
