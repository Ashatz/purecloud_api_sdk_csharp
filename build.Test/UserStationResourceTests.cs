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
    public class UserStationResourceTests
    {
        private UserStationResource instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserStationResource();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UserStationResource
        /// </summary>
        [Test]
        public void UserStationResourceInstanceTest()
        {
            Assert.IsInstanceOf<UserStationResource> (instance, "instance is a UserStationResource");
        }

        
        /// <summary>
        /// Test the property 'UserId' 
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO: unit test for the property 'UserId' 
        }
        
        /// <summary>
        /// Test the property 'StationId' 
        /// </summary>
        [Test]
        public void StationIdTest()
        {
            // TODO: unit test for the property 'StationId' 
        }
        
        /// <summary>
        /// Test the property 'StationName' 
        /// </summary>
        [Test]
        public void StationNameTest()
        {
            // TODO: unit test for the property 'StationName' 
        }
        
        /// <summary>
        /// Test the property 'LocationId' 
        /// </summary>
        [Test]
        public void LocationIdTest()
        {
            // TODO: unit test for the property 'LocationId' 
        }
        
        /// <summary>
        /// Test the property 'Provider' 
        /// </summary>
        [Test]
        public void ProviderTest()
        {
            // TODO: unit test for the property 'Provider' 
        }
        
        /// <summary>
        /// Test the property 'AddressGroup' 
        /// </summary>
        [Test]
        public void AddressGroupTest()
        {
            // TODO: unit test for the property 'AddressGroup' 
        }
        
        /// <summary>
        /// Test the property 'UserUri' 
        /// </summary>
        [Test]
        public void UserUriTest()
        {
            // TODO: unit test for the property 'UserUri' 
        }
        
        /// <summary>
        /// Test the property 'StationUri' 
        /// </summary>
        [Test]
        public void StationUriTest()
        {
            // TODO: unit test for the property 'StationUri' 
        }
        
        /// <summary>
        /// Test the property 'DefaultStation' 
        /// </summary>
        [Test]
        public void DefaultStationTest()
        {
            // TODO: unit test for the property 'DefaultStation' 
        }
        

    }

}
