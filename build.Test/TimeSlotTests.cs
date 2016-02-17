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
    public class TimeSlotTests
    {
        private TimeSlot instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TimeSlot();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TimeSlot
        /// </summary>
        [Test]
        public void TimeSlotInstanceTest()
        {
            Assert.IsInstanceOf<TimeSlot> (instance, "instance is a TimeSlot");
        }

        
        /// <summary>
        /// Test the property 'StartTime' 
        /// </summary>
        [Test]
        public void StartTimeTest()
        {
            // TODO: unit test for the property 'StartTime' 
        }
        
        /// <summary>
        /// Test the property 'StopTime' 
        /// </summary>
        [Test]
        public void StopTimeTest()
        {
            // TODO: unit test for the property 'StopTime' 
        }
        
        /// <summary>
        /// Test the property 'Day' 
        /// </summary>
        [Test]
        public void DayTest()
        {
            // TODO: unit test for the property 'Day' 
        }
        

    }

}
