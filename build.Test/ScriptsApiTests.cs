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
    public class ScriptsApiTests
    {
        private ScriptsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new ScriptsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ScriptsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<ScriptsApi> (instance, "instance is a ScriptsApi");
        }

        
        /// <summary>
        /// Test GetForms
        /// </summary>
        [Test]
        public void GetFormsTest()
        {
            // TODO: add unit test for the method 'GetForms'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            string expand2 = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            
            var response = instance.GetForms(pageSize, pageNumber, sortBy, expand, expand2, name);
            Assert.IsInstanceOf<EvaluationFormEntityListing> (response, "response is EvaluationFormEntityListing"); 
        }
        
        /// <summary>
        /// Test PostForms
        /// </summary>
        [Test]
        public void PostFormsTest()
        {
            // TODO: add unit test for the method 'PostForms'
            EvaluationForm body = null; // TODO: replace null with proper value
            
            var response = instance.PostForms(body);
            Assert.IsInstanceOf<EvaluationForm> (response, "response is EvaluationForm"); 
        }
        
        /// <summary>
        /// Test GetFormsFormId
        /// </summary>
        [Test]
        public void GetFormsFormIdTest()
        {
            // TODO: add unit test for the method 'GetFormsFormId'
            string formId = null; // TODO: replace null with proper value
            
            var response = instance.GetFormsFormId(formId);
            Assert.IsInstanceOf<EvaluationForm> (response, "response is EvaluationForm"); 
        }
        
        /// <summary>
        /// Test PutFormsFormId
        /// </summary>
        [Test]
        public void PutFormsFormIdTest()
        {
            // TODO: add unit test for the method 'PutFormsFormId'
            string formId = null; // TODO: replace null with proper value
            EvaluationForm body = null; // TODO: replace null with proper value
            
            var response = instance.PutFormsFormId(formId, body);
            Assert.IsInstanceOf<EvaluationForm> (response, "response is EvaluationForm"); 
        }
        
        /// <summary>
        /// Test DeleteFormsFormId
        /// </summary>
        [Test]
        public void DeleteFormsFormIdTest()
        {
            // TODO: add unit test for the method 'DeleteFormsFormId'
            string formId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteFormsFormId(formId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetFormsFormIdVersions
        /// </summary>
        [Test]
        public void GetFormsFormIdVersionsTest()
        {
            // TODO: add unit test for the method 'GetFormsFormIdVersions'
            string formId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetFormsFormIdVersions(formId, pageSize, pageNumber);
            Assert.IsInstanceOf<EvaluationFormEntityListing> (response, "response is EvaluationFormEntityListing"); 
        }
        
        /// <summary>
        /// Test GetPublishedforms
        /// </summary>
        [Test]
        public void GetPublishedformsTest()
        {
            // TODO: add unit test for the method 'GetPublishedforms'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            
            var response = instance.GetPublishedforms(pageSize, pageNumber, name);
            Assert.IsInstanceOf<EvaluationFormEntityListing> (response, "response is EvaluationFormEntityListing"); 
        }
        
        /// <summary>
        /// Test PostPublishedforms
        /// </summary>
        [Test]
        public void PostPublishedformsTest()
        {
            // TODO: add unit test for the method 'PostPublishedforms'
            EvaluationForm body = null; // TODO: replace null with proper value
            
            var response = instance.PostPublishedforms(body);
            Assert.IsInstanceOf<EvaluationForm> (response, "response is EvaluationForm"); 
        }
        
        /// <summary>
        /// Test GetPublishedformsFormId
        /// </summary>
        [Test]
        public void GetPublishedformsFormIdTest()
        {
            // TODO: add unit test for the method 'GetPublishedformsFormId'
            string formId = null; // TODO: replace null with proper value
            
            var response = instance.GetPublishedformsFormId(formId);
            Assert.IsInstanceOf<EvaluationForm> (response, "response is EvaluationForm"); 
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
            string expand = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string feature = null; // TODO: replace null with proper value
            
            var response = instance.Get(pageSize, pageNumber, expand, name, feature);
            Assert.IsInstanceOf<ScriptEntityListing> (response, "response is ScriptEntityListing"); 
        }
        
        /// <summary>
        /// Test Post
        /// </summary>
        [Test]
        public void PostTest()
        {
            // TODO: add unit test for the method 'Post'
            Body3 body = null; // TODO: replace null with proper value
            
            var response = instance.Post(body);
            Assert.IsInstanceOf<Script> (response, "response is Script"); 
        }
        
    }

}
