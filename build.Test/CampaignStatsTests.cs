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
    public class CampaignStatsTests
    {
        private CampaignStats instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CampaignStats();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CampaignStats
        /// </summary>
        [Test]
        public void CampaignStatsInstanceTest()
        {
            Assert.IsInstanceOf<CampaignStats> (instance, "instance is a CampaignStats");
        }

        
        /// <summary>
        /// Test the property 'ContactRate' 
        /// </summary>
        [Test]
        public void ContactRateTest()
        {
            // TODO: unit test for the property 'ContactRate' 
        }
        
        /// <summary>
        /// Test the property 'IdleAgents' 
        /// </summary>
        [Test]
        public void IdleAgentsTest()
        {
            // TODO: unit test for the property 'IdleAgents' 
        }
        
        /// <summary>
        /// Test the property 'AdjustedCallsPerAgent' 
        /// </summary>
        [Test]
        public void AdjustedCallsPerAgentTest()
        {
            // TODO: unit test for the property 'AdjustedCallsPerAgent' 
        }
        
        /// <summary>
        /// Test the property 'OutstandingCalls' 
        /// </summary>
        [Test]
        public void OutstandingCallsTest()
        {
            // TODO: unit test for the property 'OutstandingCalls' 
        }
        

    }

}
