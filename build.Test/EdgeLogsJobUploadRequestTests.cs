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
    public class EdgeLogsJobUploadRequestTests
    {
        private EdgeLogsJobUploadRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EdgeLogsJobUploadRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EdgeLogsJobUploadRequest
        /// </summary>
        [Test]
        public void EdgeLogsJobUploadRequestInstanceTest()
        {
            Assert.IsInstanceOf<EdgeLogsJobUploadRequest> (instance, "instance is a EdgeLogsJobUploadRequest");
        }

        
        /// <summary>
        /// Test the property 'FileIds' 
        /// </summary>
        [Test]
        public void FileIdsTest()
        {
            // TODO: unit test for the property 'FileIds' 
        }
        

    }

}
