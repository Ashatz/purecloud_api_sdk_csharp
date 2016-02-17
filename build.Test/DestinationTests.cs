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
    public class DestinationTests
    {
        private Destination instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Destination();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Destination
        /// </summary>
        [Test]
        public void DestinationInstanceTest()
        {
            Assert.IsInstanceOf<Destination> (instance, "instance is a Destination");
        }

        
        /// <summary>
        /// Test the property 'AccountCodeDigits' 
        /// </summary>
        [Test]
        public void AccountCodeDigitsTest()
        {
            // TODO: unit test for the property 'AccountCodeDigits' 
        }
        
        /// <summary>
        /// Test the property 'PostConnectDigits' 
        /// </summary>
        [Test]
        public void PostConnectDigitsTest()
        {
            // TODO: unit test for the property 'PostConnectDigits' 
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
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
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
        /// Test the property 'QueueId' 
        /// </summary>
        [Test]
        public void QueueIdTest()
        {
            // TODO: unit test for the property 'QueueId' 
        }
        

    }

}
