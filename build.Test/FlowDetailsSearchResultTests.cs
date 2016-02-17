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
    public class FlowDetailsSearchResultTests
    {
        private FlowDetailsSearchResult instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowDetailsSearchResult();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowDetailsSearchResult
        /// </summary>
        [Test]
        public void FlowDetailsSearchResultInstanceTest()
        {
            Assert.IsInstanceOf<FlowDetailsSearchResult> (instance, "instance is a FlowDetailsSearchResult");
        }

        
        /// <summary>
        /// Test the property 'SearchResults' 
        /// </summary>
        [Test]
        public void SearchResultsTest()
        {
            // TODO: unit test for the property 'SearchResults' 
        }
        
        /// <summary>
        /// Test the property 'FacetResults' 
        /// </summary>
        [Test]
        public void FacetResultsTest()
        {
            // TODO: unit test for the property 'FacetResults' 
        }
        

    }

}
