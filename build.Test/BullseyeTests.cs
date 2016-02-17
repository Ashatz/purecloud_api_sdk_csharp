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
    public class BullseyeTests
    {
        private Bullseye instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Bullseye();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Bullseye
        /// </summary>
        [Test]
        public void BullseyeInstanceTest()
        {
            Assert.IsInstanceOf<Bullseye> (instance, "instance is a Bullseye");
        }

        
        /// <summary>
        /// Test the property 'Rings' 
        /// </summary>
        [Test]
        public void RingsTest()
        {
            // TODO: unit test for the property 'Rings' 
        }
        

    }

}
