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
    public class AuditSearchResultTests
    {
        private AuditSearchResult instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuditSearchResult();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AuditSearchResult
        /// </summary>
        [Test]
        public void AuditSearchResultInstanceTest()
        {
            Assert.IsInstanceOf<AuditSearchResult> (instance, "instance is a AuditSearchResult");
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
        /// Test the property 'Total' 
        /// </summary>
        [Test]
        public void TotalTest()
        {
            // TODO: unit test for the property 'Total' 
        }
        
        /// <summary>
        /// Test the property 'PageCount' 
        /// </summary>
        [Test]
        public void PageCountTest()
        {
            // TODO: unit test for the property 'PageCount' 
        }
        
        /// <summary>
        /// Test the property 'FacetInfo' 
        /// </summary>
        [Test]
        public void FacetInfoTest()
        {
            // TODO: unit test for the property 'FacetInfo' 
        }
        
        /// <summary>
        /// Test the property 'AuditMessages' 
        /// </summary>
        [Test]
        public void AuditMessagesTest()
        {
            // TODO: unit test for the property 'AuditMessages' 
        }
        

    }

}
