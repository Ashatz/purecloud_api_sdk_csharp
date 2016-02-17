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
    public class DigitLengthTests
    {
        private DigitLength instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DigitLength();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DigitLength
        /// </summary>
        [Test]
        public void DigitLengthInstanceTest()
        {
            Assert.IsInstanceOf<DigitLength> (instance, "instance is a DigitLength");
        }

        
        /// <summary>
        /// Test the property 'Start' 
        /// </summary>
        [Test]
        public void StartTest()
        {
            // TODO: unit test for the property 'Start' 
        }
        
        /// <summary>
        /// Test the property 'End' 
        /// </summary>
        [Test]
        public void EndTest()
        {
            // TODO: unit test for the property 'End' 
        }
        

    }

}
