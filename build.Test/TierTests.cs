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
    public class TierTests
    {
        private Tier instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Tier();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Tier
        /// </summary>
        [Test]
        public void TierInstanceTest()
        {
            Assert.IsInstanceOf<Tier> (instance, "instance is a Tier");
        }

        
        /// <summary>
        /// Test the property 'Currency' 
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO: unit test for the property 'Currency' 
        }
        
        /// <summary>
        /// Test the property 'Price' 
        /// </summary>
        [Test]
        public void PriceTest()
        {
            // TODO: unit test for the property 'Price' 
        }
        

    }

}
