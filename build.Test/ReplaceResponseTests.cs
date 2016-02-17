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
    public class ReplaceResponseTests
    {
        private ReplaceResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReplaceResponse();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ReplaceResponse
        /// </summary>
        [Test]
        public void ReplaceResponseInstanceTest()
        {
            Assert.IsInstanceOf<ReplaceResponse> (instance, "instance is a ReplaceResponse");
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
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        
        /// <summary>
        /// Test the property 'ChangeNumber' 
        /// </summary>
        [Test]
        public void ChangeNumberTest()
        {
            // TODO: unit test for the property 'ChangeNumber' 
        }
        
        /// <summary>
        /// Test the property 'UploadStatus' 
        /// </summary>
        [Test]
        public void UploadStatusTest()
        {
            // TODO: unit test for the property 'UploadStatus' 
        }
        
        /// <summary>
        /// Test the property 'UploadDestinationUri' 
        /// </summary>
        [Test]
        public void UploadDestinationUriTest()
        {
            // TODO: unit test for the property 'UploadDestinationUri' 
        }
        
        /// <summary>
        /// Test the property 'UploadMethod' 
        /// </summary>
        [Test]
        public void UploadMethodTest()
        {
            // TODO: unit test for the property 'UploadMethod' 
        }
        

    }

}
