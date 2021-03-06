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
    ///  Class for testing OrganizationCreate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class OrganizationCreateTests
    {
        private OrganizationCreate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrganizationCreate();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrganizationCreate
        /// </summary>
        [Test]
        public void OrganizationCreateInstanceTest()
        {
            Assert.IsInstanceOf<OrganizationCreate> (instance, "instance is a OrganizationCreate");
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'AdminUsername'
        /// </summary>
        [Test]
        public void AdminUsernameTest()
        {
            // TODO: unit test for the property 'AdminUsername'
        }
        /// <summary>
        /// Test the property 'AdminPassword'
        /// </summary>
        [Test]
        public void AdminPasswordTest()
        {
            // TODO: unit test for the property 'AdminPassword'
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
        /// Test the property 'ThirdPartyOrgName'
        /// </summary>
        [Test]
        public void ThirdPartyOrgNameTest()
        {
            // TODO: unit test for the property 'ThirdPartyOrgName'
        }
        /// <summary>
        /// Test the property 'Deletable'
        /// </summary>
        [Test]
        public void DeletableTest()
        {
            // TODO: unit test for the property 'Deletable'
        }

    }

}
