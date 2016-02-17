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
    public class WorkspaceSummaryTests
    {
        private WorkspaceSummary instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkspaceSummary();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WorkspaceSummary
        /// </summary>
        [Test]
        public void WorkspaceSummaryInstanceTest()
        {
            Assert.IsInstanceOf<WorkspaceSummary> (instance, "instance is a WorkspaceSummary");
        }

        
        /// <summary>
        /// Test the property 'TotalDocumentCount' 
        /// </summary>
        [Test]
        public void TotalDocumentCountTest()
        {
            // TODO: unit test for the property 'TotalDocumentCount' 
        }
        

    }

}
