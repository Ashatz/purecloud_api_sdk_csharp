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
    public class ReportRequestTests
    {
        private ReportRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReportRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ReportRequest
        /// </summary>
        [Test]
        public void ReportRequestInstanceTest()
        {
            Assert.IsInstanceOf<ReportRequest> (instance, "instance is a ReportRequest");
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
        
        /// <summary>
        /// Test the property 'GroupBy' 
        /// </summary>
        [Test]
        public void GroupByTest()
        {
            // TODO: unit test for the property 'GroupBy' 
        }
        

    }

}
