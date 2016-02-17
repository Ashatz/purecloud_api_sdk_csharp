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
    public class RecordingTests
    {
        private Recording instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Recording();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Recording
        /// </summary>
        [Test]
        public void RecordingInstanceTest()
        {
            Assert.IsInstanceOf<Recording> (instance, "instance is a Recording");
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
        /// Test the property 'ConversationId' 
        /// </summary>
        [Test]
        public void ConversationIdTest()
        {
            // TODO: unit test for the property 'ConversationId' 
        }
        
        /// <summary>
        /// Test the property 'Path' 
        /// </summary>
        [Test]
        public void PathTest()
        {
            // TODO: unit test for the property 'Path' 
        }
        
        /// <summary>
        /// Test the property 'StartTime' 
        /// </summary>
        [Test]
        public void StartTimeTest()
        {
            // TODO: unit test for the property 'StartTime' 
        }
        
        /// <summary>
        /// Test the property 'EndTime' 
        /// </summary>
        [Test]
        public void EndTimeTest()
        {
            // TODO: unit test for the property 'EndTime' 
        }
        
        /// <summary>
        /// Test the property 'Media' 
        /// </summary>
        [Test]
        public void MediaTest()
        {
            // TODO: unit test for the property 'Media' 
        }
        
        /// <summary>
        /// Test the property 'MediaUri' 
        /// </summary>
        [Test]
        public void MediaUriTest()
        {
            // TODO: unit test for the property 'MediaUri' 
        }
        
        /// <summary>
        /// Test the property 'WaveUri' 
        /// </summary>
        [Test]
        public void WaveUriTest()
        {
            // TODO: unit test for the property 'WaveUri' 
        }
        
        /// <summary>
        /// Test the property 'Annotations' 
        /// </summary>
        [Test]
        public void AnnotationsTest()
        {
            // TODO: unit test for the property 'Annotations' 
        }
        
        /// <summary>
        /// Test the property 'Transcript' 
        /// </summary>
        [Test]
        public void TranscriptTest()
        {
            // TODO: unit test for the property 'Transcript' 
        }
        
        /// <summary>
        /// Test the property 'EmailTranscript' 
        /// </summary>
        [Test]
        public void EmailTranscriptTest()
        {
            // TODO: unit test for the property 'EmailTranscript' 
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
        /// Test the property 'RestoreExpirationTime' 
        /// </summary>
        [Test]
        public void RestoreExpirationTimeTest()
        {
            // TODO: unit test for the property 'RestoreExpirationTime' 
        }
        
        /// <summary>
        /// Test the property 'MediaUris' 
        /// </summary>
        [Test]
        public void MediaUrisTest()
        {
            // TODO: unit test for the property 'MediaUris' 
        }
        
        /// <summary>
        /// Test the property 'EstimatedTranscodeTimeMs' 
        /// </summary>
        [Test]
        public void EstimatedTranscodeTimeMsTest()
        {
            // TODO: unit test for the property 'EstimatedTranscodeTimeMs' 
        }
        
        /// <summary>
        /// Test the property 'ActualTranscodeTimeMs' 
        /// </summary>
        [Test]
        public void ActualTranscodeTimeMsTest()
        {
            // TODO: unit test for the property 'ActualTranscodeTimeMs' 
        }
        
        /// <summary>
        /// Test the property 'ArchiveDate' 
        /// </summary>
        [Test]
        public void ArchiveDateTest()
        {
            // TODO: unit test for the property 'ArchiveDate' 
        }
        
        /// <summary>
        /// Test the property 'ArchiveMedium' 
        /// </summary>
        [Test]
        public void ArchiveMediumTest()
        {
            // TODO: unit test for the property 'ArchiveMedium' 
        }
        
        /// <summary>
        /// Test the property 'DeleteDate' 
        /// </summary>
        [Test]
        public void DeleteDateTest()
        {
            // TODO: unit test for the property 'DeleteDate' 
        }
        
        /// <summary>
        /// Test the property 'MaxAllowedRestorationsForOrg' 
        /// </summary>
        [Test]
        public void MaxAllowedRestorationsForOrgTest()
        {
            // TODO: unit test for the property 'MaxAllowedRestorationsForOrg' 
        }
        
        /// <summary>
        /// Test the property 'RemainingRestorationsAllowedForOrg' 
        /// </summary>
        [Test]
        public void RemainingRestorationsAllowedForOrgTest()
        {
            // TODO: unit test for the property 'RemainingRestorationsAllowedForOrg' 
        }
        
        /// <summary>
        /// Test the property 'RecordingId' 
        /// </summary>
        [Test]
        public void RecordingIdTest()
        {
            // TODO: unit test for the property 'RecordingId' 
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
