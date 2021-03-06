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
    /// <summary>
    ///  Class for testing SuggestApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SuggestApiTests
    {
        private SuggestApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SuggestApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SuggestApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<SuggestApi> (instance, "instance is a SuggestApi");
        }

        
        /// <summary>
        /// Test GetSearch
        /// </summary>
        [Test]
        public void GetSearchTest()
        {
            // TODO: add unit test for the method 'GetSearch'
            string q64 = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            bool? profile = null; // TODO: replace null with proper value
            var response = instance.GetSearch(q64, expand, profile);
            Assert.IsInstanceOf<JsonNodeSearchResponse> (response, "response is JsonNodeSearchResponse");
        }
        
        /// <summary>
        /// Test GetSuggest
        /// </summary>
        [Test]
        public void GetSuggestTest()
        {
            // TODO: add unit test for the method 'GetSuggest'
            string q64 = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            bool? profile = null; // TODO: replace null with proper value
            var response = instance.GetSuggest(q64, expand, profile);
            Assert.IsInstanceOf<JsonNodeSearchResponse> (response, "response is JsonNodeSearchResponse");
        }
        
        /// <summary>
        /// Test PostSearch
        /// </summary>
        [Test]
        public void PostSearchTest()
        {
            // TODO: add unit test for the method 'PostSearch'
            SearchRequest body = null; // TODO: replace null with proper value
            bool? profile = null; // TODO: replace null with proper value
            var response = instance.PostSearch(body, profile);
            Assert.IsInstanceOf<JsonNodeSearchResponse> (response, "response is JsonNodeSearchResponse");
        }
        
        /// <summary>
        /// Test PostSuggest
        /// </summary>
        [Test]
        public void PostSuggestTest()
        {
            // TODO: add unit test for the method 'PostSuggest'
            SuggestSearchRequest body = null; // TODO: replace null with proper value
            bool? profile = null; // TODO: replace null with proper value
            var response = instance.PostSuggest(body, profile);
            Assert.IsInstanceOf<JsonNodeSearchResponse> (response, "response is JsonNodeSearchResponse");
        }
        
    }

}
