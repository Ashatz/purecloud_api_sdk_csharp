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
    public class EdgeInterfaceTests
    {
        private EdgeInterface instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EdgeInterface();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EdgeInterface
        /// </summary>
        [Test]
        public void EdgeInterfaceInstanceTest()
        {
            Assert.IsInstanceOf<EdgeInterface> (instance, "instance is a EdgeInterface");
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
        /// Test the property 'IpAddress' 
        /// </summary>
        [Test]
        public void IpAddressTest()
        {
            // TODO: unit test for the property 'IpAddress' 
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
        /// Test the property 'MacAddress' 
        /// </summary>
        [Test]
        public void MacAddressTest()
        {
            // TODO: unit test for the property 'MacAddress' 
        }
        
        /// <summary>
        /// Test the property 'IfName' 
        /// </summary>
        [Test]
        public void IfNameTest()
        {
            // TODO: unit test for the property 'IfName' 
        }
        
        /// <summary>
        /// Test the property 'Endpoints' 
        /// </summary>
        [Test]
        public void EndpointsTest()
        {
            // TODO: unit test for the property 'Endpoints' 
        }
        
        /// <summary>
        /// Test the property 'LineTypes' 
        /// </summary>
        [Test]
        public void LineTypesTest()
        {
            // TODO: unit test for the property 'LineTypes' 
        }
        
        /// <summary>
        /// Test the property 'AddressFamilyId' 
        /// </summary>
        [Test]
        public void AddressFamilyIdTest()
        {
            // TODO: unit test for the property 'AddressFamilyId' 
        }
        

    }

}
