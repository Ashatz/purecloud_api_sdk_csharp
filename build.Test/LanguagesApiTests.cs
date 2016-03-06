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
    public class LanguagesApiTests
    {
        private LanguagesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new LanguagesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LanguagesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<LanguagesApi> (instance, "instance is a LanguagesApi");
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
            
            var response = instance.Get(pageSize, pageNumber);
            Assert.IsInstanceOf<LanguageEntityListing> (response, "response is LanguageEntityListing"); 
        }
        
        /// <summary>
        /// Test GetLanguageId
        /// </summary>
        [Test]
        public void GetLanguageIdTest()
        {
            // TODO: add unit test for the method 'GetLanguageId'
            string languageId = null; // TODO: replace null with proper value
            
            var response = instance.GetLanguageId(languageId);
            Assert.IsInstanceOf<Language> (response, "response is Language"); 
        }
        
    }

}
