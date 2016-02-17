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
    public class ComplianceApiTests
    {
        private ComplianceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new ComplianceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ComplianceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<ComplianceApi> (instance, "instance is a ComplianceApi");
        }

        
        /// <summary>
        /// Test GetHipaa
        /// </summary>
        [Test]
        public void GetHipaaTest()
        {
            // TODO: add unit test for the method 'GetHipaa'
            
            var response = instance.GetHipaa();
            Assert.IsInstanceOf<HIPAAConfig> (response, "response is HIPAAConfig"); 
        }
        
        /// <summary>
        /// Test PutHipaa
        /// </summary>
        [Test]
        public void PutHipaaTest()
        {
            // TODO: add unit test for the method 'PutHipaa'
            HIPAAConfig body = null; // TODO: replace null with proper value
            
            var response = instance.PutHipaa(body);
            Assert.IsInstanceOf<HIPAAConfig> (response, "response is HIPAAConfig"); 
        }
        
    }

}
