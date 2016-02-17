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
    public class FaxApiTests
    {
        private FaxApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new FaxApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FaxApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<FaxApi> (instance, "instance is a FaxApi");
        }

        
        /// <summary>
        /// Test GetDocuments
        /// </summary>
        [Test]
        public void GetDocumentsTest()
        {
            // TODO: add unit test for the method 'GetDocuments'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetDocuments(pageSize, pageNumber);
            Assert.IsInstanceOf<FaxDocumentEntityListing> (response, "response is FaxDocumentEntityListing"); 
        }
        
        /// <summary>
        /// Test GetDocument
        /// </summary>
        [Test]
        public void GetDocumentTest()
        {
            // TODO: add unit test for the method 'GetDocument'
            string documentId = null; // TODO: replace null with proper value
            
            var response = instance.GetDocument(documentId);
            Assert.IsInstanceOf<FaxDocument> (response, "response is FaxDocument"); 
        }
        
        /// <summary>
        /// Test PutDocument
        /// </summary>
        [Test]
        public void PutDocumentTest()
        {
            // TODO: add unit test for the method 'PutDocument'
            string documentId = null; // TODO: replace null with proper value
            FaxDocument body = null; // TODO: replace null with proper value
            
            var response = instance.PutDocument(documentId, body);
            Assert.IsInstanceOf<FaxDocument> (response, "response is FaxDocument"); 
        }
        
        /// <summary>
        /// Test DeleteDocument
        /// </summary>
        [Test]
        public void DeleteDocumentTest()
        {
            // TODO: add unit test for the method 'DeleteDocument'
            string documentId = null; // TODO: replace null with proper value
            
            instance.DeleteDocument(documentId);
             
        }
        
        /// <summary>
        /// Test GetDocumentContent
        /// </summary>
        [Test]
        public void GetDocumentContentTest()
        {
            // TODO: add unit test for the method 'GetDocumentContent'
            string documentId = null; // TODO: replace null with proper value
            
            var response = instance.GetDocumentContent(documentId);
            Assert.IsInstanceOf<DownloadResponse> (response, "response is DownloadResponse"); 
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
        
    }

}
