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
    public class SocializeFilterRequestTests
    {
        private SocializeFilterRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SocializeFilterRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SocializeFilterRequest
        /// </summary>
        [Test]
        public void SocializeFilterRequestInstanceTest()
        {
            Assert.IsInstanceOf<SocializeFilterRequest> (instance, "instance is a SocializeFilterRequest");
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
        /// Test the property 'PageSize' 
        /// </summary>
        [Test]
        public void PageSizeTest()
        {
            // TODO: unit test for the property 'PageSize' 
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
        /// Test the property 'SortBy' 
        /// </summary>
        [Test]
        public void SortByTest()
        {
            // TODO: unit test for the property 'SortBy' 
        }
        
        /// <summary>
        /// Test the property 'SortOrder' 
        /// </summary>
        [Test]
        public void SortOrderTest()
        {
            // TODO: unit test for the property 'SortOrder' 
        }
        

    }

}
