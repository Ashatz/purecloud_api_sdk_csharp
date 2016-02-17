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
    public class QueryResultsTests
    {
        private QueryResults instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new QueryResults();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of QueryResults
        /// </summary>
        [Test]
        public void QueryResultsInstanceTest()
        {
            Assert.IsInstanceOf<QueryResults> (instance, "instance is a QueryResults");
        }

        
        /// <summary>
        /// Test the property 'Results' 
        /// </summary>
        [Test]
        public void ResultsTest()
        {
            // TODO: unit test for the property 'Results' 
        }
        
        /// <summary>
        /// Test the property 'FacetInfo' 
        /// </summary>
        [Test]
        public void FacetInfoTest()
        {
            // TODO: unit test for the property 'FacetInfo' 
        }
        

    }

}
