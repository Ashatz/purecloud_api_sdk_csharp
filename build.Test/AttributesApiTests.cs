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
    public class AttributesApiTests
    {
        private AttributesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new AttributesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AttributesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<AttributesApi> (instance, "instance is a AttributesApi");
        }

        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            
            var response = instance.Get(pageNumber, pageSize);
            Assert.IsInstanceOf<AttributeEntityListing> (response, "response is AttributeEntityListing"); 
        }
        
        /// <summary>
        /// Test Post
        /// </summary>
        [Test]
        public void PostTest()
        {
            // TODO: add unit test for the method 'Post'
            ININ.PureCloudApi.Model.Attribute body = null; // TODO: replace null with proper value
            
            var response = instance.Post(body);
            Assert.IsInstanceOf<ININ.PureCloudApi.Model.Attribute> (response, "response is ININ.PureCloudApi.Model.Attribute"); 
        }
        
        /// <summary>
        /// Test PostQuery
        /// </summary>
        [Test]
        public void PostQueryTest()
        {
            // TODO: add unit test for the method 'PostQuery'
            AttributeQueryRequest body = null; // TODO: replace null with proper value
            
            var response = instance.PostQuery(body);
            Assert.IsInstanceOf<AttributeEntityListing> (response, "response is AttributeEntityListing"); 
        }
        
        /// <summary>
        /// Test GetAttributeId
        /// </summary>
        [Test]
        public void GetAttributeIdTest()
        {
            // TODO: add unit test for the method 'GetAttributeId'
            string attributeId = null; // TODO: replace null with proper value
            
            var response = instance.GetAttributeId(attributeId);
            Assert.IsInstanceOf<ININ.PureCloudApi.Model.Attribute> (response, "response is ININ.PureCloudApi.Model.Attribute"); 
        }
        
        /// <summary>
        /// Test PutAttributeId
        /// </summary>
        [Test]
        public void PutAttributeIdTest()
        {
            // TODO: add unit test for the method 'PutAttributeId'
            string attributeId = null; // TODO: replace null with proper value
            ININ.PureCloudApi.Model.Attribute body = null; // TODO: replace null with proper value
            
            var response = instance.PutAttributeId(attributeId, body);
            Assert.IsInstanceOf<ININ.PureCloudApi.Model.Attribute> (response, "response is ININ.PureCloudApi.Model.Attribute"); 
        }
        
        /// <summary>
        /// Test DeleteAttributeId
        /// </summary>
        [Test]
        public void DeleteAttributeIdTest()
        {
            // TODO: add unit test for the method 'DeleteAttributeId'
            string attributeId = null; // TODO: replace null with proper value
            
            instance.DeleteAttributeId(attributeId);
             
        }
        
    }

}
