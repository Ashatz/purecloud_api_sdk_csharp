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
    public class FlowBodyFormatTests
    {
        private FlowBodyFormat instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowBodyFormat();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowBodyFormat
        /// </summary>
        [Test]
        public void FlowBodyFormatInstanceTest()
        {
            Assert.IsInstanceOf<FlowBodyFormat> (instance, "instance is a FlowBodyFormat");
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
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
        }
        
        /// <summary>
        /// Test the property 'SchemaUri' 
        /// </summary>
        [Test]
        public void SchemaUriTest()
        {
            // TODO: unit test for the property 'SchemaUri' 
        }
        

    }

}
