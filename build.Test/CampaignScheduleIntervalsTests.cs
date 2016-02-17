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
    public class CampaignScheduleIntervalsTests
    {
        private CampaignScheduleIntervals instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CampaignScheduleIntervals();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CampaignScheduleIntervals
        /// </summary>
        [Test]
        public void CampaignScheduleIntervalsInstanceTest()
        {
            Assert.IsInstanceOf<CampaignScheduleIntervals> (instance, "instance is a CampaignScheduleIntervals");
        }

        
        /// <summary>
        /// Test the property 'Start' 
        /// </summary>
        [Test]
        public void StartTest()
        {
            // TODO: unit test for the property 'Start' 
        }
        
        /// <summary>
        /// Test the property 'End' 
        /// </summary>
        [Test]
        public void EndTest()
        {
            // TODO: unit test for the property 'End' 
        }
        

    }

}
