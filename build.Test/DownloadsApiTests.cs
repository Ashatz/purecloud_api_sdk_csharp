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
    public class DownloadsApiTests
    {
        private DownloadsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new DownloadsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DownloadsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<DownloadsApi> (instance, "instance is a DownloadsApi");
        }

        
        /// <summary>
        /// Test GetCallback
        /// </summary>
        [Test]
        public void GetCallbackTest()
        {
            // TODO: add unit test for the method 'GetCallback'
            string code = null; // TODO: replace null with proper value
            string state = null; // TODO: replace null with proper value
            
            instance.GetCallback(code, state);
             
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            string downloadId = null; // TODO: replace null with proper value
            string contentDisposition = null; // TODO: replace null with proper value
            
            var response = instance.Get(downloadId, contentDisposition);
            Assert.IsInstanceOf<UrlResponse> (response, "response is UrlResponse"); 
        }
        
    }

}
