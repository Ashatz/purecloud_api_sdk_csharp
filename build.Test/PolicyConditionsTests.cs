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
    public class PolicyConditionsTests
    {
        private PolicyConditions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PolicyConditions();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PolicyConditions
        /// </summary>
        [Test]
        public void PolicyConditionsInstanceTest()
        {
            Assert.IsInstanceOf<PolicyConditions> (instance, "instance is a PolicyConditions");
        }

        
        /// <summary>
        /// Test the property 'ForUsers' 
        /// </summary>
        [Test]
        public void ForUsersTest()
        {
            // TODO: unit test for the property 'ForUsers' 
        }
        
        /// <summary>
        /// Test the property 'Directions' 
        /// </summary>
        [Test]
        public void DirectionsTest()
        {
            // TODO: unit test for the property 'Directions' 
        }
        
        /// <summary>
        /// Test the property 'DateRanges' 
        /// </summary>
        [Test]
        public void DateRangesTest()
        {
            // TODO: unit test for the property 'DateRanges' 
        }
        
        /// <summary>
        /// Test the property 'MediaTypes' 
        /// </summary>
        [Test]
        public void MediaTypesTest()
        {
            // TODO: unit test for the property 'MediaTypes' 
        }
        
        /// <summary>
        /// Test the property 'ForQueues' 
        /// </summary>
        [Test]
        public void ForQueuesTest()
        {
            // TODO: unit test for the property 'ForQueues' 
        }
        
        /// <summary>
        /// Test the property 'Duration' 
        /// </summary>
        [Test]
        public void DurationTest()
        {
            // TODO: unit test for the property 'Duration' 
        }
        
        /// <summary>
        /// Test the property 'WrapupCodes' 
        /// </summary>
        [Test]
        public void WrapupCodesTest()
        {
            // TODO: unit test for the property 'WrapupCodes' 
        }
        
        /// <summary>
        /// Test the property 'TimeAllowed' 
        /// </summary>
        [Test]
        public void TimeAllowedTest()
        {
            // TODO: unit test for the property 'TimeAllowed' 
        }
        

    }

}
