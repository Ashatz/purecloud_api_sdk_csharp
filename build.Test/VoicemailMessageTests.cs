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
    public class VoicemailMessageTests
    {
        private VoicemailMessage instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VoicemailMessage();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of VoicemailMessage
        /// </summary>
        [Test]
        public void VoicemailMessageInstanceTest()
        {
            Assert.IsInstanceOf<VoicemailMessage> (instance, "instance is a VoicemailMessage");
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
        /// Test the property 'Conversation' 
        /// </summary>
        [Test]
        public void ConversationTest()
        {
            // TODO: unit test for the property 'Conversation' 
        }
        
        /// <summary>
        /// Test the property 'Read' 
        /// </summary>
        [Test]
        public void ReadTest()
        {
            // TODO: unit test for the property 'Read' 
        }
        
        /// <summary>
        /// Test the property 'AudioRecordingDurationSeconds' 
        /// </summary>
        [Test]
        public void AudioRecordingDurationSecondsTest()
        {
            // TODO: unit test for the property 'AudioRecordingDurationSeconds' 
        }
        
        /// <summary>
        /// Test the property 'AudioRecordingSizeBytes' 
        /// </summary>
        [Test]
        public void AudioRecordingSizeBytesTest()
        {
            // TODO: unit test for the property 'AudioRecordingSizeBytes' 
        }
        
        /// <summary>
        /// Test the property 'CreatedDate' 
        /// </summary>
        [Test]
        public void CreatedDateTest()
        {
            // TODO: unit test for the property 'CreatedDate' 
        }
        
        /// <summary>
        /// Test the property 'ModifiedDate' 
        /// </summary>
        [Test]
        public void ModifiedDateTest()
        {
            // TODO: unit test for the property 'ModifiedDate' 
        }
        
        /// <summary>
        /// Test the property 'CallerAddress' 
        /// </summary>
        [Test]
        public void CallerAddressTest()
        {
            // TODO: unit test for the property 'CallerAddress' 
        }
        
        /// <summary>
        /// Test the property 'CallerName' 
        /// </summary>
        [Test]
        public void CallerNameTest()
        {
            // TODO: unit test for the property 'CallerName' 
        }
        
        /// <summary>
        /// Test the property 'CallerUser' 
        /// </summary>
        [Test]
        public void CallerUserTest()
        {
            // TODO: unit test for the property 'CallerUser' 
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
