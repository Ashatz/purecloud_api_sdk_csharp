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
    public class FacetEntryTests
    {
        private FacetEntry instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FacetEntry();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FacetEntry
        /// </summary>
        [Test]
        public void FacetEntryInstanceTest()
        {
            Assert.IsInstanceOf<FacetEntry> (instance, "instance is a FacetEntry");
        }

        
        /// <summary>
        /// Test the property 'Attribute' 
        /// </summary>
        [Test]
        public void AttributeTest()
        {
            // TODO: unit test for the property 'Attribute' 
        }
        
        /// <summary>
        /// Test the property 'Statistics' 
        /// </summary>
        [Test]
        public void StatisticsTest()
        {
            // TODO: unit test for the property 'Statistics' 
        }
        
        /// <summary>
        /// Test the property 'Other' 
        /// </summary>
        [Test]
        public void OtherTest()
        {
            // TODO: unit test for the property 'Other' 
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
        /// Test the property 'Missing' 
        /// </summary>
        [Test]
        public void MissingTest()
        {
            // TODO: unit test for the property 'Missing' 
        }
        
        /// <summary>
        /// Test the property 'TermCount' 
        /// </summary>
        [Test]
        public void TermCountTest()
        {
            // TODO: unit test for the property 'TermCount' 
        }
        
        /// <summary>
        /// Test the property 'TermType' 
        /// </summary>
        [Test]
        public void TermTypeTest()
        {
            // TODO: unit test for the property 'TermType' 
        }
        
        /// <summary>
        /// Test the property 'Terms' 
        /// </summary>
        [Test]
        public void TermsTest()
        {
            // TODO: unit test for the property 'Terms' 
        }
        

    }

}
