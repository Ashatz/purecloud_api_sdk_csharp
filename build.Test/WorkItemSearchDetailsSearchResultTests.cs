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
    public class WorkItemSearchDetailsSearchResultTests
    {
        private WorkItemSearchDetailsSearchResult instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkItemSearchDetailsSearchResult();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WorkItemSearchDetailsSearchResult
        /// </summary>
        [Test]
        public void WorkItemSearchDetailsSearchResultInstanceTest()
        {
            Assert.IsInstanceOf<WorkItemSearchDetailsSearchResult> (instance, "instance is a WorkItemSearchDetailsSearchResult");
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
