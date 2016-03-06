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
    public class RecordingApiTests
    {
        private RecordingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new RecordingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RecordingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<RecordingApi> (instance, "instance is a RecordingApi");
        }

        
        /// <summary>
        /// Test GetSettings
        /// </summary>
        [Test]
        public void GetSettingsTest()
        {
            // TODO: add unit test for the method 'GetSettings'
            bool? createDefault = null; // TODO: replace null with proper value
            
            var response = instance.GetSettings(createDefault);
            Assert.IsInstanceOf<RecordingConfiguration> (response, "response is RecordingConfiguration"); 
        }
        
        /// <summary>
        /// Test PutSettings
        /// </summary>
        [Test]
        public void PutSettingsTest()
        {
            // TODO: add unit test for the method 'PutSettings'
            RecordingConfiguration body = null; // TODO: replace null with proper value
            
            var response = instance.PutSettings(body);
            Assert.IsInstanceOf<RecordingConfiguration> (response, "response is RecordingConfiguration"); 
        }
        
    }

}
