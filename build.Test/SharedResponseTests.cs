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
    public class SharedResponseTests
    {
        private SharedResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SharedResponse();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SharedResponse
        /// </summary>
        [Test]
        public void SharedResponseInstanceTest()
        {
            Assert.IsInstanceOf<SharedResponse> (instance, "instance is a SharedResponse");
        }

        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        
        /// <summary>
        /// Test the property 'DownloadUri' 
        /// </summary>
        [Test]
        public void DownloadUriTest()
        {
            // TODO: unit test for the property 'DownloadUri' 
        }
        
        /// <summary>
        /// Test the property 'ViewUri' 
        /// </summary>
        [Test]
        public void ViewUriTest()
        {
            // TODO: unit test for the property 'ViewUri' 
        }
        
        /// <summary>
        /// Test the property 'Document' 
        /// </summary>
        [Test]
        public void DocumentTest()
        {
            // TODO: unit test for the property 'Document' 
        }
        
        /// <summary>
        /// Test the property 'Share' 
        /// </summary>
        [Test]
        public void ShareTest()
        {
            // TODO: unit test for the property 'Share' 
        }
        

    }

}
