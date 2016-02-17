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
    public class PhonesRebootTests
    {
        private PhonesReboot instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PhonesReboot();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PhonesReboot
        /// </summary>
        [Test]
        public void PhonesRebootInstanceTest()
        {
            Assert.IsInstanceOf<PhonesReboot> (instance, "instance is a PhonesReboot");
        }

        
        /// <summary>
        /// Test the property 'PhoneIds' 
        /// </summary>
        [Test]
        public void PhoneIdsTest()
        {
            // TODO: unit test for the property 'PhoneIds' 
        }
        

    }

}
