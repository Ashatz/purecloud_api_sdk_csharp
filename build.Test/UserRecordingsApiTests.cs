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
        /// Test GetUserrecordings
        /// </summary>
        [Test]
        public void GetUserrecordingsTest()
        {
            // TODO: add unit test for the method 'GetUserrecordings'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetUserrecordings(pageSize, pageNumber, expand);
            Assert.IsInstanceOf<UserRecordingEntityListing> (response, "response is UserRecordingEntityListing"); 
        }
        
        /// <summary>
        /// Test GetUserrecordingsSummary
        /// </summary>
        [Test]
        public void GetUserrecordingsSummaryTest()
        {
            // TODO: add unit test for the method 'GetUserrecordingsSummary'
            
            var response = instance.GetUserrecordingsSummary();
            Assert.IsInstanceOf<FaxSummary> (response, "response is FaxSummary"); 
        }
        
        /// <summary>
        /// Test GetUserrecording
        /// </summary>
        [Test]
        public void GetUserrecordingTest()
        {
            // TODO: add unit test for the method 'GetUserrecording'
            string recordingId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetUserrecording(recordingId, expand);
            Assert.IsInstanceOf<UserRecording> (response, "response is UserRecording"); 
        }
        
        /// <summary>
        /// Test PutUserrecording
        /// </summary>
        [Test]
        public void PutUserrecordingTest()
        {
            // TODO: add unit test for the method 'PutUserrecording'
            string recordingId = null; // TODO: replace null with proper value
            UserRecording body = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.PutUserrecording(recordingId, body, expand);
            Assert.IsInstanceOf<UserRecording> (response, "response is UserRecording"); 
        }
        
        /// <summary>
        /// Test DeleteUserrecording
        /// </summary>
        [Test]
        public void DeleteUserrecordingTest()
        {
            // TODO: add unit test for the method 'DeleteUserrecording'
            string recordingId = null; // TODO: replace null with proper value
            
            instance.DeleteUserrecording(recordingId);
             
        }
        
        /// <summary>
        /// Test GetUserrecordingMedia
        /// </summary>
        [Test]
        public void GetUserrecordingMediaTest()
        {
            // TODO: add unit test for the method 'GetUserrecordingMedia'
            string recordingId = null; // TODO: replace null with proper value
            string formatId = null; // TODO: replace null with proper value
            
            var response = instance.GetUserrecordingMedia(recordingId, formatId);
            Assert.IsInstanceOf<DownloadResponse> (response, "response is DownloadResponse"); 
        }
        
    }

}
