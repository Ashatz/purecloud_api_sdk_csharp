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
    public class AddressTests
    {
        private Address instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Address();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Address
        /// </summary>
        [Test]
        public void AddressInstanceTest()
        {
            Assert.IsInstanceOf<Address> (instance, "instance is a Address");
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
        /// Test the property 'Street' 
        /// </summary>
        [Test]
        public void StreetTest()
        {
            // TODO: unit test for the property 'Street' 
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
        /// Test the property 'CountryName' 
        /// </summary>
        [Test]
        public void CountryNameTest()
        {
            // TODO: unit test for the property 'CountryName' 
        }
        
        /// <summary>
        /// Test the property 'StateName' 
        /// </summary>
        [Test]
        public void StateNameTest()
        {
            // TODO: unit test for the property 'StateName' 
        }
        
        /// <summary>
        /// Test the property 'PostalCode' 
        /// </summary>
        [Test]
        public void PostalCodeTest()
        {
            // TODO: unit test for the property 'PostalCode' 
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
