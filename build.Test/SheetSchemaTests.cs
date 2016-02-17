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
    public class SheetSchemaTests
    {
        private SheetSchema instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SheetSchema();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SheetSchema
        /// </summary>
        [Test]
        public void SheetSchemaInstanceTest()
        {
            Assert.IsInstanceOf<SheetSchema> (instance, "instance is a SheetSchema");
        }

        
        /// <summary>
        /// Test the property 'HeaderRow' 
        /// </summary>
        [Test]
        public void HeaderRowTest()
        {
            // TODO: unit test for the property 'HeaderRow' 
        }
        
        /// <summary>
        /// Test the property 'DataRow' 
        /// </summary>
        [Test]
        public void DataRowTest()
        {
            // TODO: unit test for the property 'DataRow' 
        }
        
        /// <summary>
        /// Test the property 'HeaderMappings' 
        /// </summary>
        [Test]
        public void HeaderMappingsTest()
        {
            // TODO: unit test for the property 'HeaderMappings' 
        }
        
        /// <summary>
        /// Test the property 'RateType' 
        /// </summary>
        [Test]
        public void RateTypeTest()
        {
            // TODO: unit test for the property 'RateType' 
        }
        
        /// <summary>
        /// Test the property 'SheetNumber' 
        /// </summary>
        [Test]
        public void SheetNumberTest()
        {
            // TODO: unit test for the property 'SheetNumber' 
        }
        
        /// <summary>
        /// Test the property 'DateFormat' 
        /// </summary>
        [Test]
        public void DateFormatTest()
        {
            // TODO: unit test for the property 'DateFormat' 
        }
        

    }

}
