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
    public class ManagementUnitTests
    {
        private ManagementUnit instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ManagementUnit();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ManagementUnit
        /// </summary>
        [Test]
        public void ManagementUnitInstanceTest()
        {
            Assert.IsInstanceOf<ManagementUnit> (instance, "instance is a ManagementUnit");
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
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        
        /// <summary>
        /// Test the property 'StartDayOfWeek' 
        /// </summary>
        [Test]
        public void StartDayOfWeekTest()
        {
            // TODO: unit test for the property 'StartDayOfWeek' 
        }
        
        /// <summary>
        /// Test the property 'Timezone' 
        /// </summary>
        [Test]
        public void TimezoneTest()
        {
            // TODO: unit test for the property 'Timezone' 
        }
        
        /// <summary>
        /// Test the property 'Version' 
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO: unit test for the property 'Version' 
        }
        

    }

}
