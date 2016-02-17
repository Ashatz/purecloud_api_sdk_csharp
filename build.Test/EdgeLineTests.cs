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
    public class EdgeLineTests
    {
        private EdgeLine instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EdgeLine();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EdgeLine
        /// </summary>
        [Test]
        public void EdgeLineInstanceTest()
        {
            Assert.IsInstanceOf<EdgeLine> (instance, "instance is a EdgeLine");
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
        /// Test the property 'Schema' 
        /// </summary>
        [Test]
        public void SchemaTest()
        {
            // TODO: unit test for the property 'Schema' 
        }
        
        /// <summary>
        /// Test the property 'Properties' 
        /// </summary>
        [Test]
        public void PropertiesTest()
        {
            // TODO: unit test for the property 'Properties' 
        }
        
        /// <summary>
        /// Test the property 'Edge' 
        /// </summary>
        [Test]
        public void EdgeTest()
        {
            // TODO: unit test for the property 'Edge' 
        }
        
        /// <summary>
        /// Test the property 'EdgeGroup' 
        /// </summary>
        [Test]
        public void EdgeGroupTest()
        {
            // TODO: unit test for the property 'EdgeGroup' 
        }
        
        /// <summary>
        /// Test the property 'LineType' 
        /// </summary>
        [Test]
        public void LineTypeTest()
        {
            // TODO: unit test for the property 'LineType' 
        }
        
        /// <summary>
        /// Test the property 'Endpoint' 
        /// </summary>
        [Test]
        public void EndpointTest()
        {
            // TODO: unit test for the property 'Endpoint' 
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
        /// Test the property 'LogicalInterfaceId' 
        /// </summary>
        [Test]
        public void LogicalInterfaceIdTest()
        {
            // TODO: unit test for the property 'LogicalInterfaceId' 
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
