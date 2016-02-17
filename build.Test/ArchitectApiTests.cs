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
    public class ArchitectApiTests
    {
        private ArchitectApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new ArchitectApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ArchitectApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<ArchitectApi> (instance, "instance is a ArchitectApi");
        }

        
        /// <summary>
        /// Test GetFlows
        /// </summary>
        [Test]
        public void GetFlowsTest()
        {
            // TODO: add unit test for the method 'GetFlows'
            string type = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            List<string> id = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string description = null; // TODO: replace null with proper value
            string nameOrDescription = null; // TODO: replace null with proper value
            string publishVersionId = null; // TODO: replace null with proper value
            string editableBy = null; // TODO: replace null with proper value
            string lockedBy = null; // TODO: replace null with proper value
            bool? deleted = null; // TODO: replace null with proper value
            
            var response = instance.GetFlows(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, editableBy, lockedBy, deleted);
            Assert.IsInstanceOf<FlowEntityListing> (response, "response is FlowEntityListing"); 
        }
        
        /// <summary>
        /// Test PostFlows
        /// </summary>
        [Test]
        public void PostFlowsTest()
        {
            // TODO: add unit test for the method 'PostFlows'
            Flow body = null; // TODO: replace null with proper value
            
            var response = instance.PostFlows(body);
            Assert.IsInstanceOf<Flow> (response, "response is Flow"); 
        }
        
        /// <summary>
        /// Test DeleteFlows
        /// </summary>
        [Test]
        public void DeleteFlowsTest()
        {
            // TODO: add unit test for the method 'DeleteFlows'
            List<string> id = null; // TODO: replace null with proper value
            bool? ignoreDependencies = null; // TODO: replace null with proper value
            
            instance.DeleteFlows(id, ignoreDependencies);
             
        }
        
    }

}
