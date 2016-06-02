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
    ///  Class for testing Invoice
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class InvoiceTests
    {
        private Invoice instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Invoice();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Invoice
        /// </summary>
        [Test]
        public void InvoiceInstanceTest()
        {
            Assert.IsInstanceOf<Invoice> (instance, "instance is a Invoice");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id'
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
        /// Test the property 'InvoiceNumber'
        /// </summary>
        [Test]
        public void InvoiceNumberTest()
        {
            // TODO: unit test for the property 'InvoiceNumber'
        }
        /// <summary>
        /// Test the property 'InvoiceDate'
        /// </summary>
        [Test]
        public void InvoiceDateTest()
        {
            // TODO: unit test for the property 'InvoiceDate'
        }
        /// <summary>
        /// Test the property 'DueDate'
        /// </summary>
        [Test]
        public void DueDateTest()
        {
            // TODO: unit test for the property 'DueDate'
        }
        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Test]
        public void AmountTest()
        {
            // TODO: unit test for the property 'Amount'
        }
        /// <summary>
        /// Test the property 'Balance'
        /// </summary>
        [Test]
        public void BalanceTest()
        {
            // TODO: unit test for the property 'Balance'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'SelfUri'
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri'
        }

    }

}
