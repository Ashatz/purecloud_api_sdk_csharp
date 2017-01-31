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
    ///  Class for testing ContactListNotificationContactPhoneNumberColumn
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ContactListNotificationContactPhoneNumberColumnTests
    {
        private ContactListNotificationContactPhoneNumberColumn instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContactListNotificationContactPhoneNumberColumn();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContactListNotificationContactPhoneNumberColumn
        /// </summary>
        [Test]
        public void ContactListNotificationContactPhoneNumberColumnInstanceTest()
        {
            Assert.IsInstanceOf<ContactListNotificationContactPhoneNumberColumn> (instance, "instance is a ContactListNotificationContactPhoneNumberColumn");
        }

        /// <summary>
        /// Test the property 'ColumnName'
        /// </summary>
        [Test]
        public void ColumnNameTest()
        {
            // TODO: unit test for the property 'ColumnName'
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
        /// Test the property 'CallableTimeColumn'
        /// </summary>
        [Test]
        public void CallableTimeColumnTest()
        {
            // TODO: unit test for the property 'CallableTimeColumn'
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