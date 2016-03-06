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
        /// Test GetDocumentsDocumentId
        /// </summary>
        [Test]
        public void GetDocumentsDocumentIdTest()
        {
            // TODO: add unit test for the method 'GetDocumentsDocumentId'
            string documentId = null; // TODO: replace null with proper value
            
            var response = instance.GetDocumentsDocumentId(documentId);
            Assert.IsInstanceOf<FaxDocument> (response, "response is FaxDocument"); 
        }
        
        /// <summary>
        /// Test PutDocumentsDocumentId
        /// </summary>
        [Test]
        public void PutDocumentsDocumentIdTest()
        {
            // TODO: add unit test for the method 'PutDocumentsDocumentId'
            string documentId = null; // TODO: replace null with proper value
            FaxDocument body = null; // TODO: replace null with proper value
            
            var response = instance.PutDocumentsDocumentId(documentId, body);
            Assert.IsInstanceOf<FaxDocument> (response, "response is FaxDocument"); 
        }
        
        /// <summary>
        /// Test DeleteDocumentsDocumentId
        /// </summary>
        [Test]
        public void DeleteDocumentsDocumentIdTest()
        {
            // TODO: add unit test for the method 'DeleteDocumentsDocumentId'
            string documentId = null; // TODO: replace null with proper value
            
            instance.DeleteDocumentsDocumentId(documentId);
             
        }
        
        /// <summary>
        /// Test GetDocumentsDocumentIdContent
        /// </summary>
        [Test]
        public void GetDocumentsDocumentIdContentTest()
        {
            // TODO: add unit test for the method 'GetDocumentsDocumentIdContent'
            string documentId = null; // TODO: replace null with proper value
            
            var response = instance.GetDocumentsDocumentIdContent(documentId);
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
