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
    public class GeolocationApiTests
    {
        private GeolocationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new GeolocationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GeolocationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<GeolocationApi> (instance, "instance is a GeolocationApi");
        }

        
        /// <summary>
        /// Test GetGeolocationsSettings
        /// </summary>
        [Test]
        public void GetGeolocationsSettingsTest()
        {
            // TODO: add unit test for the method 'GetGeolocationsSettings'
            
            var response = instance.GetGeolocationsSettings();
            Assert.IsInstanceOf<GeolocationSettings> (response, "response is GeolocationSettings"); 
        }
        
        /// <summary>
        /// Test PatchGeolocationsSettings
        /// </summary>
        [Test]
        public void PatchGeolocationsSettingsTest()
        {
            // TODO: add unit test for the method 'PatchGeolocationsSettings'
            GeolocationSettings body = null; // TODO: replace null with proper value
            
            var response = instance.PatchGeolocationsSettings(body);
            Assert.IsInstanceOf<GeolocationSettings> (response, "response is GeolocationSettings"); 
        }
        
        /// <summary>
        /// Test GetGeolocation
        /// </summary>
        [Test]
        public void GetGeolocationTest()
        {
            // TODO: add unit test for the method 'GetGeolocation'
            string userId = null; // TODO: replace null with proper value
            string clientId = null; // TODO: replace null with proper value
            
            var response = instance.GetGeolocation(userId, clientId);
            Assert.IsInstanceOf<Geolocation> (response, "response is Geolocation"); 
        }
        
        /// <summary>
        /// Test PatchGeolocation
        /// </summary>
        [Test]
        public void PatchGeolocationTest()
        {
            // TODO: add unit test for the method 'PatchGeolocation'
            string userId = null; // TODO: replace null with proper value
            string clientId = null; // TODO: replace null with proper value
            Geolocation body = null; // TODO: replace null with proper value
            
            var response = instance.PatchGeolocation(userId, clientId, body);
            Assert.IsInstanceOf<Geolocation> (response, "response is Geolocation"); 
        }
        
    }

}
