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
    public class ResponseManagementApiTests
    {
        private ResponseManagementApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new ResponseManagementApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ResponseManagementApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<ResponseManagementApi> (instance, "instance is a ResponseManagementApi");
        }

        
        /// <summary>
        /// Test GetLibraries
        /// </summary>
        [Test]
        public void GetLibrariesTest()
        {
            // TODO: add unit test for the method 'GetLibraries'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            
            var response = instance.GetLibraries(pageNumber, pageSize);
            Assert.IsInstanceOf<LibraryEntityListing> (response, "response is LibraryEntityListing"); 
        }
        
        /// <summary>
        /// Test PostLibraries
        /// </summary>
        [Test]
        public void PostLibrariesTest()
        {
            // TODO: add unit test for the method 'PostLibraries'
            Library body = null; // TODO: replace null with proper value
            
            var response = instance.PostLibraries(body);
            Assert.IsInstanceOf<Library> (response, "response is Library"); 
        }
        
        /// <summary>
        /// Test GetLibrariesLibraryId
        /// </summary>
        [Test]
        public void GetLibrariesLibraryIdTest()
        {
            // TODO: add unit test for the method 'GetLibrariesLibraryId'
            string libraryId = null; // TODO: replace null with proper value
            
            var response = instance.GetLibrariesLibraryId(libraryId);
            Assert.IsInstanceOf<Library> (response, "response is Library"); 
        }
        
        /// <summary>
        /// Test PutLibrariesLibraryId
        /// </summary>
        [Test]
        public void PutLibrariesLibraryIdTest()
        {
            // TODO: add unit test for the method 'PutLibrariesLibraryId'
            string libraryId = null; // TODO: replace null with proper value
            Library body = null; // TODO: replace null with proper value
            
            var response = instance.PutLibrariesLibraryId(libraryId, body);
            Assert.IsInstanceOf<Library> (response, "response is Library"); 
        }
        
        /// <summary>
        /// Test DeleteLibrariesLibraryId
        /// </summary>
        [Test]
        public void DeleteLibrariesLibraryIdTest()
        {
            // TODO: add unit test for the method 'DeleteLibrariesLibraryId'
            string libraryId = null; // TODO: replace null with proper value
            
            instance.DeleteLibrariesLibraryId(libraryId);
             
        }
        
        /// <summary>
        /// Test GetResponses
        /// </summary>
        [Test]
        public void GetResponsesTest()
        {
            // TODO: add unit test for the method 'GetResponses'
            string libraryId = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            
            var response = instance.GetResponses(libraryId, pageNumber, pageSize);
            Assert.IsInstanceOf<ResponseEntityListing> (response, "response is ResponseEntityListing"); 
        }
        
        /// <summary>
        /// Test PostResponses
        /// </summary>
        [Test]
        public void PostResponsesTest()
        {
            // TODO: add unit test for the method 'PostResponses'
            Response body = null; // TODO: replace null with proper value
            
            var response = instance.PostResponses(body);
            Assert.IsInstanceOf<Response> (response, "response is Response"); 
        }
        
        /// <summary>
        /// Test PostResponsesQuery
        /// </summary>
        [Test]
        public void PostResponsesQueryTest()
        {
            // TODO: add unit test for the method 'PostResponsesQuery'
            ResponseQueryRequest body = null; // TODO: replace null with proper value
            
            var response = instance.PostResponsesQuery(body);
            Assert.IsInstanceOf<ResponseQueryResults> (response, "response is ResponseQueryResults"); 
        }
        
        /// <summary>
        /// Test GetResponsesResponseId
        /// </summary>
        [Test]
        public void GetResponsesResponseIdTest()
        {
            // TODO: add unit test for the method 'GetResponsesResponseId'
            string responseId = null; // TODO: replace null with proper value
            
            var response = instance.GetResponsesResponseId(responseId);
            Assert.IsInstanceOf<Response> (response, "response is Response"); 
        }
        
        /// <summary>
        /// Test PutResponsesResponseId
        /// </summary>
        [Test]
        public void PutResponsesResponseIdTest()
        {
            // TODO: add unit test for the method 'PutResponsesResponseId'
            string responseId = null; // TODO: replace null with proper value
            Response body = null; // TODO: replace null with proper value
            
            var response = instance.PutResponsesResponseId(responseId, body);
            Assert.IsInstanceOf<Response> (response, "response is Response"); 
        }
        
        /// <summary>
        /// Test DeleteResponsesResponseId
        /// </summary>
        [Test]
        public void DeleteResponsesResponseIdTest()
        {
            // TODO: add unit test for the method 'DeleteResponsesResponseId'
            string responseId = null; // TODO: replace null with proper value
            
            instance.DeleteResponsesResponseId(responseId);
             
        }
        
    }

}
