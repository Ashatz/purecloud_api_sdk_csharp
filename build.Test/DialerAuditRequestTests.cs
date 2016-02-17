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
    public class DialerAuditRequestTests
    {
        private DialerAuditRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DialerAuditRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DialerAuditRequest
        /// </summary>
        [Test]
        public void DialerAuditRequestInstanceTest()
        {
            Assert.IsInstanceOf<DialerAuditRequest> (instance, "instance is a DialerAuditRequest");
        }

        
        /// <summary>
        /// Test the property 'QueryPhrase' 
        /// </summary>
        [Test]
        public void QueryPhraseTest()
        {
            // TODO: unit test for the property 'QueryPhrase' 
        }
        
        /// <summary>
        /// Test the property 'QueryFields' 
        /// </summary>
        [Test]
        public void QueryFieldsTest()
        {
            // TODO: unit test for the property 'QueryFields' 
        }
        
        /// <summary>
        /// Test the property 'Facets' 
        /// </summary>
        [Test]
        public void FacetsTest()
        {
            // TODO: unit test for the property 'Facets' 
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
