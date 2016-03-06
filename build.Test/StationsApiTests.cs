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
    public class StationsApiTests
    {
        private StationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new StationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<StationsApi> (instance, "instance is a StationsApi");
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
            string sortBy = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            
            var response = instance.Get(pageSize, pageNumber, sortBy, name);
            Assert.IsInstanceOf<StationEntityListing> (response, "response is StationEntityListing"); 
        }
        
        /// <summary>
        /// Test GetId
        /// </summary>
        [Test]
        public void GetIdTest()
        {
            // TODO: add unit test for the method 'GetId'
            string id = null; // TODO: replace null with proper value
            
            var response = instance.GetId(id);
            Assert.IsInstanceOf<Station> (response, "response is Station"); 
        }
        
        /// <summary>
        /// Test DeleteIdAssociateduser
        /// </summary>
        [Test]
        public void DeleteIdAssociateduserTest()
        {
            // TODO: add unit test for the method 'DeleteIdAssociateduser'
            string id = null; // TODO: replace null with proper value
            
            var response = instance.DeleteIdAssociateduser(id);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
    }

}
