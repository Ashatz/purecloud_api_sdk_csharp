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
    public class DocumentThumbnailTests
    {
        private DocumentThumbnail instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DocumentThumbnail();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DocumentThumbnail
        /// </summary>
        [Test]
        public void DocumentThumbnailInstanceTest()
        {
            Assert.IsInstanceOf<DocumentThumbnail> (instance, "instance is a DocumentThumbnail");
        }

        
        /// <summary>
        /// Test the property 'Resolution' 
        /// </summary>
        [Test]
        public void ResolutionTest()
        {
            // TODO: unit test for the property 'Resolution' 
        }
        
        /// <summary>
        /// Test the property 'ImageUri' 
        /// </summary>
        [Test]
        public void ImageUriTest()
        {
            // TODO: unit test for the property 'ImageUri' 
        }
        

    }

}
