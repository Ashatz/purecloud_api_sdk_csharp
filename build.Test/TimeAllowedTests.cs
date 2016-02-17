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
    public class TimeAllowedTests
    {
        private TimeAllowed instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TimeAllowed();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TimeAllowed
        /// </summary>
        [Test]
        public void TimeAllowedInstanceTest()
        {
            Assert.IsInstanceOf<TimeAllowed> (instance, "instance is a TimeAllowed");
        }

        
        /// <summary>
        /// Test the property 'TimeSlots' 
        /// </summary>
        [Test]
        public void TimeSlotsTest()
        {
            // TODO: unit test for the property 'TimeSlots' 
        }
        
        /// <summary>
        /// Test the property 'TimeZoneId' 
        /// </summary>
        [Test]
        public void TimeZoneIdTest()
        {
            // TODO: unit test for the property 'TimeZoneId' 
        }
        
        /// <summary>
        /// Test the property 'Empty' 
        /// </summary>
        [Test]
        public void EmptyTest()
        {
            // TODO: unit test for the property 'Empty' 
        }
        

    }

}
