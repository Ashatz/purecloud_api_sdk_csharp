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
    public class ServerDateTests
    {
        private ServerDate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ServerDate();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ServerDate
        /// </summary>
        [Test]
        public void ServerDateInstanceTest()
        {
            Assert.IsInstanceOf<ServerDate> (instance, "instance is a ServerDate");
        }

        
        /// <summary>
        /// Test the property 'CurrentDate' 
        /// </summary>
        [Test]
        public void CurrentDateTest()
        {
            // TODO: unit test for the property 'CurrentDate' 
        }
        

    }

}
