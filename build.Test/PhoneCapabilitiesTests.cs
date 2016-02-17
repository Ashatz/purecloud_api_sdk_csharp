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
    public class PhoneCapabilitiesTests
    {
        private PhoneCapabilities instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PhoneCapabilities();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PhoneCapabilities
        /// </summary>
        [Test]
        public void PhoneCapabilitiesInstanceTest()
        {
            Assert.IsInstanceOf<PhoneCapabilities> (instance, "instance is a PhoneCapabilities");
        }

        
        /// <summary>
        /// Test the property 'Provisions' 
        /// </summary>
        [Test]
        public void ProvisionsTest()
        {
            // TODO: unit test for the property 'Provisions' 
        }
        
        /// <summary>
        /// Test the property 'Registers' 
        /// </summary>
        [Test]
        public void RegistersTest()
        {
            // TODO: unit test for the property 'Registers' 
        }
        
        /// <summary>
        /// Test the property 'DualRegisters' 
        /// </summary>
        [Test]
        public void DualRegistersTest()
        {
            // TODO: unit test for the property 'DualRegisters' 
        }
        
        /// <summary>
        /// Test the property 'HardwareIdType' 
        /// </summary>
        [Test]
        public void HardwareIdTypeTest()
        {
            // TODO: unit test for the property 'HardwareIdType' 
        }
        
        /// <summary>
        /// Test the property 'AllowReboot' 
        /// </summary>
        [Test]
        public void AllowRebootTest()
        {
            // TODO: unit test for the property 'AllowReboot' 
        }
        
        /// <summary>
        /// Test the property 'NoRebalance' 
        /// </summary>
        [Test]
        public void NoRebalanceTest()
        {
            // TODO: unit test for the property 'NoRebalance' 
        }
        

    }

}
