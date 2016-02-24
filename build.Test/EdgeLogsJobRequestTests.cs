using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Model;
using ININ.PureCloudApi.Client;
using System.Reflection;

namespace ININ.PureCloudApi.Test
{
    [TestFixture]
    public class EdgeLogsJobRequestTests
    {
        private EdgeLogsJobRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EdgeLogsJobRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EdgeLogsJobRequest
        /// </summary>
        [Test]
        public void EdgeLogsJobRequestInstanceTest()
        {
            Assert.IsInstanceOf<EdgeLogsJobRequest> (instance, "instance is a EdgeLogsJobRequest");
        }

        
        /// <summary>
        /// Test the property 'Path' 
        /// </summary>
        [Test]
        public void PathTest()
        {
            // TODO: unit test for the property 'Path' 
        }
        
        /// <summary>
        /// Test the property 'Query' 
        /// </summary>
        [Test]
        public void QueryTest()
        {
            // TODO: unit test for the property 'Query' 
        }
        
        /// <summary>
        /// Test the property 'Recurse' 
        /// </summary>
        [Test]
        public void RecurseTest()
        {
            // TODO: unit test for the property 'Recurse' 
        }
        

    }

}
