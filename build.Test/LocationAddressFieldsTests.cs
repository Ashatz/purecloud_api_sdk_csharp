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
    public class LocationAddressFieldsTests
    {
        private LocationAddressFields instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LocationAddressFields();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of LocationAddressFields
        /// </summary>
        [Test]
        public void LocationAddressFieldsInstanceTest()
        {
            Assert.IsInstanceOf<LocationAddressFields> (instance, "instance is a LocationAddressFields");
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
        /// Test the property 'Country' 
        /// </summary>
        [Test]
        public void CountryTest()
        {
            // TODO: unit test for the property 'Country' 
        }
        
        /// <summary>
        /// Test the property 'CountryName' 
        /// </summary>
        [Test]
        public void CountryNameTest()
        {
            // TODO: unit test for the property 'CountryName' 
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
        /// Test the property 'Street1' 
        /// </summary>
        [Test]
        public void Street1Test()
        {
            // TODO: unit test for the property 'Street1' 
        }
        
        /// <summary>
        /// Test the property 'Street2' 
        /// </summary>
        [Test]
        public void Street2Test()
        {
            // TODO: unit test for the property 'Street2' 
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
