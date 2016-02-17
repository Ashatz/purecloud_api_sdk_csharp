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
    public class FacetItemTests
    {
        private FacetItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FacetItem();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FacetItem
        /// </summary>
        [Test]
        public void FacetItemInstanceTest()
        {
            Assert.IsInstanceOf<FacetItem> (instance, "instance is a FacetItem");
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
        /// Test the property 'FilterValue' 
        /// </summary>
        [Test]
        public void FilterValueTest()
        {
            // TODO: unit test for the property 'FilterValue' 
        }
        
        /// <summary>
        /// Test the property 'Count' 
        /// </summary>
        [Test]
        public void CountTest()
        {
            // TODO: unit test for the property 'Count' 
        }
        

    }

}
