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
    public class UtilitiesApiTests
    {
        private UtilitiesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new UtilitiesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UtilitiesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<UtilitiesApi> (instance, "instance is a UtilitiesApi");
        }

        
        /// <summary>
        /// Test PostDetails
        /// </summary>
        [Test]
        public void PostDetailsTest()
        {
            // TODO: add unit test for the method 'PostDetails'
            Certificate body = null; // TODO: replace null with proper value
            
            var response = instance.PostDetails(body);
            Assert.IsInstanceOf<ParsedCertificate> (response, "response is ParsedCertificate"); 
        }
        
        /// <summary>
        /// Test PostAddressvalidation
        /// </summary>
        [Test]
        public void PostAddressvalidationTest()
        {
            // TODO: add unit test for the method 'PostAddressvalidation'
            ValidateAddressRequest body = null; // TODO: replace null with proper value
            
            var response = instance.PostAddressvalidation(body);
            Assert.IsInstanceOf<ValidateAddressResponse> (response, "response is ValidateAddressResponse"); 
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            
            var response = instance.Get();
            Assert.IsInstanceOf<ServerDate> (response, "response is ServerDate"); 
        }
        
        /// <summary>
        /// Test GetCheck
        /// </summary>
        [Test]
        public void GetCheckTest()
        {
            // TODO: add unit test for the method 'GetCheck'
            
            var response = instance.GetCheck();
            Assert.IsInstanceOf<HealthCheckInfo> (response, "response is HealthCheckInfo"); 
        }
        
        /// <summary>
        /// Test Get_0
        /// </summary>
        [Test]
        public void Get_0Test()
        {
            // TODO: add unit test for the method 'Get_0'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.Get_0(pageSize, pageNumber);
            Assert.IsInstanceOf<TimeZoneEntityListing> (response, "response is TimeZoneEntityListing"); 
        }
        
    }

}
