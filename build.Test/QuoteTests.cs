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
    [TestFixture]
    public class QuoteTests
    {
        private Quote instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Quote();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Quote
        /// </summary>
        [Test]
        public void QuoteInstanceTest()
        {
            Assert.IsInstanceOf<Quote> (instance, "instance is a Quote");
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
        /// Test the property 'PurchaseOrder' 
        /// </summary>
        [Test]
        public void PurchaseOrderTest()
        {
            // TODO: unit test for the property 'PurchaseOrder' 
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
        /// Test the property 'Status' 
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status' 
        }
        
        /// <summary>
        /// Test the property 'IsSubmitted' 
        /// </summary>
        [Test]
        public void IsSubmittedTest()
        {
            // TODO: unit test for the property 'IsSubmitted' 
        }
        
        /// <summary>
        /// Test the property 'IsPending' 
        /// </summary>
        [Test]
        public void IsPendingTest()
        {
            // TODO: unit test for the property 'IsPending' 
        }
        
        /// <summary>
        /// Test the property 'IsFrozen' 
        /// </summary>
        [Test]
        public void IsFrozenTest()
        {
            // TODO: unit test for the property 'IsFrozen' 
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
        /// Test the property 'CreatedDate' 
        /// </summary>
        [Test]
        public void CreatedDateTest()
        {
            // TODO: unit test for the property 'CreatedDate' 
        }
        
        /// <summary>
        /// Test the property 'LastUpdatedDate' 
        /// </summary>
        [Test]
        public void LastUpdatedDateTest()
        {
            // TODO: unit test for the property 'LastUpdatedDate' 
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
        /// Test the property 'BillingContactPhone' 
        /// </summary>
        [Test]
        public void BillingContactPhoneTest()
        {
            // TODO: unit test for the property 'BillingContactPhone' 
        }
        
        /// <summary>
        /// Test the property 'IncludeVoiceCharges' 
        /// </summary>
        [Test]
        public void IncludeVoiceChargesTest()
        {
            // TODO: unit test for the property 'IncludeVoiceCharges' 
        }
        
        /// <summary>
        /// Test the property 'Charges' 
        /// </summary>
        [Test]
        public void ChargesTest()
        {
            // TODO: unit test for the property 'Charges' 
        }
        
        /// <summary>
        /// Test the property 'EdgeControlModel' 
        /// </summary>
        [Test]
        public void EdgeControlModelTest()
        {
            // TODO: unit test for the property 'EdgeControlModel' 
        }
        
        /// <summary>
        /// Test the property 'ReferralCodes' 
        /// </summary>
        [Test]
        public void ReferralCodesTest()
        {
            // TODO: unit test for the property 'ReferralCodes' 
        }
        
        /// <summary>
        /// Test the property 'DiscountCodes' 
        /// </summary>
        [Test]
        public void DiscountCodesTest()
        {
            // TODO: unit test for the property 'DiscountCodes' 
        }
        
        /// <summary>
        /// Test the property 'SalesPartnerCode' 
        /// </summary>
        [Test]
        public void SalesPartnerCodeTest()
        {
            // TODO: unit test for the property 'SalesPartnerCode' 
        }
        
        /// <summary>
        /// Test the property 'IsAnnualPrepay' 
        /// </summary>
        [Test]
        public void IsAnnualPrepayTest()
        {
            // TODO: unit test for the property 'IsAnnualPrepay' 
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
