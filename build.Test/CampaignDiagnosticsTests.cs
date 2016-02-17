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
    public class CampaignDiagnosticsTests
    {
        private CampaignDiagnostics instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CampaignDiagnostics();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CampaignDiagnostics
        /// </summary>
        [Test]
        public void CampaignDiagnosticsInstanceTest()
        {
            Assert.IsInstanceOf<CampaignDiagnostics> (instance, "instance is a CampaignDiagnostics");
        }

        
        /// <summary>
        /// Test the property 'CallableContacts' 
        /// </summary>
        [Test]
        public void CallableContactsTest()
        {
            // TODO: unit test for the property 'CallableContacts' 
        }
        
        /// <summary>
        /// Test the property 'QueueUtilizationDiagnostic' 
        /// </summary>
        [Test]
        public void QueueUtilizationDiagnosticTest()
        {
            // TODO: unit test for the property 'QueueUtilizationDiagnostic' 
        }
        
        /// <summary>
        /// Test the property 'OutstandingInteractionsCount' 
        /// </summary>
        [Test]
        public void OutstandingInteractionsCountTest()
        {
            // TODO: unit test for the property 'OutstandingInteractionsCount' 
        }
        

    }

}
