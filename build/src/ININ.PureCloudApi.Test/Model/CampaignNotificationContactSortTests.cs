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
    ///  Class for testing CampaignNotificationContactSort
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CampaignNotificationContactSortTests
    {
        private CampaignNotificationContactSort instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CampaignNotificationContactSort();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CampaignNotificationContactSort
        /// </summary>
        [Test]
        public void CampaignNotificationContactSortInstanceTest()
        {
            Assert.IsInstanceOf<CampaignNotificationContactSort> (instance, "instance is a CampaignNotificationContactSort");
        }

        /// <summary>
        /// Test the property 'FieldName'
        /// </summary>
        [Test]
        public void FieldNameTest()
        {
            // TODO: unit test for the property 'FieldName'
        }
        /// <summary>
        /// Test the property 'Direction'
        /// </summary>
        [Test]
        public void DirectionTest()
        {
            // TODO: unit test for the property 'Direction'
        }
        /// <summary>
        /// Test the property 'Numeric'
        /// </summary>
        [Test]
        public void NumericTest()
        {
            // TODO: unit test for the property 'Numeric'
        }
        /// <summary>
        /// Test the property 'AdditionalProperties'
        /// </summary>
        [Test]
        public void AdditionalPropertiesTest()
        {
            // TODO: unit test for the property 'AdditionalProperties'
        }

    }

}