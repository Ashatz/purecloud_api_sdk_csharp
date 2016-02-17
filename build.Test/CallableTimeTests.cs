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
    public class CallableTimeTests
    {
        private CallableTime instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CallableTime();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CallableTime
        /// </summary>
        [Test]
        public void CallableTimeInstanceTest()
        {
            Assert.IsInstanceOf<CallableTime> (instance, "instance is a CallableTime");
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
        

    }

}
