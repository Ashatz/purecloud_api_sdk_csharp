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
        /// Test GetQualityForms
        /// </summary>
        [Test]
        public void GetQualityFormsTest()
        {
            // TODO: add unit test for the method 'GetQualityForms'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            string expand2 = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            
            var response = instance.GetQualityForms(pageSize, pageNumber, sortBy, expand, expand2, name);
            Assert.IsInstanceOf<EvaluationFormEntityListing> (response, "response is EvaluationFormEntityListing"); 
        }
        
        /// <summary>
        /// Test PostQualityForms
        /// </summary>
        [Test]
        public void PostQualityFormsTest()
        {
            // TODO: add unit test for the method 'PostQualityForms'
            EvaluationForm body = null; // TODO: replace null with proper value
            
            var response = instance.PostQualityForms(body);
            Assert.IsInstanceOf<EvaluationForm> (response, "response is EvaluationForm"); 
        }
        
        /// <summary>
        /// Test GetQualityForm
        /// </summary>
        [Test]
        public void GetQualityFormTest()
        {
            // TODO: add unit test for the method 'GetQualityForm'
            string formId = null; // TODO: replace null with proper value
            
            var response = instance.GetQualityForm(formId);
            Assert.IsInstanceOf<EvaluationForm> (response, "response is EvaluationForm"); 
        }
        
        /// <summary>
        /// Test PutQualityForm
        /// </summary>
        [Test]
        public void PutQualityFormTest()
        {
            // TODO: add unit test for the method 'PutQualityForm'
            string formId = null; // TODO: replace null with proper value
            EvaluationForm body = null; // TODO: replace null with proper value
            
            var response = instance.PutQualityForm(formId, body);
            Assert.IsInstanceOf<EvaluationForm> (response, "response is EvaluationForm"); 
        }
        
        /// <summary>
        /// Test DeleteQualityForm
        /// </summary>
        [Test]
        public void DeleteQualityFormTest()
        {
            // TODO: add unit test for the method 'DeleteQualityForm'
            string formId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteQualityForm(formId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetQualityFormVersions
        /// </summary>
        [Test]
        public void GetQualityFormVersionsTest()
        {
            // TODO: add unit test for the method 'GetQualityFormVersions'
            string formId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetQualityFormVersions(formId, pageSize, pageNumber);
            Assert.IsInstanceOf<EvaluationFormEntityListing> (response, "response is EvaluationFormEntityListing"); 
        }
        
        /// <summary>
        /// Test GetQualityPublishedforms
        /// </summary>
        [Test]
        public void GetQualityPublishedformsTest()
        {
            // TODO: add unit test for the method 'GetQualityPublishedforms'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            
            var response = instance.GetQualityPublishedforms(pageSize, pageNumber, name);
            Assert.IsInstanceOf<EvaluationFormEntityListing> (response, "response is EvaluationFormEntityListing"); 
        }
        
        /// <summary>
        /// Test PostQualityPublishedforms
        /// </summary>
        [Test]
        public void PostQualityPublishedformsTest()
        {
            // TODO: add unit test for the method 'PostQualityPublishedforms'
            EvaluationForm body = null; // TODO: replace null with proper value
            
            var response = instance.PostQualityPublishedforms(body);
            Assert.IsInstanceOf<EvaluationForm> (response, "response is EvaluationForm"); 
        }
        
        /// <summary>
        /// Test GetQualityPublishedform
        /// </summary>
        [Test]
        public void GetQualityPublishedformTest()
        {
            // TODO: add unit test for the method 'GetQualityPublishedform'
            string formId = null; // TODO: replace null with proper value
            
            var response = instance.GetQualityPublishedform(formId);
            Assert.IsInstanceOf<EvaluationForm> (response, "response is EvaluationForm"); 
        }
        
        /// <summary>
        /// Test GetScripts
        /// </summary>
        [Test]
        public void GetScriptsTest()
        {
            // TODO: add unit test for the method 'GetScripts'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string feature = null; // TODO: replace null with proper value
            
            var response = instance.GetScripts(pageSize, pageNumber, expand, name, feature);
            Assert.IsInstanceOf<ScriptEntityListing> (response, "response is ScriptEntityListing"); 
        }
        
        /// <summary>
        /// Test PostScripts
        /// </summary>
        [Test]
        public void PostScriptsTest()
        {
            // TODO: add unit test for the method 'PostScripts'
            Body3 body = null; // TODO: replace null with proper value
            
            var response = instance.PostScripts(body);
            Assert.IsInstanceOf<Script> (response, "response is Script"); 
        }
        
    }

}
