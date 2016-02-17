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
    public class TraceListTests
    {
        private TraceList instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TraceList();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TraceList
        /// </summary>
        [Test]
        public void TraceListInstanceTest()
        {
            Assert.IsInstanceOf<TraceList> (instance, "instance is a TraceList");
        }

        
        /// <summary>
        /// Test the property 'App' 
        /// </summary>
        [Test]
        public void AppTest()
        {
            // TODO: unit test for the property 'App' 
        }
        
        /// <summary>
        /// Test the property 'Traces' 
        /// </summary>
        [Test]
        public void TracesTest()
        {
            // TODO: unit test for the property 'Traces' 
        }
        

    }

}
