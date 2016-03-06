using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Model;

namespace ININ.PureCloudApi.Test
{
    [TestFixture]
    public class UserRecordingsApiTests
    {
        private UserRecordingsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new UserRecordingsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserRecordingsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<UserRecordingsApi> (instance, "instance is a UserRecordingsApi");
        }

        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.Get(pageSize, pageNumber, expand);
            Assert.IsInstanceOf<UserRecordingEntityListing> (response, "response is UserRecordingEntityListing"); 
        }
        
        /// <summary>
        /// Test GetSummary
        /// </summary>
        [Test]
        public void GetSummaryTest()
        {
            // TODO: add unit test for the method 'GetSummary'
            
            var response = instance.GetSummary();
            Assert.IsInstanceOf<FaxSummary> (response, "response is FaxSummary"); 
        }
        
        /// <summary>
        /// Test GetRecordingId
        /// </summary>
        [Test]
        public void GetRecordingIdTest()
        {
            // TODO: add unit test for the method 'GetRecordingId'
            string recordingId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetRecordingId(recordingId, expand);
            Assert.IsInstanceOf<UserRecording> (response, "response is UserRecording"); 
        }
        
        /// <summary>
        /// Test PutRecordingId
        /// </summary>
        [Test]
        public void PutRecordingIdTest()
        {
            // TODO: add unit test for the method 'PutRecordingId'
            string recordingId = null; // TODO: replace null with proper value
            UserRecording body = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.PutRecordingId(recordingId, body, expand);
            Assert.IsInstanceOf<UserRecording> (response, "response is UserRecording"); 
        }
        
        /// <summary>
        /// Test DeleteRecordingId
        /// </summary>
        [Test]
        public void DeleteRecordingIdTest()
        {
            // TODO: add unit test for the method 'DeleteRecordingId'
            string recordingId = null; // TODO: replace null with proper value
            
            instance.DeleteRecordingId(recordingId);
             
        }
        
        /// <summary>
        /// Test GetRecordingIdMedia
        /// </summary>
        [Test]
        public void GetRecordingIdMediaTest()
        {
            // TODO: add unit test for the method 'GetRecordingIdMedia'
            string recordingId = null; // TODO: replace null with proper value
            string formatId = null; // TODO: replace null with proper value
            
            var response = instance.GetRecordingIdMedia(recordingId, formatId);
            Assert.IsInstanceOf<DownloadResponse> (response, "response is DownloadResponse"); 
        }
        
    }

}
