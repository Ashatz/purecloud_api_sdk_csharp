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
    public class TextTableTransformTests
    {
        private TextTableTransform instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TextTableTransform();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TextTableTransform
        /// </summary>
        [Test]
        public void TextTableTransformInstanceTest()
        {
            Assert.IsInstanceOf<TextTableTransform> (instance, "instance is a TextTableTransform");
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
        /// Test the property 'RestEndpoint' 
        /// </summary>
        [Test]
        public void RestEndpointTest()
        {
            // TODO: unit test for the property 'RestEndpoint' 
        }
        
        /// <summary>
        /// Test the property 'FilenameTransforms' 
        /// </summary>
        [Test]
        public void FilenameTransformsTest()
        {
            // TODO: unit test for the property 'FilenameTransforms' 
        }
        
        /// <summary>
        /// Test the property 'Tags' 
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO: unit test for the property 'Tags' 
        }
        
        /// <summary>
        /// Test the property 'CommentSymbol' 
        /// </summary>
        [Test]
        public void CommentSymbolTest()
        {
            // TODO: unit test for the property 'CommentSymbol' 
        }
        
        /// <summary>
        /// Test the property 'Delimiter' 
        /// </summary>
        [Test]
        public void DelimiterTest()
        {
            // TODO: unit test for the property 'Delimiter' 
        }
        
        /// <summary>
        /// Test the property 'Table' 
        /// </summary>
        [Test]
        public void TableTest()
        {
            // TODO: unit test for the property 'Table' 
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
