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
    public class FacetInfoTests
    {
        private FacetInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FacetInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FacetInfo
        /// </summary>
        [Test]
        public void FacetInfoInstanceTest()
        {
            Assert.IsInstanceOf<FacetInfo> (instance, "instance is a FacetInfo");
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
        /// Test the property 'Entries' 
        /// </summary>
        [Test]
        public void EntriesTest()
        {
            // TODO: unit test for the property 'Entries' 
        }
        

    }

}
