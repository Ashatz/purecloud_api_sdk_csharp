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
    public class ConversationHistoricalQueryRequestBodyTests
    {
        private ConversationHistoricalQueryRequestBody instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConversationHistoricalQueryRequestBody();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ConversationHistoricalQueryRequestBody
        /// </summary>
        [Test]
        public void ConversationHistoricalQueryRequestBodyInstanceTest()
        {
            Assert.IsInstanceOf<ConversationHistoricalQueryRequestBody> (instance, "instance is a ConversationHistoricalQueryRequestBody");
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
        /// Test the property 'Maximum' 
        /// </summary>
        [Test]
        public void MaximumTest()
        {
            // TODO: unit test for the property 'Maximum' 
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
        /// Test the property 'Facets' 
        /// </summary>
        [Test]
        public void FacetsTest()
        {
            // TODO: unit test for the property 'Facets' 
        }
        

    }

}