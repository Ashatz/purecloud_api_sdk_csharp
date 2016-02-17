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
    public class GeolocationTests
    {
        private Geolocation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Geolocation();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Geolocation
        /// </summary>
        [Test]
        public void GeolocationInstanceTest()
        {
            Assert.IsInstanceOf<Geolocation> (instance, "instance is a Geolocation");
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
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        
        /// <summary>
        /// Test the property 'Primary' 
        /// </summary>
        [Test]
        public void PrimaryTest()
        {
            // TODO: unit test for the property 'Primary' 
        }
        
        /// <summary>
        /// Test the property 'Latitude' 
        /// </summary>
        [Test]
        public void LatitudeTest()
        {
            // TODO: unit test for the property 'Latitude' 
        }
        
        /// <summary>
        /// Test the property 'Longitude' 
        /// </summary>
        [Test]
        public void LongitudeTest()
        {
            // TODO: unit test for the property 'Longitude' 
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
        /// Test the property 'Region' 
        /// </summary>
        [Test]
        public void RegionTest()
        {
            // TODO: unit test for the property 'Region' 
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
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}
