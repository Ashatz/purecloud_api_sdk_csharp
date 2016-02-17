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
    public class TableTransformTests
    {
        private TableTransform instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TableTransform();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TableTransform
        /// </summary>
        [Test]
        public void TableTransformInstanceTest()
        {
            Assert.IsInstanceOf<TableTransform> (instance, "instance is a TableTransform");
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
        /// Test the property 'FirstData' 
        /// </summary>
        [Test]
        public void FirstDataTest()
        {
            // TODO: unit test for the property 'FirstData' 
        }
        
        /// <summary>
        /// Test the property 'HeaderReplaces' 
        /// </summary>
        [Test]
        public void HeaderReplacesTest()
        {
            // TODO: unit test for the property 'HeaderReplaces' 
        }
        
        /// <summary>
        /// Test the property 'Columns' 
        /// </summary>
        [Test]
        public void ColumnsTest()
        {
            // TODO: unit test for the property 'Columns' 
        }
        
        /// <summary>
        /// Test the property 'Unpivots' 
        /// </summary>
        [Test]
        public void UnpivotsTest()
        {
            // TODO: unit test for the property 'Unpivots' 
        }
        
        /// <summary>
        /// Test the property 'Collapses' 
        /// </summary>
        [Test]
        public void CollapsesTest()
        {
            // TODO: unit test for the property 'Collapses' 
        }
        

    }

}
