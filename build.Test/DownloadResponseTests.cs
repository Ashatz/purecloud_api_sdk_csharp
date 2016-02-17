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
    public class DownloadResponseTests
    {
        private DownloadResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DownloadResponse();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DownloadResponse
        /// </summary>
        [Test]
        public void DownloadResponseInstanceTest()
        {
            Assert.IsInstanceOf<DownloadResponse> (instance, "instance is a DownloadResponse");
        }

        
        /// <summary>
        /// Test the property 'ContentLocationUri' 
        /// </summary>
        [Test]
        public void ContentLocationUriTest()
        {
            // TODO: unit test for the property 'ContentLocationUri' 
        }
        
        /// <summary>
        /// Test the property 'ImageUri' 
        /// </summary>
        [Test]
        public void ImageUriTest()
        {
            // TODO: unit test for the property 'ImageUri' 
        }
        

    }

}
