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
    public class CallRecordTests
    {
        private CallRecord instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CallRecord();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CallRecord
        /// </summary>
        [Test]
        public void CallRecordInstanceTest()
        {
            Assert.IsInstanceOf<CallRecord> (instance, "instance is a CallRecord");
        }

        
        /// <summary>
        /// Test the property 'LastAttempt' 
        /// </summary>
        [Test]
        public void LastAttemptTest()
        {
            // TODO: unit test for the property 'LastAttempt' 
        }
        
        /// <summary>
        /// Test the property 'LastResult' 
        /// </summary>
        [Test]
        public void LastResultTest()
        {
            // TODO: unit test for the property 'LastResult' 
        }
        

    }

}
