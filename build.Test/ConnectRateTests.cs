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
    public class ConnectRateTests
    {
        private ConnectRate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConnectRate();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ConnectRate
        /// </summary>
        [Test]
        public void ConnectRateInstanceTest()
        {
            Assert.IsInstanceOf<ConnectRate> (instance, "instance is a ConnectRate");
        }

        
        /// <summary>
        /// Test the property 'Attempts' 
        /// </summary>
        [Test]
        public void AttemptsTest()
        {
            // TODO: unit test for the property 'Attempts' 
        }
        
        /// <summary>
        /// Test the property 'Connects' 
        /// </summary>
        [Test]
        public void ConnectsTest()
        {
            // TODO: unit test for the property 'Connects' 
        }
        
        /// <summary>
        /// Test the property 'ConnectRatio' 
        /// </summary>
        [Test]
        public void ConnectRatioTest()
        {
            // TODO: unit test for the property 'ConnectRatio' 
        }
        

    }

}
