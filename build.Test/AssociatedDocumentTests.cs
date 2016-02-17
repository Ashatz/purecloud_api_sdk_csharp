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
    public class AssociatedDocumentTests
    {
        private AssociatedDocument instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AssociatedDocument();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AssociatedDocument
        /// </summary>
        [Test]
        public void AssociatedDocumentInstanceTest()
        {
            Assert.IsInstanceOf<AssociatedDocument> (instance, "instance is a AssociatedDocument");
        }

        
        /// <summary>
        /// Test the property 'Document' 
        /// </summary>
        [Test]
        public void DocumentTest()
        {
            // TODO: unit test for the property 'Document' 
        }
        
        /// <summary>
        /// Test the property 'DocumentAssociationType' 
        /// </summary>
        [Test]
        public void DocumentAssociationTypeTest()
        {
            // TODO: unit test for the property 'DocumentAssociationType' 
        }
        

    }

}
