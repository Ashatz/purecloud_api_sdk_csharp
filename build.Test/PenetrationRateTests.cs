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
    ///  Class for testing PenetrationRate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PenetrationRateTests
    {
        private PenetrationRate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PenetrationRate();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PenetrationRate
        /// </summary>
        [Test]
        public void PenetrationRateInstanceTest()
        {
            Assert.IsInstanceOf<PenetrationRate> (instance, "instance is a PenetrationRate");
        }

        
        /// <summary>
        /// Test the property 'NumberOfContactsCalled' 
        /// </summary>
        [Test]
        public void NumberOfContactsCalledTest()
        {
            // TODO: unit test for the property 'NumberOfContactsCalled' 
        }
        
        /// <summary>
        /// Test the property 'TotalNumberOfContacts' 
        /// </summary>
        [Test]
        public void TotalNumberOfContactsTest()
        {
            // TODO: unit test for the property 'TotalNumberOfContacts' 
        }
        
        /// <summary>
        /// Test the property 'Percentage' 
        /// </summary>
        [Test]
        public void PercentageTest()
        {
            // TODO: unit test for the property 'Percentage' 
        }
        
        /// <summary>
        /// Test the property 'PenetrationRateId' 
        /// </summary>
        [Test]
        public void PenetrationRateIdTest()
        {
            // TODO: unit test for the property 'PenetrationRateId' 
        }
        

    }

}
