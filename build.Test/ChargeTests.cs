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
    public class ChargeTests
    {
        private Charge instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Charge();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Charge
        /// </summary>
        [Test]
        public void ChargeInstanceTest()
        {
            Assert.IsInstanceOf<Charge> (instance, "instance is a Charge");
        }

        
        /// <summary>
        /// Test the property 'LicenseCount' 
        /// </summary>
        [Test]
        public void LicenseCountTest()
        {
            // TODO: unit test for the property 'LicenseCount' 
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
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
        }
        
        /// <summary>
        /// Test the property 'Price' 
        /// </summary>
        [Test]
        public void PriceTest()
        {
            // TODO: unit test for the property 'Price' 
        }
        
        /// <summary>
        /// Test the property 'UnitOfMeasure' 
        /// </summary>
        [Test]
        public void UnitOfMeasureTest()
        {
            // TODO: unit test for the property 'UnitOfMeasure' 
        }
        
        /// <summary>
        /// Test the property 'BillingPeriod' 
        /// </summary>
        [Test]
        public void BillingPeriodTest()
        {
            // TODO: unit test for the property 'BillingPeriod' 
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
        /// Test the property 'IncludedUnits' 
        /// </summary>
        [Test]
        public void IncludedUnitsTest()
        {
            // TODO: unit test for the property 'IncludedUnits' 
        }
        

    }

}
