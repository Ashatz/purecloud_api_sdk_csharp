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
        /// Test GetAttributes
        /// </summary>
        [Test]
        public void GetAttributesTest()
        {
            // TODO: add unit test for the method 'GetAttributes'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            
            var response = instance.GetAttributes(pageNumber, pageSize);
            Assert.IsInstanceOf<AttributeEntityListing> (response, "response is AttributeEntityListing"); 
        }
        
        /// <summary>
        /// Test PostAttributes
        /// </summary>
        [Test]
        public void PostAttributesTest()
        {
            // TODO: add unit test for the method 'PostAttributes'
            ININ.PureCloudApi.Model.Attribute body = null; // TODO: replace null with proper value
            
            var response = instance.PostAttributes(body);
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
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            string attributeId = null; // TODO: replace null with proper value
            
            var response = instance.Get(attributeId);
            Assert.IsInstanceOf<ININ.PureCloudApi.Model.Attribute> (response, "response is ININ.PureCloudApi.Model.Attribute"); 
        }
        
        /// <summary>
        /// Test Put
        /// </summary>
        [Test]
        public void PutTest()
        {
            // TODO: add unit test for the method 'Put'
            string attributeId = null; // TODO: replace null with proper value
            ININ.PureCloudApi.Model.Attribute body = null; // TODO: replace null with proper value
            
            var response = instance.Put(attributeId, body);
            Assert.IsInstanceOf<ININ.PureCloudApi.Model.Attribute> (response, "response is ININ.PureCloudApi.Model.Attribute"); 
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO: add unit test for the method 'Delete'
            string attributeId = null; // TODO: replace null with proper value
            
            instance.Delete(attributeId);
             
        }
        
    }

}
