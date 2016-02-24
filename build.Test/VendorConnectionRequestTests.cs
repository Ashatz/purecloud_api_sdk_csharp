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
    public class VendorConnectionRequestTests
    {
        private VendorConnectionRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VendorConnectionRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of VendorConnectionRequest
        /// </summary>
        [Test]
        public void VendorConnectionRequestInstanceTest()
        {
            Assert.IsInstanceOf<VendorConnectionRequest> (instance, "instance is a VendorConnectionRequest");
        }

        
        /// <summary>
        /// Test the property 'Publisher' 
        /// </summary>
        [Test]
        public void PublisherTest()
        {
            // TODO: unit test for the property 'Publisher' 
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
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        

    }

}
