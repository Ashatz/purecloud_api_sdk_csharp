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
    public class EdgeLogsJobFileTests
    {
        private EdgeLogsJobFile instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EdgeLogsJobFile();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EdgeLogsJobFile
        /// </summary>
        [Test]
        public void EdgeLogsJobFileInstanceTest()
        {
            Assert.IsInstanceOf<EdgeLogsJobFile> (instance, "instance is a EdgeLogsJobFile");
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
        /// Test the property 'TimeCreated' 
        /// </summary>
        [Test]
        public void TimeCreatedTest()
        {
            // TODO: unit test for the property 'TimeCreated' 
        }
        
        /// <summary>
        /// Test the property 'TimeModified' 
        /// </summary>
        [Test]
        public void TimeModifiedTest()
        {
            // TODO: unit test for the property 'TimeModified' 
        }
        
        /// <summary>
        /// Test the property 'SizeBytes' 
        /// </summary>
        [Test]
        public void SizeBytesTest()
        {
            // TODO: unit test for the property 'SizeBytes' 
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
        /// Test the property 'EdgePath' 
        /// </summary>
        [Test]
        public void EdgePathTest()
        {
            // TODO: unit test for the property 'EdgePath' 
        }
        
        /// <summary>
        /// Test the property 'DownloadId' 
        /// </summary>
        [Test]
        public void DownloadIdTest()
        {
            // TODO: unit test for the property 'DownloadId' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}
