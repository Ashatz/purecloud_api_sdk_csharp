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
    public class ManagementUnitTimezoneTests
    {
        private ManagementUnitTimezone instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ManagementUnitTimezone();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ManagementUnitTimezone
        /// </summary>
        [Test]
        public void ManagementUnitTimezoneInstanceTest()
        {
            Assert.IsInstanceOf<ManagementUnitTimezone> (instance, "instance is a ManagementUnitTimezone");
        }

        
        /// <summary>
        /// Test the property 'Timezone' 
        /// </summary>
        [Test]
        public void TimezoneTest()
        {
            // TODO: unit test for the property 'Timezone' 
        }
        

    }

}
