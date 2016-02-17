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
    public class MaxParticipantsTests
    {
        private MaxParticipants instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MaxParticipants();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of MaxParticipants
        /// </summary>
        [Test]
        public void MaxParticipantsInstanceTest()
        {
            Assert.IsInstanceOf<MaxParticipants> (instance, "instance is a MaxParticipants");
        }

        
        /// <summary>
        /// Test the property '_MaxParticipants' 
        /// </summary>
        [Test]
        public void _MaxParticipantsTest()
        {
            // TODO: unit test for the property '_MaxParticipants' 
        }
        

    }

}
