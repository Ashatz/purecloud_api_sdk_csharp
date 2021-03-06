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
    /// <summary>
    ///  Class for testing CampaignRuleActionEntities
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CampaignRuleActionEntitiesTests
    {
        private CampaignRuleActionEntities instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CampaignRuleActionEntities();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CampaignRuleActionEntities
        /// </summary>
        [Test]
        public void CampaignRuleActionEntitiesInstanceTest()
        {
            Assert.IsInstanceOf<CampaignRuleActionEntities> (instance, "instance is a CampaignRuleActionEntities");
        }

        /// <summary>
        /// Test the property 'Campaigns'
        /// </summary>
        [Test]
        public void CampaignsTest()
        {
            // TODO: unit test for the property 'Campaigns'
        }
        /// <summary>
        /// Test the property 'Sequences'
        /// </summary>
        [Test]
        public void SequencesTest()
        {
            // TODO: unit test for the property 'Sequences'
        }
        /// <summary>
        /// Test the property 'UseTriggeringEntity'
        /// </summary>
        [Test]
        public void UseTriggeringEntityTest()
        {
            // TODO: unit test for the property 'UseTriggeringEntity'
        }

    }

}
