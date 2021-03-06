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
    ///  Class for testing OutOfOfficeNotification
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class OutOfOfficeNotificationTests
    {
        private OutOfOfficeNotification instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OutOfOfficeNotification();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OutOfOfficeNotification
        /// </summary>
        [Test]
        public void OutOfOfficeNotificationInstanceTest()
        {
            Assert.IsInstanceOf<OutOfOfficeNotification> (instance, "instance is a OutOfOfficeNotification");
        }

        /// <summary>
        /// Test the property 'User'
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User'
        }
        /// <summary>
        /// Test the property 'Active'
        /// </summary>
        [Test]
        public void ActiveTest()
        {
            // TODO: unit test for the property 'Active'
        }
        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Test]
        public void StartDateTest()
        {
            // TODO: unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'EndDate'
        /// </summary>
        [Test]
        public void EndDateTest()
        {
            // TODO: unit test for the property 'EndDate'
        }
        /// <summary>
        /// Test the property 'ModifiedDate'
        /// </summary>
        [Test]
        public void ModifiedDateTest()
        {
            // TODO: unit test for the property 'ModifiedDate'
        }

    }

}
