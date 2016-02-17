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
    public class SessionRequestTests
    {
        private SessionRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SessionRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SessionRequest
        /// </summary>
        [Test]
        public void SessionRequestInstanceTest()
        {
            Assert.IsInstanceOf<SessionRequest> (instance, "instance is a SessionRequest");
        }

        
        /// <summary>
        /// Test the property 'MinutesToLive' 
        /// </summary>
        [Test]
        public void MinutesToLiveTest()
        {
            // TODO: unit test for the property 'MinutesToLive' 
        }
        

    }

}
