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
    public class ExpansionCriteriumTests
    {
        private ExpansionCriterium instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExpansionCriterium();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ExpansionCriterium
        /// </summary>
        [Test]
        public void ExpansionCriteriumInstanceTest()
        {
            Assert.IsInstanceOf<ExpansionCriterium> (instance, "instance is a ExpansionCriterium");
        }

        
        /// <summary>
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        
        /// <summary>
        /// Test the property 'Threshold' 
        /// </summary>
        [Test]
        public void ThresholdTest()
        {
            // TODO: unit test for the property 'Threshold' 
        }
        

    }

}