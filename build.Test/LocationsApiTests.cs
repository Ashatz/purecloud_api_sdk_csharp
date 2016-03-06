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
    public class LocationsApiTests
    {
        private LocationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new LocationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LocationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<LocationsApi> (instance, "instance is a LocationsApi");
        }

        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            string state = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.Get(state, name, pageSize, pageNumber);
            Assert.IsInstanceOf<LocationEntityListing> (response, "response is LocationEntityListing"); 
        }
        
        /// <summary>
        /// Test GetLocationId
        /// </summary>
        [Test]
        public void GetLocationIdTest()
        {
            // TODO: add unit test for the method 'GetLocationId'
            string locationId = null; // TODO: replace null with proper value
            
            var response = instance.GetLocationId(locationId);
            Assert.IsInstanceOf<Location> (response, "response is Location"); 
        }
        
    }

}
