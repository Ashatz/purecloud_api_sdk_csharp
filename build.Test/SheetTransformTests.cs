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
    public class SheetTransformTests
    {
        private SheetTransform instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SheetTransform();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SheetTransform
        /// </summary>
        [Test]
        public void SheetTransformInstanceTest()
        {
            Assert.IsInstanceOf<SheetTransform> (instance, "instance is a SheetTransform");
        }

        
        /// <summary>
        /// Test the property 'Sheet' 
        /// </summary>
        [Test]
        public void SheetTest()
        {
            // TODO: unit test for the property 'Sheet' 
        }
        
        /// <summary>
        /// Test the property 'SheetName' 
        /// </summary>
        [Test]
        public void SheetNameTest()
        {
            // TODO: unit test for the property 'SheetName' 
        }
        
        /// <summary>
        /// Test the property 'Table' 
        /// </summary>
        [Test]
        public void TableTest()
        {
            // TODO: unit test for the property 'Table' 
        }
        

    }

}
