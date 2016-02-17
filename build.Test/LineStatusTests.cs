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
    public class LineStatusTests
    {
        private LineStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LineStatus();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of LineStatus
        /// </summary>
        [Test]
        public void LineStatusInstanceTest()
        {
            Assert.IsInstanceOf<LineStatus> (instance, "instance is a LineStatus");
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
        /// Test the property 'Reachable' 
        /// </summary>
        [Test]
        public void ReachableTest()
        {
            // TODO: unit test for the property 'Reachable' 
        }
        
        /// <summary>
        /// Test the property 'AddressOfRecord' 
        /// </summary>
        [Test]
        public void AddressOfRecordTest()
        {
            // TODO: unit test for the property 'AddressOfRecord' 
        }
        
        /// <summary>
        /// Test the property 'ContactAddresses' 
        /// </summary>
        [Test]
        public void ContactAddressesTest()
        {
            // TODO: unit test for the property 'ContactAddresses' 
        }
        
        /// <summary>
        /// Test the property 'ReachableStateTime' 
        /// </summary>
        [Test]
        public void ReachableStateTimeTest()
        {
            // TODO: unit test for the property 'ReachableStateTime' 
        }
        

    }

}
