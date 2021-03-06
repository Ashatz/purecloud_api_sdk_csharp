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
    ///  Class for testing CampaignInteractions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CampaignInteractionsTests
    {
        private CampaignInteractions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CampaignInteractions();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CampaignInteractions
        /// </summary>
        [Test]
        public void CampaignInteractionsInstanceTest()
        {
            Assert.IsInstanceOf<CampaignInteractions> (instance, "instance is a CampaignInteractions");
        }

        /// <summary>
        /// Test the property 'Campaign'
        /// </summary>
        [Test]
        public void CampaignTest()
        {
            // TODO: unit test for the property 'Campaign'
        }
        /// <summary>
        /// Test the property 'PendingInteractions'
        /// </summary>
        [Test]
        public void PendingInteractionsTest()
        {
            // TODO: unit test for the property 'PendingInteractions'
        }
        /// <summary>
        /// Test the property 'ProceedingInteractions'
        /// </summary>
        [Test]
        public void ProceedingInteractionsTest()
        {
            // TODO: unit test for the property 'ProceedingInteractions'
        }
        /// <summary>
        /// Test the property 'PreviewingInteractions'
        /// </summary>
        [Test]
        public void PreviewingInteractionsTest()
        {
            // TODO: unit test for the property 'PreviewingInteractions'
        }
        /// <summary>
        /// Test the property 'InteractingInteractions'
        /// </summary>
        [Test]
        public void InteractingInteractionsTest()
        {
            // TODO: unit test for the property 'InteractingInteractions'
        }
        /// <summary>
        /// Test the property 'ScheduledInteractions'
        /// </summary>
        [Test]
        public void ScheduledInteractionsTest()
        {
            // TODO: unit test for the property 'ScheduledInteractions'
        }

    }

}
