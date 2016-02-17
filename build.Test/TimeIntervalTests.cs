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
    public class TimeIntervalTests
    {
        private TimeInterval instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TimeInterval();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TimeInterval
        /// </summary>
        [Test]
        public void TimeIntervalInstanceTest()
        {
            Assert.IsInstanceOf<TimeInterval> (instance, "instance is a TimeInterval");
        }

        
        /// <summary>
        /// Test the property 'Days' 
        /// </summary>
        [Test]
        public void DaysTest()
        {
            // TODO: unit test for the property 'Days' 
        }
        
        /// <summary>
        /// Test the property 'Hours' 
        /// </summary>
        [Test]
        public void HoursTest()
        {
            // TODO: unit test for the property 'Hours' 
        }
        

    }

}
