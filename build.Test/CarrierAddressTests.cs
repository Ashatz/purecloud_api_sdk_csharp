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
    public class CarrierAddressTests
    {
        private CarrierAddress instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CarrierAddress();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CarrierAddress
        /// </summary>
        [Test]
        public void CarrierAddressInstanceTest()
        {
            Assert.IsInstanceOf<CarrierAddress> (instance, "instance is a CarrierAddress");
        }

        
        /// <summary>
        /// Test the property 'StreetAddress1' 
        /// </summary>
        [Test]
        public void StreetAddress1Test()
        {
            // TODO: unit test for the property 'StreetAddress1' 
        }
        
        /// <summary>
        /// Test the property 'StreetAddress2' 
        /// </summary>
        [Test]
        public void StreetAddress2Test()
        {
            // TODO: unit test for the property 'StreetAddress2' 
        }
        
        /// <summary>
        /// Test the property 'City' 
        /// </summary>
        [Test]
        public void CityTest()
        {
            // TODO: unit test for the property 'City' 
        }
        
        /// <summary>
        /// Test the property 'State' 
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO: unit test for the property 'State' 
        }
        
        /// <summary>
        /// Test the property 'Zipcode' 
        /// </summary>
        [Test]
        public void ZipcodeTest()
        {
            // TODO: unit test for the property 'Zipcode' 
        }
        

    }

}
