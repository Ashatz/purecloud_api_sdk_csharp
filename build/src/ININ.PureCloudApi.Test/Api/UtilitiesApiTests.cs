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
    ///  Class for testing UtilitiesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
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
        /// Test GetDate
        /// </summary>
        [Test]
        public void GetDateTest()
        {
            // TODO: add unit test for the method 'GetDate'
            var response = instance.GetDate();
            Assert.IsInstanceOf<ServerDate> (response, "response is ServerDate");
        }
        
        /// <summary>
        /// Test GetTimezones
        /// </summary>
        [Test]
        public void GetTimezonesTest()
        {
            // TODO: add unit test for the method 'GetTimezones'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            var response = instance.GetTimezones(pageSize, pageNumber);
            Assert.IsInstanceOf<TimeZoneEntityListing> (response, "response is TimeZoneEntityListing");
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
        
    }

}
