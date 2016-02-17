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
    public class FaxSummaryTests
    {
        private FaxSummary instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FaxSummary();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FaxSummary
        /// </summary>
        [Test]
        public void FaxSummaryInstanceTest()
        {
            Assert.IsInstanceOf<FaxSummary> (instance, "instance is a FaxSummary");
        }

        
        /// <summary>
        /// Test the property 'ReadCount' 
        /// </summary>
        [Test]
        public void ReadCountTest()
        {
            // TODO: unit test for the property 'ReadCount' 
        }
        
        /// <summary>
        /// Test the property 'UnreadCount' 
        /// </summary>
        [Test]
        public void UnreadCountTest()
        {
            // TODO: unit test for the property 'UnreadCount' 
        }
        
        /// <summary>
        /// Test the property 'TotalCount' 
        /// </summary>
        [Test]
        public void TotalCountTest()
        {
            // TODO: unit test for the property 'TotalCount' 
        }
        

    }

}
