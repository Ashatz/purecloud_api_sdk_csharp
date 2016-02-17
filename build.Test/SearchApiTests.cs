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
    public class SearchApiTests
    {
        private SearchApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new SearchApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SearchApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<SearchApi> (instance, "instance is a SearchApi");
        }

        
        /// <summary>
        /// Test PostChats
        /// </summary>
        [Test]
        public void PostChatsTest()
        {
            // TODO: add unit test for the method 'PostChats'
            ChatSearchRequest body = null; // TODO: replace null with proper value
            
            var response = instance.PostChats(body);
            Assert.IsInstanceOf<ChatSearchListing> (response, "response is ChatSearchListing"); 
        }
        
    }

}
