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
    public class LocationTests
    {
        private Location instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Location();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Location
        /// </summary>
        [Test]
        public void LocationInstanceTest()
        {
            Assert.IsInstanceOf<Location> (instance, "instance is a Location");
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
        /// Test the property 'Address' 
        /// </summary>
        [Test]
        public void AddressTest()
        {
            // TODO: unit test for the property 'Address' 
        }
        
        /// <summary>
        /// Test the property 'AddressFields' 
        /// </summary>
        [Test]
        public void AddressFieldsTest()
        {
            // TODO: unit test for the property 'AddressFields' 
        }
        
        /// <summary>
        /// Test the property 'AddressVerified' 
        /// </summary>
        [Test]
        public void AddressVerifiedTest()
        {
            // TODO: unit test for the property 'AddressVerified' 
        }
        
        /// <summary>
        /// Test the property 'EmergencyNumber' 
        /// </summary>
        [Test]
        public void EmergencyNumberTest()
        {
            // TODO: unit test for the property 'EmergencyNumber' 
        }
        
        /// <summary>
        /// Test the property 'Notes' 
        /// </summary>
        [Test]
        public void NotesTest()
        {
            // TODO: unit test for the property 'Notes' 
        }
        
        /// <summary>
        /// Test the property 'Path' 
        /// </summary>
        [Test]
        public void PathTest()
        {
            // TODO: unit test for the property 'Path' 
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
        /// Test the property 'SublocationOrder' 
        /// </summary>
        [Test]
        public void SublocationOrderTest()
        {
            // TODO: unit test for the property 'SublocationOrder' 
        }
        
        /// <summary>
        /// Test the property 'Version' 
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO: unit test for the property 'Version' 
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
