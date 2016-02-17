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
    public class OrphanedRecordingsApiTests
    {
        private OrphanedRecordingsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new OrphanedRecordingsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrphanedRecordingsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<OrphanedRecordingsApi> (instance, "instance is a OrphanedRecordingsApi");
        }

        
        /// <summary>
        /// Test GetOrphanrecordings
        /// </summary>
        [Test]
        public void GetOrphanrecordingsTest()
        {
            // TODO: add unit test for the method 'GetOrphanrecordings'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            
            var response = instance.GetOrphanrecordings(pageSize, pageNumber, sortBy, expand);
            Assert.IsInstanceOf<OrphanRecordingListing> (response, "response is OrphanRecordingListing"); 
        }
        
        /// <summary>
        /// Test GetOrphanrecording
        /// </summary>
        [Test]
        public void GetOrphanrecordingTest()
        {
            // TODO: add unit test for the method 'GetOrphanrecording'
            string orphanId = null; // TODO: replace null with proper value
            
            var response = instance.GetOrphanrecording(orphanId);
            Assert.IsInstanceOf<OrphanRecording> (response, "response is OrphanRecording"); 
        }
        
        /// <summary>
        /// Test DeleteOrphanrecording
        /// </summary>
        [Test]
        public void DeleteOrphanrecordingTest()
        {
            // TODO: add unit test for the method 'DeleteOrphanrecording'
            string orphanId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteOrphanrecording(orphanId);
            Assert.IsInstanceOf<OrphanRecording> (response, "response is OrphanRecording"); 
        }
        
    }

}
