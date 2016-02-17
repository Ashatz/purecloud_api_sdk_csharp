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
    public class NumberOrderRequestTests
    {
        private NumberOrderRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new NumberOrderRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of NumberOrderRequest
        /// </summary>
        [Test]
        public void NumberOrderRequestInstanceTest()
        {
            Assert.IsInstanceOf<NumberOrderRequest> (instance, "instance is a NumberOrderRequest");
        }

        
        /// <summary>
        /// Test the property 'OrderTns' 
        /// </summary>
        [Test]
        public void OrderTnsTest()
        {
            // TODO: unit test for the property 'OrderTns' 
        }
        
        /// <summary>
        /// Test the property 'ReservationIds' 
        /// </summary>
        [Test]
        public void ReservationIdsTest()
        {
            // TODO: unit test for the property 'ReservationIds' 
        }
        
        /// <summary>
        /// Test the property 'OrderId' 
        /// </summary>
        [Test]
        public void OrderIdTest()
        {
            // TODO: unit test for the property 'OrderId' 
        }
        
        /// <summary>
        /// Test the property 'EffectiveDate' 
        /// </summary>
        [Test]
        public void EffectiveDateTest()
        {
            // TODO: unit test for the property 'EffectiveDate' 
        }
        
        /// <summary>
        /// Test the property 'PhoneNumberType' 
        /// </summary>
        [Test]
        public void PhoneNumberTypeTest()
        {
            // TODO: unit test for the property 'PhoneNumberType' 
        }
        

    }

}
