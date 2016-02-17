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
    public class XlsxSchemaTests
    {
        private XlsxSchema instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new XlsxSchema();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of XlsxSchema
        /// </summary>
        [Test]
        public void XlsxSchemaInstanceTest()
        {
            Assert.IsInstanceOf<XlsxSchema> (instance, "instance is a XlsxSchema");
        }

        
        /// <summary>
        /// Test the property 'SheetSchemas' 
        /// </summary>
        [Test]
        public void SheetSchemasTest()
        {
            // TODO: unit test for the property 'SheetSchemas' 
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
        /// Test the property 'CarrierId' 
        /// </summary>
        [Test]
        public void CarrierIdTest()
        {
            // TODO: unit test for the property 'CarrierId' 
        }
        

    }

}
