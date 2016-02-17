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
    public class FlowUploadResponseTests
    {
        private FlowUploadResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowUploadResponse();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowUploadResponse
        /// </summary>
        [Test]
        public void FlowUploadResponseInstanceTest()
        {
            Assert.IsInstanceOf<FlowUploadResponse> (instance, "instance is a FlowUploadResponse");
        }

        
        /// <summary>
        /// Test the property 'Uri' 
        /// </summary>
        [Test]
        public void UriTest()
        {
            // TODO: unit test for the property 'Uri' 
        }
        
        /// <summary>
        /// Test the property 'UploadToken' 
        /// </summary>
        [Test]
        public void UploadTokenTest()
        {
            // TODO: unit test for the property 'UploadToken' 
        }
        

    }

}