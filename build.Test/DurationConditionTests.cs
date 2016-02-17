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
    public class DurationConditionTests
    {
        private DurationCondition instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DurationCondition();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DurationCondition
        /// </summary>
        [Test]
        public void DurationConditionInstanceTest()
        {
            Assert.IsInstanceOf<DurationCondition> (instance, "instance is a DurationCondition");
        }

        
        /// <summary>
        /// Test the property 'DurationTarget' 
        /// </summary>
        [Test]
        public void DurationTargetTest()
        {
            // TODO: unit test for the property 'DurationTarget' 
        }
        
        /// <summary>
        /// Test the property 'DurationOperator' 
        /// </summary>
        [Test]
        public void DurationOperatorTest()
        {
            // TODO: unit test for the property 'DurationOperator' 
        }
        
        /// <summary>
        /// Test the property 'DurationRange' 
        /// </summary>
        [Test]
        public void DurationRangeTest()
        {
            // TODO: unit test for the property 'DurationRange' 
        }
        

    }

}