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
    public class QueryFacetInfoTests
    {
        private QueryFacetInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new QueryFacetInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of QueryFacetInfo
        /// </summary>
        [Test]
        public void QueryFacetInfoInstanceTest()
        {
            Assert.IsInstanceOf<QueryFacetInfo> (instance, "instance is a QueryFacetInfo");
        }

        
        /// <summary>
        /// Test the property 'Attributes' 
        /// </summary>
        [Test]
        public void AttributesTest()
        {
            // TODO: unit test for the property 'Attributes' 
        }
        
        /// <summary>
        /// Test the property 'Facets' 
        /// </summary>
        [Test]
        public void FacetsTest()
        {
            // TODO: unit test for the property 'Facets' 
        }
        

    }

}
