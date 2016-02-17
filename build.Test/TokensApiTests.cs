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
    public class TokensApiTests
    {
        private TokensApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new TokensApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TokensApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<TokensApi> (instance, "instance is a TokensApi");
        }

        
        /// <summary>
        /// Test DeleteMe
        /// </summary>
        [Test]
        public void DeleteMeTest()
        {
            // TODO: add unit test for the method 'DeleteMe'
            
            var response = instance.DeleteMe();
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
    }

}
