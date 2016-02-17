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
    public class FaxDocumentTests
    {
        private FaxDocument instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FaxDocument();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FaxDocument
        /// </summary>
        [Test]
        public void FaxDocumentInstanceTest()
        {
            Assert.IsInstanceOf<FaxDocument> (instance, "instance is a FaxDocument");
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
        /// Test the property 'DateCreated' 
        /// </summary>
        [Test]
        public void DateCreatedTest()
        {
            // TODO: unit test for the property 'DateCreated' 
        }
        
        /// <summary>
        /// Test the property 'DateModified' 
        /// </summary>
        [Test]
        public void DateModifiedTest()
        {
            // TODO: unit test for the property 'DateModified' 
        }
        
        /// <summary>
        /// Test the property 'ContentUri' 
        /// </summary>
        [Test]
        public void ContentUriTest()
        {
            // TODO: unit test for the property 'ContentUri' 
        }
        
        /// <summary>
        /// Test the property 'Workspace' 
        /// </summary>
        [Test]
        public void WorkspaceTest()
        {
            // TODO: unit test for the property 'Workspace' 
        }
        
        /// <summary>
        /// Test the property 'CreatedBy' 
        /// </summary>
        [Test]
        public void CreatedByTest()
        {
            // TODO: unit test for the property 'CreatedBy' 
        }
        
        /// <summary>
        /// Test the property 'ContentType' 
        /// </summary>
        [Test]
        public void ContentTypeTest()
        {
            // TODO: unit test for the property 'ContentType' 
        }
        
        /// <summary>
        /// Test the property 'ContentLength' 
        /// </summary>
        [Test]
        public void ContentLengthTest()
        {
            // TODO: unit test for the property 'ContentLength' 
        }
        
        /// <summary>
        /// Test the property 'Filename' 
        /// </summary>
        [Test]
        public void FilenameTest()
        {
            // TODO: unit test for the property 'Filename' 
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
        /// Test the property 'PageCount' 
        /// </summary>
        [Test]
        public void PageCountTest()
        {
            // TODO: unit test for the property 'PageCount' 
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
        /// Test the property 'ReceiverAddress' 
        /// </summary>
        [Test]
        public void ReceiverAddressTest()
        {
            // TODO: unit test for the property 'ReceiverAddress' 
        }
        
        /// <summary>
        /// Test the property 'Thumbnails' 
        /// </summary>
        [Test]
        public void ThumbnailsTest()
        {
            // TODO: unit test for the property 'Thumbnails' 
        }
        
        /// <summary>
        /// Test the property 'SharingUri' 
        /// </summary>
        [Test]
        public void SharingUriTest()
        {
            // TODO: unit test for the property 'SharingUri' 
        }
        
        /// <summary>
        /// Test the property 'DownloadSharingUri' 
        /// </summary>
        [Test]
        public void DownloadSharingUriTest()
        {
            // TODO: unit test for the property 'DownloadSharingUri' 
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