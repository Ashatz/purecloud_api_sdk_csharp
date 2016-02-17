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
    public class BillingPeriodTests
    {
        private BillingPeriod instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BillingPeriod();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of BillingPeriod
        /// </summary>
        [Test]
        public void BillingPeriodInstanceTest()
        {
            Assert.IsInstanceOf<BillingPeriod> (instance, "instance is a BillingPeriod");
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
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}
