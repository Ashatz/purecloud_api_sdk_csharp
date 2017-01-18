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
    ///  Class for testing RuleSetNotificationActions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RuleSetNotificationActionsTests
    {
        private RuleSetNotificationActions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RuleSetNotificationActions();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RuleSetNotificationActions
        /// </summary>
        [Test]
        public void RuleSetNotificationActionsInstanceTest()
        {
            Assert.IsInstanceOf<RuleSetNotificationActions> (instance, "instance is a RuleSetNotificationActions");
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'ActionTypeName'
        /// </summary>
        [Test]
        public void ActionTypeNameTest()
        {
            // TODO: unit test for the property 'ActionTypeName'
        }
        /// <summary>
        /// Test the property 'UpdateOption'
        /// </summary>
        [Test]
        public void UpdateOptionTest()
        {
            // TODO: unit test for the property 'UpdateOption'
        }
        /// <summary>
        /// Test the property 'Properties'
        /// </summary>
        [Test]
        public void PropertiesTest()
        {
            // TODO: unit test for the property 'Properties'
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