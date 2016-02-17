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
    public class PutManagementUnitTests
    {
        private PutManagementUnit instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PutManagementUnit();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PutManagementUnit
        /// </summary>
        [Test]
        public void PutManagementUnitInstanceTest()
        {
            Assert.IsInstanceOf<PutManagementUnit> (instance, "instance is a PutManagementUnit");
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
        

    }

}
