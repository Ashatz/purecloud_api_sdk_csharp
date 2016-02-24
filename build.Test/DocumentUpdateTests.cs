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
    public class DocumentUpdateTests
    {
        private DocumentUpdate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DocumentUpdate();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DocumentUpdate
        /// </summary>
        [Test]
        public void DocumentUpdateInstanceTest()
        {
            Assert.IsInstanceOf<DocumentUpdate> (instance, "instance is a DocumentUpdate");
        }

        
        /// <summary>
        /// Test the property 'ChangeNumber' 
        /// </summary>
        [Test]
        public void ChangeNumberTest()
        {
            // TODO: unit test for the property 'ChangeNumber' 
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
        /// Test the property 'Read' 
        /// </summary>
        [Test]
        public void ReadTest()
        {
            // TODO: unit test for the property 'Read' 
        }
        
        /// <summary>
        /// Test the property 'AddTags' 
        /// </summary>
        [Test]
        public void AddTagsTest()
        {
            // TODO: unit test for the property 'AddTags' 
        }
        
        /// <summary>
        /// Test the property 'RemoveTags' 
        /// </summary>
        [Test]
        public void RemoveTagsTest()
        {
            // TODO: unit test for the property 'RemoveTags' 
        }
        
        /// <summary>
        /// Test the property 'AddTagIds' 
        /// </summary>
        [Test]
        public void AddTagIdsTest()
        {
            // TODO: unit test for the property 'AddTagIds' 
        }
        
        /// <summary>
        /// Test the property 'RemoveTagIds' 
        /// </summary>
        [Test]
        public void RemoveTagIdsTest()
        {
            // TODO: unit test for the property 'RemoveTagIds' 
        }
        
        /// <summary>
        /// Test the property 'UpdateAttributes' 
        /// </summary>
        [Test]
        public void UpdateAttributesTest()
        {
            // TODO: unit test for the property 'UpdateAttributes' 
        }
        
        /// <summary>
        /// Test the property 'RemoveAttributes' 
        /// </summary>
        [Test]
        public void RemoveAttributesTest()
        {
            // TODO: unit test for the property 'RemoveAttributes' 
        }
        

    }

}
