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
    public class ContentFacetFilterItemTests
    {
        private ContentFacetFilterItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContentFacetFilterItem();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ContentFacetFilterItem
        /// </summary>
        [Test]
        public void ContentFacetFilterItemInstanceTest()
        {
            Assert.IsInstanceOf<ContentFacetFilterItem> (instance, "instance is a ContentFacetFilterItem");
        }

        
        /// <summary>
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        
        /// <summary>
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        
        /// <summary>
        /// Test the property 'Operator' 
        /// </summary>
        [Test]
        public void OperatorTest()
        {
            // TODO: unit test for the property 'Operator' 
        }
        
        /// <summary>
        /// Test the property 'Values' 
        /// </summary>
        [Test]
        public void ValuesTest()
        {
            // TODO: unit test for the property 'Values' 
        }
        

    }

}
