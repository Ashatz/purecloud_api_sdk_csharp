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
    public class TimeZoneTests
    {
        private TimeZone instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TimeZone();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TimeZone
        /// </summary>
        [Test]
        public void TimeZoneInstanceTest()
        {
            Assert.IsInstanceOf<TimeZone> (instance, "instance is a TimeZone");
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
        /// Test the property 'StandardOffset' 
        /// </summary>
        [Test]
        public void StandardOffsetTest()
        {
            // TODO: unit test for the property 'StandardOffset' 
        }
        
        /// <summary>
        /// Test the property 'Offset' 
        /// </summary>
        [Test]
        public void OffsetTest()
        {
            // TODO: unit test for the property 'Offset' 
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
