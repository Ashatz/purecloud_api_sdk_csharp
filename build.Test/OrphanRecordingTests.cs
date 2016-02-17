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
    public class OrphanRecordingTests
    {
        private OrphanRecording instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrphanRecording();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of OrphanRecording
        /// </summary>
        [Test]
        public void OrphanRecordingInstanceTest()
        {
            Assert.IsInstanceOf<OrphanRecording> (instance, "instance is a OrphanRecording");
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
        /// Test the property 'CreatedTime' 
        /// </summary>
        [Test]
        public void CreatedTimeTest()
        {
            // TODO: unit test for the property 'CreatedTime' 
        }
        
        /// <summary>
        /// Test the property 'RecoveredTime' 
        /// </summary>
        [Test]
        public void RecoveredTimeTest()
        {
            // TODO: unit test for the property 'RecoveredTime' 
        }
        
        /// <summary>
        /// Test the property 'ProviderType' 
        /// </summary>
        [Test]
        public void ProviderTypeTest()
        {
            // TODO: unit test for the property 'ProviderType' 
        }
        
        /// <summary>
        /// Test the property 'MediaSizeBytes' 
        /// </summary>
        [Test]
        public void MediaSizeBytesTest()
        {
            // TODO: unit test for the property 'MediaSizeBytes' 
        }
        
        /// <summary>
        /// Test the property 'MediaType' 
        /// </summary>
        [Test]
        public void MediaTypeTest()
        {
            // TODO: unit test for the property 'MediaType' 
        }
        
        /// <summary>
        /// Test the property 'FileState' 
        /// </summary>
        [Test]
        public void FileStateTest()
        {
            // TODO: unit test for the property 'FileState' 
        }
        
        /// <summary>
        /// Test the property 'ProviderEndpoint' 
        /// </summary>
        [Test]
        public void ProviderEndpointTest()
        {
            // TODO: unit test for the property 'ProviderEndpoint' 
        }
        
        /// <summary>
        /// Test the property 'Recording' 
        /// </summary>
        [Test]
        public void RecordingTest()
        {
            // TODO: unit test for the property 'Recording' 
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
