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
    public class FacetRequestTests
    {
        private FacetRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FacetRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FacetRequest
        /// </summary>
        [Test]
        public void FacetRequestInstanceTest()
        {
            Assert.IsInstanceOf<FacetRequest> (instance, "instance is a FacetRequest");
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
        /// Test the property 'FacetRequestQueryType' 
        /// </summary>
        [Test]
        public void FacetRequestQueryTypeTest()
        {
            // TODO: unit test for the property 'FacetRequestQueryType' 
        }
        
        /// <summary>
        /// Test the property 'FieldName' 
        /// </summary>
        [Test]
        public void FieldNameTest()
        {
            // TODO: unit test for the property 'FieldName' 
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
        /// Test the property 'RangeFrom' 
        /// </summary>
        [Test]
        public void RangeFromTest()
        {
            // TODO: unit test for the property 'RangeFrom' 
        }
        
        /// <summary>
        /// Test the property 'RangeTo' 
        /// </summary>
        [Test]
        public void RangeToTest()
        {
            // TODO: unit test for the property 'RangeTo' 
        }
        
        /// <summary>
        /// Test the property 'MaxFacetCount' 
        /// </summary>
        [Test]
        public void MaxFacetCountTest()
        {
            // TODO: unit test for the property 'MaxFacetCount' 
        }
        

    }

}
