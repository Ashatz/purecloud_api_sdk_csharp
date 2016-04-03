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
    /// <summary>
    ///  Class for testing UnreadStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UnreadStatusTests
    {
        private UnreadStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UnreadStatus();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UnreadStatus
        /// </summary>
        [Test]
        public void UnreadStatusInstanceTest()
        {
            Assert.IsInstanceOf<UnreadStatus> (instance, "instance is a UnreadStatus");
        }

        
        /// <summary>
        /// Test the property 'Unread' 
        /// </summary>
        [Test]
        public void UnreadTest()
        {
            // TODO: unit test for the property 'Unread' 
        }
        

    }

}
