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
    public class FacetsTests
    {
        private Facets instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Facets();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Facets
        /// </summary>
        [Test]
        public void FacetsInstanceTest()
        {
            Assert.IsInstanceOf<Facets> (instance, "instance is a Facets");
        }

        
        /// <summary>
        /// Test the property 'Count' 
        /// </summary>
        [Test]
        public void CountTest()
        {
            // TODO: unit test for the property 'Count' 
        }
        
        /// <summary>
        /// Test the property 'FacetGroups' 
        /// </summary>
        [Test]
        public void FacetGroupsTest()
        {
            // TODO: unit test for the property 'FacetGroups' 
        }
        

    }

}
