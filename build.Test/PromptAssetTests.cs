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
    public class PromptAssetTests
    {
        private PromptAsset instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PromptAsset();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PromptAsset
        /// </summary>
        [Test]
        public void PromptAssetInstanceTest()
        {
            Assert.IsInstanceOf<PromptAsset> (instance, "instance is a PromptAsset");
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
        /// Test the property 'PromptId' 
        /// </summary>
        [Test]
        public void PromptIdTest()
        {
            // TODO: unit test for the property 'PromptId' 
        }
        
        /// <summary>
        /// Test the property 'Language' 
        /// </summary>
        [Test]
        public void LanguageTest()
        {
            // TODO: unit test for the property 'Language' 
        }
        
        /// <summary>
        /// Test the property 'MediaUri' 
        /// </summary>
        [Test]
        public void MediaUriTest()
        {
            // TODO: unit test for the property 'MediaUri' 
        }
        
        /// <summary>
        /// Test the property 'TtsString' 
        /// </summary>
        [Test]
        public void TtsStringTest()
        {
            // TODO: unit test for the property 'TtsString' 
        }
        
        /// <summary>
        /// Test the property 'UploadStatus' 
        /// </summary>
        [Test]
        public void UploadStatusTest()
        {
            // TODO: unit test for the property 'UploadStatus' 
        }
        
        /// <summary>
        /// Test the property 'UploadUri' 
        /// </summary>
        [Test]
        public void UploadUriTest()
        {
            // TODO: unit test for the property 'UploadUri' 
        }
        
        /// <summary>
        /// Test the property 'DurationSeconds' 
        /// </summary>
        [Test]
        public void DurationSecondsTest()
        {
            // TODO: unit test for the property 'DurationSeconds' 
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
