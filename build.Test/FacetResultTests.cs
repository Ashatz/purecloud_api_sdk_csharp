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
    public class FacetResultTests
    {
        private FacetResult instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FacetResult();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FacetResult
        /// </summary>
        [Test]
        public void FacetResultInstanceTest()
        {
            Assert.IsInstanceOf<FacetResult> (instance, "instance is a FacetResult");
        }

        
        /// <summary>
        /// Test the property 'RequestName' 
        /// </summary>
        [Test]
        public void RequestNameTest()
        {
            // TODO: unit test for the property 'RequestName' 
        }
        
        /// <summary>
        /// Test the property 'RequestFieldName' 
        /// </summary>
        [Test]
        public void RequestFieldNameTest()
        {
            // TODO: unit test for the property 'RequestFieldName' 
        }
        
        /// <summary>
        /// Test the property 'FieldType' 
        /// </summary>
        [Test]
        public void FieldTypeTest()
        {
            // TODO: unit test for the property 'FieldType' 
        }
        
        /// <summary>
        /// Test the property 'RequestType' 
        /// </summary>
        [Test]
        public void RequestTypeTest()
        {
            // TODO: unit test for the property 'RequestType' 
        }
        
        /// <summary>
        /// Test the property 'Results' 
        /// </summary>
        [Test]
        public void ResultsTest()
        {
            // TODO: unit test for the property 'Results' 
        }
        

    }

}
