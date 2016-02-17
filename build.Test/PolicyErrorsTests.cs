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
    public class PolicyErrorsTests
    {
        private PolicyErrors instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PolicyErrors();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PolicyErrors
        /// </summary>
        [Test]
        public void PolicyErrorsInstanceTest()
        {
            Assert.IsInstanceOf<PolicyErrors> (instance, "instance is a PolicyErrors");
        }

        
        /// <summary>
        /// Test the property 'PolicyErrorMessages' 
        /// </summary>
        [Test]
        public void PolicyErrorMessagesTest()
        {
            // TODO: unit test for the property 'PolicyErrorMessages' 
        }
        

    }

}