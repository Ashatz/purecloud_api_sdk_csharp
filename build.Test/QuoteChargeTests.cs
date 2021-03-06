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
    ///  Class for testing QuoteCharge
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class QuoteChargeTests
    {
        private QuoteCharge instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new QuoteCharge();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of QuoteCharge
        /// </summary>
        [Test]
        public void QuoteChargeInstanceTest()
        {
            Assert.IsInstanceOf<QuoteCharge> (instance, "instance is a QuoteCharge");
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
        /// Test the property 'Sku'
        /// </summary>
        [Test]
        public void SkuTest()
        {
            // TODO: unit test for the property 'Sku'
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
        /// Test the property 'ChargeType'
        /// </summary>
        [Test]
        public void ChargeTypeTest()
        {
            // TODO: unit test for the property 'ChargeType'
        }
        /// <summary>
        /// Test the property 'Quantity'
        /// </summary>
        [Test]
        public void QuantityTest()
        {
            // TODO: unit test for the property 'Quantity'
        }
        /// <summary>
        /// Test the property 'ListTotal'
        /// </summary>
        [Test]
        public void ListTotalTest()
        {
            // TODO: unit test for the property 'ListTotal'
        }
        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Test]
        public void TotalTest()
        {
            // TODO: unit test for the property 'Total'
        }
        /// <summary>
        /// Test the property 'ListPriceDisplay'
        /// </summary>
        [Test]
        public void ListPriceDisplayTest()
        {
            // TODO: unit test for the property 'ListPriceDisplay'
        }
        /// <summary>
        /// Test the property 'Discount'
        /// </summary>
        [Test]
        public void DiscountTest()
        {
            // TODO: unit test for the property 'Discount'
        }
        /// <summary>
        /// Test the property 'EffectivePrice'
        /// </summary>
        [Test]
        public void EffectivePriceTest()
        {
            // TODO: unit test for the property 'EffectivePrice'
        }
        /// <summary>
        /// Test the property 'ProductShippable'
        /// </summary>
        [Test]
        public void ProductShippableTest()
        {
            // TODO: unit test for the property 'ProductShippable'
        }
        /// <summary>
        /// Test the property 'ShippingAddress'
        /// </summary>
        [Test]
        public void ShippingAddressTest()
        {
            // TODO: unit test for the property 'ShippingAddress'
        }
        /// <summary>
        /// Test the property 'ForRelatedPart'
        /// </summary>
        [Test]
        public void ForRelatedPartTest()
        {
            // TODO: unit test for the property 'ForRelatedPart'
        }

    }

}
