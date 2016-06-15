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
    ///  Class for testing DomainPermissionPolicy
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DomainPermissionPolicyTests
    {
        private DomainPermissionPolicy instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainPermissionPolicy();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DomainPermissionPolicy
        /// </summary>
        [Test]
        public void DomainPermissionPolicyInstanceTest()
        {
            Assert.IsInstanceOf<DomainPermissionPolicy> (instance, "instance is a DomainPermissionPolicy");
        }

        /// <summary>
        /// Test the property 'Domain'
        /// </summary>
        [Test]
        public void DomainTest()
        {
            // TODO: unit test for the property 'Domain'
        }
        /// <summary>
        /// Test the property 'EntityName'
        /// </summary>
        [Test]
        public void EntityNameTest()
        {
            // TODO: unit test for the property 'EntityName'
        }
        /// <summary>
        /// Test the property 'PolicyName'
        /// </summary>
        [Test]
        public void PolicyNameTest()
        {
            // TODO: unit test for the property 'PolicyName'
        }
        /// <summary>
        /// Test the property 'PolicyDescription'
        /// </summary>
        [Test]
        public void PolicyDescriptionTest()
        {
            // TODO: unit test for the property 'PolicyDescription'
        }
        /// <summary>
        /// Test the property 'ActionSet'
        /// </summary>
        [Test]
        public void ActionSetTest()
        {
            // TODO: unit test for the property 'ActionSet'
        }
        /// <summary>
        /// Test the property 'NamedResources'
        /// </summary>
        [Test]
        public void NamedResourcesTest()
        {
            // TODO: unit test for the property 'NamedResources'
        }
        /// <summary>
        /// Test the property 'AllowConditions'
        /// </summary>
        [Test]
        public void AllowConditionsTest()
        {
            // TODO: unit test for the property 'AllowConditions'
        }
        /// <summary>
        /// Test the property 'ResourceConditionNode'
        /// </summary>
        [Test]
        public void ResourceConditionNodeTest()
        {
            // TODO: unit test for the property 'ResourceConditionNode'
        }

    }

}