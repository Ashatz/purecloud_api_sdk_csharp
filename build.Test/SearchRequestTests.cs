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
    public class SearchRequestTests
    {
        private SearchRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SearchRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SearchRequest
        /// </summary>
        [Test]
        public void SearchRequestInstanceTest()
        {
            Assert.IsInstanceOf<SearchRequest> (instance, "instance is a SearchRequest");
        }

        
        /// <summary>
        /// Test the property 'SearchPhrase' 
        /// </summary>
        [Test]
        public void SearchPhraseTest()
        {
            // TODO: unit test for the property 'SearchPhrase' 
        }
        
        /// <summary>
        /// Test the property 'PageNumber' 
        /// </summary>
        [Test]
        public void PageNumberTest()
        {
            // TODO: unit test for the property 'PageNumber' 
        }
        
        /// <summary>
        /// Test the property 'PageSize' 
        /// </summary>
        [Test]
        public void PageSizeTest()
        {
            // TODO: unit test for the property 'PageSize' 
        }
        
        /// <summary>
        /// Test the property 'SearchFields' 
        /// </summary>
        [Test]
        public void SearchFieldsTest()
        {
            // TODO: unit test for the property 'SearchFields' 
        }
        
        /// <summary>
        /// Test the property 'FacetRequests' 
        /// </summary>
        [Test]
        public void FacetRequestsTest()
        {
            // TODO: unit test for the property 'FacetRequests' 
        }
        
        /// <summary>
        /// Test the property 'Sort' 
        /// </summary>
        [Test]
        public void SortTest()
        {
            // TODO: unit test for the property 'Sort' 
        }
        
        /// <summary>
        /// Test the property 'Filters' 
        /// </summary>
        [Test]
        public void FiltersTest()
        {
            // TODO: unit test for the property 'Filters' 
        }
        

    }

}