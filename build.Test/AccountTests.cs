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
    ///  Class for testing Account
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AccountTests
    {
        private Account instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Account();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Account
        /// </summary>
        [Test]
        public void AccountInstanceTest()
        {
            Assert.IsInstanceOf<Account> (instance, "instance is a Account");
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
        /// Test the property 'OrgLegalName'
        /// </summary>
        [Test]
        public void OrgLegalNameTest()
        {
            // TODO: unit test for the property 'OrgLegalName'
        }
        /// <summary>
        /// Test the property 'BillingAddressLine1'
        /// </summary>
        [Test]
        public void BillingAddressLine1Test()
        {
            // TODO: unit test for the property 'BillingAddressLine1'
        }
        /// <summary>
        /// Test the property 'BillingAddressLine2'
        /// </summary>
        [Test]
        public void BillingAddressLine2Test()
        {
            // TODO: unit test for the property 'BillingAddressLine2'
        }
        /// <summary>
        /// Test the property 'BillingAddressCity'
        /// </summary>
        [Test]
        public void BillingAddressCityTest()
        {
            // TODO: unit test for the property 'BillingAddressCity'
        }
        /// <summary>
        /// Test the property 'BillingAddressState'
        /// </summary>
        [Test]
        public void BillingAddressStateTest()
        {
            // TODO: unit test for the property 'BillingAddressState'
        }
        /// <summary>
        /// Test the property 'BillingAddressZipCode'
        /// </summary>
        [Test]
        public void BillingAddressZipCodeTest()
        {
            // TODO: unit test for the property 'BillingAddressZipCode'
        }
        /// <summary>
        /// Test the property 'BillingAddressCountry'
        /// </summary>
        [Test]
        public void BillingAddressCountryTest()
        {
            // TODO: unit test for the property 'BillingAddressCountry'
        }
        /// <summary>
        /// Test the property 'LegalAddressLine1'
        /// </summary>
        [Test]
        public void LegalAddressLine1Test()
        {
            // TODO: unit test for the property 'LegalAddressLine1'
        }
        /// <summary>
        /// Test the property 'LegalAddressLine2'
        /// </summary>
        [Test]
        public void LegalAddressLine2Test()
        {
            // TODO: unit test for the property 'LegalAddressLine2'
        }
        /// <summary>
        /// Test the property 'LegalAddressCity'
        /// </summary>
        [Test]
        public void LegalAddressCityTest()
        {
            // TODO: unit test for the property 'LegalAddressCity'
        }
        /// <summary>
        /// Test the property 'LegalAddressState'
        /// </summary>
        [Test]
        public void LegalAddressStateTest()
        {
            // TODO: unit test for the property 'LegalAddressState'
        }
        /// <summary>
        /// Test the property 'LegalAddressZipCode'
        /// </summary>
        [Test]
        public void LegalAddressZipCodeTest()
        {
            // TODO: unit test for the property 'LegalAddressZipCode'
        }
        /// <summary>
        /// Test the property 'LegalAddressCountry'
        /// </summary>
        [Test]
        public void LegalAddressCountryTest()
        {
            // TODO: unit test for the property 'LegalAddressCountry'
        }
        /// <summary>
        /// Test the property 'BillingContactFirstName'
        /// </summary>
        [Test]
        public void BillingContactFirstNameTest()
        {
            // TODO: unit test for the property 'BillingContactFirstName'
        }
        /// <summary>
        /// Test the property 'BillingContactLastName'
        /// </summary>
        [Test]
        public void BillingContactLastNameTest()
        {
            // TODO: unit test for the property 'BillingContactLastName'
        }
        /// <summary>
        /// Test the property 'BillingContactEmail'
        /// </summary>
        [Test]
        public void BillingContactEmailTest()
        {
            // TODO: unit test for the property 'BillingContactEmail'
        }
        /// <summary>
        /// Test the property 'BillingContactPhone'
        /// </summary>
        [Test]
        public void BillingContactPhoneTest()
        {
            // TODO: unit test for the property 'BillingContactPhone'
        }
        /// <summary>
        /// Test the property 'PurchaseOrderNumber'
        /// </summary>
        [Test]
        public void PurchaseOrderNumberTest()
        {
            // TODO: unit test for the property 'PurchaseOrderNumber'
        }
        /// <summary>
        /// Test the property 'IsTaxExempt'
        /// </summary>
        [Test]
        public void IsTaxExemptTest()
        {
            // TODO: unit test for the property 'IsTaxExempt'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO: unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'PaymentTerm'
        /// </summary>
        [Test]
        public void PaymentTermTest()
        {
            // TODO: unit test for the property 'PaymentTerm'
        }
        /// <summary>
        /// Test the property 'ContractTerm'
        /// </summary>
        [Test]
        public void ContractTermTest()
        {
            // TODO: unit test for the property 'ContractTerm'
        }
        /// <summary>
        /// Test the property 'AutoRenew'
        /// </summary>
        [Test]
        public void AutoRenewTest()
        {
            // TODO: unit test for the property 'AutoRenew'
        }
        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Test]
        public void EnabledTest()
        {
            // TODO: unit test for the property 'Enabled'
        }
        /// <summary>
        /// Test the property 'MinCommitQuantities'
        /// </summary>
        [Test]
        public void MinCommitQuantitiesTest()
        {
            // TODO: unit test for the property 'MinCommitQuantities'
        }
        /// <summary>
        /// Test the property 'EstimatedQuantities'
        /// </summary>
        [Test]
        public void EstimatedQuantitiesTest()
        {
            // TODO: unit test for the property 'EstimatedQuantities'
        }
        /// <summary>
        /// Test the property 'OneTimeCharges'
        /// </summary>
        [Test]
        public void OneTimeChargesTest()
        {
            // TODO: unit test for the property 'OneTimeCharges'
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
