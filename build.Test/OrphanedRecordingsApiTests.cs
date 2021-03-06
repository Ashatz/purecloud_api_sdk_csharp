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
    /// <summary>
    ///  Class for testing OrphanedRecordingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
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
        /// Test DeleteOrphanId
        /// </summary>
        [Test]
        public void DeleteOrphanIdTest()
        {
            // TODO: add unit test for the method 'DeleteOrphanId'
            string orphanId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteOrphanId(orphanId);
            Assert.IsInstanceOf<OrphanRecording> (response, "response is OrphanRecording"); 
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
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            
            var response = instance.Get(pageSize, pageNumber, sortBy, expand);
            Assert.IsInstanceOf<OrphanRecordingListing> (response, "response is OrphanRecordingListing"); 
        }
        
        /// <summary>
        /// Test GetOrphanId
        /// </summary>
        [Test]
        public void GetOrphanIdTest()
        {
            // TODO: add unit test for the method 'GetOrphanId'
            string orphanId = null; // TODO: replace null with proper value
            
            var response = instance.GetOrphanId(orphanId);
            Assert.IsInstanceOf<OrphanRecording> (response, "response is OrphanRecording"); 
        }
        
    }

}
